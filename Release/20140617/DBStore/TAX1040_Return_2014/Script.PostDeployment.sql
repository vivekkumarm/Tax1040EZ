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
/*6June2014 Ashok Kumar Added Post deployment script*/

/*6June2014 Ashok Kumar Added Synonym to Returns database for accessing a stored procedure from Master Database.*/
CREATE SYNONYM [dbo].[usp_get_all_productsku_by_product_id_and_state_ids] FOR TAX1040_Master_DB.[dbo].[usp_get_all_productsku_by_product_id_and_state_ids]
CREATE SYNONYM [dbo].[usp_get_all_productsku_by_product_id] FOR TAX1040_Master_DB.[dbo].[usp_get_all_productsku_by_product_id] 
CREATE SYNONYM [dbo].[product_sku] FOR TAX1040_Master_DB.[dbo].[product_sku]