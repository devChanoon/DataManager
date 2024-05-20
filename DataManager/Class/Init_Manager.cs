using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DataManager
{
    public class Init_Manager
    {
        public Database _InitDb = new Database();

        public void Initialize()
        {
            FileInfo[] files = GetDirectoryInfo("Init").GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.ToUpper().Contains("DB_CONFIG"))
                {
                    _InitDb.InitializeDbConfig(files[i].FullName);
                }
            }

            DirectoryInfo logDirectory = GetDirectoryInfo("Log");
            string filePath = Path.Combine(logDirectory.FullName, "Log.xml");
            if (!File.Exists(filePath))
                CreateLogXml(filePath);
        }

        private void CreateLogXml(string filePath)
        {
            XDocument xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XElement("data"));
            xDoc.Save(filePath);
        }

        private DirectoryInfo GetDirectoryInfo(string folderName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(System.Windows.Forms.Application.StartupPath, folderName));
            if (!directoryInfo.Exists)
                directoryInfo.Create();

            return directoryInfo;
        }

        public class Database
        {
            private string filePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Init", "DB_CONFIG.ini");
            public string dbAddress = string.Empty;
            public string dbName = string.Empty;
            private string encryptID = string.Empty;
            private string encryptPassword = string.Empty;
            private const string CRYPT_PASSWORD = "ZR";

            public string ID
            {
                get
                {
                    if (encryptID == string.Empty)
                        return encryptID;
                    else
                        return Decrypt(encryptID, CRYPT_PASSWORD);
                }
                set
                {
                    encryptID = Encrypt(value, CRYPT_PASSWORD);
                }
            }
            public string password
            {
                get
                {
                    if (encryptPassword == string.Empty)
                        return encryptPassword;
                    else
                        return Decrypt(encryptPassword, CRYPT_PASSWORD);
                }
                set
                {
                    encryptPassword = Encrypt(value, CRYPT_PASSWORD);
                }
            }

            private string Decrypt(string cipherText, string password)
            {
                try
                {
                    byte[] cipherBytes = Convert.FromBase64String(cipherText);
                    var pdb = new PasswordDeriveBytes(password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,
                                                                    0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                                                                   });

                    byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
                    return Encoding.Unicode.GetString(decryptedData);
                }
                catch (FormatException e)
                {
                    return "입력된 값이 정상적으로 암호화 되지 않은 값 입니다 : " + e.Message;
                }
            }
            private byte[] Decrypt(byte[] cipherData, byte[] key, byte[] iv)
            {
                var ms = new MemoryStream();

                Rijndael alg = Rijndael.Create();
                alg.Key = key;
                alg.IV = iv;
                var cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(cipherData, 0, cipherData.Length);
                cs.Close();
                byte[] decryptedData = ms.ToArray();

                return decryptedData;
            }
            private byte[] Encrypt(byte[] clearData, byte[] key, byte[] iv)
            {
                var ms = new MemoryStream();
                Rijndael alg = Rijndael.Create();
                alg.Key = key;
                alg.IV = iv;
                var cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(clearData, 0, clearData.Length);
                cs.Close();
                byte[] encryptedData = ms.ToArray();

                return encryptedData;
            }
            private string Encrypt(string clearText, string password)
            {
                byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

                var pdb = new PasswordDeriveBytes(password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                                                                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                                                                });
                byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
            }

            public void InitializeDbConfig(string targetFilePath)
            {
                filePath = targetFilePath;

                StreamReader sr = new StreamReader(filePath, Encoding.Default);
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    if (line.Substring(0, 1) == "#")
                        continue;

                    string field = line.Substring(0, line.IndexOf("="));
                    string value = line.Replace(field + "=", "");

                    switch (field)
                    {
                        case "DB_Address":
                            dbAddress = value;
                            break;
                        case "DB_Name":
                            dbName = value;
                            break;
                        case "ID":
                            encryptID = value;
                            break;
                        case "Password":
                            encryptPassword = value;
                            break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }

            public void SaveDBConfig()
            {
                bool flagDbAddress = false;
                bool flagDbName = false;
                bool flagId = false;
                bool flagPassword = false;

                if (!File.Exists(filePath))
                    File.Create(filePath).Close();

                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = File.OpenText(filePath)) { 
                    while (sr.Peek() > -1)
                    {
                        string line = sr.ReadLine();
                        if (line.Substring(0, 1) == "#")
                        {
                            sb.AppendLine(line);
                            continue;
                        }

                        string content = string.Empty;
                        string field = line.Substring(0, line.IndexOf("="));
                        switch (field)
                        {
                            case "DB_Address":
                                {
                                    flagDbAddress = true;
                                    content = string.Format("{0}={1}", field, dbAddress);
                                }
                                break;
                            case "DB_Name":
                                {
                                    flagDbName = true;
                                    content = string.Format("{0}={1}", field, dbName);
                                }
                                break;
                            case "ID":
                                {
                                    flagId = true;
                                    content = string.Format("{0}={1}", field, encryptID);
                                }
                                break;
                            case "Password":
                                {
                                    flagPassword = true;
                                    content = string.Format("{0}={1}", field, encryptPassword);
                                }
                                break;
                        }

                        sb.AppendLine(content);
                    }

                    sr.Close();
                    sr.Dispose();
                }

                if (!flagDbAddress)
                    sb.AppendLine(string.Format("DB_Address={0}", dbAddress));

                if (!flagDbName)
                    sb.AppendLine(string.Format("DB_Name={0}", dbName));

                if (!flagId)
                    sb.AppendLine(string.Format("ID={0}", encryptID));

                if (!flagPassword)
                    sb.AppendLine(string.Format("Password={0}", encryptPassword));

                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.Write(sb.ToString());
                    sw.Close();
                    sw.Dispose();
                }
            }
        }
    }
}
