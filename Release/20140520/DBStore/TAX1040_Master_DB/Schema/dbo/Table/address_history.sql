/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Address History table
**********************************************************************************************/
/* Modification History */
/* Saravanan N. - 21st March, 2014  - Per spec new fields and constraints added. */
/* Vivek - 28st March, 2014  - Per spec fields updated */
/* Sathish N - 02 April 2014 changed [is_foreign_address] to address_type to store PersonalAddress,ForeignAddress,CompanyAddress and TaxPayerAddress*/
/* Sathish N - 04 April 2014 Set allow null for country_id, residence_sate_id, city and street address*/

CREATE TABLE [dbo].[address_history]
(
	[address_history_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[address_id] [BIGINT] NOT NULL,
	[street_address] [NVARCHAR](35) NULL,
	[city] [NVARCHAR](20) NULL,
	[personal_address_state_id] [BIGINT] NULL,
	[foreign_state] [NVARCHAR](15) NULL,
	[country_id] [BIGINT] NULL,
	[zip_code] [NVARCHAR](9) NULL,
	[phone] [NVARCHAR](10) NOT NULL,
    [address_type] INT NOT NULL, 
    [residence_state_id] BIGINT NULL , 
    [has_lived_in_more_than_one_state] BIT NULL DEFAULT 0, 
    [has_earned_income_from_non_lived_state] BIT NULL DEFAULT 0, 
    [lived_in_another_state_id] BIGINT NULL, 
    [lived_in_another_state_from] DATETIME NULL, 
    [lived_in_another_state_to] DATETIME NULL, 
    [earned_income_from_non_lived_state_id] BIGINT NULL, 
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
    CONSTRAINT [fK_address_history_lived_in_another_state] FOREIGN KEY ([lived_in_another_state_id]) REFERENCES [dbo].[state]([state_id]), 
    CONSTRAINT [fk_address_history_earned_income_from_non_lived_state] FOREIGN KEY ([earned_income_from_non_lived_state_id]) REFERENCES [dbo].[state]([state_id]),
)
