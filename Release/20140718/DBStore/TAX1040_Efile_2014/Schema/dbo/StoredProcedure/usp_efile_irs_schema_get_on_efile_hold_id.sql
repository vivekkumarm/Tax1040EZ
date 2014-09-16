/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_irs_schema_get_on_efile_hold_id
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_irs_schema_get_on_efile_hold_id]
	@efile_hold_id BIGINT
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				eh.[efile_hold_id], 
				eh.[tax_return_type_id], 
				[efile_irs_schema], 
				[manifest_xml], 
				[submission_id] 
			FROM 
				[dbo].[efile_irs_schema] eis WITH(NOLOCK) 
				JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON eis.[efile_hold_id] = eh.[efile_hold_id]
			WHERE 
				eis.[efile_hold_id] = @efile_hold_id AND eh.[is_deleted] = 0 AND eis.[is_deleted] = 0
			SELECT 
				[efile_hold_id], 
				[type], 
				[efile_attachment], 
				[attachment_name],
				[efile_hold_attachment_id]
			FROM 
				[dbo].[efile_hold_attachment] WITH(NOLOCK) 
			WHERE [efile_hold_id] = @efile_hold_id AND [is_deleted] = 0
		SET NOCOUNT OFF; 
	END
GO
