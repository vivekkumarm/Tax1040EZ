/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_log
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_log]
	(
		[efile_log_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_hold_id] [BIGINT] NOT NULL,
		[messages] [VARCHAR](MAX) NOT NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_log] PRIMARY KEY ([efile_log_id]),
		CONSTRAINT [fk_efile_log_efile_hold] FOREIGN KEY([efile_hold_id])REFERENCES [dbo].[efile_hold] ([efile_hold_id])
	 )
 GO
