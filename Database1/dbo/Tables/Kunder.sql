CREATE TABLE [dbo].[Kunder] (
    [KundeID]      INT           NOT NULL,
    [KundeNavn]    VARCHAR (255) NOT NULL,
    [KundeNummer]  VARCHAR (11)  NOT NULL,
    [KundeAdresse] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([KundeID] ASC)
);

