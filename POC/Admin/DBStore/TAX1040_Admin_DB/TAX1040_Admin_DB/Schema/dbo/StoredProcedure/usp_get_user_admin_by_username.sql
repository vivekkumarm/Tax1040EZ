/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to Get admin User
******************************************************************************************/
CREATE  PROCEDURE [dbo].[usp_get_user_admin_by_username]--'jeevan'
@username VARCHAR(15)

AS
BEGIN
	SELECT 
	A.user_admin_id,
	A.username,
	A.password,
	A.salt,
	A.email,
	A.is_active,
	R.role_name
	FROM [dbo].[user_admin] A WITH(NOLOCK)
	LEFT OUTER JOIN [dbo].[user_admin_role] R WITH(NOLOCK) ON A.user_admin_id=R.user_admin_id 
	WHERE username=@username
End




