/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_rpt_payment_and_efile_count
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_rpt_payment_and_efile_count]
AS  
	BEGIN  
		SET NOCOUNT ON;  
			SELECT  
					r.[return_id], 
					Year(r.[create_time_stamp]) AS Year,  
					Month(r.[create_time_stamp]) AS Month ,
					CASE 
					WHEN els.[stage] IS NOT NULL THEN 1 ELSE 0 END AS [status] 
					INTO #TempPay
				FROM 
					[dbo].[returns] r WITH(NOLOCK)  
					LEFT OUTER JOIN [dbo].[efile_hold] eh WITH(NOLOCK) on eh.[returnid] = r.[return_id] AND eh.[is_deleted] = 0 
					LEFT OUTER JOIN [dbo].[efile_last_status] els WITH(NOLOCK) on els.[efile_hold_id] = eh.[efile_hold_id] AND els.[stage] = 'APMV' AND els.[state] = 'Success' 
				WHERE  
					r.[create_time_stamp]  >= '1-06-2008' 
					AND r.[product_id] = 5 
					AND r.[is_deleted] = 0
					SELECT 
							Year,
							Month, 
							SUM([status]) AS COUNT FROM #TempPay
						GROUP BY 
							Year, 
							Month
						ORDER BY 
							Year,
							MOnth
		SET NOCOUNT OFF;
	END
GO
