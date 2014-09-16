/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_error_on_transmission_id
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_error_on_transmission_id]
@efile_trans_id VARCHAR(30)
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				[efile_error_id],
				[tax_return_type_id],
				[error_code],
				[error_message],
				[error_classification],
				[action] 
			FROM 
				[dbo].[efile_hold] WITH(NOLOCK) 
				JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_hold].[efile_hold_id] = [efile_irs_schema].[efile_hold_id]
				JOIN [dbo].[efile_error] WITH(NOLOCK) ON [efile_irs_schema].[submission_id] = [efile_error].[submission_id]
			WHERE 
				[efile_hold].[efile_trans_id] = @efile_trans_id 
				AND [efile_irs_schema].[is_deleted] = 0 
				AND [efile_hold].[is_deleted] = 0
				AND [efile_error].[is_deleted] = 0
		SET NOCOUNT OFF;
	END
GO
