
/**********************************************************************************************
Created by Sathish N - 16Apr2014 Condition to be validated against zip code
**********************************************************************************************/
CREATE TABLE [dbo].[state_zip_code_conditions]
(
	[zip_code_condition_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[state_id] [BIGINT] UNIQUE NOT NULL,
	[condition] [VARCHAR](500) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GetDate(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GetDate(), 
	CONSTRAINT [fk_state_id] FOREIGN KEY ([state_id]) REFERENCES [dbo].[state]([state_id]), 
)
