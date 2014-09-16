CREATE TABLE [dbo].[admin_role]
(
	[admin_role_Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [role_name] NVARCHAR(50) NULL, 
    [is_active] BIT NOT NULL DEFAULT 1, 
    [is_deleted] BIT NOT NULL DEFAULT 0, 
    [create_datetime] DATETIME NOT NULL DEFAULT GETDATE(), 
    [update_datetime] DATETIME NOT NULL DEFAULT GETDATE()
)
