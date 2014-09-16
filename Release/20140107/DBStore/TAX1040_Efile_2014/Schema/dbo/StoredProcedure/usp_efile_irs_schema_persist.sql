/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_irs_schema_persist
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_irs_schema_persist]
@efile_hold_id INT,
@efile_irs_schema XML,
@manifest_xml XML = NULLL,
@submission_id VARCHAR(20) = NULL,
@status_id INT = 0,
@old_submission_id VARCHAR(30) = NULL,
@stage VARCHAR(10),
@state VARCHAR(10)
AS
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	SET NOCOUNT ON
		BEGIN TRAN
			IF @old_submission_id IS NULL
				BEGIN 
					INSERT INTO [dbo].[efile_irs_schema]
					(
						[efile_hold_id],
						[efile_irs_schema],
						[manifest_xml], 
						[submission_id],
						[is_deleted],
						[create_time_stamp],
						[update_time_stamp]
					)
					VALUES 
					(
						@efile_hold_id,
						@efile_irs_schema,
						@manifest_xml, 
						@submission_id,
						0,
						GETDATE(),
						GETDATE()
					)
					EXEC 
						StatusUpdate NULL,
						@efile_hold_id, 
						@status_id,
						@Stage,
						@State
				END 
			ELSE
				BEGIN
					INSERT INTO [dbo].[efile_irs_schema]
					(
						[efile_hold_id],
						[efile_irs_schema],
						[manifest_xml], 
						[submission_id],
						[is_deleted],
						[create_time_stamp],
						[update_time_stamp]
					)
					VALUES 
					(
						@efile_hold_id,
						@efile_irs_schema,
						@manifest_xml,
						@submission_id,
						0,
						GETDATE(),
						GETDATE()
					)
					EXEC 
						StatusUpdate NULL,
						@efile_hold_id, 
						@status_id,
						@Stage,
						@State
					UPDATE 
						[dbo].[efile_irs_schema] WITH(ROWLOCK)
					SET 
						[is_deleted] = 1,[update_time_stamp] = GETDATE() 
					WHERE 
						[submission_id] = @submission_id
					UPDATE 
						[dbo].[efile_sender] SET [is_deleted] = 1 WHERE [submission_id] = @old_submission_id
					UPDATE 
						[dbo].[efile_receiver] SET [is_deleted] = 1 WHERE [submission_id] = @old_submission_id
				END 
		COMMIT TRAN
	SET NOCOUNT OFF
GO
