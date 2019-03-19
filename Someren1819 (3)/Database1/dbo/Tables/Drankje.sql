CREATE TABLE [dbo].[Drankje] (
    [DrankjeNaam]  VARCHAR (50) NOT NULL,
    [VerkoopPrijs] FLOAT (53)   NOT NULL,
    [BTW]          TEXT         NOT NULL,
    [Voorraad]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([DrankjeNaam] ASC)
);

