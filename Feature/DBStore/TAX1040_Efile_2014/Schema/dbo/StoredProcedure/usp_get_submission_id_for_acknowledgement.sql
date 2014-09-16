/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_submission_id_for_acknowledgement
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_submission_id_for_acknowledgement]
AS  
	BEGIN  
		SET NOCOUNT ON;  
			SELECT 
				eh.[tax_return_type_id], 
				--ReturnID,
				els.[efile_hold_id],   
				es.[submission_id],
				els.[update_time_stamp] as 'SubmittedDate',
				stage,
				els.[state]
				--UserName  
			FROM 
				[dbo].[efile_last_status] els WITH(NOLOCK)  
				JOIN [dbo].[efile_irs_schema] es WITH(NOLOCK) ON es.[efile_hold_id] = els.[efile_hold_id]  
				JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON es.[efile_hold_id]=eh.[efile_hold_id]  
			WHERE
				(els.[stage] = 'send' AND [state] = 'Success') 
				OR (els.[stage] = 'GAck' AND ([state] = 'Error' OR [state] = 'Blank' )) 
				AND es.[is_deleted] = 0  
				AND eh.[is_deleted] = 0 
				AND els.[is_deleted] = 0   
		SET NOCOUNT OFF; 
	END
GO
