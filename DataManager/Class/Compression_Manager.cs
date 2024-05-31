using System.Diagnostics;
using System;
using System.IO;
using DevExpress.XtraRichEdit;
using System.Collections.Generic;

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
            switch (extension.Replace(".", string.Empty))
            {
                case "tar":
                    argument = $"-c \"tar -xf '{Path.GetFileName(filePath)}' -C '{targetPath}'\"";
                    break;

                case "zip":
                    argument = $"-Command \"Expand-Archive -LiteralPath '{filePath}' -DestinationPath '{targetPath}'\"";
                    break;
            }

            Decompression(filePath, targetPath, argument);
        }

        private static void Compression(string folderPath, string zipFilePath)
        {
            string argument = $"Compress-Archive -Path '{folderPath}' -DestinationPath '{zipFilePath}'\"";
            ProcessPowerShell(true, argument);
        }

        private static void Decompression(string filePath, string targetPath, string argument)
        {
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            ProcessPowerShell(false, argument, Path.GetDirectoryName(filePath));

            string decompressionPath = GetDecompressionPath(targetPath);
            if (decompressionPath == string.Empty)
                throw new Exception("압축 해제된 경로를 찾을 수 없습니다.\r\n압축 해제가 진행 중일 수 있습니다.");
            else if (decompressionPath != targetPath)
            {
                // 폴더 내 파일들을 모두 targetPath로 이동
                string[] files = Directory.GetFiles(decompressionPath, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    string destPath = file.Replace(decompressionPath, targetPath);
                    string destDir = Path.GetDirectoryName(destPath);
                    if (!Directory.Exists(destDir))
                        Directory.CreateDirectory(destDir);

                    File.Move(file, destPath);
                }
            }
        }

        private static string GetDecompressionPath(string filePath)
        {
            string checkFileName = "Web.config"; // 체크할 파일명
            
            // 현재 디렉토리의 파일 검색
            string[] allDirectorys = GetAllDirectories(filePath);
            string targetPath = string.Empty;
            foreach (string directory in allDirectorys)
            {
                targetPath = GetFilePath(directory, checkFileName);
                if (!string.IsNullOrEmpty(targetPath))
                    return Path.GetDirectoryName(targetPath);
            }
            return targetPath;
        }

        private static string[] GetAllDirectories(string rootPath)
        {
            List<string> directories = new List<string>() { rootPath };
            // 하위 디렉토리에 대해 재귀적으로 검색
            foreach (string directory in Directory.GetDirectories(rootPath))
            {
                directories.AddRange(GetAllDirectories(directory));
            }

            return directories.ToArray();
        }

        private static string GetFilePath(string path, string fileName)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                    return file;
            }

            return string.Empty;
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
