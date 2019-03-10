CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Round] [int] NOT NULL, 
    CONSTRAINT [PK_Games] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Games_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]),
 )

