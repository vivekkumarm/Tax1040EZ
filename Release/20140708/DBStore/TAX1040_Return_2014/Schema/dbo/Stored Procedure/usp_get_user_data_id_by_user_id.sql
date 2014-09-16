/*******************************************************************************
Created by Balasubramanian - 2 April 2014 - Procedure for get user_data_id column from [user_data] table by user_id column
/* Modification History*/ 
********************************************************************************/   
CREATE PROCEDURE [dbo].[usp_get_user_data_id_by_user_id]
@user_id BIGINT
AS
BEGIN
SET NOCOUNT ON;
IF EXISTS(SELECT 1 FROM [dbo].[user_data] WITH(NOLOCK) 
			WHERE [user_id]=@user_id 
			  AND [is_deleted] = 0)
BEGIN
	SELECT [user_data_id] FROM [dbo].[user_data] WITH(NOLOCK) 
			WHERE [user_id]=@user_id 
			  AND [is_deleted] = 0
END    
ELSE
BEGIN
	SELECT CAST(0 AS BIGINT) AS 'user_data_id'
END	
SET NOCOUNT OFF;
END