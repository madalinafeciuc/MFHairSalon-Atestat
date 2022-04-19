CREATE TABLE [dbo].[Marfa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Tip_Produs] NVARCHAR(50) NULL, 
    [Nume_produs] NVARCHAR(50) NULL, 
    [Cantitate] INT NULL, 
    [Pret_(RON)] INT NULL, 
    [Data_expirare] DATE NULL, 
    [Furnizor] NVARCHAR(50) NULL
)
