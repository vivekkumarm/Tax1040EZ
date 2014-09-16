
/*********************************************************************************************
Created by Sathish - 15July2014 -  Persist User feature  
*********************************************************************************************/
/* Modification History */
CREATE PROCEDURE [dbo].[usp_persist_user_feature]
@product_id BIGINT,
@user_data_id BIGINT
AS
BEGIN
	SET NOCOUNT ON;
		BEGIN
			IF NOT EXISTS( SELECT [user_data_id] FROM [dbo].[user_feature]
							WHERE [user_data_id] = @user_data_id)
			BEGIN
					INSERT INTO [dbo].[user_feature]([user_data_id],[federal_feature_sku_id])
							(SELECT @user_data_id,
								  [federal_feature_sku_id] 
							FROM [dbo].[federal_feature_sku] WITH(NOLOCK)
							WHERE [product_id] = @product_id)		
					
					INSERT INTO [dbo].[user_feature]([user_data_id],[state_feature_sku_id])
								(SELECT  @user_data_id,
										[state_feature_sku_id] 
								FROM [dbo].[state_feature_sku] WITH(NOLOCK)
								WHERE [product_id] = @product_id)
			END
		
		END
	SET NOCOUNT OFF;	
END