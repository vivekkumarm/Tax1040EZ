/***************************************************************************************************
Created by Balasubramanian Velmurugan - 21 March 2014 - Procedure to get Ez Eligibility details.
Modified by Balasubramanian  25 March 2014  included user_id column in select clause of the stored proc 
****************************************************************************************************/
/* Modification History */
/* Balasubramanian - 25 March 2014  included user_id column in select clause of the stored proc.*/
/* Balasubramanian - 26 March 2014  - Refactored field name as per the standards. */

CREATE PROCEDURE [dbo].[usp_get_ez_eligibility_by_personal_info_id]
@personal_info_id [BIGINT]
AS
BEGIN
	SET NOCOUNT ON;
	
    SELECT 	[user_id],
	        [ez_eligibility_id],
			[has_dependent],
			[has_received_other_income],
			[has_adjusted_gross_income],
			[has_claimed_itemized_deduction],
			[has_claimed_credit],
		    [has_hired_person],
			[has_claimed_prior_year_tax],
			[has_paid_any_estimate],
			[has_claimed_as_Debtor]
	FROM [dbo].[ez_eligibility] WITH (NOLOCK)
	WHERE [personal_info_id] = @personal_info_id
	AND [is_deleted] = CAST(0 AS BIT)
	
	SET NOCOUNT OFF; 
END
