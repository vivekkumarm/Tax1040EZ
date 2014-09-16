/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_rejected_efile_get_on_id
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_rejected_efile_get_on_id]
	@submission_id VARCHAR(20)
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				eh.[tax_return_type_id],
				[efile_irs_schema_id],
				es.[efile_hold_id],
				[efile_irs_schema],
				[manifest_xml],
				[submission_id],
				es.[create_time_stamp]
			FROM 
				[dbo].[efile_irs_schema] es WITH(NOLOCK) 
				JOIN [dbo].[efile_hold] eh WITH(NOLOCK)  ON es.[efile_hold_id] = eh.[efile_hold_id] AND eh.[is_deleted] = 0
			WHERE 
				[submission_id] = @submission_id  AND es.[is_deleted] = 0
		SET NOCOUNT OFF;
	END
GO
