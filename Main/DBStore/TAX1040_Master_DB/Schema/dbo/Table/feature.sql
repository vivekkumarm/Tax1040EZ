/**********************************************************************************************
Created by sathish - 2Jul2014 -  feature static table
**********************************************************************************************/
/* Modification History */

CREATE TABLE [dbo].[feature]
(
	[feature_id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[feature_name] [VARCHAR](50),
	[description] [VARCHAR](100),
	[is_active] [BIT] NOT NULL DEFAULT(1),
	[is_deleted] [BIT] NOT NULL DEFAULT(0),
	[create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
	[update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE() 
)
