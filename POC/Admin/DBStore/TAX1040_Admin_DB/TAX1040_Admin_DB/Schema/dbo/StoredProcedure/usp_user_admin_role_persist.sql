/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to persist admin role
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_user_admin_role_persist]
@user_admin_id BIGINT,
@role_name VARCHAR(50)
AS
BEGIN
SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM [dbo].[user_admin_role] WITH(NOLOCK) 
		WHERE 
		user_admin_id=@user_admin_id AND role_name=@role_name)
		RETURN

	ELSE
		INSERT INTO [dbo].[user_admin_role]
		(admin_role_id,role_name,is_deleted) 
		VALUES (@user_admin_id,@role_name,0)

SET NOCOUNT OFF;
END 
