/*
Copyright       : Copyright Jeevan Technologies
File Name       : Audit.cs
Description     : Business object for Audit.
Author          : Bhavani Rajesh
Created Date    : 28 Aug 2014
 
Modification History:
---------------------
 
 */

namespace JTL.Tax1040.Core.Object
{
    public class Audit
    {
        public long UserId { get; set; }

        public long UserDataId { get; set; }
        
        public string IPAddress { get; set; }

        public string TabName { get; set; }

        public string TopicName { get; set; }

        public string Description { get; set; }

    }
}
