/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_return_data_records_on_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_return_data_records_on_status]
@stage_id INT,
@state VARCHAR(20) = NULL 
AS  
	SET NOCOUNT ON;  
		BEGIN 
			IF  @State IS NULL 
				BEGIN
					SELECT 
						[efile_return_data].[product_id],
						[sender_id],
						--[user_id],
						[user_data_id], 
						[no_of_attachments],
						[efile_return_data].[efile_return_data_id] ,
						[user_name],
						[email], 
						[encrypted_tax_data],
						[env_indicator], 
						[efile_trans_id],
						[stage_id],
						[state] ,
						--[submission_id],
						[tax_year]
						--[tax_period]
					FROM 
						[dbo].[efile_return_data] WITH(NOLOCK)   
						JOIN [dbo].[efile_current_status] WITH(NOLOCK) ON  [efile_return_data].[efile_return_data_id] = [efile_current_status].[efile_return_data_id] 
						--join STCEfileServiceStatus on STCEfileServiceStatus.TaxReturnTypeID=EfileHold.TaxReturnTypeID and IsActive=1
						LEFT OUTER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_return_data_id] = [efile_return_data].[efile_return_data_id] AND [efile_irs_schema].[is_deleted] = 0
					WHERE 
						[stage_id]=@stage_id 
						AND [efile_return_data].[is_deleted] = 0 
				END
			ELSE
				BEGIN
					SELECT 
						[product_id],
						[sender_id],
						--[user_id],
						[user_data_id], 
						[no_of_attachments],
						[efile_return_data].[efile_return_data_id],
						[user_name],
						[email], 
						[encrypted_tax_data],
						[env_indicator], 
						[efile_trans_id],
						[stage_id],
						[state] ,
						--[submission_id],
						[tax_year]
						--[tax_period]
					FROM 
						[dbo].[efile_return_data] WITH(NOLOCK)   
						JOIN [dbo].[efile_current_status] WITH(NOLOCK) ON  [efile_return_data].[efile_return_data_id] = [efile_current_status].[efile_return_data_id] 
						--join STCEfileServiceStatus on STCEfileServiceStatus.TaxReturnTypeID=EfileHold.TaxReturnTypeID and IsActive=1
						LEFT OUTER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_return_data_id] = [efile_return_data].[efile_return_data_id] AND [efile_irs_schema].[is_deleted] = 0
					WHERE 
						[state] = @State 
						AND [stage_id] = @stage_id 
						AND [efile_return_data].[is_deleted] = 0 
				END
		END
	SET NOCOUNT OFF;
