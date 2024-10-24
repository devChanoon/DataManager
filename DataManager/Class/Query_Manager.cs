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
   AND SUBSTRING(name, 0, CASE WHEN CHARINDEX('#', name) = 0 THEN LEN(name) + 1 ELSE CHARINDEX('#', name) END) @CONTAINTS_AT like '%_AT'
";
            query = query.Replace("@CONTAINTS_AT", currentDbName.Contains("_AT") ? "" : "not");
            return query.Replace("@CURRENT_DB_NAME", currentDbName);
        }

        public static string DropCurrentUsers()
        {
            string query = @"
SELECT CONCAT('DROP USER [', name, ']') as query 
  FROM sys.database_principals 
 WHERE name NOT IN ('dbo', 'guest', 'INFORMATION_SCHEMA', 'sys')
   AND type = 'S'
";
            return query;
        }	  

        public static string GetUserAndRoles(string sourceDbName)
        {
            string query = @"
SELECT CONCAT('CREATE USER [', a.name, '] FOR LOGIN [', a.name, ']; ') as query
  FROM (select c.name
		  from [@SOURCE_DB_NAME].sys.database_role_members a
			   INNER JOIN [@SOURCE_DB_NAME].sys.database_principals b ON a.role_principal_id = b.principal_id
			   INNER JOIN [@SOURCE_DB_NAME].sys.database_principals c ON a.member_principal_id = c.principal_id
		 where c.name NOT IN ('dbo', 'guest', 'INFORMATION_SCHEMA', 'sys') -- 기본 사용자 제외
	  group by c.name
	   ) a
	   LEFT OUTER JOIN sys.database_principals b on a.name = b.name
 WHERE b.name is null

 UNION ALL

SELECT 'EXEC sp_addrolemember ''' + b.name + ''', ''' + c.name + '''; ' as query
  FROM [@SOURCE_DB_NAME].sys.database_role_members a
	   INNER JOIN [@SOURCE_DB_NAME].sys.database_principals b ON a.role_principal_id = b.principal_id
	   INNER JOIN [@SOURCE_DB_NAME].sys.database_principals c ON a.member_principal_id = c.principal_id
 WHERE c.type IN ('S', 'G', 'U') -- SQL 로그인, Windows 그룹, 데이터베이스 사용자만 포함
   AND c.name NOT IN ('dbo', 'guest', 'INFORMATION_SCHEMA', 'sys'); -- 기본 사용자 제외
";
            return query.Replace("@SOURCE_DB_NAME", sourceDbName);
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
     , max(b.name) as table_name
	 , CONCAT(FORMAT(SUM (CASE WHEN (a.index_id < 2) THEN (a.in_row_data_page_count + a.lob_used_page_count + a.row_overflow_used_page_count)
													ELSE (a.lob_used_page_count + a.row_overflow_used_page_count)
							END) * 8, '#,0'), ' KB') AS table_size
  FROM [@SELECTED_DB_NAME].sys.dm_db_partition_stats a
	   INNER JOIN [@SELECTED_DB_NAME].sys.all_objects b ON a.object_id = b.object_id
 WHERE b.type = 'U'
GROUP BY a.object_id
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

        public static string CheckExistTable(string tableName)
        {
            string query = @"
IF EXISTS (select name from sys.tables where name = '@TABLE_NAME')
	SELECT 'Y'
ELSE
	SELECT 'N'
";
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string CheckExistDatabase(string dbName)
        {
            string query = @"
IF EXISTS (select name from sys.databases where name = '@DB_NAME')
	SELECT 'Y'
ELSE
	SELECT 'N'
";
            return query.Replace("@DB_NAME", dbName);
        }

        public static string ValidationTableData(string sourceDbName, string tableName, string columnData)
        {
            string query = @"
SELECT @COLUMN_DATA 
  FROM [@SOURCE_DB_NAME].dbo.[@TABLE_NAME]

EXCEPT 

SELECT @COLUMN_DATA 
  FROM [@TABLE_NAME]
";
            query = query.Replace("@SOURCE_DB_NAME", sourceDbName);
            query = query.Replace("@COLUMN_DATA", columnData);
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string DeleteTableData(string tableName)
        {
            string query = @"
DELETE @TABLE_NAME
";
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string GetColumnList(string sourceDbName, string tableName)
        {
            string query = @"
 SELECT b.name as column_name
   INTO #COLUMN_LIST
   FROM sys.tables a
		INNER JOIN sys.columns b on a.object_id = b.object_id
	    LEFT OUTER JOIN sys.computed_columns b1 on a.object_id = b1.object_id and b.column_id = b1.column_id  
  WHERE a.name = '@TABLE_NAME'
    AND isnull(b1.column_id, -1) = -1
	
 SELECT b.name as column_name
   FROM [@SOURCE_DB_NAME].sys.tables a
		INNER JOIN [@SOURCE_DB_NAME].sys.columns b on a.object_id = b.object_id
		INNER JOIN #COLUMN_LIST c on b.name = c.column_name
  WHERE a.name = '@TABLE_NAME'

 DROP TABLE #COLUMN_LIST
";
            query = query.Replace("@SOURCE_DB_NAME", sourceDbName);
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string GetTableDataList(string sourceDbName, string tableName, string columnData, int pageNumber)
        {
            string query = @"
DECLARE @RowsPerPage AS INT = 1000000
DECLARE @StartRow AS INT = ((@PAGE_NUMBER - 1) * @RowsPerPage) + 1
DECLARE @EndRow AS INT = @PAGE_NUMBER * @RowsPerPage

;WITH NumberedTable AS (
    SELECT 
        @COLUMN_DATA, 
        ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS RowNumber
    FROM 
        [@SOURCE_DB_NAME].dbo.[@TABLE_NAME]
)
SELECT 
    @COLUMN_DATA
FROM 
    NumberedTable
WHERE 
    RowNumber BETWEEN @StartRow AND @EndRow
";
            query = query.Replace("@PAGE_NUMBER", pageNumber.ToString());
            query = query.Replace("@COLUMN_DATA", columnData);
            query = query.Replace("@SOURCE_DB_NAME", sourceDbName);
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string GetTableSchema(string tableName, string columnData)
        {
            string query = @"
SELECT @COLUMN_DATA
  FROM @TABLE_NAME
 WHERE 1 = 2
            ";
            query = query.Replace("@COLUMN_DATA", columnData);
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string ResetIdentity(string tableName)
        {
            string query = @"
DBCC CHECKIDENT ('@TABLE_NAME', RESEED, 0)
";
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string SetIdentityMax(string tableName)
        {
            string query = @"
DBCC CHECKIDENT ('@TABLE_NAME', RESEED)
";
            return query.Replace("@TABLE_NAME", tableName);
        }

        public static string GetDBInfo(string currentDbName)
        {
            string query = @"
SP_HELPDB @CURRENT_DB_NAME
";
            return query.Replace("@CURRENT_DB_NAME", currentDbName);
        }

        public static string SetDBAccess(string currentDbName, bool isMultiUser)
        {
            string query = @"
ALTER DATABASE @CURRENT_DB_NAME SET @MODE WITH ROLLBACK IMMEDIATE;
";
            query = query.Replace("@CURRENT_DB_NAME", currentDbName);
            return query.Replace("@MODE", isMultiUser ? "MULTI_USER" : "RESTRICTED_USER");
        }

        public static string SetDBStatus(string currentDbName, bool isOnline)
        {
            string query = @"
ALTER DATABASE @CURRENT_DB_NAME SET @MODE WITH ROLLBACK IMMEDIATE;
";
            query = query.Replace("@CURRENT_DB_NAME", currentDbName);
            return query.Replace("@MODE", isOnline ? "ONLINE" : "OFFLINE");
        }

        public static string SetDBLogicalName(string currentDbName, string currentName, string newName)
        {
            string query = @"
ALTER DATABASE @CURRENT_DB_NAME
MODIFY FILE ( NAME = @CURRENT_NAME, NEWNAME = @NEW_NAME )
";
            query = query.Replace("@CURRENT_DB_NAME", currentDbName);
            query = query.Replace("@CURRENT_NAME", currentName);
            return query.Replace("@NEW_NAME", newName);
        }

        public static string SetDBLogicalPath(string currentDbName, string name, string path)
        {
            string query = @"
ALTER DATABASE @CURRENT_DB_NAME
MODIFY FILE ( NAME = @NAME, FILENAME = '@PATH' )
";
            query = query.Replace("@CURRENT_DB_NAME", currentDbName);
            query = query.Replace("@NAME", name);
            return query.Replace("@PATH", path);
        }

        public static string ChangeDBName(string currentDbName, string newName)
        {
            string query = @"
ALTER DATABASE @CURRENT_DB_NAME MODIFY NAME = @NEW_NAME;
";
            query = query.Replace("@CURRENT_DB_NAME", currentDbName);
            return query.Replace("@NEW_NAME", newName);
        }

        public static string DropDatabase(string currentDbName)
        {
            string query = @"
ALTER DATABASE [@CURRENT_DB_NAME] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

DROP DATABASE @CURRENT_DB_NAME
";
            query = query.Replace("@CURRENT_DB_NAME", currentDbName);
            return query;
        }
    }
}
