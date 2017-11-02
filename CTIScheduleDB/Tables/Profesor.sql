CREATE TABLE [dbo].[Profesor]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Prenume] NVARCHAR(50) NOT NULL, 
    [Disciplina] INT NOT NULL, 
    CONSTRAINT [FK_Profesor_Disciplina] FOREIGN KEY ([Disciplina]) REFERENCES [Disciplina]([Id])
)
