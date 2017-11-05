CREATE TABLE [dbo].[DisciplinaProfesor]
(
	[Id_Disciplina] INT NOT NULL, 
    [Id_Profesor] INT NOT NULL, 
    CONSTRAINT [FK_DisciplinaProfesor_Disciplina] FOREIGN KEY (Id_Disciplina) REFERENCES [Disciplina](Id),
    CONSTRAINT [FK_DisciplinaProfesor_Profesor] FOREIGN KEY (Id_Profesor) REFERENCES [Profesor](Id),
)
