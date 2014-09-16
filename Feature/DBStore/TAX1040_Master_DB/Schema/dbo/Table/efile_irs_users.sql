CREATE TABLE [dbo].[efile_irs_users](
      [efile_irs_users_id] [SMALLINT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
      [form_type] [VARCHAR](30) NOT NULL,
      [user_name] [VARCHAR](100) NOT NULL,
      [password] [VARCHAR](100) NOT NULL,
      [encrypt_key] [VARCHAR](200) NOT NULL,
      [decrypt_key] [VARCHAR](200) NULL,
	  [is_active] [BIT] NOT NULL DEFAULT(1),
	  [is_deleted] [BIT] NOT NULL DEFAULT(0),
	  [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	  [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)