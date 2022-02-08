CREATE TABLE [dbo].[TrackedTickets]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[UserId] INT NOT NULL, 
	[TicketId] INT NOT NULL,
)
