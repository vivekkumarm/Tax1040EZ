/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Address History table
**********************************************************************************************/
/* Modification History */
/* Saravanan N. - 21st March, 2014  - Per spec new fields and constraints added. */
/* Vivek - 28st March, 2014  - Per spec fields updated */
/* Sathish N - 02 April 2014 changed [is_foreign_address] to address_type to store PersonalAddress,ForeignAddress,CompanyAddress and TaxPayerAddress*/
/* Sathish N - 04 April 2014 Set allow null for country_id, residence_sate_id, city and street address*/
/* Saravanan N - 25th July, 2014 - City and foreign_state column size increased to 50 as per Personal spec 2.5 and also fixed Defect 14281 */
/* Bala - 28 July 2014 lived_in_another_state_id,earned_income_from_non_lived_state_id are modified and lived_in_another_state_from,lived_in_another_state_to are removed */

CREATE TABLE [dbo].[address_history]
(
	[address_history_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[address_id] [BIGINT] NOT NULL,
	[street_address] [NVARCHAR](35) NULL,
	[city] [NVARCHAR](50) NULL,
	[personal_address_state_id] [BIGINT] NULL,
	[foreign_state] [NVARCHAR](50) NULL,
	[country_id] [BIGINT] NULL,
	[zip_code] [NVARCHAR](10) NULL,
	[phone] [NVARCHAR](12) NOT NULL,
    [address_type] INT NOT NULL, 
    [residence_state_id] BIGINT NULL , 
    [has_lived_in_more_than_one_state] BIT NULL DEFAULT 0, 
    [has_earned_income_from_non_lived_state] BIT NULL DEFAULT 0, 
    [lived_in_another_state_id] VARCHAR(10) NULL, 
    [earned_income_from_non_lived_state_id] VARCHAR(10) NULL, 
    [apartment_number] NVARCHAR(5) NULL, 
	[postal_code] NVARCHAR(10) NULL,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [pk_address_history] PRIMARY KEY ([address_history_id]), 
    CONSTRAINT [fk_address_history_address] FOREIGN KEY ([address_id]) REFERENCES [dbo].[address]([address_id]), 
    CONSTRAINT [fk_address_history_personal_address_state] FOREIGN KEY ([personal_address_state_id]) REFERENCES [dbo].[state]([state_id]), 
    CONSTRAINT [fk_address_history_country] FOREIGN KEY ([country_id]) REFERENCES [dbo].[country]([country_id]), 
    CONSTRAINT [fK_address_history_residence_state_id] FOREIGN KEY (residence_state_id) REFERENCES [dbo].[state]([state_id]), 
)
