/*******************************************************************************
Created by Saravanan N - 15th April, 2014 - Persist SessionData into DB.
********************************************************************************/

CREATE PROCEDURE [dbo].[usp_session_data_persist]
	@user_id BIGINT,
	@user_data_id BIGINT,
	@session_data VARCHAR(300)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION

		UPDATE [dbo].[user_data]
		SET 
           [session_data]=@session_data, [upate_datetime]=GETDATE()
		WHERE 
			([user_id]=@user_id AND [user_data_id]=@user_data_id AND [is_deleted] = 0)

	IF @@ERROR = 0
		COMMIT TRANSACTION
	ELSE
		ROLLBACK TRANSACTION
	SET NOCOUNT OFF;
END