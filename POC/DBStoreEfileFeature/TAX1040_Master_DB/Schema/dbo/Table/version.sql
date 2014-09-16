
/**********************************************************************************************
Created by Sathish - 26Jun2014 -  efile version static table
**********************************************************************************************/

CREATE TABLE [dbo].[version](
      [version_id] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [name] [VARCHAR](50) NULL,
      [pdf_name] [VARCHAR](50) NULL,
      [is_paper_enabled] [BIT] NOT NULL,
      [product_id] [INT] NULL,
      [is_efile_enabled] [BIT] NOT NULL,
      [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)