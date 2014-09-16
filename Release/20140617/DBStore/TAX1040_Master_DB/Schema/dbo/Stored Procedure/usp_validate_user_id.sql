/***************************************************************************************************
Created by Swapnesh on 02-May-2014  For Validate User ID  
****************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_valid_user_id]

@user_id BIGINT
AS

BEGIN
SET NOCOUNT ON;

	IF EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)
				  WHERE [user_id]=@user_id 
					AND [is_active] = 1 
					AND [is_deleted] = 0)
	BEGIN
			SELECT CAST(1 AS BIT) 'valid_user_id'
	END   
		ELSE

	BEGIN
        SELECT CAST(0 AS BIT) AS 'Valid_user_id'
	END       

SET NOCOUNT OFF;

END
