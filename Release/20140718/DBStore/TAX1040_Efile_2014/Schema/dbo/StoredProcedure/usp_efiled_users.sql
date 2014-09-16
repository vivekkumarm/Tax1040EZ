/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efiled_users
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efiled_users]
@form_type VARCHAR(20)    
AS        
	SET NOCOUNT ON;        
		BEGIN        
			SELECT 
				EH.[efile_hold_id],
				EH.[tax_return_type_id],
				EH.[return_id],
				EH.[create_time_stamp] as 'SubmitDate',
				EH.[efile_trans_id],        
				case EF.[status_id] 
				when 5 then 'Yes' else 'No' End as 'Schedule1pushed',        
				ELS.[stage] as StcStatus,        
				ELS.[state],        
				case isnull(Processed,0) 
					when 1 then 'Paid' else 'NotPaid' End Status,        
				--SEFS.StcStatus,        
				(
					SELECT 
					COUNT(1) 
					FROM 
					[dbo].[efile_irs_schema] WITH(NOLOCK) 
					WHERE 
					EH.[efile_hold_id] = [efile_hold_id]
				) SubmissionCount  ,      
				CASE  WHEN 
					(
						SELECT 
						COUNT(1) 
						FROM 
						[dbo].[efile_tax_xml] EFF WITH(NOLOCK)  
						WHERE 
						EFF.[return_id] = EH.[return_id]
					)   > 1    THEN  'YES'    ELSE 'NO' END AS 'RETRANS',        
					U.[user_id],
					[user_name],
					U.[login_id],
					BI.[business_name],
					BI.[phone],
					EH.[user_email],
					EIRS.[submission_id],
					ELS.[stage],
					CASE (EF.[status_id]) 
						WHEN 1 THEN 'Transmitted'      
						WHEN 2 THEN 'Approved'      
						WHEN 3 THEN 'Accepted'      
						WHEN 4 THEN 'Ready to File'      
						WHEN 5 THEN 'Schedule 1'  
						WHEN 6 THEN 'Rejected'     
						ELSE 'Not Transmitted' END AS 'EfileStatus'     
			FROM 
				[dbo].[efile_hold] EH WITH(NOLOCK)         
				INNER JOIN [dbo].[efile_tax_xml] EF WITH(NOLOCK) ON EF.[efile_trans_id] = EH.[efile_trans_id] and EF.[id_deleted] = 0        
				INNER JOIN [dbo].[efile_irs_schema] EIRS WITH(NOLOCK) ON EH.[efile_hold_id] = EIRS.[efile_hold_id] and EIRS.[is_deleted] = 0         
				INNER JOIN [dbo].[efile_last_status] ELS WITH(NOLOCK) ON EH.[efile_hold_id] = ELS.[efile_hold_id]        
				INNER JOIN [dbo].[returns] RT WITH(NOLOCK) ON RT.[return_id] = EH.[return_id]         
				INNER JOIN [dbo].[business_info] BI WITH(NOLOCK) ON BI.[business_info_id] = RT.[business_info_id]        
				INNER JOIN [dbo].[users] U WITH(NOLOCK) ON U.[user_id] = BI.[user_id]         
				left join [dbo].[orders] O on O.[return_id] = EH.[return_id]         
				--INNER JOIN STCStatus SEFS WITH(NOLOCK) ON SEFS.StcStatusID = ELS.StatusID        
			WHERE 
				EH.[is_deleted] =0    
				and EH.[tax_return_type_id] = @form_type    
			GROUP BY 
				EH.[efile_hold_id],
				EH.[return_id],
				EH.[create_time_stamp],
				EH.[efile_trans_id],        
				U.[user_id],
				[user_name],
				U.[login_id],
				BI.[business_name],
				BI.[phone],
				EH.[user_email],
				EIRS.[submission_id],
				ELS.[stage],
				EF.[status_id],
				O.[processed],        
				ELS.[state],
				EH.[tax_return_type_id]
			ORDER BY 
				EH.[return_id] DESC--,SEFS.StcStatus        
		END
	SET NOCOUNT OFF;
GO
