/*16Apr2014 Sathish.N Validate zip code by sate id*/  
/* Modification History*/ 
  
CREATE PROCEDURE [dbo].[usp_validate_zip_code_by_state_id]
@state_id BIGINT,
@zip_code VARCHAR(9)
AS
BEGIN
SET NOCOUNT ON;
 
	DECLARE @zip_code_condition VARCHAR(500) = ''
	DECLARE @sql VARCHAR(2000) = ''
	DECLARE @status BIT  = 0

	
	print 'TEST'
	IF(ISNUMERIC(@zip_code) = 1)
	BEGIN
		SELECT  @zip_code_condition = REPLACE(condition,'tempzipcode',@zip_code) 
				FROM [dbo].[state_zip_code_conditions] WITH(NOLOCK)  
				WHERE [state_id] = @state_id  
	END
	
	IF(@zip_code_condition <> '')
	BEGIN
		set @sql = 'IF EXISTS (SELECT   1 
								FROM [dbo].[state_zip_code_conditions] 
								WHERE ' + @zip_code_condition +  ' AND  
								[state_id] = ' + CAST(@state_id AS VARCHAR) + ') 
								SELECT CAST(1 AS BIT) AS [status]
					ELSE 
								SELECT CAST(0 AS BIT) AS [status]'  
		
		
		EXEC(@sql)
	END
	ELSE
		SELECT CAST(0 AS BIT) AS [status]

SET NOCOUNT OFF;
END