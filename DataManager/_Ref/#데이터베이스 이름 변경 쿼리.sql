
-- 1. ssms ���� DB �ɼ� ������ ������ RESTRICTED_USER�� ���� �� DB �̸� ����

-- 2. ����, ������ �̸� ��ȸ
sp_helpdb RTEGMS_NOVAREX

-- 3. ���� �̸� ���� ---------------------------------------------------------------------------
-- 3-1.  ������ ����
ALTER DATABASE RTEGMS_NOVAREX
	MODIFY FILE (
    NAME = NEW_GMS_INIT, --���� ���� �����͸�
    NEWNAME = RTEGMS_NOVAREX) --������ ���� �����͸�
GO
-- 3-2. �α� ����
ALTER DATABASE RTEGMS_NOVAREX
    MODIFY FILE(
    NAME = NEW_GMS_INIT_log, --���� ���� �α׸�
    NEWNAME = RTEGMS_NOVAREX_log) -- ������ ���� �α׸�
GO

-- 4. ������ ���� �� �� ��� ���� ---------------------------------------------------------------------------
-- 4-1. DB OFFLINE -> OFFLINE ���¿����� ���ϸ� ���� ����
ALTER DATABASE RTEGMS_NOVAREX set OFFLINE
GO
-- 4-2. ���丮 �����ؼ� mdf, ldf ���� �� ���� �ٲ��ּ��� ---------------------------------------
-- 4-3. ������ ���� ��� ����
ALTER DATABASE RTEGMS_NOVAREX
    MODIFY FILE
    (NAME = RTEGMS_NOVAREX, -- ������ ���� �����͸�
    FILENAME = 'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RTEGMS_NOVAREX.mdf')
GO
-- 4-4. �α� ���� ��� ����
ALTER DATABASE RTEGMS_NOVAREX
    MODIFY FILE
    (NAME = RTEGMS_NOVAREX_log, -- ������ ���� �α׸�
    FILENAME = 'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RTEGMS_NOVAREX_log.ldf')
GO

-- 5. DB ONLINE
ALTER DATABASE RTEGMS_NOVAREX set ONLINE

-- 6. ���� Ȯ��
sp_helpdb RTEGMS_NOVAREX

-- 7. DB �ɼ� ������ ������ MULTI_USER�� ����
 