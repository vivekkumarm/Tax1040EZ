/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : IRSTransmission.cs
Description                 : Contains Properties related Efiling Process.
Author                      : Ashok Kumar
Created Date                : 15thApr2014
 
Modification History:
---------------------
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.BusinessObject
{
    public class IRSTransmission
    {
        //Primary Tax Payer
        //Already available in Tax8879Page1 Object. Can be removed after discussion
        //public string PrimaryPIN { get; set; }
        //public bool IsPrimaryPINSpecified { get; set; }

        public string PrimaryPriorYearPIN { get; set; }
        public bool IsPrimaryPriorYearPINSpecified { get; set; }

        public string PrimaryPriorYearEfilePIN { get; set; }
        public bool IsPrimaryPriorYearEfilePINSpecified { get; set; }

        //Already available in Person Object. Can be removed after discussion
        //public DateTime PrimaryDateOfBirth { get; set; }
        //public bool IsPrimaryDOBSpecified { get; set; }

        public double PrimaryPriorYearAGI { get; set; }
        public bool IsPrimaryPriorYearAGISpecified { get; set; }

        //Spouse
        //Already available in Tax8879Page1 Object. Can be removed after discussion
        //public string SpousePIN { get; set; }
        //public bool IsSpousePINSpecified { get; set; }

        public string SpousePriorYearPIN { get; set; }
        public bool IsSpousePriorYearPINspecified { get; set; }


        public string SpousePriorYearEfilePIN { get; set; }
        public bool IsSpousePriorYearEfilePINspecified { get; set; }

        //Already available in Person Object. Can be removed after discussion
        //public DateTime SpouseDateOfBirth { get; set; }
        //public bool IsSpouseDOBSpecifiedSpecified { get; set; }

        public double SpousePriorYearAGI { get; set; }
        public bool IsSpousePriorYearAGISpecified { get; set; }

        public string DayTimePhone { get; set; }
        public byte[] Form8879 { get; set; }

        public string IPAddress { get; set; }
    }
}
