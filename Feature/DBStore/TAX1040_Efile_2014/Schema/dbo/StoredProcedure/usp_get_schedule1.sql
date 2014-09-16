/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_schedule1
	CREATED ON: 12th May 2014
*******************************************************************************************************/


CREATE PROCEDURE [dbo].[usp_get_schedule1]
@efile_trans_id VARCHAR(30)
AS
	BEGIN
		SET NOCOUNT ON
			Select 
				[schedule1] 
			from 
				[dbo].[efile_hold] WITH(NOLOCK) 
				join  [dbo].[efile_irs_schema] WITH(NOLOCK) on [efile_hold].[efile_hold_id] = [efile_irs_schema].[create_time_stamp]
				join [dbo].[efile_receiver] WITH(NOLOCK) on [efile_receiver].[submission_id] = [efile_irs_schema].[submission_id]
			where 
				[efile_irs_schema].[is_deleted] = 0 
				and [efile_receiver].[is_deleted] = 0 
				and [efile_trans_id] = @efile_trans_id 
				and [efile_hold].[is_deleted] = 0
		SET NOCOUNT OFF;
	end
GO
