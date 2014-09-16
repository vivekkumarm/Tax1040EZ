/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_rejected_efile
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_rejected_efile]
AS  
	SET NOCOUNT ON  
		BEGIN  
			SELECT 
				BI.[user_id],
				R.[return_id],
				R.[product_id], 
				STP.[tax_period]+'-'+STY.[tax_year] as Description, 
				EH.[efile_hold_id] as HoldID,   
				EIS.[submission_id], 
				BI.[business_name],'Rejection' as 'Rejection',   
				Eh.[efile_trans_id], 
				ELS.[stage]+'-'+ELS.[state] as 'EfileStatus' ,
				[tax_return_type_id] as 'Type'  
			FROM 
				[dbo].[business_info] BI  WITH(NOLOCK) 
				JOIN [dbo].[returns] R WITH(NOLOCK)  ON BI.[business_info_id] = R.[business_info_id]  
				LEFT OUTER JOIN [dbo].[stc_tax_year] STY WITH(NOLOCK)  ON R.[tax_year_id] = STY.[tax_year_id]  
				LEFT OUTER JOIN [dbo].[stc_tax_period] STP WITH(NOLOCK)  ON R.[tax_period_id] = STP.[tax_period_id]  
				JOIN [dbo].[efile_hold] EH WITH(NOLOCK)  ON EH.[return_id] = R.[return_id] AND EH.[is_deleted] = 0  
				JOIN [dbo].[efile_irs_schema] EIS WITH(NOLOCK)  ON EIS.[efile_hold_id] =EH.[efile_hold_id] AND EIS.[is_deleted]=0  
				JOIN [dbo].[efile_last_status] ELS WITH(NOLOCK)  ON Eh.[efile_hold_id] = ELS.[efile_hold_id]   
			WHERE 
				ELS.State = 'error' OR ELS.State='rejected' 
				AND BI.[is_deleted] = 0 
				AND R.[is_deleted] = 0   
				ORDER BY EH.[efile_hold_id] DESC   
				--SELECT EH.TaxReturnTypeID,EH.ReturnID,ES.EfileHoldID,eh.UserName,EH.EfileTransID,ES.SubmissionID,Stage+' - '+State as  'Status',EH.CreateTimeStamp as 'TransmittedDate'  
				--FROM EfileIRSSchema ES with(nolock)  
				--JOIN EfileLastStatus ELS with(nolock) ON ES.EfileHoldID = ELS.EfileHoldID  
				--Join EfileHold EH with(nolock) on EH.EfileHoldID=ES.EfileHoldID  
				--WHERE State = 'error' or State='rejected' AND ES.IsDeleted = 0 and EH.ISDeleted=0 order by Stage,State   
		END
	SET NOCOUNT ON
GO
