using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JTL.Tax1040.IRSObject;
using System.Data;
using JTL.Tax1040.BusinessObject;
using System.Configuration;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
using JTL.Tax1040.Core;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class Tax1040EZConversion_TY2014
    {
        #region Global Declarations
        string SoftwareId = string.Empty;
        string SoftwareVersion = string.Empty;
        int efileHoldId = 0;
        string strNameControl = string.Empty;
        int documentCount = 0;
        #endregion


        public IRSSchemaDE CreateTax1040EZchema(IRSSchemaDE objIRSSchemaDE)
        {
            if (objIRSSchemaDE != null)
            {
                if (objIRSSchemaDE.EfileHoldID > 0)
                {
                    efileHoldId = objIRSSchemaDE.EfileHoldID;
                }

                //declare return object
                Return objReturn1040EZ = new Return();
                TaxXMLtoIRSSchemaBL objTaxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
                // DataSet dsAttachments = objTaxXMLtoIRSSchemaBL.GetVendorAttachments(objIRSSchemaDE.EfileHoldID);


                //create tax engine object from xml
                // JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO = (JTL.Tax1040.BusinessObject.Tax1040)Utilities.DeSerialize(objIRSSchemaDE.VendorXML, typeof(JTL.Tax1040.BusinessObject.Tax1040));

                // Create tax engine object from Json string
                //  JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO = objIRSSchemaDE.Tax1040;// JsonConvert.DeserializeObject<JTL.Tax1040.BusinessObject.Tax1040>(objIRSSchemaDE.VendorXML);

                //verify object reference
                if (objIRSSchemaDE.Tax1040 != null)
                {
                    //getting softwareid and version from the config file
                    SoftwareId = ConfigurationManager.AppSettings["Tax1040EZ_SoftwareId_TY2014"].ToString();
                    SoftwareVersion = Utilities.GetSoftwareVersion();

                    // Get submission count
                    long TodaysCountforSubmissionId = objTaxXMLtoIRSSchemaBL.GetTodayCount();

                    //calculate submission id
                    objIRSSchemaDE.SubmissionId = Utilities.GetSubmissionID(objIRSSchemaDE.Originator_EFIN,
                                                                            (int)FormCode.FormTax1040EZ,
                                                                            objIRSSchemaDE.IRSUserName,
                                                                            TodaysCountforSubmissionId);
                    //call return header create
                    objReturn1040EZ.ReturnHeader = CreateReturnHeader(objIRSSchemaDE.Tax1040, objIRSSchemaDE);

                    //Create return data
                    objReturn1040EZ.ReturnData = CreateReturnData(objIRSSchemaDE.Tax1040, objIRSSchemaDE);

                    //assign document count.
                    // need to remove for schema validation
                    if (documentCount == 0)
                    {
                        documentCount = 1;
                    }
                    objReturn1040EZ.ReturnData.documentCnt = documentCount.ToString();
                    //assign conversion status.
                    objIRSSchemaDE.EfileIRSSchema = Utilities.Serialize(objReturn1040EZ);
                    objIRSSchemaDE.IsIRSSchemaConverted = true;
                }
                //return object 
                return objIRSSchemaDE;
            }
            return null;
        }


        #region Create ReturnHeader

        private ReturnHeaderType CreateReturnHeader(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO, IRSSchemaDE objIRSSchemaDE)
        {
            //Create instance for Return Header and assign attachment count.
            ReturnHeaderType objReturnHeader = new ReturnHeaderType();

            //TimeStamp
            DateTime CurrentDate;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss zzz");
            DateTime.TryParse(currentDate, out CurrentDate);
            objReturnHeader.ReturnTs = CurrentDate;

            objReturnHeader.TaxYr = "2014";

            string Month = string.Empty;

            // Doubt 1 Swapnesh
            //if (objTax1040BO.Tax4868BO.CalendarYear > 0)
            //{
            // Discussed and this is not needed as per discussion with BA
            objReturnHeader.TaxPeriodBeginDt = Convert.ToDateTime("01/01/2014");
            objReturnHeader.TaxPeriodEndDt = Convert.ToDateTime("12/31/2014");
            //}

            // need to analysis
            // **   objReturnHeader.ImperfectReturnInd = objTax1040BO.im TODO Not available in Existing Efile services CheckboxType
            // **   objReturnHeader.ImperfectReturnIndSpecified = objTax1040BO TODO Not available in Existing Efile services 

            // **
            //  objReturnHeader.ConsortiumReturnCd =objTax1040BO.TODO . It is Optional – Checked with 4868 and 2350 ENUM
            // **      objReturnHeader.ConsortiumReturnCdSpecified =objTax1040BO. TODO . It is Optional – Checked with 4868 and 2350 ENUM

            // **
            //     objReturnHeader.AffordableFilingCd = TODO Not available in Existing Efile services ENUM
            // **     objReturnHeader.AffordableFilingCdSpecified = TODO Not available in Existing Efile services

            // **
            // objReturnHeader.ISPNum=objTax1040BO. TODO It is Optional – Checked with  2290

            objReturnHeader.SoftwareId = SoftwareId;
            objReturnHeader.SoftwareVersionNum = SoftwareVersion;

            //assigning Originator
            objReturnHeader.OriginatorGrp = CreateOriginator(objTax1040BO);

            //assigning SelfSelectPINGrp Modified by Ashok Kumar
            objReturnHeader.SelfSelectPINGrp = CreateSelfSelectPINGrp(objTax1040BO);

            //TODO - Ashok Kumar
            // need to confirm with BA (we should collect this info from Client. Need to Discuss further on Object Placing)
            // ** objReturnHeader.IdentityProtectionPIN=objTax1040BO.PersonalDetails.Spouse.Person.
            // ** objReturnHeader.SpouseIdentityProtectionPIN

            // ** PINTypeCd
            //TODO - Ashok Kumar Based on IRS Payment Option we have to bind this value - binded comparing both Exisiting 2350 and 4868 Efile Services
            objReturnHeader.PINTypeCd = PINCodeType.SelfSelectOnLine;

            //    //assigning JuratDisclosureCode
            //TODO - Ashok Kumar need to confirm  with 2290  3 Options available - Can be checked while transmitting to IRS while Testing
            objReturnHeader.JuratDisclosureCd = ReturnHeaderTypeJuratDisclosureCd.OnlineSelfSelectPIN;

            //binded comparing both Exisiting 2350 and 4868 Efile Services 
            objReturnHeader.PrimaryPINEnteredByCd = PINEnteredByType.Taxpayer;
            objReturnHeader.PrimaryPINEnteredByCdSpecified = true;

            //binded comparing both Exisiting 2350 and 4868 Efile Services 
            objReturnHeader.SpousePINEnteredByCd = PINEnteredByType.Taxpayer;
            objReturnHeader.SpousePINEnteredByCdSpecified = true;

            //Modified by Ashok after Object finalization
            //Assign Signature PIN
            if (objTax1040BO.Filing != null && objTax1040BO.Filing.FederalFiling != null && objTax1040BO.Filing.FederalFiling.IRS != null && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission != null)
            {
                if (!string.IsNullOrEmpty(objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerIPIN))
                {
                    objReturnHeader.PrimarySignaturePIN = objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerIPIN;
                    objReturnHeader.PrimarySignatureDt = DateTime.Now;
                    objReturnHeader.PrimarySignatureDtSpecified = true;
                }

                if (objTax1040BO.OutputForms.Tax8879Page1 != null && !string.IsNullOrEmpty(objTax1040BO.OutputForms.Tax8879Page1.SpousePIN))
                {
                    objReturnHeader.SpouseSignaturePIN = objTax1040BO.OutputForms.Tax8879Page1.SpousePIN;
                    objReturnHeader.SpouseSignatureDt = DateTime.Now;
                    objReturnHeader.SpouseSignatureDtSpecified = true;
                }
            }

            //assigninig return type
            objReturnHeader.ReturnTypeCd = ReturnHeaderTypeReturnTypeCd.Item1040EZ;

            //assigning Filer
            objReturnHeader.Filer = CreateFiler(objTax1040BO);

            // need to discuss with UMA  this is only for cpa
            objReturnHeader.PaidPreparerInformationGrp = CreatePaidPreparerInformationGrp(objTax1040BO);


            //  ** need to do
            //IPAddressType ipaddress = new IPAddressType();
            //ipaddress.Item = objTax1040BO.IRSTransmission.IPAddress;
            //objReturnHeader.IPAddress = ipaddress;


            //**  need to clarify
            ReturnHeaderTypeOnlineFilerInformation retonlinefiler = new ReturnHeaderTypeOnlineFilerInformation();
            // ** retonlinefiler.DepositorAccountNum
            //**  retonlinefiler.EmailAddressTxt
            //**   retonlinefiler.Item

            objReturnHeader.OnlineFilerInformation = retonlinefiler;


            //objReturnHeader.Form8283PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form8283PaperDocumentIndSpecified = true;

            //objReturnHeader.Form8858PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form8858PaperDocumentIndSpecified = true;

            //objReturnHeader.Form8332PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form8332PaperDocumentIndSpecified = true;

            //objReturnHeader.Form3468PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form3468PaperDocumentIndSpecified = true;

            //objReturnHeader.Form3115PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form3115PaperDocumentIndSpecified = true;

            //objReturnHeader.Form5713PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form5713PaperDocumentIndSpecified = true;
            //objReturnHeader.Form1098CPaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form1098CPaperDocumentIndSpecified = true;
            //objReturnHeader.Form8885PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form8885PaperDocumentIndSpecified = true;
            //objReturnHeader.Form8864PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form8864PaperDocumentIndSpecified = true;
            //objReturnHeader.Form4136PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form4136PaperDocumentIndSpecified = true;
            //objReturnHeader.POAPaperDocumentInd = CheckboxType.X;
            //objReturnHeader.POAPaperDocumentIndSpecified = true;
            //objReturnHeader.Form8949PaperDocumentInd = CheckboxType.X;
            //objReturnHeader.Form8949PaperDocumentIndSpecified = true;

            // Swapnesh  need to do 
            objReturnHeader.binaryAttachmentCnt = "0";

            return objReturnHeader;
        }


        #region Get BusinessEIN

        private string GetBusinessSSNOREIN(string ssn)
        {
            string SSN = string.Empty;

            if (!string.IsNullOrEmpty(ssn))
            {
                SSN = Utilities.RemoveHyphens(ssn);
            }


            return SSN;
        }

        #endregion

        #region Create Originator

        private ReturnHeaderTypeOriginatorGrp CreateOriginator(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            ReturnHeaderTypeOriginatorGrp originator = new ReturnHeaderTypeOriginatorGrp();


            if (null != ConfigurationManager.AppSettings["originator_EFIN"])
            {
                originator.EFIN = ConfigurationManager.AppSettings["originator_EFIN"].ToString();
            }

            //Ashok Kumar- Mapped by comparing existing Efile services
            originator.OriginatorTypeCd = OriginatorType.ERO;

            ReturnHeaderTypeOriginatorGrpPractitionerPINGrp practitionerPIN = new ReturnHeaderTypeOriginatorGrpPractitionerPINGrp();
            if (null != ConfigurationManager.AppSettings["originator_EFIN"])
            {
                practitionerPIN.EFIN = ConfigurationManager.AppSettings["originator_EFIN"].ToString();
            }

            practitionerPIN.PIN = ConfigurationManager.AppSettings["practitioner_PIN"].ToString();
            originator.PractitionerPINGrp = practitionerPIN;


            return originator;
        }
        #endregion

        #region Create SelfSelectPINGrp
        //Added by Ashok kumar
        private ReturnHeaderTypeSelfSelectPINGrp CreateSelfSelectPINGrp(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            //Modified by Ashok Kumar after Object Finalization
            ReturnHeaderTypeSelfSelectPINGrp returnHeaderTypeSelfSelectPIN = new ReturnHeaderTypeSelfSelectPINGrp();

            if (objTax1040BO.PersonalDetails.PrimaryTaxPayer != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person != null)
            {
                if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth != DateTime.MinValue)
                {
                    returnHeaderTypeSelfSelectPIN.PrimaryBirthDt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth;
                    returnHeaderTypeSelfSelectPIN.PrimaryBirthDtSpecified = true;
                }

                if (objTax1040BO.Filing != null && objTax1040BO.Filing.FederalFiling != null && objTax1040BO.Filing.FederalFiling.IRS != null && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission != null)
                {
                    if (objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearPIN.HasValue && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearPIN.Value) // IsPrimaryPriorYearPINSpecified)
                    {
                        returnHeaderTypeSelfSelectPIN.PrimaryPriorYearPIN = objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.PrimaryPriorYearPIN;
                    }
                    //else if (objTax1040BO.IRSTransmission.)  //IsPrimaryPriorYearEfilePINSpecified)
                    //{
                    //    returnHeaderTypeSelfSelectPIN.PrimaryPriorYearPIN = objTax1040BO.IRSTransmission.PrimaryPriorYearEfilePIN;
                    //}

                    if (objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearAGI.HasValue && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearAGI.Value) //IsPrimaryPriorYearAGISpecified)
                    {
                        returnHeaderTypeSelfSelectPIN.PrimaryPriorYearAGIAmt = objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.PrimaryPriorYearAGI.ToString();
                    }

                }
                if (objTax1040BO.OutputForms != null && objTax1040BO.OutputForms.Tax8879Page1 != null)
                {
                    if (!string.IsNullOrEmpty(objTax1040BO.OutputForms.Tax8879Page1.TaxPayerPIN))
                    {
                        returnHeaderTypeSelfSelectPIN.PrimaryElectronicFilingPIN = objTax1040BO.OutputForms.Tax8879Page1.TaxPayerPIN;
                    }
                }
            }

            if (objTax1040BO.PersonalDetails.Spouse != null && objTax1040BO.PersonalDetails.Spouse.Person != null)
            {
                if (objTax1040BO.PersonalDetails.Spouse.Person.DateOfBirth != DateTime.MinValue)
                {
                    returnHeaderTypeSelfSelectPIN.SpouseBirthDt = objTax1040BO.PersonalDetails.Spouse.Person.DateOfBirth;
                    returnHeaderTypeSelfSelectPIN.SpouseBirthDtSpecified = true;
                }
                if (objTax1040BO.Filing != null && objTax1040BO.Filing.FederalFiling != null && objTax1040BO.Filing.FederalFiling.IRS != null && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission != null)
                {
                    if (objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearPIN.HasValue && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearPIN.Value)//IsSpousePriorYearPINspecified)
                    {
                        returnHeaderTypeSelfSelectPIN.SpousePriorYearPIN = objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.SpousePriorYearPIN;
                    }
                    //else if (objTax1040BO.IRSTransmission.IsSpousePriorYearEfilePINspecified)
                    //{
                    //    returnHeaderTypeSelfSelectPIN.SpousePriorYearPIN = objTax1040BO.IRSTransmission.SpousePriorYearEfilePIN;
                    //}

                    if (objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearAGI.HasValue && objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.HavePriorYearAGI.Value) //IsPrimaryPriorYearAGISpecified)
                    {
                        returnHeaderTypeSelfSelectPIN.PrimaryPriorYearAGIAmt = objTax1040BO.Filing.FederalFiling.IRS.IRSTransmission.SpousePriorYearAGI.ToString();
                    }

                    //if (objTax1040BO.IRSTransmission. //IsSpousePriorYearAGISpecified)
                    //{
                    //    returnHeaderTypeSelfSelectPIN.PrimaryPriorYearAGIAmt = objTax1040BO.IRSTransmission.SpousePriorYearAGI.ToString();
                    //}

                }
                if (objTax1040BO.OutputForms != null && objTax1040BO.OutputForms.Tax8879Page1 != null)
                {
                    if (!string.IsNullOrEmpty(objTax1040BO.OutputForms.Tax8879Page1.SpousePIN))
                    {
                        returnHeaderTypeSelfSelectPIN.PrimaryElectronicFilingPIN = objTax1040BO.OutputForms.Tax8879Page1.SpousePIN;
                    }
                }
            }
            return returnHeaderTypeSelfSelectPIN;
        }
        #endregion

        //** this is for CPA
        private ReturnHeaderTypePaidPreparerInformationGrp CreatePaidPreparerInformationGrp(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            ReturnHeaderTypePaidPreparerInformationGrp returnprepinfoGrp = new ReturnHeaderTypePaidPreparerInformationGrp();

            // returnprepinfoGrp.SignatureDt = objTax1040BO.PaidTaxReturnPreparers.Firm.s
            //     returnprepinfoGrp.SignatureDtSpecified 
            //**returnprepinfoGrp.SelfEmployedInd =objTax1040BO.PaidTaxReturnPreparers.Firm
            //**    returnprepinfoGrp.SelfEmployedIndSpecified
            //**   returnprepinfoGrp.Item
            //**        returnprepinfoGrp.ItemElementName
            //**    returnprepinfoGrp.PreparerFirmEIN
            //**           returnprepinfoGrp.PreparerPersonNm
            //**  returnprepinfoGrp.PreparerFirmName
            //**     returnprepinfoGrp.Item1
            //**     returnprepinfoGrp.Item2
            //**        returnprepinfoGrp.Item2ElementName
            //**   returnprepinfoGrp.EmailAddressTxt

            return returnprepinfoGrp;

        }

        #region Create FilerInformation
        private ReturnHeaderTypeFiler CreateFiler(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            ReturnHeaderTypeFiler filer = new ReturnHeaderTypeFiler();

            if (objTax1040BO.PersonalDetails.PrimaryTaxPayer != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person != null)
            {
                if (!string.IsNullOrEmpty(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.SSN))
                {
                    filer.PrimarySSN = GetBusinessSSNOREIN(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.SSN);

                }
                // SWAPNESH  DOUBT  SCHEMA VALIDATION
                if (!string.IsNullOrEmpty(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.LastName)
                    && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.LastName.Length >= 4)
                {
                    filer.PrimaryNameControlTxt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.LastName.Substring(0, 4).ToUpper();
                }

                filer.NameLine1Txt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.FirstName + " " + objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.LastName;
            }

            if (objTax1040BO.PersonalDetails.Spouse != null && objTax1040BO.PersonalDetails.Spouse.Person != null)
            {
                if (!string.IsNullOrEmpty(objTax1040BO.PersonalDetails.Spouse.Person.SSN))
                {
                    filer.SpouseSSN = GetBusinessSSNOREIN(objTax1040BO.PersonalDetails.Spouse.Person.SSN);

                }

                //TODO Ashok kumar - Need to Confirm it while transmission
                filer.NameLine1Txt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.FirstName + " " + objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.LastName + "&" + objTax1040BO.PersonalDetails.Spouse.Person.FirstName + " " + objTax1040BO.PersonalDetails.Spouse.Person.LastName;

                // SWAPNESH  DOUBT  SCHEMA VALIDATION
                if (!string.IsNullOrEmpty(objTax1040BO.PersonalDetails.Spouse.Person.LastName)
                    && objTax1040BO.PersonalDetails.Spouse.Person.LastName.Length >= 4)
                {
                    filer.PrimaryNameControlTxt = objTax1040BO.PersonalDetails.Spouse.Person.LastName.Substring(0, 4).ToUpper();
                }
            }

            //if (objTax1040BO.TaxesAndPenalties != null)
            //{
            //    filer.InCareOfNm = objTax1040BO.TaxesAndPenalties.InCareOf;
            //}


            if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress != null)
            {
                // **
                ForeignAddressType filerforeignAddress = new ForeignAddressType();
                //**if (!string.IsNullOrEmpty(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.))
                //{
                filerforeignAddress.AddressLine1Txt = GetAddress(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress).Trim();
                //}

                // no ned to fill swapnesh
                //**if (!string.IsNullOrEmpty(objTax1040BO.Tax4868BO.Tax4868Part1BO.Address2))
                //{
                //    filerforeignAddress.AddressLine2 = GetAddress(objTax1040BO.Tax4868BO.Tax4868Part1BO.Address2).Trim();
                //}

                // filerforeignAddress.City = objTax1040BO.Tax4868BO.Tax4868Part1BO.City;
                filerforeignAddress.ProvinceOrStateNm = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StateOrProvince;

                if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.Country != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.Country.CountryId != 0)
                {
                    filerforeignAddress.CountryCd = (CountryType)Enum.Parse(typeof(CountryType), objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.Country.CountryId.ToString(), true);
                }

                filerforeignAddress.ForeignPostalCd = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode;

                filer.Item = filerforeignAddress;
            }
            else
            {
                if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress != null)
                {
                    USAddressType filerusAddress = new USAddressType();

                    // need to check
                    filerusAddress.AddressLine1Txt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ApartmentNumber;
                    filerusAddress.AddressLine2Txt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress;
                    filerusAddress.CityNm = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City;

                    // no ned to fill swapnesh
                    //if (!string.IsNullOrEmpty(objTax1040BO.Tax4868BO.Tax4868Part1BO.Address2))
                    //{
                    //    filerusAddress.AddressLine2 = GetAddress(objTax1040BO.Tax4868BO.Tax4868Part1BO.Address2).Trim();
                    //}

                    //  SWAPNESH Schema Validation

                    //  filerusAddress.CityNm = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City;
                    if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State.StateId != 0)
                    {
                        Hashtable filerhtState = new Hashtable();
                        filerhtState = Utilities.StateIDToStateCodeHashtable();
                        if (filerhtState.ContainsKey(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State.StateId.ToString()))
                        {
                            string state = filerhtState[objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State.StateId.ToString()].ToString();
                            filerusAddress.StateAbbreviationCd = (StateType)Enum.Parse(typeof(StateType), state, true);
                        }
                    }
                    filerusAddress.ZIPCd = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode;

                    filer.Item = filerusAddress;
                }
            }

            return filer;
        }
        #endregion

        #region Get Phone number
        private string EditPhoneNumber(string phoneNo)
        {
            phoneNo = phoneNo.Replace("-", "");
            phoneNo = phoneNo.Replace("(", "");
            phoneNo = phoneNo.Replace(")", "");
            return phoneNo;
        }
        #endregion

        #region Get Address
        private string GetAddress(string address)
        {
            if (address.Contains(","))
                address = address.Replace(",", " ");
            if (address.Contains(":"))
                address = address.Replace(":", " ");
            if (address.Contains("-"))
                address = address.Replace("-", " ");
            if (address.Contains("#"))
                address = address.Replace("#", " ");
            if (address.Contains("."))
                address = address.Replace(".", " ");
            if (address.Contains("  "))
                address = address.Replace("  ", " ");
            return address;
        }
        #endregion

        #endregion


        private IRS1040EZ CreateIRS1040EZ(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            IRS1040EZ irs1040EZ = new IRS1040EZ();
            irs1040EZ.documentId = irs1040EZ.documentName;
            irs1040EZ.softwareId = SoftwareId;
            irs1040EZ.softwareVersionNum = SoftwareVersion;

            if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.DateOfDeath != null && objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.DateOfDeath != DateTime.MinValue)
            {

                irs1040EZ.PrimaryDeathDt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.DateOfDeath.Value;
                irs1040EZ.PrimaryDeathDtSpecified = true;
            }
            else
            {
                irs1040EZ.PrimaryDeathDtSpecified = false;
            }
            if (objTax1040BO.PersonalDetails.Spouse != null)
            {
                if ((objTax1040BO.PersonalDetails.Spouse.Person.DateOfDeath != null && objTax1040BO.PersonalDetails.Spouse.Person.DateOfDeath != DateTime.MinValue))
                {
                    irs1040EZ.SpouseDeathDt = objTax1040BO.PersonalDetails.Spouse.Person.DateOfDeath.Value;
                    irs1040EZ.SpouseDeathDtSpecified = true;
                }
                else
                {
                    irs1040EZ.SpouseDeathDtSpecified = false;
                }

                if (objTax1040BO.PersonalDetails.Spouse.Person.HasSpouseEcfContributed.HasValue && (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.HasSpouseEcfContributed.Value))
                {
                    irs1040EZ.PECFSpouseInd = CheckboxType.X;
                    irs1040EZ.PECFSpouseIndSpecified = true;
                }

                if (objTax1040BO.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue &&
               objTax1040BO.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value)
                {
                    irs1040EZ.SpouseClaimAsDependentInd = CheckboxType.X;
                    irs1040EZ.SpouseClaimAsDependentIndSpecified = true;
                }
                irs1040EZ.SpouseOccupationTxt = objTax1040BO.PersonalDetails.Spouse.Person.Occupation;
            }
            //** need confirmation from UMA(confirm 2290)
            //**irs1040EZ.Item

            if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.HasPrimaryFilerEcfContributed.HasValue && (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.HasPrimaryFilerEcfContributed.Value))
            {
                irs1040EZ.PECFPrimaryInd = CheckboxType.X;
                irs1040EZ.PECFPrimaryIndSpecified = true;
            }


            IRS1040EZTypeWagesSalariesAndTipsAmt irs1040EZTypeWagesSalariesAndTipsAmt = new JTL.Tax1040.IRSObject.IRS1040EZTypeWagesSalariesAndTipsAmt();
            //**  irs1040EZTypeWagesSalariesAndTipsAmt.referenceDocumentId = irs1040EZTypeWagesSalariesAndTipsAmt.referenceDocumentName;
            irs1040EZTypeWagesSalariesAndTipsAmt.Value = objTax1040BO.OutputForms.Tax1040EZPage1.TotalWages.ToString();
            irs1040EZ.WagesSalariesAndTipsAmt = irs1040EZTypeWagesSalariesAndTipsAmt;





            irs1040EZ.TaxableInterestAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TaxableInterest.ToString();

            //Modified by Ashok after Object finalization

            if (objTax1040BO.OutputForms.Tax1040EZPage1.TEI > 0)
            {
                irs1040EZ.TaxExemptInterestAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TEI.ToString();
                irs1040EZ.TaxExemptInterestCd = IRS1040EZTypeTaxExemptInterestCd.TEI;
                irs1040EZ.TaxExemptInterestCdSpecified = true;
            }

            IRS1040EZTypeUnemploymentCompAmt irs1040EZTypeUnemploymentCompAmt = new JTL.Tax1040.IRSObject.IRS1040EZTypeUnemploymentCompAmt();
            irs1040EZTypeUnemploymentCompAmt.repaymentAmt = objTax1040BO.OutputForms.Tax1040EZPage1.UnemploymentCompensation.ToString();
            irs1040EZTypeUnemploymentCompAmt.Value = objTax1040BO.OutputForms.Tax1040EZPage1.UnemploymentCompensation.ToString();
            irs1040EZ.UnemploymentCompAmt = irs1040EZTypeUnemploymentCompAmt;


            //  need to   analysis
            //**  irs1040EZ.ProtectiveSec108iELCRecordInd
            //**    irs1040EZ.ProtectiveSec108iELCRecordIndSpecified

            irs1040EZ.AdjustedGrossIncomeAmt = objTax1040BO.OutputForms.Tax1040EZPage1.AdjustedGrossIncome.ToString();

            if (objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.HasValue &&
                   objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent.Value)
            {
                irs1040EZ.PrimaryClaimAsDependentInd = CheckboxType.X;
                irs1040EZ.PrimaryClaimAsDependentIndSpecified = true;
            }

            // Moved up
            //if (objTax1040BO.PersonalDetails.Spouse.Person.HasClaimedAsDependent.HasValue &&
            //    objTax1040BO.PersonalDetails.Spouse.Person.HasClaimedAsDependent.Value)
            //{
            //    irs1040EZ.SpouseClaimAsDependentInd = CheckboxType.X;
            //    irs1040EZ.SpouseClaimAsDependentIndSpecified = true;
            //}

            //  need to discuss Praveen
            //** irs1040EZ.CombStdDedAndPrsnlExemptAmt =objTax1040BO.OutputForms.Tax1040EZPage1.c
            irs1040EZ.TaxableIncomeAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TaxableIncome.ToString();


            IRS1040EZTypeWithholdingTaxAmt irs1040EZTypeWithholdingTaxAmt = new IRS1040EZTypeWithholdingTaxAmt();

            //** irs1040EZTypeWithholdingTaxAmt.referenceDocumentId = irs1040EZTypeWithholdingTaxAmt.referenceDocumentName;
            irs1040EZTypeWithholdingTaxAmt.Value = objTax1040BO.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount.ToString();
            irs1040EZ.WithholdingTaxAmt = irs1040EZTypeWithholdingTaxAmt;



            irs1040EZ.EarnedIncomeCreditAmt = objTax1040BO.OutputForms.Tax1040EZPage1.EarnedIncomeCredit.ToString();

            // ** 
            //**  irs1040EZ.EICEligibilityLiteralCd =IRS1040EZTypeEICEligibilityLiteralCd.
            // **   irs1040EZ.EICEligibilityLiteralCdSpecified


            irs1040EZ.NontxCombatPayElectionAmt = objTax1040BO.OutputForms.Tax1040EZPage1.NonTaxableCombatPayElection.ToString();



            IRS1040EZTypeRequestForExtensionAmt irs1040EZTypeRequestForExtensionAmt = new IRS1040EZTypeRequestForExtensionAmt();
            irs1040EZTypeRequestForExtensionAmt.Value = objTax1040BO.OutputForms.Tax1040EZPage1.RefundAmount.ToString();
            irs1040EZ.RequestForExtensionAmt = irs1040EZTypeRequestForExtensionAmt;


            irs1040EZ.TotalPaymentsAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits.ToString();
            irs1040EZ.TaxAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TaxAmount.ToString();
            irs1040EZ.RefundAmt = objTax1040BO.OutputForms.Tax1040EZPage1.RefundAmount.ToString();


            //** not supported now
            //IRS1040EZTypeForm8888Ind irs1040EZTypeForm8888Ind = new IRS1040EZTypeForm8888Ind();
            //// **  irs1040EZTypeForm8888Ind. referenceDocumentId
            //// ***  irs1040EZTypeForm8888Ind.Value
            //irs1040EZ.Form8888Ind = irs1040EZTypeForm8888Ind;

            //  string Checking = "1";

            if (objTax1040BO.Filing != null && objTax1040BO.Filing.FederalFiling != null && objTax1040BO.Filing.FederalFiling.IRS != null && objTax1040BO.Filing.FederalFiling.IRS.BankDetails != null)
            {
                irs1040EZ.RoutingTransitNum = objTax1040BO.Filing.FederalFiling.IRS.BankDetails.RoutingTransitNumber;

                //  if (!string.IsNullOrEmpty(objTax1040BO.Settlement.IRS.BankDetails.BankAccountTypeCode) && Convert.ToInt16(objTax1040BO.Settlement.IRS.BankDetails.BankAccountTypeCode) > 0)
                if (objTax1040BO.Filing.FederalFiling.IRS.BankDetails.BankAccountTypeCode != JTL.Tax1040.Core.Object.AccountType.None)
                {
                    if (objTax1040BO.Filing.FederalFiling.IRS.BankDetails.BankAccountTypeCode == JTL.Tax1040.Core.Object.AccountType.Checking)// Checking)
                    {
                        irs1040EZ.BankAccountTypeCd = BankAccountType.Item1;
                    }
                    else
                    {
                        irs1040EZ.BankAccountTypeCd = BankAccountType.Item2;
                    }

                    irs1040EZ.BankAccountTypeCdSpecified = true;
                }

                irs1040EZ.DepositorAccountNum = objTax1040BO.Filing.FederalFiling.IRS.BankDetails.AccountNumber;
            }
            else
            {
                irs1040EZ.RoutingTransitNum = "253177049";
                irs1040EZ.BankAccountTypeCd = BankAccountType.Item2;
            }


            irs1040EZ.OwedAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TaxOweAmount.ToString();
            if (objTax1040BO.ThirdPartyDesignee != null)
            {
                irs1040EZ.ThirdPartyDesigneeInd = true;
                irs1040EZ.ThirdPartyDesigneeIndSpecified = true;

                irs1040EZ.ThirdPartyDesigneeNm = objTax1040BO.ThirdPartyDesignee.DesigneeName;
                irs1040EZ.ThirdPartyDesigneePhoneNum = objTax1040BO.ThirdPartyDesignee.PhoneNumber;
                irs1040EZ.ThirdPartyDesigneePIN = objTax1040BO.ThirdPartyDesignee.PIN.ToString();
            }

            //  Not supported now 
            //** irs1040EZ.PowerOfAttorneySignedBy
            //**  irs1040EZ.PowerOfAttorneySignedBySpecified
            //**  irs1040EZ.PowerOfAttorneyName


            irs1040EZ.PrimaryOccupationTxt = objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.Occupation;

            //** need to discuss with UMA
            //** irs1040EZ.SurvivingSpouseInd
            //** irs1040EZ.SurvivingSpouseIndSpecified


            if (irs1040EZ.PrimaryDeathDtSpecified && irs1040EZ.SpouseDeathDtSpecified)
            {

                irs1040EZ.PersonalRepresentativeInd = CheckboxType.X;
                irs1040EZ.PersonalRepresentativeIndSpecified = true;
            }
            else
            {
                irs1040EZ.PersonalRepresentativeIndSpecified = false;
            }

            // moved up swapnessh
            ///////////// irs1040EZ.SpouseOccupation = objTax1040BO.PersonalDetails.Spouse.Person.Occupation;
            //** Fields available need to finalize
            ///**  irs1040EZ.Item1
            //**  irs1040EZ.Item1ElementName

            //** need to analysis BA
            //** irs1040EZ.NonPaidPreparerCd
            ///**      irs1040EZ.NonPaidPreparerCdSpecified
            //**   irs1040EZ.RefundAnticipationLoanCd
            return irs1040EZ;
        }

        //public List<IRS1310> CreateIRS1310(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    List<IRS1310> lstIRS1310 = new List<IRS1310>();

        //    return lstIRS1310;
        //}

        //public List<IRS8833> CreateIRS8833(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    List<IRS8833> lstIRS8833 = new List<IRS8833>();

        //    return lstIRS8833;
        //}

        public List<IRSW2> CreateIRSW2(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            List<IRSW2> lstIRSW2 = new List<IRSW2>();

            int w2id = 0;
            if (objTax1040BO.Income != null && objTax1040BO.Income.W2Wages != null)
            {
                foreach (JTL.Tax1040.BusinessObject.W2 formirsw2 in objTax1040BO.Income.W2Wages)
                {

                    IRSW2 irsw2 = new IRSW2();

                    irsw2.documentId = irsw2.documentName + w2id.ToString();
                    irsw2.softwareId = SoftwareId;
                    irsw2.softwareVersionNum = SoftwareVersion;

                    if (formirsw2.IsCorrectedW2.HasValue && formirsw2.IsCorrectedW2.Value)
                    {
                        irsw2.CorrectedW2Ind = CheckboxType.X;
                        irsw2.CorrectedW2IndSpecified = true;
                    }

                    if (formirsw2.OwnerType == JTL.Tax1040.Core.Object.OwnerType.PrimaryTaxPayer)
                    {
                        irsw2.EmployeeSSN = GetBusinessSSNOREIN(objTax1040BO.PersonalDetails.PrimaryTaxPayer.Person.SSN);
                    }
                    else if (formirsw2.OwnerType == JTL.Tax1040.Core.Object.OwnerType.Spouse)
                    {
                        irsw2.EmployeeSSN = GetBusinessSSNOREIN(objTax1040BO.PersonalDetails.Spouse.Person.SSN);
                    }
                    irsw2.EmployerEIN = GetBusinessSSNOREIN(formirsw2.Employer.Organization.EIN);
                    //** do later ADD  sw2.EmployerNameControl = formirsw2.EmployerNameControl;

                    if (!String.IsNullOrEmpty(formirsw2.Employer.Organization.Name) && formirsw2.Employer.Organization.Name.Length >= 4)
                    {
                        irsw2.EmployerNameControlTxt = formirsw2.Employer.Organization.Name.Substring(0, 4);
                    }
                    else
                    {

                        irsw2.EmployerNameControlTxt = "ABCD";
                    }
                    BusinessNameType businessNameType = new BusinessNameType();
                    //**  need to analysis   
                    businessNameType.BusinessNameLine1Txt = "need to fill";
                    //**  need to analysis            
                    businessNameType.BusinessNameLine2Txt = "need to fill";


                    irsw2.EmployerName = businessNameType;

                    USAddressType usaddresstype = new USAddressType();
                    usaddresstype.AddressLine1Txt = "need to fill";
                    usaddresstype.AddressLine2Txt = "need to fill";
                    usaddresstype.CityNm = "need to fill";
                    usaddresstype.ZIPCd = "34567";
                    irsw2.Item = usaddresstype;



                    irsw2.ControlNum = "123e";
                    //   irsw2.EmployeeName = formirsw2.e
                    irsw2.EmployeeNm = "1235445";



                    irsw2.Item1 = usaddresstype;


                    irsw2.WagesAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.WagesAmount);
                    irsw2.WithholdingAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.FederalTaxWithholdingAmount);
                    irsw2.SocialSecurityWagesAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.SocialSecurityWagesAmount);
                    irsw2.SocialSecurityTaxAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.SocialSecurityTaxWithholdingAmount);
                    irsw2.MedicareWagesAndTipsAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.MedicareWagesAmount);
                    irsw2.MedicareTaxWithheldAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.MedicareTaxWithholdingAmount);
                    irsw2.SocialSecurityTipsAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.SocialSecurityTipsAmount);
                    irsw2.AllocatedTipsAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.AllocatedTipsAmount);
                    irsw2.DependentCareBenefitsAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.DependentCareBenefitsAmount);
                    irsw2.NonqualifiedPlansAmt = Utilities.IsNullReturnZeroNumeric(formirsw2.NonQualifiedPlansAmount);
                    //** need to discuss BA   irsw2.EmployersUseGrp =formirsw2.em
                    if (formirsw2.IsNonStandardW2.HasValue && formirsw2.IsNonStandardW2.Value)
                    {
                        irsw2.StatutoryEmployeeInd = CheckboxType.X;
                        irsw2.StatutoryEmployeeIndSpecified = true;
                    }
                    if (formirsw2.HasRetirementPlan.HasValue && formirsw2.HasRetirementPlan.Value)
                    {
                        irsw2.RetirementPlanInd = CheckboxType.X;
                        irsw2.RetirementPlanIndSpecified = true;
                    }
                    if (formirsw2.HasThirdPartySickPay.HasValue && formirsw2.HasThirdPartySickPay.Value)
                    {
                        irsw2.ThirdPartySickPayInd = CheckboxType.X;
                        irsw2.ThirdPartySickPayIndSpecified = true;
                    }

                    if (formirsw2.OtherDeductsBenefits != null)
                    {
                        irsw2.OtherDeductionsBenefitsGrp = formirsw2.OtherDeductsBenefits.Select(a => new USItemizedEntryType
                        {
                            Desc = string.IsNullOrEmpty(a.Description) ? "Need to fill" : a.Description,
                            Amt = Utilities.IsNullReturnZeroNumeric(a.Amount)
                        }).ToList();
                    }

                    if (formirsw2.W2StateLocalTaxInfo != null)
                    {
                        List<W2StateLocalTaxGrpType> lstW2StateLocalTaxGrpType = new List<W2StateLocalTaxGrpType>();
                        foreach (W2StateLocalTaxInfo w2stateLocalTaxInfo in formirsw2.W2StateLocalTaxInfo)
                        {
                            W2StateLocalTaxGrpType w2sateLocalTaxGrpTypelocal = new W2StateLocalTaxGrpType();

                            w2sateLocalTaxGrpTypelocal.W2StateTaxGrp = new W2StateLocalTaxGrpTypeW2StateTaxGrp();
                            if (w2stateLocalTaxInfo.State != null)
                            {
                                w2sateLocalTaxGrpTypelocal.W2StateTaxGrp.EmployerStateIdNum = w2stateLocalTaxInfo.State.StateId.ToString();

                                //** doubt
                                if (!string.IsNullOrEmpty(w2stateLocalTaxInfo.State.StateCode))
                                {
                                    w2sateLocalTaxGrpTypelocal.W2StateTaxGrp.StateAbbreviationCd = (StateType)Enum.Parse(typeof(StateType), w2stateLocalTaxInfo.State.StateCode, true);
                                }
                                w2sateLocalTaxGrpTypelocal.W2StateTaxGrp.StateWagesAmt = w2stateLocalTaxInfo.StateWagesAmount.ToString();
                                w2sateLocalTaxGrpTypelocal.W2StateTaxGrp.StateIncomeTaxAmt = w2stateLocalTaxInfo.StateTaxWithholdingAmount.ToString();
                            }
                            W2StateLocalTaxGrpTypeW2StateTaxGrpW2LocalTaxGrp w2stateLOCALTaxGrpTypeW2StateTaxGrpW2LocalTaxGrp = new W2StateLocalTaxGrpTypeW2StateTaxGrpW2LocalTaxGrp();
                            //**  w2stateLOCALTaxGrpTypeW2StateTaxGrpW2LocalTaxGrp.LocalWagesAndTipsAmt
                            // **      LocalIncomeTaxAmt
                            //  **     NameOfLocality

                            w2sateLocalTaxGrpTypelocal.W2StateTaxGrp.W2LocalTaxGrp = w2stateLOCALTaxGrpTypeW2StateTaxGrpW2LocalTaxGrp;
                            lstW2StateLocalTaxGrpType.Add(w2sateLocalTaxGrpTypelocal);
                        }

                        //** need to discuss
                        //irsw2.W2StateLocalTaxGrp =
                    }

                    if (formirsw2.IsNonStandardW2.HasValue && formirsw2.IsNonStandardW2.Value)
                    {
                        irsw2.StandardOrNonStandardCd = IRSW2TypeStandardOrNonStandardCd.S;
                    }
                    else if (formirsw2.IsNonStandardW2.HasValue && !formirsw2.IsNonStandardW2.Value)
                    {
                        irsw2.StandardOrNonStandardCd = IRSW2TypeStandardOrNonStandardCd.N;
                    }

                    lstIRSW2.Add(irsw2);
                }
            }
            return lstIRSW2;
        }

        //public List<FECRecord> CreateFECRecord(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    List<FECRecord> lstFECRecord = new List<FECRecord>();

        //    ///*****

        //    return lstFECRecord;
        //}

        //public NameChangeStatement CreateNameChangeStatement(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    NameChangeStatement nameChangeStatement = new NameChangeStatement();


        //    return nameChangeStatement;
        //}

        public OtherWithholdingStatement CreateOtherWithholdingStatement(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            OtherWithholdingStatement otherWithholdingStatement = new OtherWithholdingStatement();

            otherWithholdingStatement.documentId = otherWithholdingStatement.documentName;
            otherWithholdingStatement.softwareId = SoftwareId;
            otherWithholdingStatement.softwareVersionNum = SoftwareVersion;

            // **   List
            //**  need to analysis

            //**     OtherWithholdingStmtType othrherWithholdingStmtType=new OtherWithholdingStmtType()
            //**otherWithholdingStatement.OtherWithholdingStmt=objTax1040BO.Income.


            return otherWithholdingStatement;
        }

        //public OverseasExtensionStatement CreateOverseasExtensionStatement(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    OverseasExtensionStatement overseasExtensionStatement = new OverseasExtensionStatement();


        //    return overseasExtensionStatement;
        //}

        //** need to discuss UMA And BA
        public PenaltiesStatement CreatePenaltiesStatement(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            PenaltiesStatement penaltiesStatement = new PenaltiesStatement();
            penaltiesStatement.documentId = penaltiesStatement.documentName;
            penaltiesStatement.softwareId = SoftwareId;
            penaltiesStatement.softwareVersionNum = SoftwareVersion;

            return penaltiesStatement;
        }

        public SpouseSignatureStatement CreateSpouseSignatureStatement(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            SpouseSignatureStatement spouseSignatureStatement = new SpouseSignatureStatement();
            spouseSignatureStatement.documentId = spouseSignatureStatement.documentName;
            spouseSignatureStatement.softwareId = SoftwareId;
            spouseSignatureStatement.softwareVersionNum = SoftwareVersion;
            /// **   spouseSignatureStatement.Statement =objTax1040BO.PersonalDetails.Spouse.Person.ss
            return spouseSignatureStatement;
        }

        //** need to discuss UMA
        public WagesNotShownSchedule CreateWagesNotShownSchedule(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            WagesNotShownSchedule wagesNotShownSchedule = new WagesNotShownSchedule();
            wagesNotShownSchedule.documentId = wagesNotShownSchedule.documentName;
            wagesNotShownSchedule.softwareId = SoftwareId;
            wagesNotShownSchedule.softwareVersionNum = SoftwareVersion;

            return wagesNotShownSchedule;
        }

        //public InjuredSpouseOtherIncomeStmt CreateInjuredSpouseOtherIncomeStmt(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    InjuredSpouseOtherIncomeStmt injuredSpouseOtherIncomeStmt = new InjuredSpouseOtherIncomeStmt();


        //    return injuredSpouseOtherIncomeStmt;
        //}

        public IRSPayment CreateIRSPayment(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            IRSPayment irsPayment = new IRSPayment();
            irsPayment.documentId = irsPayment.documentName;
            irsPayment.softwareId = SoftwareId;
            irsPayment.softwareVersionNum = SoftwareVersion;

            if (objTax1040BO.Filing != null && objTax1040BO.Filing.FederalFiling != null && objTax1040BO.Filing.FederalFiling.IRS != null && objTax1040BO.Filing.FederalFiling.IRS.BankDetails != null)
            {
                irsPayment.RoutingTransitNum = objTax1040BO.Filing.FederalFiling.IRS.BankDetails.RoutingTransitNumber;
                irsPayment.BankAccountNum = objTax1040BO.Filing.FederalFiling.IRS.BankDetails.AccountNumber;

                //  need to fill
                irsPayment.TaxpayerDaytimePhoneNum = EditPhoneNumber("23456-78973");

                //** checkbelow  objTax1040BO.Settlement.IRS.BankDetails.BankAccountTypeCode

                if (objTax1040BO.Filing.FederalFiling.IRS.BankDetails.BankAccountTypeCode == JTL.Tax1040.Core.Object.AccountType.Checking) //"1")
                {

                    irsPayment.BankAccountTypeCd = BankAccountType.Item1;
                }
                else
                {
                    irsPayment.BankAccountTypeCd = BankAccountType.Item2;
                }
            }
            else
            {
                irsPayment.RoutingTransitNum = "253177046";

                irsPayment.TaxpayerDaytimePhoneNum = EditPhoneNumber("23456-78973");
                irsPayment.BankAccountNum = "134567892345";
            }


            // need to analysis
            if (objTax1040BO.OutputForms.Tax1040EZPage1.TaxOweAmount > 0)
            {
                irsPayment.PaymentAmt = objTax1040BO.OutputForms.Tax1040EZPage1.TaxOweAmount.ToString();
            }
            else
            {
                irsPayment.PaymentAmt = "1";
            }

            // need to fill efile business object
            //**     irsPayment.RequestedPaymentDt = 
            irsPayment.RequestedPaymentDt = DateTime.Now;
            //if (objTax1040BO.OutputForms.Tax1040EZPage1.p..PaymentDate != DateTime.MinValue)
            //{
            //    iRSPayment.RequestedPaymentDt = Utilities.GetDateTime(objTaxEngineBO.TaxPayOptionBO.PaymentDate);
            //}
            //else
            //{
            //    iRSPayment.RequestedPaymentDt = DateTime.Now;
            //}

            //    **        irsPayment.TaxpayerDaytimePhoneNum = 

            return irsPayment;
        }

        //public List<IRSESPayment> CreateListIRSESPayment(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        //{
        //    List<IRSESPayment> lstIRSESPayment = new List<IRSESPayment>();


        //    return lstIRSESPayment;
        //}


        //** need to discuss with UMA
        public List<GeneralDependencySmall> CreateGeneralDependencySmall(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            List<GeneralDependencySmall> lstgeneralDependencySmall = new List<GeneralDependencySmall>();


            return lstgeneralDependencySmall;
        }

        //** need to discuss with UMA
        public List<GeneralDependencyMedium> CreateGeneralDependencyMedium(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO)
        {
            List<GeneralDependencyMedium> lstgeneralDependencyMedium = new List<GeneralDependencyMedium>();


            return lstgeneralDependencyMedium;
        }

        #region Create ReturnData
        private ReturnData CreateReturnData(JTL.Tax1040.BusinessObject.Tax1040 objTax1040BO, IRSSchemaDE objIRSSchemaDE)
        {
            //create instance for return data object
            ReturnData objReturnData = new ReturnData();


            objReturnData.IRS1040EZ = CreateIRS1040EZ(objTax1040BO);

            // **  now not done
            //  objReturnData.IRS1310 = CreateIRS1310(objTax1040BO);

            // **  now not done
            //IRS8379 irs8379 = new IRS8379();
            //objReturnData.IRS8379 = irs8379;

            // **  now not done
            // objReturnData.IRS8833 = CreateIRS8833(objTax1040BO);

            //IRS8862 irs8862 = new JTL.Tax1040.IRSObject.IRS8862();
            //// **  now not done
            //objReturnData.IRS8862 = irs8862;


            //IRS8867 irs8867 = new JTL.Tax1040.IRSObject.IRS8867();
            //// **  now not done
            //objReturnData.IRS8867 = irs8867;

            //IRS8888 irs8888 = new IRS8888();
            //// **  now not done
            //objReturnData.IRS8888 = irs8888;

            //IRS9465 irs9465 = new IRS9465();
            //// **  now not done
            //objReturnData.IRS9465 = irs9465;


            objReturnData.IRSW2 = CreateIRSW2(objTax1040BO);

            //objReturnData.FECRecord = CreateFECRecord(objTax1040BO);

            //objReturnData.NameChangeStatement = CreateNameChangeStatement(objTax1040BO);
            objReturnData.OtherWithholdingStatement = CreateOtherWithholdingStatement(objTax1040BO);


            // objReturnData.OverseasExtensionStatement = CreateOverseasExtensionStatement(objTax1040BO);

            objReturnData.PenaltiesStatement = CreatePenaltiesStatement(objTax1040BO);

            objReturnData.SpouseSignatureStatement = CreateSpouseSignatureStatement(objTax1040BO);

            objReturnData.WagesNotShownSchedule = CreateWagesNotShownSchedule(objTax1040BO);

            //  objReturnData.InjuredSpouseOtherIncomeStmt = CreateInjuredSpouseOtherIncomeStmt(objTax1040BO);

            objReturnData.IRSPayment = CreateIRSPayment(objTax1040BO);

            //   objReturnData.IRSESPayment = CreateListIRSESPayment(objTax1040BO);

            objReturnData.GeneralDependencySmall = CreateGeneralDependencySmall(objTax1040BO);

            objReturnData.GeneralDependencyMedium = CreateGeneralDependencyMedium(objTax1040BO);
            objReturnData.BinaryAttachment = CreateBinaryAttachment(objIRSSchemaDE);
            objReturnData.documentCnt = documentCount.ToString();

            return objReturnData;
        }
        #endregion

        #region Create BinaryAttachment
        private BinaryAttachment[] CreateBinaryAttachment(IRSSchemaDE objIRSSchemaDE)
        {
            if (!string.IsNullOrEmpty(objIRSSchemaDE.AttachmentsCount) && Utilities.GetInt32(objIRSSchemaDE.AttachmentsCount) > 0)
            {
                TaxXMLtoIRSSchemaBL objTaxXMLtoIRSSchemaBL = new TaxXMLtoIRSSchemaBL();
                DataSet dsAttachments = objTaxXMLtoIRSSchemaBL.GetVendorAttachments(objIRSSchemaDE.EfileHoldID);

                if (null != dsAttachments)
                {
                    int BinaryAttachmentIncrementCount = 0;
                    BinaryAttachment[] binaryAttachment = new BinaryAttachment[Utilities.GetInt32(objIRSSchemaDE.AttachmentsCount)];
                    foreach (DataRow dr in dsAttachments.Tables[0].Rows)
                    {

                        BinaryAttachment BinaryAttachmentItem = new BinaryAttachment();
                        BinaryAttachmentItem.DocumentType = BinaryAttachmentTypeDocumentType.PDF;
                        BinaryAttachmentItem.Description = dr["AttachementName"].ToString();

                        BinaryAttachmentItem.AttachmentLocation = dr["AttachementName"].ToString() + ".pdf";
                        BinaryAttachmentItem.documentId = BinaryAttachmentItem.documentName + BinaryAttachmentIncrementCount.ToString();
                        documentCount += 1;
                        BinaryAttachmentItem.softwareId = SoftwareId;
                        BinaryAttachmentItem.softwareVersionNum = SoftwareVersion;
                        binaryAttachment[BinaryAttachmentIncrementCount] = BinaryAttachmentItem;
                        BinaryAttachmentIncrementCount += 1;

                    }
                    return binaryAttachment;
                }
            }
            return null;
        }
        #endregion
    }

}