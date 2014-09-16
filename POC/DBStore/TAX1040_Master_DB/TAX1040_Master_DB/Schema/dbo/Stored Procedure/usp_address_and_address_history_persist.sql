/*********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Persist Address and AddressHistory records into DB.  
*********************************************************************************************/
/*Modification History*/
/*Saravanan N - 14th March, 2014 - @address_idendity movied out of IF condition.*/
/*Saravanan N - 21st March, 2014 - As per the spec. fields added in the Address table. Hence, the corresponding changes done here too.*/
/*Saravanan N - 28th March, 2014 - @street_address size altered from 200 to 35*/
/*Sathish N - 01 April, 2014 is_foreign_address to address_type */
/*Sathish N - 04 April 2014 Check address is modified using union all */

CREATE PROCEDURE [dbo].[usp_address_and_address_history_persist]
@personal_info_id BIGINT=0,
@address_id BIGINT=0,
@street_address NVARCHAR(35),
@city NVARCHAR(100),
@personal_address_state_id BIGINT=NULL,
@foreign_state NVARCHAR(50)=NULL,
@country_id BIGINT=NULL,
@zip_code NVARCHAR(9)=NULL,
@phone NVARCHAR(11),
@address_type INT,
@residence_state_id BIGINT = NULL,
@has_lived_in_more_than_one_state BIT=NULL,
@has_earned_income_from_non_lived_state BIT=NULL,
@lived_in_another_state_id BIGINT=NULL,
@lived_in_another_state_from DATETIME=NULL,
@lived_in_another_state_to DATETIME=NULL,
@earned_income_from_non_lived_state_id BIGINT=NULL,
@apartment_number NVARCHAR(5)=NULL,
@postal_code NVARCHAR(10)=NULL
AS
BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION
      DECLARE @address_idendity BIGINT

    IF @address_id=0
        BEGIN
           INSERT INTO [dbo].[address]
           (
                        [personal_info_id],
                        [street_address],
                        [city],
                        [personal_address_state_id],
                        [foreign_state],
                        [country_id],
                        [zip_code],
                        [phone],
                        [address_type],
                        [residence_state_id],
                        [has_lived_in_more_than_one_state],
                        [has_earned_income_from_non_lived_state],
                        [lived_in_another_state_id],
                        [lived_in_another_state_from],
                        [lived_in_another_state_to],
                        [earned_income_from_non_lived_state_id],
                        [apartment_number],
                        [postal_code],
                        [update_datetime]             
               )
               VALUES
               (
                        @personal_info_id,
                        @street_address,
                        @city,
                        @personal_address_state_id,
                        @foreign_state,
                        @country_id,
                        @zip_code,
                        @phone,
                        @address_type,
                        @residence_state_id,
                        @has_lived_in_more_than_one_state,
                        @has_earned_income_from_non_lived_state,
                        @lived_in_another_state_id,
                        @lived_in_another_state_from,
                        @lived_in_another_state_to,
                        @earned_income_from_non_lived_state_id,
                        @apartment_number,
                        @postal_code,
                        GETDATE()
                  )
            SET @address_idendity=@@IDENTITY
           
            INSERT INTO [dbo].[address_history]
            (
                        [address_id],
                        [street_address],
                        [city],
                        [personal_address_state_id],
                        [foreign_state],
                        [country_id],
                        [zip_code],
                        [phone],
                        [address_type],
                        [residence_state_id],
                        [has_lived_in_more_than_one_state],
                        [has_earned_income_from_non_lived_state],
                        [lived_in_another_state_id],
                        [lived_in_another_state_from],
                        [lived_in_another_state_to],
                        [earned_income_from_non_lived_state_id],
                        [apartment_number],
                        [postal_code]
                  )
                  VALUES
                  (
                        @address_idendity,
                        @street_address,
                        @city,
                        @personal_address_state_id,
                        @foreign_state,
                        @country_id,
                        @zip_code,
                        @phone,
                        @address_type,
                        @residence_state_id,
                        @has_lived_in_more_than_one_state,
                        @has_earned_income_from_non_lived_state,
                        @lived_in_another_state_id,
                        @lived_in_another_state_from,
                        @lived_in_another_state_to,
                        @earned_income_from_non_lived_state_id,
                        @apartment_number,
                        @postal_code
                  )
       END
     ELSE IF( @address_id<>0)
            BEGIN 
            
            DECLARE @modified as int  = 0
            
            SET @modified = (SELECT COUNT(*) FROM (
                                                SELECT [personal_info_id],[street_address],[city],[personal_address_state_id],[foreign_state],
                                                            [country_id],[zip_code],[phone],[address_type],[residence_state_id],[has_lived_in_more_than_one_state],
                                                            [lived_in_another_state_id],[lived_in_another_state_from],[lived_in_another_state_to],
                                                            [earned_income_from_non_lived_state_id],[apartment_number],[postal_code]
                                                FROM [dbo].[address] 
                                                WHERE [address_id]=@address_id
                                                UNION
                                                SELECT @personal_info_id,@street_address,@city,@personal_address_state_id,@foreign_state,
                                                            @country_id,@zip_code,@phone,@address_type,@residence_state_id,@has_lived_in_more_than_one_state,
                                                            @lived_in_another_state_id,@lived_in_another_state_from,@lived_in_another_state_to,
                                                            @earned_income_from_non_lived_state_id,@apartment_number,@postal_code) is_modified)
                        
            IF(@modified > 1)
            BEGIN
                  UPDATE  [dbo].[address]
                        SET         [personal_info_id]=@personal_info_id,
                                    [street_address]=@street_address,
                                    [city]=@city,
                                    [personal_address_state_id]=@personal_address_state_id,
                                    [foreign_state]=@foreign_state,
                                    [country_id]=@country_id,
                                    [zip_code]=@zip_code,
                                    [phone]=@phone,
                                    [address_type]    =@address_type,
                                    [residence_state_id]=@residence_state_id,
                                    [has_lived_in_more_than_one_state]=@has_lived_in_more_than_one_state,
                                    [has_earned_income_from_non_lived_state]=@has_earned_income_from_non_lived_state,
                                    [lived_in_another_state_id]=@lived_in_another_state_id,
                                    [lived_in_another_state_from]=@lived_in_another_state_from,
                                    [lived_in_another_state_to]=@lived_in_another_state_to,
                                    [earned_income_from_non_lived_state_id]=@earned_income_from_non_lived_state_id,
                                    [apartment_number]=@apartment_number,
                                    [postal_code]=@postal_code,
                                    [update_datetime]=GETDATE()   
                        WHERE [address_id]=@address_id
                        
                  INSERT INTO [dbo].[address_history]
                        (
                              [address_id],
                              [street_address],
                              [city],
                              [personal_address_state_id],
                              [foreign_state],
                              [country_id],
                              [zip_code],
                              [phone],
                              [address_type],
                              [residence_state_id],
                              [has_lived_in_more_than_one_state],
                              [has_earned_income_from_non_lived_state],
                              [lived_in_another_state_id],
                              [lived_in_another_state_from],
                              [lived_in_another_state_to],
                              [earned_income_from_non_lived_state_id],
                              [apartment_number],
                              [postal_code]
                        )
                        VALUES
                        (
                              @address_id,
                              @street_address,
                              @city,
                              @personal_address_state_id,
                              @foreign_state,
                              @country_id,
                              @zip_code,
                              @phone,
                              @address_type,
                              @residence_state_id,
                              @has_lived_in_more_than_one_state,
                              @has_earned_income_from_non_lived_state,
                              @lived_in_another_state_id,
                              @lived_in_another_state_from,
                              @lived_in_another_state_to,
                              @earned_income_from_non_lived_state_id,
                              @apartment_number,
                              @postal_code
                        )
            END
            SET @address_idendity=@address_id   
      END

         SELECT @address_idendity AS 'address_id'

      IF @@ERROR = 0
        COMMIT TRANSACTION
      ELSE
        ROLLBACK TRANSACTION

      SET NOCOUNT OFF;
END