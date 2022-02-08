CREATE TABLE [dbo].[Roles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [User] BIT NULL, 
    [Admin] BIT NULL, 
    [Owner] BIT NULL
)
