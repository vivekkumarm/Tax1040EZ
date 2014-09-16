/*********************************************************************************************
Created by Ashok Kumar - 2nd June, 2014 -  Function that returns list of States in the Form of a Table based
on the StatesIds given as input in the String format with comma seperator
*********************************************************************************************/
/* Modification History */
/* */
CREATE FUNCTION [dbo].[SplitString]
(
 @String varchar(8000),
 @Delimiter char(1)
)
 returns
 @temptable TABLE (items varchar(100))
AS
BEGIN
     DECLARE @idx int       
     DECLARE @slice varchar(8000)       

     Select @idx = 1       
         if len(@String)<1 or @String is null  return       

     while @idx!= 0       
     BEGIN       
         set @idx = charindex(@Delimiter,@String)       
         if @idx!=0       
             set @slice = left(@String,@idx - 1)       
         else       
             set @slice = @String       

         if(len(@slice)>0)  
             Insert into @temptable(Items) values(@slice)       

         set @String = right(@String,len(@String) - @idx)       
         if len(@String) = 0 break       
     END   
  return 
END
