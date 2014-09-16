
/*****************************************************************************************
Created by Thileepkumar 26 April 2014 -  Procedure to Update User Details
Modified by Thileepkumar - 30 April 2014 - Added for Username and E already exise
Modified by Thileepkumar - 26June 2014 - Removed the salt from securityanswer update
Modified by Thileepkumar - 04July 2014 
******************************************************************************************/
--exec [dbo].usp_update_user_details_by_user_id 2,'','thileep','','',0,''

 CREATE PROCEDURE [dbo].[usp_update_user_details_by_user_id]  
(    
       @user_id [BIGINT]  
      ,@email NVARCHAR(100) = NULL  
      ,@username NVARCHAR(100) = NULL  
      ,@password NVARCHAR(100) = NULL   
      ,@salt   NVARCHAR(100) = NULL  
      ,@security_question_id INT = 0  
      ,@security_answer NVARCHAR(150) = NULL  
)  
AS  
BEGIN    
 SET NOCOUNT ON  
  DECLARE @username_exist int
  DECLARE @email_exist int  
  SET @username_exist=2
  SET @email_exist=1

IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)WHERE [user_id] = @user_id AND [is_active] = 1  AND [is_deleted] = 0)                                               

BEGIN  
IF   EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)WHERE  [email] = @email AND  [is_active] = 1  AND [is_deleted] = 0)                                               
   BEGIN   
	  BEGIN  
         SELECT  @email_exist	      
      END  
   END
   
ELSE       
	   IF(@email != '') 
	 BEGIN 
        UPDATE [dbo].[user]   
	     SET  
           [email] = @email,  
           [Update_datetime] = GETDATE()   
           WHERE  [user_id] = @user_id  
           AND [is_deleted] = 0  
           AND [is_active] = 1  
     END 
   
IF  EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)WHERE [username] = @username AND [is_active] = 1  AND [is_deleted] = 0)                                               
   BEGIN   
     BEGIN  
      SELECT  @username_exist  
     END 
   END
   
ELSE   
      IF(@username != '')
    BEGIN   
     UPDATE [dbo].[user]   
        SET  
         [username] = @username,  
         [Update_datetime] = GETDATE()   
         WHERE  [user_id] = @user_id   
         AND [is_deleted] = 0  
         AND [is_active] = 1  
    END
   
     IF(@password != '' AND @salt != '')  
    BEGIN  
        UPDATE [dbo].[user]   
       SET  
        [password]=@password,  
        [Update_datetime] = GETDATE()   
        WHERE  [user_id] = @user_id   
        AND [is_deleted] = 0   
        AND [is_active] = 1  
    END      
   
     IF(@security_answer != ''  AND @security_question_id != 0)  
    BEGIN  
        UPDATE [dbo].[user]   
      SET  
      [security_question_id] = @security_question_id,  
      [security_answer] = @security_answer, 
      [Update_datetime] = GETDATE()   
      WHERE  [user_id] = @user_id   
      AND [is_deleted] = 0  
      AND [is_active] = 1  
    END    
  
END    
SET NOCOUNT OFF     
END