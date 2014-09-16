
/*****************************************************************************************
Created by Thileepkumar 26 April 2014 -  Procedure to validate User Password and get User Details by User Id
******************************************************************************************/
CREATE PROCEDURE [dbo].[usp_get_user_authentication_by_user_id]  
(
@user_id bigint
)
AS   
BEGIN  
SET NOCOUNT ON;  
	IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)  
		WHERE [user_id]=@user_id  
		AND [is_active] = 1  
		AND [is_deleted] = 0)   
  BEGIN  
	SELECT
		[user_id],  
		[password],  
		[salt]   
    FROM [dbo].[user] WITH(NOLOCK)   
    WHERE [user_id]=@user_id  
		AND [is_active] = 1  
		AND [is_deleted] = 0  
  END  
SET NOCOUNT OFF;  
END  