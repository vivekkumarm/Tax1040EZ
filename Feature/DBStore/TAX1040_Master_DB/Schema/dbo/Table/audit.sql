/**********************************************************************************************
Created by BhavaniRajesh - 28 Aug 2014 -  Audit table
**********************************************************************************************/

CREATE TABLE [dbo].[audit](
	[audit_id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_id] [bigint] NOT NULL,
	[user_data_id] [bigint] NULL,
	[ip_address] [nvarchar](100) NOT NULL,
	[tab_name] [nvarchar](50) NULL,
	[topic_name] [nvarchar](50) NULL,
	[description] [nvarchar](1000) NOT NULL,
	[create_datetime] [datetime] NOT NULL DEFAULT GetDate(),
	 CONSTRAINT [pk_audit] PRIMARY KEY ([audit_id]),
) 
GO