/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_attachement_and_xml_by_efile_trans_id
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_attachement_and_xml_by_efile_trans_id]
@efile_trans_id VARCHAR(30)    
AS    
	Begin  
		SET NOCOUNT ON;     
			SELECT 
				[efile_hold].[tax_return_type_id],
				[efile_hold].[efile_hold_id],
				[manifest_xml],
				[submission_id],
				[efile_irs_schema]   
			FROM 
				[dbo].[efile_hold] WITH(NOLOCK)  
				INNER JOIN [dbo].[efile_irs_schema]  WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id]   
			WHERE 
				[efile_trans_id] = @efile_trans_id  
				AND [efile_hold].[is_deleted] = 0 
				AND [efile_irs_schema].[is_deleted] = 0    
			ORDER BY  
				[efile_hold].[efile_hold_id]  DESC 

			SELECT 
				[efile_hold_attachment_id],
				[efile_attachment],
				[type],
				[attachment_name]   
			FROM 
				[dbo].[efile_hold] WITH(NOLOCK)   
				INNER JOIN [dbo].[efile_hold_attachment]  WITH(NOLOCK)  ON [efile_hold_attachment].[efile_hold_id] = [efile_hold].[efile_hold_id]   
			WHERE 
				[efile_trans_id] = @efile_trans_id  
				AND [efile_hold].[is_deleted] = 0  
		SET NOCOUNT OFF; 
	End
GO
