/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_schema_get_by_id
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_schema_get_by_id]
	@submission_id VARCHAR(20)
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				eh.[efile_hold_id],
				eh.[tax_return_type_id],
				es.[submission_id],
				eh.[return_id],
				eh.[user_id],
				eh.[user_name],
				eh.[user_email],
				eh.[no_of_attachments],
				eh.[tax_object],
				eh.[efile_trans_id],
				es.[efile_irs_schema],
				es.[manifest_xml]
			FROM 
				[dbo].[efile_hold] eh WITH (NOLOCK)
				JOIN  [dbo].[efile_irs_schema] es WITH(NOLOCK) ON eh.[efile_hold_id] = es.[efile_hold_id]
			WHERE 
				es.[submission_id] = @submission_id 
				AND es.[is_deleted] = 0  
				AND eh.[is_deleted] = 0
		SET NOCOUNT OFF;
	END
GO
