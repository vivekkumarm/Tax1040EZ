/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_receiver_insert
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_receiver_insert]
	@submission_id VARCHAR(20),
	@send_submission_status VARBINARY(MAX) = NULL,
	@get_ack_status VARBINARY(MAX) = NULL,
	@submission_status VARBINARY(MAX) = NULL,
	@schedule1 VARBINARY(MAX) = NULL,
	@ack_xml XML = NULL,
	@status_id INT = 0,
	@stage VARCHAR(10),
	@state VARCHAR(10),
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
				[is_deleted],
				[system_id],
				[create_time_stamp],
				[update_time_stamp]
			)
			values
			(
				@submission_id, 
				@send_submission_status, 
				@get_ack_status, 
				@ack_xml,
				@submission_status,
				@schedule1,
				0,
				@irs_system_id,
				getdate(),
				getdate()
			)
			EXEC StatusUpdate @submission_id, NULL, @status_id, @stage, @state
		SET NOCOUNT OFF; 
	END
GO
