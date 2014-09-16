/**********************************************************************************************
Created by Sathish - 26Jun2014 -  efile irs system static table
**********************************************************************************************/

CREATE TABLE [dbo].[irs_systems](
      [irs_systems_ID] [BIGINT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [system_id] [VARCHAR](20) NULL,
      [password] [VARCHAR](100) NULL,
      [salt] [VARCHAR](100) NULL,
	  [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  
)
