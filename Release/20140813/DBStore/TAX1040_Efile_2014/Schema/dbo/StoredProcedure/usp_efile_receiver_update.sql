/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_receiver_update
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_receiver_update]
@SubmissionID VARCHAR(20),
@ReceiverType VARCHAR(MAX),
@AttachmentStatus VARBINARY(MAX)=NULL,
@AckXML XML = NULL,
@StatusID INT = 0,
@Stage VARCHAR(10),
@State VARCHAR(10)
AS
	BEGIN
		SET NOCOUNT ON
		IF @ReceiverType='SendSubmissionStatus'
			UPDATE 
				[dbo].[efile_receiver] WITH(ROWLOCK) 
			SET 
				[send_submission_status] = @AttachmentStatus 
			WHERE 
				[submission_id] = @SubmissionID 
				AND [is_deleted] = 0
		ELSE IF @ReceiverType='GetAckStatus'
			BEGIN
				UPDATE 
					[dbo].[efile_receiver] WITH(ROWLOCK) 
				SET 
					[get_ack_status] = @AttachmentStatus 
				WHERE 
					[submission_id] = @SubmissionID 
					AND [is_deleted] = 0
			--			if @@rowcount > 0
			IF @State='Success'
			EXEC EFileNameControlCreate @SubmissionID
			END
		ELSE IF @ReceiverType='SubmissionStatus'
			UPDATE 
				[dbo].[efile_receiver] WITH(ROWLOCK) 
			SET 
				[submission_status] = @AttachmentStatus 
			WHERE 
				[submission_id] = @SubmissionID 
				AND [is_deleted] = 0
		ELSE IF @ReceiverType='GetSchedule1'
			UPDATE 
				[dbo].[efile_receiver] WITH(ROWLOCK) 
			SET 
				[schedule1] = @AttachmentStatus 
			WHERE 
				[submission_id] = @SubmissionID 
				AND [is_deleted] = 0
		ELSE IF @ReceiverType='AckXML'
			UPDATE 
				[dbo].[efile_receiver] WITH(ROWLOCK) 
			SET 
				[ack_xml] = @AckXML 
			WHERE 
				[submission_id] = @SubmissionID 
				AND [is_deleted] = 0
		EXEC StatusUpdate @SubmissionID, null, @StatusID, @Stage, @State
		SET NOCOUNT ON
	END
GO

