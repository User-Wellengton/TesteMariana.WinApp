CREATE TABLE [dbo].[TBTeste] (
    [Numero]              INT           IDENTITY (1, 1) NOT NULL,
    [Nome]                VARCHAR (200) NOT NULL,
    [Quantidade_Questoes] INT           NOT NULL,
    [Disciplina_Numero]   INT           NOT NULL,
    [Materia_Numero]      INT           NOT NULL,
    [Data_Criacao]        DATE          NOT NULL,
    CONSTRAINT [FK_TBTeste_TBDisciplina] FOREIGN KEY ([Disciplina_Numero]) REFERENCES [dbo].[TBDisciplina] ([Id]),
    CONSTRAINT [FK_TBTeste_TBMateria] FOREIGN KEY ([Materia_Numero]) REFERENCES [dbo].[TBMateria] ([Numero])
);

