/**********************************************************************************************
Created by Vivek - 7th March, 2014 -  State static table
**********************************************************************************************/
/* Modification History */
/* Sathish - 08May2014 added new column is_additional_mailing_address to get additional state for US.  */
CREATE TABLE [dbo].[state]
(
	[state_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[state_code] [VARCHAR](3) NOT NULL,
	[state_name] [NVARCHAR](50) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GetDate(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GetDate(), 
    [is_additional_mailing_address] BIT NULL DEFAULT 0, 
    CONSTRAINT [pk_state] PRIMARY KEY ([state_id]),
)
