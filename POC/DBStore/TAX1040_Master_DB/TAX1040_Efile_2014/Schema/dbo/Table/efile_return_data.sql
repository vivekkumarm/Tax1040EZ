/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_return_data
	CREATED ON: 8th May 2014
*******************************************************************************************************/


CREATE TABLE [dbo].[efile_return_data]
	(
        [efile_return_data_id] [BIGINT] IDENTITY(1,1) NOT NULL,
        [sender_id] [INT] NOT NULL,		
        [user_data_id] [INT] NULL,
        [product_id] [VARCHAR](20) NULL,
        [user_name] [VARCHAR](50) NULL,
        [email] [VARCHAR](50) NULL,
        [no_of_attachments] [INT] NULL,
        [encrypted_tax_data] [NVARCHAR](MAX) NOT NULL,
        [env_indicator] [CHAR](1) NOT NULL,
        [efile_trans_id] [VARCHAR](30) NULL,
        [tax_year] [VARCHAR](10) NULL,		
        [is_deleted] [BIT] NOT NULL DEFAULT 0,
        [create_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
        [update_datetime] [DATETIME] NOT NULL DEFAULT GETDATE(),
        [irs_system_id] [VARCHAR](20) NULL,
        CONSTRAINT [pk_efile_return_data] PRIMARY KEY ([efile_return_data_id])
	)
GO
