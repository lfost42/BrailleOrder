CREATE TABLE [dbo].[Symbol]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Symbol] VARCHAR(20) NOT NULL, 
	[ChangeId] INT NULL, 
	CONSTRAINT [FK_Symbol_Changes] FOREIGN KEY (ChangeId) REFERENCES Changes([Id])
)
