CREATE TABLE [dbo].[AiubLink]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Phone] INT NULL, 
    [UserID] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Photo] IMAGE NULL, 
    [DOB] DATETIME NULL, 
    [Password] VARCHAR(50) NULL
)