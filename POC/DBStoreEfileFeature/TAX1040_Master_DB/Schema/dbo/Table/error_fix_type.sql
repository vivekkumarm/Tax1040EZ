/*******************************************************************************************************
	CREATED BY: Yogalakshmi				TABLE NAME: error_fix_type
	CREATED ON: 10th May 2014
*******************************************************************************************************/
/*****************************************************************************
		Table:
				Existing						Previous		
			[error_fix_type]		-		[StcErrorFixType]
		Columns:
				Existing						Previous
			[error_fix_type]		-		[ErrorFixType]
		*****************************************************************************/
CREATE TABLE [dbo].[error_fix_type]
(
	[error_fix_type_id] TINYINT IDENTITY(1,1) NOT NULL,
	[error_fix_type] [VARCHAR](50) NOT NULL,
	CONSTRAINT [pk_error_fix_type] PRIMARY KEY ([error_fix_type_id])
)
