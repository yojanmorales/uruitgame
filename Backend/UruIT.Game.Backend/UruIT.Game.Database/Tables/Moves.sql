CREATE TABLE [dbo].[Moves](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL, 
    CONSTRAINT [PK_Moves] PRIMARY KEY ([Id]),
)