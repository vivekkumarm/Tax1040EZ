/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_admin_efile_count
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_admin_efile_count]
@from_date DATETIME,
@to_date DATETIME,
@product_id BIGINT=0
AS
	BEGIN
		SET NOCOUNT ON; 
		  IF @product_id = 0
				SELECT 
					COUNT(r.[return_id]) AS EfileCount,
					r.[product_id]
				FROM 
					[dbo].[efile_last_status] els WITH(NOLOCK)
					INNER JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON eh.[efile_hold_id] = els.[efile_hold_id] 
					INNER JOIN [dbo].[returns] r WITH(NOLOCK) ON eh.[return_id] = r.[return_id] AND eh.[is_deleted] = 0
				WHERE 
					[stage] = 'apmv' 
					AND els.[state] = 'Success' 
					AND els.[status_id] <>21
					AND CAST(CONVERT(VARCHAR(30),r.[create_time_stamp],106) AS DATETIME) 
					BETWEEN CAST(CONVERT(VARCHAR(30),@from_date,106) AS DATETIME) 
					AND CAST(CONVERT(VARCHAR(30),@to_date,106) AS DATETIME)
					GROUP BY r.ProductID
		  ELSE
				SELECT 
					COUNT(r.ReturnID) AS EfileCount,
					r.ProductID
				FROM 
					[dbo].[efile_last_status] els WITH(NOLOCK)
					INNER JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON eh.[efile_hold_id] = els.[efile_hold_id] 
					INNER JOIN [dbo].[returns] r WITH(NOLOCK) ON eh.[return_id] = r.[return_id] AND eh.[is_deleted] = 0
				WHERE 
					[stage] = 'apmv' 
					AND els.[state] = 'Success' 
					AND els.[status_id] <>21
					AND CAST(CONVERT(VARCHAR(30),r.[create_time_stamp],106) AS DATETIME) 
					BETWEEN CAST(CONVERT(VARCHAR(30),@from_date,106) AS DATETIME) 
					AND CAST(CONVERT(VARCHAR(30),@to_date,106) AS DATETIME)
					AND [product_id] = @product_id
					GROUP BY r.[product_id]
		SET NOCOUNT OFF; 
	END
GO

