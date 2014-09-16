/**********************************************************************************************
Author          : Sathish - 
Created Date    : 18th July, 2014
Description     : Table which holds user rating information
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[user_rating]
(
	[user_rating_id] BIGINT IDENTITY(1,1),
	[user_id] BIGINT NOT NULL,
	[rating] INT NOT NULL DEFAULT(0),
	[comment] VARCHAR(300) NULL,
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [fk_user_rating_id] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user]([user_id]),
)
