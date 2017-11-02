CREATE TABLE [dbo].[Sala]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(10) NOT NULL, 
    [Capacitate] INT NOT NULL, 
    [Activitate] INT NOT NULL, 
    CONSTRAINT [FK_Sala_Activitate] FOREIGN KEY ([Activitate]) REFERENCES [Activitate]([Id])
)
