/*
Copyright       : Copyright Jeevan Technologies
File Name       : CAOutputForms.cs
Description     : Business object for CA State. 
Author          : Rajadurai.S
Created Date    : 10 July 2014
 
Modification History:
---------------------
 
 */
namespace JTL.Tax1040.BusinessObject
{
    public class CAOutputForms
    {
        // CA540-2EZ Form
        public CA5402EZPage1 CA5402EZPage1 { get; set; }
        public CA5402EZPage2 CA5402EZPage2 { get; set; }
        public CA5402EZPage3 CA5402EZPage3 { get; set; }
        public CA5402EZPage4 CA5402EZPage4 { get; set; }

        // CA540 Form

        public CA540Page1 CA540Page1 { get; set; }
        public CA540Page2 CA540Page2 { get; set; }
        public CA540Page3 CA540Page3{ get; set; }
        public CA540Page4 CA540Page4 { get; set; }
        public CA540Page5 CA540Page5 { get; set; }
        
    }
}
