/*
Copyright   : Copyright Jeevan Technologies
File Name   : FilingStatus.cs 
Description : Business Logic for user. 

 * Modification History:
 *  31Mar2014 Sathis changed Enum name from SendPassworResetLink to SendUserNameAndPasswordReset
 *  08Apr2014 Sathish Added Enum description for Filling Status
 *  8thApr2014 Ashok Kumar Used JsonConvertor for ENUM
 *  9th April, 2014 - Saravanan N - FilingStatus.None added.
 *  9th April, 2014 - Bala - EmploymentType enum added.
 *  9th April, 2014 - Bala - W2OtherCode enum added.
 *  16  April, 2014 - Sathish - Changed enum name for email template 
 *  21  April, 2014 - Vincent- Change enum description for Employer code.
 *  28  April, 2014 - Ashok Kumar- Added new enum for Account Type.
 *  7  May, 2014 - Ashok Kumar- Added new enums for IRS PaymentType FilingType and Product Type
 *  22 MAY 2014 Enum or state and Resident type
 */

using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace JTL.Tax1040.Core.Object
{
    /// <summary>
    /// Denotes the Filing Status of the TaxPayer
    /// Vivek - 17 Mar, 2014 - As per Spec. 6 and 7 items added.
    /// </summary>
    public enum FilingStatus
    {
        [Description("None")]
        None = 0,
        [Description("Single")]
        Single = 1,
        [Description("Married Filing jointly")]
        MarriedFilingJointly = 2,
        [Description("Married Filing Separately(Divorced or legally separated)")]
        MarriedFilingSeperately = 3,
        [Description("Registered domestic partnership or Civil Union")]
        CivilUnion = 4,
        [Description("Same sex Marriage")]
        SameSexMarriage = 5,
        [Description("Widower")]
        Widower = 6,
        [Description("Head of Household")]
        HeadofHousehold = 7,
    }
        
    /// <summary>
    /// Enum for the service in military 
    /// </summary>
    /// 4-july-14 vivek - As per the latest spec 2.4
    public enum  ServedInMilitary
    {
        [Description("None")]
        None = 0,
        [Description("Not Applicable")]
        NotApplicable=1,
        [Description("Operation Iraqi Freedom")]
        OperationIraqiFreedom=2,
		[Description("Kosovo Operation")]
        KosovoOperation=3,		
        [Description("Afghanistan/Enduring Freedom")]
        AfghanistanEnduringFreedom=4,
        [Description("DesertStorm")]
        DesertStorm=5,		
        [Description("Haiti")]
        Haiti=6,		
        [Description("Farmer Yugoslavia")]
        FarmerYugoslavia=7,		
        [Description("UN Operation")]
        UNOperation=8,		
        [Description("Operation Joint Forge")]
        OperationJointForge=9,
        [Description("Northern Watch")]
        NorthernWatch=10,		
        [Description("Operation Allied Force")]
        OperationAlliedForce=11,		
        [Description("Northern Forge")]
        NorthernForge=12,
	    [Description("Other Combat Zone")]
	    OtherCombatZone=13,	
        [Description("Joint Guard")]
        JointGuard=14		
    }

    /// <summary>
    /// Denotes the EmployerCode of the TaxPayer
    /// </summary>
    public enum EmployerCode
    {
        //Vincent-31th Mar-Added the Description method EmployerCode Enum and Added addition Employer code.
        [Description("None Selected")]
        NoneSelected = 0,
        [Description("A–Uncollected Soc. Sec. or RRTA tax on tips.")]
        AUncollectedSocSecOrRRTATaxOnTips = 1,
        [Description("B–Uncollected Medicare tax on tips.")]
        BUncollectedMedicareTaxOnTips = 2,
        [Description("C–Taxable benefit of group term-life insurance.")]
        CTaxableCostofgroupTermLifeInsurance = 3,
        [Description("D–Non-taxable elective salary deferrals under Section 401K.")]
        DElectiveDeferralsToSection401k = 4,
        [Description("E–Non-taxable elective salary deferrals under Section 403B.")]
        EElectiveDeferralsToSection403b = 5,
        [Description("F–Non-taxable elective salary deferrals under Section 408(k)(6).")]
        FElectiveDeferralsToSection408k6 = 6,
        [Description("G–Non-taxable elective salary deferrals under Section 457(b) plan.")]
        GElectiveDeferralsToSection457bPlan = 7,
        [Description("H–Non-taxable elective salary deferrals under Section 501(c)(18)(D) plan.")]
        HElectiveDeferralsToSection501c18DPlan = 8,
        [Description("J–Non-taxable sick pay.")]
        JNonTaxableSickPay = 9,
        [Description("K–Excise tax (equal to 20%) on excess golden parachute payments.")]
        KExciseTaxOnExcessGoldenParachutePayments = 10,
        [Description("L–Non-taxable reimbursements for Employee business expenses.")]
        LSubstantiatedEmployeeBusinessReimbursement = 11,
        [Description("M–Uncollected Social Security or RRTA tax on group term life insurance.")]
        MUncollectedSocSecOrRRTATaxOnGrpTermsLifeIns = 12,
        [Description("N–Uncollected Medicare tax on  group term life insurance.")]
        NUncollectedMedicareTaxOnGroupTermLifeInsurance = 13,
        [Description("P–Non-taxable reimbursements for Employee moving expenses.")]
        PExcludableMovingExpenseReimbursements = 14,
        [Description("Q–Non-taxable combat pay.")]
        QNonTaxableCombatPay = 15,
        [Description("R–Employer contributions to an Archer MSA.")]
        REmployeeContributionsToAnArcherMSA = 16,
        [Description("S–Non-taxable salary deferral to a 408(p) SIMPLE plan.")]
        SEmployeeSalaryReductionUnderSection408pSIMPLE = 17,
        [Description("T–Employer paid adoption benefits.")]
        TAdoptionBenefits = 18,
        [Description("V–Income from exercise of non-statutory stock options.")]
        VIncomeFromExerciseOfNonstatutoryStockOptions = 19,
        [Description("W–Employer and Employee contributions to HSA.")]
        WEmployerAndEmployeeContributionsToAHealthSavingsAccount = 20,
        [Description("Y–Salary deferrals under  Section 409A plan")]
        YNonQualifiedDefferredCompensationPlan = 21,
        [Description("Z–Income received under Section 409A  plan. ")]
        ZIncomeReceivedUnder409ANonQualifiedDeferredCompensationPlan = 22,
        [Description("AA–Designated Roth contribution under Section 401(K) plan.")]
        AATaxContributionToRoth401RetirementPlan = 23,
        [Description("BB–Designated Roth contribution under Section 403(b) plan.")]
        BBTaxContributionToRoth402RetirementPlan = 24,
        [Description("DD–Cost of Employer sponsored health coverage")]
        DDReportCostOfNonTaxableHealthInsurance = 25,
        [Description("EE–Designated Roth contribution under section 457(b) plan.")]
        EETaxContributionToRoth457RetirementPlanByGovernment = 26
    }

    // Newly added by Vincent on 04th March, 2014 - New Enum property for Person type 4/3/14 
    public enum PersonType
    {
        PrimaryTaxPayer = 1,
        Spouse = 2,
        Dependent = 3
    }

    /// <summary>
    /// Added by Saravanan N. on 11th March, 2014. It Denotes state of the object.
    /// </summary>
    public enum ObjectState
    {
        Current = 0,
        New = 1,
        Deleted = 2,
        Modified = 4
    }
    
    /// <summary>
    ///  Email ID associated to the template
    /// </summary>
    public enum EmailTemplate
    {
        SendUserRegistrationInfo = 1,
        SendPasswordResetCode = 2,
        SendPasswordResetInfo = 3,
        SendUserNameAndPasswordReset = 4,
        SendUserName = 5,
        SendUpdateEmail = 6,
        PaymentEmail = 7,
        TransmitFederalReturn=8,
        FederalReturnReject=12,
        FederalReturnAccepted=13
    }

    //Added on 1st April 2014. It denotes owner of a Particular Form (Say W2, 1099INT, 1099OID and So on)
    public enum OwnerType
    {
        None = 0,
        PrimaryTaxPayer = 1,
        Spouse = 2,
        Joint = 3
    }

    //Saravanan N - 1st April, 2014 - New enum added for FormType usage TaxReturnRepository persist.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FormType
    {
        W2 = 1,
        Form1099G = 2,
        Form1099INT = 3,
        Form1099OID = 4
    }

    public enum AddressType
    {
        PersonalAddress = 1,
        ForeignAddress = 2,
        CompanyAddress = 3,
        TaxPayerAddress = 4

    }

    //public enum ReturnStatus
    //{
    //    None = 0,
    //    Transmitted = 1,
    //    Rejected = 2,
    //    NotStarted = 3,
    //    InProgress = 4,
    //    Accepted = 5

    //}


    public enum EmploymentType
    {
        RegularW2Wages = 1,
        ActiveDutyMilitaryWages = 2,
        SocialSecurityAndMedicareWerenotWithHeld = 3,
        MedicareQualifiedGovernmentWages = 4,
        ChurchEmployeeWages = 5,
        HouseholdEmployeeWages = 6,
        TaxableScholarshipIncome = 7,
        //Yogalakshmi - 20th June 2014 - Added a new enum for foreign employment as per the SPEC.
        ForeignEmployment = 8
    }

    /// <summary>
    /// Denotes the W2 OtherCode of the TaxPayer
    /// </summary>
    public enum W2OtherCode
    {
        [Description("None Selected")]
        NoneSelected = 0,
        [Description("Union dues")]
        UnionDues = 1,
        [Description("Health insurance premiums deducted (not pre-tax) (reported on Schedule A, Line 1)")]
        HealthInsurancePremiumsDeducted = 2,
        [Description("Unreimbursed Employee expenses (reported on Schedule A, Line 21)")]
        UnreimbursedEmployeeExpenses = 3,
        [Description("Voluntary after-tax contributions (reported on Schedule A, Line 16)")]
        VoluntaryAfterTaxContributions = 4,
        [Description("State disability contributions (SDI or CASDI)")]
        StateDisabilityContributions = 5,
        [Description("Section 125 flexible spending account contributions")]
        Section125FlexibleSpendingAccountContributions = 6,
        [Description("Section 414(h) contributions")]
        Section414Contributions = 7,
        [Description("Tier I or Tier II railroad retirement contributions")]
        RailroadRetirementContributions = 8,
        [Description("Educational assistance payments")]
        EducationalAssistancePayments = 9,
        [Description("Other Information")]
        OtherInformation = 10
    }
    // vivek - 11-4-14 
    //Added StateTaxRefund by prasana on 15.07.2014 after Income spec update 2.3 
    /// <summary>
    /// Other Income Type enum
    /// </summary>
    public enum OtherIncomeType : int
    {
        SocialSecurityAndRailRoadBenefits = 1,
        AlaskaDividendIncome = 2,
        StateTaxRefund = 3
    }

    //Ashok kumar Added New Enum type for Account Type in Taxes and Penalties
    /// <summary>
    /// Denoes the Type of Account
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountType
    {
        Checking = 1,
        Saving = 2,
        None = 0
    }

    /// <summary>
    /// Ashok kumar Added for IRS Payment Option - dated 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    //25Jul2014 Sathish changed IRSPayment option to Paymentoption since it is common for state and federal
    public enum PaymentOption
    {
        DirectDebit = 1,
        EFTPS = 2,
        CheckByMail = 3,
        PayByCheck = 4,
        None = 0
    }

    /// <summary>
    /// Ashok kumar Added for Filing Type
    /// </summary>
    public enum FilingType
    {
        PaperFile = 1,
        EFile = 2,
        None = 0
    }

    /// <summary>
    /// Ashok kumar Added for Product Type 
    /// </summary>
    public enum ProductType
    {
        Form1040EZ = 1,
        Form1040 = 2,
        Form1040A = 3,
        None = 0
    }

    public enum ReportingType
    {
        Federal = 1,
        State = 2,
        None = 0
    }

    public enum CardType
    {
        None = 0,
        Visa = 1,
        MasterCard = 2,
        AmericanExpress = 3,
        Discover = 4
    }

    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum StateList
    {
        [Description("New York")]
        NewYork,
        Missouri,
        Illinois,
        California,
        [Description("New Jersey")]
        NewJersey,
        Alaska,
        Florida,
        Texas,
        [Description("South Dakota")]
        SouthDakota,
        Wyoming,
        Washington,
        Nevada
    }



    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum ResidentType
    {
        Resident,
        [Description("Non Resident")]
        NonResident
    }

    //vincent-4 July 2014- Added a Description for return status enum\
    //25Jul2014 Sathish added enum printpapercopy as discussed with qa
    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum ReturnStatus
    {
        [Description("None")]
        None = 0,
        [Description("Transmitted")]
        Transmitted = 1,
        [Description("Rejected")]
        Rejected = 2,
        [Description("NotStarted")]
        NotStarted = 3,
        [Description("In Progress")]
        InProgress = 4,
        [Description("Accepted")]
        Accepted = 5,
        [Description("Print Paper Copy")]
        PrintPaperCopy = 6

    }

    //07Aug2014 Sathish Personal section 
    public enum PersonalSection
    {
        None = 0,
        FilingStatus = 1,
        PrimaryFiler=2,
        Spouse=3,
        Address=4,
        PersonalSummary=5
    }

    //Praveen T 11 Aug 2014 Added for Payment Section
    public enum StatusType
    {
        Success,
        Failure
    }

    public class EnumToStringUsingDescription : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType.Equals(typeof(Enum)));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType.Equals(typeof(String)));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!destinationType.Equals(typeof(String)))
            {
                throw new ArgumentException("Can only convert to string.", "destinationType");
            }

            if (!value.GetType().BaseType.Equals(typeof(Enum)))
            {
                throw new ArgumentException("Can only convert an instance of enum.", "value");
            }

            string name = value.ToString();
            object[] attrs =
                value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attrs.Length > 0) ? ((DescriptionAttribute)attrs[0]).Description : name;
        }
    }
}
