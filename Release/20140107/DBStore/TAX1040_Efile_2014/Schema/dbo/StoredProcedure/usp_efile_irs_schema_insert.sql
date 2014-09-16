/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_irs_schema_insert
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_irs_schema_insert]
@efile_hold_id INT,
@efile_irs_schema XML,
@manifest_xml XML = NULLL,
@submission_id VARCHAR(20) = NULL,
@status_id INT = 0,
@stage VARCHAR(10) = NULL,
@state VARCHAR(10) = NULL
AS
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	SET NOCOUNT ON;
		BEGIN TRAN
			IF EXISTS (SELECT 1 FROM [dbo].[efile_irs_schema] WITH(NOLOCK)  WHERE [efile_hold_id] = @efile_hold_id AND [is_deleted] = 0)
				UPDATE  
					[dbo].[efile_irs_schema]
				SET 
					[is_deleted] = 1,
					[update_time_stamp] = GETDATE() 
				WHERE 
					[efile_hold_id] = @efile_hold_id AND [is_deleted] = 0
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
			EXEC StatusUpdate NULL, @efile_hold_id, @submission_id ,@stage,@state
		COMMIT TRAN
	SET NOCOUNT OFF;
GO
