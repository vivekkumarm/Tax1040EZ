using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.TAX1040.Admin.BusinessObject
{
   public class PersonalInfo
    {
        public string FirstName { get; set; }
        public char? MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Occupation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SSN { get; set; }
        public bool? IsPersonalRepresentative { get; set; }
        public bool? IsBankruptcyDebtor { get; set; }

        public string NameControl { get; set; }
   }
}
