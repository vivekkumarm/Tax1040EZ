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


--13 Aug 2014 Praveen T Included for Efile Service
CREATE SYNONYM [dbo].[efile_control] FOR TAX1040_Master_DB.[dbo].[efile_control]
CREATE SYNONYM [dbo].[efile_irs_users] FOR TAX1040_Master_DB.[dbo].[efile_irs_users]
CREATE SYNONYM [dbo].[efile_schema_version] FOR TAX1040_Master_DB.[dbo].[efile_schema_version]