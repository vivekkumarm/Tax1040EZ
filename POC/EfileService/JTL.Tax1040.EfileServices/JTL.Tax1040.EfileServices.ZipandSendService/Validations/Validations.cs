using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    public class Validations
    {
        #region Constants
        const int ConstIntZero = 0;
        const int ConstIntOne = 1;
        const int ConstIntTwo = 2;
        const int ConstIntThree = 3;
        const int ConstIntFour = 4;
        const int ConstIntSix = 6;
        const int ConstIntTwenty = 20;
        const int ConstIntSixtyFour = 64;

        const string ConstString00800 = "00800";
        const string ConstString20500 = "20500";
        const string ConstString34000 = "34000";
        const string ConstString00600 = "00600";
        const string ConstString96100 = "96100";
        const string ConstString96900 = "96900";
        const string ConstString00 = "00";
        const char ConstCharZero = '0';
        const char ConstCharNine = '9';

        const char ConstCharDot = '.';
        const string ConstStringZip = "zip";

        #region ErrorType
        internal class ErrorType
        {
            public const string ApplicationError = "APPLICATION_ERROR";
        }
        #endregion

        #region ErrorTypeErrorCode
        internal class ErrorCode
        {
            #region 57-80
            public const string IRSAPPCON000057 = "IRSAPPCON000057";
            public const string IRSAPPCON000058 = "IRSAPPCON000058";
            public const string IRSAPPCON000059 = "IRSAPPCON000059";
            public const string IRSAPPCON000060 = "IRSAPPCON000060";
            public const string IRSAPPCON000061 = "IRSAPPCON000061";
            public const string IRSAPPCON000062 = "IRSAPPCON000062";
            public const string IRSAPPCON000063 = "IRSAPPCON000063";
            public const string IRSAPPCON000064 = "IRSAPPCON000064";
            public const string IRSAPPCON000065 = "IRSAPPCON000065";
            public const string IRSAPPCON000066 = "IRSAPPCON000066";
            public const string IRSAPPCON000067 = "IRSAPPCON000067";
            public const string IRSAPPCON000068 = "IRSAPPCON000068";
            public const string IRSAPPCON000069 = "IRSAPPCON000069";
            public const string IRSAPPCON000070 = "IRSAPPCON000070";
            public const string IRSAPPCON000071 = "IRSAPPCON000071";
            public const string IRSAPPCON000072 = "IRSAPPCON000072";
            public const string IRSAPPCON000073 = "IRSAPPCON000073";
            public const string IRSAPPCON000074 = "IRSAPPCON000074";
            public const string IRSAPPCON000075 = "IRSAPPCON000075";
            public const string IRSAPPCON000076 = "IRSAPPCON000076";
            public const string IRSAPPCON000077 = "IRSAPPCON000077";
            public const string IRSAPPCON000078 = "IRSAPPCON000078";
            public const string IRSAPPCON000079 = "IRSAPPCON000079";
            public const string IRSAPPCON000080 = "IRSAPPCON000080";
            #endregion
            #region 81-93
            public const string IRSAPPCON000081 = "IRSAPPCON000081";
            public const string IRSAPPCON000082 = "IRSAPPCON000082";
            public const string IRSAPPCON000083 = "IRSAPPCON000083";
            public const string IRSAPPCON000084 = "IRSAPPCON000084";
            public const string IRSAPPCON000085 = "IRSAPPCON000085";
            public const string IRSAPPCON000086 = "IRSAPPCON000086";
            public const string IRSAPPCON000087 = "IRSAPPCON000087";
            public const string IRSAPPCON000088 = "IRSAPPCON000088";
            public const string IRSAPPCON000089 = "IRSAPPCON000089";
            public const string IRSAPPCON000090 = "IRSAPPCON000090";
            public const string IRSAPPCON000091 = "IRSAPPCON000091";
            public const string IRSAPPCON000092 = "IRSAPPCON000092";
            public const string IRSAPPCON000093 = "IRSAPPCON000093";
            #endregion
        }
        #endregion

        #endregion

        #region Declarations
        List<MessagesDE> listMessagesDE;
        MessagesDE messagesDE;
        #endregion

        #region Constructor
        public Validations()
        {
            listMessagesDE = new List<MessagesDE>();
        }
        #endregion

        #region Is Distinct
        public MessagesDE IsDistinct(List<string> attachments)
        {
            foreach (string attachment1 in attachments)
            {
                foreach (string attachment2 in attachments)
                {
                    if (attachment1 == attachment2)
                    {
                        messagesDE = new MessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IRSAPPCON000058;
                        messagesDE.ErrorCategory = ErrorType.ApplicationError;
                        return messagesDE;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Is Unique
        public MessagesDE IsUnique(List<string> fileNames)
        {
            foreach (string fileName1 in fileNames)
            {
                foreach (string fileName2 in fileNames)
                {
                    if (fileName1 == fileName2)
                    {
                        messagesDE = new MessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IRSAPPCON000089;
                        messagesDE.ErrorCategory = ErrorType.ApplicationError;
                        return messagesDE;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Validate Attachment Name
        public MessagesDE ValidateAttachmentName(List<string> attachments)
        {
            foreach (string attachment in attachments)
            {
                string attachmentName = string.Empty;
                if (null != ConfigurationManager.AppSettings["AttachmentFolderName"])
                {

                }
                attachmentName = attachment.Replace(ConfigurationManager.AppSettings["AttachmentFolderName"].ToString(), "");
                int attachmentNameSize = System.Text.Encoding.Unicode.GetBytes(attachmentName).Length;
                if (ConstIntSixtyFour < attachmentNameSize)
                {
                    messagesDE = new MessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IRSAPPCON000058;
                    messagesDE.ErrorCategory = ErrorType.ApplicationError;
                    return messagesDE;
                }
            }
            return null;
        }
        #endregion

    }
}
