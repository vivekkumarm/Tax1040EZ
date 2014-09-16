/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_upload_files
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_upload_files]
	@submission_id VARCHAR(30) = NULL,
	@zip VARBINARY(MAX) = NULL,
	@get_ack_status VARBINARY(MAX) = NULL,
	@schedule1 VARBINARY(MAX) = NULL,
	@stage VARCHAR(20) = NULL,
	@state VARCHAR(20)
AS
	BEGIN
		SET NOCOUNT ON; 
			DECLARE @EfileHoldID [BIGINT]
			IF @submission_id IS NULL
				BEGIN		
					RETURN
				END 
			ELSE
				BEGIN
					SELECT 
						@EfileHoldID = [efile_hold_id] 
					FROM 
						[dbo].[efile_irs_schema] WITH(NOLOCK) 
					WHERE  
						[submission_id] = @submission_id AND [is_deleted] = 0
				END
			IF @zip IS NOT NULL
				BEGIN
					UPDATE [dbo].[efile_sender] WITH(ROWLOCK) 
					SET 
						[dime_attachment] = @zip,[update_time_stamp] = GETDATE() 	
					WHERE 
						[submission_id] = @submission_id AND is_deleted = 0
				IF @@rowcount = 0
					INSERT INTO [dbo].[efile_sender]
						(
							[efile_hold_id],
							[dime_attachment],
							[submission_id],
							[message_id],
							[is_deleted],
							[create_time_stamp],
							[update_time_stamp]
						) 
						VALUES 
						(
							@EfileHoldID,
							@zip,
							@submission_id,
							NULL,
							0,
							GETDATE(),
							GETDATE()
						)	
					EXEC  Statusupdate @submission_id, @EfileHoldID, NULL, @stage, @state
				END 
			IF @get_ack_status IS NOT NULL
				BEGIN
					UPDATE [dbo].[efile_receiver] WITH(ROWLOCK) 
					SET 
						[get_ack_status] = @get_ack_status , 
						[update_time_stamp] = GETDATE() 
					WHERE 
						[submission_id] = @submission_id AND [is_deleted] = 0
					IF @@rowcount = 0
						INSERT INTO [dbo].[efile_receiver]
						(
							[submission_id],
							[send_submission_status],
							[get_ack_status],
							[submission_status],
							[schedule1],
							[is_deleted],
							[create_time_stamp],
							[update_time_stamp]
						)
						VALUES
						(
							@submission_id,
							null,
							@get_ack_status,
							NULL,
							NULL,
							0,
							GETDATE(),
							GETDATE()
						)
						EXEC  Statusupdate @submission_id, @EfileHoldID, NULL, @stage, @state
				END 
			IF @Schedule1 IS NOT NULL	
				BEGIN
					UPDATE [dbo].[efile_receiver] WITH(ROWLOCK) 
					SET 
						[schedule1] = @Schedule1, 
						[update_time_stamp] =GETDATE() 
					WHERE
						[submission_id] = @submission_id AND [is_deleted] = 0
					IF @@rowcount = 0
						INSERT INTO [dbo].[efile_receiver]
						(
							[submission_id],
							[send_submission_status],
							[get_ack_status],
							[submission_status],
							[schedule1],
							[is_deleted],
							[create_time_stamp],
							[update_time_stamp]
						)
						VALUES
						(
							@submission_id,
							NULL,
							NULL,
							NULL,
							@Schedule1,
							0,
							GETDATE(),
							GETDATE()
						)
					EXEC  Statusupdate @submission_id, @EfileHoldID, NULL, @stage, @state
				END
		SET NOCOUNT OFF;
	END
GO
