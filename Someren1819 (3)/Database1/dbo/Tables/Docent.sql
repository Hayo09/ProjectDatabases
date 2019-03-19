CREATE TABLE [dbo].[Docent] (
    [DocentNummer]  INT          NOT NULL,
    [Naam]          VARCHAR (50) NOT NULL,
    [Tussenvoegsel] VARCHAR (10) NULL,
    [Achternaam]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([DocentNummer] ASC)
);

