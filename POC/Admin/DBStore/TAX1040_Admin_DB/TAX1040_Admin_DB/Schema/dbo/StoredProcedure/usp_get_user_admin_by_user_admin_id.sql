/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to getuser admin by admin user id
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_get_user_admin_by_user_admin_id]
@user_admin_id BIGINT
As
BEGIN
SET NOCOUNT ON;

	SELECT 
		[user_admin_id],
		[username],
		[password],
		[salt],
		[email],
		[is_active]
	FROM [dbo].[user_admin] WITH(NOLOCK) 
	WHERE 
		(user_admin_id=@user_admin_id and is_deleted=0)
	
	SELECT 
		[admin_role_id],
		[role_name]
	FROM [dbo].[user_admin_role] WITH(NOLOCK)
	WHERE 
		(user_admin_id=@user_admin_id and is_deleted=0)

SET NOCOUNT OFF;
END