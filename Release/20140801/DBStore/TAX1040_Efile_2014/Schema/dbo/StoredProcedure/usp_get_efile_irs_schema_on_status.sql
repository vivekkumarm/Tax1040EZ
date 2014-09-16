/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_irs_schema_on_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_irs_schema_on_status]
@Stage VARCHAR(10),    
@State VARCHAR(10)    
AS    
	SET NOCOUNT ON;    
		BEGIN    
			SELECT 
				[efile_irs_schema].[efile_hold_id],
				[tax_return-type_id],
				[efile_irs_schema].[submission_id], 
				[tax_return-type_id] AS 'FormType',
				[efile_hold].[tax_year],
				[efile_hold].[tax_period],
				[efile_irs_schema].[create_time_stamp] AS 'Date' ,
				[manifest_xml], 
				[efile_irs_schema],
				[returns].[product_id]  
			FROM 
				[dbo].[efile_irs_schema] WITH(NOLOCK) 
				JOIN [dbo].[efile_last_status] WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] = [efile_last_status].[efile_hold_id]     
				JOIN [dbo].[efile_hold] ON [efile_hold].[efile_hold_id] = [efile_irs_schema].[efile_hold_id]   
				JOIN [dbo].[returns] ON [returns].[return_id] = [efile_hold].[return_id] and [returns].[is_deleted] = 0  
			WHERE 
				[efile_irs_schema].[is_deleted] = 0 
				AND [stage] = @Stage 
				AND [state] = @State 
				AND [efile_hold].[is_deleted] = 0    
		END
	SET NOCOUNT OFF;
GO
