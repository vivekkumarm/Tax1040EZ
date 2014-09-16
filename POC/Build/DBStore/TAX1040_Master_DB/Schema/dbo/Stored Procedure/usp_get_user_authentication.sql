/***************************************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 - Procedure to get user authentication details
****************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_user_authentication]
@username NVARCHAR(100)
AS 
BEGIN
SET NOCOUNT ON;

IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)
	WHERE [username]=@username
	AND [is_active] = 1
	AND [is_deleted] = 0)

BEGIN
	SELECT [user_id],
		   [password],
		   [salt] 
    FROM [dbo].[user] WITH(NOLOCK) 
    WHERE [username]=@username
	AND [is_active] = 1
	AND [is_deleted] = 0
END
SET NOCOUNT OFF;
END

