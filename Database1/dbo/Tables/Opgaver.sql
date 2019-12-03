CREATE TABLE [dbo].[Opgaver] (
    [ID]                INT           NOT NULL,
    [KundeID]           INT           NOT NULL,
    [Beskrivelse]       VARCHAR (255) NULL,
    [HjælperTilknyttet] INT           NULL,
    [IsDone]            BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([KundeID]) REFERENCES [dbo].[Kunder] ([KundeID])
);

