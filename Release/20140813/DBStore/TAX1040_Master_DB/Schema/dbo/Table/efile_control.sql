CREATE TABLE [dbo].[efile_control]
(
	[efile_control_id] [BIGINT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[form_type] [VARCHAR](30) NOT NULL,
	[control_name][VARCHAR](100) NOT NULL,
	[control_value][VARCHAR](200) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)
