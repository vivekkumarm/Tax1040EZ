
/*****************************************************************************************
Created by Thileepkumar 26 April 2014 -  Procedure to get User Details by User Id
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_get_user_details_by_user_id]
(
	@user_id [BIGINT]
)
AS
BEGIN
	SET NOCOUNT ON
		SELECT 		
			[email] ,
			[username], 
			[password] ,
			[salt],
			[security_question_id],
			[security_answer]
			FROM [user]
		  WHERE
		[user_id]=@user_id AND [is_deleted] = 0 AND [is_active] = 1
    SET NOCOUNT OFF
END