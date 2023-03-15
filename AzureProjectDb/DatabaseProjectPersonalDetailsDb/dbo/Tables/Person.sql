CREATE TABLE [dbo].[Person] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Surname]   NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    [LastLogin] DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO

