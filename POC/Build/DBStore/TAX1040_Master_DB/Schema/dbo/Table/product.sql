/**********************************************************************************************
Created By Ashok Kumar - 12th May, 2014 Table which holds Static product details
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[product]
(
	[product_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[product_name] [VARCHAR](30),
	[description] [VARCHAR](50),
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [pk_product] PRIMARY KEY ([product_id])
)
