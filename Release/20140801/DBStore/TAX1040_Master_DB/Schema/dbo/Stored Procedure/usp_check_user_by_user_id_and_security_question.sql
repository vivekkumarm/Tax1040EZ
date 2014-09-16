/*******************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 - Procedure for Check user by username,security_question and security_answer
Modified by sathish - 18 Mar 2014 changed parameter data type for security question to int
********************************************************************************/

CREATE PROCEDURE [dbo].[usp_check_user_by_user_id_and_security_question]
@user_id BIGINT,
@security_question_id int,
@security_answer NVARCHAR(100)
AS
BEGIN
SET NOCOUNT ON;

IF EXISTS(SELECT 1 FROM [dbo].[user]  WITH(NOLOCK)  
WHERE [user_id]=@user_id
	AND [security_question_id]=@security_question_id 
	AND [security_answer]=@security_answer
	AND [is_active] = 1
	AND [is_deleted] = 0)

BEGIN
	SELECT  [username], 
			[email]
	FROM [dbo].[user] WITH(NOLOCK)  
	WHERE [user_id]=@user_id
	AND [security_question_id]=@security_question_id
	AND [security_answer]=@security_answer
	AND [is_active] = 1
	AND [is_deleted] = 0
END

SET NOCOUNT OFF;
END
