/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Income.cs 
    Description     :   Business object for Income DTO 
    Author          :   Ashok Kumar 
    Created Date    :   29 May 2014

    Modification History:
    ---------------------
 */


namespace JTL.Tax1040.BusinessObject
{
    public class IncomeDTO
    {
        public bool HasW2Wages { get; set; }

        public bool HasInterestIncome { get; set; }

        public bool HasUnemploymentCompensation { get; set; }

        public bool HasOtherIncome { get; set; }

        public int W2WagesCount { get; set; }

        public int Form1099INTCount { get; set; }

        public int Form1099OIDCount { get; set; }

        public int Form1099GCount { get; set; }

        public int OtherIncomeCount { get; set; }

        public string NickName { get; set; }

        public long UserId { get; set; }

        public long UserDataId { get; set; }
    }
}
