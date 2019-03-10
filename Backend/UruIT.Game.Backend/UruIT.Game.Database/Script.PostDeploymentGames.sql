/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [dbo].[Moves]
           ([Name])
     VALUES
           ('Rock')
GO

INSERT INTO [dbo].[Moves]
           ([Name])
     VALUES
           ('Paper')
GO

INSERT INTO [dbo].[Moves]
           ([Name])
     VALUES
           ('Scissors')
GO
