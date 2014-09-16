/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_comment_get
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_comment_get]
	@efile_hold_id BIGINT  
AS  
	BEGIN  
		SET NOCOUNT ON; 
			SELECT 
				[efile_comment_id],
				[efile_hold_id],
				[efile_comment],
				[efile_admin_user_name] AS AdminUsersName ,
				efile_admin_users.[create_time_stamp]  
			FROM 
				[dbo].[efile_comment]  WITH(NOLOCK)  
				JOIN [dbo].[efile_admin_users]  WITH(NOLOCK) ON efile_admin_users.[admin_users_id] = efile_comment.[admin_users_id]
			WHERE 
				[efile_hold_id] = @efile_hold_id  
			ORDER BY 
				efile_admin_users.[create_time_stamp] DESC
		SET NOCOUNT OFF;
	END 
GO
