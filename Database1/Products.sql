CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL identity(1, 1) PRIMARY KEY,
	[NAME] nvarchar(200) not null,
	[Category_id] int not null
)
