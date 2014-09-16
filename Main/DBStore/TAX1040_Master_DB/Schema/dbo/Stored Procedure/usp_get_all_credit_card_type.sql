/**********************************************************************************************
Created By Ashok Kumar - 22 May, 2014 Get All Credit Card Type.  
**********************************************************************************************/
/* Modification History */

CREATE PROCEDURE [dbo].[usp_get_all_credit_card_type]
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN
	SELECT 
		[credit_card_type_id],
		[credit_card_type]
	FROM
		[dbo].[credit_card_type] WITH (NOLOCK)
	WHERE
		[is_active]=1 AND [is_deleted]=0 
	END
	SET NOCOUNT OFF;
END
