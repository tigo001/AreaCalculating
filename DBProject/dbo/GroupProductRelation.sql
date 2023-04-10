CREATE TABLE [dbo].[GroupProductRelation] (
	[ID] INT IDENTITY NOT NULL,
	[GroupId] INT NULL,
	[ProductId] INT NOT NULL,
	CONSTRAINT [FK_GroupProductRelation_Groups] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([ID]),
	CONSTRAINT [FK_GroupProductRelation_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ID]),
	CONSTRAINT [PK_GroupProductRelation] PRIMARY KEY ([ID]),
)