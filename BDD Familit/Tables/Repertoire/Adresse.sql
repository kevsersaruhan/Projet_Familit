CREATE TABLE [dbo].[Adresse]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AdRue] NCHAR(60) NOT NULL, 
    [AdNum] NCHAR(6) NOT NULL, 
    [AdCp] INT NOT NULL, 
    [AdVille] NCHAR(60) NOT NULL, 
    [AdPays] NCHAR(60) NOT NULL, 
    [NumTel] INT NULL, 
    [EMail] NCHAR(60) NULL
)
