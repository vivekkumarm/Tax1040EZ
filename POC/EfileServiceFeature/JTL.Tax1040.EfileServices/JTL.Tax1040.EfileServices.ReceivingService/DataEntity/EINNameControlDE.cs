using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class EINNameControlValidation
    {
        private List<EINNameControlDE> _EINnameControl;

        public List<EINNameControlDE> EINnameControl
        {
            get { return _EINnameControl; }
            set { _EINnameControl = value; }
        }
    }

    public class EINNameControlDE
    {
        private string _NameControl;

        public string NameControl
        {
            get { return _NameControl; }
            set { _NameControl = value; }
        }

        private string _EIN;

        public string EIN
        {
            get { return _EIN; }
            set { _EIN = value; }
        }
    }
}