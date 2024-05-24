using System.Diagnostics;
using System;
using System.IO;
using DevExpress.XtraRichEdit;

namespace DataManager
{
    public class Compression_Manager
    {
        public static void CompressionFolder(string folderPath, string zipFilePath)
        {
            Compression(folderPath, zipFilePath);
        }

        public static void DecompressionFile(string filePath, string targetPath)
        {
            // 확장자 확인
            string extension = Path.GetExtension(filePath);
            string argument = string.Empty;
            bool moveParentDir = false;
            switch (extension.Replace(".", string.Empty))
            {
                case "tar":
                    argument = $"-c \"tar -xf '{Path.GetFileName(filePath)}' -C '{targetPath}'\"";
                    moveParentDir = true;
                    break;

                case "zip":
                    argument = $"-Command \"Expand-Archive -LiteralPath '{filePath}' -DestinationPath '{targetPath}'\"";
                    break;
            }

            Decompression(filePath, targetPath, argument, moveParentDir);
        }

        private static void Compression(string folderPath, string zipFilePath)
        {
            string argument = $"Compress-Archive -Path '{folderPath}' -DestinationPath '{zipFilePath}'\"";
            ProcessPowerShell(true, argument);
        }

        private static void Decompression(string filePath, string targetPath, string argument, bool moveParentDir)
        {
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            ProcessPowerShell(false, argument, Path.GetDirectoryName(filePath));

            if (moveParentDir)
            {
                // 파일명 추출
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string targetPathInFolder = Path.Combine(targetPath, fileName);

                // 폴더 내 파일들을 모두 targetPath로 이동
                string[] files = Directory.GetFiles(targetPathInFolder, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    string destPath = file.Replace(targetPathInFolder, targetPath);
                    string destDir = Path.GetDirectoryName(destPath);
                    if (!Directory.Exists(destDir))
                        Directory.CreateDirectory(destDir);

                    File.Move(file, destPath);
                }
            }
        }

        private static void ProcessPowerShell(bool isCompressing, string argument, string workingDirectory = "")
        {
            // Shell 명령어를 실행하기 위한 프로세스 설정
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = argument,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            if (!string.IsNullOrEmpty(workingDirectory))
                processStartInfo.WorkingDirectory = workingDirectory;

            using (Process process = new Process { StartInfo = processStartInfo })
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode != 0)
                    throw new Exception($"Error {(isCompressing ? "compressing" : "extracting")} file: {error}");
            }
        }
    }
}
