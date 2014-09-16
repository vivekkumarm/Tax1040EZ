/**********************************************************************************************
Created by vivekkumar - 7th March, 2014 -  Contains Personal Information
**********************************************************************************************/
/* Modification History */
/* Saravanan N. - 21st March, 2014  - Per spec new fields and constraints added. */
/* Vivek - 28st March, 2014  - Following fields changed as not required fields as per the requirement.
first_name, last_name,nick_name,occupation,date_of_birth,social_security_number,filing_status_id,person_type_id */

CREATE TABLE [dbo].[personal_info]
(
	[personal_info_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[user_id] [BIGINT] NOT NULL,
	[first_name] [NVARCHAR](100)  NULL,
	[middle_initial] CHAR(1) NULL,
	[last_name] [NVARCHAR](100)  NULL,
	[nick_name] [NVARCHAR](100) NULL,
	[occupation] [NVARCHAR](100) NULL,
	[date_of_birth] [DATETIME]  NULL,
	[social_security_number] [VARCHAR](15) NULL,
	[filing_status_id] [BIGINT] NULL,
	[person_type_id] [BIGINT]  NULL,
	[has_primaryfiler_ecf_contributed] [BIT] NULL,
    [has_spouse_ecf_contributed] BIT NULL, 
    [is_legally_blind] BIT NULL, 
    [is_disabled] BIT NULL, 
    [has_claimed_as_dependent] BIT NULL, 
    [is_died] BIT NULL, 
    [date_of_death] DATETIME NULL, 
    [is_student] BIT NULL, 
    [is_fulltime_student] BIT NULL, 
    [is_other_info_none] BIT NULL, 
    [has_lived_in_another_state] BIT NULL, 
    [lived_in_another_state_id] BIGINT NULL, 
	[is_active] [BIT] NOT NULL DEFAULT 1,
	[is_deleted] [BIT] NOT NULL DEFAULT 0,
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL
    CONSTRAINT [pk_personal_info] PRIMARY KEY ([personal_info_id]), 
    CONSTRAINT [fk_personal_info_user] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user]([user_id]), 
    CONSTRAINT [fk_personal_info_filing_status] FOREIGN KEY ([filing_status_id]) REFERENCES [dbo].[filing_status]([filing_status_id]), 
    CONSTRAINT [fk_personal_info_person_type] FOREIGN KEY ([person_type_id]) REFERENCES [dbo].[person_type]([person_type_id]), 
    CONSTRAINT [fK_personal_info_state] FOREIGN KEY ([lived_in_another_state_id]) REFERENCES [dbo].[state]([state_id]) 
)