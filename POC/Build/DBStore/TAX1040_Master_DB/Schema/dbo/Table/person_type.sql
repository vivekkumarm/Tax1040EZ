/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Person Type static table
**********************************************************************************************/
CREATE TABLE [dbo].[person_type]
(
	[person_type_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[person_type] [NVARCHAR](30) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GetDate(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GetDate(), 
    CONSTRAINT [pk_person_type] PRIMARY KEY ([person_type_id]),
)
