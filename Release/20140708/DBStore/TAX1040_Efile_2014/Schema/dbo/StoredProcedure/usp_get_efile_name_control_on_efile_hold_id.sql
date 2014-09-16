/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_name_control_on_efile_hold_id
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_name_control_on_efile_hold_id]
@efile_hold_id BIGINT  
AS  
	BEGIN 
		SET NOCOUNT ON; 
			SELECT  
				[name_control] 
			FROM  
				[dbo].[efile_name_control] WITH(NOLOCK) 
			WHERE 
				[business_info_id] =  
				(  
					SELECT 
						bi.[business_info_id] 
					FROM 
						[dbo].[business_info] bi WITH(NOLOCK)    
						JOIN [dbo].[returns] r WITH(NOLOCK)  ON bi.[business_info_id] = r.[business_info_id]  
						JOIN [dbo].[efile_hold] eh WITH(NOLOCK)  ON eh.[return_id] = r.[return_id] 
					WHERE 
						eh.[efile_hold_id] = @efile_hold_id
				)   
		SET NOCOUNT OFF;
	END
GO
