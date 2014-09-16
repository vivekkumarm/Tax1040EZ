/*********************************************************************************************
Created by Sathish 03Jul2014 get federal sku.  
*********************************************************************************************/
/* Modification History */
/* */
CREATE PROCEDURE [dbo].[usp_get_federal_return_sku]
AS
BEGIN
SET NOCOUNT ON;	
	BEGIN
		SELECT 
			[federal_sku_id],
			[federal_sku_name],
			[description],
			[price]
		FROM
			[dbo].[federal_sku] WITH(NOLOCK)
		WHERE 
			([is_active]=1 AND 
			[is_deleted]=0)
	END
SET NOCOUNT OFF;
END
