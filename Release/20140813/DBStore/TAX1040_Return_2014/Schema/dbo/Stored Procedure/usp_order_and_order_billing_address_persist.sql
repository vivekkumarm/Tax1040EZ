/*********************************************************************************************
Created by Ashok Kumar - 16th May, 2014 -  Persist Order and Order Billing Address records into DB.  
*********************************************************************************************/
/*Modification History*/
/* */

CREATE PROCEDURE usp_order_and_order_billing_address_persist
@user_data_id BIGINT,
@shopping_cart_id BIGINT,
@order_amount NUMERIC(22,2),
@card_number VARCHAR(50),
@cardtype_id INT,
@card_expires VARCHAR(10),
@processed BIT,
@time DATETIME,
@o_authorization VARCHAR(50),
@ip_address VARCHAR(50),
@name VARCHAR(50),
@email VARCHAR(50),
@street_address VARCHAR(50),
@apartment_number NVARCHAR(5),
@city VARCHAR(20),
@state_name VARCHAR(20),
@country_name VARCHAR(20) = null,
@phone VARCHAR(20),
@postcode VARCHAR(20)

AS

BEGIN

SET NOCOUNT ON;
BEGIN TRANSACTION
DECLARE @order_identity BIGINT
    
         INSERT INTO [dbo].[order]
         ( 
				[user_data_id],
				[shopping_cart_id],
				[order_amount],
				[card_number] ,
				[cardtype_id] ,
				[card_expires],
				[processed] ,
				[time] ,
				[o_authorization] ,
				[ip_address] ,
				[is_deleted] ,
				[create_timestamp],
				[update_timestamp]
          )
          
		  VALUES
          (
				@user_data_id,
				@shopping_cart_id ,
				@order_amount ,
				@card_number ,
				@cardtype_id ,
				@card_expires ,
				@processed ,
				@time ,
				@o_authorization ,
				@ip_address ,
				0,
				GETDATE(),
				GETDATE()
          )

	SET @order_identity=@@IDENTITY   
             
            INSERT INTO [dbo].[order_billing_address]
            (
                [order_id] ,
				[name] ,
				[email] ,
				[street_address] ,
				[apartment_number],
				[city] ,
				[state_name] ,
				[country_name] ,
				[phone] ,
				[postcode] ,
				[is_deleted] ,
				[create_datetime] ,
				[update_datetime] 
            )
            VALUES
            (           
				@order_identity,
				@name ,
				@email,
				@street_address,
				@apartment_number,
				@city ,
				@state_name,
				@country_name ,
				@phone ,
				@postcode,
				0,
				GETDATE(),
				GETDATE()
            )

			 UPDATE [dbo].[order_detail_mapper] SET [is_deleted] = 1
			 WHERE [shopping_cart_id] = @shopping_cart_id

			 UPDATE [dbo].[shopping_cart] SET [is_deleted] = 1
			 WHERE [shopping_cart_id] = @shopping_cart_id
                 
			 SELECT @order_identity

      IF @@ERROR = 0
        COMMIT TRANSACTION
      ELSE
        ROLLBACK TRANSACTION

SET NOCOUNT OFF;
END
