CREATE TABLE [dbo].[Contact] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Name]            VARCHAR (500) NULL,
    [Email]           VARCHAR (500) NOT NULL,
    [PhoneNumber]     VARCHAR (500) NOT NULL,
    [BusinessCompany] VARCHAR (500) NULL,
    [CompanyPosition] VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

