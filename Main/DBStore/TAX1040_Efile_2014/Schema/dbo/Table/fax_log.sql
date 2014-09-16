/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: fax_log
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[fax_log]
	(
		[fax_status_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[return_id] [BIGINT] NULL,
		[shopping_cart_detail_id] [BIGINT] NULL,
		[fax_number] [VARCHAR](30) NULL,
		[fax_service_number] [VARCHAR](30) NULL,
		[fax_return_value_id] [BIGINT] NULL,
		[create_time_stamp] [DATETIME] NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NULL DEFAULT GETDATE()
	)
GO
