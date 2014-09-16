/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_update_system_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_update_system_status]
@irs_system_id  VARCHAR(20),
@efile_hold_id  BIGINT
AS
	SET NOCOUNT ON; 
		BEGIN
			UPDATE 
				[dbo].[efile_hold] WITH(ROWLOCK) 
			SET  
				[irs_system_id] = @irs_system_id
			WHERE
				[efile_hold_id] = @efile_hold_id 
			UPDATE 
				[dbo].[efile_sender] WITH(ROWLOCK) 
			SET  
				[irs_system_id] = @irs_system_id
			WHERE 
				[efile_hold_id] = @efile_hold_id 
		END
	SET NOCOUNT OFF; 
GO
