/**********************************************************************************************
Created by Sathish - 26Jun2014 -  efile tax year static table
**********************************************************************************************/

CREATE TABLE [dbo].[tax_year](
      [tax_year_id] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [tax_year] [VARCHAR](50) NOT NULL,
      [year] [VARCHAR](50) NULL,
      [product_id] [BIGINT] NULL,
      [version_id] [INT] NULL,
      [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)