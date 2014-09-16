/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_status_update
	CREATED ON: 9th May 2014

	Modified By Swapnesh  on 8th July 2014  GETDATE
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_return_status_update]
(
	@submission_id VARCHAR(20)=null,
	@efile_return_data_id BIGINT=null,
	@stage_id INT= 0,
	@state VARCHAR(10) = null
)
AS
	BEGIN
		SET NOCOUNT ON;
			IF @submission_id IS NOT NULL AND @efile_return_data_id IS NULL
				SELECT
					@efile_return_data_id = eh.[efile_return_data_id] 
				FROM 
					[dbo].[efile_return_data] eh WITH(NOLOCK) 
					JOIN [dbo].[efile_irs_schema] eis WITH(NOLOCK) 
					ON eis.[efile_return_data_id]=eh.[efile_return_data_id] 
					AND eis.[submission_id]=@submission_id 
					AND eis.[is_deleted]=0 
					AND eh.[is_deleted]=0
				
                SELECT
					@efile_return_data_id

			IF @efile_return_data_id is NULL RETURN

			UPDATE 
				[dbo].[efile_current_status] WITH(ROWLOCK)
			SET 
				[stage_id] = @stage_id, 
				[state] = @state ,
				[update_datetime] = GETDATE()
			WHERE 
				[efile_return_data_id] = @efile_return_data_id

			IF @@ROWCOUNT = 0
				INSERT INTO [dbo].[efile_current_status]
				(
					[efile_return_data_id], 
					[stage_id],
					[state]
				) 
				VALUES 
				(
					@efile_return_data_id,
					@stage_id,
					@state
				)

			INSERT INTO [dbo].[efile_progress] 
			(
				[efile_return_data_id], 
				[stage_id],
				[state]
			) 
			VALUES 
			( 
				@efile_return_data_id, 
				@stage_id,
				@state
			) 

		SET NOCOUNT OFF;
	END