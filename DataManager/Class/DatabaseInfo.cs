using System.Data;

namespace DataManager
{
    public class DatabaseInfo
    {
        public DBInfo Current = new DBInfo();
        public DBInfo Target = new DBInfo();
        public struct DBInfo
        {
            public string DBName;
            public string DataDBName;
            public string DataDBPath;
            public string LogDBName;
            public string LogDBPath;
        }

        public DatabaseInfo() {
            Current.DBName = string.Empty;
            Current.DataDBName = string.Empty;
            Current.DataDBPath = string.Empty;
            Current.LogDBName = string.Empty;
            Current.LogDBPath = string.Empty;

            Target.DBName = string.Empty;
            Target.DataDBName = string.Empty;
            Target.DataDBPath = string.Empty;
            Target.LogDBName = string.Empty;
            Target.LogDBPath = string.Empty;
        }

        public DatabaseInfo GetDatabaseInfo(string dbName, ref Sql_Manager sqlManager) {
            Current.DBName = dbName;
            DataTable dataTable = sqlManager.GetDBInfo(dbName);
            if (dataTable != null)
            {
                Current.DataDBName = dataTable.Rows[0]["name"].ToString();
                Current.DataDBPath = dataTable.Rows[0]["filename"].ToString();
                Current.LogDBName = dataTable.Rows[1]["name"].ToString();
                Current.LogDBPath = dataTable.Rows[1]["filename"].ToString();
            }
            return this;
        }

        public void SetTargetDbInfo(string suffix)
        {
            Target.DBName = Current.DBName.Replace(suffix, string.Empty);
            Target.DataDBName = Current.DataDBName.Replace(suffix, string.Empty);
            Target.DataDBPath = Current.DataDBPath.Replace(suffix, string.Empty);
            Target.LogDBName = Current.LogDBName.Replace(suffix, string.Empty);
            Target.LogDBPath = Current.LogDBPath.Replace(suffix, string.Empty);
        }
    }
}
