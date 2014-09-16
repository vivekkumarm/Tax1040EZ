/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_info_on_stage_status
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_info_on_stage_status]
	@stage VARCHAR(10)=NULL,
	@state VARCHAR(10)=NULL
AS
	BEGIN
		SET NOCOUNT ON; 
			IF @stage IS NULL AND @state IS NULL 
				Select 
					eh.[tax_return_type_id], 
					eh.[return_id],
					eh.[user_id],
					eh.[user_name],
					eh.[efile_trans_id],
					eh.[efile_hold_id],
					eh.[tax_object],
					es.[submission_id], 
					es.[efile_irs_schema],
					es.[manifest_xml],
					[stage],
					[state]
				FROM 
					[dbo].[efile_hold] eh
					LEFT OUTER JOIN [dbo].[efile_irs_schema] es ON eh.[efile_hold_id]=es.[efile_hold_id] AND es.[is_deleted] = 0
					JOIN [dbo].[efile_last_status] el ON el.[efile_hold_id] = eh.[efile_hold_id]	
			ELSE
				SELECT 
					eh.[tax_return_type_id], 
					eh.[return_id],
					eh.[user_id],
					eh.[user_name],
					eh.[efile_trans_id],
					eh.[efile_hold_id],
					eh.[tax_object],
					es.[submission_id], 
					es.[efile_irs_schema],
					es.[manifest_xml],
					[stage],
					[state]
				FROM 
					[dbo].[efile_hold] eh
					LEFT OUTER JOIN [dbo].[efile_irs_schema] es ON eh.[efile_hold_id]=es.[efile_hold_id] AND es.[is_deleted] = 0
					JOIN [dbo].[efile_last_status] el ON el.[efile_hold_id] = eh.[efile_hold_id]	 
				WHERE 
					el.[stage]=@stage AND el.[state]=@state
		SET NOCOUNT OFF; 
	END
GO

