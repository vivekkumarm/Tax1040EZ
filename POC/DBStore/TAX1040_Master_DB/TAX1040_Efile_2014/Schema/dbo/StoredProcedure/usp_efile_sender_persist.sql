/*********************************************************************************************************
	CREATED BY: Saravanan N				STORED PROCEDURE NAME: usp_efile_sender_persist
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_sender_persist]
	@efile_return_data_id INT,
	@dime_attachment VARBINARY(MAX),
	@submission_id VARCHAR(20),
	@message_id VARCHAR(20) =NULL,
	@stage_id INT,
	@state VARCHAR(20)
AS
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
		BEGIN TRAN
			IF EXISTS (SELECT 1 FROM [dbo].[efile_sender]  WITH(NOLOCK) WHERE [efile_return_data_id] = @efile_return_data_id AND [is_deleted] = 0) 
			UPDATE 
				[dbo].[efile_sender]  
			SET 
				[is_deleted] = 1  
			WHERE 
				[efile_return_data_id] = @efile_return_data_id AND [is_deleted] = 0
				
			INSERT INTO [dbo].[efile_sender] 
			(
				[efile_return_data_id],
				[dime_attachment],
				[submission_id],
				[message_id]
			)
			VALUES
			(
				@efile_return_data_id,
				@dime_attachment,
				@submission_id,
				@message_id
			)
			
			EXEC [dbo].[usp_return_status_update] @submission_id, @efile_return_data_id, @Stage_id, @State
		COMMIT TRAN
	SET NOCOUNT ON
GO
