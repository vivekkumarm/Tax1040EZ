/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_name_control
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_name_control]
	(
		[efile_name_control_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[user_id] [BIGINT] NULL,
		[business_info_id] [BIGINT] NULL,
		[business_info_name] [VARCHAR](100) NULL,
		[return_id] [BIGINT] NULL,
		[name_control] [VARCHAR](100) NULL
	) 
GO
