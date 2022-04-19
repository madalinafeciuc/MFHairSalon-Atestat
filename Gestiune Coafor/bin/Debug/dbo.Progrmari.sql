CREATE TABLE [dbo].[Progrmari] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nume_client]     NVARCHAR (50) NULL,
    [Prenume_client]  NVARCHAR (50) NULL,
    [Data]            DATE          NULL,
    [Ora]             FLOAT      NULL,
    [Serviciu]        NVARCHAR (50) NULL,
    [Nume_specialist] NVARCHAR (50) NULL,
    [Pret]            INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

