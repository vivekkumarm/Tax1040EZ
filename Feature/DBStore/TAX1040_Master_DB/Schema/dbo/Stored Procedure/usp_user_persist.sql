/*****************************************************************************************
Created by Balasubramanian Velmurugan - 12 March 2014 -  Procedure to persist User Details
Modified by Sathish - 18 March 2014 - changed security question varchar to int
******************************************************************************************/

CREATE PROCEDURE [dbo].[usp_user_persist] 
(
@email NVARCHAR(100),
@username NVARCHAR(100),
@password NVARCHAR(100),
@salt NVARCHAR(100),
@security_question_id int,
@security_answer NVARCHAR(100),
@client_IP NVARCHAR(20),
@username_exist BIT OUTPUT,
@email_exist BIT OUTPUT
)
AS
BEGIN
SET NOCOUNT ON;

SET @username_exist = 0
SET @email_exist = 0

IF NOT EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)
	   WHERE [username]=@username)

BEGIN
       IF NOT EXISTS(SELECT 1 FROM [dbo].[user] WITH(NOLOCK)
	   WHERE [email]=@email)
       BEGIN
       INSERT INTO  [dbo].[user] 
              (
              [email],
              [username],
              [password],
              [salt],
              [security_question_id],
              [security_answer],
              [client_IP]
              )
              VALUES
              (
              @email,
              @username,
              @password,
              @salt,
              @security_question_id,
              @security_answer,
              @client_IP
              )   
       SELECT @@IDENTITY AS 'user_id'
       END
       ELSE
       BEGIN
              SET @username_exist=0
              SET @email_exist=1
              SELECT 0 AS 'user_id'
       END
END
ELSE
BEGIN
       SET @username_exist=1
       SELECT @email_exist = COUNT(*) FROM [dbo].[user] WITH(NOLOCK)
	   WHERE [email]=@email
       SELECT 0 AS 'user_id'
END
SET NOCOUNT OFF;
END