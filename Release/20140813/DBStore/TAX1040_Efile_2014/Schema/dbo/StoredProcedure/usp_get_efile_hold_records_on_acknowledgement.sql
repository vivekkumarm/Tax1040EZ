/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_hold_records_on_acknowledgement
	CREATED ON: 12th May 2014
*******************************************************************************************************/


CREATE PROCEDURE [dbo].[usp_get_efile_hold_records_on_acknowledgement]
AS  
	BEGIN
		SET NOCOUNT ON; 
			SELECT 
				[tax_return_type_id],
				[sender_id],
				efile_hold.[user_id],
				efile_hold.[return_id],
				business_info.[business_name],
				[no_of_attachments],
				efile_hold.[efile_hold_id],
				[user_name],
				[user_email], 
				[tax_object],
				[env_indicator], 
				[efile_trans_id],
				[stage],
				efile_last_status.[state] ,
				[submission_id],
				[tax_year],
				[tax_period]
			FROM 
				[dbo].[efile_hold] WITH(NOLOCK)   
				JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON  [efile_hold].[efile_hold_id] = [efile_last_status].[efile_hold_id] 
				LEFT OUTER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id] AND [efile_irs_schema].[is_deleted] = 0
				JOIN [dbo].[users] WITH(NOLOCK) ON [users].[user_id] = [efile_hold].[user_id]
				JOIN [dbo].[returns] WITH(NOLOCK) ON [returns].[return_id] = [efile_hold].[return_id]
				JOIN [dbo].[business_info] WITH(NOLOCK) ON  [business_info].[business_info_id] = [returns].[business_info_id]
			WHERE 
				[stage] IN('GACK','SCH1') 
				AND [efile_last_status].[state] = 'Success' 
				AND [efile_hold].[is_deleted] = 0 
		SET NOCOUNT OFF; 
	END
GO
