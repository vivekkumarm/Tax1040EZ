/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to delete User admin
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_user_admin_delete]
	@user_admin_id BIGINT
AS
BEGIN
SET NOCOUNT ON;
	DELETE FROM [dbo].[user_admin_role] WITH(ROWLOCK) WHERE user_admin_id=@user_admin_id
	DELETE FROM [dbo].[user_admin] WITH(ROWLOCK) WHERE user_admin_id=@user_admin_id

SET NOCOUNT OFF;
END
