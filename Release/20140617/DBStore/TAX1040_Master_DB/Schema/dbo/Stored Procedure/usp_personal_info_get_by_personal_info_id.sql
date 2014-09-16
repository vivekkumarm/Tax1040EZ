/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Get Personal Info details with Personal Info ID  
**********************************************************************************************/
/* Modification History */
/* Saravanan N. - 17th March, 2014 - Inner Join changed to LEFT JOIN to get records through there is no corresponding records in address table. */
/* Saravanan N. - 21st March, 2014  - Per spec new fields and constraints added. */
/* Sathish N - 01 April, 2014 is_foreign_address to address_type */
CREATE PROCEDURE [dbo].[usp_personal_info_get_by_personal_info_id]
@personal_info_id BIGINT
AS
BEGIN
	SET NOCOUNT ON;

    SELECT		p.[user_id],
				p.[first_name],
				p.[middle_initial],
				p.[last_name],
				p.[nick_name],
				p.[occupation],
				p.[date_of_birth],
				p.[social_security_number],
				p.[filing_status_id],
				p.[person_type_id],
				p.[has_primaryfiler_ecf_contributed],
				p.[has_spouse_ecf_contributed],
				p.[is_legally_blind],
				p.[is_disabled],
				p.[has_claimed_as_dependent],
				p.[is_died],
				p.[date_of_death],
				p.[is_student],
				p.[is_fulltime_student],				
				p.[has_lived_in_another_state],
				p.[lived_in_another_state_id],
				a.[street_address],
				a.[city],
				a.[personal_address_state_id],
				a.[foreign_state],
				a.[country_id],
				a.[zip_code],
				a.[phone],
				a.[address_type],
				a.[residence_state_id],
				a.[has_lived_in_more_than_one_state],
				a.[has_earned_income_from_non_lived_state],
				a.[lived_in_another_state_id],
				a.[lived_in_another_state_from],
				a.[lived_in_another_state_to],
				a.[earned_income_from_non_lived_state_id],
				a.[apartment_number],
				a.[postal_code]
	FROM [dbo].[personal_info] p WITH(NOLOCK) 
	LEFT JOIN [dbo].[address] a WITH(NOLOCK)  ON a.[personal_info_id] = p.[personal_info_id]
	WHERE p.[personal_info_id]=@personal_info_id

SET NOCOUNT OFF;
END


