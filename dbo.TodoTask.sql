CREATE TABLE [dbo].[TodoTask] (
    [Id]                  INT          NOT NULL,
    [Priority]            VARCHAR (50) NOT NULL,
    [Title]               VARCHAR (50) NOT NULL,
    [DateCreation]        DATETIME     NOT NULL,
    [DateConclusion]      DATETIME     NULL,
    [PercentageConcluded] FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);