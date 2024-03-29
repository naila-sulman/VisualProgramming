USE [master]
GO
/****** Object:  Database [JMS]    Script Date: 07/18/2018 00:41:27 ******/
CREATE DATABASE [JMS] ON  PRIMARY 
( NAME = N'Seven86', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Seven86.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Seven86_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Seven86_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [JMS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JMS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [JMS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [JMS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [JMS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [JMS] SET ARITHABORT OFF
GO
ALTER DATABASE [JMS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [JMS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [JMS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [JMS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [JMS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [JMS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [JMS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [JMS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [JMS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [JMS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [JMS] SET  DISABLE_BROKER
GO
ALTER DATABASE [JMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [JMS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [JMS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [JMS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [JMS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [JMS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [JMS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [JMS] SET  READ_WRITE
GO
ALTER DATABASE [JMS] SET RECOVERY FULL
GO
ALTER DATABASE [JMS] SET  MULTI_USER
GO
ALTER DATABASE [JMS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [JMS] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'JMS', N'ON'
GO
USE [JMS]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[CUSTOMERID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](max) NULL,
	[CONTACTNUMBER] [varchar](15) NULL,
	[ADDRESS] [varchar](max) NULL,
	[NIC] [varchar](20) NOT NULL,
	[JOINDATE] [date] NULL,
	[STATUS] [varchar](10) NULL,
	[LEAVEDATE] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CUSTOMERID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BATCH]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BATCH](
	[BATCHID] [int] IDENTITY(1,1) NOT NULL,
	[BATCHNAME] [varchar](max) NOT NULL,
	[BATCHDATE] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[BATCHID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLOYEES](
	[EMPLOYEEID] [int] IDENTITY(1,1) NOT NULL,
	[EMPLOYEENAME] [varchar](max) NOT NULL,
	[JOINDATE] [date] NULL,
	[LEAVEDATE] [date] NULL,
	[CONTACTNUMBER] [varchar](15) NULL,
	[NIC] [varchar](20) NOT NULL,
	[ADDRESS] [varchar](50) NULL,
	[DESIGNATION] [varchar](max) NULL,
	[SALARY] [int] NOT NULL,
	[STATUS] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[EMPLOYEEID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PACKINGTYPE]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PACKINGTYPE](
	[PACKINGID] [int] IDENTITY(1,1) NOT NULL,
	[PACKINGTYPE] [varchar](max) NULL,
	[VOLUME] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PACKINGID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRADEMARK]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRADEMARK](
	[TRADEMARKID] [int] IDENTITY(1,1) NOT NULL,
	[COMPANYNAME] [varchar](max) NOT NULL,
	[COMPANYADDRESS] [varchar](max) NULL,
	[EMAIL] [varchar](max) NULL,
	[CONTACTNUMBER] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[TRADEMARKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TASKS]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TASKS](
	[TASKID] [int] IDENTITY(1,1) NOT NULL,
	[DETAILS] [varchar](max) NOT NULL,
	[TASKPURPOSE] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[TASKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAKEORDER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAKEORDER](
	[ORDERID] [int] IDENTITY(1,1) NOT NULL,
	[CUSTOMERID] [int] NULL,
	[ORDERDATE] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ORDERID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[PRODUCTID] [int] IDENTITY(1,1) NOT NULL,
	[PRODUCTNAME] [varchar](max) NOT NULL,
	[INSTRUCTION] [varchar](max) NULL,
	[FORMULA] [varchar](max) NULL,
	[QUANTITYINSTOCK] [int] NULL,
	[PACKINGID] [int] NULL,
	[BATCHID] [int] NULL,
	[TRADEMARKID] [int] NULL,
	[RETAILPRICE] [float] NOT NULL,
	[TRADEPRICE] [float] NOT NULL,
	[MARKUP] [int] NULL,
	[EXPIRYDATE] [date] NULL,
	[MANUFACTUREDATE] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PRODUCTID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REMINDER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REMINDER](
	[REMINDERID] [int] IDENTITY(1,1) NOT NULL,
	[REMINDERDATE] [date] NOT NULL,
	[REMINDERTIME] [time](7) NOT NULL,
	[REMINDERTEXT] [varchar](max) NOT NULL,
	[EMPLOYEEID] [int] NULL,
	[STATUS] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[REMINDERID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DISTRIBUTOR]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DISTRIBUTOR](
	[DISTRIBUTORID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](max) NULL,
	[CONTACTNUMBER] [varchar](15) NULL,
	[TRADEMARKID] [int] NULL,
	[EMAIL] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DISTRIBUTORID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ASSIGNEDTASKS]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ASSIGNEDTASKS](
	[ASSIGNEDTASKID] [int] IDENTITY(1,1) NOT NULL,
	[TASK] [varchar](max) NULL,
	[STARTTIME] [datetime] NULL,
	[ENDTIME] [datetime] NULL,
	[REMARKS] [varchar](max) NULL,
	[ASSIGNEDDATE] [date] NULL,
	[TASKID] [int] NULL,
	[EMPID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ASSIGNEDTASKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[asigntaskview]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[asigntaskview] as select ASSIGNEDTASKID,TASK,STARTTIME,ENDTIME,REMARKS,ASSIGNEDDATE,TASKID,EMPLOYEEID,EMPLOYEENAME from dbo.ASSIGNEDTASKS inner join dbo.EMPLOYEES on  dbo.ASSIGNEDTASKS.ASSIGNEDTASKID=dbo.EMPLOYEES.ASSIGNTASKID
GO
/****** Object:  Table [dbo].[RETURNBYCUSTOMER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RETURNBYCUSTOMER](
	[RETURNID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERID] [int] NULL,
	[PRODUCTID] [int] NULL,
	[CUSTOMERID] [int] NULL,
	[RETURNQUANTITY] [int] NOT NULL,
	[AMOUNT] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[RETURNID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAYMENTBYCUSTOMER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAYMENTBYCUSTOMER](
	[BILLNUMBER] [int] IDENTITY(1,1) NOT NULL,
	[CUSTOMERID] [int] NULL,
	[ORDERPRODUCTID] [int] NULL,
	[BILLAMOUNT] [float] NOT NULL,
	[PAIDAMOUNT] [int] NOT NULL,
	[BALANCE] [int] NOT NULL,
	[STATUS] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[BILLNUMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[products]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[products] as(select dbo.PRODUCT.PRODUCTID, dbo.PRODUCT.PRODUCTNAME, dbo.PRODUCT.INSTRUCTION, dbo.PRODUCT.FORMULA, dbo.PRODUCT.QUANTITYINSTOCK, dbo.PRODUCT.RETAILPRICE, dbo.PRODUCT.TRADEPRICE, dbo.PRODUCT.MARKUP, dbo.PRODUCT.EXPIRYDATE, dbo.PRODUCT.MANUFACTUREDATE, dbo.PACKINGTYPE.PACKINGTYPE, dbo.PACKINGTYPE.VOLUME, dbo.TRADEMARK.EMAIL, dbo.TRADEMARK.COMPANYADDRESS, dbo.TRADEMARK.COMPANYNAME, dbo.BATCH.BATCHNAME, dbo.BATCH.BATCHDATE
from dbo.PRODUCT INNER JOIN dbo.BATCH ON dbo.PRODUCT.BATCHID = dbo.BATCH.BATCHID 
INNER JOIN dbo.TRADEMARK ON dbo.PRODUCT.TRADEMARKID = dbo.TRADEMARK.TRADEMARKID 
INNER JOIN dbo.PACKINGTYPE ON dbo.PRODUCT.PACKINGID = dbo.PACKINGTYPE.PACKINGID)
GO
/****** Object:  View [dbo].[orderproducts]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[orderproducts] as 
(
select ORDERID,dbo.TAKEORDER.CUSTOMERID,NAME,ORDERDATE,dbo.PRODUCT.PRODUCTID,PRODUCTNAME,INSTRUCTION,RETAILPRICE,QUANTITY,TOTALAMOUNT,DISCOUNT,GROSSAMOUNT from dbo.TAKEORDER 
inner join dbo.CUSTOMER on dbo.TAKEORDER.CUSTOMERID = dbo.CUSTOMER.CUSTOMERID
inner join dbo.PRODUCT on dbo.TAKEORDER.PRODUCTID = dbo.PRODUCT.PRODUCTID
)
GO
/****** Object:  Table [dbo].[ORDEREDPRODUCTS]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDEREDPRODUCTS](
	[ORDERID] [int] NULL,
	[PRODUCTID] [int] NULL,
	[QUANTITY] [int] NULL,
	[TOTALAMOUNT] [float] NULL,
	[DISCOUNT] [int] NULL,
	[GROSSAMOUNT] [float] NULL,
	[ORPID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ORPID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PLACEORDER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLACEORDER](
	[ORDERNUMBER] [int] IDENTITY(1,1) NOT NULL,
	[DISTRIBUTORID] [int] NULL,
	[ORDERDATE] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ORDERNUMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RETURNBYSHOPKEEPER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RETURNBYSHOPKEEPER](
	[RETURNID] [int] IDENTITY(1,1) NOT NULL,
	[DISTRIBUTORID] [int] NULL,
	[TRADEMARKID] [int] NULL,
	[ORDERID] [int] NULL,
	[PRODUCTID] [int] NULL,
	[RETURNQUANTITY] [int] NOT NULL,
	[AMOUNT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RETURNID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAYMENTBYSHOPKEEPER]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENTBYSHOPKEEPER](
	[BILLNUMBER] [int] IDENTITY(1,1) NOT NULL,
	[DISTRIBUTORID] [int] NULL,
	[ORDERNUMBER] [int] NOT NULL,
	[BILLAMOUNT] [float] NOT NULL,
	[PAIDAMOUNT] [int] NOT NULL,
	[BALANCE] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[BILLNUMBER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEMANDPRODUCTS]    Script Date: 07/18/2018 00:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEMANDPRODUCTS](
	[ORPID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERID] [int] NULL,
	[PRODUCTID] [int] NULL,
	[QUANTITY] [int] NULL,
	[TOTALAMOUNT] [float] NULL,
	[DISCOUNT] [int] NULL,
	[GROSSAMOUNT] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ORPID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK__TAKEORDER__CUSTO__24927208]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[TAKEORDER]  WITH CHECK ADD FOREIGN KEY([CUSTOMERID])
REFERENCES [dbo].[CUSTOMER] ([CUSTOMERID])
GO
/****** Object:  ForeignKey [FK__PRODUCT__BATCHID__1BFD2C07]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD FOREIGN KEY([BATCHID])
REFERENCES [dbo].[BATCH] ([BATCHID])
GO
/****** Object:  ForeignKey [FK__PRODUCT__PACKING__1B0907CE]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD FOREIGN KEY([PACKINGID])
REFERENCES [dbo].[PACKINGTYPE] ([PACKINGID])
GO
/****** Object:  ForeignKey [FK__PRODUCT__TRADEMA__1CF15040]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD FOREIGN KEY([TRADEMARKID])
REFERENCES [dbo].[TRADEMARK] ([TRADEMARKID])
GO
/****** Object:  ForeignKey [FK__REMINDER__EMPLOY__72C60C4A]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[REMINDER]  WITH CHECK ADD FOREIGN KEY([EMPLOYEEID])
REFERENCES [dbo].[EMPLOYEES] ([EMPLOYEEID])
GO
/****** Object:  ForeignKey [FK__DISTRIBUT__TRADE__3C69FB99]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[DISTRIBUTOR]  WITH CHECK ADD FOREIGN KEY([TRADEMARKID])
REFERENCES [dbo].[TRADEMARK] ([TRADEMARKID])
GO
/****** Object:  ForeignKey [FK__ASSIGNEDT__TASKI__534D60F1]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[ASSIGNEDTASKS]  WITH CHECK ADD FOREIGN KEY([TASKID])
REFERENCES [dbo].[TASKS] ([TASKID])
GO
/****** Object:  ForeignKey [FK_ASSIGNEDTASKS_EMPLOYEES]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[ASSIGNEDTASKS]  WITH CHECK ADD  CONSTRAINT [FK_ASSIGNEDTASKS_EMPLOYEES] FOREIGN KEY([EMPID])
REFERENCES [dbo].[EMPLOYEES] ([EMPLOYEEID])
GO
ALTER TABLE [dbo].[ASSIGNEDTASKS] CHECK CONSTRAINT [FK_ASSIGNEDTASKS_EMPLOYEES]
GO
/****** Object:  ForeignKey [FK__RETURNBYC__CUSTO__00200768]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYCUSTOMER]  WITH CHECK ADD FOREIGN KEY([CUSTOMERID])
REFERENCES [dbo].[CUSTOMER] ([CUSTOMERID])
GO
/****** Object:  ForeignKey [FK__RETURNBYC__ORDER__7E37BEF6]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYCUSTOMER]  WITH CHECK ADD FOREIGN KEY([ORDERID])
REFERENCES [dbo].[TAKEORDER] ([ORDERID])
GO
/****** Object:  ForeignKey [FK__RETURNBYC__PRODU__7F2BE32F]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYCUSTOMER]  WITH CHECK ADD FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[PRODUCT] ([PRODUCTID])
GO
/****** Object:  ForeignKey [FK__PAYMENTBY__CUSTO__2A4B4B5E]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PAYMENTBYCUSTOMER]  WITH CHECK ADD FOREIGN KEY([CUSTOMERID])
REFERENCES [dbo].[CUSTOMER] ([CUSTOMERID])
GO
/****** Object:  ForeignKey [FK__PAYMENTBY__ORDER__2B3F6F97]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PAYMENTBYCUSTOMER]  WITH CHECK ADD FOREIGN KEY([ORDERPRODUCTID])
REFERENCES [dbo].[TAKEORDER] ([ORDERID])
GO
/****** Object:  ForeignKey [FK_ORDEREDPRODUCTS_PRODUCT]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[ORDEREDPRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_ORDEREDPRODUCTS_PRODUCT] FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[PRODUCT] ([PRODUCTID])
GO
ALTER TABLE [dbo].[ORDEREDPRODUCTS] CHECK CONSTRAINT [FK_ORDEREDPRODUCTS_PRODUCT]
GO
/****** Object:  ForeignKey [FK_ORDEREDPRODUCTS_TAKEORDER]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[ORDEREDPRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_ORDEREDPRODUCTS_TAKEORDER] FOREIGN KEY([ORDERID])
REFERENCES [dbo].[TAKEORDER] ([ORDERID])
GO
ALTER TABLE [dbo].[ORDEREDPRODUCTS] CHECK CONSTRAINT [FK_ORDEREDPRODUCTS_TAKEORDER]
GO
/****** Object:  ForeignKey [FK__PLACEORDE__DISTR__440B1D61]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PLACEORDER]  WITH CHECK ADD FOREIGN KEY([DISTRIBUTORID])
REFERENCES [dbo].[DISTRIBUTOR] ([DISTRIBUTORID])
GO
/****** Object:  ForeignKey [FK__RETURNBYS__DISTR__04E4BC85]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYSHOPKEEPER]  WITH CHECK ADD FOREIGN KEY([DISTRIBUTORID])
REFERENCES [dbo].[DISTRIBUTOR] ([DISTRIBUTORID])
GO
/****** Object:  ForeignKey [FK__RETURNBYS__ORDER__06CD04F7]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYSHOPKEEPER]  WITH CHECK ADD FOREIGN KEY([ORDERID])
REFERENCES [dbo].[PLACEORDER] ([ORDERNUMBER])
GO
/****** Object:  ForeignKey [FK__RETURNBYS__PRODU__07C12930]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYSHOPKEEPER]  WITH CHECK ADD FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[PRODUCT] ([PRODUCTID])
GO
/****** Object:  ForeignKey [FK__RETURNBYS__TRADE__05D8E0BE]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[RETURNBYSHOPKEEPER]  WITH CHECK ADD FOREIGN KEY([TRADEMARKID])
REFERENCES [dbo].[TRADEMARK] ([TRADEMARKID])
GO
/****** Object:  ForeignKey [FK__PAYMENTBY__DISTR__49C3F6B7]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PAYMENTBYSHOPKEEPER]  WITH CHECK ADD FOREIGN KEY([DISTRIBUTORID])
REFERENCES [dbo].[DISTRIBUTOR] ([DISTRIBUTORID])
GO
/****** Object:  ForeignKey [FK__PAYMENTBY__ORDER__4AB81AF0]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[PAYMENTBYSHOPKEEPER]  WITH CHECK ADD FOREIGN KEY([ORDERNUMBER])
REFERENCES [dbo].[PLACEORDER] ([ORDERNUMBER])
GO
/****** Object:  ForeignKey [FK__DEMANDPRO__ORDER__282DF8C2]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[DEMANDPRODUCTS]  WITH CHECK ADD FOREIGN KEY([ORDERID])
REFERENCES [dbo].[PLACEORDER] ([ORDERNUMBER])
GO
/****** Object:  ForeignKey [FK__DEMANDPRO__PRODU__29221CFB]    Script Date: 07/18/2018 00:41:28 ******/
ALTER TABLE [dbo].[DEMANDPRODUCTS]  WITH CHECK ADD FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[PRODUCT] ([PRODUCTID])
GO
