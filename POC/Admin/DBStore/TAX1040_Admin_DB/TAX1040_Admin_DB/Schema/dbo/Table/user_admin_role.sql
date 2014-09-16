CREATE TABLE [dbo].[user_admin_role]
(
	[user_admin_role_id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[user_admin_id] [bigint] NOT NULL,
	[admin_role_id] [bigint] NOT NULL,
	[role_name] [varchar](50) NULL,
	[is_deleted] [bit] NOT NULL DEFAULT 0,
	[create_datetime] [datetime] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [datetime] NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_admin_role_admin_user] FOREIGN KEY ([user_admin_id]) REFERENCES [dbo].[user_admin]([user_admin_id]), 
    CONSTRAINT [FK_user_admin_role_admin_role] FOREIGN KEY ([admin_role_id]) REFERENCES [admin_role]([admin_role_id]) 
)
 