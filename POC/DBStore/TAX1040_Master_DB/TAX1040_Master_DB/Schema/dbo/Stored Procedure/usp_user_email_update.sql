/****************************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 - Procedure to update user email id
Modification History
Modified by Bala 26Mar2014 return username instead of status
*****************************************************************************************/

CREATE PROCEDURE [dbo].[usp_user_email_update]
@user_id BIGINT,
@email NVARCHAR(100)
AS
BEGIN
SET NOCOUNT ON;

DECLARE @username as NVARCHAR(100) = ''

IF NOT EXISTS(SELECT [email] FROM [dbo].[user] WITH(NOLOCK) 
	WHERE [user_id] <> @user_id
	AND [email] = @email)
BEGIN
	UPDATE [dbo].[user] 
	SET [email]=@email,
	[update_datetime] = GETDATE() 
	WHERE [user_id]=@user_id 
	AND [is_active] = 1 
	AND [is_deleted] = 0

IF @@ROWCOUNT > 0
    SELECT @username = [username]
	FROM [dbo].[user] WITH(NOLOCK) 
	WHERE [user_id] = @user_id
END

SELECT @username AS 'username'

SET NOCOUNT OFF;
END