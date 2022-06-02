CREATE TABLE [dbo].[TBQuestao] (
    [Numero]            INT           IDENTITY (1, 1) NOT NULL,
    [Enunciado]         VARCHAR (200) NOT NULL,
    [Disciplina_Numero] INT           NOT NULL,
    [Materia_Numero]    INT           NOT NULL,
    CONSTRAINT [PK_TBQuestao] PRIMARY KEY CLUSTERED ([Numero] ASC)
);

