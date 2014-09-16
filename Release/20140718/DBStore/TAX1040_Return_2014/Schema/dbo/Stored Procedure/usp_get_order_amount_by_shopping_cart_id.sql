/*********************************************************************************************
Created by Ashok Kumar - 21st May, 2014 -  Get Order Amount  based on Shopping Cart ID.  
*********************************************************************************************/
/* Modification History */
/* 07Jul2014 Sathish return total sum of price for federal and state */
CREATE PROCEDURE [dbo].[usp_get_order_amount_by_shopping_cart_id]
@product_id BIGINT,
@user_data_id BIGINT
AS
BEGIN
	SET NOCOUNT ON;
		BEGIN
			--SELECT SUM(sku_price) order_amount FROM  [dbo].[order_detail_mapper] WITH(NOLOCK)
			--WHERE [shopping_cart_id] = @shopping_cart_id
			--	AND [is_deleted] = 0
			
			SELECT SUM(price) AS price FROM 
			(SELECT SUM(ff.[federal_price]) AS price 
			FROM [dbo].[user_feature]  AS uf WITH(NOLOCK)
				INNER JOIN [dbo].[federal_feature_sku] ff
					on uf.[federal_feature_sku_id] = ff.[feature_id]
				INNER JOIN [dbo].[feature] f
					on f.[feature_id] = ff.[federal_feature_sku_id]
					where ff.[product_id] =  @product_id
						AND uf.[user_data_id] = @user_data_id
			UNION			
			SELECT SUM(sf.[state_price]) AS price FROM [dbo].[user_feature] AS uf
				INNER JOIN [dbo].[state_feature_sku] sf
					on uf.[state_feature_sku_id] = sf.[state_feature_sku_id]
				INNER JOIN [dbo].[feature] f
					on f.[feature_id] = sf.[feature_id]
			WHERE sf.[product_id] =  @product_id
				AND uf.[user_data_id] = @user_data_id	)order_price 		
			
			
		END
	SET NOCOUNT OFF;	
END