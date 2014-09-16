/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: sms_log
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[sms_log]
	(
		[sms_log_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[return_id] [BIGINT] NOT NULL,
		[return_value_id] [INT] NULL,
		[stc_sms_template_id] [INT] NULL,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	) 
GO
