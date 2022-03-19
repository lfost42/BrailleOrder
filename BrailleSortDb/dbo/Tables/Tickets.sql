CREATE TABLE [dbo].[Tickets]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[TicketSubject] VARCHAR(50) NOT NULL, 
	[StatusClosed] BIT NOT NULL DEFAULT 0, 
	[TicketCreated] DATETIME2 NOT NULL, 
	[TicketUpdated] DATETIME2 NOT NULL

)
