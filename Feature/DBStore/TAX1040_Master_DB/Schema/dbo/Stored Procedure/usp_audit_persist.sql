/*******************************************************************************
Created By  : Bhavani Rajesh
Created Date: 27 Aug 2014
Description : Persists the audit table.
********************************************************************************/

CREATE PROCEDURE [dbo].[usp_audit_persist]
@user_id		BIGINT,
@user_data_id	BIGINT,
@ip_address		NVARCHAR(100),
@tab_name		NVARCHAR(50),
@topic_name	    NVARCHAR(50),
@description	NVARCHAR(1000)
AS

BEGIN
	SET NOCOUNT ON;
		 INSERT INTO [dbo].[audit]
		  (
				[user_id],
				[user_data_id],
				[ip_address],
				[tab_name],
				[topic_name],
				[description]	        
		  )
		  VALUES
		  (
				@user_id,
				@user_data_id,
				@ip_address,
				@tab_name,
				@topic_name,
				@description	
		   )   

	SET NOCOUNT OFF;
END
