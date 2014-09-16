/*****************************************************************************************
Created by Sathish 18-March-2014 Get security question associated to the user
******************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_security_question_by_user_id]
	@user_id BIGINT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT q.[question_id],
			q.[question] 
	FROM [dbo].[user] AS u WITH(NOLOCK)  
	INNER JOIN [dbo].[security_question] AS q WITH(NOLOCK)  
		ON u.[security_question_id] = q.[question_id]
	WHERE u.[user_id] = @user_id

	SET NOCOUNT OFF;

END