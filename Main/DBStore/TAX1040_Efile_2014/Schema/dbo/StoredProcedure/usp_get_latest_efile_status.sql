/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_get_latest_efile_status
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_get_latest_efile_status]
AS
	BEGIN
		SET NOCOUNT ON;
			SELECT 
				 eh.[return_id],
				 [user_name],
				 [user_email],
				 bi.[business_name],
				 bi.[ein],
				 bi.[phone],
				 els.[state],
				 MAX(eh.[create_time_stamp]) as whenTransmitted,
				 COUNT(eh.[return_id]) as NoofTransmittedTimes 
			 FROM 
				 [dbo].[efile_hold] eh WITH(NOLOCK)
				 LEFT OUTER JOIN [dbo].[business)info] bi ON eh.[user_id] = bi.[user_id] 
				 LEFT OUTER JOIN [dbo].[efile_last_status] els ON els.[efile_hold_id] = eh.[efile_hold_id]
			GROUP BY 
				eh.[return_id],
				[user_name],
				[user_email],
				bi.[business_name],
				bi.[ein],
				bi.[phone],
				els.[state],
				eh.[create_time_stamp]
			ORDER BY 
				eh.[create_time_stamp],
				eh.[return_id] DESC
		SET NOCOUNT OFF;
	END
GO
