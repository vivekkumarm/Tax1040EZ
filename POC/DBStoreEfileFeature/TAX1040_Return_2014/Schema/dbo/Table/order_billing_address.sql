/**********************************************************************************************
Created By Ashok Kumar - 12th May, 2014 Table which holds Order details
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[order_billing_address]
(
	[order_billing_address_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[order_id] [BIGINT] NOT NULL,
	[name] NVARCHAR(100),
	[email] NVARCHAR(100),
	[street_address] NVARCHAR(35),
	[apartment_number] NVARCHAR(5) NULL, 
	[city] NVARCHAR(20),
	[state_name] NVARCHAR(50),
	[country_name] NVARCHAR(100),
	[phone] NVARCHAR(10),
	[postcode] [VARCHAR](20),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [pk_orderbillingaddres] PRIMARY KEY ([order_billing_address_id]), 
	CONSTRAINT [fk_order_billing_address_order] FOREIGN KEY ([order_id]) REFERENCES [order]([order_id])
)
