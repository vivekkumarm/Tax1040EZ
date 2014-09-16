/**********************************************************************************************
Created By Ashok Kumar - 20th May, 2014 Table which holds state details which is 
related to a particular order
**********************************************************************************************/
/* Modification History */
CREATE TABLE [dbo].[order_detail_mapper]
(
	[order_detail_mapper_id] BIGINT IDENTITY(1,1) NOT NULL , 
    [shopping_cart_id] BIGINT NOT NULL, 
    [sku_id] BIGINT NOT NULL, 
    [sku_price] NUMERIC(15, 2) NOT NULL, 
    [state_id] BIGINT NOT NULL,
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [pk_order_detail_mapper] PRIMARY KEY ([order_detail_mapper_id]),
	CONSTRAINT [FK_order_detail_mapper_shopping_cart] FOREIGN KEY ([shopping_cart_id]) REFERENCES [shopping_cart]([shopping_cart_id]),
	--CONSTRAINT [FK_order_detail_mapper_state] FOREIGN KEY ([state_id]) REFERENCES [state]([state_id]) 
)
