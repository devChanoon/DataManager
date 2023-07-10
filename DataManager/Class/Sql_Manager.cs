using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataManager
{
    public class Sql_Manager
    {
        private SqlConnection _SqlConnection = new SqlConnection();
        private SqlCommand _SqlCommand = null;
        private string _ConnectionString = string.Empty;

        private enum DataType { DATA_SET, DATA_TABLE, STRING };
        public string ConnectionString { get { return _ConnectionString; } }

        public bool SqlConnect(string connectionString)
        {
            try
            {
                _ConnectionString = connectionString;
                _SqlConnection.ConnectionString = connectionString;
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand();
                _SqlCommand.Connection = _SqlConnection;

                return true;
            }
            catch (Exception ex)
            {
                _SqlConnection.Close();

                return false;
            }
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

        public DataTable ValidationTableData(string sourceDbName, string tableName)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.ValidationTableData(sourceDbName, tableName));
        }

        public void DeleteTableData(string tablename)
        {
            ExecuteSql(DataType.STRING, Query_Manager.DeleteTableData(tablename));
        }

        public void SetIdentityInsert(string tableName, bool isOn)
        {
            ExecuteSql(DataType.STRING, Query_Manager.SetIdentityInsert(tableName, isOn));
        }

        public DataTable GetColumnList(string tableName)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetColumnList(tableName));
        }

        public DataTable GetTableDataList(string sourceDbName, string tableName, string columnData)
        {
            return ExecuteSql(DataType.DATA_TABLE, Query_Manager.GetTableDataList(sourceDbName, tableName, columnData));
        }

        public string InsertDataToTable(string tableName, string columnData, string valueData, ref string query)
        {
            query = Query_Manager.InsertDataToTable(tableName, columnData, valueData);
            return ExecuteSql(DataType.STRING, query);
        }

        public void InsertDataToTable(string tableName, string columnData, string valueData, Dictionary<string, byte[]> bytesData, ref string query)
        {
            query = Query_Manager.InsertDataToTable(tableName, columnData, valueData);
            using (SqlCommand sqlCommand = new SqlCommand(query, _SqlConnection))
            {
                for (int i = 0; i < bytesData.Count; i++)
                {
                    sqlCommand.Parameters.AddWithValue(string.Format("@BinaryData_{0}", bytesData.Keys.ElementAt(i)), bytesData.Values.ElementAt(i));
                }

                sqlCommand.ExecuteNonQuery();
            }
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