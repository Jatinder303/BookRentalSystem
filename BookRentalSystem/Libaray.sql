USE [master]
GO
/****** Object:  Database [Libaray]    Script Date: 19/05/2020 9:17:23 AM ******/
CREATE DATABASE [Libaray]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Libaray', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Libaray.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Libaray_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Libaray_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Libaray] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Libaray].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Libaray] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Libaray] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Libaray] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Libaray] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Libaray] SET ARITHABORT OFF 
GO
ALTER DATABASE [Libaray] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Libaray] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Libaray] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Libaray] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Libaray] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Libaray] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Libaray] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Libaray] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Libaray] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Libaray] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Libaray] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Libaray] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Libaray] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Libaray] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Libaray] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Libaray] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Libaray] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Libaray] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Libaray] SET  MULTI_USER 
GO
ALTER DATABASE [Libaray] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Libaray] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Libaray] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Libaray] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Libaray] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Libaray] SET QUERY_STORE = OFF
GO
USE [Libaray]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](50) NOT NULL,
	[Author] [varchar](30) NOT NULL,
	[Available] [varchar](5) NULL,
	[Borrower] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rent]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rent](
	[BorrowID] [int] IDENTITY(1,1) NOT NULL,
	[BookIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[BorrowDate] [date] NULL,
	[ReturnedDate] [date] NULL,
 CONSTRAINT [PK_Rent] PRIMARY KEY CLUSTERED 
(
	[BorrowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Popular_books]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Popular_books]
AS
SELECT TOP (100) PERCENT dbo.Books.BookName AS [Book Name], dbo.Books.Author, dbo.Books.Available, COUNT(dbo.Rent.BookIDFK) AS [Number of Times]
FROM     dbo.Books INNER JOIN
                  dbo.Rent ON dbo.Books.BookID = dbo.Rent.BookIDFK
GROUP BY dbo.Books.BookName, dbo.Books.Author, dbo.Books.Available
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Mobile] [char](10) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Popular_Customer]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Popular_Customer]
AS
SELECT dbo.Customer.FirstName AS [First Name], dbo.Customer.LastName AS [Last Name], dbo.Customer.Address, dbo.Customer.Mobile, COUNT(dbo.Rent.BookIDFK) AS BooksRented
FROM     dbo.Customer INNER JOIN
                  dbo.Rent ON dbo.Customer.CustID = dbo.Rent.CustIDFK
GROUP BY dbo.Customer.FirstName, dbo.Customer.LastName, dbo.Customer.Address, dbo.Customer.Mobile
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookID], [BookName], [Author], [Available], [Borrower]) VALUES (1, N'The Fault in Our Stars', N'John Green', N'No', N'Yes')
INSERT [dbo].[Books] ([BookID], [BookName], [Author], [Available], [Borrower]) VALUES (2, N'The Kite Runner', N'Khaled Hosseini', N'Yes', NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [Author], [Available], [Borrower]) VALUES (3, N'The Alchemist', N'Paulo Coelho', N'Yes', NULL)
INSERT [dbo].[Books] ([BookID], [BookName], [Author], [Available], [Borrower]) VALUES (4, N'Divergent', N'Veronica Roth', N'No', N'Yes')
INSERT [dbo].[Books] ([BookID], [BookName], [Author], [Available], [Borrower]) VALUES (5, N'A Game of Thrones', N'George R.R. Martin', N'Yes', NULL)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Mobile]) VALUES (1, N'Jatinder', N'Singh', N'ZYX', N'2589632587')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Mobile]) VALUES (2, N'Jaskaran', N'Singh', N'CDF', N'1489632587')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Mobile]) VALUES (4, N'Karan', N'Singh', N'YTG', N'369963697 ')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Rent] ON 

INSERT [dbo].[Rent] ([BorrowID], [BookIDFK], [CustIDFK], [BorrowDate], [ReturnedDate]) VALUES (3, 1, 1, CAST(N'2020-05-12' AS Date), CAST(N'2020-05-12' AS Date))
INSERT [dbo].[Rent] ([BorrowID], [BookIDFK], [CustIDFK], [BorrowDate], [ReturnedDate]) VALUES (4, 4, 4, CAST(N'2020-05-09' AS Date), NULL)
INSERT [dbo].[Rent] ([BorrowID], [BookIDFK], [CustIDFK], [BorrowDate], [ReturnedDate]) VALUES (5, 5, 2, CAST(N'2020-05-10' AS Date), CAST(N'2020-05-12' AS Date))
INSERT [dbo].[Rent] ([BorrowID], [BookIDFK], [CustIDFK], [BorrowDate], [ReturnedDate]) VALUES (6, 1, 2, CAST(N'2020-05-12' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Rent] OFF
SET IDENTITY_INSERT [dbo].[UserDetails] ON 

INSERT [dbo].[UserDetails] ([UserID], [UserName], [Email], [Password]) VALUES (1, N'Jatinder', N'Jatinder@atc.na', N'123456789')
INSERT [dbo].[UserDetails] ([UserID], [UserName], [Email], [Password]) VALUES (2, N'Sahil', N'Sahil@atc.nz', N'258963258')
INSERT [dbo].[UserDetails] ([UserID], [UserName], [Email], [Password]) VALUES (3, N'Chetan', N'Chetan@atc.nz', N'123654789')
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [FK_Rent_Books] FOREIGN KEY([BookIDFK])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [FK_Rent_Books]
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [FK_Rent_Customer] FOREIGN KEY([CustIDFK])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [FK_Rent_Customer]
GO
/****** Object:  StoredProcedure [dbo].[BorrowBooks]    Script Date: 19/05/2020 9:17:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrowBooks]
	
	AS
	set nocount on;
	SELECT * from Books where Borrower = 'Yes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Books"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Rent"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Popular_books'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Popular_books'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Customer"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Rent"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1692
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Popular_Customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Popular_Customer'
GO
USE [master]
GO
ALTER DATABASE [Libaray] SET  READ_WRITE 
GO
