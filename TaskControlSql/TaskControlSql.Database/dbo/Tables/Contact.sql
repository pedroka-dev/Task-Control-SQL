CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] VARCHAR(500) NULL, 
    [Email] VARCHAR(500) NOT NULL, 
    [PhoneNumber] VARCHAR(500) NOT NULL, 
    [BusinessCompany] VARCHAR(500) NULL, 
    [CompanyPosition] VARCHAR(500) NULL
)