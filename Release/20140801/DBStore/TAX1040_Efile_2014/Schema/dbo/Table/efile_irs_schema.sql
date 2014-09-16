/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_irs_scheme
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_irs_schema]
	(
		[efile_irs_schema_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_hold_id] [BIGINT] NOT NULL,
		[efile_irs_schema] [XML] NOT NULL,
		[manifest_xml] [XML] NULL DEFAULT NULL,
		[submission_id] [VARCHAR](20) NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_irs_schema] PRIMARY KEY ([efile_irs_schema_id]),
		CONSTRAINT [fk_efile_irs_schema_efile_hold] FOREIGN KEY([efile_hold_id])REFERENCES [dbo].[efile_hold] ([efile_hold_id])
	 )
 GO

