CREATE TABLE [dbo].[Notes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Note] VARCHAR(500) NOT NULL, 
	[TicketId] INT NOT NULL, 
	[CreatedId] INT NOT NULL, 
	[AssignedId] INT NULL, 
	[NoteCreated] DATETIME2 NOT NULL, 
	[NoteUpdated] DATETIME2 NOT NULL, 
	CONSTRAINT [FK_Notes_Tickets] FOREIGN KEY (TicketId) REFERENCES Tickets(Id), 
	CONSTRAINT [FK_Notes_Users] FOREIGN KEY (CreatedId) REFERENCES Users(Id)
)
