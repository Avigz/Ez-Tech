CREATE TABLE [dbo].[Hjælpere] (
    [ID]            INT           NOT NULL,
    [Navn]          VARCHAR (255) NOT NULL,
    [TelefonNummer] VARCHAR (11)  NOT NULL,
    [Kodeord]       VARCHAR (255) NOT NULL,
    [Email]         VARCHAR (255) NOT NULL,
    [IsAdmin]       BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

