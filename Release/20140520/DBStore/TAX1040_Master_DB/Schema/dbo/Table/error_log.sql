/**********************************************************************************************
Created by Swapnesh - 6th May, 2014 -  Error Log Table
**********************************************************************************************/

CREATE TABLE [dbo].[error_log]
(
	[error_log_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[user_id] [BIGINT] NULL,
	[exception_occured_instance] [NVARCHAR](200) NULL,
	[exception_message] [NVARCHAR](MAX) NULL,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GetDate() ,
	CONSTRAINT [pk_error_log] PRIMARY KEY ([error_log_id]),
)