/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_comment
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_comment]
	(
		[efile_comment_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[efile_hold_id] [BIGINT] NULL,
		[efile_comment] [TEXT] NULL,
		[admin_users_id] [BIGINT] NULL,
		[create_time_stamp] [DATETIME] NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_comment] PRIMARY KEY ([efile_comment_id]),
		CONSTRAINT [pk_efile_comment_efile_hold] FOREIGN KEY([efile_hold_id]) REFERENCES [dbo].[efile_hold] ([efile_hold_id])

	 )
 GO 

