/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_submissions_for_sender_channel
	CREATED ON: 9th May 2014
*********************************************************************************************************/


CREATE PROCEDURE [dbo].[usp_get_submissions_for_sender_channel]
(
	@stage VARCHAR(10),
	@state VARCHAR(50)
)
AS
	BEGIN
		SET NOCOUNT ON
			SELECT 
				eh.[tax_return_type_id],
				eh.[return_id],
				eh.[efile_trans_id],
				es.[efile_hold_id],
				es.[submission_id],
				es.[dime_attachment],
				es.[create_time_stamp] 
			FROM 
				[dbo].[efile_sender] es WITH(NOLOCK)
				JOIN [dbo].[efile_last_status] els WITH(NOLOCK) ON els.[efile_hold_id] = es.[efile_hold_id]
				JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON es.[efile_hold_id] = eh.[efile_hold_id]
			WHERE 
				els.[stage] = @stage 
				AND els.[state] = @state 
				AND es.[is_deleted] = 0 
				AND els.[is_deleted] = 0 
				AND eh.[is_deleted] = 0
		SET NOCOUNT OFF
	END
GO
