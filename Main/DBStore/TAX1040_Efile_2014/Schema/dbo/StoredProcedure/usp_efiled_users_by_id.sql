/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efiled_users_by_id
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efiled_users_by_id]
@efile_hold_id INT 
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				EH.[efile_hold_id],
				EH.[tax_return_type_id],
				EH.[return_id],
				EH.[create_time_stamp] AS 'SubmitDate',
				EH.[efile_trans_id],
				CASE  WHEN 
					(
						SELECT 
							COUNT(1) 
						FROM 
							[dbo].[efile_tax_xml] EFF WITH(NOLOCK)  
						WHERE 
							EFF.[return_id] = EH.[return_id]
					)   > 1    THEN 'YES' ELSE 'NO' END AS 'RETRANS', 
				U.[user_id],
				[user_name],
				U.[login_id],
				BI.[business_name],
				BI.[phone],
				EH.[user_email],
				EIRS.[submission_id],
				ELS.[stage],
				ELS.[state],
				CASE WHEN 
					(
						SELECT 
							TOP 1 StatusID 
						FROM 
							[dbo].[efile_tax_xml] WITH(NOLOCK) 
						WHERE 
							[efile_trans_id] = EH.[efile_trans_id] 
							and [is_deleted] = 0
					) = 1 
				THEN 'YES' 
				ELSE 'NO' END AS 'User Notified' 
			FROM 
				[dbo].[efile_hold] EH WITH(NOLOCK)         
				INNER JOIN [dbo].[efile_tax_xml] EF WITH(NOLOCK) ON EF.[efile_trans_id] = EH.[efile_trans_id] AND EF.[id_deleted] = 0        
				INNER JOIN [dbo].[efile_irs_schema] EIRS WITH(NOLOCK) ON EH.[efile_hold_id] = EIRS.[efile_hold_id] AND EIRS.[is_deleted] = 0         
				INNER JOIN [dbo].[efile_last_status] ELS WITH(NOLOCK) ON EH.[efile_hold_id] = ELS.[efile_hold_id]        
				INNER JOIN [dbo].[returns] RT WITH(NOLOCK) ON RT.[return_id] = EH.[return_id]         
				INNER JOIN [dbo].[business_info] BI WITH(NOLOCK) ON BI.[business_info_id] = RT.[business_info_id]        
				INNER JOIN [dbo].[users] U WITH(NOLOCK) ON U.[user_id] = BI.[user_id]  
			WHERE 
				EH.[efile_hold_id] = @efile_hold_id 
				AND EH.[is_deleted] = 0
		SET NOCOUNT OFF;
	END
GO
