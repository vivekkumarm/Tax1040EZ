/*********************************************************************************************
Created by Ashok Kumar - 21st May, 2014 -  Get Order Amount  based on Shopping Cart ID.  
*********************************************************************************************/
/* Modification History */
/* */
CREATE PROCEDURE dbo.usp_get_order_amount_by_shopping_cart_id
@shopping_cart_id BIGINT
AS
BEGIN
	SET NOCOUNT ON;
		BEGIN
			SELECT SUM(sku_price) order_amount FROM  [dbo].[order_detail_mapper] WITH(NOLOCK)
			WHERE [shopping_cart_id] = @shopping_cart_id
				AND [is_deleted] = 0
		END
	SET NOCOUNT OFF;	
END