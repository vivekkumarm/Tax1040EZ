/*10Mar2014 Bala Validate passwrd reset code in user table*/  
/* Modification History*/ 
/* sathish - 27March2014 - Changed according to coding standard
   Sathish - 31March2014 - Validated password reset code by user id instead of user name and return true if user exist else false
   Bala - 19May14 -Added condition to check Password reset code is valid only for 24hours.		
*/    
CREATE PROCEDURE [dbo].[usp_validate_user_password_reset_code]
@password_reset_code BIGINT,
@user_id BIGINT
AS
BEGIN
SET NOCOUNT ON;
IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK) 
			WHERE [user_id]=@user_id 
				   AND [password_reset_code] = @password_reset_code
				   AND DATEDIFF(hh,[update_datetime],GETDATE()) <= 24
				   AND [is_active] = 1 
				   AND [is_deleted] = 0)
BEGIN
	SELECT CAST(1 AS BIT) 'valid_password_rest_code'
END    
ELSE
BEGIN
	SELECT CAST(0 AS BIT) AS 'valid_password_rest_code'
END	
SET NOCOUNT OFF;
END
