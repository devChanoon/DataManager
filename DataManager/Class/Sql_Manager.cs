using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraLayout.Customization;
using System.Text.RegularExpressions;

namespace DataManager
{
    public class Sql_Manager
    {
        private SqlConnection _SqlConnection = new SqlConnection();
        private SqlCommand _SqlCommand = null;
        private string _ConnectionString = string.Empty;

        private enum DataType { DATA_SET, DATA_TABLE, STRING };
        public string ConnectionString { get { return _ConnectionString; } }
        public string ServerName { get { return GetProperty("Server"); } }
        public string Database { get { return GetProperty("database"); } }

        public static string CreateConnectionString(string dbAddress, string dbName, string userId, string password)
        {   
            return $"Server={dbAddress};database={dbName};uid={userId};pwd={password}";
        }

        public string GetProperty(string propertyName)
        {
            if (_ConnectionString == string.Empty)
                return string.Empty;
            else
            {
                string pattern = propertyName + @"=([^;]+)";
                Match match = Regex.Match(_ConnectionString, pattern);

                if (match.Success)
                    return match.Groups[1].Value;
                else
                    return string.Empty;
            }
        }

        public string SqlConnect(string connectionString)
        {
            string errorMessage = string.Empty;
            try
            {
                _ConnectionString = connectionString;
                _SqlConnection.ConnectionString = connectionString;
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand();
                _SqlCommand.Connection = _SqlConnection;
                _SqlCommand.CommandTimeout = 0;
            }
            catch (Exception ex)
            {
                _SqlConnection.Close();
                errorMessage = ex.Message;
            }

            return errorMessage;
        }
        public bool SqlDisconnect()
        {
            try
            {                
                _SqlConnection.Close();
                _SqlCommand = null;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetDbList(string currentDbName)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetDbList(currentDbName));
        }

        public DataTable GetTableList(string selectedDbName)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetTableList(selectedDbName));
        }

        public DataTable GetForeignKeyList()
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetForeignKeyList());
        }

        public string SetForeignKey(string tableName, string foreignKeyName, bool isCheck)
        {
            return ExecuteSql(DataType.STRING, Query_Manager.SetForeignKey(tableName, foreignKeyName, isCheck));
        }

        public string CheckExistTable(string tableName)
        {
            return ExecuteSql(DataType.STRING, Query_Manager.CheckExistTable(tableName));
        }

        public DataTable ValidationTableData(string sourceDbName, string tableName, string columnData)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.ValidationTableData(sourceDbName, tableName, columnData));
        }

        public void DeleteTableData(string tablename)
        {
            ExecuteSql(DataType.STRING, Query_Manager.DeleteTableData(tablename));
        }

        public DataTable GetColumnList(string sourceDbName, string tableName)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetColumnList(sourceDbName, tableName));
        }

        public DataTable GetTableSchema(string tableName, string columnData)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetTableSchema(tableName, columnData));
        }

        public DataTable GetTableDataList(string sourceDbName, string tableName, string columnData)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetTableDataList(sourceDbName, tableName, columnData));
        }

        public void InsertBulk(string tableName, DataTable dataTable)
        {
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(_SqlConnection, SqlBulkCopyOptions.KeepIdentity | SqlBulkCopyOptions.KeepNulls, null))
            {   
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.BulkCopyTimeout = 0;

                // DataTable의 열과 테이블의 열 매핑
                foreach (DataColumn column in dataTable.Columns)
                {
                    bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                }

                // Bulk insert 실행
                bulkCopy.WriteToServer(dataTable);
            }
        }

        public void ResetIdentity(string tableName)
        {
            ExecuteSql(DataType.DATA_TABLE, Query_Manager.ResetIdentity(tableName));
            ExecuteSql(DataType.DATA_TABLE, Query_Manager.SetIdentityMax(tableName));
        }

        public DataTable GetDBInfo(string currentDbName)
        {
            DataSet dataSet = ExecuteSql(DataType.DATA_SET, Query_Manager.GetDBInfo(currentDbName));
            if (dataSet == null)
                return null;
            else
                return dataSet.Tables[1];
        }

        public void SetDBAccess(string currentDbName, bool isMultiUser)
        {
            ExecuteSql(DataType.STRING, Query_Manager.SetDBAccess(currentDbName, isMultiUser));
        }

        public void SetDBStatus(string currentDbName, bool isOnline)
        {
            ExecuteSql(DataType.STRING, Query_Manager.SetDBStatus(currentDbName, isOnline));
        }

        public string SetDBLogicalName(string currentDbName, string currentName, string newName)
        {
            ExecuteSql(DataType.STRING, Query_Manager.SetDBLogicalName(currentDbName, currentName, newName));
            DataTable dataTable = GetDBInfo(currentDbName);
            bool isChanged = false;
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["name"].ToString() == newName)
                    {
                        isChanged = true;
                        break;
                    }
                }
            }

            return isChanged ? newName : string.Empty;
        }

        public void SetDBLogicalPath(string currentDbName, string name, string path)
        {
            ExecuteSql(DataType.STRING, Query_Manager.SetDBLogicalPath(currentDbName, name, path));
        }

        public void ChangeDBName(string currentDbName, string newName)
        {
            ExecuteSql(DataType.STRING, Query_Manager.ChangeDBName(currentDbName, newName));
        }

        private dynamic ExecuteSql(DataType dataType, string query)
        {
            _SqlCommand.CommandText = query;
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter(_SqlCommand);
                DataSet ds = new DataSet();
                sd.Fill(ds, "Result");

                switch (dataType)
                {
                    case DataType.DATA_SET:
                        {
                            return ds;
                        }
                    case DataType.DATA_TABLE:
                        {
                            if (ds.Tables.Count > 0)
                                return ds.Tables[0];
                            else
                                return null;
                        }
                    case DataType.STRING:
                        {
                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                return ds.Tables[0].Rows[0][0].ToString();
                            else
                                return "";
                        }
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}