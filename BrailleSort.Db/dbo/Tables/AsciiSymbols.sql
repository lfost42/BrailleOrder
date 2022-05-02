CREATE TABLE [dbo].[AsciiSymbols]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[AsciiId] INT NOT NULL, 
	[SymbolId] INT NOT NULL, 
	[CreatorId] NVARCHAR(450) NOT NULL, 
	[ChangeId] INT NULL, 
	CONSTRAINT [FK_AsciiSymbols_Ascii] FOREIGN KEY (AsciiId) REFERENCES Ascii(Id), 
	CONSTRAINT [FK_AsciiSymbols_Symbols] FOREIGN KEY (SymbolId) REFERENCES Symbols(Id),
	CONSTRAINT [FK_AsciiSymbols_Creators] FOREIGN KEY (CreatorId) REFERENCES AspNetUsers(Id),
	CONSTRAINT [FK_AsciiSymbols_Changes] FOREIGN KEY (ChangeId) REFERENCES Changes(Id)
)
