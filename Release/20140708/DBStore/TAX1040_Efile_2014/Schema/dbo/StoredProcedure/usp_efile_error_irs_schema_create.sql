/*******************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_error_irs_schema_create
	CREATED ON: 12th May 2014
*******************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_error_irs_schema_create]
@SubmissionID VARCHAR(30),
@ErrorCode VARCHAR(30),
@Errormessage TEXT,
@ErrorClassification TEXT,
@Action VARCHAR(50),
@ErrorType VARCHAR(50)
AS
	BEGIN	
		SET NOCOUNT ON;
			DECLARE @Count INT
				IF @ErrorType IS NOT NULL
					BEGIN
						IF  EXISTS(SELECT 1 FROM [dbo].[stc_error_code] WITH(NOLOCK) WHERE [error_type] = @ErrorType)
							BEGIN
								SELECT 
									@ErrorCode = [error_code] 
								FROM 
									[dbo].[stc_error_code] WITH(NOLOCK) 
								WHERE 
									[error_type] = @ErrorType
								INSERT INTO 
									[dbo].[efile_error] 
								VALUES
								(
									@SubmissionID,
									@ErrorCode,
									@Errormessage,
									@ErrorClassification,
									@Action,
									0,
									0,
									0,
									GETDATE(),
									GETDATE()
								)
							END 
						ELSE
							BEGIN
								SELECT @Count = COUNT(ErrorCode)+1 FROM [dbo].[stc_error_code] WITH(NOLOCK) WHERE  [error_code] LIKE 'IRSSCHVAL%'
								SET @ErrorCode = 'IRSSCHVAL'+CAST (@Count AS VARCHAR(50))
								IF EXISTS (SELECT 1 FROM [dbo].[stc_error_code] WHERE [error_code] = @ErrorCode)
									INSERT INTO 
										[dbo].[efile_error]  
									VALUES
									(
										@SubmissionID,
										@ErrorCode,
										@Errormessage,
										@ErrorClassification,
										@Action,
										0,
										0,
										0,
										GETDATE(),
										GETDATE()
									)
								ELSE
									BEGIN
										INSERT INTO 
											[dbo].[stc_error_code] 
										VALUES
										(
											@ErrorCode, 
											@Errormessage,
											@Errormessage,
											@ErrorType,
											3
										)
										INSERT INTO 
											[dbo].[efile_error]  
										VALUES
										(
											@SubmissionID,
											@ErrorCode,
											@Errormessage,
											@ErrorClassification,
											@Action,
											0,
											0,
											0,
											GETDATE(),
											GETDATE()
										)
									END
							END 
					END
				ELSE 
					BEGIN
						IF  EXISTS(SELECT 1 FROM [dbo].[stc_error_code] WITH(NOLOCK) WHERE ErrorFaultResponse = CAST(@ErrorMessage AS VARCHAR(MAX)))
							BEGIN
								SELECT @ErrorCode = [error_code] FROM [dbo].[stc_error_code] WITH(NOLOCK) WHERE [error_type] = @ErrorType
								INSERT INTO 
									[dbo].[efile_error]  
								VALUES
								(
									@SubmissionID,
									@ErrorCode,
									@Errormessage,
									@ErrorClassification,
									@Action,
									0,
									0,
									0,
									GETDATE(),
									GETDATE()
								)
							END 
						ELSE
							BEGIN
								SELECT @Count = count([error_code])+1 FROM [dbo].[stc_error_code] WITH(NOLOCK) WHERE [error_code] LIKE 'IRSSCHVAL%'
								SET @ErrorCode = 'IRSSCHVAL'+cast (@Count AS VARCHAR(50))
								IF EXISTS (SELECT 1 FROM [dbo].[stc_error_code] WHERE ErrorCode = @ErrorCode)
									INSERT INTO 
										[dbo].[efile_error]  
									VALUES
									(
										@SubmissionID,
										@ErrorCode,
										@Errormessage,
										@ErrorClassification,
										@Action,
										0,
										0,
										0,
										GETDATE(),
										GETDATE()
									)
								ELSE
									BEGIN
										INSERT INTO 
											[dbo].[stc_error_code] 
										VALUES
										(
											@ErrorCode, 
											@Errormessage,
											@Errormessage,
											@ErrorType,
											3
										)
										INSERT INTO 
											[dbo].[efile_error]  
										VALUES
										(
											@SubmissionID,
											@ErrorCode,
											@Errormessage,
											@ErrorClassification,
											@Action,
											0,
											0,
											0,
											GETDATE(),
											GETDATE()
										)
									END
							END 
					END 
		SET NOCOUNT OFF;
	END
GO
