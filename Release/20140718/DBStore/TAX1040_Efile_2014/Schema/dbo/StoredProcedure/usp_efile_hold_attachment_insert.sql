/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_hold_attachment_insert
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_hold_attachment_insert]
	@efile_hold_id INT,
	@efile_attachment VARBINARY(MAX),
	@type VARCHAR(50) = NULL,
	@attachment_name VARCHAR(50) = NULL
AS
	BEGIN
		SET NOCOUNT ON;
			INSERT INTO [dbo].[efile_hold_attachment]
			(
				[efile_hold_id], 
				[type], 
				[efile_attachment],
				[attachment_name],
				[is_deleted] ,
				[create_time_stamp],
				[update_time_stamp]
			)
			VALUES 
			(
				@efile_hold_id,
				@type, 
				@efile_attachment,
				@attachment_name,
				0,
				GETDATE(),
				GETDATE()
			) 
		SET NOCOUNT OFF;
	END
GO	
