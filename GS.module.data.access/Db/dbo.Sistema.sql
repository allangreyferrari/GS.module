CREATE TABLE [dbo].[Sistema]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(80) NULL, 
    [Descripcion] VARCHAR(350) NULL, 
    [Password] VARCHAR(50) NULL, 
    [Key] VARCHAR(50) NULL, 
    [Estado] BIT NULL, 
    [Poolname] VARCHAR(200) NULL, 
    [Fileconfig] VARCHAR(500) NULL
)
