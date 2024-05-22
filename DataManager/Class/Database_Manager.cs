using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManager
{
    internal class Database_Manager
    {
        public Main.ModifyDBAppendLog ModifyDBAppendLog;
        
        private Log_Manager _LogManager = new Log_Manager();
        private Sql_Manager _SqlManager = null;
        private DatabaseInfo _DatabaseInfo;

        private bool _isAppendLog = false;
        private const string TIME_STAMP_SYMBOL = "#";

        public static bool CheckBackupDB(string dbName)
        {
            return dbName.Contains(TIME_STAMP_SYMBOL);
        }

        public Database_Manager(DatabaseInfo databaseInfo, bool isAppendLog, ref Sql_Manager sqlManager)
        {
            _DatabaseInfo = databaseInfo;
            _isAppendLog = isAppendLog;
            _SqlManager = sqlManager;
        }

        public Tuple<bool, DatabaseInfo> ModifyDatabase()
        {
            if (_isAppendLog)
                _LogManager.AppendMaster("Modify Database", _SqlManager.ServerName);

            string currentDBName = _DatabaseInfo.Current.DBName;

            try
            {
                // 1. 액세스 제한 RESTRICTED_USER로 변경
                SetDBAccess(false);

                // 2. 논리 이름 변경 (DB, LOG)
                string suffix = DateTime.Now.ToString("yyyyMMddHHmmss");
                _DatabaseInfo.Current.DataDBName = SetDBLogicalName(_DatabaseInfo.Current.DataDBName, suffix, _DatabaseInfo.Target.DataDBName);
                _DatabaseInfo.Current.LogDBName = SetDBLogicalName(_DatabaseInfo.Current.LogDBName, suffix, _DatabaseInfo.Target.LogDBName);

                // 3. DB명 변경
                _DatabaseInfo.Current.DBName = SetDBName(_DatabaseInfo.Current.DBName, suffix, _DatabaseInfo.Target.DBName);

                // 4. DB OFFLINE
                SetDBStatus(false);

                // 5. 물리 DB 파일 이름 변경
                _DatabaseInfo.Current.DataDBPath = SetDBPhysicalName(_DatabaseInfo.Current.DataDBPath, suffix, _DatabaseInfo.Target.DataDBPath);
                _DatabaseInfo.Current.LogDBPath = SetDBPhysicalName(_DatabaseInfo.Current.LogDBPath, suffix, _DatabaseInfo.Target.LogDBPath);

                // 6. DB ONLINE
                SetDBStatus(true);

                // 7. 파일 경로 수정
                SetDBPath(_DatabaseInfo.Current.DataDBName, _DatabaseInfo.Current.DataDBPath);
                SetDBPath(_DatabaseInfo.Current.LogDBName, _DatabaseInfo.Current.LogDBPath);
            }
            catch (Exception ex)
            {
                AppendLog(ex.Message, Log.LogType.ALERT);
            }
            finally
            {
                // DB ONLINE
                SetDBStatus(true);

                // DB 액세스 제한 MULTI_USER로 변경
                SetDBAccess(true);
            }

            return new Tuple<bool, DatabaseInfo>(_DatabaseInfo.Current.DBName != currentDBName, _DatabaseInfo);
        }

        private void SetDBAccess(bool isMultiUser)
        {
            AppendLog($"DB Access 제한 변경 : {(isMultiUser ? "MULTI_USER" : "RESTRICED_USER")}");
            _SqlManager.SetDBAccess(_DatabaseInfo.Current.DBName, isMultiUser);
        }

        private void SetDBStatus(bool isOnline)
        {
            AppendLog($"DB State 변경 : {(isOnline ? "ONLINE" : "OFFLINE")}");
            _SqlManager.SetDBStatus(_DatabaseInfo.Current.DBName, isOnline);
        }

        private string SetDBLogicalName(string currentName, string suffix, string targetName = "")
        {
            string newName = targetName == string.Empty ? GetNewName(currentName, suffix) : targetName;
            AppendLog($"DB 논리 파일명 변경 : {currentName} >> {newName}");

            string resultName = _SqlManager.SetDBLogicalName(_DatabaseInfo.Current.DBName, currentName, newName);
            if (resultName != newName)
                throw new Exception("DB 논리 파일명 변경에 실패 했습니다.");
            else
                return resultName;
        }

        private string GetNewName(string currentName, string suffix)
        {
            string sourceName = currentName;
            if (sourceName.IndexOf(TIME_STAMP_SYMBOL) > -1)
                sourceName = sourceName.Substring(0, sourceName.IndexOf(TIME_STAMP_SYMBOL));

            return $"{sourceName}{TIME_STAMP_SYMBOL}{suffix}";
        }

        private string SetDBPhysicalName(string path, string suffix, string targetPath = "")
        {
            string extention = Path.GetExtension(path);
            string fileName = Path.GetFileName(path);
            fileName = fileName.Substring(0, fileName.Length - extention.Length);

            string newFileName = targetPath == string.Empty ? $"{GetNewName(fileName, suffix)}{extention}" : Path.GetFileName(targetPath);
            string newPath = Path.Combine(Path.GetDirectoryName(path), newFileName);

            try
            {
                AppendLog($"DB 물리 파일명 변경 : {Path.GetFileName(path)} >> {newFileName}");

                FileInfo fileInfo = new FileInfo(path);
                fileInfo.MoveTo(newPath);
            }
            catch (Exception ex)
            {
                throw new Exception($"DB 물리 파일명 변경에 실패했습니다. {ex.Message}");
            }

            return newPath;
        }

        private void SetDBPath(string currentName, string path)
        {
            AppendLog($"DB 물리 경로 변경 : {currentName} - {path}");
            _SqlManager.SetDBLogicalPath(_DatabaseInfo.Current.DBName, currentName, path);
        }

        private string SetDBName(string currentName, string suffix, string targetName = "")
        {
            string newName = targetName == string.Empty ? GetNewName(currentName, suffix) : targetName;
            AppendLog($"DB명 변경 : {_DatabaseInfo.Current.DBName} >> {newName}");
            _SqlManager.ChangeDBName(currentName, newName);
            return newName;
        }

        private void AppendLog(string content, Log.LogType logType = Log.LogType.INFO)
        {
            if (_isAppendLog)
            {
                _LogManager.AppendDetail(new Log_Manager.DetailData()
                {
                    LogMessage = content,
                    Result = logType == Log.LogType.ALERT ? "FAIL" : "SUCCESS",
                    ErrorMessage = logType == Log.LogType.ALERT ? content : string.Empty
                });
                ModifyDBAppendLog(content, logType);
            }
        }
    }
}
