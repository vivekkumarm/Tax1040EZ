/***************************************************************************************************
Created by Sathish - 14 March 2014 - Procedure to get security questions.
Modified By Swapnesh -7-may-2014 -  get selected question id
****************************************************************************************************/
CREATE PROCEDURE [dbo].[usp_get_security_question]
@user_id BIGINT = 0
AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT [question_id],
		   [question] 
	FROM [dbo].[security_question] WITH (NOLOCK)
	WHERE [is_deleted] = CAST(0 AS BIT)

	SELECT 
	      security_question_id AS selected_question_id 
	FROM [dbo].[user]  WITH (NOLOCK)
	WHERE [user_id] = @user_id
	
	SET NOCOUNT OFF; 

END
