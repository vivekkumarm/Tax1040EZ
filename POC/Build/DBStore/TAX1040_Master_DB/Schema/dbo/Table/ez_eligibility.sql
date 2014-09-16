/**********************************************************************************************
Created by Balasubramanian - 21st March, 2014 -  Ez Eligibility table
Modified by Balasubramanian - 25 March 2014 added [user_id] field and foreign key reference with [dbo].[user] table.
**********************************************************************************************/
/* Modification History */
/* Balasubramanian. - 25 March 2014  - added [user_id] field and foreign key reference with [dbo].[user] table. */
/* Balasubramanian. - 26 March 2014  - Refactored field and type name as per the standards. */

CREATE TABLE [dbo].[ez_eligibility]
(
	[ez_eligibility_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[user_id] [BIGINT],
	[personal_info_id] [BIGINT],
	[has_dependent] [BIT] NULL DEFAULT 0,
	[has_received_other_income] [BIT] NULL DEFAULT 0,
	[has_adjusted_gross_income] [BIT] NULL DEFAULT 0,
	[has_claimed_itemized_deduction] [BIT] NULL DEFAULT 0,
	[has_claimed_credit] [BIT] NULL DEFAULT 0,
	[has_hired_person] [BIT] NULL DEFAULT 0,
	[has_claimed_prior_year_tax] [BIT] NULL DEFAULT 0,
	[has_paid_any_estimate] [BIT] NULL DEFAULT 0,
	[has_claimed_as_debtor] [BIT] NULL DEFAULT 0,
	[is_deleted] [BIT] NULL DEFAULT 0,
	[create_datetime] [DATETIME] NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NULL DEFAULT GETDATE() , 
    CONSTRAINT [pk_ez_eligibility] PRIMARY KEY ([ez_eligibility_id]), 
    CONSTRAINT [fk_ez_eligibility_personal_info] FOREIGN KEY ([personal_info_id]) REFERENCES [dbo].[personal_info]([personal_info_id]),
	CONSTRAINT [fk_ez_eligibility_user] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user]([user_id])
)
GO


