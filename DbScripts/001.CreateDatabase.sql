USE [master]
GO

/****** Object:  Database [EmailTemplates]    Script Date: 5/22/2017 12:03:41 PM ******/
CREATE DATABASE [EmailTemplates]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmailTemplates', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EmailTemplates.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EmailTemplates_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EmailTemplates_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [EmailTemplates] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmailTemplates].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EmailTemplates] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EmailTemplates] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EmailTemplates] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EmailTemplates] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EmailTemplates] SET ARITHABORT OFF 
GO

ALTER DATABASE [EmailTemplates] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EmailTemplates] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EmailTemplates] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EmailTemplates] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EmailTemplates] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EmailTemplates] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EmailTemplates] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EmailTemplates] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EmailTemplates] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EmailTemplates] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EmailTemplates] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EmailTemplates] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EmailTemplates] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EmailTemplates] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EmailTemplates] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EmailTemplates] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EmailTemplates] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EmailTemplates] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EmailTemplates] SET  MULTI_USER 
GO

ALTER DATABASE [EmailTemplates] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EmailTemplates] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EmailTemplates] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EmailTemplates] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [EmailTemplates] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EmailTemplates] SET  READ_WRITE 
GO


