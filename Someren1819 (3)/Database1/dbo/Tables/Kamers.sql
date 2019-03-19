CREATE TABLE [dbo].[Kamers] (
    [KamerNummer]   INT NOT NULL,
    [PersoonNummer] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([KamerNummer] ASC),
    FOREIGN KEY ([PersoonNummer]) REFERENCES [dbo].[Persoon] ([PersoonNummer])
);

