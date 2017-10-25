CREATE TABLE [dbo].[Sala]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Capacitate] INT NOT NULL, 
    [IdActivitate] INT NOT NULL
)
