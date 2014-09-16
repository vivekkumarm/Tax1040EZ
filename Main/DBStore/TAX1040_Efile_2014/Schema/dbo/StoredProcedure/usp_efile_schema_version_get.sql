/*********************************************************************************************************
	CREATED BY: Praveen T				STORED PROCEDURE NAME: usp_efile_schema_version_get
	CREATED ON: 12 August 2014
*********************************************************************************************************/
CREATE PROCEDURE [dbo].[usp_efile_schema_version_get]
@return_type VARCHAR(50),
@tax_year VARCHAR(10),
@tax_period VARCHAR(50)

AS
BEGIN

    SELECT 
		[efile_schema_version_id],
		[schema_location] 
		FROM [dbo].[efile_schema_version] WITH(NOLOCK) 

    WHERE 
		(return_type=@return_type AND tax_year=@tax_year AND 
		tax_period=@tax_period AND is_deleted=0)

END
