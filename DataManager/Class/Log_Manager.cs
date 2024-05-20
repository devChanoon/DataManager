using System;
using System.Data;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using static DataManager.Log_Manager;

namespace DataManager
{
    internal class Log_Manager
    {
        private static string XML_FILE_PATH = Path.Combine(System.Windows.Forms.Application.StartupPath, "log", "Log.xml");
        private const string MASTER_ELEMENT_NAME = "master";
        private string _MasterId = string.Empty;

        public struct MasterData
        {
            public string MasterId;
            public string ServerName;
            public string Type;
            public string Time;
            public string Result;
            public string ErrorMessage;
        }

        public struct SiteData
        {
            public string Time;
            public string SiteName;
            public string Path;
            public string FilePath;
            public string Result;
            public string ErrorMessage;
        }

        public struct DatabaseData
        {
            public string Time;
            public string DatabaseName;
            public string BackupFilePath;
            public string Result;
            public string ErrorMessage;
        }

        public struct DetailData
        {
            public string Time;
            public string LogMessage;
            public string Result;
            public string ErrorMessage;
        }

        private static DataTable GetTableSchema(Type type)
        {
            DataTable dataTable = new DataTable();

            // 구조체의 필드를 열로 추가
            foreach (var field in type.GetFields())
            {
                // 필드 이름과 형식을 기반으로 DataColumn 생성
                DataColumn column = new DataColumn(field.Name, field.FieldType);
                dataTable.Columns.Add(column);
            }

            return dataTable;
        }

        public static DataTable GetMasterData()
        {
            // XML 파일 로드
            XDocument doc = XDocument.Load(XML_FILE_PATH);

            Type masterDataType = typeof(MasterData);
            DataTable dataTable = GetTableSchema(masterDataType);

            // XML에서 데이터 읽어와 DataTable에 추가
            foreach (var masterElement in doc.Descendants(MASTER_ELEMENT_NAME))
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (var field in masterDataType.GetFields())
                {
                    dataRow[field.Name] = masterElement.Element(field.Name).Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        public static DataTable GetDetailData(string masterId, Type detailDataType)
        {
            DataTable dataTable = GetTableSchema(detailDataType);
            Tuple<XDocument, XElement> masterElementTuple = GetMasterElement(masterId);
            XElement masterElement = masterElementTuple.Item2;
            if (masterElement != null)
            {
                // masterID에 해당하는 details 요소들 가져오기
                var detailsElements = masterElement.Elements(detailDataType.Name);
                foreach (var detailElement in detailsElements)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var field in detailDataType.GetFields())
                    {
                        dataRow[field.Name] = detailElement.Element(field.Name).Value;
                    }

                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        private static Tuple<XDocument, XElement> GetMasterElement(string masterId)
        {
            XDocument doc = XDocument.Load(XML_FILE_PATH);
            return new Tuple<XDocument, XElement>(doc, doc.Descendants(MASTER_ELEMENT_NAME)
                                                          .FirstOrDefault(m => m.Element("MasterId").Value == masterId));
        }

        public void AppendMaster(string type, string serverName)
        {
            XDocument doc = XDocument.Load(XML_FILE_PATH);

            // 모든 masterId 값을 가져와 최대값 구하기
            int maxMasterId = doc.Descendants(MASTER_ELEMENT_NAME)
                                .Select(m => (int)m.Element("MasterId"))
                                .DefaultIfEmpty(0) // masterId가 없는 경우 0으로 초기화
                                .Max();
            // 다음 masterId 생성
            string nextMasterId = (maxMasterId + 1).ToString();
            _MasterId = nextMasterId;

            MasterData masterData = new MasterData();
            masterData.Type = type;
            masterData.MasterId = nextMasterId;
            masterData.ServerName = serverName;
            masterData.Result = "Success";
            masterData.ErrorMessage = string.Empty;

            XElement newMaster = new XElement(MASTER_ELEMENT_NAME, GetObjectArray(masterData).Item3);
            doc.Element("data").Add(newMaster);
            doc.Save(XML_FILE_PATH);
        }

        private Tuple<bool, string, object[]> GetObjectArray(object data)
        {
            bool isSuccess = true;
            string errorMessage = string.Empty;

            List<object> parameterList = new List<object>();
            foreach (var field in data.GetType().GetFields())
            {
                object value = field.GetValue(data);
                if (field.Name == "ErrorMessage" && value.ToString() != string.Empty)
                {
                    isSuccess = false;
                    errorMessage = value.ToString();
                }
                parameterList.Add(new XElement(field.Name, field.Name == "Time" ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") : value));
            }
            return new Tuple<bool, string, object[]>(isSuccess, errorMessage, parameterList.ToArray());
        }

        public void AppendDetail(object detailData)
        {
            Tuple<XDocument, XElement> masterElementTuple = GetMasterElement(_MasterId);
            XDocument doc = masterElementTuple.Item1;
            XElement masterElement = masterElementTuple.Item2;
            if (masterElement != null)
            {
                Tuple<bool, string, object[]> detailDataTuple = GetObjectArray(detailData);
                if (!detailDataTuple.Item1)
                {
                    masterElement.Element("Result").Value = "Fail";
                    string errorMessage = masterElement.Element("ErrorMessage").Value;
                    if (errorMessage == string.Empty)
                        errorMessage = detailDataTuple.Item2;
                    else
                        errorMessage += $" / {detailDataTuple.Item2}";

                    masterElement.Element("ErrorMessage").Value = errorMessage;
                }

                masterElement.Add(new XElement(detailData.GetType().Name, detailDataTuple.Item3));
                doc.Save(XML_FILE_PATH);
            }
        }
    }
}
