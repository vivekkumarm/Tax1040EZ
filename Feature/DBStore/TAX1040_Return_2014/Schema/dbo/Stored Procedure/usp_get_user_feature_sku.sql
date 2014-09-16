/*********************************************************************************************
Created by Sathish - 4Jul2014 get user order 
*********************************************************************************************/
/* Modification History */
/* */
CREATE PROCEDURE dbo.usp_get_user_feature_sku
@product_id BIGINT,
@user_data_id BIGINT
AS
BEGIN
	SET NOCOUNT ON;
		BEGIN
			SELECT 0 AS [federal_id],
				   'Federal' AS [federal], 
				   SUM([federal_feature].[federal_price]) AS [federal_price] 
			FROM (SELECT f.[feature_name],f.[description],ff.[federal_price] FROM [dbo].[user_feature]  AS uf WITH(NOLOCK)
				INNER JOIN [dbo].[federal_feature_sku] ff
					on uf.[federal_feature_sku_id] = ff.[feature_id]
				INNER JOIN [dbo].[feature] f
					on f.[feature_id] = ff.[federal_feature_sku_id]
					where ff.[product_id] =  @product_id
						AND uf.user_data_id = @user_data_id ) federal_feature
					

		SELECT [state_feature].[state_id],
					s.[state_name],
					SUM([state_feature].[state_price]) as state_price 
			FROM (SELECT f.[feature_name],f.[description],sf.[state_id],sf.[state_price] FROM [dbo].[user_feature] AS uf
				INNER JOIN [dbo].[state_feature_sku] sf
					on uf.[state_feature_sku_id] = sf.[state_feature_sku_id]
				INNER JOIN [dbo].[feature] f
					on f.[feature_id] = sf.[feature_id]
			WHERE sf.[product_id] =  @product_id
				AND uf.user_data_id = @user_data_id ) [state_feature]
			INNER JOIN [state] AS s
				on s.[state_id] = [state_feature].[state_id]
			GROUP BY [state_feature].[state_id],s.[state_name]
			
		END
	SET NOCOUNT OFF;	
END