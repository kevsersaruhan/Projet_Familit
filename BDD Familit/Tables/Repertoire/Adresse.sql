CREATE TABLE [dbo].[Adresse]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AdRue] NVARCHAR(60) NOT NULL, 
    [AdNum] NVARCHAR(6) NOT NULL, 
    [AdCp] INT NOT NULL, 
    [AdVille] NVARCHAR(60) NOT NULL, 
    [AdPays] NVARCHAR(60) NOT NULL, 
    [NumTel] INT NULL, 
    [EMail] NVARCHAR(60) NULL
)
