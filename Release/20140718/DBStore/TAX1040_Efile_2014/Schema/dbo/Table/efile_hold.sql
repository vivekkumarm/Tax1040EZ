/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_hold
	CREATED ON: 8th May 2014
*******************************************************************************************************/


CREATE TABLE [dbo].[efile_hold]
	(
		[efile_hold_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[sender_id] [INT] NOT NULL,
		[return_id] [BIGINT] NULL,
		[user_id] [INT] NULL,
		[tax_return_type_id] [VARCHAR](20) NULL,
		[user_name] [VARCHAR](50) NULL,
		[user_email] [VARCHAR](50) NULL,
		[no_of_attachments] [INT] NULL,
		[tax_object] [XML] NOT NULL,
		[env_indicator] [CHAR](1) NOT NULL,
		[efile_trans_id] [VARCHAR](30) NULL,
		[tax_year] [VARCHAR](10) NULL,
		[tax_period] [VARCHAR](30) NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[irs_system_id] [VARCHAR](20) NULL,
		CONSTRAINT [pk_efile_hold] PRIMARY KEY ([efile_hold_id])
	)
GO
