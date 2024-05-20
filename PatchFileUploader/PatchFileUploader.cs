using DevExpress.Data.Filtering.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PatchFileUploader
{
    public partial class PatchFileUploader : Form
    {
        private const string CONNECTION_STRING = "Server=sf.tascorp.co.kr,1444;database=_GIT_MIRROR_DB;uid=sa;pwd=!1Tascorp";
        private string _UploadFilePath = string.Empty;
        public PatchFileUploader()
        {
            InitializeComponent();
            SearchFileList();
        }

        private void SearchFileList()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                
                string query = @"
SELECT FileName, FileVersion, IsCurrentYN, CONVERT(CHAR(23), UploadTime, 21) AS UploadTime
  FROM Patch
ORDER BY id
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable fileData = new DataTable();
                adapter.Fill(fileData);
                gc_File.DataSource = fileData;
            }
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip files (*.zip)|*.zip";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            { 
                _UploadFilePath = openFileDialog.FileName;
                tb_FileName.Text = Path.GetFileName(_UploadFilePath);
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            if (_UploadFilePath == string.Empty)
            {
                MessageBox.Show("업로드할 파일이 선택되지 않았습니다.");
                return;
            }

            if (tb_Version.Text == string.Empty)
            {
                MessageBox.Show("파일 버전이 입력되지 않았습니다.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                try
                {
                    string query = @"
INSERT INTO Patch (FileName, FileContent, FileVersion, IsCurrentYN)
     VALUES (@FILE_NAME, @FILE_CONTENT, @FILE_VERSION, 'Y')

UPDATE Patch
   SET IsCurrentYN = 'N'
 WHERE FileVersion <> @FILE_VERSION
";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@FILE_NAME", Path.GetFileName(_UploadFilePath));
                    sqlCommand.Parameters.AddWithValue("@FILE_VERSION", tb_Version.Text);
                    sqlCommand.Parameters.AddWithValue("@FILE_CONTENT", GetFileContent(_UploadFilePath));
                    sqlCommand.ExecuteNonQuery();

                    SearchFileList();
                    MessageBox.Show("업로드가 완료 되었습니다.");

                    _UploadFilePath = string.Empty;
                    tb_FileName.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private byte[] GetFileContent(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] fileContent = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            return fileContent;
        }

        private void gv_File_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tb_Version.Text = gv_File.GetFocusedRowCellValue(gc_FileVersion).ToString();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                try
                {
                    string query = @"
UPDATE Patch
   SET IsCurrentYN = IIF(FileVersion = @FILE_VERSION, 'Y', 'N')
";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@FILE_VERSION", gv_File.GetFocusedRowCellValue(gc_FileVersion).ToString());
                    sqlCommand.ExecuteNonQuery();

                    SearchFileList();
                    MessageBox.Show("변경이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                try
                {
                    string query = @"
DELETE Patch
 WHERE FileVersion = @FILE_VERSION
";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@FILE_VERSION", gv_File.GetFocusedRowCellValue(gc_FileVersion).ToString());
                    sqlCommand.ExecuteNonQuery();

                    SearchFileList();
                    MessageBox.Show("삭제가 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    try
                    {
                        string query = @"
SELECT FileName, FileContent
  FROM Patch
 WHERE FileVersion = '@FILE_VERSION'
";
                        query = query.Replace("@FILE_VERSION", gv_File.GetFocusedRowCellValue(gc_FileVersion).ToString());
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable fileData = new DataTable();
                        adapter.Fill(fileData);
                        
                        DataRow dataRow = fileData.Rows[0];
                        string fileName = dataRow["FileName"].ToString();
                        byte[] fileContent = (byte[])dataRow["FileContent"];
                        // 파일이 존재하는지 확인하고, 존재하지 않으면 파일 생성
                        string filePath = Path.Combine(folderBrowserDialog.SelectedPath, fileName);
                        if (!File.Exists(filePath))
                            File.WriteAllBytes(filePath, fileContent);
                        else
                        {
                            // 파일 내용 비교 후 다를 경우 파일 생성
                            byte[] existingFileContent = File.ReadAllBytes(filePath);
                            if (!fileContent.SequenceEqual(existingFileContent))
                                File.WriteAllBytes(filePath, fileContent);
                        }

                        MessageBox.Show("다운로드가 완료 되었습니다.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
