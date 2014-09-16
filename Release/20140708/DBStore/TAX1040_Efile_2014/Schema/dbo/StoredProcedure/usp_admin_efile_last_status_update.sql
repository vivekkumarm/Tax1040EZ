/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_admin_efile_last_status_update
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_admin_efile_last_status_update]
@efile_hold_id BIGINT,
@stage VARCHAR(10),
@state VARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON; 
			UPDATE 
				[dbo].[efile_last_status] WITH(ROWLOCK) 
			SET 
				[stage] = @stage,
				[state] = @state
			WHERE 
				efile_hold_id = @efile_hold_id 
				AND [is_deleted] = 0
		SET NOCOUNT OFF; 
	END
GO
