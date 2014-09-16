/*************************************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 - Procedure to check whether the user exists
**************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_is_user_exists]
@username NVARCHAR(100)
AS
BEGIN 
SET NOCOUNT ON;

IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK) 
	WHERE [username]=@username
	AND [is_active] = 1
	AND [is_deleted] = 0)
BEGIN
	SELECT [user_id] 
	FROM [dbo].[user] WITH(NOLOCK) 
	WHERE [username]=@username
	AND [is_active] = 1 
	AND [is_deleted] = 0
END
ELSE
BEGIN
    SELECT 0 AS 'user_id'
END
SET NOCOUNT OFF;
END