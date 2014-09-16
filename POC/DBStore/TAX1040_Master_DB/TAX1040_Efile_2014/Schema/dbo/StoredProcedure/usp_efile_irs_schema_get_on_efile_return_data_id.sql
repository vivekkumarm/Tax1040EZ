/*********************************************************************************************************
	CREATED BY: Saravanan N.				STORED PROCEDURE NAME: usp_efile_irs_schema_get_on_efile_return_data_id
	CREATED ON: 7th July, 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_irs_schema_get_on_efile_return_data_id]
	@efile_return_data_id BIGINT
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				eh.[efile_return_data_id], 
				eh.[product_id], 
				[efile_irs_schema], 
				[manifest_xml], 
				[submission_id] 
			FROM 
				[dbo].[efile_irs_schema] eis WITH(NOLOCK) 
				JOIN [dbo].[efile_return_data] eh WITH(NOLOCK) ON eis.[efile_return_data_id] = eh.[efile_return_data_id]
			WHERE 
				eis.[efile_return_data_id] = @efile_return_data_id AND eh.[is_deleted] = 0 AND eis.[is_deleted] = 0
			
            SELECT 
				[efile_return_data_id], 
				[type], 
				[efile_attachment], 
				[attachment_name],
				[efile_return_data_attachment_id]
			FROM 
				[dbo].[efile_return_data_attachment] WITH(NOLOCK) 
			WHERE [efile_return_data_id] = @efile_return_data_id AND [is_deleted] = 0
		SET NOCOUNT OFF; 
	END
