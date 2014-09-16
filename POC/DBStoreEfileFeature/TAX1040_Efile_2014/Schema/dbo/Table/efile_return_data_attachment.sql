/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_return_data_attachment
	CREATED ON: 8th May 2014
*******************************************************************************************************/
CREATE TABLE [dbo].[efile_return_data_attachment]
	(
		[efile_return_data_attachment_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_return_data_id] [BIGINT] NOT NULL,
		[attachment_name] [VARCHAR](100) NULL,
		[type] [VARCHAR](50) NULL,
		[efile_attachment] [VARBINARY](MAX) NOT NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_attachment_hold] PRIMARY KEY ([efile_return_data_attachment_id]),
		CONSTRAINT [fk_efile_attachment_hold_efile_return_data] FOREIGN KEY([efile_return_data_id]) REFERENCES [dbo].[efile_return_data] ([efile_return_data_id])
	 )
 GO
