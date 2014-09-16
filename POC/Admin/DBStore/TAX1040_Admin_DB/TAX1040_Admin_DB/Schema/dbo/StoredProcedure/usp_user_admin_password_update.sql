/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to update User admin Password
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_user_admin_password_update]
@user_admin_id BIGINT,
@password VARCHAR(500)

AS
BEGIN
	UPDATE [dbo].[user_admin] WITH(ROWLOCK) 
		SET password=@password 
	WHERE user_admin_id=@user_admin_id
END
