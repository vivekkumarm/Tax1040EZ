/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_request_response_create
	CREATED ON: 12th May 2014
*******************************************************************************************************/


CREATE PROCEDURE [dbo].[usp_efile_request_response_create]
@submission_id VARCHAR(25)= NULL,
@request TEXT = NULL,
@message_id VARCHAR(50),
@response TEXT = NULL,
@error_code VARCHAR(50) = NULL,
@error_message TEXT = NULL,
@error_classification VARCHAR(50)=NULL,
@action VARCHAR(50) = NULL,
@service_action VARCHAR(50) = NULL,
@status_id TINYINT = 0--,
--@Stage varchar(10)=null,
--@State varchar(10)=null
AS
	SET NOCOUNT ON;  
		BEGIN
			INSERT INTO [dbo].[efile_request_response]
			(
				[submission_id], 
				[message_id],
				[request], 
				[response], 
				[action],
				[status_id], 
				[create_time_stamp], 
				[update_time_stamp]
			)
			VALUES
			(
				@submission_id, 
				@message_id,
				@request, 
				@response, 
				@service_action,
				@status_id, 
				GETDATE(), 
				GETDATE()
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
						--exec StatusUpdate @SubmissionID, null, @StatusID ,@Stage,@State
						END    
				END
		END
	SET NOCOUNT OFF;
GO
