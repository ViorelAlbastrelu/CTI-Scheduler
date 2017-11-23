CREATE TABLE [dbo].[DisciplinaActivitate]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Id_Disciplina] INT NOT NULL, 
    [Id_Activitate] INT NOT NULL, 
    [Nr_Module] INT NOT NULL, 
    CONSTRAINT [FK_DisciplinaActivitate_Disciplina] FOREIGN KEY ([Id_Disciplina]) REFERENCES [Disciplina]([Id]),
    CONSTRAINT [FK_DisciplinaActivitate_Activitate] FOREIGN KEY ([Id_Activitate]) REFERENCES [Activitate]([Id])
)
/* 
	nr modul se calculeaza la doua saptamani 
*/
