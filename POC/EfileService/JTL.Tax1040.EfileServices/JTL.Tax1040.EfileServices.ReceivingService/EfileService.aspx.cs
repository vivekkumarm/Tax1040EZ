﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Helpers;
using System.Configuration;


namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public partial class EfileService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string userData = "{\"UserDataId\":2,\"PersonalDetails\":{\"Dependents\":null,\"PrimaryTaxPayer\":{\"Person\":{\"PersonId\":1,\"FirstName\":\"Sathish\",\"MiddleInitial\":\"N\",\"LastName\":\"Natarajan\",\"NickName\":\"Satz\",\"Occupation\":\"IT\",\"DateOfBirth\":\"1991-02-11T00:00:00\",\"SSN\":\"123-45-6896\",\"HasPrimaryFilerEcfContributed\":false,\"HasSpouseEcfContributed\":false,\"IsLegallyBlind\":false,\"IsDisabled\":false,\"HasClaimedAsDependent\":false,\"IsDied\":false,\"DateOfDeath\":null,\"IsStudent\":false,\"IsFullTimeStudent\":false,\"PersonType\":1,\"Address\":{\"AddressId\":1,\"AddressType\":1,\"ResidenceState\":{\"StateId\":1,\"StateCode\":null,\"StateName\":\"Alabama\"},\"HasLivedInMoreThanOneState\":false,\"HasEarnedIncomeFromNonLivedState\":false,\"LivedInAnotherStateId\":0,\"LivedInAnotherStateFrom\":null,\"LivedInAnotherStateTo\":null,\"EarnedIncomeFromNonLivedStateId\":0,\"PersonalAddress\":{\"StreetAddress\":\"Adi sankara street\",\"ApartmentNumber\":\"15\",\"City\":\"Chennai\",\"StateId\":1,\"ZipCode\":\"35000\",\"PhoneNumber\":\"123-456-7899\"},\"ForeignAddress\":null,\"CompanyAddress\":null,\"PayerAddress\":null},\"IsPersonalRepresentative\":null,\"IsBankruptcyDebtor\":null,\"NameControl\":null},\"FilingStatus\":1,\"FilingStatusDescription\":null},\"Spouse\":null},\"Income\":{\"W2Wages\":[{\"EmploymentType\":1,\"W2Id\":1,\"WagesAmount\":14340.0,\"FederalTaxWithholdingAmount\":1000.0,\"SocialSecurityWagesAmount\":100.0,\"SocialSecurityTaxWithholdingAmount\":100.0,\"MedicareWagesAmount\":100.0,\"MedicareTaxWithholdingAmount\":1.0,\"SocialSecurityTipsAmount\":null,\"AllocatedTipsAmount\":null,\"DependentCareBenefitsAmount\":null,\"NonQualifiedPlansAmount\":0.0,\"Employer\":{\"Organization\":{\"Name\":\"JT\",\"Address\":{\"AddressId\":0,\"AddressType\":0,\"ResidenceState\":null,\"HasLivedInMoreThanOneState\":null,\"HasEarnedIncomeFromNonLivedState\":null,\"LivedInAnotherStateId\":0,\"LivedInAnotherStateFrom\":null,\"LivedInAnotherStateTo\":null,\"EarnedIncomeFromNonLivedStateId\":0,\"PersonalAddress\":null,\"ForeignAddress\":null,\"CompanyAddress\":{\"StateId\":1,\"City\":\"Chennai\",\"Zip\":\"35000\",\"CountryId\":0,\"District\":null,\"StreetAddress\":\"Maylapor\"},\"PayerAddress\":null},\"EIN\":\"12-3456789\"},\"HouseholdEmployeeWages\":null,\"TaxableScholarshipAmount\":null},\"IsStatutoryEmployee\":false,\"HasRetirementPlan\":false,\"HasThirdPartySickPay\":false,\"W2StateLocalTaxInfo\":[{\"StateId\":0,\"StateCode\":\"\",\"StateWagesAmount\":null,\"StateTaxWithholdingAmount\":null,\"W2LocalTaxInfo\":[{\"LocalityName\":\"\",\"StateCode\":0,\"LocalWagesAmount\":null,\"LocalTaxWithholdingAmount\":null}]}],\"OtherDeductsBenefits\":[{\"Amount\":null,\"Description\":\"\",\"W2OtherId\":0}],\"W2EmployerCodes\":[{\"EmployerCode\":0,\"Amount\":0.0},{\"EmployerCode\":0,\"Amount\":0.0},{\"EmployerCode\":0,\"Amount\":0.0},{\"EmployerCode\":0,\"Amount\":0.0}],\"EmployeeAddress\":{\"StateId\":1,\"City\":\"Chennai\",\"ZipCode\":\"35000\",\"StreetAddress\":\"Loyds road\"},\"OwnerType\":1,\"HasEmployeeAddress\":true,\"IsCorrectedW2\":false,\"IsNonStandardW2\":false}],\"WithholdingTaxAmount\":null,\"Form1099INT\":[{\"Form1099INTId\":1,\"ForeignTaxPaid\":null,\"EarlyWithdrawalPenalty\":null,\"USBondsTreasury\":null,\"FederalTaxWithHoldingAmount\":1000.0,\"InvestmentExpenses\":null,\"ForeignCountryId\":0,\"TaxExemptInterest\":null,\"TaxExemptAccuredInterest\":null,\"SpecifiedPrivateActivityBond\":null,\"TaxExemptBondCUSIPNumber\":null,\"BothFederalStateExemptInterest\":null,\"IsStateInformationAvailable\":null,\"InterestReceivedAsNominee\":null,\"AccuredInterestInpaymentDates\":\"0001-01-01T00:00:00\",\"AmortizableBondPremium\":null,\"InterestIncome\":1000.0,\"TaxableInterestAmount\":null,\"WithholdingTaxAmount\":null,\"AccountNumber\":\"\",\"Payer\":{\"PayerIdentificationNumber\":\"\",\"PayerName\":\"Sathish\",\"Address\":null},\"Form1099StateInfo\":[{\"StateId\":0,\"StateIdentificationNumber\":\"\",\"StateTaxWithholdingAmount\":null},{\"StateId\":0,\"StateIdentificationNumber\":\"\",\"StateTaxWithholdingAmount\":null}],\"Owner\":1,\"Form\":\"Form1099INT\",\"TaxExemptInterestStateId\":0,\"StateExemptInterest\":null,\"RecipientName\":null}],\"Form1099OID\":[{\"Form1099OIDId\":1,\"Payer\":{\"PayerIdentificationNumber\":\"\",\"PayerName\":\"OID\",\"Address\":null},\"AccountNumber\":\"\",\"OriginalIssueDiscount\":500.0,\"OtherPeriodicInterest\":null,\"EarlyWithdrawalPenalty\":null,\"IncomeMarketDiscount\":null,\"ForeignTaxPaid\":null,\"ForeignCountryId\":0,\"IsMutualFundRegulatedInvestment\":null,\"USTreasuryObligations\":null,\"InvestmentExpenses\":null,\"IsStateInformationAvailable\":null,\"InterestReceivedAsNominee\":null,\"AdjustmentAmount\":null,\"TaxableInterestAmount\":null,\"FederalTaxWithHoldingAmount\":100.0,\"Description\":\"\",\"Form1099StateInfo\":[{\"StateId\":0,\"StateIdentificationNumber\":\"\",\"StateTaxWithholdingAmount\":null},{\"StateId\":0,\"StateIdentificationNumber\":\"\",\"StateTaxWithholdingAmount\":null}],\"AcquisitionPremium\":null,\"HasToReportTaxExempt\":false,\"HasToReportAdjustment\":false,\"TaxExemptInterestStateId\":0,\"StateExemptInterest\":null,\"Owner\":1,\"TaxExemptInterest\":null,\"RecipientName\":null,\"Form\":\"Form1099OID\"}],\"Form1099G\":[{\"Form1099GId\":1,\"OwnerType\":1,\"Payer\":{\"PayerIdentificationNumber\":\"12-3456789\",\"PayerName\":\"Sathish\",\"Address\":{\"AddressId\":0,\"AddressType\":0,\"ResidenceState\":null,\"HasLivedInMoreThanOneState\":null,\"HasEarnedIncomeFromNonLivedState\":null,\"LivedInAnotherStateId\":0,\"LivedInAnotherStateFrom\":null,\"LivedInAnotherStateTo\":null,\"EarnedIncomeFromNonLivedStateId\":0,\"PersonalAddress\":null,\"ForeignAddress\":null,\"CompanyAddress\":null,\"PayerAddress\":{\"StreetAddress\":\"Loyds road\",\"City\":\"Chennai\",\"StateId\":1,\"ZipCode\":\"35000\"}}},\"UnEmploymentCompensation\":1000.0,\"FederalTaxWithHoldingAmount\":1000.0,\"IsCurrentYearUnemploymentRepaid\":false,\"CurrentYearUnemploymentRepaid\":null,\"IsPriorYearUnEmploymentRepaid\":false,\"PriorYearUnEmploymentRepaid\":null,\"Form1099StateInfo\":[{\"StateId\":0,\"StateIdentificationNumber\":\"\",\"StateTaxWithholdingAmount\":null}],\"TaxPayerName\":null}],\"OtherIncome\":{\"HasSsbAndRrb\":true,\"HasAlaskaPermanantFund\":true,\"HasStateTaxRefund\":true,\"HasClaimedItemizedDeductionPriorYear\":false,\"HasStateAndLocalTaxDeductionPriorYear\":false,\"AlaskaPermanentFundDividend\":{\"PrimaryTaxpayerAlaskaFundDividend\":1000.0,\"SpouseAlaskaFundDividend\":null},\"StateOrLocalIncomeTaxRefunds\":{\"HasClaimedItemizedDeductionPriorYear\":false,\"HasStateAndLocalTaxDeductionPriorYear\":null},\"SSB\":{\"HasTaxableSocialSecurityBenefits\":null,\"TaxpayerNetBenefits\":1000.0,\"TaxPayerFederalTaxWithheld\":1000.0,\"SpouseNetBenefits\":0.0,\"SpouseFederalTaxWithheld\":0.0},\"RRB\":{\"NetBenefits\":0.0,\"FederalTaxWithholdingAmount\":0.0,\"TaxpayerNetBenefits\":1000.0,\"TaxPayerFederalTaxWithheld\":100.0,\"SpouseNetBenefits\":0.0,\"SpouseFederalTaxWithheld\":0.0}},\"HasIncomeFromOtherSources\":null,\"Form8862\":null,\"HasW2Wages\":true,\"HasInterestIncome\":true,\"HasUnemploymentCompensation\":true,\"HasOtherIncome\":true},\"State\":null,\"StateBO\":null,\"Deductions\":null,\"Credits\":{\"EIC\":{\"HasValidSSN\":false,\"IsInUSMorethanHalfYear\":false,\"HasClaimedAsQualifyingChild\":false,\"IsProhibitedFromClaimingEIC\":null,\"HasReceivedIRSNoticeOnFiling8862\":false,\"HasEICForPriorYearDisallowance\":null,\"HasIncorrectlyReportedEarnedIncome\":null,\"NumberOfDaysTaxPayerLivedInUS\":0,\"NumberOfDaysSpouseLivedInUS\":0,\"HasTaxableScholarshipCredits\":false,\"TaxableScholarshipCredit\":0.0,\"HasPensionAnnuity\":false,\"PensionAnnuity\":0.0,\"HasPenalInstitutionInmateWages\":false,\"PenalInstitutionInmateWages\":0.0,\"IsNonResidentAlien\":null,\"HasReceivedIRSNoticeOnEICNotEligible\":false},\"HasCreditsToClaim\":null,\"HasEarnedIncomeCredits\":null,\"HasEstimatedTaxPayments\":null},\"TaxesAndPenalties\":{\"HasOwedHouseholdEmploymentTax\":false,\"HasAlternativeMinimumTax\":false,\"HasAdditionalSocialSecurityOrMedicareTax\":false,\"HasFederalQuarterlyEstimatesPaid\":false,\"HasFiledForm4868\":false,\"HasPaidFederalExtensionWithForm4868\":false,\"FederalExtensionFiledDate\":null,\"IsFilingReturnAfterDueDate\":false,\"FederalExtensionAmount\":null,\"FederalExtensionAmountPaidDate\":null,\"FilingDate\":null,\"HasToDepositTaxRefundsToBankAccount\":false,\"BankDetails\":null,\"InCareOf\":\"\",\"InCareOfPhoneNumber\":\"\",\"HasThirdPartyDesignee\":false,\"ThirdPartyDesignee\":null,\"PenaltiesAndInterest\":null,\"InterestOnUnpaidDue\":null},\"WrapUp\":null,\"PaidTaxReturnPreparers\":null,\"Settlement\":null,\"ThirdPartyDesignee\":null,\"OutputForms\":{\"Tax1040EZPage1\":{\"TotalWages\":14340.0,\"TaxableInterest\":1500.0,\"UnemploymentCompensation\":2000.0,\"AdjustedGrossIncome\":17840.0,\"TaxableIncome\":7840.0,\"FederalTaxWithholdingAmount\":4200.0,\"EarnedIncomeCredit\":0.0,\"NonTaxableCombatPayElection\":0.0,\"FederalExtensionAmount\":0.0,\"TotalPaymentsAndCredits\":4200.0,\"TaxAmount\":784.0,\"RefundAmount\":3416.0,\"TaxOweAmount\":0.0,\"PenaltiesAndInterest\":0.0,\"StandardDeduction\":10000.0,\"PersonalDeduction\":0.0,\"TEI\":0.0,\"WagesPrefix\":null},\"Tax8879Page1\":null,\"Tax8862Page1\":null,\"Tax8879\":null},\"ErrorMessages\":[{\"ErrorCode\":\"EarnedIncomeCredit_BR1\",\"FieldName\":\"EIC  - AGI exceed $14,340 Single\",\"FieldDescription\":\"AGI exceeds - $14,340 Single \",\"Tab\":\"Credit\",\"Topic\":\"Earned Income Credit\",\"ErrorType\":\"Information\",\"MessageType\":\"BR\",\"ErrorText\":\"Your Earned Income (------) and Adjusted Gross Income {0} exceeds the maximum allowed amount of $14,340 with no qualifying children.\",\"LongErrorText\":\"Your Earned Income (------) and Adjusted Gross Income (----) exceeds the maximum allowed amount of $14,340 with no qualifying children.\",\"MessageTarget\":\"\",\"ErrorTitle\":\"\",\"FormId\":0},{\"ErrorCode\":\"EarnedIncomeCredit_BR5\",\"FieldName\":\"EIC - Lived in United States more than half of the year\",\"FieldDescription\":\"Lived in United States more than half of the year\",\"Tab\":\"Credit\",\"Topic\":\"Earned Income Credit\",\"ErrorType\":\"Information\",\"MessageType\":\"BR\",\"ErrorText\":\"You did not stayed in united States for more than half of the year.\",\"LongErrorText\":\"You did not stayed in united States for more than half of the year.\",\"MessageTarget\":\"\",\"ErrorTitle\":\"\",\"FormId\":0},{\"ErrorCode\":\"EarnedIncomeCredit_BR3\",\"FieldName\":\"EIC -  Invalid SSN\",\"FieldDescription\":\"EIC -  Invalid SSN\",\"Tab\":\"Credit\",\"Topic\":\"Earned Income Credit\",\"ErrorType\":\"Information\",\"MessageType\":\"BR\",\"ErrorText\":\"You & Your Spouse should not have a Valid Social security Number.\",\"LongErrorText\":\"You & Your Spouse (if MFJ) should not have a Valid Social security Number\",\"MessageTarget\":\"\",\"ErrorTitle\":\"\",\"FormId\":0},{\"ErrorCode\":\"EarnedIncomeCredit_BR4\",\"FieldName\":\"EIC - Age of the Taxpayer & Spouse not less than 25 or more than 65\",\"FieldDescription\":\" Age of the Taxpayer & Spouse not less than 25 or more than 65\",\"Tab\":\"Credit\",\"Topic\":\"Earned Income Credit\",\"ErrorType\":\"Information\",\"MessageType\":\"BR\",\"ErrorText\":\"You or Your Spouse Age must be more than 25 and less than 65 years in 2014. \",\"LongErrorText\":\"You or Your Spouse (if MFJ) Age must be more than 25 and less than 65 years in 2014. \",\"MessageTarget\":\"\",\"ErrorTitle\":\"\",\"FormId\":0}],\"F1040EZEligibility\":{\"InterestIncomeEligibility\":{\"HasInterestReceivedAsNominee\":false,\"HasPreviousYearsUSBondsInterest\":false,\"HasOwnedForeignFinancialAccounts\":false,\"HasSellerFinancedMortageInterest\":false,\"IsReportingLesserOID\":false,\"IsExemptByAmortizableBond\":false,\"IsClaimingEEOrIUSBondsInterestAfter1989\":false,\"HasNoneOfOptions\":true,\"HasEarlyWithdrawalPenalty\":false,\"HasForeignTaxCredit\":false},\"CommonEligibility\":null},\"IRSTransmission\":null,\"F1040EZ\":{\"F1040EZWorkSheets\":{\"DeductionsWorkSheet\":{\"LineAAmount\":0.0,\"LineBAmount\":0.0,\"LineCAmount\":0.0,\"LineDAmount\":0.0,\"LineEAmount\":0.0,\"LineFAmount\":0.0,\"LineGAmount\":0.0},\"SSBWorkSheet\":{\"Line1Amount\":2000.0,\"Line2Amount\":1000.0,\"IsLine2SSBTaxable\":true,\"Line3Amount\":15340.0,\"Line4Amount\":1500.0,\"Line5Amount\":17840.0,\"Line6Amount\":25000.0,\"IsLine7SSBTaxable\":false},\"EICWorkSheet\":{\"Line1Amount\":14340.0,\"Line2Amount\":0.0,\"Line3Amount\":0.0,\"IsLine4AmountsSame\":false,\"Line5Amount\":0.0,\"IsLine5Blank\":false,\"Line6Amount\":0.0}},\"F1040EZEligibility\":null}}";

            ////  Encrypt(userData, "swapnesh");

            //userData = Json.Decode(Security.Encrypt(userData, "swapnesh"));



            ReceivingService receivingService = new ReceivingService();
            receivingService.ReceiveService(Security.Encrypt(userData, ConfigurationManager.AppSettings[Constants.EncryptionKey]));

        }
    }
}