/*********************************************************************************************
Created by Ashok Kumar - 2nd June, 2014 -  Get All Product Sku based on Product ID and State IDs.  
*********************************************************************************************/
/* Modification History */
/* */
CREATE PROCEDURE [dbo].[usp_get_all_productsku_by_product_id_and_state_ids]
(
	@product_id INT,
	@state_ids VARCHAR(100)
)
AS
BEGIN
SET NOCOUNT ON;	
	BEGIN
		SELECT 
			[sku_id],
			[sku_name],
			[sku_description],
			[sku_price],
			[state_id]
		FROM
			[dbo].[product_sku] WITH(NOLOCK)
		WHERE 
			([is_active]=1 AND 
			[is_deleted]=0 AND 
			[product_id] = @product_id AND 
			[state_id] IN (SELECT Items FROM [dbo].[SplitString](@state_ids, ',')))
	END
SET NOCOUNT OFF;
END
