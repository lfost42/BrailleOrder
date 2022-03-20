CREATE TABLE [dbo].[TicketNotes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[TicketId] INT NOT NULL, 
	[NoteId] INT NOT NULL, [CreatorId] NVARCHAR(450) NOT NULL,
	[ChangeId] INT NULL, 
	CONSTRAINT [FK_TicketNotes_Tickets] FOREIGN KEY (TicketId) REFERENCES Tickets(Id), 
	CONSTRAINT [FK_TicketNotes_Notes] FOREIGN KEY (NoteId) REFERENCES Notes(Id), 
	CONSTRAINT [FK_TicketNotes_Creators] FOREIGN KEY (CreatorId) REFERENCES AspNetUsers(Id),
	CONSTRAINT [FK_TicketNotes_Changes] FOREIGN KEY (ChangeId) REFERENCES Changes(Id), 

	
)
