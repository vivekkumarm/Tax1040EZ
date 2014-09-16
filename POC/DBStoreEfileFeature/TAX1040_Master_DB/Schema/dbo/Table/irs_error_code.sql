/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: irs_error_code
	CREATED ON: 10th July 2014
*******************************************************************************************************/
/*****************************************************************************
		Table:
				Existing							Previous		
			[irs_error_code]			-		[StcErrorCode]
		Columns:
				Existing							Previous
			[irs_error_code]			-		[ErrorCode]
			[irs_error_response]		-		[ErrorFaultResponse] 
			[irs_error_log_error_message]-		[ErrorLogErrorMessage]
			[irs_error_type]			-		[ErrorType]
			[error_fix_type]			-		[FixType]
*****************************************************************************/

CREATE TABLE [dbo].[irs_error_code]
(
	[irs_error_code_id] BIGINT IDENTITY(1,1) NOT NULL, 
	[irs_error_code] [VARCHAR](50) NOT NULL,
	[irs_error_response] [VARCHAR](MAX) NULL,
	[irs_error_log_error_message] [VARCHAR](MAX) NULL,
	[irs_error_type] [VARCHAR](100) NULL,
	[error_fix_type] [TINYINT] NULL,
	CONSTRAINT [pk_irs_error_code] PRIMARY KEY ([irs_error_code_id]),
    CONSTRAINT [fk_irs_error_code_error_fix_type] FOREIGN KEY ([error_fix_type]) REFERENCES [error_fix_type]([error_fix_type_id])
)
