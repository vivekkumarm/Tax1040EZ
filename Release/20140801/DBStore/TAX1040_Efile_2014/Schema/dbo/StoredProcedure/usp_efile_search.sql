/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_search
	CREATED ON: 9th May 2014
*********************************************************************************************************/


CREATE PROCEDURE [dbo].[usp_efile_search]
(
	@return_id BIGINT = NULL,    
	@business_name VARCHAR(50) = NULL,    
	@ein VARCHAR(30) = NULL,    
	@submission_id VARCHAR(30) = NULL,    
	@date DATETIME = NULL,    
	@description VARCHAR(50) = NULL,
	@form_type INT = NULL
)
AS    
	BEGIN    
		SET NOCOUNT ON;   
			DECLARE @strSQl [NVARCHAR](MAX)    
			SET @strSQl='
				SELECT 
					[ein], 
					[business_name],
					[efile_hold].[TaxReturnTypeID], 
					[returns].[return_id],'''' as Description,
					[efile_irs_schema].[submission_id],     
					[efile_hold].[create_time_stamp], 
					[send_submission_status], 
					[get_ack_status],
					[submission_status],    
					[schedule1],'''' as StatusID,
					[efile_last_status].[stage] + ''-'' + [efile_last_status].[state] as StcStatus 
				FROM 
					[returns] WITH(NOLOCK)      
					JOIN [dbo].[business_info] WITH(NOLOCK) ON [returns].[business_info_id] = [business_info].[business_info_id]   
					LEFT OUTER JOIN [dbo].[efile_hold] WITH(NOLOCK) ON [efile_hold].[return_id] = [returns].[return_id]    
					LEFT OUTER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id ]   
					LEFT OUTER JOIN [dbo].[efile_sender] WITH(NOLOCK) ON [efile_irs_schema].[submission_id] = [efile_sender].[submission_id]    
					LEFT OUTER JOIN [dbo].[efile_receiver] WITH(NOLOCK) ON [efile_receiver].[submission_id] = [efile_irs_schema].[submission_id ]   
					LEFT OUTER JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON [efile_last_status].[efile_hold_id] = [efile_hold].[efile_hold_id]    
				WHERE 
					[business_info].[is_deleted] = 0 
					AND [efile_irs_schema].[is_deleted] = 0 
					AND [efile_hold].[is_deleted] = 0     
					AND [efile_sender].[is_deleted] = 0 
					AND [efile_receiver].[is_deleted] = 0 
					AND [efile_irs_schema].[submission_id] IS NOT NULL'    
			IF  
				@return_id IS NOT NULL     
			SET 
				@strSQl = @strSQl + ' and [returns].[return_id] = '+ CAST(@return_id AS VARCHAR(20))    
			IF 
				@business_name IS NOT NULL    
			SET 
				@strSQl = @strSQl + ' and [business_info].[business_name] = '''+ CAST(@business_name AS VARCHAR(50))+''''    
			IF 
				@ein IS NOT NULL     
			SET 
				@strSQl = @strSQl + ' and [business_info].[ein] = ''' + CAST(@EIN AS VARCHAR(30))   +''''    
			IF 
				@submission_id IS NOT NULL     
			SET 
				@strSQl = @strSQl + ' and [efile_irs_schema].[submission_id] = ''' + CAST(@submission_id AS VARCHAR(30))+''''    
			IF 
				@description IS NOT NULL     
			SET 
				@strSQl = @strSQl + ' and [returns].[description] = ''' + CAST(@description AS VARCHAR(30))+''''    
			IF 
				@date IS NOT NULL     
			SET 
				@strSQl = @strSQl + ' and convert(varchar(10),[efile_hold].[create_time_stamp],105) = convert(varchar(10),cast(''' + CAST(@date AS VARCHAR(30))   +''' as datetime),105)'    
			IF 
				@form_type IS NOT NULL     
			SET 
				@strSQl = @strSQl + ' and [tax_return_type_id] =  ''' + CAST(@form_type AS VARCHAR(30))+''''    
			EXEC sp_executesql @strSQl    
		SET NOCOUNT OFF;   
	End
GO
