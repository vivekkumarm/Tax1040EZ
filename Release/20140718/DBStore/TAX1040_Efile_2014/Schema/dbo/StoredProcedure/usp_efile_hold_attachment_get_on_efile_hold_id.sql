/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_hold_attachment_get_on_efile_hold_id
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_hold_attachment_get_on_efile_hold_id]
	@efile_hold_id BIGINT
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				[efile_hold_id], 
				[type], 
				[efile_attachment],
				[attachment_name],
				[efile_hold_attachment_id]
			FROM 
				[dbo].[efile_hold_attachment] WITH(NOLOCK) 
			WHERE 
				[efile_hold_id] = @efile_hold_id AND [is_deleted] = 0
		SET NOCOUNT OFF;
	END
GO
