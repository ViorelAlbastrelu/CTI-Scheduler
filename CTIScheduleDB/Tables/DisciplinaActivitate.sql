CREATE TABLE [dbo].[DisciplinaActivitate]
(
    [Id_Disciplina] INT NOT NULL, 
    [Id_Activitate] INT NOT NULL, 
    [NrOre] INT NOT NULL, 
    CONSTRAINT [FK_DisciplinaActivitate_Disciplina] FOREIGN KEY ([Id_Disciplina]) REFERENCES [Disciplina]([Id]),
    CONSTRAINT [FK_DisciplinaActivitate_Activitate] FOREIGN KEY ([Id_Activitate]) REFERENCES [Activitate]([Id])
	
)
