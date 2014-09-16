/* 21Jul2014 Sathish Added Referral Rating*/

using System.Collections.Generic;
namespace JTL.Tax1040.BusinessObject
{
   public class ReferralRating
    {
        public UserRating UserRating { get; set; }
        public List<UserReferral> UserReferral { get; set; } // 22Jul2014 sathish changed to list multiple user referral
    }
}
