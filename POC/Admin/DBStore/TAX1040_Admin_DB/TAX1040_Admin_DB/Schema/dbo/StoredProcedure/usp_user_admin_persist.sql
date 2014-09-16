/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to persist User admin
******************************************************************************************/

CREATE PROCEDURE [dbo].[usp_user_admin_persist] 
@username VARCHAR(15),
@password VARCHAR(500),
@salt VARCHAR(15),
@email VARCHAR(50),
@is_active BIT=1,
@is_password_change BIT=0

AS
BEGIN
SET NOCOUNT ON;

IF EXISTS (SELECT 1 FROM [dbo].[user_admin] WITH(NOLOCK) WHERE username=username)
	BEGIN
		IF @is_password_change=1

			   UPDATE [dbo].[user_admin] WITH(ROWLOCK) SET 
				password=@password,salt=@salt,email=@email,is_active=@is_active
				WHERE username=@username
		ELSE
				UPDATE [dbo].[user_admin] WITH(ROWLOCK) SET 
				email=@email,is_active=@is_active
				WHERE username=@username
	END
		ELSE
	BEGIN

			INSERT INTO [dbo].[user_admin](username,password,
			salt,email,is_active,is_deleted)
			VALUES(@username,@password,
			@salt,@email,@is_active,0)

			SELECT @@identity 'admin_user_id'
	END
SET NOCOUNT OFF;
END
