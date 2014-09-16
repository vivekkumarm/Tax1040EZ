/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_submissions
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_submissions]
@form_type NVARCHAR(20)
AS  
	BEGIN  
		SET NOCOUNT ON;  
			SELECT 
				[efile_irs_schema].[submission_id], 
				[efile_last_status].[efile_hold_id] AS StatusID,[efile_last_status].[stage] + '-'+ [efile_last_status].[state] AS stcstatus   
			FROM 
				[dbo].[efile_hold] WITH(NOLOCK) 
				INNER JOIN  [dbo].[efile_irs_schema] WITH(NOLOCK)  ON [efile_hold].[efile_hold_id] = [efile_irs_schema].[efile_hold_id]
				JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON [efile_last_status].[efile_hold_id] = [efile_irs_schema].[efile_hold_id]  
			WHERE
				[efile_irs_schema].[is_deleted] =0 
				AND [efile_last_status].[is_deleted] = 0   
				AND  [tax_return_type_id] = @form_type
		SET NOCOUNT OFF;
	END
GO
