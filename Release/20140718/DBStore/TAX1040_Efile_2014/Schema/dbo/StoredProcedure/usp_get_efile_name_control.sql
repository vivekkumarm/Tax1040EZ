/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_name_control
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_name_control]
@efile_hold_id BIGINT
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				[name_control],
				[efile_name_control].[user_id],
				[efile_name_control].[business_info_id],
				[efile_name_control].[business_info_name] as businessname 
			FROM 
				[dbo].[efile_name_control] WITH(NOLOCK)  
				INNER JOIN [dbo].[efile_hold] WITH(NOLOCK) ON [efile_name_control].[return_id] = [efile_hold].[return_id]
			WHERE 
				[efile_hold].[efile_hold_id] = @efile_hold_id
			GROUP BY 
				[name_control],
				[efile_name_control].[user_id],
				[efile_name_control].[business_info_id],
				[efile_name_control].[business_info_name]
		SET NOCOUNT OFF;
	END
GO
