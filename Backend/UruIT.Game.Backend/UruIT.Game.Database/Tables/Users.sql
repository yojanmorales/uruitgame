CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
)