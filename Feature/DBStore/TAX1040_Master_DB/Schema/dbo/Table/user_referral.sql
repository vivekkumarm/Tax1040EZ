/**********************************************************************************************
Author          : Sathish - 
Created Date    : 19th July, 2014
Description     : Table which holds user referral email
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[user_referral]
(
	[user_referral_id] BIGINT IDENTITY(1,1),
	[user_id] BIGINT NOT NULL,
	[user_referral_email] VARCHAR(100) NOT NULL DEFAULT(0),
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [fk_user_referral_id] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user]([user_id]),
)
