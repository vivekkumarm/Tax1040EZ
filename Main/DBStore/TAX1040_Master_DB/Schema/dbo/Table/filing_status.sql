/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Filing Status static table
**********************************************************************************************/ 
/*Modified Filing Status size increased to 60 to occupy more characters per DB Spec. */
CREATE TABLE [dbo].[filing_status]
(
	[filing_status_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[filing_status] [NVARCHAR](60) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GetDate(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GetDate(), 
    CONSTRAINT [pk_filing_status] PRIMARY KEY ([filing_status_id]),
)
