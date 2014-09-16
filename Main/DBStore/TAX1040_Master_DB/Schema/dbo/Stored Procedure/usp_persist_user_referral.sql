/*************************************************************************************************
Created by Sathish on 18Jul2014 procedure persist user referral
**************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_persist_user_referral]
@user_id BIGINT,
@referral_email VARCHAR(1000)
AS
BEGIN 
	SET NOCOUNT ON;

			INSERT INTO  [dbo].[user_referral]([user_id],
											 [user_referral_email]) 
			VALUES(@user_id,
					@referral_email)
	SET NOCOUNT OFF;
END