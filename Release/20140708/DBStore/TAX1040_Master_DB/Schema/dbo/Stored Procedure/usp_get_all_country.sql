/*********************************************************************************************
Created by vivekkumar - 14th March, 2014 -  Get All Country Details.  
*********************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_all_country]
AS
BEGIN
SET NOCOUNT ON;
	SELECT 
		[country_id],
		[country_code],
		[country_name]
	FROM
		[dbo].[country] WITH(NOLOCK)
	WHERE 
		([is_active]=1 AND [is_deleted]=0)
SET NOCOUNT OFF;
END


	