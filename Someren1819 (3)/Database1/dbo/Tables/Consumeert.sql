CREATE TABLE [dbo].[Consumeert] (
    [DrankjeNaam]   VARCHAR (50) NOT NULL,
    [PersoonNummer] INT          NOT NULL,
    [Aantal]        INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([DrankjeNaam] ASC, [PersoonNummer] ASC),
    FOREIGN KEY ([DrankjeNaam]) REFERENCES [dbo].[Drankje] ([DrankjeNaam]),
    FOREIGN KEY ([PersoonNummer]) REFERENCES [dbo].[Persoon] ([PersoonNummer])
);

