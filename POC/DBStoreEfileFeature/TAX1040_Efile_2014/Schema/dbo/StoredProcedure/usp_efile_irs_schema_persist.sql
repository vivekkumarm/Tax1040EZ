/*********************************************************************************************************
	CREATED BY: SWAPNESH				STORED PROCEDURE NAME: usp_efile_irs_schema_persist
	CREATED ON: 8th July, 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_irs_schema_persist]
@efile_return_data_id INT,
@efile_irs_schema XML,
@manifest_xml XML = NULLL,
@submission_id VARCHAR(20) = NULL,
@stage_id VARCHAR(10) = NULL,
@state VARCHAR(10) = NULL
AS
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	SET NOCOUNT ON;
		BEGIN TRAN
			IF EXISTS (SELECT 1 FROM [dbo].[efile_irs_schema] WITH(NOLOCK)  WHERE [efile_return_data_id] = @efile_return_data_id AND [is_deleted] = 0)
				UPDATE  
					[dbo].[efile_irs_schema]
				SET 
					[is_deleted] = 1,
					[update_datetime] = GETDATE() 
				WHERE 
					[efile_return_data_id] = @efile_return_data_id AND [is_deleted] = 0
			INSERT INTO [dbo].[efile_irs_schema]
			(
				[efile_return_data_id],
				[efile_irs_schema],
				[manifest_xml], 
				[submission_id],
				[is_deleted],
				[create_datetime],
				[update_datetime]
			)
			VALUES 
			(
				@efile_return_data_id,
				@efile_irs_schema,
				@manifest_xml, 
				@submission_id,
				0,
				GETDATE(),
				GETDATE()
			)
			
				EXEC [dbo].[usp_return_status_update] @submission_id, @efile_return_data_id, @stage_id, @state 
		COMMIT TRAN
	SET NOCOUNT OFF;
GO
