/**********************************************************************************************
Created by Sathish - 14th March, 2014 -  Contains security questions
**********************************************************************************************/
CREATE TABLE [dbo].[security_question]
(
	[question_id] INT IDENTITY(1,1) ,
	[question] NVARCHAR(100) NOT NULL,
	[is_deleted] BIT NOT NULL DEFAULT 0, 
    [create_datetime] DATETIME NOT NULL DEFAULT GETDATE(), 
    [update_datetime] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [pk_question] PRIMARY KEY ([question_id]),
	
)
