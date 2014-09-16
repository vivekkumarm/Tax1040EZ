/*********************************************************************************************/
/* Modification History */
/* Ashok Kumar - 23July2014 added for getting supporting states*/
CREATE PROCEDURE [dbo].[usp_get_all_supporting_state]
AS
BEGIN
SET NOCOUNT ON;	
	BEGIN
		SELECT 
			[state_id],
			[state_code],
			[state_name]
		FROM
			[dbo].[state] WITH(NOLOCK)
		WHERE 
			([is_active]=1 AND [is_deleted]=0
			 AND [is_supporting_state] = 1)
	END
SET NOCOUNT OFF;
END
GO