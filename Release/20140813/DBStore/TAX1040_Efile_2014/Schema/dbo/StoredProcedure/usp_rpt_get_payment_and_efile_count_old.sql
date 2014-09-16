/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_rpt_get_payment_and_efile_count_old
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_rpt_get_payment_and_efile_count_old]
AS
	--BEGIN
	--	SET NOCOUNT ON;
	--		SELECT 
	--			r.return_id, 
	--			Year(r.create_time_stamp) AS Year,  
	--			Month(r.create_time_stamp) AS Month , 
	--			CASE
	--				WHEN els.status_id=25 
	--				THEN 1 
	--				ELSE 0 
	--				END AS status 
	--				INTO #TempPay
	--		FROM 
	--			tax2290_Master.dbo.returns r 
	--		LEFT OUTER JOIN efile_hold eh ON eh.return_id=r.return_id AND eh.is_deleted=0 
	--		LEFT OUTER JOIN efile_last_status els ON els.efile_hold_id=eh.efile_hold_id AND els.status_id=25 
	--		WHERE 
	--			r.create_time_stamp <='1-06-2008' AND r.product_id=1 AND r.is_deleted=0
	--		SELECT 
	--			year,
	--			Month, 
	--			sum(Status) AS COUNT FROM #TempPay
	--			GROUP BY
	--				Year, 
	--				Month
	--			ORDER BY 
	--				Year,
	--				Month
	--	SET NOCOUNT OFF;
	--END
GO
