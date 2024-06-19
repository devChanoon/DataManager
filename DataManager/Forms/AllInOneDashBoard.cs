using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Web.Administration;
using System.Threading;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace DataManager
{
    public partial class AllInOneDashBoard : Form
    {
        private List<string> _IgnoreFileList = new List<string>
        {
            Main.INI_FILE_NAME,
            "log4net.config"
        };

        private struct ThreadInfo
        {
            public bool IsComplete;
            public List<string> ErrorMessages;
            public string ServerName;
            public string Id;
            public string Password;
            public int ThreadCount;
        }

        private ThreadInfo _SiteThread;
        private ThreadInfo _DbThread;
        private DateTime _StartTime;

        private Log_Manager _LogManager = new Log_Manager();
        private const string PUBLIC_DOCUMENTS_DIRECTORY = "C:\\Users\\Public\\Documents";

        public AllInOneDashBoard(DataTable siteData, DataTable dbData, string serverName, string id, string password, int threadCount)
        {
            InitializeComponent();
            gc_Site.DataSource = GetFilteredDataTable(siteData, "FilePath");
            gc_Database.DataSource = GetFilteredDataTable(dbData, "BackupFilePath");

            _SiteThread = new ThreadInfo { IsComplete = false, ErrorMessages = new List<string>() };
            _DbThread = new ThreadInfo { 
                IsComplete = false, 
                ErrorMessages = new List<string>(), 
                ServerName = serverName, 
                Id = id,
                Password = password,
                ThreadCount = threadCount
            };

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<bool, StringBuilder> result = GetWorkResultMessage();
            StringBuilder sb = result.Item2;
            if (result.Item1)
            {
                if (_SiteThread.ErrorMessages.Count > 0)
                {
                    sb.AppendLine("SITE >>>>>>>>>>>>>>>>>>>>>");
                    foreach (string errorMessage in _SiteThread.ErrorMessages)
                    {
                        sb.AppendLine(errorMessage);
                    }
                }

                if (_DbThread.ErrorMessages.Count > 0)
                {
                    sb.AppendLine("DATABASE >>>>>>>>>>>>>>>>>>>>>");
                    foreach (string errorMessage in _DbThread.ErrorMessages)
                    {
                        sb.AppendLine(errorMessage);
                    }
                }
            }
            else
                FindSiteAndRestart();

            if (DialogResult.OK == MessageBox.Show(sb.ToString(),
                    result.Item1 ? "오류" : "알림", 
                    MessageBoxButtons.OK,
                    result.Item1 ? MessageBoxIcon.Error : MessageBoxIcon.Information))
                thisFormClose();
        }

        private Tuple<bool, StringBuilder> GetWorkResultMessage()
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool existError = _SiteThread.ErrorMessages.Count > 0 || _DbThread.ErrorMessages.Count > 0;
            if (existError)
                stringBuilder.AppendLine("작업 실패 이력이 존재합니다.");
            else
                stringBuilder.AppendLine("작업이 완료되었습니다.");

            double _totalSeconds = DateTime.Now.Subtract(_StartTime).TotalSeconds;
            int hours = (int)(_totalSeconds / 3600);
            _totalSeconds = _totalSeconds % 3600;
            int minutes = (int)(_totalSeconds / 60);
            _totalSeconds = _totalSeconds % 60;
            int seconds = (int)(_totalSeconds);
            stringBuilder.AppendLine(string.Format("소요시간 : {0:D3}:{1:D2}:{2:D2}", hours, minutes, seconds));
            stringBuilder.AppendLine(string.Empty);

            return new Tuple<bool, StringBuilder>(existError, stringBuilder);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _StartTime = DateTime.Now;
            _LogManager.AppendMaster("All In One", _DbThread.ServerName);

            Thread siteThread = new Thread(new ThreadStart(ExecuteSite));
            siteThread.Start();

            Thread dbThread = new Thread(new ThreadStart(ExecuteDB));
            dbThread.Start();

            // 둘 다 작업이 끝날때까지 대기
            while (!_SiteThread.IsComplete || !_DbThread.IsComplete) { }
        }

        private void thisFormClose()
        {
            if (this.InvokeRequired)
            {
                Action close = delegate { thisFormClose(); };
                this.Invoke(close);
            }
            else
                this.Close();
        }

        private DataTable GetFilteredDataTable(DataTable dataTable, string checkFieldName)
        {
            var fileteredRows = dataTable.AsEnumerable().Where(row => row[checkFieldName].ToString() != string.Empty);
            DataTable newDataSource = fileteredRows.Any() ? fileteredRows.CopyToDataTable() : dataTable.Clone();

            string fieldName = "Status";
            newDataSource.Columns.Add(fieldName, typeof(string));
            foreach (DataRow row in newDataSource.Rows)
            {
                row[fieldName] = string.Empty;
            }
            return newDataSource;
        }

        private DataTable GetDataSource(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            return gridView.GridControl.DataSource as DataTable;
        }

        private void FindSiteAndRestart()
        {
            DataTable dataTable = GetDataSource(gv_Site);
            var filteredTable = dataTable.AsEnumerable().Where(row => row["SiteName"].ToString() != Main.NOT_EXIST_IIS);
            dataTable = filteredTable.Any() ? filteredTable.CopyToDataTable() : dataTable.Clone();

            if (dataTable.Rows.Count > 0)
            { 
                ServerManager serverManager = new ServerManager();
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (Site site in serverManager.Sites)
                    {
                        if (site.Name == row["SiteName"].ToString())
                        {
                            site.Stop();
                            site.Start();
                            break;
                        }
                    }
                }
            }
        }

        private void SetFocusedRowHandle(DevExpress.XtraGrid.Views.Grid.GridView gridView, int index)
        {
            if (gridView.GridControl.InvokeRequired)
            {
                Action setFocusedRowHandle = delegate { SetFocusedRowHandle(gridView, index); };
                gridView.GridControl.Invoke(setFocusedRowHandle);
            }
            else
                gridView.FocusedRowHandle = index;
        }

        private void SetRowCellValue(DevExpress.XtraGrid.Views.Grid.GridView gridView, int rowHandle, string fieldName, string value)
        {
            if (gridView.GridControl.InvokeRequired)
            {
                Action setRowCellValue = delegate { SetRowCellValue(gridView, rowHandle, fieldName, value); };
                gridView.GridControl.Invoke(setRowCellValue);
            }
            else
                gridView.SetRowCellValue(rowHandle, fieldName, value);
        }

        #region ExecuteSite
        private void ExecuteSite()
        {
            DataTable dataTable = GetDataSource(gv_Site);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                SetFocusedRowHandle(gv_Site, i);

                Log_Manager.SiteData siteData = new Log_Manager.SiteData
                {
                    SiteName = dataTable.Rows[i]["SiteName"].ToString(),
                    Path = dataTable.Rows[i]["Path"].ToString(),
                    FilePath = dataTable.Rows[i]["FilePath"].ToString(),
                    Result = "Success",
                    ErrorMessage = string.Empty
                };

                string status = "N";
                try
                {
                    // 1. 기존 배포파일 압축하여 백업
                    DisplaySiteStatus("기존 파일 압축하는 중...");
                    Compression_Manager.CompressionFolder(siteData.Path, GetFilePath(siteData.Path));

                    // 2. 신규 배포 파일 압축 풀기
                    DisplaySiteStatus("신규 파일 압축 푸는 중...");
                    string filePath = GetPath(siteData.FilePath.Replace(Path.GetExtension(siteData.FilePath), string.Empty));
                    Compression_Manager.DecompressionFile(siteData.FilePath, filePath);

                    // 3. 압축 해제한 파일들을 기존 경로로 복사
                    CopyFiles(filePath, siteData.Path);

                    // 4. 복사 후 폴더 삭제
                    DisplaySiteStatus("정리하는 중...");
                    Directory.Delete(filePath, true);

                    status = "Y";
                }
                catch (Exception e)
                {   
                    _SiteThread.ErrorMessages.Add($"{siteData.SiteName} >> {e.Message}");

                    siteData.Result = "Fail";
                    siteData.ErrorMessage = e.Message;
                }
                SetRowCellValue(gv_Site, i, "Status", status);
                _LogManager.AppendDetail(siteData);
            }

            _SiteThread.IsComplete = true;
            DisplaySiteStatus("완료");
        }

        private void DisplaySiteStatus(string content)
        {
            if (lc_SiteStatus.InvokeRequired)
            {
                Action displaySiteStatus = delegate { DisplaySiteStatus(content); };
                lc_SiteStatus.Invoke(displaySiteStatus);
            }
            else
            {
                lc_SiteStatus.Text = content;
                if (content.Equals("완료"))
                { 
                    lc_SiteStatus.BackColor = System.Drawing.Color.Green;
                    lc_SiteStatus.ImageOptions.Image = null;
                }
            }
        }

        private void DisplayDatabaseStatus(string content)
        {
            if (lc_DatabaseStatus.InvokeRequired)
            {
                Action displayDatabaseStatus = delegate { DisplayDatabaseStatus(content); };
                lc_DatabaseStatus.Invoke(displayDatabaseStatus);
            }
            else
            {
                lc_DatabaseStatus.Text = content;
                if (content.Equals("완료"))
                {
                    lc_DatabaseStatus.BackColor = System.Drawing.Color.Green;
                    lc_DatabaseStatus.ImageOptions.Image = null;
                }
            }
        }

        private string GetPath(string path)
        {
            string newPath = path;
            int duplicateIndex = 2;
            while (Directory.Exists(newPath))
            {
                newPath = $"{path} ({duplicateIndex++})";
            }
            return newPath;
        }

        private string GetFilePath(string path)
        {
            string fileName = $"{Path.GetFileName(path)}_{DateTime.Now.ToString("yyyyMMdd")}";
            string parentFolderPath = Path.GetDirectoryName(path);
            string newPath = Path.Combine(parentFolderPath, $"{fileName}.zip");
            int duplicateIndex = 2;
            while (File.Exists(newPath))
            {
                newPath = Path.Combine(parentFolderPath, $"{fileName} ({duplicateIndex++}).zip");
            }
            return newPath;
        }
        private void CopyFiles(string sourcePath, string targetPath)
        {
            DisplaySiteStatus("신규 배포 파일 기존 폴더에 덮어쓰는 중...");

            string[] files = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);
            // 각 파일을 목적지 디렉토리로 복사합니다.
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (_IgnoreFileList.Contains(fileName))
                    continue;

                // 파일 이름만 추출하여 목적지 경로에 추가합니다.
                string destinationFile = file.Replace(sourcePath, targetPath);

                XElement rewriteSection = null;
                if (fileName.ToLower() == "web.config")
                    rewriteSection = GetRewriteSection(destinationFile);

                // 파일을 덮어쓰기 위해 복사합니다.
                File.Copy(file, destinationFile, true);

                if (rewriteSection != null)
                    SetRewriteSection(destinationFile, rewriteSection);
            }
        }

        private XElement GetRewriteSection(string filePath)
        {
            XElement rewriteSection = null;
            if (File.Exists(filePath))
            { 
                XDocument webConfig = XDocument.Load(filePath);
                rewriteSection = webConfig.Descendants("rewrite").FirstOrDefault();
            }

            return rewriteSection;
        }

        private void SetRewriteSection(string filePath, XElement rewriteSection)
        {
            XDocument webConfig = XDocument.Load(filePath);
            XElement oldRewriteSection = webConfig.Descendants("rewrite").FirstOrDefault();
            if (oldRewriteSection != null)
                oldRewriteSection.ReplaceWith(rewriteSection);
            else
                webConfig.Descendants("system.webServer").FirstOrDefault().Add(rewriteSection);

            webConfig.Save(filePath);
        }
        #endregion

        private void ExecuteDB()
        {
            DataTable dataTable = GetDataSource(gv_Database);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                SetFocusedRowHandle(gv_Database, i);

                string status = "N";

                Log_Manager.DatabaseData databaseData = new Log_Manager.DatabaseData
                {
                    DatabaseName = dataTable.Rows[i]["DBName"].ToString(),
                    BackupFilePath = dataTable.Rows[i]["BackupFilePath"].ToString(),
                    Result = "Success",
                    ErrorMessage = string.Empty
                };

                DatabaseInfo BackupDbInfo = null;
                DatabaseInfo tempDbDatabaseInfo = null;
                try
                {
                    // 1. 기존 DB -> 백업 DB로 변경 (Database_Manager)
                    DisplayDatabaseStatus("기존 DB를 백업 DB로 변경하는 중...");
                    Tuple<string, DatabaseInfo> result = BackupCurrentDatabase(databaseData.DatabaseName);
                    if (result.Item1 != string.Empty)
                        throw new Exception(result.Item1);
                    else
                        BackupDbInfo = result.Item2;

                    // 2. tempDbName으로 복원 (기존 DB에 데이터 insert 방지)
                    DisplayDatabaseStatus("백업 파일로 임시 DB 복원하는 중...");
                    tempDbDatabaseInfo = RestoreDatabase(BackupDbInfo, databaseData.DatabaseName, databaseData.BackupFilePath);

                    // 3. 데이터 복사 (CopyData)
                    DisplayDatabaseStatus("백업 DB에서 임시 DB로 데이터 복사하는 중...");
                    Tuple<string, Sql_Manager> copyResult = CopyDataBackupToCurrent(tempDbDatabaseInfo.Current.DBName, BackupDbInfo);
                    if (copyResult.Item1 != string.Empty)
                    {
                        throw new Exception(copyResult.Item1);
                    }

                    // 4. tempDbName -> dbName으로 변경 (Database_Manager)
                    DisplayDatabaseStatus("임시 DB를 기존 DB로 변경하는 중...");
                    ModifyDatabase(tempDbDatabaseInfo, copyResult.Item2);

                    status = "Y";
                }
                catch (Exception e)
                {
                    if (BackupDbInfo != null)
                    { 
                        // 오류 발생시 백업 DB를 기존 DB로 변경
                        DisplayDatabaseStatus("오류 발생 >> 백업 DB를 기존 DB로 변경하는 중...");
                        BackupDbInfo.SetTargetDbInfo();

                        Sql_Manager sqlManager = new Sql_Manager();
                        sqlManager.SqlConnect(Sql_Manager.CreateConnectionString(_DbThread.ServerName, BackupDbInfo.Current.DBName, _DbThread.Id, _DbThread.Password));
                        ModifyDatabase(BackupDbInfo, sqlManager);
                        sqlManager.SqlDisconnect();
                    }

                    if (tempDbDatabaseInfo != null)
                    {
                        // 오류 발생한 임시 DB 삭제
                        Sql_Manager sqlManager = new Sql_Manager();
                        sqlManager.SqlConnect(Sql_Manager.CreateConnectionString(_DbThread.ServerName, "master", _DbThread.Id, _DbThread.Password));
                        DisplayDatabaseStatus("오류 발생 >> 임시 DB 삭제하는 중...");
                        DropDatabase(tempDbDatabaseInfo, sqlManager);
                        sqlManager.SqlDisconnect();
                    }
                    _DbThread.ErrorMessages.Add($"{databaseData.DatabaseName} >> {e.Message}");

                    databaseData.Result = "Fail";
                    databaseData.ErrorMessage = e.Message;
                }
                SetRowCellValue(gv_Database, i, "Status", status);
                _LogManager.AppendDetail(databaseData);
            }

            _DbThread.IsComplete = true;
            DisplayDatabaseStatus("완료");
        }

        private Tuple<string, DatabaseInfo> BackupCurrentDatabase(string dbName)
        {
            string errorMessage = string.Empty;
            DatabaseInfo databaseInfo = null;
            Sql_Manager sqlManager = new Sql_Manager();
            try
            {
                sqlManager.SqlConnect(Sql_Manager.CreateConnectionString(_DbThread.ServerName, dbName, _DbThread.Id, _DbThread.Password));
                databaseInfo = new DatabaseInfo().GetDatabaseInfo(dbName, ref sqlManager);
                Database_Manager databaseManager = new Database_Manager(databaseInfo, false, ref sqlManager);
                Tuple<bool, DatabaseInfo> modifyResult = databaseManager.ModifyDatabase();
                if (!modifyResult.Item1)
                    throw new Exception("기존 DB 변경 실패");
                else
                    databaseInfo = modifyResult.Item2;
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { sqlManager.SqlDisconnect(); }

            return new Tuple<string, DatabaseInfo>(errorMessage, databaseInfo);
        }

        private DatabaseInfo RestoreDatabase(DatabaseInfo databaseInfo, string dbName, string backupFilePath)
        {
            string dataPath = Path.GetDirectoryName(databaseInfo.Current.DataDBPath);

            // DB 옮기기
            string tempBackupFilePath = $"{PUBLIC_DOCUMENTS_DIRECTORY}\\{Path.GetFileName(backupFilePath)}";
            File.Copy(backupFilePath, tempBackupFilePath, true);

            Tuple<string, string> originDatabase = GetOriginalDatabaseNameFromBackupFile(tempBackupFilePath);
            string suffix = $"_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}";
            string tempDbName = $"{dbName}{suffix}";
            DatabaseInfo tempDbDatabaseInfo = RestoreDatabase(tempBackupFilePath, _DbThread.ServerName, originDatabase.Item1, originDatabase.Item2, tempDbName, dataPath);
            tempDbDatabaseInfo.SetTargetDbInfo(suffix);

            // DB 옮긴 후 파일 삭제
            File.Delete(tempBackupFilePath);

            return tempDbDatabaseInfo;
        }

        private Tuple<string, Sql_Manager> CopyDataBackupToCurrent(string tempDbName, DatabaseInfo backupDbInfo)
        {
            Sql_Manager sqlManager = new Sql_Manager();
            sqlManager.SqlConnect(Sql_Manager.CreateConnectionString(_DbThread.ServerName, tempDbName, _DbThread.Id, _DbThread.Password));
            List<string> tableList = new List<string>();
            foreach (DataRow dataRow in sqlManager.GetTableList(backupDbInfo.Current.DBName).Rows)
            {
                tableList.Add(dataRow["table_name"].ToString());
            }

            copyData.Initialize(tableList, backupDbInfo.Current.DBName, _DbThread.ThreadCount, ref sqlManager, false);
            while (!copyData.IsEnd) { }
            if (copyData.ErrorMessage != string.Empty)
                sqlManager.SqlDisconnect();

            return new Tuple<string, Sql_Manager>(copyData.ErrorMessage, sqlManager);
        }

        private void ModifyDatabase(DatabaseInfo tempDbDatabaseInfo, Sql_Manager sqlManager)
        {
            Database_Manager databaseManager = new Database_Manager(tempDbDatabaseInfo, false, ref sqlManager);
            Tuple<bool, DatabaseInfo> modifyResult = databaseManager.ModifyDatabase();
            if (!modifyResult.Item1)
                throw new Exception("DB 변경 실패");
        }

        private void DropDatabase(DatabaseInfo databaseInfo, Sql_Manager sqlManager)
        {
            sqlManager.DropDatabase(databaseInfo.Current.DBName);
        }

        public Tuple<string, string> GetOriginalDatabaseNameFromBackupFile(string backupFilePath)
        {
            // Create a restore object and set the backup device
            Restore restore = new Restore();
            restore.Devices.AddDevice(backupFilePath, DeviceType.File);

            // Read the backup header to get the database name
            var fileList = restore.ReadFileList(new Server());
            return new Tuple<string, string>(fileList.Rows[0][0].ToString(), fileList.Rows[1][0].ToString());
        }

        private DatabaseInfo RestoreDatabase(string backupFilePath, string serverName, string databaseName, string logDatabaseName, string newDatabaseName, string targetDataDirectory)
        {
            DatabaseInfo databaseInfo = new DatabaseInfo();
            databaseInfo.Current.DBName = newDatabaseName;

            // Set up the restore
            Restore restore = new Restore();
            restore.Database = newDatabaseName;
            restore.Action = RestoreActionType.Database;
            restore.Devices.AddDevice(backupFilePath, DeviceType.File);

            // Set up the server connection
            ServerConnection connection = new ServerConnection(serverName);
            connection.LoginSecure = false; // SQL Server 인증 사용
            connection.Login = _DbThread.Id; // 사용자 이름 설정
            connection.Password = _DbThread.Password; // 암호 설정
            Server sqlServer = new Server(connection);

            // Define the new data and log file locations
            string newPath = $"{targetDataDirectory}\\{newDatabaseName}";
            string newDataFilePath = $"{newPath}.mdf";
            string newLogFilePath = $"{newPath}_log.ldf";

            RelocateFile dataFile = new RelocateFile();
            dataFile.LogicalFileName = databaseName;
            dataFile.PhysicalFileName = newDataFilePath;

            databaseInfo.Current.DataDBName = databaseName;
            databaseInfo.Current.DataDBPath = newDataFilePath;

            RelocateFile logFile = new RelocateFile();
            logFile.LogicalFileName = logDatabaseName;
            logFile.PhysicalFileName = newLogFilePath;

            databaseInfo.Current.LogDBName = logDatabaseName;
            databaseInfo.Current.LogDBPath = newLogFilePath;

            // Set the new file locations
            restore.RelocateFiles.Add(dataFile);
            restore.RelocateFiles.Add(logFile);

            // Restore the database
            restore.SqlRestore(sqlServer);

            return databaseInfo;
        }
    }
}
