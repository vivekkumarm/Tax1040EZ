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

INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Receive Return');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Schema Conversion');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Schema Validation');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Business Validation');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Zip');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Send');
INSERT INTO [dbo].[efile_stage] ([stage_description]) VALUES ('Ping');