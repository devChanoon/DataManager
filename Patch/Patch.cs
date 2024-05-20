using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.ComponentModel;

namespace Patch
{
    public partial class Patch : Form
    {
        private const string TARGET_PROGRAM = "DataManager.exe";
        public Patch()
        {
            InitializeComponent();
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(ExecutePatch);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExecuteTargetProgram);
            backgroundWorker.RunWorkerAsync();
        }

        private void ExecutePatch(object sender, DoWorkEventArgs e)
        {
            string downloadPath = Path.GetDirectoryName(Application.StartupPath);
            string targetPath = Path.Combine(downloadPath, $"___{DateTime.Now.ToString("yyyyMMddHHmmssfff")}");
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            string downloadFileName = string.Empty;
            try
            {
                // 데이터베이스에서 파일 목록 가져오기
                DataTable fileData = GetFileDataFromDatabase(GetFileVersion());
                if (fileData.Rows.Count > 0)
                {
                    DataRow dataRow = fileData.Rows[0];
                    string fileName = dataRow["FileName"].ToString();
                    byte[] fileContent = (byte[])dataRow["FileContent"];
                    downloadFileName = CreateFile(fileName, fileContent, downloadPath);

                    ZipFile.ExtractToDirectory(downloadFileName, targetPath);

                    // 임시 폴더 파일을 원래 폴더에 덮어쓰기
                    string[] files = Directory.GetFiles(targetPath, "*.*", SearchOption.AllDirectories);
                    // 각 파일을 목적지 디렉토리로 복사합니다.
                    foreach (string file in files)
                    {
                        // 파일 이름만 추출하여 목적지 경로에 추가합니다.
                        string destinationFile = file.Replace(targetPath, Application.StartupPath);
                        string destinationDirectory = Path.GetDirectoryName(destinationFile);
                        if (!Directory.Exists(destinationDirectory))
                            Directory.CreateDirectory(destinationDirectory);

                        // 파일을 덮어쓰기 위해 복사합니다.
                        File.Copy(file, destinationFile, true);
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                if (Directory.Exists(targetPath))
                    Directory.Delete(targetPath, true);

                if (File.Exists(downloadFileName))
                    File.Delete(downloadFileName);
            }
        }

        private void ExecuteTargetProgram(object sender, RunWorkerCompletedEventArgs e)
        {
            string targetPath = Path.Combine(Application.StartupPath, TARGET_PROGRAM);
            if (File.Exists(targetPath))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = targetPath,
                    UseShellExecute = true,
                    Verb = "runas" // 관리자 권한으로 실행
                };
                Process.Start(processStartInfo);
            }

            Close();
        }

        private string GetFileVersion()
        {
            string targetPath = Path.Combine(Application.StartupPath, TARGET_PROGRAM);
            if (File.Exists(targetPath))
                return FileVersionInfo.GetVersionInfo(targetPath).FileVersion;
            else
                return string.Empty;
        }

        private DataTable GetFileDataFromDatabase(string fileVersion)
        {
            string connectionString = $"Server=sf.tascorp.co.kr,1444;database=_GIT_MIRROR_DB;uid=sa;pwd=!1Tascorp";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
SELECT FileName, FileContent
  FROM Patch
 WHERE IsCurrentYN = 'Y'
   AND FileVersion <> '@FILE_VERSION'
";
                query = query.Replace("@FILE_VERSION", fileVersion);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable fileData = new DataTable();
                adapter.Fill(fileData);
                return fileData;
            }
        }

        private string CreateFile(string fileName, byte[] fileContent, string targetPath)
        {
            // 파일이 존재하는지 확인하고, 존재하지 않으면 파일 생성
            string filePath = Path.Combine(targetPath, fileName);
            if (!File.Exists(filePath))
                File.WriteAllBytes(filePath, fileContent);
            else
            {
                // 파일 내용 비교 후 다를 경우 파일 생성
                byte[] existingFileContent = File.ReadAllBytes(filePath);
                if (!fileContent.SequenceEqual(existingFileContent))
                    File.WriteAllBytes(filePath, fileContent);
            }

            return filePath;
        }
    }
}
