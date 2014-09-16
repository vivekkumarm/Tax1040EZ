/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_irs_scheme
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_irs_schema]
	(
		[efile_irs_schema_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_return_data_id] [BIGINT] NOT NULL,
		[efile_irs_schema] [XML] NOT NULL,
		[manifest_xml] [XML] NULL DEFAULT NULL,
		[submission_id] [VARCHAR](20) NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_irs_schema] PRIMARY KEY ([efile_irs_schema_id]),
		CONSTRAINT [fk_efile_irs_schema_efile_return_data] FOREIGN KEY([efile_return_data_id])REFERENCES [dbo].[efile_return_data] ([efile_return_data_id])
	 )
 GO

