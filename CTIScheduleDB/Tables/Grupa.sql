CREATE TABLE [dbo].[Grupa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [IdGeneratie] INT NOT NULL,
    CONSTRAINT [FK_Grupa_Generatie] FOREIGN KEY (IdGeneratie) REFERENCES [Generatie]([Id])
)
