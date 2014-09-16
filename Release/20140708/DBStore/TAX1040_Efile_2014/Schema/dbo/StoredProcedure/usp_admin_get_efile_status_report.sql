/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_admin_get_efile_status_report
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_admin_get_efile_status_report]
@date [DATETIME]
AS
	--BEGIN
	--	SET NOCOUNT ON;
	--		CREATE TABLE 
	--			dbo.#efile_status ([Status] VARCHAR(20),[2290] BIGINT,[720] BIGINT,[8849] BIGINT)
	--		INSERT INTO 
	--			dbo.#efile_status
	--		SELECT  
	--			'Accepted' AS [Status],ISNULL([2290],0) AS [2290Received], ISNULL([720],0) AS [720Received], ISNULL([8849],0) AS [8849Received] 
	--			FROM
	--			(
	--				SELECT 
	--					COUNT(r.ReturnID) AS EfileAccepted ,
	--					0 AS EfileRejected,
	--					CASE WHEN r.ProductID IN(1) THEN '720' WHEN r.ProductID IN(5,6) THEN '2290' ELSE '8849' END Product
	--				FROM 
	--					efile_last_status els
	--					INNER JOIN efile_hold eh ON eh.efile_hold_id=els.efile_hold_id
	--					INNER JOIN [returns] r ON eh.returnid=r.returnid AND eh.is_deleted=0
	--				WHERE 
	--					stage = 'apmv' AND els.state = 'Success' AND els.status_id <>21
	--					AND CAST(CONVERT(VARCHAR(30),r.create_time_stamp,106) As DATETIME) = CAST(CONVERT(VARCHAR(30),@Date,106) AS DATETIME) 
	--				GROUP BY r.ProductID
	--			)s 
	--		PIVOT
	--		(
	--		SUM
	--			(EfileAccepted) 
	--			FOR
	--			Product IN([2290],[8849],[720])) p
	--			UNION ALL
	--		SELECT  
	--			'Rejected',ISNULL([2290],0) AS [2290], ISNULL([720],0) AS [720], ISNULL([8849],0) AS [8849] FROM
	--			(
	--				SELECT 
	--					0 EfileAccepted,COUNT(r.ReturnID) AS EfileRejected,CASE WHEN r.ProductID IN(1) THEN '720' WHEN r.ProductID IN(5,6) THEN '2290' ELSE '8849' END Product
	--				FROM 
	--					efile_last_status els
	--					INNER JOIN efile_hold eh ON eh.efile_hold_id=els.efile_hold_id
	--					INNER JOIN [returns] r ON eh.returnid=r.returnid AND eh.is_deleted=0
	--				WHERE 
	--					stage = 'apmv' AND els.state = 'Success' AND els.status_id =21 
	--					AND CAST(CONVERT(VARCHAR(30),r.create_time_stamp,106) AS DATETIME) = CAST(CONVERT(VARCHAR(30),@date,106) As DATETIME) 
	--				GROUP BY r.ProductID
	--			)s 
	--		PIVOT
	--		(
	--		SUM
	--			(efile_rejected) 
	--			FOR
	--			Product IN([2290],[8849],[720])) p
	--		SELECT
	--			 [Status],ISNULL([2290],0) AS 'Tax2290',ISNULL([720],0) 'Tax720',ISNULL([8849],0) 'Tax8849' 
	--		 FROM 
	--			dbo.#efile_status
	--			UNION ALL
	--		SELECT 
	--			'Total',ISNULL(SUM([2290]),0),ISNULL(SUM([720]),0),ISNULL(SUM([8849]),0) 
	--		FROM 
	--			dbo.#efile_status
	--		DROP TABLE 
	--			dbo.#efile_status
	--	SET NOCOUNT OFF;
	--END
GO

