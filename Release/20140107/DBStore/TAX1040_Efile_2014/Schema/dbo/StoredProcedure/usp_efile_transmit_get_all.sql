/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_transmit_get_all
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_transmit_get_all]
AS 
	BEGIN
		SELECT 
			[efile_transmit_id],
			[return_id],
			[return_type],
			[stage],
			[state],
			[user_id],
			[ip_date_time],
			[ip_time_zone],
			[ip_address],
			[is_deleted]
		FROM  
			[dbo].[efile_transmit] WITH(NOLOCK)
		WHERE
			[stage] ='TRAN' AND [state] = 'Blank' AND [is_deleted] = 0
	END
GO
