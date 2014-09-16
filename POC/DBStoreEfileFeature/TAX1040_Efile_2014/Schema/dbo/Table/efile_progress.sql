/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_progress
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_progress]
	(
		[efile_progress_id] [INT] IDENTITY(1,1) NOT NULL,
		[efile_return_data_id] [BIGINT] NOT NULL,
		[stage_id] [INT] NOT NULL,
		[state] [VARCHAR](20) NOT NULL,
		[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_progress] PRIMARY KEY ([efile_progress_id]),
		CONSTRAINT [fk_efile_progress_efile_return_data] FOREIGN KEY([efile_return_data_id]) REFERENCES [dbo].[efile_return_data] ([efile_return_data_id])

	 )
 GO
