/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_last_status
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_last_status]
	(
		[efile_last_status_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_hold_id] [BIGINT] NOT NULL,
		[status_id] [INT] NOT NULL,
		[stage] [VARCHAR](10) NOT NULL,
		[state] [VARCHAR](50) NOT NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_last_status] PRIMARY KEY ([efile_last_status_id]),
		CONSTRAINT [fk_efile_last_status_efile_hold] FOREIGN KEY([efile_hold_id])REFERENCES [dbo].[efile_hold] ([efile_hold_id])
	 )
 GO

