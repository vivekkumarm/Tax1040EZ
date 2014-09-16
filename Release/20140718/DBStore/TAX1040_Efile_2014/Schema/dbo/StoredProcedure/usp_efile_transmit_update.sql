/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_transmit_update
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_transmit_update]
(
	@efile_transmit_id BIGINT,
	@state VARCHAR(10)
)
AS
	BEGIN
		SET NOCOUNT ON;
			UPDATE 
				[dbo].[efile_transmit]  SET [state] = @state 
			WHERE 
				[efile_transmit_id] = @efile_transmit_id
		SET NOCOUNT OFF; 
	END
GO
