using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class IRSSchemaDE
    {
        private int _EfileIRSSchemaID;

        public int EfileIRSSchemaID
        {
            get { return _EfileIRSSchemaID; }
            set { _EfileIRSSchemaID = value; }
        }

        private int _EfileHoldID;

        public JTL.Tax1040.BusinessObject.Tax1040 Tax1040
        {
            get;
            set;
        }

        public int EfileHoldID
        {
            get { return _EfileHoldID; }
            set { _EfileHoldID = value; }
        }

        private string _EfileIRSSchema;

        public string EfileIRSSchema
        {
            get { return _EfileIRSSchema; }
            set { _EfileIRSSchema = value; }
        }


        private int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        private string formtype;

        public string FormType
        {
            get { return formtype; }
            set { formtype = value; }
        }


        private string _IRSSubmissionManifest;

        public string IRSSubmissionManifest
        {
            get { return _IRSSubmissionManifest; }
            set { _IRSSubmissionManifest = value; }
        }

        private string _SubmissionId;

        public string SubmissionId
        {
            get { return _SubmissionId; }
            set { _SubmissionId = value; }
        }

        private string _returnID;

        public string ReturnID
        {
            get { return _returnID; }
            set { _returnID = value; }
        }

        private string _AttachmentsCount;

        public string AttachmentsCount
        {
            get { return _AttachmentsCount; }
            set { _AttachmentsCount = value; }
        }

        private string _VendorXML;

        public string VendorXML
        {
            get { return _VendorXML; }
            set { _VendorXML = value; }
        }

        private bool _IsIRSSchemaConverted;

        public bool IsIRSSchemaConverted
        {
            get { return _IsIRSSchemaConverted; }
            set { _IsIRSSchemaConverted = value; }
        }

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private string stage;

        public string Stage
        {
            get { return stage; }
            set { stage = value; }
        }

        private bool _IsManifestGenerated;

        public bool IsManifestGenerated
        {
            get { return _IsManifestGenerated; }
            set { _IsManifestGenerated = value; }
        }

        private string _Originator_EFIN;

        public string Originator_EFIN
        {
            get { return _Originator_EFIN; }
            set { _Originator_EFIN = value; }
        }

        private int _NoOfCreditsAttachments;

        public int NoOfCreditsAttachments
        {
            get { return _NoOfCreditsAttachments; }
            set { _NoOfCreditsAttachments = value; }
        }

        private int _NoOfSuspendedAttachments;

        public int NoOfSuspendedAttachments
        {
            get { return _NoOfSuspendedAttachments; }
            set { _NoOfSuspendedAttachments = value; }
        }

        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        //added tax year and tax period in tax schema object.
        private string _TaxYear;

        public string TaxYear
        {
            get { return _TaxYear; }
            set { _TaxYear = value; }
        }

        private string _TaxPeriod;

        public string TaxPeriod
        {
            get { return _TaxPeriod; }
            set { _TaxPeriod = value; }
        }

        private string _IRSUserName;

        public string IRSUserName
        {
            get { return _IRSUserName; }
            set { _IRSUserName = value; }
        }
    }
}