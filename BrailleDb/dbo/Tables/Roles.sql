﻿CREATE TABLE [dbo].[Roles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Visitor] BIT NOT NULL,
	[Admin] BIT NULL, 
	[Owner] BIT NULL
)
