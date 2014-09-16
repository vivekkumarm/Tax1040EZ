/**********************************************************************************************
Created By Ashok Kumar - 12th May, 2014 Table which holds Static product Sku details
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[product_sku]
(
	[sku_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[product_id] [BIGINT],
	[sku_name] [VARCHAR](50),
	[sku_description] [VARCHAR](100),
	[sku_price] [NUMERIC](15,2),
	[state_id] BIGINT NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [pk_sku] PRIMARY KEY ([sku_id]), 
	CONSTRAINT [FK_product_sku_product] FOREIGN KEY (product_id) REFERENCES [dbo].[product](product_id),
	--CONSTRAINT [FK_product_sku_state] FOREIGN KEY (state_id) REFERENCES [dbo].[state](state_id)
)
