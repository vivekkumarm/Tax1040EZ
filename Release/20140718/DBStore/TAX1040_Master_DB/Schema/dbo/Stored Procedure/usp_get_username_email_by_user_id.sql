/*******************************************************************************
Created by Balasubramanian Velmurugan - 14 April 2014 - Procedure to get username and user's email by user id
Modified by 
********************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_username_email_by_user_id]
@user_id BIGINT
AS
BEGIN
SET NOCOUNT ON;

IF EXISTS(SELECT 1 FROM [dbo].[user]  WITH(NOLOCK)  
WHERE [user_id]=@user_id
	AND [is_active] = 1
	AND [is_deleted] = 0)

BEGIN
	SELECT  [username], 
			[email]
	FROM [dbo].[user] WITH(NOLOCK)  
	WHERE [user_id]=@user_id
	AND [is_active] = 1
	AND [is_deleted] = 0
END
ELSE
BEGIN
	SELECT '' AS [username], 
		   '' AS [email]
END

SET NOCOUNT OFF;
END
GO


