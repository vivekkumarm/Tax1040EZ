/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_sender_on_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_sender_on_status]
@Stage VARCHAR(10),  
@State VARCHAR(10)   
AS  
	BEGIN  
		SET NOCOUNT ON;
			SELECT 
				[efile_sender].[efile_hold_id],
				[dime_attachment], 
				[submission_id], 
				[message_id],
				[tax_return_type_id],
				[efile_sender].[irs_system_id]  
			FROM 
				[dbo].[efile_sender] WITH(NOLOCK)  
				JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON [efile_sender].[efile_hold_id] = [efile_last_status].[efile_hold_id]   
				JOIN [dbo].[efile_hold] WITH(NOLOCK) ON  [efile_last_status].[efile_hold_id] = [efile_hold].[efile_hold_id]   
			WHERE 
				[efile_last_status].[stage] = @Stage
				AND [efile_last_status].[state] = @State 
				AND [efile_sender].[is_deleted] = 0 
				AND [efile_hold].[is_deleted] = 0  
		SET NOCOUNT OFF;
	END
GO

