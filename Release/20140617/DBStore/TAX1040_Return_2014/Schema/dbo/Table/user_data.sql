/**********************************************************************************************
Author          : Ashok Kumar - 
Created Date    : 17th March, 2014
Description     : Table which holds user data information
**********************************************************************************************/
/* Modification History */
/* Bala - 03 April 2014  changed User id as unique id*/
CREATE TABLE [dbo].[user_data](
    [user_data_id] BIGINT NOT NULL IDENTITY,
	[user_id] [bigint] UNIQUE NOT NULL,
	[session_data] TEXT NULL,
	[tax_data] TEXT NOT NULL,
	[history_data] TEXT NULL,
	[session_terminate] [bit] NULL,
	[create_datetime] [datetime] NOT NULL,
	[upate_datetime] [datetime] NOT NULL,
	[is_deleted] [bit] NOT NULL,      
    CONSTRAINT [PK_user_data] PRIMARY KEY ([user_data_id]), 
    
) ON [PRIMARY]	

GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_create_datetime]  DEFAULT (getdate()) FOR [create_datetime]
GO

ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_upate_datetime]  DEFAULT (getdate()) FOR [upate_datetime]
GO

ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
