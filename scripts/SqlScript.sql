--Create tables

CREATE TABLE [dbo].[Measures](
	[Id] [INT] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Subject] [NVARCHAR](100) NOT NULL,
	[Description] [NVARCHAR](MAX) NOT NULL,
	[MinimumNoOfVotesRequired] [INT] NOT NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedDate] [datetime] NULL
)

CREATE TABLE [dbo].[Options](
	[Id] [INT] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[MeasureId] INT FOREIGN KEY REFERENCES [dbo].[Measures](Id),
	[Value] [NVARCHAR](100) NOT NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedDate] [datetime] NULL
)

CREATE TABLE [dbo].[Users](
	[Id] [INT] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [NVARCHAR](100) NOT NULL,
	[Email] [NVARCHAR](100) NOT NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedDate] [datetime] NULL
)

CREATE TABLE [dbo].[Votings](
	[Id] [INT] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[MeasureId] INT FOREIGN KEY REFERENCES [dbo].[Measures](Id),
	[UserId] INT FOREIGN KEY REFERENCES [dbo].[Users](Id),
	[OptionId] INT FOREIGN KEY REFERENCES [dbo].[Options](Id),
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedDate] [datetime] NULL
)

--Seed data

INSERT INTO Users ([Name], [Email]) VALUES
('Ben', 'Ben@abc.com'),
('Tom', 'Tom@abc.com')