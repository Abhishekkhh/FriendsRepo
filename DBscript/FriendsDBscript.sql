USE [master]
GO
/****** Object:  Database [Friends]    Script Date: 24-12-2021 01:56:31 ******/
CREATE DATABASE [Friends]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Friends', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Friends.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Friends_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Friends_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Friends] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Friends].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Friends] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Friends] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Friends] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Friends] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Friends] SET ARITHABORT OFF 
GO
ALTER DATABASE [Friends] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Friends] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Friends] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Friends] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Friends] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Friends] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Friends] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Friends] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Friends] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Friends] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Friends] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Friends] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Friends] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Friends] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Friends] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Friends] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Friends] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Friends] SET RECOVERY FULL 
GO
ALTER DATABASE [Friends] SET  MULTI_USER 
GO
ALTER DATABASE [Friends] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Friends] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Friends] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Friends] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Friends] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Friends] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Friends', N'ON'
GO
ALTER DATABASE [Friends] SET QUERY_STORE = OFF
GO
USE [Friends]
GO
/****** Object:  User [hrms]    Script Date: 24-12-2021 01:56:32 ******/
CREATE USER [hrms] FOR LOGIN [hrms] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [hrms]
GO
/****** Object:  Table [dbo].[FriendMaster]    Script Date: 24-12-2021 01:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FriendMaster](
	[FriendID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[MobileNo] [varchar](20) NULL,
	[EmailID] [varchar](100) NULL,
	[isDeleted] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_FriendMaster] PRIMARY KEY CLUSTERED 
(
	[FriendID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 24-12-2021 01:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[UserMasterId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[EmailID] [varchar](100) NULL,
	[MobileNo] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[isDeleted] [bit] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[UserMasterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FriendMaster] ADD  CONSTRAINT [DF_FriendMaster_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[FriendMaster] ADD  CONSTRAINT [DF_FriendMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[UserMaster] ADD  CONSTRAINT [DF_UserMaster_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[UserMaster] ADD  CONSTRAINT [DF_UserMaster_CreatedDate]  DEFAULT (getdate()) FOR [CreatedOn]
GO
/****** Object:  StoredProcedure [dbo].[CheckLoginDetails]    Script Date: 24-12-2021 01:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- select * from UserMaster
-- exec CheckLoginDetails '9969853401','Abhi@123'
CREATE proc [dbo].[CheckLoginDetails]
@MobileNo varchar(20),
@Password varchar(20)
AS
BEGIN

	select UserMasterID, FirstName, LastName,EmailID,MobileNo from UserMaster
	where MobileNo = @MobileNo and Password= @Password and isDeleted = 0

END
GO
/****** Object:  StoredProcedure [dbo].[Create_Update_Delete_Friend]    Script Date: 24-12-2021 01:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- truncate table FriendMaster
-- select * from FriendMaster
-- exec Create_Update_Delete_Friend 'Add',0,'Abhishek','Khandelwal','abhishekkhh@gmail.com','9969853409',1
-- exec Create_Update_Delete_Friend 'Update',1,'Abhishek','Khandelwal','abhishekkhh@gmail.com','9969853409',1
-- exec Create_Update_Delete_Friend 'Delete',0,'','','','',1,'2,3,4'
CREATE proc [dbo].[Create_Update_Delete_Friend]
@Type varchar(20) = NULL,
@FriendID int = NULL,
@FirstName varchar(50) = NULL, 
@LastName varchar(50) = NULL,
@EmailID varchar(100) = NULL,
@MobileNo varchar(20) = NULL,
@CreatedBy int = NULL,
@DeleteCommaSepFriendId varchar(MAX) = NULL
AS
BEGIN

DECLARE @QUERY nvarchar(MAX) = NULL

if exists(select 1 from FriendMaster where EmailID = @EmailID and isDeleted = 0 and FriendID <> isnull(@FriendID,0))
BEGIN

select 1 as ErrorCode,'Email already exists' as [Message]
return;

END

else if exists(select 1 from FriendMaster where MobileNo = @MobileNo and isDeleted = 0 and FriendID <> isnull(@FriendID,0))
BEGIN

select 1 as ErrorCode,'Mobile No already exists' as [Message]
return;

END

else if(@Type = 'Add')
BEGIN

insert into FriendMaster(FirstName,LastName,EmailID,MobileNo,CreatedBy)
values(@FirstName,@LastName,@EmailID,@MobileNo,@CreatedBy)

select 0 as ErrorCode,'Friend Created Successfully !!' as [Message]

END

ELSE if(@Type = 'Update')
BEGIN

update FriendMaster set FirstName = @FirstName,LastName = @LastName,EmailID=@EmailID,MobileNo=@MobileNo,
ModifiedOn = getdate(), ModifiedBy = @CreatedBy
where FriendId = @FriendID and isDeleted = 0

select 0 as ErrorCode,'Friend Updated Successfully !!' as [Message]

END

ELSE if(@Type = 'Delete')
BEGIN

set @QUERY=' update FriendMaster set isDeleted = 1,ModifiedBy=' + CONVERT(varchar(20),@CreatedBy) + ',ModifiedOn=getdate() 
 where FriendId in ( ' + @DeleteCommaSepFriendId + ' )'

 exec (@QUERY)

 select 0 as ErrorCode,'Friend/s deleted Successfully !!' as [Message]

END

END
GO
/****** Object:  StoredProcedure [dbo].[Create_UpdateUser]    Script Date: 24-12-2021 01:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Create_UpdateUser]
@FirstName varchar(50) = NULL, 
@LastName varchar(50) = NULL,
@EmailID varchar(100) = NULL,
@MobileNo varchar(20) = NULL,
@Password varchar(20) = NULL
AS
BEGIN

DECLARE @QUERY nvarchar(MAX) = NULL

if exists(select 1 from UserMaster where EmailID = @EmailID and isDeleted = 0)
BEGIN

select 1 as ErrorCode,'Email ID already exists' as [Message]
return;

END

else if exists(select 1 from UserMaster where MobileNo = @MobileNo and isDeleted = 0)
BEGIN

select 1 as ErrorCode,'Mobile No already exists' as [Message]
return;

END

insert into UserMaster(FirstName,LastName,EmailID,MobileNo,[Password])
values(@FirstName,@LastName,@EmailID,@MobileNo,@Password)

select 0 as ErrorCode,'User Created Successfully !!' as [Message]


END
GO
/****** Object:  StoredProcedure [dbo].[DisplayFriendsList]    Script Date: 24-12-2021 01:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec DisplayFriendsList
-- exec DisplayFriendsList 1
CREATE proc [dbo].[DisplayFriendsList]
@FriendID int = NULL
AS
BEGIN

select FriendId,FirstName,LastName,EmailID,MobileNo 
from FriendMaster
where IsDeleted = 0 and (isnull(@FriendID,0) = 0 or FriendId = @FriendID)

END
GO
USE [master]
GO
ALTER DATABASE [Friends] SET  READ_WRITE 
GO
