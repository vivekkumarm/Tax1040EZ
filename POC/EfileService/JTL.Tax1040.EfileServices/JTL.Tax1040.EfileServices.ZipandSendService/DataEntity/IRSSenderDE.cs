using System;
using System.Collections.Generic;
using System.Text;

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public class IRSSenderDE
    {

        public string UserName
        {
            get;
            set;
        }

        private string _SubmissionID;

        public string SubmissionID
        {
            get { return _SubmissionID; }
            set { _SubmissionID = value; }
        }

        private int _StatusID;

        public int StatusID
        {
            get { return _StatusID; }
            set { _StatusID = value; }
        }

        private string _RequestXML;

        public string RequestXML
        {
            get { return _RequestXML; }
            set { _RequestXML = value; }
        }

        private string _ResponseXML;

        public string ResponseXML
        {
            get { return _ResponseXML; }
            set { _ResponseXML = value; }
        }

        private string _MessageID;

        public string MessageID
        {
            get { return _MessageID; }
            set { _MessageID = value; }
        }

        private byte[] _SendSubmissionStatus;

        public byte[] SendSubmissionStatus
        {
            get { return _SendSubmissionStatus; }
            set { _SendSubmissionStatus = value; }
        }

        private string _serviceaction;

        public string ServiceAction
        {
            get { return _serviceaction; }
            set { _serviceaction = value; }
        }

        //Error
        private IRSErrorDE _Error;

        public IRSErrorDE Error
        {
            get { return _Error; }
            set { _Error = value; }
        }
    }

    public class IRSErrorDE
    {
        private bool _IsErrorPresent;

        public bool IsErrorPresent
        {
            get { return _IsErrorPresent; }
            set { _IsErrorPresent = value; }
        }

        private string _ErrorCode;

        public string ErrorCode
        {
            get { return _ErrorCode; }
            set { _ErrorCode = value; }
        }

        private string _ErrorMessage;

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
            set { _ErrorMessage = value; }
        }

        private string _ErrorClassification;

        public string ErrorClassification
        {
            get { return _ErrorClassification; }
            set { _ErrorClassification = value; }
        }

        private string _Action;

        public string Action
        {
            get { return _Action; }
            set { _Action = value; }
        }


    }
}
