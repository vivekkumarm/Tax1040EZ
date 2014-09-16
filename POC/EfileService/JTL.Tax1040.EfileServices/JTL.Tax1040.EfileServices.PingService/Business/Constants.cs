using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.PingService
{
    public class Constants
    {
        public const string Login = "Login";
    }

    public class Stage
    {
        public const string SendSubmission = "SEND";
        public const string GetAcknowledgement = "GACK";
    }

    public class State
    {
        public const string Blank = "Blank";
        public const string Success = "Success";
        public const string Rejected = "Rejected";
        public const string Error = "Error";
        public const string Marked = "Marked";
    }

    public static class FormType
    {
        //public const string Form2290 = "2290";
        public const string Form7004 = "7004";
    }

    public static class TestMode
    {
        public const string Test = "T";
        public const string Prod = "P";
    }
}
