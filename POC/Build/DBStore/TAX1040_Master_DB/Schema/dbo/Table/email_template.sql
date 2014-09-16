/**********************************************************************************************
Created By Sathish - 14 th March, 2014 Table which holds Static Error Messages
**********************************************************************************************/
/* Modification History */
/* Sathish - 27 March 2014 Added is_deleted column  and set default to isactive and is_deleted */
CREATE TABLE [dbo].[email_template]
(
	[template_id] [INT] IDENTITY(1,1) NOT NULL,
	[template_Content] [NVARCHAR](MAX) NULL,
	[template_Name] [NVARCHAR](100) NULL,
	[is_active] [BIT] NULL DEFAULT 1,
	[is_deleted] [BIT] NULL DEFAULT 0,
)
