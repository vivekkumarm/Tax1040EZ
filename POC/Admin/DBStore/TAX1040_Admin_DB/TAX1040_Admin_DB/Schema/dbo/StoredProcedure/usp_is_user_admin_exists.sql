/*****************************************************************************************
Created by Praveen T  - 21 July 2014 -  Procedure to check whether User admin exist
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_is_user_admin_exists]
@username VARCHAR(15)
AS
BEGIN
SET NOCOUNT ON;

	IF EXISTS(SELECT 1 FROM [dbo].[user_admin] WITH(NOLOCK) WHERE username=@username)
		SELECT 1 AS 'Status'
	ELSE
		SELECT 0 AS 'Status'
SET NOCOUNT OFF;
END




