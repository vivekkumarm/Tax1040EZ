/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_email_log
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_email_log]
	(
		[efile_email_log_id] [INT] IDENTITY(1,1) NOT NULL,
		[submission_id] [VARCHAR](25) NOT NULL,
		[efile_error_id] [INT] NOT NULL,
		[efile_email_template_id] [INT] NOT NULL,
		[email_to] [VARCHAR](50) NOT NULL,
		[email_from] [VARCHAR](50) NOT NULL,
		[email_message] [TEXT] NOT NULL,
		[email_subject] [VARCHAR](50) NOT NULL,
		[email_status] [BIT] NULL,
		CONSTRAINT [pk_efile_email_log] PRIMARY KEY ([efile_email_log_id]), 
		CONSTRAINT [FK_efile_email_log_efile_error] FOREIGN KEY ([efile_error_id]) REFERENCES [dbo].[efile_error] ([efile_error_id])
	 )
 GO
