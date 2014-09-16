/*********************************************************************************************
Created by vivekkumar - 14th March, 2014 -  Get All State Details.  
*********************************************************************************************/
/* Modification History */
/* Sathish - 08May2014 added us mailing address */
CREATE PROCEDURE [dbo].[usp_get_all_state]
(
	@is_additional_mailing_address bit
)
AS
BEGIN
SET NOCOUNT ON;
	IF @is_additional_mailing_address = 0
	BEGIN
		SELECT 
			[state_id],
			[state_code],
			[state_name]
		FROM
			[dbo].[state] WITH(NOLOCK)
		WHERE 
			([is_active]=1 AND [is_deleted]=0
			 AND [is_additional_mailing_address] = 0)
	END
	ELSE
	BEGIN
		SELECT 
			[state_id],
			[state_code],
			[state_name]
		FROM
			[dbo].[state] WITH(NOLOCK)
		WHERE 
			([is_active]=1 AND [is_deleted]=0)
	END
SET NOCOUNT OFF;
END