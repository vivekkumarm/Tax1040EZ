/*******************************************************************************
Created by vivekkumar - 7th March, 2014 -  Update users password_reset_code
********************************************************************************/

CREATE PROCEDURE [dbo].[usp_user_password_reset_code_update]
@password_reset_code BIGINT,
@user_id BIGINT
AS
BEGIN
SET NOCOUNT ON;

    UPDATE [dbo].[user] 
	SET password_reset_code=@password_reset_code,
	update_datetime = GETDATE() 
	WHERE [user_id] = @user_id
    AND is_active = 1 AND is_deleted = 0

	SELECT 1 AS 'Status'

SET NOCOUNT OFF;
END
