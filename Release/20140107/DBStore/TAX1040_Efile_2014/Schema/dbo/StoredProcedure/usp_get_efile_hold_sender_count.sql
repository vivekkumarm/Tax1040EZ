/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_efile_hold_sender_count
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_efile_hold_sender_count]
@sender_id INT
AS
	BEGIN
		SET NOCOUNT ON;
			BEGIN TRAN
				SELECT 
					COUNT([efile_hold_id]) as 'Count' 
				FROM 
					[dbo].[efile_hold] WITH(NOLOCK)
				WHERE 
					[sender_id] = @sender_id 
					AND CONVERT(VARCHAR(13),[create_time_stamp],107)=CONVERT(VARCHAR(13),GETDATE(),107)
			COMMIT TRAN
		SET NOCOUNT OFF;
	END
GO
