
/*********************************************************************************************
Created by Ashok Kumar – 3rd June, 2014 -  Get Product Sku based on Product ID and State IDS.  
*********************************************************************************************/
/* Modification History */
/* 07Jul2014 Sathish commented order detail mapper persit*/
CREATE PROCEDURE [dbo].[usp_shopping_cart_and_order_detail_mapper_persist]
(
	@user_data_id BIGINT,
	@product_id BIGINT
)
AS
BEGIN
SET NOCOUNT ON;
          
          DECLARE @Shopping_Identity BIGINT

           INSERT INTO [dbo].[shopping_cart]
            (
            [user_data_id],
            [product_id],  
            [is_deleted] ,
            [create_timestamp],
            [update_timestamp]
            )
            VALUES
            (  
            @user_data_id,
            @product_id,
            0,
            GETDATE(),
            GETDATE()
            )
           SELECT @Shopping_Identity=@@IDENTITY
           
           --CREATE TABLE #temp(sku_id BIGINT ,sku_price NUMERIC(15, 2),state_id BIGINT,sku_description [VARCHAR](100),[sku_name] [VARCHAR](50))
           
           --INSERT INTO #temp(sku_id,sku_name,sku_description,sku_price,state_id)
           
           --EXECUTE [dbo].[usp_get_all_productsku_by_product_id_and_state_ids] @product_id,@state_ids
           
           --INSERT INTO [dbo].[order_detail_mapper]
           -- (
           --  [shopping_cart_id],
           --  [sku_id],
           --  [sku_price],
           --  [state_id],
           --  [is_deleted],
           --  [create_timestamp],
           --  [update_timestamp]
           -- )
           -- SELECT @Shopping_Identity,[sku_id],[sku_price],[state_id],0,GETDATE(),GETDATE()
           -- FROM #temp 
            
           -- DROP TABLE #temp
            
           SELECT @Shopping_Identity AS shopping_cart_id

SET NOCOUNT OFF;
END