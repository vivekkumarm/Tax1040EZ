using System;
using System.Collections.Generic;
using System.Text;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public static class Status
    {
        public const int InsertedFromRecieveChannel = 1;
        public const int Converted1040EZXmlToIRSSchema = 2;
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

    public class Stage
    {
        public const string Initial = "INIT";
        public const int SchemaConversion = 2;
        public const int SchemaValidation = 3;
        public const int BusinessValidation = 4;
        public const string SchemaConversionText = "CONV";
        public const string XVAL = "XVAL";
        public const string CONV = "CONV";

       // public const int ReceiveReturn = 1;

        public const string IRSSchemaValidation = "XVAL";
        public const string BusinessValidationVAL = "BVAL";
    }

    public class State
    {
        public const string Blank = "Blank";
        public const string Success = "Success";
        public const string InProgress = "InProgress";
        public const string Error = "Error";
    }

    public enum FormCode
    {
        Form7004 = 4,
        Form8868 = 5,
        Form4868 = 6,
        Form2350 = 7,

         FormTax1040EZ = 8,
    }
}