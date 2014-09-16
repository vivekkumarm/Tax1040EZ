/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_hold_persist
	CREATED ON: 9th May 2014
	Modified By Swapnesh  on 8th July 2014 OUTPUT parameter
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_return_data_persist]
 @sender_id INT,    
 @user_data_id  INT = NULL,
 @product_id VARCHAR(20) = NULL,
 @user_name VARCHAR(50) = NULL,    
 @email VARCHAR(50) = NULL,    
 @no_of_attachments INT = NULL,    
 @encrypted_tax_data VARCHAR(MAX),     
 @env_indicator CHAR(1) = '',
 @efile_trans_id VARCHAR(30) = ''  ,    
 @tax_year VARCHAR(10) = NULL,    
 @stage_id INT = NULL,  
 @state VARCHAR(10) = NULL,
 @efile_return_data_id BIGINT OUTPUT
AS    
	SET NOCOUNT ON    
		BEGIN     
			DECLARE @Date DATETIME, @EfileReturnDataId INT
			SET @Date = GETDATE()
            IF EXISTS (SELECT 1 FROM [dbo].[efile_return_data] WITH(NOLOCK) WHERE [user_data_id] = @user_data_id AND [is_deleted] = 0)  

			BEGIN  
				 UPDATE [dbo].[efile_return_data] WITH(ROWLOCK)  
				 SET 
					 [is_deleted]=1  
				 WHERE 
					[user_data_id] = @user_data_id
            END

			INSERT INTO [dbo].[efile_return_data]
			(
				[sender_id], 
                [user_data_id], 
				[product_id],
				[user_name],
				[email],
				[no_of_attachments], 
				[encrypted_tax_data], 
				[env_indicator], 
				[efile_trans_id], 
				[tax_year]
			)     
			VALUES 
			(
				@sender_id, 
				@user_data_id,
				@product_id,
                @user_name,
                @email,
				@no_of_attachments,
                @encrypted_tax_data,
				@env_indicator, 
				@efile_trans_id, 
				@tax_year
			)    

			SET @EfileReturnDataId = @@Identity  
			SET @efile_return_data_id   = @EfileReturnDataId 
			SELECT @EfileReturnDataId AS 'EfileHoldID'    
			EXEC [dbo].[usp_return_status_update] NULL, @EfileReturnDataId, @stage_id, @state  
		END
	SET NOCOUNT OFF
