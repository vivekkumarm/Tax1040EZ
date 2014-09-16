/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to get admin role by id
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_get_user_admin_role_by_user_admin_id]
@user_admin_id BIGINT
As
BEGIN
SET NOCOUNT ON;

	SELECT 
		[user_admin_id],
		[role_name] 
		FROM [dbo].[user_admin_role] WITH(NOLOCK)

	WHERE 
		(user_admin_id=@user_admin_id AND is_deleted=0)

SET NOCOUNT OFF;
END

