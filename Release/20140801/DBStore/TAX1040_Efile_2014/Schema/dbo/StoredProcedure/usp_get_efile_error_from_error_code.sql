/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_error_from_error_code
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_error_from_error_code]
AS
	BEGIN
		SET NOCOUNT ON
			SELECT 
				[efile_error_id],
				[submission_id],
				[error_code], 
				[error_message], 
				[error_classification], 
				[action], 
				[error_picked_up], 
				[error_fixed] 
			FROM
				[dbo].[efile_error] WITH(NOLOCK) 
			WHERE 
				[error_code]  NOT IN 
				(
					SELECT 
						[error_code] 
					FROM 
						[dbo].[stc_error_code] WITH(NOLOCK) 
					WHERE 
						[is_deleted] = 0
				) 
		SET NOCOUNT OFF;
	END
GO
