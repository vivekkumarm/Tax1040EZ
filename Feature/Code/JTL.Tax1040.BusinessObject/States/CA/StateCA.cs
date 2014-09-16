/*
Copyright       : Copyright Jeevan Technologies
File Name       : StateCA.cs
Description     : Business object for state. 
Author          : Sathish.S
Created Date    : 25 Jul 2014
 
Modification History:
---------------------
 * 03 Sep 2014, Bala, Moved StateCA BO class into CA folder and created CA basicInfo, adjustment, credits and taxesandwrapup BO objects in StateCA BO
 */
namespace JTL.Tax1040.BusinessObject
{
    public class StateCA
    {
        public CABasicInfo BasicInfo { get; set; }
        public CAAdjustments Adjustments { get; set; }
        public CACredits Credits { get; set; }
        public CATaxesAndWrapup TaxesAndWrapup { get; set; }
    }
}
