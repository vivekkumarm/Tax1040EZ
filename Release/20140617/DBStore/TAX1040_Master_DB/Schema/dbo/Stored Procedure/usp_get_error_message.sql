/**********************************************************************************************
Created By Ashok Kumar - 19th March, 2014 Table which holds Static Error Messages
**********************************************************************************************/
/* Modification History */
/* sathish - 27 March 2014  - Changed according to coding standard */
CREATE PROCEDURE [dbo].[usp_get_error_message]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [error_code],
			[field_name],
			[field_description],
			[tab],
			[topic],
			[error_type],
			[message_type],
			[short_error_text],
			[long_error_text],
			[message_target],
			[error_title] 
	FROM error_message  WITH(NOLOCK) 
	WHERE ([is_deleted] = 0)

	SET NOCOUNT OFF;
END

SET NOCOUNT OFF;
