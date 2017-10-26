﻿CREATE TABLE [dbo].[SubGrupa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [IdGrupa] INT NOT NULL,
    CONSTRAINT [FK_SubGrupa_Grupa] FOREIGN KEY (IdGrupa) REFERENCES [Grupa]([Id])
)
