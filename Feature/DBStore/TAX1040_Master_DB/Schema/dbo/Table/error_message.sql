/**********************************************************************************************
Created By Ashok Kumar - 19th March, 2014 Table which holds Static Error Messages
Modified by Ashok kumar  - 20 March 2014 Added New and Modified columns
**********************************************************************************************/
/* Modification History */
/* Ashok Kumar - 20 March 2014   Added New and Modified columns*/
/* sathish - 27 March 2014  - added is deleted column Changed according to coding standard  */
/* Thileepkumar - 12Aug2014  - Changed [short_error_text] column length to "max" as per discussion */
CREATE TABLE [dbo].[error_message](
	[message_id] [INT] IDENTITY(1,1) NOT NULL,
	[error_code] [NVARCHAR](50) NULL,
	[field_name] [NVARCHAR](MAX) NULL,
	[field_description] [NVARCHAR](max) NULL,
	[tab] [NVARCHAR](255) NULL,
	[topic] [NVARCHAR](255) NULL,
	[error_type] [NVARCHAR](50) NULL,
	[message_type] [NVARCHAR](50) NULL,
	[short_error_text] [NVARCHAR](max) NULL,
	[long_error_text] [NVARCHAR](max) NULL,
	[message_target] [NVARCHAR](255) NULL,
	[error_title] [NVARCHAR](255) NULL,
	[is_deleted] [BIT] NULL DEFAULT 0,
    CONSTRAINT [pk_error_message] PRIMARY KEY ([message_id]) ,
	CONSTRAINT [uc_error_message] UNIQUE ([error_code]) 
)
