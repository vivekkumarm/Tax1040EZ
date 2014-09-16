/**********************************************************************************************
Created By Ashok Kumar - 12th May, 2014 Table which holds Order details
**********************************************************************************************/
/* Modification History */
/* 07Jul2014 Sathish changed phone number varchar length to 12*/
/* 01Aug2014 Sathish changed street address varchar length from 35 to 60*/
/* 01Aug2014 Sathish changed city varchar length from 20 to 50*/
/* 01Aug2014 Sathish changed name varchar length from 100 to 150*/

CREATE TABLE [dbo].[order_billing_address]
(
	[order_billing_address_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[order_id] [BIGINT] NOT NULL,
	[name] NVARCHAR(150),
	[email] NVARCHAR(100),
	[street_address] NVARCHAR(60),
	[apartment_number] NVARCHAR(5) NULL, 
	[city] NVARCHAR(50),
	[state_name] NVARCHAR(50),
	[country_name] NVARCHAR(100),
	[phone] NVARCHAR(12),
	[postcode] [VARCHAR](20),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE()
	CONSTRAINT [pk_orderbillingaddres] PRIMARY KEY ([order_billing_address_id]), 
	CONSTRAINT [fk_order_billing_address_order] FOREIGN KEY ([order_id]) REFERENCES [order]([order_id])
)
