/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_req_res_by_action_and_time
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_req_res_by_action_and_time]
(
	@action [VARCHAR](50) = NULL,          
	@start_time [VARCHAR](100) = NULL,          
	@end_time [VARCHAR](100) = NULL,        
	@date [VARCHAR](100) = NULL  ,      
	@last_hours [CHAR](5) = NULL ,  
	@form_type [VARCHAR](20) = NULL    
)
AS          
	BEGIN        
		SET NOCOUNT ON;          
			DECLARE @SQL NVARCHAR(MAX)            
			SET @SQL =N'
				SELECT 
					[efile_request_response_id],
					isnull(submission_id.[submission_id],'''') [submission_id],  
					[message_id],
					isnull([request],'''') as Request,isnull([response],'''') as Response,
					isnull(efile_request_response.[status_id],'''') as StatusId  ,  
					isnull([state],'''') + '' - '' +isnull([stage],'''') as ''STCStatus'' ,
					efile_request_response.[create_time_stamp] as ''TimeStamp''     
				FROM   
					[dbo].[efile_hold] eh INNER JOIN [dbo].[efile_irs_schema] es on eh.[efile_hold_id] = es.[efile_hold_id]   
					INNER JOIN efile_request_response with(nolock) on es.[submission_id] = [efile_request_response].[submission_id]     
					left outer join [dbo].[efile_last_status] els with(nolock) ON els.[efile_hold_id]=es.[efile_hold_id] 
				WHERE 1 = 1 '          
			SET 
				@date = CONVERT(VARCHAR(20),CONVERT(DATETIME,@date),101)        
			IF 
				@form_type IS NOT NULL  
			SET 
				@SQL = @SQL + ' AND tax_return_type_id = '''+ @form_type +''''  
			IF 
				@action IS NOT NULL          
			SET 
				@SQL = @SQL + 'AND action = ''' + @action +''''          
			IF 
				@date IS NOT NULL          
			SET 
				@sql = @sql +  ' and convert(varchar(100),efile_request_response.create_time_stamp,101) = '''+  @date + ''''        
			SELECT 
				@start_time = CONVERT(VARCHAR(20),CONVERT(DATETIME,@start_time),108), @end_time = CONVERT(VARCHAR(20),CONVERT(DATETIME,@end_time),108)      
			IF 
				(@start_time IS NOT NULL )          
			SET 
				@SQL = @SQL + 'AND CONVERT(VARCHAR(20),efile_request_response.[create_time_stamp],108) >= '''+ @start_time +''''      
			IF 
				(@end_time IS NOT NULL)      
			SET 
				@SQL = @SQL + 'AND CONVERT(VARCHAR(20),efile_request_response.[create_time_stamp],108) <= '''+ @end_time +''''      
			IF 
				(@last_hours   IS NOT NULL and ISNUMERIC(@last_hours) = 1)      
			SET 
				@SQL = @SQL + 'AND efile_request_response.[create_time_stamp] >= dateadd(hh,-('+@last_hours+'),getdate())'      
			EXEC sp_executesql @SQL   
		SET NOCOUNT OFF;       
	END
GO
