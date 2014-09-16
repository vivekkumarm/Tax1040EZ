/**********************************************************************************************
Created by sathish - 2Jul2014 -  State feature static table
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[state_feature_sku]
(
	[state_feature_sku_id] BIGINT NOT NULL PRIMARY KEY  IDENTITY(1,1),
	[product_id] BIGINT NOT NULL,
	[feature_id] BIGINT NOT NULL, 
	[state_id] BIGINT NOT NULL,
	[state_price] [DECIMAL](15,2) NOT NULL,
	[description] [VARCHAR](100),
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE() 
	CONSTRAINT [fk_state_product_id] FOREIGN KEY (product_id) REFERENCES [dbo].[product](product_id),
	CONSTRAINT [fk_state_feature_id] FOREIGN KEY (feature_id) REFERENCES [dbo].[feature](feature_id),
	CONSTRAINT [fk_feature_state_id] FOREIGN KEY (state_id) REFERENCES [dbo].[state](state_id),
)
