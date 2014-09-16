﻿/*
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
 */

using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        SendPasswordResetInfo =3,
        SendUserNameAndPasswordReset = 4,
        SendUserName=5,
        SendUpdateEmail =6
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

    public enum EmploymentType
    {
        RegularW2Wages = 1,
        ActiveDutyMilitaryWages = 2,
        SocialSecurityAndMedicareWerenotWithHeld = 3,
        MedicareQualifiedGovernmentWages = 4,
        ChurchEmployeeWages = 5,
        HouseholdEmployeeWages = 6,
        TaxableScholarshipIncome = 7
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
    /// <summary>
    /// Other Income Type enum
    /// </summary>
    public enum OtherIncomeType : int
    {
        SocialSecurityAndRailRoadBenefits=1,
        AlaskaDividendIncome=2
    }

    //Ashok kumar Added New Enum type for Account Type in Taxes and Penalties
    /// <summary>
    /// Denoes the Type of Account
    /// </summary>
    public enum AccountType
    {
        Checking = 1,
        Savings = 2
    }
}
