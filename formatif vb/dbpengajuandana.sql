USE [master]
GO

/****** Object:  Database [dbpengajuandana]    Script Date: 10/05/2018 21:35:31 ******/
CREATE DATABASE [dbpengajuandana] ON  PRIMARY 
( NAME = N'dbpengajuandana', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbpengajuandana.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbpengajuandana_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbpengajuandana_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [dbpengajuandana] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbpengajuandana].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dbpengajuandana] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [dbpengajuandana] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [dbpengajuandana] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [dbpengajuandana] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [dbpengajuandana] SET ARITHABORT OFF 
GO

ALTER DATABASE [dbpengajuandana] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [dbpengajuandana] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [dbpengajuandana] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [dbpengajuandana] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [dbpengajuandana] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [dbpengajuandana] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [dbpengajuandana] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [dbpengajuandana] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [dbpengajuandana] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [dbpengajuandana] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [dbpengajuandana] SET  DISABLE_BROKER 
GO

ALTER DATABASE [dbpengajuandana] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [dbpengajuandana] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [dbpengajuandana] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [dbpengajuandana] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [dbpengajuandana] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [dbpengajuandana] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [dbpengajuandana] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [dbpengajuandana] SET  READ_WRITE 
GO

ALTER DATABASE [dbpengajuandana] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [dbpengajuandana] SET  MULTI_USER 
GO

ALTER DATABASE [dbpengajuandana] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [dbpengajuandana] SET DB_CHAINING OFF 
GO

