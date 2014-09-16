/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to get all admin user
******************************************************************************************/

CREATE procedure [dbo].[usp_get_all_user_admin]
AS
BEGIN
SET NOCOUNT ON;
	SELECT 
		[user_admin_Id],
		[username],
		[password],
		[salt],
		[email],
		[is_active] 
	FROM [dbo].[user_admin] WITH(NOLOCK) 
	WHERE 
		(is_active=1 AND is_deleted=0)
SET NOCOUNT OFF;
END
