CREATE TABLE [dbo].[TeamsTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Victories] INT NULL, 
    [Goals] INT NULL
)
