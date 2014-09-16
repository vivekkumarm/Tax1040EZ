CREATE TABLE [dbo].[StcErrorCode](
      [ErrorCode] [varchar](50) NOT NULL,
      [ErrorFaultResponse] [varchar](max) NULL,
      [ErrorLogErrorMessage] [varchar](max) NULL,
      [ErrorType] [varchar](100) NULL,
      [FixType] [tinyint] NULL,
 CONSTRAINT [PK_TestErrorCode] PRIMARY KEY CLUSTERED 
(
      [ErrorCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
