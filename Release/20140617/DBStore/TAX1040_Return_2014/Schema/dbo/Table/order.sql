/**********************************************************************************************
Created By Ashok Kumar - 12th May, 2014 Table which holds Order details
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[order]
(
	 [order_id] [BIGINT] IDENTITY(1,1) NOT NULL,
     [user_data_id] BIGINT NOT NULL,
	 [shopping_cart_id] [BIGINT] NOT NULL,
	 [order_amount] DECIMAL(22, 2) NOT NULL,
	 [card_number] [VARCHAR](50) NOT NULL,
	 [cardtype_id] [INT] NOT NULL,
	 [card_expires] [VARCHAR](10) NOT NULL,
	 [processed] [BIT] NOT NULL DEFAULT(1) ,
	 [time] [DATETIME] NOT NULL,
	 [o_authorization] [VARCHAR](50) NOT NULL,
	 [ip_address] [VARCHAR](50) NOT NULL,
	 [is_deleted] [BIT] NOT NULL DEFAULT(0),
	 [create_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE(),
	 [update_timestamp] [DATETIME] NOT NULL DEFAULT GETDATE()
	 CONSTRAINT [pk_order] PRIMARY KEY ([order_id]), 
	 CONSTRAINT [fk_order_shopping_cart] FOREIGN KEY ([shopping_cart_id]) REFERENCES [shopping_cart]([shopping_cart_id]),
	 --CONSTRAINT [FK_order_product] FOREIGN KEY ([product_id]) REFERENCES [product]([product_id])
	 CONSTRAINT [fk_order_user_data] FOREIGN KEY ([user_data_id]) REFERENCES [user_data]([user_data_id])
)
