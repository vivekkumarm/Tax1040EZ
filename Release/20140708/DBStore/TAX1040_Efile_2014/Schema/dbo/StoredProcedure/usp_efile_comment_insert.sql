/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_comment_insert
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_comment_insert]
	@efile_hold_id BIGINT,
	@efile_comment TEXT,
	@admin_users_id BIGINT
AS
	BEGIN
		SET NOCOUNT ON;
			INSERT INTO [dbo].[efile_comment]  
			(
				[efile_hold_id], 
				[efile_comment], 
				[admin_users_id], 
				[create_time_stamp]
			)
			VALUES
			(
				@efile_hold_id,
				@efile_comment, 
				@admin_users_id, 
				GETDATE()
			)
		SET NOCOUNT OFF;
	END
GO
