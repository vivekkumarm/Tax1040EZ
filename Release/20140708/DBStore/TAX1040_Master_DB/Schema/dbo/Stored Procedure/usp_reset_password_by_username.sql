/*********************************************************************************
Created by vivekkumar - 7th March, 2014 -  Procedure to Reset Password By Username
Modification History
Modified by Bala 26Mar2014 return email instead of status
**********************************************************************************/

CREATE PROCEDURE [dbo].[usp_reset_password_by_username]
@user_id BIGINT,
@username NVARCHAR(100),
@password NVARCHAR(100),
@salt NVARCHAR(100)
AS
BEGIN
SET NOCOUNT ON;

IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK) 
	WHERE [user_id]=@user_id
	AND [username]=@username
	AND [is_active] = 1
	AND [is_deleted] = 0)

BEGIN
    UPDATE [dbo].[user]
	SET [password]=@password,
		[salt]=@salt,
		[update_datetime] = GETDATE() 
	WHERE [user_id]=@user_id
	AND [username]=@username
    AND [is_active] = 1
	AND [is_deleted] = 0

    SELECT [email] 
	FROM [dbo].[user]
	WHERE [user_id]=@user_id
END
ELSE
BEGIN
	SELECT '' AS email 
END	
SET NOCOUNT OFF;
END