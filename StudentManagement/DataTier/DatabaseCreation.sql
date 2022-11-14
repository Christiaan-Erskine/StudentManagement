IF EXISTS (SELECT [name] FROM sysobjects WHERE name = 'Create' AND type = 'P')
DROP PROCEDURE [Create]
GO

Declare @DBName varchar(200);
DECLARE @RelDir varchar(1000);
DECLARE @sql varchar(1500);

--Change this to the location where the database will be created, remember to add a backslash at the end 
SET @RelDir = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\';	                  ------------------CHANGE THE PATH---------------

SET @DBName = 'StudentManagement';                                                                        ------------------CHANGE THIS FOR DIFFIRENT DB NAME---------------

--ON
SELECT @sql = 'CREATE DATABASE '+ quotename(@DBName) + ' 
CONTAINMENT = NONE
ON
 (
 NAME = ''' + @DBName + '_DB'', 
 FILENAME = ''' + @RelDir + @DBName + '.mdf'', 
 SIZE = 1MB , MAXSIZE = UNLIMITED, 
 FILEGROWTH = 2MB
 ) 
LOG ON
 (
 NAME = '''+ @DBName + '_Log'', 
 FILENAME = '''+ @RelDir + @DBName  + 'log.ldf'', 
 SIZE = 1MB , MAXSIZE = UNLIMITED , FILEGROWTH = 2MB
 )'


IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = @DBName)
BEGIN
	EXEC (@sql);
END
GO

USE [StudentManagement]																	                 --------------CHANGE THIS FOR DIFFIRENT DB NAME-------------
GO

CREATE PROCEDURE [Create] @DBName varchar(128), @Name varchar(128), @Params varchar(2000)
AS
BEGIN
declare @table varchar(128),@DB varchar(128),@sql varchar(1000)
select @table = @Name
select @DB = @DBName

select @sql = 'use '+ quotename(@DB)+';
create table ' + quotename(@DB) +'.'+ QUOTENAME('dbo') +'.'+ quotename(@table) + @Params
--print @sql
exec (@sql)
END
GO

exec sp_MSforeachtable "declare @name nvarchar(max); set @name = parsename('?', 1); exec sp_MSdropconstraints @name";
exec sp_MSforeachtable "declare @name nvarchar(max); set @name = parsename('?', 1); exec sp_MSdropconstraints @name";
GO

Declare @TableName varchar(200);
Declare @FileName varchar(200);
Declare @Cnt int;
Declare @sql varchar(1500);
Declare @RelDir varchar(1000);
Declare @DBName varchar(500);
declare @s nvarchar(1000);
SET DATEFORMAT YMD

SET @DBName = db_name();
--for csv insert. Change this to the location of the csv folder, remember to add a backslash at the end
SET @RelDir = 'C:\Users\Hanno\OneDrive\Documents\Coding\Github\StudentManagement\StudentManagement\DataTier\csv\'	          ------------------CHANGE THE CSV PATH---------------


