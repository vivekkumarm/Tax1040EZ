/*********************************************************************************************************
	CREATED BY: Saravanan N.				STORED PROCEDURE NAME: usp_efile_control_get_on_form_type
	CREATED ON: 8th July, 2014
*********************************************************************************************************/

CREATE PROCEDURE [dbo].[usp_efile_control_get_on_form_type] 
    @FormType varchar(20)
AS

BEGIN
    SELECT 
        [form_type],
        [control_name],
        [control_value] 
    FROM [dbo].[efile_control] With(NoLock) 
    WHERE 
        [is_deleted] = 0 AND 
        form_type=@FormType
    
UNION ALL 

    SELECT 
        [form_type],
        'UserName' as ControlName,
        [user_name] as ControlValue 
    FROM 
        [dbo].[efile_irs_users] WITH(NOLOCK)  
    WHERE   [is_deleted] = 0 AND 
            [is_active] = 1 AND 
            [form_type] = @FormType 

UNION ALL 

    SELECT 
        [form_type],
        'Password' as ControlName ,
        [Password] as ControlValue 
    FROM 
        [dbo].[efile_irs_users] WITH(NOLOCK) 
    WHERE   [is_deleted] = 0 AND 
            [is_active] = 1 AND 
            [form_type] = @FormType 
UNION ALL 

    SELECT 
        [form_type],
        'EncryptKey' as ControlName ,
        [encrypt_key] as ControlValue 
    FROM 
        [dbo].[efile_irs_users] WITH(NOLOCK)  
    WHERE   [is_deleted] = 0 AND 
            [is_active] = 1 AND 
            [form_type] = @FormType 
END

