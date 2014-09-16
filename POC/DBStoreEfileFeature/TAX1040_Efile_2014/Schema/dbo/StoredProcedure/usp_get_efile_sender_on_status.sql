/*********************************************************************************************************
	CREATED BY: Saravanan N.				STORED PROCEDURE NAME: usp_efile_irs_schema_get_on_efile_return_data_id
	CREATED ON: 8th July, 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_sender_on_status]
@stage_id INT,  
@State VARCHAR(20)   
AS  
	BEGIN  
		SET NOCOUNT ON;
			SELECT 
				[efile_sender].[efile_return_data_id],
				[dime_attachment], 
				[submission_id], 
				[message_id],
				[product_id],
				[efile_sender].[irs_system_id]  
			FROM 
				[dbo].[efile_sender] WITH(NOLOCK)  
				JOIN [dbo].[efile_current_status] WITH(NOLOCK) ON [efile_sender].[efile_return_data_id] = [efile_current_status].[efile_return_data_id]   
				JOIN [dbo].[efile_return_data] WITH(NOLOCK) ON  [efile_current_status].[efile_return_data_id] = [efile_return_data].[efile_return_data_id]   
			WHERE 
				[efile_current_status].[stage_id] = @stage_id
				AND [efile_current_status].[state] = @State 
				AND [efile_sender].[is_deleted] = 0 
				AND [efile_return_data].[is_deleted] = 0  
		SET NOCOUNT OFF;
	END

