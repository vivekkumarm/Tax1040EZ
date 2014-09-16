using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public static class Status
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
    }

    public static class Stage
    {
        public const string BVAL = "BVAL";
        public const string Zip = "ZIPP";

        // Swapnesh  Constant to Status

   //     public const string Zip = "ZIPP";
        public const string SendSubmission = "SEND";
    }
    public static class State
    {
        public const string Success = "Success";
        public const string Blank = "Blank";
        public const string Error = "Error";

        public const string Marked = "Marked";
    }
}
