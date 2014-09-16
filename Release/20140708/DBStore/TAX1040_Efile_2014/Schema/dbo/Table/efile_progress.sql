/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_progress
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_progress]
	(
		[efile_progress_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_hold_id] [BIGINT] NOT NULL,
		[progress_status] [TINYINT] NOT NULL,
		[stage] [VARCHAR](10) NOT NULL,
		[state] [VARCHAR](50) NULL,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_progress] PRIMARY KEY ([efile_progress_id]),
		CONSTRAINT [fk_efile_progress_efile_hold] FOREIGN KEY([efile_hold_id]) REFERENCES [dbo].[efile_hold] ([efile_hold_id])

	 )
 GO
