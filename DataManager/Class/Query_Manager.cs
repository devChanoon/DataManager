using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class Query_Manager
    {
        /// <summary>
        /// 현재 연결된 DB를 제외한 DB 목록을 가져온다.
        /// </summary>
        /// <param name="currentDbName">현재 연결된 DB 이름</param>
        /// <returns></returns>
        public static string GetDbList(string currentDbName)
        {
            string query = @"
SELECT name as table_name
  FROM sys.databases
 WHERE name not in ('master', '@CURRENT_DB_NAME')
   AND name @CONTAINTS_AT like '%_AT'
";
            query = query.Replace("@CONTAINTS_AT", currentDbName.Contains("_AT") ? "" : "not");
            return query.Replace("@CURRENT_DB_NAME", currentDbName);
        }

        /// <summary>
        /// 현재 선택된 원본 DB의 테이블 목록을 가져온다
        /// </summary>
        /// <param name="selectedDbName">선택된 원본 DB명</param>
        /// <returns></returns>
        public static string GetTableList(string selectedDbName)
        {
            string query = @"
SELECT 'Y' as 'check'
     , convert(varchar(30), min(b.name)) as table_name
     , CONCAT(convert(int, ltrim(str(sum(reserved) * 8.192, 15, 0))), ' kb') as table_size
  FROM [@SELECTED_DB_NAME].dbo.sysindexes a
       INNER JOIN [@SELECTED_DB_NAME].dbo.sysobjects b on (a.id = b.id)
 WHERE a.indid in (0, 1, 255)
   AND b.xtype = 'U'
   AND reserved > 0
GROUP BY a.id
ORDER BY table_name
";
            return query.Replace("@SELECTED_DB_NAME", selectedDbName);
        }

        public static string GetForeignKeyList()
        {
            string query = @"
SELECT OBJECT_NAME(a.OBJECT_ID) AS foreign_key_name
     , OBJECT_NAME(a.parent_object_id) AS table_name
  FROM sys.objects a
       INNER JOIN sys.tables b on OBJECT_NAME(a.parent_object_id) = b.name
 WHERE a.type_desc IN ('FOREIGN_KEY_CONSTRAINT')
ORDER BY table_name
";
            return query;
        }

        public static string SetForeignKey(string tableName, string foreignKeyName, bool isCheck)
        {
            string query = @"
BEGIN TRY
    ALTER TABLE @TABLE_NAME @CHECK_STATUS CONSTRAINT @FOREIGN_KEY_NAME
    SELECT ''
END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE()
END CATCH
";
            query = query.Replace("@TABLE_NAME", tableName);
            query = query.Replace("@FOREIGN_KEY_NAME", foreignKeyName);
            return query.Replace("@CHECK_STATUS", isCheck ? "CHECK" : "NOCHECK");
        }

    }
}
