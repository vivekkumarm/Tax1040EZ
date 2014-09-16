/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_receiver
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_receiver]
	(
		[efile_receiver_id] [INT] IDENTITY(1,1) NOT NULL,
		[submission_id] [VARCHAR](25) NOT NULL,
		[send_submission_status] [VARBINARY](MAX) NULL,
		[get_ack_status] [VARBINARY](MAX) NULL,
		[ack_xml] [XML] NULL DEFAULT NULL,
		[submission_status] [VARBINARY](MAX) NULL,
		[schedule1] [VARBINARY](MAX) NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[system_id] [VARCHAR](20) NULL,
		CONSTRAINT [pk_efile_receiver] PRIMARY KEY ([efile_receiver_id])
	 )
 GO
