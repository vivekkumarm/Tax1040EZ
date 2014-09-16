/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_error_on_submission_id
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_error_on_submission_id]
@submission_id VARCHAR(25) 
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
				[error_fixed], 
				[create_time_stamp] AS 'Time' 
			FROM 
				[dbo].[efile_error] WITH(NOLOCK)
			WHERE 
				[submission_id] = @submission_id
		SET NOCOUNT OFF;
	END
GO
