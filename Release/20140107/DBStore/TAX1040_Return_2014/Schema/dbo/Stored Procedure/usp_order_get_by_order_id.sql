/*********************************************************************************************
Created by Ashok Kumar - 16th May, 2014 -  Get Order against order Id.  
*********************************************************************************************/
/*Modification History*/
/* */

CREATE PROCEDURE usp_order_get_by_order_id
@order_id BIGINT
AS 
BEGIN
SET NOCOUNT ON;

	SELECT	o.[order_id],
			o.[user_data_id],
            o.[shopping_cart_id],
            o.[order_amount],
            o.[card_number] ,
            o.[cardtype_id] ,
            o.[card_expires],
            o.[processed] ,
            o.[time] ,
            o.[o_authorization] ,
            o.[ip_address] ,
            ob.[name] ,
            ob.[email] ,
            ob.[street_address] ,
			ob.[apartment_number],
            ob.[city] ,
            ob.[state_name] ,
            ob.[country_name] ,
            ob.[phone] ,
            ob.[postcode]
    FROM [dbo].[order] o WITH(NOLOCK)
    INNER JOIN [dbo].[order_billing_address] ob 
				ON o.[order_id]=ob.[order_id]
    WHERE o.[order_id]=@order_id

	 SELECT
		odm.[sku_id],
		ps.[sku_name],
		ps.[sku_description],
		odm.[sku_price],
		odm.[state_id]
	FROM
		[dbo].[order_detail_mapper] odm 
		INNER JOIN [dbo].[shopping_cart] sc on odm.[shopping_cart_id]=sc.[shopping_cart_id]
		INNER JOIN [dbo].[order] o on o.[shopping_cart_id]=sc.[shopping_cart_id]
		INNER JOIN [dbo].[product_sku] ps on ps.[sku_id]=odm.[sku_id] 
	WHERE o.[order_id]=@order_id

SET NOCOUNT OFF;
END


