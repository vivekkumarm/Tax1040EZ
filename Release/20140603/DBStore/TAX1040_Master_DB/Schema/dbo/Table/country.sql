/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Country static table
**********************************************************************************************/

CREATE TABLE [dbo].[country]
(
	[country_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[country_code] [VARCHAR](3) NOT NULL,
	[country_name] [NVARCHAR](100) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GetDate(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GetDate(), 
    CONSTRAINT [pk_country] PRIMARY KEY ([country_id]),
)
