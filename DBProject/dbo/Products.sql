﻿CREATE TABLE [dbo].[Products] (
	[ID] INT IDENTITY NOT NULL,
	[Name] NVARCHAR(250) NOT NULL,
	CONSTRAINT [PK_Products] PRIMARY KEY ([ID])
)