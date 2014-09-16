/*****************************************************************************************
Created by Balasubramanian Velmurugan - 21 March 2014 -  Procedure to persist Ez Eligibility details
Modified by Balasubramanian 25 March 2014 added user_id column to persist
******************************************************************************************/
/* Modification History */
/* Balasubramanian - 25 March 2014  added user_id column to persist.*/
/* Balasubramanian - 26 March 2014  - Refactored field name as per the standards. */

CREATE PROCEDURE [dbo].[usp_ez_eligibility_persist] 
(
@user_id [BIGINT],
@personal_info_id [BIGINT],
@has_dependent [BIT],
@has_received_other_income [BIT],
@has_adjusted_gross_income [BIT],
@has_claimed_itemized_deduction [BIT],
@has_claimed_credit [BIT],
@has_hired_person [BIT],
@has_claimed_prior_year_tax [BIT],
@has_paid_any_estimate [BIT],
@has_claimed_as_Debtor [BIT]
)
AS
BEGIN
SET NOCOUNT ON;

       INSERT INTO [dbo].[ez_eligibility] 
              (
			  [user_id],
              [personal_info_id],
			  [has_dependent],
			  [has_received_other_income],
			  [has_adjusted_gross_income],
			  [has_claimed_itemized_deduction],
			  [has_claimed_credit],
		      [has_hired_person],
			  [has_claimed_prior_year_tax],
			  [has_paid_any_estimate],
			  [has_claimed_as_Debtor]
              )
              VALUES
              (
			  @user_id,
              @personal_info_id,
			  @has_dependent,
			  @has_received_other_income,
			  @has_adjusted_gross_income,
			  @has_claimed_itemized_deduction,
			  @has_claimed_credit,
			  @has_hired_person,
			  @has_claimed_prior_year_tax,
			  @has_paid_any_estimate,
			  @has_claimed_as_Debtor
              )   
       SELECT @@IDENTITY AS 'ez_eligibility_id'
SET NOCOUNT OFF;
END