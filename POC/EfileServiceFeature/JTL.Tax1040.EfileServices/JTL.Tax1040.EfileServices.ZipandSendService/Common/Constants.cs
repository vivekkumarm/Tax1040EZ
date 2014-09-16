using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public class Constants
    {
        public const string Login = "Login";

        //production mode
        public const string Production = "P";
        public const string ServerName = "DED4263";

        public const int ReceiveReturn = 1;
        public const int SchemaConversion = 2;
        public const int SchemaValidation = 3;
        public const int BusinessValidation = 4;
        public const int Zipp = 5;
        public const int Send = 6;
        public const int Ping = 7;
    }

    public class StatusCodes
    {
        public const int InsertedFromRecieveChannel = 1;
        public const int Converted2290XmlToIRSSchema = 2;
        public const int ZipCreatedAndReadyForSubmission = 3;
        public const int ZipSentToIRS = 4;
        public const int Success = 5;
        public const int UnSuccessToCreateZip = 6;
        public const int UnSuccessToSendEfile = 7;
        public const int RecievedAckFromIRS = 8;
        public const int FailedToGetAckFromIRS = 9;
        public const int RejectedFromIRS = 10;
        public const int IRSSubmissionAccepted = 11;
        public const int UnSuccessfulInConvertingIRSSchema = 12;
        public const int NoSubmissionFoundInIRS = 13;
        public const int EfilingSuccessful = 14;
        public const int EfilingSuccessfulAndRecievedSchedule1 = 15;
        public const int EmailedEfileErrorsToConcernPerson = 16;
        public const int EmailedSuccessfulEfilingReceipients = 17;
        public const int ErrorinSubmission = 18;
        public const int ErrorinSubmissionandErrorReturned = 19;
        public const int EfilingStatusSuccessfullySentToAppln = 20;

        //Login Status
        public const int SuccessfullLogin = 100;
        public const int UnSuccessfullLogin = 101;

        //LogOut Status
        public const int SuccessfullLogOut = 102;
        public const int UnSuccessfullLogOut = 103;
    }

    //public class Stage
    //{
    //    public const string Zip = "ZIPP";
    //    public const string SendSubmission = "SEND";
    //}

    //public class State
    //{
    //    public const string Blank = "Blank";
    //    public const string Success = "Success";
    //    public const string Error = "Error";
    //    public const string Marked = "Marked";
    //}
    public static class FormType
    {
        //public const string Form2290 = "2290";
        public const string Form1040EZ = "Form1040EZ";
    }

    public static class TestMode
    {
        public const string Test = "T";
        public const string Prod = "P";
    }
}
