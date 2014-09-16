/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_error
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_error]
	(
		[efile_error_id] [INT] IDENTITY(1,1) NOT NULL,
		[submission_id] [VARCHAR](25) NULL,
		[error_code] [VARCHAR](50) NULL,
		[error_message] [VARCHAR](MAX) NULL,
		[error_classification] [VARCHAR](MAX) NULL DEFAULT NULL,
		[action] [VARCHAR](50) NULL,
		[error_picked_up] [TINYINT] NULL DEFAULT 0,
		[error_fixed] [TINYINT] NULL DEFAULT 0 ,
		[is_deleted] [BIT] NULL DEFAULT 0,
		[create_time_stamp] [DATETIME] NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_error] PRIMARY KEY ([efile_error_id])
	 )
 GO

