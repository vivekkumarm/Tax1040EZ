/**********************************************************************************************
Created by Balasubramanian - 12th March, 2014 -  User table
Modified by sathish - 18 Mar 2014 changed data type for security question to int, nvarchar(max) and foreign key to security question
Modified by sathish - 24 Mar 2014 Chaged length for security question max to 150
**********************************************************************************************/
/* Modification History */
/* sathish - 18 March 2014  changed data type for security question to int, nvarchar(max) and foreign key to security question*/
/* sathish - 24 March 2014  - Chaged length for security question max to 150 */
/* sathish - 27 March 2014  - Changed according to coding standard */


CREATE TABLE [dbo].[user]
(
	[user_id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[email] [NVARCHAR](100) UNIQUE NULL,
	[username] [NVARCHAR](100) UNIQUE NULL,
	[password] [NVARCHAR](100) NULL,
	[salt] [NVARCHAR](100) NULL,
	[security_question_id] INT NULL,
	[security_answer] [NVARCHAR](150) NULL,
	[client_IP] [NVARCHAR](20) NULL,
	[password_reset_code] [BIGINT] NULL,
	[is_remember] [BIT] NOT NULL DEFAULT 0,
	[is_active] [BIT] NULL DEFAULT 1,
	[is_deleted] [BIT] NULL DEFAULT 0,
	[create_datetime] [DATETIME] NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NULL DEFAULT GETDATE() , 
    CONSTRAINT [pk_user] PRIMARY KEY ([user_id]), 
    CONSTRAINT [fk_question] FOREIGN KEY ([security_question_id]) REFERENCES [security_question]([question_id]),
)
GO

CREATE NONCLUSTERED INDEX [ix_user_cover] 
      ON [dbo].[user]
      ([email],[username],[security_question_id],[security_answer])
GO
