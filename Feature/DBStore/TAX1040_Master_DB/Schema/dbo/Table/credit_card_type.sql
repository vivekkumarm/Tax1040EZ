/**********************************************************************************************
Created By Thileep Kumar - 22 May, 2014 Table which holds Credit Card details
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[credit_card_type]
(
    [credit_card_type_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[credit_card_type] [VARCHAR] (50) NOT NULL,
	[is_active] [BIT] NOT NULL DEFAULT(1),
    [is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(), 
	CONSTRAINT [pk_credit_card_type] PRIMARY KEY ([credit_card_type_id])
)


