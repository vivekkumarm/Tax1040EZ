/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_sender_persist
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_sender_persist]
	@efile_hold_id INT,
	@dime_attachment VARBINARY(MAX),
	@submission_id VARCHAR(20),
	@message_id VARCHAR(20) =NULL,
	@status_id TINYINT = NULL,
	@stage VARCHAR(10),
	@state VARCHAR(10)
AS
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
		BEGIN TRAN
			IF EXISTS (SELECT 1 FROM [dbo].[efile_sender]  WITH(NOLOCK) WHERE [efile_hold_id] = @efile_hold_id AND [is_deleted] = 0) 
			UPDATE 
				[dbo].[efile_sender]  
			SET 
				[is_deleted] = 1 , 
				[update_time_stamp] = GETDATE() 
			WHERE 
				[efile_hold_id] = @efile_hold_id AND [is_deleted] = 0
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
				@efile_hold_id,
				@dime_attachment,
				@submission_id,
				@message_id,
				0,
				GETDATE(),
				GETDATE()
			)
			EXEC StatusUpdate @submission_id, @efile_hold_id, @status_id, @Stage, @State
		COMMIT TRAN
	SET NOCOUNT ON
GO
