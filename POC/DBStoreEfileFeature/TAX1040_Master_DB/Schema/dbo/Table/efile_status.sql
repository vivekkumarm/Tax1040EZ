/**********************************************************************************************
Created by Sathish - 26Jun2014 -  efile status static table
**********************************************************************************************/

CREATE TABLE [dbo].[efile_status](
      [efile_status_id] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [status] [VARCHAR](20) NULL,
	  [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)