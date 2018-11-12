/******************************************************************************
 * USER DEFINED TABLES                                                        *
 ******************************************************************************/
--Table: [dbo].[TableName] - Description
IF OBJECT_ID ('[dbo].[TestTable2]', 'U') IS NOT NULL
	DROP TABLE [dbo].[TestTable2];
IF OBJECT_ID ('[dbo].[TestTable2]', 'U') IS NULL
BEGIN
	CREATE TABLE [dbo].[TestTable2] (
	/**********************************************************
	 *          Name: [dbo].[TableName]
	 *        Author: 
	 *   Create Date: 
	 *   Description: 
	 * *********************************************************/
		[Id] INT IDENTITY(1, 1) NOT NULL
		, [Text] VARCHAR(100) NOT NULL
		, [AddedDate] DATETIME NULL
		, [AddedWho] VARCHAR(100) NULL
		, CONSTRAINT [PKAF00100] PRIMARY KEY NONCLUSTERED ([Text] ASC) WITH (
			PAD_INDEX = OFF
			, STATISTICS_NORECOMPUTE = OFF
			, IGNORE_DUP_KEY = OFF
			, ALLOW_ROW_LOCKS = ON
			, ALLOW_PAGE_LOCKS = ON
			)
		ON [PRIMARY]
		) ON [PRIMARY]
	;
END
GO

ALTER TABLE [dbo].[TestTable2] ADD CONSTRAINT [DF_TestTable2_AddedDate] DEFAULT(GETDATE()) FOR [AddedDate];
GO

ALTER TABLE [dbo].[TestTable2] ADD CONSTRAINT [DF_TestTable2_AddedWho] DEFAULT(SUSER_NAME()) FOR [AddedWho];
GO

INSERT INTO [dbo].[TestTable2] ([Text]) VALUES ('In Pre-Deployment');
SELECT * FROM [dbo].[TestTable2];
