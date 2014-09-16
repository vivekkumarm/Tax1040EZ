
/*
Copyright   : Copyright Jeevan Technologies
File Name   : EmailData.cs 
Description : Business object for EmailData. 
Author      : Sathish Natarajan
Date        : 13 Mar 2014
Modification History:
---------------------
 */

namespace JTL.Tax1040.BusinessObject
{
  public  class EmailData
    {
      public string FromEmailID { get; set; }
      public string ToEmailID { get; set; }
      public string Subject { get; set; }
      public string TemplateName { get; set; }
      public string TemplateContent { get; set; }
    }
}
