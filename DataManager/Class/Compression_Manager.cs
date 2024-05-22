using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using System.Text;

namespace DataManager
{
    public class Compression_Manager
    {
        public static void CompressionFolder(string folderPath, string zipFilePath)
        {
            FastZip fastZip = new FastZip();
            fastZip.CreateEmptyDirectories = true;
            fastZip.CreateZip(zipFilePath, folderPath, true, null);
        }

        public static void DecompressionFile(string filePath, string targetPath)
        {
            // 확장자 확인
            string extension = Path.GetExtension(filePath);
            switch (extension.Replace(".", string.Empty))
            {
                case "tar":
                    DecompressionTar(filePath, targetPath);
                    break;

                case "zip":
                    DecompressionZip(filePath, targetPath);
                    break;
            }
        }

        private static void DecompressionTar(string filePath, string targetPath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                TarArchive tarArchive = TarArchive.CreateInputTarArchive(stream, Encoding.UTF8);
                tarArchive.ExtractContents(targetPath);
            }

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

        private static void DecompressionZip(string filePath, string targetPath)
        {
            FastZip fastZip = new FastZip();
            fastZip.ExtractZip(filePath, targetPath, null);
        }
    }
}
