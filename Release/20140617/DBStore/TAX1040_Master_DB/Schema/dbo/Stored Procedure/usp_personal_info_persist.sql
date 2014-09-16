/*******************************************************************************
Created by vivekkumar - 7th March, 2014 - Persist Personal info records into DB.
********************************************************************************/
/* Modification History */
/*Saravanan N - 14th March, 2014 - @personal_info_idendity movied out of IF condition.*/
/*Saravanan N - 21st March, 2014 - As per the spec. fields added in the PersonalInfo table. Hence, the corresponding changes done here too.*/
 
CREATE PROCEDURE  [dbo].[usp_personal_info_persist]
@personal_info_id BIGINT=0,
@user_id BIGINT,
@first_name NVARCHAR(100)=NULL,
@middle_initial  CHAR(1)=NULL,
@last_name  NVARCHAR(100)=NULL,
@nick_name  NVARCHAR(100)=NULL,
@occupation  NVARCHAR(100)=NULL,
@date_of_birth DATETIME=NULL,
@social_security_number  NVARCHAR(20)=NULL,
@filing_status_id BIGINT=NULL,
@person_type_id BIGINT=NULL,
@has_primaryfiler_ecf_contributed BIT=NULL,
@has_spouse_ecf_contributed BIT=NULL,
@is_legally_blind BIT=NULL,
@is_disabled BIT=NULL,
@has_claimed_as_dependent BIT=NULL,
@is_died BIT=NULL,
@date_of_death DATETIME=NULL,
@is_student BIT=NULL,
@is_fulltime_student BIT=NULL,
@is_other_info_none BIT=NULL,
@has_lived_in_another_state BIT=NULL,
@lived_in_another_state_id BIGINT=NULL
AS
BEGIN
SET NOCOUNT ON;

BEGIN TRANSACTION
	DECLARE @personal_info_idendity BIGINT

    IF @personal_info_id=0
	  BEGIN
           INSERT INTO [dbo].[personal_info]
           (
				[user_id],
				[first_name],
				[middle_initial],
				[last_name],
				[nick_name],
				[occupation],
				[date_of_birth],
				[social_security_number],
				[filing_status_id],
				[person_type_id],
				[has_primaryfiler_ecf_contributed],
				[has_spouse_ecf_contributed],
				[is_legally_blind],
				[is_disabled],
				[has_claimed_as_dependent],
				[is_died],
				[date_of_death],
				[is_student],
				[is_fulltime_student],
				[is_other_info_none],
				[has_lived_in_another_state],
				[lived_in_another_state_id],
				[update_datetime]
            )
		    VALUES
		    (
		        @user_id,
				@first_name,
		        @middle_initial,
		        @last_name,
		        @nick_name,
		        @occupation,
		        @date_of_birth,
		        @social_security_number,
		        @filing_status_id,
		        @person_type_id,
				@has_primaryfiler_ecf_contributed,
				@has_spouse_ecf_contributed,
				@is_legally_blind,
				@is_disabled,
				@has_claimed_as_dependent,
				@is_died,
				@date_of_death,
				@is_student,
				@is_fulltime_student,
				@is_other_info_none,
				@has_lived_in_another_state,
				@lived_in_another_state_id,
		        GETDATE()
		     )
		     
		   SELECT @personal_info_idendity=@@IDENTITY
	   END
    ELSE
       BEGIN
			UPDATE [dbo].[personal_info] 
			SET [user_id]=@user_id,
				[first_name]=@first_name,
				[middle_initial]=@middle_initial,
				[last_name]=@last_name,
				[nick_name]=@nick_name,
				[occupation]=@occupation,
				[date_of_birth]=@date_of_birth,
				[social_security_number]=@social_security_number,
				[filing_status_id]=@filing_status_id,
				[person_type_id]=@person_type_id,
				[has_primaryfiler_ecf_contributed]=@has_primaryfiler_ecf_contributed,
				[has_spouse_ecf_contributed]=@has_spouse_ecf_contributed,
				[is_legally_blind]=@is_legally_blind,
				[is_disabled]=@is_disabled,
				[has_claimed_as_dependent]=@has_claimed_as_dependent,
				[is_died]=@is_died,
				[date_of_death]=@date_of_death,
				[is_student]=@is_student,
				[is_fulltime_student]=@is_fulltime_student,
				[is_other_info_none]=@is_other_info_none,
				[has_lived_in_another_state]=@has_lived_in_another_state,
				[lived_in_another_state_id]=@lived_in_another_state_id,
				[update_datetime]=GETDATE()
			WHERE [personal_info_id]=@personal_info_id
		   
			SET @personal_info_idendity=@personal_info_id
	   END
	   
	 SELECT @personal_info_idendity AS 'personal_info_id'
	 
 IF @@ERROR = 0
  COMMIT TRANSACTION
 ELSE
  ROLLBACK TRANSACTION
SET NOCOUNT OFF;
END