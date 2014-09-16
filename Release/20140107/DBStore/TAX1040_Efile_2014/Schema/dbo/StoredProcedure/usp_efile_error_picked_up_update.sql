/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_error_picked_up_update
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_error_picked_up_update]
@efile_error_id INT
AS
	BEGIN
		SET NOCOUNT ON
			UPDATE 
				[dbo].[efile_error] WITH(ROWLOCK)  
			SET 
				[error_picked_up] = 1 ,
				[update_time_stamp] = GETDATE() 
			WHERE 
				[efile_error_id] = @efile_error_id
		SET NOCOUNT ON
	END
GO
