CREATE TABLE [dbo].[Activiteit_Begeleiding] (
    [DocentNummer]   INT          NOT NULL,
    [ActiviteitNaam] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([DocentNummer] ASC, [ActiviteitNaam] ASC),
    FOREIGN KEY ([ActiviteitNaam]) REFERENCES [dbo].[Activiteit] ([ActiviteitNaam]),
    FOREIGN KEY ([DocentNummer]) REFERENCES [dbo].[Docent] ([DocentNummer])
);

