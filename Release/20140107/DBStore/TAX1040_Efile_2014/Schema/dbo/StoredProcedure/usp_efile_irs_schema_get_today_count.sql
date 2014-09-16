/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_irs_schema_get_today_count
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_irs_schema_get_today_count]
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				COUNT([efile_irs_schema_id]) AS 'Count' 
			FROM 
				[dbo].[efile_irs_schema] WITH(NOLOCK) 
			WHERE 
				CONVERT([VARCHAR](20),[create_time_stamp],107) = CONVERT([VARCHAR](20),GETDATE(),107)
		SET NOCOUNT OFF; 
	END
GO
