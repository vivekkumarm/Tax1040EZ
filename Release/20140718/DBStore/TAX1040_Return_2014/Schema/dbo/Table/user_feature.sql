CREATE TABLE [dbo].[user_feature]
(
	[user_feature_id] BIGINT NOT NULL IDENTITY(1,1),
	[user_data_id] BIGINT NOT NULL,
	[federal_feature_sku_id] BIGINT NULL,
	[state_feature_sku_id] BIGINT  NULL,
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [fk_federal_user_data_id] FOREIGN KEY (user_data_id) REFERENCES [dbo].[user_data](user_data_id),
)
