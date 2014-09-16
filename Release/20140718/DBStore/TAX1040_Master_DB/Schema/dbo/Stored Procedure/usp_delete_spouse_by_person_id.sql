
/*******************************************************************************
Created by Sathish - 05Jun2014 - Delete spouse by person id
********************************************************************************/
/* Modification History */

 
CREATE PROCEDURE  [dbo].[usp_delete_spouse_by_person_id]
@personal_info_id BIGINT
AS
BEGIN
SET NOCOUNT ON;

BEGIN TRANSACTION
       BEGIN
			UPDATE [dbo].[personal_info] 
			SET [is_deleted] = 1,
				[is_active] = 0
			WHERE [personal_info_id]=@personal_info_id
	   END

 IF @@ERROR = 0
  COMMIT TRANSACTION
 ELSE
  ROLLBACK TRANSACTION
SET NOCOUNT OFF;
END