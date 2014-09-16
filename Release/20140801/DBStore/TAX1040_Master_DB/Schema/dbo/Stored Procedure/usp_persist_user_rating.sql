/*************************************************************************************************
Created by Sathish on 18Jul2014 procedure persist user rating
**************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_persist_user_rating]
@user_id BIGINT,
@rating TINYINT,
@comment VARCHAR(300)
AS
BEGIN 
	SET NOCOUNT ON;

		IF EXISTS(SELECT 1 FROM [dbo].[user_rating] WITH(NOLOCK) 
			WHERE [user_id]=@user_id
				AND [is_active] = 1)
		BEGIN
			UPDATE [dbo].[user_rating] 
			SET [rating] = @rating,
				[comment] = @comment
			WHERE [user_id] = @user_id
		END
		ELSE
		BEGIN
			INSERT INTO  [dbo].[user_rating]([user_id],
											 [rating],
											 [comment]) 
			VALUES(@user_id,
					@rating,
					@comment)
		END
	SET NOCOUNT OFF;
END