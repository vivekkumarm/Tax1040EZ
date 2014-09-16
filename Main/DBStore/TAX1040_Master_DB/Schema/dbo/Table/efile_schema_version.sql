CREATE TABLE [dbo].[efile_schema_version](
      [efile_schema_version_id] [BIGINT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [return_type] [VARCHAR](50) NULL,
      [tax_year] [VARCHAR](10) NULL,
      [tax_period] [VARCHAR](50) NULL,
      [schema_version] [VARCHAR](50) NULL,
      [schema_location] [VARCHAR](100) NULL,
	  [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)