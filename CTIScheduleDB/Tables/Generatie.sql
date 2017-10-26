﻿CREATE TABLE [dbo].[Generatie]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AnStart] INT NOT NULL, 
    [AnStop] INT NOT NULL, 
    [AnStudiu] INT NOT NULL,
    CONSTRAINT [FK_Generatie_Disciplina] FOREIGN KEY (AnStudiu) REFERENCES [Disciplina]([An])
)