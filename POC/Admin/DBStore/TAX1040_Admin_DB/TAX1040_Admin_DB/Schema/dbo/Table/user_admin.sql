CREATE TABLE [dbo].[user_admin]
(
	[user_admin_Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [username] [NVARCHAR](100)  UNIQUE NOT NULL,     	
	[password] [NVARCHAR](100) NOT NULL,
	[email] [NVARCHAR](100) UNIQUE NOT NULL,
	[salt] [NVARCHAR](100) NOT NULL,		
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
)
