/*********************************************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 - Procedure to get username By User Personal details
Modified by Sathish removed Security question and Security answer
**********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_username_by_personal_details]
@first_name NVARCHAR(100),
@last_name NVARCHAR(100),
@date_of_birth DATETIME,
@email NVARCHAR(100)
AS
BEGIN
SET NOCOUNT ON;

    SELECT u.[user_id],
			u.[username] 
	FROM [dbo].[user] u WITH(NOLOCK)
	INNER JOIN [dbo].[personal_info] p WITH(NOLOCK)
	ON u.[user_id]=p.[user_id]
	WHERE (p.[first_name]=@first_name)
	AND (p.[last_name]=@last_name)
	AND (CAST(CONVERT(VARCHAR(10),p.[date_of_birth],110)AS DATETIME)=CAST(CONVERT(VARCHAR(10),@date_of_birth,110)AS DATETIME))
	AND (u.[email]=@email)
	AND (u.[is_active] = 1)
	AND	(u.[is_deleted] = 0)
	AND (p.[is_deleted] = 0)

SET NOCOUNT OFF;
END