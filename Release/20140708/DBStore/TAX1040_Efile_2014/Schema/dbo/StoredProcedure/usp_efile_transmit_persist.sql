/*********************************************************************************************************
	CREATED BY: Yogalakshmi				STORED PROCEDURE NAME: usp_efile_transmit_persist
	CREATED ON: 9th May 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_transmit_persist]
	@user_id BIGINT,        
	@return_id BIGINT,        
	@return_type VARCHAR(20),        
	@stage VARCHAR(10),        
	@state VARCHAR(10),        
	@ip_date_time VARCHAR(50),        
	@ip_time_zone VARCHAR(50),        
	@ip_address VARCHAR(50),        
	@status_id INT        
AS         
	BEGIN 
		SET NOCOUNT ON;        
		--- Temp Fix----------      
		 DECLARE @Day VARCHAR(10),@ProductId TINYINT ,@PaymentDate DATETIME,@Status VARCHAR(5)     
		 SELECT @ProductId=[product-id] FROM [returns] WITH(NOLOCK) WHERE [return_id] = @return_id      
			 IF @ProductId = 5      
		  BEGIN   
			 SET @PaymentDate = getdate()	   
			 SET @Day= datename (dw, @PaymentDate)  
			 SET @PaymentDate=CASE 
				 WHEN @Day = 'Saturday' THEN DATEADD(dd,2,@PaymentDate)      
				 WHEN @Day = 'Sunday' THEN DATEADD(dd,1,@PaymentDate)
				 ELSE GETDATE() END      
		  END      
		-----------------------       
		 If EXISTS (SELECT 1 FROM [dbo].[efile_transmit] WITH(NOLOCK) WHERE [return_id] = @return_id)        
			 Begin        
			   UPDATE  [dbo].[efile_transmit] WITH(ROWLOCK) 
			   SET 
					[is_deleted] = 1 
			   WHERE 
					[return_id] = @return_id        
			   INSERT INTO  [dbo].[efile_transmit]
			   (
				   [user_id],
				   [return_id],
				   [return_type],
				   [stage],
				   [state],
				   [ip_date_time],
				   [ip_time_zone],
				   [ip_address],
				   [status_id],
				   [is_deleted]
			   )        
			   VALUES
			   (
				   @user_id,
				   @return_id,
				   @return_type,
				   @stage,
				   @state,
				   @ip_date_time,
				   @ip_time_zone,
				   @ip_address,
				   @status_id,
				   0
			   ) 
			   --Modified For Multiple E-mail Issue On 15-07-2011---------
			IF EXISTS(SELECT 1 FROM [dbo].[efile_tax_xml] WITH(NOLOCK) WHERE [return_id] = @return_id AND [status_id] = 4) 
				 SET @Status='TRUE'
				  ELSE IF EXISTS(SELECT 1 FROM [dbo].[efile_transmit] WITH(NOLOCK) WHERE [return_id] = @return_id AND [is_deleted] = 1)    
						SET @Status='FALSE' 
				ELSE    
				  SET @Status='TRUE'      
			   SELECT @@Identity AS EfileTransmitID, @Status AS 'Status'  
			   --Update Account Details - Requested Date        
			   UPDATE [dbo].[account_details] WITH(ROWLOCK)        
				 SET  [payment_date] = @PaymentDate       
				 WHERE [return_id] = @return_id         
			  END        
		 ELSE        
			  BEGIN        
			   INSERT INTO [dbo].[efile_transmit]
			   (
				   [user_id],
				   [return_id],
				   [return_type],
				   [stage],
				   [state],
				   [ip_date_time],
				   [ip_time_zone],
				   [ip_address],
				   [status_id],
				   [is_deleted]
			   )        
			   VALUES
			   (
				   @user_id,
				   @return_id,
				   @return_type,
				   @stage,
				   @state,
				   @ip_date_time,
				   @ip_time_zone,
				   @ip_address,
				   @status_id,
				   0
			   )        
			   SELECT @@Identity AS EfileTransmitID,'TRUE' AS 'Status'         
			   --Update Account Details - Requested Date        
			   UPDATE [dbo].[account_details]      
				 SET  
					[payment_date] = @PaymentDate       
				 WHERE 
					[return_id] = @return_id  
			  END 
		  SET NOCOUNT OFF;       
	END
GO
