CREATE TABLE [dbo].[Activiteit_Deelname] (
    [StudentNummer]  INT          NOT NULL,
    [ActiviteitNaam] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentNummer] ASC, [ActiviteitNaam] ASC),
    FOREIGN KEY ([ActiviteitNaam]) REFERENCES [dbo].[Activiteit] ([ActiviteitNaam]),
    FOREIGN KEY ([StudentNummer]) REFERENCES [dbo].[Student] ([StudentNummer])
);

