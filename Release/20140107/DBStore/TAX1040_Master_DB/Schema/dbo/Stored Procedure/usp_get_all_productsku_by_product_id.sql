/*********************************************************************************************
Created by Ashok Kumar - 14th May, 2014 -  Get All Product Sku based on Product ID.  
*********************************************************************************************/
/* Modification History */
/* */
CREATE PROCEDURE [dbo].[usp_get_all_productsku_by_product_id]
(
	@product_id INT
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
			([is_active]=1 AND [is_deleted]=0
			 AND [product_id] = @product_id)
	END
SET NOCOUNT OFF;
END
