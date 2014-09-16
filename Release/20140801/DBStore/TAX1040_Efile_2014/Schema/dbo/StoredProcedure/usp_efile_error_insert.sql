/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_error_insert
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_error_insert]
	@submission_id VARCHAR(25),
	@error_code VARCHAR(50) = NULL,
	@error_message VARCHAR(MAX) = NULL,
	@error_classification VARCHAR(50) = NULL,
	@action VARCHAR(50) = NULL,
	@status_id INT,
	@stage VARCHAR(10) = NULL,
	@state VARCHAR(10) = NULL
AS
	BEGIN
		SET NOCOUNT ON; 
			IF EXISTS (SELECT 1 FROM [dbo].[efile_stc_error_code] WITH(NOLOCK) WHERE [error_code] = @error_code)
				BEGIN
					IF @error_message IS NULL 
						SELECT 
							@error_message = ErrorLogErrorMessage 
						FROM 
							[dbo].[efile_stc_error_code] WITH(NOLOCK)  
						WHERE 
							[error_code] = @error_code
								INSERT INTO [dbo].[efile_error]
								(
									[submission_id], 
									[error_code], 
									[error_message], 
									[error_classification], 
									[action],
									[error_picked_up], 
									[error_fixed], 
									[is_deleted], 
									[create_time_stamp], 
									[update_time_stamp]
								)
								VALUES
								(
									@submission_id, 
									@error_code, 
									@error_message, 
									@error_classification, 
									@Action,
									0, 
									0,
									0, 
									GETDATE(), 
									GETDATE()
								)
						EXEC StatusUpdate @submission_id, NULL, @status_id,@stage,@state
				END
			ELSE
				BEGIN
					INSERT INTO  [dbo].[efile_stc_error_code]
					(
						[error_code], 
						[error_fault_response], 
						[error_log_error_message], 
						[error_type],
						[fix_type]
					)
					VALUES
					(
						@error_code, 
						@error_message, 
						@error_classification, 
						NULL,
						NULL
					)
					INSERT INTO [dbo].[efile_error]
					(
						[submission_id], 
						[error_code], 
						[error_message], 
						[error_classification], 
						[action],
						[error_picked_up], 
						[error_fixed], 
						[is_deleted], 
						[create_time_stamp], 
						[update_time_stamp]
					)
					VALUES
					(
						@submission_id, 
						@error_code, 
						@error_message, 
						@error_classification, 
						@action,
						0, 
						0, 
						0, 
						GETDATE(), 
						GETDATE()
					)
				END 
		SET NOCOUNT OFF; 
	END
GO
