using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.Core.Process
{
    public class EfileConstants
    {
    }

    public static class Stage
    {
        public const int ReceiveReturn = 1;
        public const int SchemaConversion = 2;
        public const int SchemaValidation = 3;
        public const int BusinessValidation = 4;
        public const int Zip = 5;
        public const int Send = 6;
        public const int Ping = 7;

        // Swapnesh  Constant to Status

        //     public const string Zip = "ZIPP";
        //public const string SendSubmission = "SEND";
    }
}
