/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_hold_get_on_id
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_hold_get_on_id]
	@efile_hold_id BIGINT  
AS  
	BEGIN  
		SET NOCOUNT ON;  
			SELECT 
				[efile_hold_id],
				[sender_id],
				[return_id],
				[user_id],
				[tax_return_type_id],
				[user_name],
				[user_email],  
				[no_of_attachments],
				[tax_object],
				[env_indicator],
				[efile_trans_id],
				[tax_year],
				[tax_period]
			FROM 
				[dbo].[efile_hold] WITH (NOLOCK)  
			WHERE 
				[efile_hold_id] = @efile_hold_id AND [is_deleted] = 0   
		SET NOCOUNT OFF; 
	END
GO
