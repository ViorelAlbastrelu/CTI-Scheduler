CREATE TABLE [dbo].[Disciplina]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NVARCHAR(50) NOT NULL, 
	[NumeScurt] NVARCHAR(10) NOT NULL, 
    [An] INT NOT NULL, 
    [Semestru] INT NOT NULL
)
