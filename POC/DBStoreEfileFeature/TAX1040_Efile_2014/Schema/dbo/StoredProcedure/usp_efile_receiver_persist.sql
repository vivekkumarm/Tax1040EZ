/*********************************************************************************************************
	CREATED BY: Saravanan N				STORED PROCEDURE NAME: usp_efile_receiver_persist
	CREATED ON: 10th July, 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_receiver_persist]
	@submission_id VARCHAR(20),
	@send_submission_status VARBINARY(MAX) = NULL,
	@get_ack_status VARBINARY(MAX) = NULL,
	@submission_status VARBINARY(MAX) = NULL,
	@schedule1 VARBINARY(MAX) = NULL,
	@ack_xml XML = NULL,
	@status_id INT = 0,
	@stage_id INT,
	@state VARCHAR(20),
	@irs_system_id VARCHAR(20) = NULL
AS
	BEGIN
		SET NOCOUNT ON; 
			INSERT INTO [dbo].[efile_receiver]
			(
				[submission_id], 
				[send_submission_status],
				[get_ack_status], 
				[ack_xml],
				[submission_status],
				[schedule1],
				[system_id]
			)
			values
			(
				@submission_id, 
				@send_submission_status, 
				@get_ack_status, 
				@ack_xml,
				@submission_status,
				@schedule1,
				@irs_system_id
			)
			EXEC [dbo].[usp_return_status_update] @submission_id, NULL, @stage_id, @state
		SET NOCOUNT OFF; 
	END
GO

