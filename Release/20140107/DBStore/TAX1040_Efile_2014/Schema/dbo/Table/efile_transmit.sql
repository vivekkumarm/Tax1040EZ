/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_transmit
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_transmit]
	(
		[efile_transmit_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[return_id] [BIGINT] NULL,
		[return_type] [VARCHAR](20) NULL,
		[stage] [VARCHAR](10) NULL,
		[state] [VARCHAR](10) NULL,
		[user_id] [BIGINT] NULL,
		[ip_date_time] [VARCHAR](50) NULL,
		[ip_time_zone] [VARCHAR](50) NULL,
		[ip_address] [VARCHAR](50) NULL,
		[status_id] [INT] NULL,
		[is_deleted] [BIT] NULL DEFAULT 0,
		CONSTRAINT [pk_efileTransmit] PRIMARY KEY ([efile_transmit_id])
	 )
 GO
