CREATE TABLE [dbo].[Student] (
    [StudentNummer] INT          NOT NULL,
    [Naam]          VARCHAR (50) NOT NULL,
    [Tussenvoegsel] VARCHAR (10) NULL,
    [Achternaam]    VARCHAR (50) NOT NULL,
    [Klas]          VARCHAR (6)  NOT NULL,
    [GeboorteDatum] DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentNummer] ASC)
);

