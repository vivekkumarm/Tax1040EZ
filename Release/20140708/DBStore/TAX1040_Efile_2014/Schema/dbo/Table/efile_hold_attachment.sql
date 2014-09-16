/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_hold_attachment
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_hold_attachment]
	(
		[efile_hold_attachment_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_hold_id] [BIGINT] NOT NULL,
		[attachment_name] [VARCHAR](100) NULL,
		[type] [VARCHAR](50) NULL,
		[efile_attachment] [VARBINARY](MAX) NOT NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_attachment_hold] PRIMARY KEY ([efile_hold_attachment_id]),
		CONSTRAINT [fk_efile_attachment_hold_efile_hold] FOREIGN KEY([efile_hold_id])REFERENCES [dbo].[efile_hold] ([efile_hold_id])
	 )
 GO
