CREATE TABLE [dbo].[TBMateria] (
    [Numero]            INT          IDENTITY (1, 1) NOT NULL,
    [Titulo]            VARCHAR (50) NOT NULL,
    [Serie]             VARCHAR (50) NOT NULL,
    [Disciplina_Numero] INT          NOT NULL,
    CONSTRAINT [PK_TBMateria] PRIMARY KEY CLUSTERED ([Numero] ASC),
    CONSTRAINT [FK_TBMateria_TBDisciplina] FOREIGN KEY ([Disciplina_Numero]) REFERENCES [dbo].[TBDisciplina] ([Id])
);

