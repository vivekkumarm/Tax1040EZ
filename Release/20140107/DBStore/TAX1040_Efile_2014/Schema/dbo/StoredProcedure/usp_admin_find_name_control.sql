/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_admin_find_name_control
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_admin_find_name_control]
@return_id BIGINT
AS
	BEGIN
		SET NOCOUNT ON; 
		DECLARE @xml XML,@handle INT,@test Nvarchar(MAX),@char INT,@BusinessInfoID BIGINT 
			SELECT 
				@BusinessInfoID = [business_info_id] 
			FROM 
				[dbo].[returns] WITH(NOLOCK)
			WHERE 
				[return_id] = @return_id

			SELECT 
				@xml = [efile_irs_schema]
			FROM 
				[dbo].[efile_irs_schema] ei WITH(NOLOCK)
				INNER JOIN [dbo].[efile_hold] eh WITH(NOLOCK) ON ei.[efile_hold_id] = eh.[efile_hold_id]
				INNER JOIN [dbo].[efile_last_status] el WITH(NOLOCK) ON eh.[efile_hold_id] = el.[efile_hold_id]
				INNER JOIN [dbo].[returns] r WITH(NOLOCK) ON r.ReturnID = eh.[return_id]
				INNER JOIN [dbo].[business_info] b WITH(NOLOCK) ON r.[business_info_id] = b.[business_info_id]
			WHERE 
				b.[business_info_id] = @BusinessInfoID 
				AND ei.[is_deleted] = 0 
				AND [stage] = 'APMV'
				AND el.[state] = 'Success'
				AND [status_id]! = 21
			--SELECT @xml.query('/Return/ReturnHeader/Filer') 
			SET 
				@test = CAST(@xml AS NVARCHAR(MAX))
			SELECT 
				@char = CHARINDEX('<ReturnHeader',@test,1)
			Select 
				@xml = CAST(REPLACE(@test,SUBSTRING(@test,9,@char-10),'') AS XML)
			SELECT 
				tab.col.value('NameControl[1]','VARCHAR(20)')AS NameControl
			FROM 
				@xml.nodes('//Filer') tab(col) 
		SET NOCOUNT OFF; 
	END
GO
