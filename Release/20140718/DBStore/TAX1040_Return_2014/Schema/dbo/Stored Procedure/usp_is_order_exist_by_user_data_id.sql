/*************************************************************************************************
Created by Sathish on 18Jul2014 procedure check weather order exist for the user
**************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_is_order_exist_by_user_data_id]
@product_id BIGINT,
@user_data_id BIGINT
AS
BEGIN 
	SET NOCOUNT ON;

		IF EXISTS(SELECT 1 FROM [dbo].[shopping_cart] WITH(NOLOCK) 
			WHERE [user_data_id]=@user_data_id
			AND [product_id] = @product_id
			AND [is_deleted] = 1)
		BEGIN
			SELECT CAST(1 AS BIT) AS [is_order_exist] 
		END
		ELSE
		BEGIN
			SELECT CAST(0 AS BIT) AS [is_order_exist] 
		END
	SET NOCOUNT OFF;
END