/**********************************************************************************************
Created By Ashok Kumar - 12th May, 2014 Table which holds shopping cart details
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[shopping_cart]
(
	[shopping_cart_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[user_data_id] [BIGINT] NOT NULL,
	[product_id] [BIGINT] NOT NULL,
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [pk_shopping_cart] PRIMARY KEY ([shopping_cart_id]), 
	CONSTRAINT [FK_shopping_cart_user_data] FOREIGN KEY ([user_data_id]) REFERENCES [user_data]([user_data_id])
	--CONSTRAINT [FK_shopping_cart_product] FOREIGN KEY ([product_id]) REFERENCES [product]([product_id])

)
