/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_sender
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_sender]
	(
		[efile_sender_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_return_data_id] [BIGINT] NOT NULL,
		[dime_attachment] [VARBINARY](MAX) NOT NULL,
		[submission_id] [VARCHAR](20) NOT NULL,
		[message_id] [VARCHAR](20) NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[irs_system_id] [VARCHAR](20) NULL,
		CONSTRAINT [pk_efile_sender] PRIMARY KEY ([efile_sender_id]),
		CONSTRAINT [fk_efile_sender_efile_return_data] FOREIGN KEY([efile_return_data_id]) REFERENCES [dbo].[efile_return_data] ([efile_return_data_id])
 
	 )
 GO

