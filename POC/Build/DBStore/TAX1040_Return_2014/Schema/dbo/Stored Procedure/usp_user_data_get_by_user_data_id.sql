/****************************************************************************************
Author          : Ashok Kumar - 
Created Date    : 17th March, 2014
Description     : Retrieving User data by use_data_id from DB.


     Date                 Name                         Summary
    -----                ------                       ---------
18th March, 2014        Ashok Kumar        Added @user_id as input parameter
*/

CREATE PROCEDURE [dbo].[usp_user_data_get_by_user_data_id]
@user_data_id BIGINT,
@user_id BIGINT
AS 
BEGIN
SET NOCOUNT ON;

    SELECT 
		[user_id],
		[session_data],
		[tax_data],
		[history_data],
		[session_terminate],
		[create_datetime],
		[upate_datetime],
		[is_deleted]
    FROM  [dbo].[user_data] WITH(NOLOCK)
    WHERE [user_data_id]=@user_data_id and [user_id]=@user_id and [is_deleted]=0
   
SET NOCOUNT OFF;
END
    
