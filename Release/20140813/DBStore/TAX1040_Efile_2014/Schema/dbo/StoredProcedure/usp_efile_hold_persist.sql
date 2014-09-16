/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_hold_persist
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_hold_persist]
 @sender_id INT,    
 @return_id INT = NULL,    
 @user_id INT = NULL,    
 @user_name VARCHAR(50) = NULL,    
 @no_of_attachments INT = NULL,    
 @user_email VARCHAR(50) = NULL,    
 @tax_object XML,     
 @env_indicator CHAR(1),    
 @efile_trans_id VARCHAR(30) ,    
 @status_id INT = NULL,    
 @stage VARCHAR(10) = NULL,  
 @state VARCHAR(10) = NULL,  
 @tax_return_type_id VARCHAR(20) = NULL,  
 @tax_year VARCHAR(10) = NULL,  
 @tax_period VARCHAR(30) = NULL  
AS    
	SET NOCOUNT ON    
		BEGIN     
			DECLARE @Date DATETIME, @EfileHoldID INT    
			SET @Date = GETDATE()    
			IF EXISTS (SELECT 1 FROM [dbo].[efile_hold] WITH(NOLOCK) WHERE [return_id] = @return_id AND [is_deleted] = 0)  
				BEGIN  
				 UPDATE [dbo].[efile_hold] WITH(ROWLOCK)  
				 SET 
					 [is_deleted]=1 , 
					 [update_time_stamp] = @Date   
				 WHERE 
					[return_id] = @return_id  
				 INSERT INTO [dbo].[efile_hold]
				 (
					 [sender_id], 
					 [tax_return_type_id],
					 [return_id] , 
					 [no_of_attachments], 
					 [user_id], 
					 [user_name],
					 [user_email],
					 [tax_object], 
					 [env_indicator], 
					 [efile_trans_id], 
					 [is_deleted], 
					 [create_time_stamp], 
					 [update_time_stamp],
					 [tax_year],
					 [tax_period]
				 )     
				 VALUES 
				 (
					 @sender_id, 
					 @tax_return_type_id,
					 @return_id,
					 @no_of_attachments,
					 @user_id,
					 @user_name,
					 @user_email,
					 @tax_object,
					 @env_indicator, 
					 @efile_trans_id, 
					 0, 
					 @Date, 
					 @Date,
					 @tax_year,
					 @tax_period
				 )    
				 SET @EfileHoldID=@@Identity     
				 SELECT @EfileHoldID AS 'EfileHoldID'    
				 EXEC StatusUpdate NULL, @EfileHoldID, @status_id,@stage,@state  
				END   
			ELSE  
				INSERT INTO [dbo].[efile_hold]
				 (
					 [sender_id], 
					 [tax_return_type_id],
					 [return_id] , 
					 [no_of_attachments], 
					 [user_id], 
					 [user_name],
					 [user_email],
					 [tax_object], 
					 [env_indicator], 
					 [efile_trans_id], 
					 [is_deleted], 
					 [create_time_stamp], 
					 [update_time_stamp],
					 [tax_year],
					 [tax_period]
				 )        
				VALUES 
				(
					@sender_id, 
					@tax_return_type_id,
					@return_id, 
					@no_of_attachments,
					@user_id,
					@user_name,
					@user_email,
					@tax_object,
					@env_indicator, 
					@efile_trans_id, 
					0, 
					@Date, 
					@Date,
					@tax_year,
					@tax_period
				)    
				SET @EfileHoldID = @@Identity     
				SELECT @EfileHoldID AS 'EfileHoldID'    
				EXEC StatusUpdate NULL, @EfileHoldID, @status_id,@stage,@state  
		END
	SET NOCOUNT OFF   
GO
