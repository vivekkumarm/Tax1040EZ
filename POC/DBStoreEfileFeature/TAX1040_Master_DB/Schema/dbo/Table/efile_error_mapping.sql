/**********************************************************************************************
Created by Sathish - 26Jun2014 -  efile error mapping static table
**********************************************************************************************/

CREATE TABLE [dbo].[efile_error_mapping](
      [efile_error_mapping_id] [BIGINT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [error_code] [VARCHAR](30) NULL,
      [efile_error] [TEXT] NULL,
      [user_error] [TEXT] NULL,
      [help_id] [NCHAR](10) NULL,
      [form_type] [varchar](20) NULL,
	  [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
	)