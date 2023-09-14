
-- 1. ssms 에서 DB 옵션 엑세스 제한을 RESTRICTED_USER로 변경 후 DB 이름 변경

-- 2. 논리적, 물리적 이름 조회
sp_helpdb RTEGMS_NOVAREX

-- 3. 논리적 이름 변경 ---------------------------------------------------------------------------
-- 3-1.  데이터 파일
ALTER DATABASE RTEGMS_NOVAREX
	MODIFY FILE (
    NAME = NEW_GMS_INIT, --현재 논리적 데이터명
    NEWNAME = RTEGMS_NOVAREX) --변경할 논리적 데이터명
GO
-- 3-2. 로그 파일
ALTER DATABASE RTEGMS_NOVAREX
    MODIFY FILE(
    NAME = NEW_GMS_INIT_log, --현재 논리적 로그명
    NEWNAME = RTEGMS_NOVAREX_log) -- 변경할 논리적 로그명
GO

-- 4. 물리적 파일 명 및 경로 변경 ---------------------------------------------------------------------------
-- 4-1. DB OFFLINE -> OFFLINE 상태에서만 파일명 변경 가능
ALTER DATABASE RTEGMS_NOVAREX set OFFLINE
GO
-- 4-2. 디렉토리 접근해서 mdf, ldf 파일 명 먼저 바꿔주세요 ---------------------------------------
-- 4-3. 데이터 파일 경로 수정
ALTER DATABASE RTEGMS_NOVAREX
    MODIFY FILE
    (NAME = RTEGMS_NOVAREX, -- 수정한 논리적 데이터명
    FILENAME = 'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RTEGMS_NOVAREX.mdf')
GO
-- 4-4. 로그 파일 경로 수정
ALTER DATABASE RTEGMS_NOVAREX
    MODIFY FILE
    (NAME = RTEGMS_NOVAREX_log, -- 수정한 논리적 로그명
    FILENAME = 'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RTEGMS_NOVAREX_log.ldf')
GO

-- 5. DB ONLINE
ALTER DATABASE RTEGMS_NOVAREX set ONLINE

-- 6. 변경 확인
sp_helpdb RTEGMS_NOVAREX

-- 7. DB 옵션 엑세스 제한을 MULTI_USER로 변경
 