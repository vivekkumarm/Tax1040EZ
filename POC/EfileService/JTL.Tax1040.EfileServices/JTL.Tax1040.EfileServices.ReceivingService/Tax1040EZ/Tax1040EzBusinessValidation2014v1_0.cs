using Efile.SubmissionManifest;
using JTL.Tax1040.IRSObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class Tax1040EzBusinessValidation2014v1_0
    {
        #region Constants
        string ConstReturnVersion1040 = "ConstReturnVersion1040";
        List<EINNameControlDE> lstEINNameControl = new List<EINNameControlDE>();
        string PreparerSSNZeros = "00000000";
        string PreparerSSNNines = "99999999";
        #endregion

        #region Declarations
        List<BusinessMessagesDE> listMessagesDE;
        BusinessMessagesDE messagesDE;
        #endregion

        #region Constructor
        public Tax1040EzBusinessValidation2014v1_0()
        {
            listMessagesDE = new List<BusinessMessagesDE>();
        }
        #endregion


        #region ErrorType
        internal class ErrorType
        {
            public const string ApplicationError = "IRSSchemaBusinessValidation";
        }
        #endregion


        #region ErrorTypeErrorCode
        internal class ErrorCode
        {
            // Swapnesh
            public const string F1040EZ00101 = "F1040EZ-001-01";
            public const string F1040EZ00202 = "F1040EZ-002-02";
            public const string F1040EZ00302 = "F1040EZ-003-02";
            public const string F1040EZ004 = "F1040EZ-004";
            public const string F1040EZ005 = "F1040EZ-005";
            public const string F1040EZ006 = "F1040EZ-006";
            public const string F1040EZ007 = "F1040EZ-007";
            public const string F1040EZ008 = "F1040EZ-008";
            public const string F1040EZ009 = "F1040EZ-009";
            public const string F1040EZ010 = "F1040EZ-010";
            public const string F1040EZ011 = "F1040EZ-011";
            public const string F1040EZ012 = "F1040EZ-012";
            public const string F1040EZ013 = "F1040EZ-013";
            public const string F1040EZ01602 = "F1040EZ-016-02";
            public const string F1040EZ01702 = "F1040EZ-017-02";
            public const string F1040EZ01802 = "F1040EZ-018-02";
            public const string F1040EZ01902 = "F1040EZ-019-02";
            public const string F1040EZ02002 = "F1040EZ-020-02";
            public const string F1040EZ02102 = "F1040EZ-021-02";
            public const string F1040EZ02202 = "F1040EZ-022-02";
            public const string F1040EZ023 = "F1040EZ-023";
            public const string F1040EZ024 = "F1040EZ-024";
            public const string F1040EZ025 = "F1040EZ-025";
            public const string F1040EZ026 = "F1040EZ-026";
            public const string F1040EZ027 = "F1040EZ-027";
            public const string F1040EZ028 = "F1040EZ-028";
            public const string F1040EZ029 = "F1040EZ-029";
            public const string F1040EZ044 = "F1040EZ-044";
            public const string F1040EZ046 = "F1040EZ-046";
            public const string F1040EZ049 = "F1040EZ-049";
            public const string F1040EZ050 = "F1040EZ-050";
            public const string F1040EZ051 = "F1040EZ-051";
            public const string F1040EZ052 = "F1040EZ-052";
            public const string F1040EZ054 = "F1040EZ-054";
            public const string F1040EZ06101 = "F1040EZ-061-01";
            public const string F1040EZ06201 = "F1040EZ-062-01";
            public const string F1040EZ06301 = "F1040EZ-063-01";
            public const string F1040EZ064 = "F1040EZ-064";
            public const string F1040EZ065 = "F1040EZ-065";
            public const string F1040EZ07101 = "F1040EZ-071-01";
            public const string F1040EZ07301 = "F1040EZ-073-01";
            public const string IND05601 = "IND-056-01";
            public const string IND05701 = "IND-057-01";

            public const string F1040EZ088 = "F1040EZ-088";
            public const string F1040EZ336 = "F1040EZ-336";
            public const string F1040EZ411 = "F1040EZ-411";
            public const string F1040EZ412 = "F1040EZ-412";
            public const string F1040EZ510 = "F1040EZ-510";
            public const string F1040EZ511 = "F1040EZ-511";
            public const string F1040EZ513 = "F1040EZ-513";
            public const string F1040EZ52401 = "F1040EZ-524-01";
            public const string F886200101 = "F8862-001-01";
            public const string FPYMT06401 = "FPYMT-064-01";
            public const string FPYMT06801 = "FPYMT-068-01";
            public const string FPYMT06901 = "FPYMT-069-01";
            public const string FPYMT07101 = "FPYMT-071-01";
            public const string FPYMT07201 = "FPYMT-072-01";
            public const string FPYMT07401 = "FPYMT-074-01";
            public const string FW2002 = "FW2-002";
            public const string FW200301 = "FW2-003-01";
            public const string FW2007 = "FW2-007";
            public const string FW2008 = "FW2-008";
            public const string FW2499 = "FW2-499";
            public const string FW2502 = "FW2-502";
            public const string FW250501 = "FW2-505-01";
            public const string IND00101 = "IND-001-01";
            public const string IND02101 = "IND-021-01";
            public const string IND02201 = "IND-022-01";
            public const string IND02301 = "IND-023-01";
            public const string IND02401 = "IND-024-01";
            public const string IND02501 = "IND-025-01";

            public const string IND02601 = "IND-026-01";
            public const string IND02701 = "IND-027-01";
            public const string IND02801 = "IND-028-01";
            public const string IND042 = "IND-042";
            public const string IND043 = "IND-043";
            public const string IND044 = "IND-044";

            public const string IND063 = "IND-063";
            public const string IND67201 = "IND-672-01";
            public const string IND67301 = "IND-673-01";
            public const string IND69401 = "IND-694-01";

            public const string IND69501 = "IND-695-01";
            public const string IND69601 = "IND-696-01";
            public const string IND69901 = "IND-699-01";
            public const string IND769 = "IND-769";
            public const string IND770 = "IND-770";


            public const string IND045 = "IND-045";
            public const string IND05501 = "IND-055-01";
            public const string IND05801 = "IND-058-01";
            public const string IND05901 = "IND-059-01";
            public const string IND060 = "IND-060";
            public const string IND03201 = "IND-032-01";
            public const string IND066 = "IND066";
            public const string IND002 = "IND-002";
            public const string IND00501 = "IND-005-01";
            public const string IND006 = "IND-006";
            public const string IND010 = "IND-010";
            public const string IND011 = "IND-011";
            public const string IND012 = "IND-012";
            public const string IND01301 = "IND-013-01";
            public const string IND01401 = "IND-014-01";
            public const string IND015 = "IND-015";
            public const string IND016 = "IND-016";
            public const string IND03301 = "IND-033-01";
            public const string IND01801 = "IND-018-01";
            public const string IND01901 = "IND-019-01";
            public const string IND03401 = "IND-034-01";
            public const string IND035 = "IND-035";
            public const string IND036 = "IND-036";
            public const string IND037 = "IND-037";
            public const string IND038 = "IND-038";
            public const string IND039 = "IND-039";
            public const string IND040 = "IND-040";
            public const string IND041 = "IND-041";
            public const string IND046 = "IND-046";
            public const string IND049 = "IND-049";
            public const string IND052 = "IND-052";
            public const string IND061 = "IND-061";
            public const string IND180 = "IND-180";
            public const string IND181 = "IND-181";
            public const string IND182 = "IND-182";
            public const string IND183 = "IND-183";
            public const string IND508 = "IND-508";
            public const string IND510 = "IND-510";
            public const string IND513 = "IND-513";
            public const string IND515 = "IND-515";
            public const string IND52101 = "IND-521-01";
            public const string IND53101 = "IND-531-01";
            public const string IND53201 = "IND-532-01";
            public const string IND57001 = "IND-570-01";
            public const string IND68901 = "IND-689-01";
            public const string IND901 = "IND-901";
            public const string IND902 = "IND-902";
            public const string IND903 = "IND-903";
            public const string IND904 = "IND-904";
            public const string IND941 = "IND-941";
            public const string IND942 = "IND-942";
            public const string IND943 = "IND-943";
            public const string IND944 = "IND-944";
            public const string R000000701 = "R0000-007-01";
            public const string R0000020 = "R0000-020";
            public const string R0000022 = "R0000-022";
            public const string R0000024 = "R0000-024";
            public const string R0000046 = "R0000-046";
            public const string R000005201 = "R0000-052-01";
            public const string R000007501 = "R0000-075-01";
            public const string R000008001 = "R0000-080-01";
            public const string R000008101 = "R0000-081-01";
            public const string R0000082 = "R0000-082";
            public const string R000009201 = "R0000-092-01";
            public const string R000009301 = "R0000-093-01";
            public const string R000009502 = "R0000-095-02";
            public const string R000009602 = "R0000-096-02";
            public const string R000011301 = "R0000-113-01";
            public const string R0000114 = "R0000-114";
            public const string R0000115 = "R0000-115";
            public const string R000011601 = "R0000-116-01";
            public const string R0000117 = "R0000-117";
            public const string R000012301 = "R0000-123-01";
            public const string F1040EZ08701 = "F1040EZ-087-01";
            public const string R000012501 = "R0000-125-01";
            public const string R000012601 = "R0000-126-01";
            public const string R000012701 = "R0000-127-01";
            
            
            public const string R0000192 = "R0000-192";
            public const string R0000193 = "R0000-193";
            public const string R0000194 = "R0000-194";
            public const string R000050001 = "R0000-500-01";
            public const string R000050301 = "R0000-503-01";
            public const string R000090201 = "R0000-902-01";
            public const string R000090403 = "R0000-904-03";
            public const string R000090501 = "R0000-905-01";
            public const string R000090601 = "R0000-906-01";
            public const string STATE010 = "STATE-010";
            public const string STATE011 = "STATE-011";
            public const string STATE012 = "STATE-012";
            public const string STATE013 = "STATE-013";
            public const string STATE015 = "STATE-015";
            public const string STATE016 = "STATE-016";
            public const string STATE017 = "STATE-017";
            public const string STATE019 = "STATE-019";
            public const string STATE901 = "STATE-901";
            public const string STATE902 = "STATE-902";
            public const string STATE903 = "STATE-903";


            public const string IRSAPPCON000030 = "R0000-003";
            public const string IRSAPPCON000031 = "R0000-004";
            public const string IRSAPPCON000036 = "R0000-019";
            public const string IRSAPPCON000043 = "R0000-030";
            public const string IRSAPPCON000051 = "R0000-051";
            public const string IRSAPPCON000053 = "R0000-054";
            public const string R000003001 = "R0000-030-01";
            public const string R000005401 = "R0000-054-01";
            public const string R0000143 = "R0000-143";
            

            public const string FPYMT052 = "FPYMT-052";
            public const string FPYMT057 = "FPYMT-057";
            public const string R0000094 = "R0000-094";
            public const string R0000095 = "R0000-095";
            public const string R0000096 = "R0000-096";
            public const string R0000098 = "R0000-098";
            public const string R0000099 = "R0000-099";
        }
        #endregion

        #region Business Validations
        public List<BusinessMessagesDE> BusinessValidations(string SubmissionId, string IRSSchemaXml, string ManifestXml, bool testMode)
        {
            try
            {
                if (!string.IsNullOrEmpty(SubmissionId) && !string.IsNullOrEmpty(IRSSchemaXml) && !string.IsNullOrEmpty(ManifestXml))
                {
                    Return return1040EZ = (Return)Utilities.DeSerialize(IRSSchemaXml, typeof(Return));
                    IRSSubmissionManifest iRSSubmissionManifest = (IRSSubmissionManifest)Utilities.DeSerialize(ManifestXml, typeof(IRSSubmissionManifest));

                    if (null != return1040EZ)
                    {
                        //Validates the ReturnVersion
                        ValidateReturnVersion(return1040EZ.returnVersion);
                        //ValidatesReturnHeader
                        ValidatesReturnHeader(testMode, return1040EZ, iRSSubmissionManifest);
                        //Validates the ReturnData
                        ValidateReturnData(return1040EZ, iRSSubmissionManifest);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listMessagesDE;

        }
        #endregion


        private void ValidateReturnData(Return return1040, IRSSubmissionManifest iRSSubmissionManifest)
        {
            int primarytaxage = 0;
            int spouseage = 0;

            double withholdingTaxAmt = 0;

            if (return1040.ReturnHeader != null && return1040.ReturnHeader.Filer != null)
            {
                // 1 . F1040EZ-001-01
                if (!string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN))
                {

                    if (string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseNameControlTxt))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ00101;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }
                    // 3  F1040EZ-003-02
                    if (return1040.ReturnHeader.SelfSelectPINGrp != null && return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDt != DateTime.MinValue)
                    {
                        DateTime today = DateTime.Today;
                        spouseage = today.Year - return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDt.Year;
                        if (return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDt > today.AddYears(-spouseage)) spouseage--;
                        if (spouseage > 65)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.F1040EZ00302;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }
                    }
                }
            }

            // 2  F1040EZ-002-02
            if (return1040.ReturnHeader != null && return1040.ReturnHeader.SelfSelectPINGrp != null &&
                return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDt != DateTime.MinValue)
            {

                DateTime today = DateTime.Today;
                primarytaxage = today.Year - return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDt.Year;
                if (return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDt > today.AddYears(-primarytaxage)) primarytaxage--;

                if (primarytaxage > 65)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.F1040EZ00202;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

            }

            if (return1040.ReturnData != null)
            {
                if (return1040.ReturnData.IRS1040EZ != null)
                {
                    // 4 F1040EZ-004
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TaxableInterestAmt) > 1500)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ004;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    // 5 F1040EZ-005
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TaxableIncomeAmt) > 100000)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ005;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // 6  F1040EZ-006
                    if ((return1040.ReturnData.IRS1040EZ.EICEligibilityLiteralCd == IRS1040EZTypeEICEligibilityLiteralCd.NO)
                        && (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) != 0))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ006;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    // 7 F1040EZ-007
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) != 0)
                    {
                        if (return1040.ReturnData.WagesNotShownSchedule != null)
                        {
                            List<string> listWagesNotShownAmt = return1040.ReturnData.WagesNotShownSchedule.WagesNotShownSch.Where(a => a.WagesLit == WagesNotShownSchTypeWagesLit.HSH).Select(a => a.WagesNotShownAmt).ToList();

                            bool checkWagesGreaterthanZero = false;

                            if (listWagesNotShownAmt != null && listWagesNotShownAmt.Count() > 0)
                            {

                                foreach (string wagenotshown in listWagesNotShownAmt)
                                {

                                    double wagesnotshownamount = Utilities.Getdouble(wagenotshown);

                                    if (wagesnotshownamount > 0)
                                    {
                                        checkWagesGreaterthanZero = true;
                                    }
                                }

                                if (!checkWagesGreaterthanZero)
                                {
                                    messagesDE = new BusinessMessagesDE();
                                    messagesDE.ErrorCode = ErrorCode.F1040EZ007;
                                    messagesDE.Action = ErrorType.ApplicationError;
                                    listMessagesDE.Add(messagesDE);
                                }

                            }
                            else
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.F1040EZ007;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }
                        }
                        else
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.F1040EZ007;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }
                    }

                    //   8 F1040EZ-008
                    // need to rework
                    withholdingTaxAmt = Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.WithholdingTaxAmt.Value);
                    double otherWithholdingAmt = return1040.ReturnData.OtherWithholdingStatement.OtherWithholdingStmt.Select(a => Utilities.Getdouble(a.WithholdingAmt)).Sum();
                    double differenceAmount = 0;
                    if (withholdingTaxAmt != otherWithholdingAmt)
                    {
                        if (withholdingTaxAmt > otherWithholdingAmt)
                        {
                            differenceAmount = withholdingTaxAmt - otherWithholdingAmt;
                        }
                        else
                        {
                            differenceAmount = otherWithholdingAmt - withholdingTaxAmt;
                        }

                        if (differenceAmount > 5)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.F1040EZ008;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                    }


                    //   9    F1040EZ-009
                    double wagesAmtSum = return1040.ReturnData.IRSW2.Select(a => Utilities.Getdouble(a.WagesAmt)).Sum();
                    double wagesSalariesAndTipsAmt = Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.WagesSalariesAndTipsAmt.Value);

                    if (wagesAmtSum != wagesSalariesAndTipsAmt && (wagesAmtSum > wagesSalariesAndTipsAmt))
                    {
                        if (wagesSalariesAndTipsAmt - wagesAmtSum > 5)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.F1040EZ009;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                    }

                    ///  10   Done   F1040EZ-010  need to clarify BA
                    ///  
                    ///If any of the following Form 1040-EZ fields have a value, then all of these fields must have a value: Line 11b 'RoutingTransitNumber' and Line 11c  'BankAccountTypeCd' and Line 11d 'DepositorAccountNumber'.
                    if (!string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.RoutingTransitNumber) &&
                        (return1040.ReturnData.IRS1040EZ.BankAccountTypeCd == null ||
                        string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.DepositorAccountNumber)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ010;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }
                    if (return1040.ReturnData.IRS1040EZ.BankAccountTypeCd != null &&
                       (string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.RoutingTransitNumber) || string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.DepositorAccountNumber)))
                    {
                    }
                    if (!string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.DepositorAccountNumber) &&
                  (return1040.ReturnData.IRS1040EZ.BankAccountTypeCd == null || string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.RoutingTransitNumber)))
                    {
                    }


                    // 11 F1040EZ-011
                    if ((Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.RefundAmt) > 0)
                        && Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TotalPaymentsAmt) < Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TaxAmt))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ011;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }



                    ///  12       F1040EZ-012         Needs Clarity from Uma on ITIN
                    ///  
                    /// If 'PrimarySSN' in the Return Header is an ITIN, then Line 8a, 'EarnedIncomeCreditAmt' must be equal to zero if an amount is entered.


                    ///  13       F1040EZ-013         Needs Clarity from Uma on ITIN
                    ///  
                    /// If 'SpouseSSN' in the Return Header is an ITIN, then Line 8a, 'EarnedIncomeCreditAmt' must be equal to zero if an amount is entered.


                    ///  14  F1040EZ-016-02
                    if (!return1040.ReturnData.IRS1040EZ.PrimaryClaimAsDependentIndSpecified
                       && String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN) &&
                       Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.CombStdDedAndPrsnlExemptAmt) != 10000)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ01602;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    /// 15  F1040EZ-017-02
                    if ((!return1040.ReturnData.IRS1040EZ.PrimaryClaimAsDependentIndSpecified &&
                        !return1040.ReturnData.IRS1040EZ.SpouseClaimAsDependentIndSpecified)
                        && !String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN) &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.CombStdDedAndPrsnlExemptAmt) != 20000)
                    {

                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ01702;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);

                    }


                    /// 16  F1040EZ-018-02
                    if ((return1040.ReturnData.IRS1040EZ.PrimaryClaimAsDependentIndSpecified &&
                        return1040.ReturnData.IRS1040EZ.SpouseClaimAsDependentIndSpecified)
                        && !String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN) &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.CombStdDedAndPrsnlExemptAmt) > 12200)
                    {

                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ01802;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);

                    }


                    /// 17  F1040EZ-019-02
                    if (return1040.ReturnData.IRS1040EZ.PrimaryClaimAsDependentIndSpecified
                        && String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN) &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.CombStdDedAndPrsnlExemptAmt) > 6100)
                    {

                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ01902;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    /// 18  F1040EZ-020-02
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) > 487)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ02002;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///  19    F1040EZ-021-02
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) > 0
                        && String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                        && Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AdjustedGrossIncomeAmt) > 14340)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ02102;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    ///  20    F1040EZ-022-02
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) > 0
                        && !String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                        && Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AdjustedGrossIncomeAmt) > 19680)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ02202;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///  21   F1040EZ-023
                    if (return1040.ReturnData.IRS1040EZ.PrimaryClaimAsDependentIndSpecified &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) != 0)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ023;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    ///  22   F1040EZ-024
                    if (return1040.ReturnData.IRS1040EZ.SpouseClaimAsDependentIndSpecified &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) != 0)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ024;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///  23   F1040EZ-025
                    if (return1040.ReturnData.IRS1040EZ.SpouseClaimAsDependentIndSpecified &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) != 0)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ025;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///  24   F1040EZ-026
                    if ((return1040.ReturnData.IRS1040EZ.AdjustedGrossIncomeAmt != null ||
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AdjustedGrossIncomeAmt) == 0)
                     &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AdjustedGrossIncomeAmt) !=
                        (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.WagesSalariesAndTipsAmt) +
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.UnemploymentCompAmt)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ026;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///  25  F1040EZ-027
                    /// 
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) > 0 &&
                      !((primarytaxage > 25 && primarytaxage < 65) ||
                      (spouseage > 25 && spouseage < 65)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ027;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    ///  26 F1040EZ-028   Done  As per BA Discussion  ( Combat Pay has been excluded from Wages) is not considered

                    if (withholdingTaxAmt >
                        (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.WagesSalariesAndTipsAmt) +
                          Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TaxableInterestAmt) +
                          Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.UnemploymentCompAmt)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ028;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    ///  27  F1040EZ-029
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AmountOwedAmt) > 0
                        && (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TaxAmt) < Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.TotalPaymentsAmt)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ029;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///  28  F1040EZ-044
                    ///     Form 1040EZ, Line 8a 'EarnedIncomeCreditAmt' must have a zero value if an amount is entered.  
                    ///     e-File database indicates the taxpayer is not allowed to claim Earned Income Credit for this tax year.


                    ///   29   F1040EZ-046
                    if ((return1040.ReturnHeader.Filer.Item != null && return1040.ReturnHeader.Filer.GetType().Name == "ForeignAddressType")
                        && Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.EarnedIncomeCreditAmt) != 0)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ046;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    ///   30   F1040EZ-049  
                    ///   If 'SpouseSSN' is has a value in the Return Header,  and on Form 1040EZ, 
                    ///   [both 'PrimaryDateOfDeath' and 'SpouseDateOfDeath' has a value] and
                    ///   Line 11a 'RefundAmt' has a non-zero value, then two Forms 1310 must be present in the return.

                    ///   31  F1040EZ-050
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                       && return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeathSpecified &&
                       !return1040.ReturnData.IRS1040EZ.SurvivingSpouseIndSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ050;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }



                    ///   32   F1040EZ-051
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                      && return1040.ReturnData.IRS1040EZ.SpouseDateOfDeathSpecified &&
                      !return1040.ReturnData.IRS1040EZ.SurvivingSpouseIndSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ051;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    ///   32   F1040EZ-054
                    if (string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                      && return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeathSpecified && return1040.ReturnData.IRS1040EZ.SpouseDateOfDeathSpecified &&
                      !(return1040.ReturnData.IRS1040EZ.PersonalRepresentativeInd ==CheckboxType.X))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ054;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }



                    /// 33  F1040EZ-052
                    /// If 'SpouseSSN' does not have a value in the Return Header and Form 1040EZ, 'PrimaryDateOfDeath' has a value and Line 11a 'RefundAmt' has a non-zero value, then no more than one Form 1310 must be present in the return.

                    /// 34  F1040EZ-061-01
                    if (!String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                        && return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeath != DateTime.MinValue &&
                        (return1040.ReturnHeader.Filer.NameLine1Txt != "DECD" || return1040.ReturnHeader.Filer.NameLine1Txt != "<DECD"))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ06101;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    /// 35  F1040EZ-062-01   Doubt 
                    if (!String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                         && return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeath != DateTime.MinValue &&
                         return1040.ReturnHeader.Filer.NameLine1Txt != "DECD &")
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ06201;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    /// 36  F1040EZ-063-01
                    if (!String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                        && return1040.ReturnData.IRS1040EZ.SpouseDateOfDeath != DateTime.MinValue &&
                        return1040.ReturnHeader.Filer.NameLine1Txt != "DECD")
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ06301;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    List<IRSW2TypeEmployersUseGrp> lstirsw2 = new List<IRSW2TypeEmployersUseGrp>();
                    double employersUseAmt = 0;
                    foreach (IRSW2 irslocal in return1040.ReturnData.IRSW2)
                    {

                        employersUseAmt = employersUseAmt + irslocal.EmployersUseGrp.Where(a => a.EmployersUseCd == "Q").Select(a => Utilities.Getdouble(a.EmployersUseAmt)).Sum();


                    }


                    // lstirsw2 = return1040.ReturnData.IRSW2.Select(a => a.EmployersUseGrp).ToList();

                    //     double employersUseAmt = lstirsw2.Where(a => a.EmployersUseCd == "Q").Select(a => Utilities.Getdouble(a.EmployersUseAmt)).Sum();

                    /// 37  F1040EZ-064
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.NontxCombatPayElectionAmt) > 0 &&
                       (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.NontxCombatPayElectionAmt) != employersUseAmt))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ064;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    // 38  F1040EZ-065   Need Clarifications . Are we going to support Form 8888
                    /// Form 8888 must not be present in the return if any one of the following lines of Form 1040EZ has a value: Line 11b 'RoutingTransitNumber' or Line 11c 'BankAccountTypeCd' or Line 11d 'DepositorAccountNumber'.


                    // 39  F1040EZ-071-01
                    if (!String.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN)
                        && !return1040.ReturnHeader.SpousePINEnteredByCdSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ07101;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  40   F1040EZ-073-01
                    if (string.IsNullOrEmpty(return1040.ReturnHeader.PrimarySignaturePIN))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ07301;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }  //  G2   IND-056-01
                    else if (!return1040.ReturnHeader.PrimaryPINEnteredByCdSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND05601;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G2  IND-058-01
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.PrimarySignaturePIN) && !return1040.ReturnHeader.PrimarySignatureDtSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND05801;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //     41  F1040EZ-088     Supporting 1310
                    //  If Form 1040EZ, 'SpouseSSN' has a value in the Return Header and both 'PrimaryDateOfDeath' and 'SpouseDateOfDeath' have a value, then checkbox 'PersonalRepresentativeInd' must be checked.


                    // 42  F1040EZ-336    Supporting 1310   Need clarity from Uma
                    //  If 'SpouseSSN' does not have a value in the Return Header and Form 1040EZ, 'PrimaryDateOfDeath' has a value and Line 11a 'RefundAmt' has a non-zero value, then Form 1310 must be attached to Form 1040EZ.

                    // 43   F1040EZ-411
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AmountOwedAmt) > 0 &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.RefundAmt) != 0)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ411;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //   44     F1040EZ-412
                    if (Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.RefundAmt) > 0 &&
                        Utilities.Getdouble(return1040.ReturnData.IRS1040EZ.AmountOwedAmt) != 0)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ412;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    // 45   F1040EZ-510  We cant check it… Its not possible by Us. Only IRS can check
                    /// If Form 1040EZ, Line 5 checkbox 'PrimaryClaimAsDependentInd' is not checked, then 'PrimarySSN' in the Return Header must not be equal to a 'DependentSSN' on another tax return.
                    /// 

                    //  46  F1040EZ-511  We cant check it… Its not possible by Us. Only IRS can check
                    //  Primary SSN in the Return Header must not be equal to the Spouse SSN on another tax return in which the Filing Status is "Married filing separately".

                    //  47  F1040EZ-513  We cant check it… Its not possible by Us. Only IRS can check
                    // If Form 1040EZ, Line 5 checkbox 'SpouseClaimAsDependentInd' is not checked, then Spouse SSN in the Return Header must not be the same as a 'DependentSSN' on another tax return.

                    //  48  F1040EZ-524-01  We cannot test  irs only DO
                    //  If 'PINTypeCd' in the Return Header has the value "Self-Select On-Line" and Form 1040EZ, filing status is not "Married filing jointly" ('SpouseSSN' does not have a value in the Return Header), then 'PrimaryBirthDt' in the Return Header must match the e-File database.


                    //  G2  IND-021-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectOnLine &&
                        !string.IsNullOrEmpty(return1040.ReturnHeader.PrimarySignaturePIN) &&
                        return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDt == DateTime.MinValue)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02101;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2 IND-022-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectOnLine &&
                        !string.IsNullOrEmpty(return1040.ReturnHeader.SpouseSignaturePIN) &&
                        return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDt == DateTime.MinValue)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02201;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-023-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectPractitioner &&
                        !string.IsNullOrEmpty(return1040.ReturnHeader.PrimarySignaturePIN) &&
                        return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDt == DateTime.MinValue)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02301;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-024-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectPractitioner &&
                        !string.IsNullOrEmpty(return1040.ReturnHeader.SpouseSignaturePIN) &&
                        return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDt == DateTime.MinValue)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02401;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-025-01
                    if ((return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectOnLine &&
                         return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDtSpecified)
                        && (Utilities.GetInt32(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryPriorYearAGIAmt) == 0
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryPriorYearPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryElectronicFilingPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.IdentityProtectionPIN)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02501;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G2  IND-060
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.IdentityProtectionPIN)
                        && return1040.ReturnHeader.IdentityProtectionPIN == Constants.ZeroPIN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND060;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //  G2  IND-026-01
                    if ((return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectPractitioner &&
                         return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDtSpecified)
                        && (Utilities.GetInt32(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryPriorYearAGIAmt) == 0
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryPriorYearPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryElectronicFilingPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.IdentityProtectionPIN)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02601;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //  G2  IND-027-01
                    if ((return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectOnLine &&
                         return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDtSpecified)
                        && (Utilities.GetInt32(return1040.ReturnHeader.SelfSelectPINGrp.SpousePriorYearAGIAmt) == 0
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.SpousePriorYearPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.SpouseElectronicFilingPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SpouseIdentityProtectionPIN)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02701;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //  G2  IND-028-01
                    if ((return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectPractitioner &&
                         return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDtSpecified)
                        && (Utilities.GetInt32(return1040.ReturnHeader.SelfSelectPINGrp.SpousePriorYearAGIAmt) == 0
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.SpousePriorYearPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.SpouseElectronicFilingPIN)
                        || string.IsNullOrEmpty(return1040.ReturnHeader.SpouseIdentityProtectionPIN)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND02801;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //  G2  IND-063
                    if (return1040.ReturnHeader.ReturnTs == DateTime.MinValue)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND063;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-694-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectPractitioner &&
                        return1040.ReturnHeader.JuratDisclosureCd != ReturnHeaderTypeJuratDisclosureCd.SelfSelectPINByERO)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND69401;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-695-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.Practitioner &&
                        return1040.ReturnHeader.JuratDisclosureCd != ReturnHeaderTypeJuratDisclosureCd.PractitionerPIN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND69501;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-696-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectOnLine &&
                        return1040.ReturnHeader.JuratDisclosureCd != ReturnHeaderTypeJuratDisclosureCd.OnlineSelfSelectPIN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND69601;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G2  IND-699-01
                    if (return1040.ReturnHeader.PINTypeCd == PINCodeType.Practitioner
                           && (Utilities.GetInt32(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryPriorYearAGIAmt) != 0
                        || !string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryPriorYearPIN)
                        || !string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.PrimaryElectronicFilingPIN)
                        || Utilities.GetInt32(return1040.ReturnHeader.SelfSelectPINGrp.SpousePriorYearAGIAmt) != 0
                        || !string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.SpousePriorYearPIN)
                        || !string.IsNullOrEmpty(return1040.ReturnHeader.SelfSelectPINGrp.SpouseElectronicFilingPIN)))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND69901;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G2  IND-769
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.IdentityProtectionPIN) &&
                    Utilities.IsNumeric(return1040.ReturnHeader.IdentityProtectionPIN))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND769;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  IND-770
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.SpouseIdentityProtectionPIN) &&
                   Utilities.IsNumeric(return1040.ReturnHeader.SpouseIdentityProtectionPIN))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND770;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-672-01
                    if ((return1040.ReturnHeader.PINTypeCd == PINCodeType.Practitioner || return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectPractitioner)
                        && return1040.ReturnHeader.OriginatorGrp.OriginatorTypeCd == null)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND67201;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-673-01
                    if ((return1040.ReturnHeader.PINTypeCd == PINCodeType.SelfSelectOnLine)
                        && return1040.ReturnHeader.OriginatorGrp.OriginatorTypeCd != null)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND67301;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  R0000-030-01
                    if (return1040.ReturnHeader.OriginatorGrp.EFIN != return1040.ReturnHeader.OriginatorGrp.PractitionerPINGrp.EFIN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.R000003001;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G2  R0000-054-01
                    if (iRSSubmissionManifest.EFIN != return1040.ReturnHeader.OriginatorGrp.EFIN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.R000005401;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // R0000-143
                   if ( String.IsNullOrEmpty (iRSSubmissionManifest.TaxYear ))
                   {
                         messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.R0000143;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                   }

                    // G2  IND-042
                    if (return1040.ReturnData.IRS1040EZ.PowerOfAttorneySignedBySpecified && return1040.ReturnData.IRS1040EZ.SurvivingSpouseIndSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND042;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-043
                    if (return1040.ReturnData.IRS1040EZ.PowerOfAttorneySignedBySpecified && return1040.ReturnData.IRS1040EZ.PersonalRepresentativeIndSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND043;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-044
                    if (return1040.ReturnData.IRS1040EZ.PowerOfAttorneySignedBySpecified && return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDtSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND044;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    //  G2  IND-045
                    if (return1040.ReturnData.IRS1040EZ.PowerOfAttorneySignedBySpecified && return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDtSpecified)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND045;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }





                    //  49 F8862-001-01  Are we going todo Form 8862
                    //Form 8862, Line 1 'EICEligClmFilingYr' must be equal to 'TaxYr' in the Return Header.


                    // 50 FPYMT-064-01 We cannot test  irs only DO
                    // 'PaymentAmt' in the IRS Payment Record must not be more than 200% of the Form 1040EZ, Line 12 'AmountOwedAmt' amount. If a value is not provided on Form 1040EZ, Line 12, treat that value as zero.

                    // 51  FPYMT-068-01
                    if (Utilities.Getdouble(return1040.ReturnData.IRSPayment.PaymentAmt) > 99999999)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.FPYMT06801;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // 52 FPYMT-069-01
                    if (return1040.ReturnData.IRSESPayment.Select(a => Utilities.Getdouble(a.PaymentAmt)).Sum() > 99999999)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.FPYMT06901;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    // ** 53 FPYMT-071-01  need to do
                    if ((return1040.ReturnData.IRSPayment.RequestedPaymentDt - DateTime.Today).TotalDays > 5)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.FPYMT07101;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //// ** 54 FPYMT-071-01  need to do
                    //if ((return1040.ReturnData.IRSPayment.RequestedPaymentDt - DateTime.Today).TotalDays > 5)
                    //{
                    //    messagesDE = new BusinessMessagesDE();
                    //    messagesDE.ErrorCode = ErrorCode.FPYMT07201;
                    //    messagesDE.Action = ErrorType.ApplicationError;
                    //    listMessagesDE.Add(messagesDE);
                    //}


                    // **  55   FPYMT-074-01
                    //  If the return is received after the due date of the return, then the 'RequestedPaymentDt' in the IRS Payment Record must not be later than the date the return was received.
                    // return1040.ReturnData.IRSPayment.d


                    if (return1040.ReturnData.IRSW2 != null)
                    {

                        // 56 FW2-002
                        if (return1040.ReturnData.IRSW2.Select(a => Utilities.Getdouble(a.WagesAmt)).Sum() < 0)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.FW2002;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }


                        // 57 FW2-003-01

                        if (!return1040.ReturnData.IRSW2.Select(a => a.EmployeeSSN == return1040.ReturnHeader.Filer.SpouseSSN || a.EmployeeSSN == return1040.ReturnHeader.Filer.PrimarySSN).Any())
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.FW200301;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }


                        foreach (IRSW2 localirsw2 in return1040.ReturnData.IRSW2)
                        {
                            // 58  FW2-008

                            if (localirsw2.Item.GetType().Name == "EmployerForeignAddress")
                            {
                                OtherForeignAddressType ohterforeignAddress = (OtherForeignAddressType)localirsw2.Item;

                                if (string.IsNullOrEmpty(ohterforeignAddress.City))
                                {
                                    messagesDE = new BusinessMessagesDE();
                                    messagesDE.ErrorCode = ErrorCode.FW2008;
                                    messagesDE.Action = ErrorType.ApplicationError;
                                    listMessagesDE.Add(messagesDE);
                                }

                                if (!string.IsNullOrEmpty(ohterforeignAddress.City) && ohterforeignAddress.City.Length > 3)
                                {
                                    messagesDE = new BusinessMessagesDE();
                                    messagesDE.ErrorCode = ErrorCode.FW2007;
                                    messagesDE.Action = ErrorType.ApplicationError;
                                    listMessagesDE.Add(messagesDE);
                                }




                            }


                            //  59 FW2-007
                            if (localirsw2.Item.GetType().Name == "USAddressType")
                            {
                                USAddressType usAddressType = (USAddressType)localirsw2.Item;
                                if (string.IsNullOrEmpty(usAddressType.City))
                                {
                                    messagesDE = new BusinessMessagesDE();
                                    messagesDE.ErrorCode = ErrorCode.FW2007;
                                    messagesDE.Action = ErrorType.ApplicationError;
                                    listMessagesDE.Add(messagesDE);
                                }

                                if (!string.IsNullOrEmpty(usAddressType.City) && usAddressType.City.Length > 3)
                                {
                                    messagesDE = new BusinessMessagesDE();
                                    messagesDE.ErrorCode = ErrorCode.FW2008;
                                    messagesDE.Action = ErrorType.ApplicationError;
                                    listMessagesDE.Add(messagesDE);
                                }
                            }

                        }

                        //   60 We cant check it… Its not possible by Us. Only IRS can check
                        //   Form W-2, Line B 'EmployerEIN' is invalid for processing an Individual e-filed return
                        //   61 We cant check it… Its not possible by Us. Only IRS can check\
                        //   Form W-2, Line B 'EmployerEIN' must match data in the eFile database.
                        //   62 We cant check it… Its not possible by Us. Only IRS can check
                        //  Form W-2, Line B 'EmployerEIN' was issued after the Tax Year in the Return Header.


                        //  63   IND-001-01
                        if ((return1040.ReturnHeader.Filer.PrimarySSN == PreparerSSNZeros || return1040.ReturnHeader.Filer.PrimarySSN == PreparerSSNNines))
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND00101;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        //  64   IND-002
                        if (return1040.ReturnHeader.TaxPeriodEndDt > return1040.ReturnHeader.ReturnTs)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND002;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        //  65  IND-005-01   Are we supporting 9465 Form?   Not supported
                        //  If Form 9465 and IRS Payment Record are present in the return, then Form 9465, 'PaymentAmt' must be equal to 'PaymentAmt' in IRS Payment Record.



                        //  69 IND-012
                        //  70 IND-013-01  
                        //  71 IND-014-01
                        //  72 IND-015
                        //  73 IND-016

                        // 74 IND-033-01

                        if (return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeathSpecified)
                        {
                           

                            if (Utilities.GetInt32(return1040.ReturnHeader.TaxYr) < return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeath.Year)
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND03301;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }

                            //  IND-018-01  Need Clarification
                          if(String.IsNullOrEmpty(   return1040.ReturnHeader.Filer.InCareOfNm))
                          {
                                 messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND01801;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                          }

                            // 78 IND-037

                            if (return1040.ReturnHeader.Filer.Item.GetType().Name == "ForeignAddress")
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND037;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }

                        }

                        // 75  IND-034-01
                        if (return1040.ReturnData.IRS1040EZ.SpouseDateOfDeathSpecified)
                        {
                              //  IND-018-01  Need Clarification
                          if(string.IsNullOrEmpty(   return1040.ReturnHeader.Filer.InCareOfNm))
                          {
                                 messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND01901;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                          }


                            if (return1040.ReturnHeader != null && Utilities.GetInt32(return1040.ReturnHeader.TaxYr) < return1040.ReturnData.IRS1040EZ.SpouseDateOfDeath.Year)
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND03401;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }

                            // 79 IND-038
                            if (return1040.ReturnHeader != null && return1040.ReturnHeader.Filer.Item.GetType().Name == "ForeignAddress")
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND038;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }


                        }
                        // 76  We cant check it… Its not possible by Us. Only IRS can check
                        // 'PrimaryDateOfDeath' in the return must match that in the e-File database.
                        // 77  We cant check it… Its not possible by Us. Only IRS can check
                        // 'SpouseDateOfDeath' in the return must match that in the e-File database.


                        /// 78  Done   line  797
                        /// 

                        // 79  Done   line  797


                        // 80 IND-039
                        if (return1040.ReturnData.IRS1040EZ.ThirdPartyDesigneeInd && string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.ThirdPartyDesigneeName))
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND039;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // 81 IND-040
                        if (return1040.ReturnData.IRS1040EZ.ThirdPartyDesigneeInd && string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.ThirdPartyDesigneePhone))
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND040;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // 82 IND-041
                        if (return1040.ReturnData.IRS1040EZ.ThirdPartyDesigneeInd && string.IsNullOrEmpty(return1040.ReturnData.IRS1040EZ.ThirdPartyDesigneePIN))
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND041;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // 83  84  not needed
                        // Form 8862 must be present in the return.  e-File database indicates the taxpayer must file Form 8862 to Claim Earned Income Credit after disallowance.
                        // Tax returns from the U.S. Possessions of American Samoa, Guam, U.S. Virgin Islands and the Commonwealth of the Northern Mariana Islands may not be electronically filed.



                        //  86  IND-061  We cant check it… Its not possible by Us. Only IRS can check - Need analysis on what is  ES payment Record
                        // IRS ES Payment Record must not be present in a prior year return.

                        // **  87  IP PIN???	Need analsysis by BA and if not able to identify, have to check with Uma
                        // Primary taxpayer's Identity Protection Personal Identification Number (IP PIN) must match the e-File database.  Please double check your entry and resubmit your return with the correct number.

                        // ** 88 IP PIN???	Need analsysis by BA and if not able to identify, have to check with Uma	IND-181	
                        // The Primary Taxpayer did not enter a valid Identity Protection Personal Identification Number (IP PIN).  Please  visit www.irs.gov/get-an-ippin for further information and resubmit your return with the correct number.

                        // ** 89 IP PIN???	Have to decide based on IRS checking	IND-182	The Spouse Identity Protection Personal Identification Number (IP PIN) must match the e-File database. Please double check your entry and resubmit your return with the correct number.

                        // **  90			IP PIN???	Have to decide based on IRS checking	IND-183	The Spouse did not enter a valid Identity Protection Personal Identification Number (IP PIN).  Please  visit www.irs.gov/get-an-ippin for further information and resubmit your return with the correct number.


                        // 91 We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-508	Primary SSN in the Return Header must not be equal to the Spouse SSN on another tax return  for which filing status is Married Filing Jointly or  [filing status is Married Filing Separately and the Spouse exemption is claimed].	Primary SSN in the Return header must not be equal to Spouse SSN on another tax return for which filing status is Married Filing jointly or (filing status is Married filing separately and the sp
                        // 92 We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-510	Spouse SSN in the Return Header must not be equal to the Primary SSN on another tax return.	Spouse SSN in the return header not equal to taxpayer SSN on another tax return.
                        // 93 We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-513	The Spouse SSN in the Return Header must not be equal to the Spouse SSN in another return filed for the same tax year.	Spouse SSN in the return header not equal to  spouse SSN on another tax return.
                        // 94 We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-515	The Primary SSN in the Return Header must not be equal to the Primary SSN in another return filed for the same tax year.	Taxpayer SSN in the return header not equal to  taxpayer SSN on another tax return.




                        //  96 IND-531-01
                        if (return1040.ReturnHeader != null && Utilities.GetInt32(return1040.ReturnHeader.TaxYr) < return1040.ReturnData.IRS1040EZ.PrimaryDateOfDeath.Year)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND53101;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // 97  IND-532-01
                        if (return1040.ReturnHeader != null && Utilities.GetInt32(return1040.ReturnHeader.TaxYr) < return1040.ReturnData.IRS1040EZ.SpouseDateOfDeath.Year)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.IND53201;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }





                        //100  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-901	The Primary SSN in the Return Header has been locked because Social Security Administration records indicate the number belongs to a deceased individual.	taxpayer SSN has been locked by SSA department because the primary SSN in return header belongs to deceased individual .  Hence, IRS will reject the tax return.
                        //101  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-902	The Primary SSN in the Return Header has been locked.  The account was locked per the taxpayer's request.	 primary SSN in the return header  has been locked because the account has been locked per taxpayer's request.
                        //102  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-903	The Primary SSN in the Return Header has been systemically locked based on IRS information which indicates there is not a filing requirement for this SSN.	The taxpayer SSN has been systemically locked based on IRS information which indicates that there is no filing requirement for this taxpayer SSN.
                        //103  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-904	The Primary SSN in the Return Header has been locked.  Social Security Administration records indicate the SSN belongs to a minor.  The account was locked per the request of the minor's parent or guardian.	The taxpayer SSN has been locked because the SSA department indicates the SSN belongs to a minor. And the account was locked per the request of minor parent or guardian.
                        //104  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-941	The Spouse SSN in the Return Header has been locked because Social Security Administration records indicate the number belongs to a deceased individual.	Sposue SSN has been locked by SSA department because the spouse SSN in return header belongs to deceased individual .  
                        //105  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-942	The Spouse SSN in the Return Header has been locked.  The account was locked per the taxpayer's request.   	Spouse SSN in the return header  has been locked because the account has been locked per taxpayer's request.
                        //106  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-943	The Spouse SSN in the Return Header has been systemically locked based on IRS information which indicates there is not a filing requirement for this SSN.	The Spouse SSN has been systemically locked based on IRS information which indicates that there is no filing requirement for this SSN.
                        //107  We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	IND-944	The Spouse SSN in the Return Header has been locked.  Social Security Administration records indicate the SSN belongs to a minor.  The account was locked per the request of the minor's parent or guardian.	The Spouse SSN has been locked because the SSA department indicates the SSN belongs to a minor. And the account was locked per the request of minor parent or guardian.


                        // 108 Doubt
                        //**  108 R0000-007-01   For US Addresses, the first five digits of the Zip Code of the Filer's address 
                        // in the Return Header must be within the valid ranges of zip codes for the corresponding State Abbreviation. See Publication 4164.





                        //  109 110 111 112  Done Above






                        //  114  need to do



                        // 117  R0000-082

                        if (iRSSubmissionManifest.TaxPeriodBeginDate == DateTime.MinValue || iRSSubmissionManifest.TaxPeriodEndDate == DateTime.MinValue)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.R0000082;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // ** 118			Need Clarification on ATIN and ITIN	Have to decide based on IRS checking	R0000-092-01	'PrimarySSN' in the Return Header must be within the valid range of SSN/ITIN and must not be an ATIN.	The primary SSN in the return header must be with valid range of SSN/ITIN and must not be in ATIN(Adoption taxpayer identificaiton number)
                        // **119			Need Clarification on ATIN and ITIN	Have to decide based on IRS checking	R0000-093-01	If 'SpouseSSN' in the Return Header has a value, then it must be within the valid range of SSN/ITIN and must not be an ATIN.	The Spouse SSN in the return header must be with valid range of SSN/ITIN and must not be in ATIN(Adoption taxpayer identificaiton number)
                        // 122  Not Supported Need Clarification on ATIN and ITIN - Are we Supporting Paid Preparer?		R0000-113-01	The eight numeric digits of the STIN (of the Paid Preparer) following the letter S, must not equal all zeros or all nines in the Return Header.

                        // 123  R0000-114
                        if (iRSSubmissionManifest.TaxPeriodBeginDate.Day != 1 || iRSSubmissionManifest.TaxPeriodBeginDate.Month != 1)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.R0000114;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // 123  R0000-115
                        if (iRSSubmissionManifest.TaxPeriodEndDate.Day != 31 || iRSSubmissionManifest.TaxPeriodEndDate.Month != 12)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.R0000115;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }


                        // 125   R0000-116-01  Done Above
                        // 126   R0000-117  Done Above
                        // 127 R0000-123-01 Done Above

                        //**128	Need to DO				R0000-192	Phone Number provided in the return must not be all zeros.
                        //** 129  Need to do R0000-193	Bank Account Number provided in the return must not be all zeros.
                        //     if(return1040.ReturnData.


                        //130   We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	R0000-194	Return must not be a duplicate of a previously accepted return.
                        // 131   We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	R0000-500-01	'PrimarySSN' and 'PrimaryNameControlTxt' in the Return Header must match the e-File database.
                        ///132   Is this relevant to F1040EZ? What is line 6B ?	Not supported	R0000-503-01	'SpouseSSN' and the 'SpouseNameControlTxt' in the Return Header (or Line 6b 'ExemptSpouseNameControl' in the return  - For 1040/1040A returns) must match the e-File database.
                        //133   We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	R0000-902-01	Taxpayer TIN in the Return Header must not be the same as a TIN of a previously accepted electronic return for the return type and tax period indicated in the tax return.
                        //134			By Successful Certification Process	Not needed.	R0000-904-03	Software ID in the Return Header must have passed testing for the form family and 'TaxYr'.
                        //135			Software Id is provided by IRS to US	Not needed.	R0000-905-01	Electronic Filing Identification Number (EFIN) in the Return Header must be listed in the e-File database and in accepted status.

                        //                       136			We cant check it… Its not possible by Us. Only IRS can check 	Have to decide based on IRS checking	R0000-906-01	Routing Transit Number (RTN) included in the return must be present in the e-File database.
                        //137			is this relevant to State Return???	BA will check and confirm whether this validation is needed	STATE-010	The Tax Year referenced in the State Submission Manifest must match the Tax Year of the linked Federal return.
                        //138				BA will check and confirm whether this validation is needed	STATE-011	An SSN (either the Primary or the Spouse) referenced in the State Submission Manifest must match an SSN (either the Primary or the Spouse) of a linked Federal return.
                        //139			Need to Analyse on State return efiling	BA will check and confirm whether this validation is needed	STATE-012	The State Submission category that was filed is not being accepted by Modernized e-File (MeF) at this time.  Please check the MeF web page under irs.gov for more information.  The submission category filed was <category>.
                        //140				BA will check and confirm whether this validation is needed	STATE-013	The ETIN associated with the Individual submission is not a participating transmitter.  Please check the Modernized e-File (MeF) web page under irs.gov for more information on participation rules.
                        //141				BA will check and confirm whether this validation is needed	STATE-015	If the Submission Category in the State Submission Manifest has a value of ("CORP" or "PART" or "IND" or "EO" or "ESTRST"), then 'TaxYear'  in the State Submission Manifest must be be valid for the current or prior year returns that are being accepted by Modernized e-File (MeF).
                        //142				BA will check and confirm whether this validation is needed	STATE-016	If the Submission Category in the State Submission Manifest has a value of ("CORPEP" or "PARTEP" or "INDEP"or "ESTRSTEP"), then 'TaxYear'  in the State Submission Manifest must be the same as processing year.
                        //143				BA will check and confirm whether this validation is needed	STATE-017	If the Submission Category in the State Submission Manifest has a value of ("CORPEP" or "PARTEP" or "INDEP"or "ESTRSTEP"), then 'IRSSubmissionId' in the State Submission Manifest must not have a value.
                        //144				BA will check and confirm whether this validation is needed	STATE-019	In the State Submission Manifest, if the Submission Category has a value of ("IND" or "INDEP"), then ( 'PrimarySSN'  and 'PrimaryNameControl' ) or 'TempID' must have a value.
                        //145				BA will check and confirm whether this validation is needed	STATE-901	The IRS Submission ID referenced in the State Submission Manifest must be present in the e-File database.
                        //146			Accepted status means….	BA will check and confirm whether this validation is needed	STATE-902	The IRS Submission ID referenced in the State Submission Manifest must be in accepted status.
                        //147			EFIN Id is provided by IRS to US	BA will check and confirm whether this validation is needed	STATE-903	Electronic Filing Identification Number (EFIN) in the State Submission Manifest must be approved and present in the e-File database.

                    }

                }
            }


            ValidateReturnDocumentCount(return1040.ReturnData);

        }


        private string EditPhoneNumber(string phoneNo)
        {
            phoneNo = phoneNo.Replace("-", "");
            phoneNo = phoneNo.Replace("(", "");
            phoneNo = phoneNo.Replace(")", "");
            return phoneNo;
        }



        #region ValidatesReturnHeader
        private void ValidatesReturnHeader(bool testMode, Return return1040, IRSSubmissionManifest iRSSubmissionManifest)
        {
            if (return1040.ReturnHeader != null)
            {
                ValidateReturnHeader(return1040, testMode);
                if (null != iRSSubmissionManifest)
                {
                    ValidateIRSManiFestXml(return1040, iRSSubmissionManifest);
                }

                // 113 R0000-052-01
                if (return1040.ReturnHeader.TaxYr != iRSSubmissionManifest.TaxYear)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.R000005201;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }


                // 98 IND-570-01
                if (Utilities.GetInt32(return1040.ReturnHeader.TaxYr) < return1040.ReturnHeader.SelfSelectPINGrp.SpouseBirthDt.Year)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND57001;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                // 95	IND-521-01	The Year of Birth of the Primary SSN must not be greater than the 'TaxYr' in the Return Header.
                if (Utilities.GetInt32(return1040.ReturnHeader.TaxYr) < return1040.ReturnHeader.SelfSelectPINGrp.PrimaryBirthDt.Year)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND52101;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                //  115   R0000-080-01
                if (return1040.ReturnHeader.TaxPeriodBeginDt != iRSSubmissionManifest.TaxPeriodBeginDate)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.R000008001;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                //  116   R0000-081-01
                if (return1040.ReturnHeader.TaxPeriodEndDt != iRSSubmissionManifest.TaxPeriodEndDate)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.R000008101;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                // 67   IND-010
                if (return1040.ReturnHeader.TaxYr != return1040.ReturnHeader.TaxPeriodBeginDt.Year.ToString())
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND010;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                // 68   IND-011
                if (return1040.ReturnHeader.TaxYr != return1040.ReturnHeader.TaxPeriodEndDt.Year.ToString())
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND011;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                // 120  R0000-095-02
                if (return1040.ReturnHeader.PrimarySignaturePIN == Constants.ZeroPIN)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.R000009502;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                // 120  IND-066
                if (return1040.ReturnHeader.SpouseIdentityProtectionPIN == Constants.ZeroPIN)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND066;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                //    G2  IND-057-01
                if (!string.IsNullOrEmpty(return1040.ReturnHeader.SpouseSignaturePIN) && !return1040.ReturnHeader.SpousePINEnteredByCdSpecified)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND05701;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                //    G2  IND-059-01
                if (!string.IsNullOrEmpty(return1040.ReturnHeader.SpouseSignaturePIN) && !return1040.ReturnHeader.SpouseSignatureDtSpecified)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND05901;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                //    121  R0000-096-02
                if (return1040.ReturnHeader.SpouseSignaturePIN == Constants.ZeroPIN)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.R000009602;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                // 99 IND-689-01
                if (Utilities.GetInt32(return1040.ReturnHeader.TaxYr) != return1040.ReturnHeader.PrimarySignatureDt.Year)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IND68901;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

                if (return1040.ReturnHeader.Filer != null)
                {

                    //  **  85 IND-052    Is TIN equal to SSN?   Need to confirm with Uma
                    // The TIN present in the IRS Submission Manifest must be equal to the Primary SSN in the Return Header.
                    if (iRSSubmissionManifest.TIN != return1040.ReturnHeader.Filer.PrimarySSN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND052;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }


                    //  66  IND-006
                    if (return1040.ReturnHeader.Filer.PrimarySSN == return1040.ReturnHeader.Filer.SpouseSSN)
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.IND006;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }



                    // 127  R0000-123-01
                    if (return1040.ReturnHeader.Filer.NameLine1Txt.Contains('&') && string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.R000012301;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G  F1040EZ-087-01
                    if (!string.IsNullOrEmpty(return1040.ReturnHeader.Filer.SpouseSSN) && !return1040.ReturnHeader.Filer.NameLine1Txt.Contains('&'))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.F1040EZ08701;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    }

                    // G R0000-125-01
                    if (!return1040.ReturnHeader.Filer.NameLine1Txt.Contains('<'))
                    {
                        messagesDE = new BusinessMessagesDE();
                        messagesDE.ErrorCode = ErrorCode.R000012501;
                        messagesDE.Action = ErrorType.ApplicationError;
                        listMessagesDE.Add(messagesDE);
                    } //  G2  R0000-126-01
                    else 
                    {
                        if (return1040.ReturnHeader.Filer.NameLine1Txt.Count(x => x == '<') > 2)
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.R000012601;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }

                        // G2 R0000-127-01

                        char nametxtvalue=return1040.ReturnHeader.Filer.NameLine1Txt.Substring(return1040.ReturnHeader.Filer.NameLine1Txt.IndexOf('<'), 
                            return1040.ReturnHeader.Filer.NameLine1Txt.IndexOf('<') + 1)[0];
                        if (!Char.IsLetter(nametxtvalue))
                        {
                            messagesDE = new BusinessMessagesDE();
                            messagesDE.ErrorCode = ErrorCode.R000012701;
                            messagesDE.Action = ErrorType.ApplicationError;
                            listMessagesDE.Add(messagesDE);
                        }
                    }


                    if (return1040.ReturnHeader.Filer.Item != null)
                    {

                        if (return1040.ReturnHeader.Filer.Item.GetType().Name == Constants.USAddress)
                        {
                            USAddressType usaddress = (USAddressType)return1040.ReturnHeader.Filer.Item;

                            int threedigitZipCode = Utilities.GetInt32(usaddress.ZIPCode.Substring(0, 3));


                            //  109  R0000-020
                            if (usaddress.State == StateType.AA && threedigitZipCode != 340)
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.R0000020;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }

                            // G2 IND-055-01
                            if (!string.IsNullOrEmpty(usaddress.AddressLine2))
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.IND05501;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }


                            // 110  R0000-022
                            if (usaddress.State == StateType.AE && !Enumerable.Range(090, 098).Contains(threedigitZipCode))
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.R0000022;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }

                            // 111  R0000-024
                            if (usaddress.State == StateType.AP && !Enumerable.Range(962, 966).Contains(threedigitZipCode))
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.R0000024;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }



                            int fourthfifthdigitZipCode = Utilities.GetInt32(usaddress.ZIPCode.Substring(3, 2));


                            // 112  R0000-046
                            var zipcodestrings = new List<string> {Constants.ConstString00800, 
                                    Constants.ConstString20500, 
                                                         Constants.ConstString34000   ,   
                                                         Constants.ConstString00600, Constants.ConstString96100, Constants.ConstString96900 };
                            bool contains = zipcodestrings.Contains(usaddress.ZIPCode, StringComparer.OrdinalIgnoreCase);
                            if (!contains && fourthfifthdigitZipCode == 00)
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.R0000024;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);
                            }

                            //  125  R0000-116-01
                            if ((usaddress.City == "APO" || usaddress.City == "DPO" || usaddress.City == "FPO") &&
                                 (usaddress.State != StateType.AA || usaddress.State != StateType.AE || usaddress.State != StateType.AP))
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.R000011601;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);

                            }


                            //  126  R0000-117
                            if ((usaddress.State == StateType.AA || usaddress.State == StateType.AE || usaddress.State == StateType.AP) &&
                                 (usaddress.City != "APO" || usaddress.City != "DPO" || usaddress.City != "FPO"))
                            {
                                messagesDE = new BusinessMessagesDE();
                                messagesDE.ErrorCode = ErrorCode.R000011601;
                                messagesDE.Action = ErrorType.ApplicationError;
                                listMessagesDE.Add(messagesDE);

                            }

                        }
                    }

                }

            }
        }
        #endregion

        #region Validate Return Version  (BR1.602 Rule Number: R0000-003)
        private void ValidateReturnVersion(string returnVersion)
        {
            if (string.IsNullOrEmpty(returnVersion))
            {
                messagesDE = new BusinessMessagesDE();
                messagesDE.ErrorCode = ErrorCode.IRSAPPCON000030;
                messagesDE.Action = ErrorType.ApplicationError;
                listMessagesDE.Add(messagesDE);
            }
            else if (ConfigurationManager.AppSettings[ConstReturnVersion1040].ToString() != returnVersion)
            {
                messagesDE = new BusinessMessagesDE();
                messagesDE.ErrorCode = ErrorCode.IRSAPPCON000031;
                messagesDE.Action = ErrorType.ApplicationError;
                listMessagesDE.Add(messagesDE);
            }
        }
        #endregion

        #region Validate Return Header
        private void ValidateReturnHeader(Return return1040, bool testMode)
        {
            ValidateReturnType(return1040.ReturnHeader.ReturnTypeCd);
            if (null != return1040.ReturnHeader.OriginatorGrp)
            {
                ValidateSignatureOption(return1040);
            }
        }
        #endregion


        #region Validate Return Type (B

        private void ValidateReturnType(ReturnHeaderTypeReturnTypeCd returnType)
        {
            if (ReturnHeaderTypeReturnTypeCd.Item1040EZ != returnType)
            {
                //messagesDE = new BusinessMessagesDE();
                //messagesDE.ErrorCode = ErrorCode.IRSAPPCON000029;
                //messagesDE.Action = ErrorType.ApplicationError;
                //listMessagesDE.Add(messagesDE);
            }
        }
        #endregion


        #region ValidateSignatureOption
        private void ValidateSignatureOption(Return return1040)
        {
            //if (null != return1040.ReturnHeader..Originator.PractitionerPIN)
            //{
            //    ValidatePractitionerPIN(return1040);
            //}
        }
        #endregion

        #region Validate Practitioner PIN
        private void ValidatePractitionerPIN(Return return4868)
        {
            //if (return4868.ReturnHeader != null && return4868.ReturnHeader.Originator != null && return4868.ReturnHeader.Originator.PractitionerPIN != null)
            //{
            //if (!string.IsNullOrEmpty(return4868.ReturnHeader.Originator.PractitionerPIN.PIN))
            //{
            //    if (return4868.ReturnHeader.Originator.PractitionerPIN.EFIN !=
            //        return4868.ReturnHeader.Originator.EFIN)
            //    {
            //        messagesDE = new BusinessMessagesDE();
            //        messagesDE.ErrorCode = ErrorCode.IRSAPPCON000043;
            //        messagesDE.Action = ErrorType.ApplicationError;
            //        listMessagesDE.Add(messagesDE);
            //    }
            //}
            //   }
        }
        #endregion


        #region ValidateIRSManiFestXml
        private void ValidateIRSManiFestXml(Return return1040, IRSSubmissionManifest iRSSubmissionManifest)
        {
            if (!return1040.ReturnHeader.ReturnTypeCd.ToString().Contains(iRSSubmissionManifest.FederalSubmissionType.ToString()))
            {
                messagesDE = new BusinessMessagesDE();
                messagesDE.ErrorCode = ErrorCode.IRSAPPCON000051;
                messagesDE.Action = ErrorType.ApplicationError;
                listMessagesDE.Add(messagesDE);
            }
        }
        #endregion


        #region Validate Efin
        private void ValidateEfin(string returnHeaderEfin, string manifestEfin)
        {
            if (returnHeaderEfin != manifestEfin)
            {
                messagesDE = new BusinessMessagesDE();
                messagesDE.ErrorCode = ErrorCode.IRSAPPCON000053;
                messagesDE.Action = ErrorType.ApplicationError;
                listMessagesDE.Add(messagesDE);
            }
        }
        #endregion



        #region Validate Return Document Count (BR1.744- Rule Number:R0000-019)
        private void ValidateReturnDocumentCount(ReturnData returnData)
        {
            int count = 0;
            if (null != returnData)
            {
                //if (null != returnData.IRS4868)
                //{
                //    count++;
                //}

                if (null != returnData.IRSPayment)
                {
                    count = count + 1;
                }

                if (null != returnData.IRSESPayment)
                {
                    count = count + returnData.IRSESPayment.Count;
                }

                if (int.Parse(returnData.documentCount) != count)
                {
                    messagesDE = new BusinessMessagesDE();
                    messagesDE.ErrorCode = ErrorCode.IRSAPPCON000036;
                    messagesDE.Action = ErrorType.ApplicationError;
                    listMessagesDE.Add(messagesDE);
                }

            }
        }
        #endregion
    }
}