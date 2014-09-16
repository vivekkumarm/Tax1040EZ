/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_name_control_persist
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_name_control_persist]
	@submission_id VARCHAR(20)
AS
	BEGIN
		SET NOCOUNT ON; 
			IF EXISTS 
				(
					SELECT 1 FROM [dbo].[efile_name_control] WITH(NOLOCK)
					WHERE [business_info_id] IN 
					(
						SELECT 
							business_info.business_info_id
						FROM 
							[dbo].[business_info] WITH(NOLOCK)
							JOIN [dbo].[returns] WITH(NOLOCK) ON [returns].[business_info_id] = [business_info].[business_info_id] 
							JOIN [dbo].[efile_hold] WITH(NOLOCK) ON [efile_hold].[return_id] = [returns].[return_id]
							JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON [efile_irs_schema].[efile_hold_id] =[efile_hold].[efile_hold_id] 
						WHERE 
							[efile_irs_schema].[submission_id] = @submission_id 
					)
				)
				BEGIN
					UPDATE 
						[dbo].[efile_name_control]
					SET 
						[name_control]=(
						SELECT SUBSTRING
						(
							CONVERT(VARCHAR(MAX),[efile_irs_schema]),
							CHARINDEX('<namecontrol>',CONVERT(VARCHAR(MAX),[efile_irs_schema]))+13,
							CHARINDEX('</namecontrol>',CONVERT(VARCHAR(MAX),[efile_irs_schema]))-13-CHARINDEX('<namecontrol>',CONVERT(VARCHAR(MAX),[efile_irs_schema]))
						)
					FROM [dbo].[efile_receiver] WITH(NOLOCK)
						INNER JOIN [dbo].[efile_irs_schema] WITH(NOLOCK) ON efile_receiver.[submission_id] = efile_irs_schema.[submission_id]
						INNER JOIN [dbo].[efile_hold] WITH(NOLOCK) ON efile_irs_schema.[efile_hold_id] = efile_hold.[efile_hold_id]
						INNER JOIN [dbo].[returns] WITH(NOLOCK) ON efile_hold.[return_id] = returns.[return_id]
						INNER JOIN [dbo].[business_info] WITH(NOLOCK) ON returns.[business_info_id] = [business_info.business_info_id]
						INNER JOIN [dbo].[users] WITH(NOLOCK) ON users.[user_id] = business_info.[user_id]
					WHERE 
						efile_receiver.[submission_id] = @submission_id) 
						WHERE 
							[business_info_id] = (
							SELECT 
								[business_info].[business_info_id] 
							FROM 
								[dbo].[business_info] WITH(NOLOCK)
							JOIN 
							[dbo].[returns] ON [returns].[business_info_id] = [business_info].[business_info_id] 
							JOIN 
							[dbo].[efile_hold] ON [efile_hold].[return_id] = [returns].[return_id]
							JOIN 
							[dbo].[efile_irs_schema] ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id] AND [efile_irs_schema].[submission_id]  = @submission_id)
				END
			ELSE
				BEGIN
					INSERT INTO 
						[dbo].[efile_name_control]
						(
							[user_id],
							[business_info_id],
							[business_info_name],
							[return_id],
							[name_control]
						)
					SELECT 
						[users].[user_id],
						[returns].[business_info_id],
						[business_info].business_name ,  
						[returns].return_id,
						SUBSTRING(CONVERT(VARCHAR(MAX),[efile_irs_schema]),CHARINDEX('<namecontrol>',CONVERT(VARCHAR(MAX),[efile_irs_schema]))+13,
						CHARINDEX('</namecontrol>',CONVERT(VARCHAR(MAX),[efile_irs_schema]))-13-CHARINDEX('<namecontrol>',CONVERT(VARCHAR(MAX),[efile_irs_schema])))
						--EfileIRSSchema.value('(/Return/ReturnHeader/Filer/NameControl)[1]','varchar(50)') 
					FROM [dbo].[efile_receiver] WITH(NOLOCK)
						INNER JOIN [dbo].[efile_irs_schema] ON [efile_receiver].[submission_id] = [efile_irs_schema].[submission_id]
						INNER JOIN [dbo].[efile_hold] ON [efile_irs_schema].[efile_hold_id] = [efile_hold].[efile_hold_id]
						INNER JOIN [dbo].[returns] ON [efile_hold].[return_id] = [returns].[return_id]
						INNER JOIN [dbo].[business_info] ON returns.[business_info_id] = [business_info.business_info_id]
						INNER JOIN [dbo].[users] ON [users].[user_id] = [business_info].[user_id]
					WHERE 
						[efile_receiver].[submission_id]  = @submission_id
				END
		SET NOCOUNT OFF; 
	END
GO