/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_last_status
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_current_status]
	(
		[efile_current_status_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_return_data_id] [BIGINT] NOT NULL,
		[stage_id] [INT] NOT NULL,
		[state] [VARCHAR](20) NOT NULL,
		[is_deleted] [BIT] NOT NULL DEFAULT 0,
		[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_current_status] PRIMARY KEY ([efile_current_status_id]),
		CONSTRAINT [fk_efile_current_status_efile_return_data] FOREIGN KEY([efile_return_data_id])REFERENCES [dbo].[efile_return_data] ([efile_return_data_id]),
        CONSTRAINT [fk_efile_current_status_efile_stage] FOREIGN KEY([stage_id])REFERENCES [dbo].[efile_stage] ([efile_stage_Id]),
	 )
 GO

