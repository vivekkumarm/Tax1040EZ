/*10 Mar 2014 Bala Retrieve Userid given by user & personal_info details
* Modified by Sathish 19Mar2014 removed security question and security answer
Modified by Sathish 25Mar2014 changed social security number datatype to varchar
*/

CREATE PROCEDURE [dbo].[usp_get_user_id_by_personal_details]
@first_name NVARCHAR(100),
@last_name NVARCHAR(100),
@date_of_birth DATETIME,
@social_security_number VARCHAR(15)
AS
BEGIN
SET NOCOUNT ON;

    SELECT u.[user_id] 
	FROM [dbo].[user] u WITH(NOLOCK)
	INNER JOIN [dbo].[personal_info] p WITH(NOLOCK) ON u.[user_id]=p.[user_id]
	WHERE p.[first_name]=@first_name AND p.[last_name]=@last_name AND
	CAST(CONVERT(VARCHAR(10),p.[date_of_birth],110)AS DATETIME)=CAST(CONVERT(VARCHAR(10),@date_of_birth,110)AS DATETIME) AND
	p.[social_security_number]=@social_security_number AND
	u.[is_active] = 1 AND u.[is_deleted] = 0 AND p.[is_deleted] = 0 

SET NOCOUNT OFF;
END