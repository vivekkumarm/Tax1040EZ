/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_status_update
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_status_update]
(
	@submission_id VARCHAR(20)=null,
	@efile_hold_id BIGINT=null,
	@status_id INT= 0,
	@stage VARCHAR(10)= null,
	@state VARCHAR(10)= null
)
AS
	BEGIN
		SET NOCOUNT ON;
			IF @submission_id IS NOT NULL AND @efile_hold_id IS NULL
				SELECT
					@efile_hold_id = eh.[efile_hold_id] 
				FROM 
					[dbo].[efile_hold] eh WITH(NOLOCK) 
					JOIN [dbo].[efile_irs_schema] eis WITH(NOLOCK) 
					ON eis.[efile_hold_id]=eh.[efile_hold_id] 
					AND eis.[submission_id]=@submission_id 
					AND eis.[is_deleted]=0 
					AND eh.[is_deleted]=0
				SELECT
					@efile_hold_id
			IF @efile_hold_id is NULL RETURN
				UPDATE 
					[dbo].[efile_last_status] WITH(ROWLOCK)
				SET 
					[status_id] = @status_id, 
					[stage] = @stage, 
					[state] = @state, 
					[update_time_stamp] = GETDATE()
				WHERE 
					[efile_hold_id] = @efile_hold_id AND [is_deleted] = 0
			IF @@ROWCOUNT = 0
				INSERT INTO [dbo].[efile_last_status]
				(
					[efile_hold_id], 
					[status_id], 
					[stage],
					[state],
					[is_deleted], 
					[create_time_stamp], 
					[update_time_stamp]
				) 
				VALUES 
				(
					@efile_hold_id,
					@status_id,
					@stage,
					@state,
					0, 
					GETDATE(), 
					GETDATE()
				)
				INSERT INTO [dbo].[efile_progress] 
				(
					[efile_hold_id], 
					[progress_status], 
					[stage],
					[state],
					[create_time_stamp], 
					[update_time_stamp]
				) 
				VALUES 
				( 
					@efile_hold_id, 
					@status_id, 
					@stage,
					@state,
					GETDATE(), 
					GETDATE()
				) 
		SET NOCOUNT OFF;
	END
GO
