USE [viajett]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/15/2019 11:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](50) NOT NULL,
	[TeamId] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportingPeriod]    Script Date: 5/15/2019 11:09:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportingPeriod](
	[ReportingPeriodId] [uniqueidentifier] NOT NULL,
	[Year] [int] NOT NULL,
	[PeriodNumber] [int] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ReportingPeriod] PRIMARY KEY CLUSTERED 
(
	[ReportingPeriodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 5/15/2019 11:09:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[TaskId] [uniqueidentifier] NOT NULL,
	[TeamId] [uniqueidentifier] NULL,
	[Name] [varchar](500) NOT NULL,
	[Description] [varchar](2000) NULL,
	[TaskCategoryId] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskCategory]    Script Date: 5/15/2019 11:09:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskCategory](
	[TaskCategoryId] [uniqueidentifier] NOT NULL,
	[CategoryName] [varchar](200) NOT NULL,
 CONSTRAINT [PK_TaskCategory] PRIMARY KEY CLUSTERED 
(
	[TaskCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskEntry]    Script Date: 5/15/2019 11:09:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskEntry](
	[TaskEntryId] [uniqueidentifier] NOT NULL,
	[EmployeeId] [uniqueidentifier] NOT NULL,
	[ReportingPeriodId] [uniqueidentifier] NOT NULL,
	[TaskId] [uniqueidentifier] NOT NULL,
	[Hours] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_TaskEntry] PRIMARY KEY CLUSTERED 
(
	[TaskEntryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 5/15/2019 11:09:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[TeamId] [uniqueidentifier] NOT NULL,
	[TeamName] [varchar](100) NOT NULL,
	[ManagerId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Team] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Team]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_TaskCategory] FOREIGN KEY([TaskCategoryId])
REFERENCES [dbo].[TaskCategory] ([TaskCategoryId])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_TaskCategory]
GO
ALTER TABLE [dbo].[TaskEntry]  WITH CHECK ADD  CONSTRAINT [FK_TaskEntry_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[TaskEntry] CHECK CONSTRAINT [FK_TaskEntry_Employee]
GO
ALTER TABLE [dbo].[TaskEntry]  WITH CHECK ADD  CONSTRAINT [FK_TaskEntry_ReportingPeriod] FOREIGN KEY([ReportingPeriodId])
REFERENCES [dbo].[ReportingPeriod] ([ReportingPeriodId])
GO
ALTER TABLE [dbo].[TaskEntry] CHECK CONSTRAINT [FK_TaskEntry_ReportingPeriod]
GO
ALTER TABLE [dbo].[TaskEntry]  WITH CHECK ADD  CONSTRAINT [FK_TaskEntry_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([TaskId])
GO
ALTER TABLE [dbo].[TaskEntry] CHECK CONSTRAINT [FK_TaskEntry_Task]
GO
