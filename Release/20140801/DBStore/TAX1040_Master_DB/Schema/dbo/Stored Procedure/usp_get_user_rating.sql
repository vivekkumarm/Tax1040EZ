/*************************************************************************************************
Created by Sathish on 18Jul2014 get user rating
**************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_user_rating]
@user_id BIGINT
AS
	SELECT [rating],[comment] FROM [dbo].[user_rating] WITH(NOLOCK) 
			WHERE [user_id]=@user_id
RETURN 0
