/***************************************************************************************************
Created by Sathish - 14 March 2014 - Procedure to get Email template.
****************************************************************************************************/
/* Modification History */
/* Sathish - 27 March 2014 Filer by is deleted and changed column name from isactive to is_active */
CREATE PROCEDURE [dbo].[usp_get_email_template_by_id]
@template_id INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [template_name],
		   [template_Content] 
	FROM [dbo].[email_template] WITH (NOLOCK)
	WHERE [template_id] = @template_id
	AND [is_active] = CAST(1 AS BIT)
	AND [is_deleted] = CAST(0 AS BIT)
	
	SET NOCOUNT OFF; 
END
