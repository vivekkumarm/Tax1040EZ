/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_hold_records_on_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_hold_records_on_status]
@stage VARCHAR(10),
@state VARCHAR(10) = NULL 
AS  
	SET NOCOUNT ON;  
		BEGIN 
			IF  @State IS NULL 
				BEGIN
					SELECT 
						[efile_hold].[tax_return_type_id],
						[sender_id],
						[user_id],
						[return_id], 
						[no_of_attachments],
						[efile_hold].[efile_hold_id] ,
						[user_name],
						[user_email], 
						[tax_object],
						[env_indicator], 
						[efile_trans_id],
						[stage],
						[state] ,
						[submission_id],
						[tax_year],
						[tax_period]
					FROM 
						[dbo].[efile_hold] WITH(NOLOCK)   
						JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON  [efile_hold].[efile_hold_id] = [efile_last_status].[efile_hold_id] 
						--join STCEfileServiceStatus on STCEfileServiceStatus.TaxReturnTypeID=EfileHold.TaxReturnTypeID and IsActive=1
						LEFT OUTER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id] AND [efile_irs_schema].[is_deleted] = 0
					WHERE 
						[stage]=@stage 
						AND [efile_hold].[is_deleted] = 0 
				END
			ELSE
				BEGIN
					SELECT 
						[efile_hold].[tax_return_type_id],
						[sender_id],
						[user_id],
						[return_id], 
						[no_of_attachments],
						[efile_hold].[efile_hold_id] ,
						[user_name],
						[user_email], 
						[tax_object],
						[env_indicator], 
						[efile_trans_id],
						[stage],
						[state] ,
						[submission_id],
						[tax_year],
						[tax_period]
					FROM 
						[dbo].[efile_hold] WITH(NOLOCK)   
						JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON  [efile_hold].[efile_hold_id] = [efile_last_status].[efile_hold_id] 
						JOIN [dbo].[stc_efile_service_status] WITH(NOLOCK) ON [stc_efile_service_status].[tax_return_type_id] = [efile_hold].[tax_return_type_id] AND [is_active] = 1
						LEFT OUTER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id] AND [efile_irs_schema].[is_deleted] = 0
					WHERE 
						[state] = @State 
						AND [stage] = @stage 
						AND [efile_hold].[is_deleted] = 0 
				END
		END
	SET NOCOUNT OFF;
GO
