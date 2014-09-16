/*******************************************************************************************************
	CREATED BY: Saravanan N				STORED PROCEDURE NAME: usp_efile_request_response_persist
	CREATED ON: 10th July, 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_request_response_persist]
@submission_id VARCHAR(25)= NULL,
@request TEXT = NULL,
@message_id VARCHAR(50),
@response TEXT = NULL,
@error_code VARCHAR(50) = NULL,
@error_message TEXT = NULL,
@error_classification VARCHAR(50)=NULL,
@action VARCHAR(50) = NULL,
@service_action VARCHAR(50) = NULL,
@status_id TINYINT = 0,
@Stage_id INT=0,
@State varchar(10)=NULL
AS
	SET NOCOUNT ON;  
		BEGIN
			INSERT INTO [dbo].[efile_irs_request_response]
			(
				[submission_id], 
				[message_id],
				[request], 
				[response], 
				[action],
				[status_id] 
			)
			VALUES
			(
				@submission_id, 
				@message_id,
				@request, 
				@response, 
				@service_action,
				@status_id 
			)
			IF  @submission_id IS NOT NULL 
				BEGIN
					IF @error_code IS NOT NULL
						BEGIN
						INSERT INTO [dbo].[efile_error]
						(
							[submission_id], 
							[error_code], 
							[error_message], 
							[error_classification], 
							[action],
							[error_picked_up], 
							[error_fixed]
						)
						VALUES
						(
							@submission_id, 
							@error_code, 
							@error_message, 
							@error_classification, 
							@Action,
							0, 
							0
						)
						EXEC [dbo].[usp_return_status_update] @submission_id, null, @Stage_id, @State
						END    
				END
		END
	SET NOCOUNT OFF;
GO
