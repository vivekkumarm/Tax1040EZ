/*****************************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 - Procedure to get username by email
******************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_username_by_email]
@email NVARCHAR(100)
AS
BEGIN
SET NOCOUNT ON;

   SELECT [username]
   FROM [dbo].[user] WITH(NOLOCK) 
   WHERE ([email]=@email
   AND [is_active] = 1
   AND [is_deleted] = 0)

SET NOCOUNT OFF;
END