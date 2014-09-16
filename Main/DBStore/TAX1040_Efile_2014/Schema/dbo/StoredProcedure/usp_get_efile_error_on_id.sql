/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_error_on_id
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_error_on_id]
@efile_error_id INT = NULL
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				[efile_error_id],
				[submission_id],
				[efile_error].[error_code],
				[error_message],
				[error_classification],
				[action],
				[error_picked_up],
				[error_fixed] ,
				[error_fault_response],
				[error_log_error_message],
				[error_type],
				[fix_type],
				[error_fix_type]
			FROM 
				[dbo].[efile_error] WITH(NOLOCK) 
				LEFT OUTER JOIN [dbo].[stc_error_code] WITH(NOLOCK) ON [stc_error_code].[error_code] = [efile_error].[error_code] 
				LEFT OUTER JOIN [dbo].[error_fix_type]  WITH(NOLOCK) ON [error_fix_type].[stc_eror_fix_type_id] = [stc_error_code].[fix_type]
			WHERE 
				[efile_error_id] = @efile_error_id
				AND [efile_error].[is_deleted] = 0
		SET NOCOUNT OFF;
	END
GO
