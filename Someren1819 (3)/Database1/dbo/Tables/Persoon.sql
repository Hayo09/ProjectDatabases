CREATE TABLE [dbo].[Persoon] (
    [PersoonNummer] INT NOT NULL,
    [StudentNummer] INT NULL,
    [DocentNummer]  INT NULL,
    PRIMARY KEY CLUSTERED ([PersoonNummer] ASC),
    FOREIGN KEY ([DocentNummer]) REFERENCES [dbo].[Docent] ([DocentNummer]),
    FOREIGN KEY ([StudentNummer]) REFERENCES [dbo].[Student] ([StudentNummer])
);

