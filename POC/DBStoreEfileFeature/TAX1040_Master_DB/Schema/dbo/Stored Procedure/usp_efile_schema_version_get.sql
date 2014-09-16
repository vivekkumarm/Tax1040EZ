CREATE Procedure [dbo].[usp_efile_schema_version_get]
@return_type VARCHAR(50),
@tax_year VARCHAR(10),
@tax_period VARCHAR(50)
AS
BEGIN
    SELECT efile_schema_version_id,schema_location FROM efile_schema_version WITH(NOLOCK) 
    WHERE return_type=@return_type and tax_year=@tax_year and 
    tax_period=@tax_period and is_deleted=0
END
