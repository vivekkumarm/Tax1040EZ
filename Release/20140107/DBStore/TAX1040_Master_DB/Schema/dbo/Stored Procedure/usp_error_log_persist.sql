/*******************************************************************************
Created by SWAPNESH - 6 MAY 2014 - Procedure to log Error in application
********************************************************************************/

CREATE PROCEDURE [dbo].[usp_error_log_persist]
@user_id BIGINT,
@exception_occured_instance [NVARCHAR](200) = NULL,
@exception_message [NVARCHAR](MAX) = NULL
AS
BEGIN
	SET NOCOUNT ON;
		 INSERT INTO [dbo].[error_log]
		  (
					  [user_id],
					  [exception_occured_instance],
					  [exception_message]            
					  )
					  VALUES
					  (
					  @user_id,
					  @exception_occured_instance,
					  @exception_message
					  )   

	SET NOCOUNT OFF;
END
GO