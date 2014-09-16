/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: efile_request_response
	CREATED ON: 8th May 2014
*******************************************************************************************************/

CREATE TABLE [dbo].[efile_request_response]
	(
		[efile_req_res_id] [BIGINT] IDENTITY(1,1) NOT NULL,
		[submission_id] [VARCHAR](25) NULL,
		[message_id] [VARCHAR](30) NULL,
		[request] [TEXT] NULL,
		[response] [TEXT] NULL,
		[action] [VARCHAR](50) NULL,
		[status_id] [TINYINT] NULL,
		[create_time_stamp] [DATETIME] NULL DEFAULT GETDATE(),
		[update_time_stamp] [DATETIME] NULL DEFAULT GETDATE(),
		CONSTRAINT [pk_efile_req_res] PRIMARY KEY ([efile_req_res_id])
	 )
 GO
