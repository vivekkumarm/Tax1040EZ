/*******************************************************************************
Author          : Ashok Kumar - 
Created Date    : 17th March, 2014
Description     : Persisting User data records into DB.

     Date                 Name                         Summary
    -----                ------                       ---------
18th March, 2014        Ashok Kumar        Removed @session_terminate as input parameter
26th March, 2014        Ashok Kumar        Added where condtion to Update section
*/
CREATE PROCEDURE [dbo].[usp_user_data_persist]
@user_data_id BIGINT,
@user_id BIGINT,
@session_data TEXT = NULL,
@tax_data TEXT,
@history_data TEXT = NULL
AS
BEGIN
SET NOCOUNT ON;
 
   IF @user_data_id=0
    
     BEGIN
     
        INSERT INTO [dbo].[user_data]
        (
			[user_id],
			[session_data],
			[tax_data],
			[history_data]
        )
        VALUES
        (
        @user_id,
        @session_data,
        @tax_data,
        @history_data
        )
        
       SELECT @@IDENTITY AS 'user_data_id'
    
     END
   ELSE
     BEGIN
      
       UPDATE [dbo].[user_data]
       SET [user_id]=@user_id,
           [session_data]=@session_data,
           [tax_data]=@tax_data,
           [history_data]=@history_data,
           [upate_datetime]=GETDATE()
       WHERE [user_data_id]=@user_data_id

      SELECT @user_data_id AS 'user_data_id'
     
     END

SET NOCOUNT OFF;
END