----------------------------------------------------------------------------------------------------------------------------------------------------------------------
BEGIN
	set @TableName = 'Student'																		                

	IF EXISTS (SELECT * FROM sysobjects WHERE name = @TableName and xtype='U')
	BEGIN	
		select @sql = 'DROP TABLE ' + @TableName
		exec (@sql)	
	END	
		EXEC [Create] @DBName, @TableName,
		'(							
			StudentNumber INT PRIMARY KEY IDENTITY(1, 1),
			Name VARCHAR(100),
			Surname VARCHAR(100),
			Image VARCHAR(1000),
			DOB DATE,
			Gender VARCHAR(1),
			Phone VARCHAR(15),
			Address VARCHAR(200),
			ModuleCode VARCHAR(25)
		 )';
		 --VARBINARY(max) --for image stored in binary format

	set @s = 'select @cnt = (select count(*) from ' + @TableName +')';
	exec sp_executesql @s, N'@cnt nvarchar(20) output', @cnt output;

	IF(@Cnt < 2)
	BEGIN	
		set @FileName = @RelDir+@TableName+'.csv'
		print @filename
		set @sql = 'BULK INSERT ' + @TableName + ' FROM ''' + @FileName + ''' WITH (FIRSTROW = 2, FIELDTERMINATOR ='','', ROWTERMINATOR =''\n'', TABLOCK)';
		EXEC(@sql);
	END
END
----------------------------------------------------------------------------------------------------------------------------------------------------------------------
BEGIN
	set @TableName = 'Module'																		                

	IF EXISTS (SELECT * FROM sysobjects WHERE name = @TableName and xtype='U')
	BEGIN	
		select @sql = 'DROP TABLE ' + @TableName
		exec (@sql)	
	END	
		EXEC [Create] @DBName, @TableName,
		'(							
			ModuleCode VARCHAR(25) PRIMARY KEY,
			Name VARCHAR(100),
			Description VARCHAR(4000),		
		 )';

	set @s = 'select @cnt = (select count(*) from ' + @TableName +')';
	exec sp_executesql @s, N'@cnt nvarchar(20) output', @cnt output;

	IF(@Cnt < 2)
	BEGIN	
		set @FileName = @RelDir+@TableName+'.csv'
		print @filename
		set @sql = 'BULK INSERT ' + @TableName + ' FROM ''' + @FileName + ''' WITH (FIRSTROW = 2, FIELDTERMINATOR ='','', ROWTERMINATOR =''\n'', TABLOCK)';
		EXEC(@sql);
	END
END
----------------------------------------------------------------------------------------------------------------------------------------------------------------------
BEGIN
	set @TableName = 'StudentModule'																		                

	IF EXISTS (SELECT * FROM sysobjects WHERE name = @TableName and xtype='U')
	BEGIN	
		select @sql = 'DROP TABLE ' + @TableName
		exec (@sql)	
	END	
		EXEC [Create] @DBName, @TableName,
		'(							
			StudentNumber INT FOREIGN KEY REFERENCES Student(StudentNumber),
			ModuleCode VARCHAR(25) FOREIGN KEY REFERENCES Module(ModuleCode)
		 )';

	set @s = 'select @cnt = (select count(*) from ' + @TableName +')';
	exec sp_executesql @s, N'@cnt nvarchar(20) output', @cnt output;

	IF(@Cnt < 2 and 1 = 0)
	BEGIN	
		set @FileName = @RelDir+@TableName+'.csv'
		print @filename
		set @sql = 'BULK INSERT ' + @TableName + ' FROM ''' + @FileName + ''' WITH (FIRSTROW = 2, FIELDTERMINATOR ='','', ROWTERMINATOR =''\n'', TABLOCK)';
		EXEC(@sql);
	END
END
----------------------------------------------------------------------------------------------------------------------------------------------------------------------
BEGIN
	set @TableName = 'Resource'																		                

	IF EXISTS (SELECT * FROM sysobjects WHERE name = @TableName and xtype='U')
	BEGIN	
		select @sql = 'DROP TABLE ' + @TableName
		exec (@sql)	
	END	
		EXEC [Create] @DBName, @TableName,
		'(	
			ResourceID INT PRIMARY KEY IDENTITY(1, 1),	
			TypeName varchar(100),
			URL VARCHAR(4000)				
		 )';

	set @s = 'select @cnt = (select count(*) from ' + @TableName +')';
	exec sp_executesql @s, N'@cnt nvarchar(20) output', @cnt output;

	IF(@Cnt < 2)
	BEGIN	
		set @FileName = @RelDir+@TableName+'.csv'
		print @filename
		set @sql = 'BULK INSERT ' + @TableName + ' FROM ''' + @FileName + ''' WITH (FIRSTROW = 2, FIELDTERMINATOR ='','', ROWTERMINATOR =''\n'', TABLOCK)';
		EXEC(@sql);
	END
END
----------------------------------------------------------------------------------------------------------------------------------------------------------------------
BEGIN
	set @TableName = 'ResourceModule'													                

	IF EXISTS (SELECT * FROM sysobjects WHERE name = @TableName and xtype='U')
	BEGIN	
		select @sql = 'DROP TABLE ' + @TableName
		exec (@sql)	
	END	
		EXEC [Create] @DBName, @TableName,
		'(							
			ResourceID INT FOREIGN KEY REFERENCES Resource(ResourceID),
			ModuleCode VARCHAR(25) FOREIGN KEY REFERENCES Module(ModuleCode)
		 )';

	set @s = 'select @cnt = (select count(*) from ' + @TableName +')';
	exec sp_executesql @s, N'@cnt nvarchar(20) output', @cnt output;

	IF(@Cnt < 2 and 1 = 0)
	BEGIN	
		set @FileName = @RelDir+@TableName+'.csv'
		print @filename
		set @sql = 'BULK INSERT ' + @TableName + ' FROM ''' + @FileName + ''' WITH (FIRSTROW = 2, FIELDTERMINATOR ='','', ROWTERMINATOR =''\n'', TABLOCK)';
		EXEC(@sql);
	END
END
----------------------------------------------------------------------------------------------------------------------------------------------------------------------