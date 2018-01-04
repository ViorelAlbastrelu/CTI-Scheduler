CREATE TABLE [dbo].[Modul]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdZi] INT NOT NULL, 
    [IdDisciplina] INT NOT NULL, 
    [IdActivitate] INT NOT NULL, 
    [IdProfesor] INT NOT NULL,
	[IdSubGrupa] INT NOT NULL,
	[IdSala] INT NOT NULL,
    [OraStart] TIME NOT NULL, 
    [OraStop] TIME NOT NULL, 
    [SaptPara] BIT NULL, 
    CONSTRAINT [FK_Modul_ZI] FOREIGN KEY (IdZi) REFERENCES [Zile]([Id]), 
    CONSTRAINT [FK_Modul_Disciplina] FOREIGN KEY (IdDisciplina) REFERENCES [Disciplina]([Id]), 
    CONSTRAINT [FK_Modul_Activitate] FOREIGN KEY (IdActivitate) REFERENCES [Activitate]([Id]), 
    CONSTRAINT [FK_Modul_Profesor] FOREIGN KEY (IdProfesor) REFERENCES [Profesor]([Id]),
	CONSTRAINT [FK_Modul_SubGrupa] FOREIGN KEY (IdSubGrupa) REFERENCES [SubGrupa](Id),
	CONSTRAINT [FK_Modul_Sala] FOREIGN KEY (IdSala) REFERENCES [Sala](Id)

)
