/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_admin_efile_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_admin_efile_status]
AS
	BEGIN
		--SELECT eh.returnid,els.efileholdid,stage,els.state,els.createtimestamp,eh.username,b.businessname,es.EfileIRSSchema
	 --   FROM efilelaststatus els
		--INNER JOIN efilehold eh ON eh.efileholdid=els.efileholdid
		--INNER JOIN [returns] r ON eh.returnid=r.returnid AND eh.isdeleted=0
	 --   INNER JOIN businessinfo b ON r.businessinfoid=b.businessinfoid
	 --   INNER JOIN EfileIRSSchema es ON eh.efileholdid=es.EfileHoldID
		--WHERE stage != 'apmv' and els.state != 'reconciled' AND es.IsDeleted=0
	 --   ORDER BY els.efileholdid
		SET NOCOUNT ON; 
			SELECT 
				eh.[return_id],
				els.[efile_hold_id],
				[stage],
				els.[state],
				els.[create_time_stamp],
				eh.[user_name],
				b.[business_name],
				CONVERT(VARCHAR(MAX),es.[efile_irs_schema]) [efile_irs_schema],
				COUNT(eq.[submission_id]) AS EfileReqRes
			FROM 
				[dbo].[efile_last_status] els WITH(NOLOCK)
				INNER JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON eh.[efile_hold_id] = els.[efile_hold_id]
				INNER JOIN [dbo].[returns] r WITH(NOLOCK) ON eh.[return_id] = r.[return_id] AND eh.[is_deleted] = 0
				INNER JOIN [dbo].[business_info] b WITH(NOLOCK) ON r.[business_info_id] = b.[business_info_id]
				INNER JOIN [dbo].[efile_irs_schema] es WITH(NOLOCK) ON eh.[efile_hold_id] = es.[efile_hold_id]
				LEFT JOIN [dbo].[efile_request_response] eq WITH(NOLOCK) ON es.[submission_id] = eq.[submission_id]
			WHERE 
				[stage] != 'apmv' 
				AND els.[state] != 'reconciled' 
				AND es.[is_deleted] = 0
			GROUP BY 
			eh.[return_id],
				els.[efile_hold_id],
				[stage],
				els.[state],
				els.[create_time_stamp],
				eh.[user_name],
				b.[business_name],
				CONVERT(VARCHAR(MAX),es.[efile_irs_schema]),eq.[submission_id]
				ORDER BY els.[efile_hold_id]
		SET NOCOUNT ON; 
	END
GO
