CREATE TABLE [dbo].[Symbols]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[SymbolName] VARCHAR(50) NOT NULL, 
	[SymbolId] INT NOT NULL, 
	[ChangeId] INT NULL, 
	CONSTRAINT [FK_Symbols_Symbol] FOREIGN KEY (SymbolId) REFERENCES Symbol(Id), 
	CONSTRAINT [FK_Symbols_Changes] FOREIGN KEY (ChangeId) REFERENCES Changes([Id])
)
