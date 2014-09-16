/*
Copyright   : Copyright Jeevan Technologies
File Name   : UserRepository.cs 
Description : Business Logic for user. 
 * 
 * Modification History:
 *  27Mar2014 Sathish Added  EMAIL_LOGIN_LINK,EMAIL_PASSWORD_RESET_LINK and EMAIL_EMAIL_ID constant 
 *  1 APR2014 Vincent Added a additional interest income constants code.
 *  2 APR2014 Ashok Kumar Added a additional interest income Check List constants.
 *  31Mar2014 Sathish Added APP_SETTING_LOGIN_LINK constant
 *  08Apr2014 Sathish Added constant for spouse business validation
 *  09Apr2014 Saravanan N Added constants for Unemployment and OtherIncome sections.
 *  9 Apr2014 Vincent Made the changes in Interest income and OID section.
 *  17 Apr14 Vincent Added a New Constant files.
 *  22Apr2014 Sathish Added EIC Constant,Deduction year and PrimaryTaxPayerName
 *  23 Apr14 Vincent Remove the state local tax const for Unemployment Compensation and change error code for Federal & State Tax withholding.
 *  29 Apr 14 vivek Added new constant for tax and wrap up
 *  30 Apr 14 Sathish Changed constant name for Tax and wrap up
 *  02May14 Bala Topics added for filtering error messages.
 *  05May2014 Sathish added constant for Tax and wrap up error message topic
 *  08May2014 Sathish added constant Tax_Year for date of birth validation
 *  09May2014 Thileepkumar added constants for email template 
 *  13May2014 Sathish Default Tax payer Name if first name or nick name not available.
 *  27May2014 Sathish added error message for extenstion date dand filling date for spec Tax1040EZ-06_Taxes and Wrap Up _TY2014_V1 1
 *  28May2014 Sathish added TAXABLE_INCOME constant to check tax able income eligibility
 *  28May2014-Vincent- Added a Some of Constants for Interest income.
 *  02Jun2014 Sathish Added constant for wages required and validation field
 *            Sathish added constant for zip code lenght
 *  2Jun2014-Vincent-Added Const files for other income.
     04.06.2014 Thileep Added Social Security Wages Constant   
 * 16.06.2014 Thileep Added PasswordResetUrl Constant App setting.
 */

using System;
namespace JTL.Tax1040.Core.Object
{
    public sealed class Constants
    {
        public const int TAX_YEAR = 2014;

        // 28May2014 Sathish added TAXABLE_INCOME constant to check tax able income eligibility
        public const double TAXABLE_INCOME_ELIGIBILITY_AMOUNT = 100000;

        //13May2014 Sathish Default Tax payer Name if first name or nick name not available.
        public const string DEFAULT_TAX_PAYER_NAME = "TaxPayer";

        //02Jun2014 Sathish added constant for zip code lenght
        public const int ZIP_CODE_MIN_LENGTH = 5;
        public const int ZIP_CODE_MAX_LENGTH = 9;

        //20Jun2014 Sathish added constant for error type
        public const string MESSAGE_TYPE_BR = "BR";
        public const string MESSAGE_TYPE_ER = "ER";
        public const string MESSAGE_TYPE_RF = "RF";
        public const string MESSAGE_TYPE_V = "V";



        //EZ Eligibility 
        public const string TAXPAYER_FILING_STATUS = "FilingStatus_ER1";
        public const string TAXPAYER_OR_SPOUSE_DOB = "PrimaryFiler_ER1";
        public const string TAXPAYER_IS_BLIND = "PrimaryFiler_ER2";
        public const string TAXPAYER_DATEOFDEATH = "PrimaryFiler_ER3";

        // Primay Tax Payer
        public const string TAXPAYER_DEFAULT_DISPAY_NAME = "Taxpayer";
        public const string TAXPAYER_MISSING_FILING_STATUS = "FilingStatus_RF1";
        public const string TAXPAYER_MISSING_FIRST_NAME = "PrimaryFiler_RF1";
        public const string TAXPAYER_FIRST_NAME_ALPHABET = "PrimaryFiler_V1";
        public const string TAXPAYER_MISSING_LAST_NAME = "PrimaryFiler_RF2";
        public const string TAXPAYER_LAST_NAME_ALPHABET = "PrimaryFiler_V2";
        public const string TAXPAYER_MIDDLE_NAME_ALPHABET = "PrimaryFiler_V3";
        public const string TAXPAYER_NICK_NAME_ALPHABET = "PrimaryFiler_V4";
        public const string TAXPAYER_OCCUPATION_NAME_ALPHABET = "PrimaryFiler_V5";
        public const string TAXPAYER_MISSING_OCCUPATION_NAME = "PrimaryFiler_V6";
        public const string TAXPAYER_MISSING_DATE_OF_BIRTH = "PrimaryFiler_RF3";
        public const string TAXPAYER_MISSING_SSN = "PrimaryFiler_RF4";
        public const string TAXPAYER_INVALID_SSN = "PrimaryFiler_V7";
        public const string TAXPAYER_MISSING_DATE_OF_DEATH = "PrimaryFiler_RF5";
        public const string TAXPAYER_DATE_OF_DEATH_MUST_CURRENT_YEAR = "PrimaryFiler_V8";
        public const string TAXPAYER_DATE_OF_BIRTH_GREATER_THAT_TAX_YEAR = "PrimaryFiler_V9";
        //Vincent - 8/7/14- Added a new constant for served in military for Taxpayer
        public const string TAXPAYER_HAS_SERVED_IN_MILITARY = "PrimaryFiler_RF6";
        public const string TAXPAYER_HAS_OTHER_COMBAT_ZONE = "PrimaryFiler_RF7";

        public const string RECEIVED_INCOME_APART_FROM_WAGES_UNEMPLOYMENT_INTEREST_INCOME = "EZEligibility_ER1";
        public const string NO_AGI_DEDUCTIONS = "EZEligibility_ER2";
        public const string NO_ITEMIZED_DEDUCTION = "EZEligibility_ER3";
        public const string NO_CREDITS = "EZEligibility_ER4";
        public const string NO_HOUSEHOLD_EMPLOYMENT_TAXES = "EZEligibility_ER5";
        public const string NO_AMT_TAXES = "EZEligibility_ER6";
        public const string NO_ESTIMATE_PAYMENTS = "EZEligibility_ER7";
        public const string TAXPAYER_SHOULD_NOT_BE_UNDER_ANY_BANKRUPTCY_CASE = "EZEligibility_ER8";
        public const string CLAIM_EXEMPTION_FOR_DEPENDENT = "EZEligibility_ER9";
        public const string SOCIAL_SECURITY_AND_RAILROAD_BENEFITS = "OtherIncome_ER1";
        public const string TAXABLE_INCOME = "EZEligibilityER10";
        public const string INTEREST_INCOME = "InterestIncome_ER1";

        public const string SPOUSE_DOB = "Spouse_ER1";
        public const string SPOUSE_IS_BLIND = "Spouse_ER2";
        public const string SPOUSE_DATEOFDEATH = "Spouse_ER3";

        public const string SPOUSE_MISSING_FIRST_NAME = "Spouse_RF1";
        public const string SPOUSE_MISSING_LAST_NAME = "Spouse_RF2";
        public const string SPOUSE_MISSING_SSN = "Spouse_RF3";
        public const string SPOUSE_MISSING_DATE_OF_BIRTH = "Spouse_RF4";
        public const string SPOUSE_STATE_OF_RESIDENCE = "Spouse_RF5";
        public const string SPOUSE_MISSING_DATE_OF_DEATH = "Spouse_RF6";//added by vivek during testing 14-May-14
        public const string SPOUSE_FIRST_NAME_ALPHABET = "Spouse_V1";
        public const string SPOUSE_LAST_NAME_ALPHABET = "Spouse_V2";
        public const string SPOUSE_MIDDLE_NAME_ALPHABET = "Spouse_V3";
        public const string SPOUSE_INVALID_SSN = "Spouse_V4";
        public const string SPOUSE_OCCUPATION_NAME_ALPHABET = "Spouse_V5";
        public const string SPOUSE_MISSING_OCCUPATION_NAME = "Spouse_V6";
        public const string SPOUSE_DATE_OF_BIRTH_GREATER_THAT_TAX_YEAR = "Spouse_V8";
       //Vincent - 8/7/14- Added a new constant for served in military for Spouse
        public const string SPOUSE_HAS_SERVED_IN_MILITARY = "Spouse_RF7";
        public const string SPOUSE_HAS_OTHER_COMBAT_ZONE = "Spouse_RF8";


        public const string TAXPAYER_PERSONAL_ADDRESS_MISSING_STREET = "Address_RF1";
        public const string TAXPAYER_PERSONAL_ADDRESS_MISSING_CITY = "Address_RF2";
        public const string TAXPAYER_PERSONAL_ADDRESS_MISSING_STATE = "Address_RF3";
        public const string TAXPAYER_PERSONAL_ADDRESS_MISSING_ZIP_CODE = "Address_RF4";

        public const string TAXPAYER_FOREIGN_ADDRESS_MISSING_STREET = "Address_RF5";
        public const string TAXPAYER_FOREIGN_ADDRESS_MISSING_CITY = "Address_RF6";
        public const string TAXPAYER_FOREIGN_ADDRESS_MISSING_STATE = "Address_RF7";
        public const string TAXPAYER_FOREIGN_ADDRESS_MISSING_POSTAL_CODE = "Address_RF8";
        public const string TAXPAYER_FOREIGN_ADDRESS_MISSING_COUNTRY = "Address_RF9";
        public const string TAXPAYER_FOREIGN_ADDRESS_MISSING_RESIDENT_STATE = "Address_RF10";
        public const string TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE = "Address_RF11";
        public const string TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE_FROM = "Address_RF12";
        public const string TAXPAYER_ADDRESS_MISSING_LIVED_IN_ANOTHER_STATE_TO = "Address_RF13";
        public const string TAXPAYER_ADDRESS_MISSING_EARNED_INCOME_STATE = "Address_RF14";
        public const string TAXPAYER_ADDRESS_MISSING_PHONE_NUMBER = "Address_RF15";
        public const string TAXPAYER_ADDRESS_MISSING_FOREIGN_PHONE_NUMBER = "Address_RF16";
        public const string TAXPAYER_PERSONAL_ADDRESS_STREET_ALPHABET = "Address_V1";
        public const string TAXPAYER_PERSONAL_ADDRESS_CITY_ALPHABET = "Address_V2";
        public const string TAXPAYER_PERSONAL_ADDRESS_VALID_ZIP_CODE = "Address_V3";
        public const string TAXPAYER_PERSONAL_ADDRESS_VALID_PHONE_NUMBER = "Address_V4";
        public const string TAXPAYER_PERSONAL_ADDRESS_VALID_FOREIGN_PHONE_NUMBER = "Address_V10";
        public const string TAXPAYER_FOREIGN_ADDRESS_STREET_ALPHABET = "Address_V5";
        public const string TAXPAYER_FOREIGN_ADDRESS_CITY_ALPHABET = "Address_V6";
        public const string TAXPAYER_FOREIGN_ADDRESS_STATE_OR_PROVINCE = "Address_V7";

        //Added by swapnesh on 28 May 2014
        public const string TAXPAYER_ADDRESS_SAMERESIDENT_NAME = "Address_V12";
        public const string TAXPAYER_ADDRESS_RESIDENTAND_NONRESIDENT = "Address_V13";
        public const string TAXPAYER_ADDRESS_FROMDATE_RESIDENT = "Address_V14";
        public const string TAXPAYER_ADDRESS_TODATE_RESIDENT = "Address_V15";
        public const string TAXPAYER_ADDRESS_FROMDATE_TODATE_GREATER = "Address_V16";


        //EIC Eligibility
        public const string EIC_AGI_EXCEEDS_SINGLE = "EarnedIncomeCredit_BR1";
        public const string EIC_AGI_EXCEEDS_MFJ = "EarnedIncomeCredit_BR2";
        public const string EIC_SINGLE_OR_MFJ__INVALID_SSN = "EarnedIncomeCredit_BR3";
        public const string EIC_AGE_CHECK_MFJ_OR_SINGLE = "EarnedIncomeCredit_BR4";
        public const string EIC_LIVED_IN_US = "EarnedIncomeCredit_BR5";
        public const string EIC_NON_QUALIFIED_CHILD = "EarnedIncomeCredit_BR6";
        public const string EIC_RECEIVED_IRS_NOTICE = "EarnedIncomeCredit_BR7";
        public const string EIC_CLAIMED_AS_DEPENDENT_SINGLE = "EarnedIncomeCredit_BR8";
        //Modified by prasana need to discuss on this 
        public const string EIC_CLAIMED_AS_DEPENDENT_MFJ = "EarnedIncomeCredit_BR13";
        public const string EIC_REDUCED_OR_DISALLOWED_EARLIER_YEAR = "EarnedIncomeCredit_BR14";

        public const string EIC_TAX_PAYER_LIVED_IN_US = "EarnedIncomeCredit_BR11";
        public const string EIC_SPOUSE_LIVED_IN_US = "EarnedIncomeCredit_BR12";

        //Modified by prasana need to discuss on this newly added
        public const string EIC_PRIOR_YEAR_DISALLOWANCE = "EarnedIncomeCredit_BR9";
        public const string EIC_INCORRECTLY_REPORTED_YOUR_EARNED_INCOME = "EarnedIncomeCredit_BR10";

        public const string EIC_TAXABLE_FELLOWSHIP_INCOME = "EarnedIncomeCredit_RF1";
        public const string EIC_PENSION_OR_ANNUITY_NOT_QUALIFIED_COMPENSATION = "EarnedIncomeCredit_RF2";
        public const string EIC_WAGES_FOR_WORK_DONE_WHILE_PENAL_INSTITUTION = "EarnedIncomeCredit_RF3";
        public const string EIC_LIKE_TO_CLAIM_FORM_8862 = "EarnedIncomeCredit_RF4";
        public const string EIC_REDUCED_OR_DISALLOWED_FOR_INCORRECTLY_REPORTEED_INCOME = "EarnedIncomeCredit_RF5";
        public const string EIC_NUMBER_OF_DAYS_TaxPayer_LIVED_IN_US = "EarnedIncomeCredit_RF6";
        public const string EIC_NUMBER_OF_DAYS_SPOUSE_LIVED_IN_US = "EarnedIncomeCredit_RF7";


        //Personal Info
        public const string TAXPAYER_DOD = "PrimaryFiler_BR1";
        public const string SPOUSE_DOD = "Spouse_BR1";

        //Wages
        public const string WAGES_FEDERAL_WITHHOLDING = "Wages_BR1";
        public const string SOCIAL_SECURITY_WAGES = "Wages_BR2";
        public const string SOCIAL_SECURITY_TAX = "Wages_BR3";
        public const string MEDICARE_TAX_WITHHELD = "Wages_BR4";

        public const string BOX12A_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL = "Wages_BR5";
        public const string BOX12A_T_EMPLOYER_PAID_ADOPTION_BENEFITS = "Wages_BR6";
        public const string BOX12A_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH = "Wages_BR7";
        //Added by vivek on 5-June-14
        public const string HOUSEHOLD_EMPLOYEE_WAGES="Wages_BR10";

        public const string BOX12B_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL = "Wages_BR11";
        public const string BOX12B_T_EMPLOYER_PAID_ADOPTION_BENEFITS = "Wages_BR12";
        public const string BOX12B_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH = "Wages_BR13";

        public const string BOX12C_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL = "Wages_BR14";
        public const string BOX12C_T_EMPLOYER_PAID_ADOPTION_BENEFITS = "Wages_BR15";
        public const string BOX12C_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH = "Wages_BR16";

        public const string BOX12D_R_EMPLOYER_CONTRIBUTIONS_TO_ARCHER_MEDICAL = "Wages_BR17";
        public const string BOX12D_T_EMPLOYER_PAID_ADOPTION_BENEFITS = "Wages_BR18";
        public const string BOX12D_W_EMPLOYER_AND_EMPLOYEE_CONTRIBUTIONS_TO_HEALTH = "Wages_BR19";

        public const string WAGES_STATE_LOCAL_STATE_WAGES_NOT_MORE_THAN_FEDERAL_WAGES = "Wages_BR8";
        public const string WAGES_STATE_TAX_WITHHELD = "Wages_BR9";

        public const string ALLOCATED_TIPS = "Wages_ER1";
        public const string DEPENDENT_CARE_BENEFITS = "Wages_ER2";
        public const string BOX12A_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS = "Wages_ER3";
        public const string BOX12A_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS = "Wages_ER4";
        public const string BOX12A_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS = "Wages_ER5";
        public const string BOX12A_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP = "Wages_ER6";
        public const string BOX12A_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP = "Wages_ER7";
        public const string BOX12A_Z_INCOME_RECEIVED_UNDER_409A = "Wages_ER8";

        public const string FOREIGN_EMPLOYMENT_MUST_REPORT = "Wages_ER9";

        public const string BOX12B_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS = "Wages_ER10";
        public const string BOX12B_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS = "Wages_ER11";
        public const string BOX12B_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS = "Wages_ER12";
        public const string BOX12B_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP = "Wages_ER13";
        public const string BOX12B_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP = "Wages_ER14";
        public const string BOX12B_Z_INCOME_RECEIVED_UNDER_409A = "Wages_ER15";

        public const string BOX12C_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS = "Wages_ER16";
        public const string BOX12C_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS = "Wages_ER17";
        public const string BOX12C_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS = "Wages_ER18";
        public const string BOX12C_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP = "Wages_ER19";
        public const string BOX12C_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP = "Wages_ER20";
        public const string BOX12C_Z_INCOME_RECEIVED_UNDER_409A = "Wages_ER21";

        public const string BOX12D_A_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TIPS = "Wages_ER22";
        public const string BOX12D_B_UNCOLLECTED_MEDICARE_TAX_ON_TIPS = "Wages_ER23";
        public const string BOX12D_K_EXCISE_TAX_ON_GOLDEN_PARACHUTE_PAYMENTS = "Wages_ER24";
        public const string BOX12D_M_UNCOLLECTED_SOCIAL_SECURITY_OR_RRTA_TAX_ON_TAXABLE_GROUP = "Wages_ER25";
        public const string BOX12D_N_UNCOLLECTED_MEDICARE_TAX_ON_TAXABLE_GROUP = "Wages_ER26";
        public const string BOX12D_Z_INCOME_RECEIVED_UNDER_409A = "Wages_ER27";

        public const string WAGES_TAX_PAYER_OR_SPOUSE_CODE = "Wages_RF1";
        public const string WAGES_TAX_PAYER_EMPLOYMENT_TYPE = "Wages_RF2";
        public const string WAGES_EIN = "Wages_RF3";
        public const string WAGES_EMPLOYER_NAME = "Wages_RF4";
        public const string WAGES_EMPLOYER_ADDRESS = "Wages_RF5";
        public const string WAGES_EMPLOYER_CITY = "Wages_RF6";
        public const string WAGES_EMPLOYER_STATE = "Wages_RF7";
        public const string WAGES_EMPLOYER_ZIP = "Wages_RF8";
        public const string WAGES_EMPLOYER_ZIP_VALIDATION = "Wages_V14"; // 02Jun2014 Sathish added constats for validation
        public const string WAGES_EMPLOYEE_ADDRESS = "Wages_RF9";
        public const string WAGES_EMPLOYEE_CITY = "Wages_RF10";
        public const string WAGES_EMPLOYEE_STATE = "Wages_RF11";
        public const string WAGES_EMPLOYEE_ZIP = "Wages_RF12";
        public const string WAGES_EMPLOYEE_ZIP_VALIDATION = "Wages_V17";
        public const string WAGES_AMOUNT = "Wages_RF13";
        public const string WAGES_FEDERAL_TAX_WITH_HOLDING_AMOUNT = "Wages_RF14";
        public const string WAGES_STATE_LOCAL_STATE_ID = "Wages_RF16";
        public const string WAGES_STATE_LOCAL_STATE_CODE = "Wages_RF15";
        public const string WAGES_STATE_LOCAL_STATE_WAGES = "Wages_RF17";
        public const string WAGES_STATE_LOCAL_STATE_WAGES_TAX_WITH_HOLDING_AMOUNT = "Wages_RF18";
        public const string WAGES_LOCAL_WAGES_AMOUNT = "Wages_RF19";
        public const string WAGES_LOCAL_WAGES_WITH_HOLDING_AMOUNT = "Wages_RF20";
        public const string WAGES_LOCAL_WAGES_LOCALITY_NAME = "Wages_RF21";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12A = "Wages_RF22";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12B = "Wages_RF23";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12C = "Wages_RF24";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12D = "Wages_RF25";

        // 02Jun2014 Sathish added constant for other information
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12A_AMOUNT = "Wages_RF37";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12B_AMOUNT = "Wages_RF38";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12C_AMOUNT = "Wages_RF39";
        public const string WAGES_BENEFITS_OTHER_INFORMATION_12D_AMOUNT = "Wages_RF40";
        public const string WAGES_BENEFITS_OTHER_INFORMATION = "Wages_RF41";

        // 02Jun2014 Sathish added constant for wages
        public const string WAGES_SOCIAL_SECURITY_TAX_WITHHOLDING_AMOUNT = "Wages_RF34";
        public const string WAGES_MEDICARE_WAGES_AMOUNT = "Wages_RF35";
        public const string WAGES_MEDICARE_TAX_WITHHOLDING_AMOUNT = "Wages_RF36";


        // 04.06.2014 Thileep Added Social Security Wages Constant  
        public const string WAGES_SOCIAL_SECURITY = "Wages_RF33";



        // 02Jun2014 Sathish added constant for House hold employer wages
        public const string WAGES_HOUSE_HOLD_EMPLOYER_NAME_REQUIRED = "Wages_RF42";
        public const string WAGES_HOUSE_HOLD_ADDRESS_REQUIRED = "Wages_RF43";
        public const string WAGES_HOUSE_HOLD_CITY_REQUIRED = "Wages_RF44";
        public const string WAGES_HOUSE_HOLD_STATE_REQUIRED = "Wages_RF45";
        public const string WAGES_HOUSE_HOLD_ZIP_REQUIRED = "Wages_RF46";
        public const string WAGES_HOUSE_HOLD_ZIP_VALIDATION = "Wages_V15";
        public const string WAGES_HOUSE_HOLD_EMPLOYER_NAME_VALIDATION = "Wages_V11";
        public const string WAGES_HOUSE_HOLD_ADDRESS_VALIDATION = "Wages_V12";
        public const string WAGES_HOUSE_HOLD_CITY_VALIDATION = "Wages_V13";

        public const string WAGES_HOUSE_HOLD_WAGES = "Wages_RF26";
        public const string WAGES_INSTITUITION_NAME = "Wages_RF27";
        public const string WAGES_INSTITUITION_ADDRESS = "Wages_RF28";
        public const string WAGES_INSTITUITION_CITY = "Wages_RF29";
        public const string WAGES_INSTITUITION_STATE = "Wages_RF30";
        public const string WAGES_INSTITUITION_ZIP = "Wages_RF31";
        public const string WAGES_TAX_ABLE_SCHOLARSHIP_INCOME = "Wages_RF32";
        public const string WAGES_EMPLOYER_EIN_INVALID = "Wages_V1";
        public const string WAGES_EMPLOYER_NAME_ALPHABET = "Wages_V2";
        public const string WAGES_EMPLOYER_ADDRESS_ALPHABET = "Wages_V3";
        public const string WAGES_EMPLOYER_CITY_ALPHABET = "Wages_V4";
        public const string WAGES_EMPLOYEEE_ADDRESS_ALPHABET = "Wages_V5";
        public const string WAGES_EMPLOYEE_CITY_ALPHABET = "Wages_V6";
        public const string WAGES_INSTITUITION_ZIP_INVALID = "Wages_V7";
        public const string WAGES_INSTITUITION_ZIP_VALIDATION = "Wages_V16"; // 02Jun2014 Sathish added constant for instution zip code validaiton
        public const string WAGES_INSTITUITION_NAME_ALPHABET = "Wages_V8";
        public const string WAGES_INSTITUITION_ADDRESS_ALPHABET = "Wages_V9";
        public const string WAGES_INSTITUITION_CITY_ALPHABET = "Wages_V10";


        //Interest Income
        //public const string EARLY_WITHDRAWAL_PENALTY = "InterestIncome_BR1";
        //public const string INTEREST_INCOME_FEDERAL_WITHHOLDING = "InterestIncome_BR2";
        //public const string INVESTMENT_EXPENSES = "InterestIncome_BR3";
        //public const string FOREIGN_TAX_WITHHELD = "InterestIncome_BR4";
        //public const string INTEREST_INCOME_STATE_TAX_WITHHELD = "InterestIncome_BR5";
        //public const string INT_NOMINEE_INTEREST = "InterestIncome_ER1";
        //public const string INT_US_BOND_SAVING = "InterestIncome_ER2";
        //public const string INT_FOREIGN_FINANICAL = "InterestIncome_ER3";
        //public const string INT_SELLER_FINANICAL_MORTGAGE = "InterestIncome_ER4";
        //public const string INT_ORGINIAL_ISSUE_DISCOUNT = "InterestIncome_ER5";
        //public const string INT_AMORTIZABLE_BOND = "InterestIncome_ER6";
        //public const string INT_SERIES_EE_OR_US_SAVING_BOND = "InterestIncome_ER7";

        //Interest Income - Business Rule.
        public const string INTEREST_INCOME_FEDERAL_WITHHOLDING = "InterestIncome_BR1";
        public const string INVESTMENT_EXPENSES = "InterestIncome_BR2";
        public const string INTEREST_INCOME_STATE_TAX_WITHHELD = "InterestIncome_BR3";
        public const string FOREIGN_TAX_WITHHELD = "InterestIncome_BR4";
        public const string INT_EARLY_WITHDRAWAL_PENALTY_BR = "InterestIncome_BR5";
        public const string OID_FEDERAL_WITHHOLDING_BR = "InterestIncome_BR6";
        public const string OID_INVESTMENT_EXPENSES_BR = "InterestIncome_BR7";
        public const string OID_STATE_TAX_WITHHELD_BR = "InterestIncome_BR8";
        public const string OID_FOREIGN_TAX_WITHHELD_BR = "InterestIncome_BR9";
        public const string OID__EARLY_WITHDRAWAL_PENALTY_BR = "InterestIncome_BR10";

        //Interest Income - Eligibility Rules
        public const string INT_NOMINEE_INTEREST = "InterestIncome_ER1";
        public const string INT_US_BOND_SAVING = "InterestIncome_ER2";
        public const string INT_FOREIGN_FINANICAL = "InterestIncome_ER3";
        public const string INT_SELLER_FINANICAL_MORTGAGE = "InterestIncome_ER4";
        public const string INT_ORGINIAL_ISSUE_DISCOUNT = "InterestIncome_ER5";
        public const string INT_AMORTIZABLE_BOND = "InterestIncome_ER6";
        public const string INT_SERIES_EE_OR_US_SAVING_BOND = "InterestIncome_ER7";
        public const string INT_EARLY_WITHDRAWAL_PENALTY = "InterestIncome_ER8";
        public const string INT_FOREIGN_TAX_PAID = "InterestIncome_ER9";
        public const string INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT = "InterestIncome_ER10";

        //Interest Income - Required Field 
        public const string INT_WHOSE_INCOME_IS_THIS = "InterestIncome_RF1";
        public const string INT_PAYER_NAME = "InterestIncome_RF2";
        public const string INT_INTEREST_INCOME = "InterestIncome_RF3";
        public const string INT_STATE_CODE_TAX_EXEMPT_INTEREST = "InterestIncome_RF4";
        public const string OID_ORIGINAL_ISSUE_DISCOUNT = "InterestIncome_RF5";
        public const string OID_TAX_EXEMPT_INTEREST = "InterestIncome_RF6";
        public const string OID_STATE_TAX_EXEMPT_INTEREST = "InterestIncome_RF7";
        public const string OID_ADUJUSTMENT = "InterestIncome_RF8";
        public const string INT_NO_OPTION_SELECTED = "InterestIncome_RF9";
        public const string INT_BOX11_STATE_CODE1_MISSING = "InterestIncome_RF10";
        public const string INT_BOX11_STATE_CODE2_MISSING = "InterestIncome_RF11";
        public const string OID_BOX11_STATE_CODE1_MISSING = "InterestIncome_RF12";
        public const string OID_BOX11_STATE_CODE2_MISSING = "InterestIncome_RF13";
        public const string OID_WHOSE_INCOME_IS_THIS = "InterestIncome_RF14";
        public const string OID_PAYER_NAME = "InterestIncome_RF15";

        //Interest Income - Validations
        public const string INT_PAYER_NAME_SPECIAL_CHARACTERS = "InterestIncome_V1";
        public const string INT_PAYER_IDENTIFICATION_NUMBER = "InterestIncome_V2";        
        public const string OID_PAYER_NAME_SPECIAL_CHARACTERS = "InterestIncome_V3";
        public const string OID_PAYER_IDENTIFICATION_NUMBER = "InterestIncome_V4";
        // Added by vivek on 6-jun-14 as per the spec
        public const string INT_STATE_TAX_EXEMPT_INTEREST_EXCEEDS_TAX_EXEMPT_INTEREST = "InterestIncome_V5";
        //6th June, 2014 Saravanan Added Validation # 6. 
        public const string OID_STATE_TAX_EXEMPT_INTEREST_EXCEEDS_TAX_EXEMPT_INTEREST = "InterestIncome_V6";

        //Form 1099G  - Unemployment Compensation
        public const string F1099G_FEDERAL_WITHHOLDING = "UnemploymentCompensation_BR1";
        public const string F1099G_STATE_WITHHOLDING = "UnemploymentCompensation_BR2";

        public const string F1099G_WHOSE_UNEMPLOYMENT_COMPENSATION_IS_THIS = "UnemploymentCompensation_RF1";
        public const string F1099G_PAYER_NAME_MISSING = "UnemploymentCompensation_RF2";
        public const string F1099G_PAYER_ADDRESS_MISSING = "UnemploymentCompensation_RF3";
        public const string F1099G_PAYER_CITY_MISSING = "UnemploymentCompensation_RF4";
        public const string F1099G_PAYER_STATE_CODE_MISSING = "UnemploymentCompensation_RF5";
        public const string F1099G_PAYER_ZIP_CODE_MISSING = "UnemploymentCompensation_RF6";
        public const string F1099G_PAYER_IDENTIFIQATION_NUMBER_MISSING = "UnemploymentCompensation_RF7";
        public const string F1099G_UNEMPLOYMENT_COMPENSATION_AMOUNT_MISSING = "UnemploymentCompensation_RF8";
        public const string F1099G_BOX_4_FEDERAL_TAX_WITHHELD_MISSING = "UnemploymentCompensation_RF9";
        public const string F1099G_REPAID_AMOUNT_MISSING = "UnemploymentCompensation_RF10";
        //Yogalkashmi - 29th May 2014 - Added two new error messages(RF11 and RF12) as per the modified SPEC.
        public const string F1099G_REPAID_AMOUNT_PRIOR_YEAR_MISSING = "UnemploymentCompensation_RF11";
        public const string F1099G_STATE_CODE_MISSING = "UnemploymentCompensation_RF12";

        public const string F1099G_BOX_4_FEDERAL_TAX_WITHHELD_NOT_GREATER_THAN_UNEMPLOYMENT_COMPENSATION = "UnemploymentCompensation_BR1";
        public const string F1099G_BOX11_STATE_TAX_WITHHELD_NOT_GREATER_THAN_UNEMPLOYMENT_COMPENSATION = "UnemploymentCompensation_BR2";

        public const string F1099G_PAYER_NAME_HAS_SPECIAL_CHARACTERS = "UnemploymentCompensation_V1";
        public const string F1099G_PAYER_ADDRESS_HAS_SPECIAL_CHARACTERS = "UnemploymentCompensation_V2";
        public const string F1099G_PAYER_CITY_HAS_SPECIAL_CHARACTERS = "UnemploymentCompensation_V3";
        public const string F1099G_PAYER_ZIP_CODE_INVALID = "UnemploymentCompensation_V4";
        public const string F1099G_PAYER_IDENTIFIQATION_NUMBER_INVALID = "UnemploymentCompensation_V5";

        public const string F1099G__REPAID_AMOUNT_FOR_EARLIER_YEAR = "UnemploymentCompensation_ER1";

        //Other Income
        public const string OTHERINCOME_NET_BENEFITS = "OtherIncome_RF1";
        public const string OTHERINCOME_ALASKA_DIVIDEND_INCOME_MISSING = "OtherIncome_RF2";
        public const string OTHERINCOME_WHOSE_TAXREFUND_IS_THIS = "OtherIncome_RF3";
        public const string OTHERINCOME_STATE_CODE = "OtherIncome_RF4";

        public const string OTHERINCOME_FEDERAL_TAX_WITHHELD_NOT_GREATER_THAN_NET_BENEFIT = "OtherIncome_BR1";
        public const string OTHERINCOME_FEDERAL_TAX_WITHHELD_NOT_GREATER_THAN_NET_TIER_BENEFIT = "OtherIncome_BR2";
        public const string OTHERINCOME_SSB_SPOUSE_FEDERAL_WITHHOLDING = "OtherIncome_BR3";
        public const string OTHERINCOME_RRB_SPOUSE_FEDERAL_WITHHOLDING = "OtherIncome_BR4";

        public const string OTHERINCOME_STATE_TAX_REFUND = "OtherIncome_ER1";
        public const string OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS = "OtherIncome_ER2";


        //SSA
        public const string SSA_FEDERAL_WITHHOLDING = "OtherIncome_BR1";
        public const string RRB_FEDERAL_WITHHOLDING = "OtherIncome_BR2";


        //Form 8862
        public const string F8862_EARNED_INCOME_CREDIT_DISALLOWED = "Form8862_BR1";
        public const string F8862_TAX_YEAR_TAXPAYER_FILING_FORM_8862 = "Form8862_BR2";
        public const string F8862_EIC_REDUCED_DISALLOWED_EARLIER_YEAR = "Form8862_BR3";
        public const string F8862_TAXPAYER_DAYS_LIVED_US = "Form8862_BR4";
        public const string F8862_SPOUSE_DAYS_LIVED_US = "Form8862_BR5";
        public const string F8862_EIC_INCORRECT_INCOME = "Form8862_BR6";

        // Email
        public const string EMAIL_FIRST_NAME = "@@first_name";
        public const string EMAIL_NICK_NAME = "@@nick_name";
        public const string EMAIL_RESET_CODE = "@@reset_code";
        public const string EMAIL_USER_NAME = "@@user_name";
        public const string EMAIL_EMAIL_ID = "@@email";
        public const string EMAIL_PASSWORD_RESET_LINK = "@@password_reset_link";
        public const string EMAIL_LOGIN_LINK = "@@login_link";

        public const string EMAIL_PASSWORD = "@@password";
        public const string EMAIL_SECURITY_QUESTION = "@@security_question";
        public const string EMAIL_SECURITY_ANSWER = "@@security_answer";


        //EmailTemplateImages
        //public const string EMAIL_TWITTER_LINK = "@@ExciseURL";
        //public const string EMAIL_FACEBOOK_LINK = "@@ExciseURL";
        //public const string EMAIL_LINKEDIN_LINK = "@@ExciseURL";
        //public const string EMAIL_HEADER_LINK = "@@ExciseURL";
        //public const string EMAIL_BBB_LINK = "@@ExciseURL";
        //public const string EMAIL_IRS_GOVT_EFILE_LINK = "@@ExciseURL";

        public const string Tax1040ImageUrl = "Tax1040ImageUrl";
        public const string EMAIL_IMAGE_LINK = "@@Tax1040URL";
        public const string APP_SETTING_KEY_PASSWORD_RESET_URL = "PasswordResetUrl";

        //App Setting Name
        public const string APP_SETTING_KEY_FROM_MAIL = "FromEmail";
        public const string APP_SETTING_EXCEPTIONGROUPMAIL = "ExceptionGroupMail";
        public const string APP_SETTING_ERROR_FROM_WHICH_SERVER = "ErrorFromServer";
        public const string APP_SETTING_KEY_MAIL_HOST = "MailHost";
        public const string APP_SETTING_KEY_ADMIN_MAIL = "AdminEmail";
        public const string APP_SETTING_LOGIN_LINK = "LoginLink";

        //  public const string APP_SETTING_KEY_HEADER_LINK = "HeaderLinkEmail";
        // public const string APP_SETTING_KEY_TWITTER_LINK = "TwitterLinkEmail";
        //  public const string APP_SETTING_KEY_FACEBOOK_LINK = "FacebookLinkEmail";
        //  public const string APP_SETTING_KEY_LINKEDIN_LINK = "LinkedinLinkEmail";
        //  public const string APP_SETTING_KEY_BBB_LINK = "BBBLinkEmail";
        //  public const string APP_SETTING_KEY_IRS_GOVT_EFILE_LINK = "IrsGovtEfileLinkEmail";
        public const string APP_SETTING_KEY_PASSWORD = "Password";
        public const string APP_SETTING_KEY_SECURITY_ANSWER = "SecurityAnswer";

        //PDF Binding
        public const string Integer = "Integer";
        public const string Decimal = "Decimal";
        public const string String = "String";
        public const string Bool = "Bool";
        public const string SSN = "SSN";
        public const string RTN = "RTN";
        public const string AccountNumber = "AccountNumber";
        public const string PIN = "PIN";
        public const string List = "List";
        public const string Check = "Check";
        public const string UnCheck = "UnCheck";
        public const string Split = "Split";
        public const string SplitReverse = "SplitReverse";

        //Business Validations

        public const string NineZeros = "000000000";
        public const string NineNines = "999999999";
        public const string NaturalNumbers = "123456789";
        public const int InvalidSsnAreaCodeRange = 772;
        public const int InvalidSsnAreaCode = 666;

        //EIN Validation
        public const string TenZeros = "0000000000";
        public const string TenNines = "9999999999";
        public const int intZero = 0;

        //Added by Bala for Phone Number and SSN
        public const int PhoneNumerLength = 10;
        public const int SSNLength = 9;

        //Topic Name
        public const string TOPIC_PERSONAL_FILINGSTATUS = "FilingStatus";
        public const string TOPIC_PERSONAL_PRIMARYFILER = "PrimaryFiler";
        public const string TOPIC_PERSONAL_SPOUSE = "Spouse";
        public const string TOPIC_PERSONAL_ADDRESS = "Address";
        public const string TOPIC_PERSONAL_EZELIGIBILITY = "EZEligibility";

        public const string TOPIC_UNEMPLOYMENT_COMPENSATION = "UnemploymentCompensation";
        public const string TOPIC_OTHER_INCOME = "OtherIncome";
        public const string TOPIC_WAGES = "Wages";
        public const string TOPIC_INTEREST_INCOME = "InterestIncome";
        public const string TOPIC_EARNED_INCOME_CREDIT = "EarnedIncomeCredit";
        public const string TOPIC_TAX_AND_WRAPUP = "TaxesAndWrapUp";
        public const string TOPIC_IRS_PAYMENT_OPTION = "Payment";  // 13May2014 Sathish added constant to clear error message
        public const string TOPIC_FORM_INT = "FormINT";
        public const string TOPIC_FORM_OID = "FormOID";
        public const string TOPIC_OTHER_INCOME_SSB_RRB = "SSB&RRB";
        public const string TOPIC_OTHER_INCOME_Alaska = "Alaska";
        public const string TOPIC_OTHER_INCOME_State_And_Local = "State&local";


        //Error messages for tax and wrap up
        public const string TAX_AND_WRAP_UP_TAXPAYER_NOT_TO_CLAIM_ANY_HOUSEHOLD_EMPLOYMENT_TAX = "TaxesAndWrapUp_ER1";
        public const string TAX_AND_WRAP_UP_TAXPAYER_NOT_TO_INCUR_ANY_AMT_OTHER_TAXES = "TaxesAndWrapUp_ER2";
        public const string TAX_AND_WRAP_UP_ADDITIONAL_SOCIAL_SECURITY_AND_MEDICARE = "TaxesAndWrapUp_ER3";
        public const string TAX_AND_WRAP_UP_NO_ESTIMATES_ADDITIONAL_FEDERAL_WITHHELD = "TaxesAndWrapUp_ER4";
        public const string TAX_AND_WRAP_UP_TAXABLE_INCOME = "TaxesAndWrapUp_ER5";
        public const string TAX_AND_WRAP_UP_EXTENSTION_AMOUNT = "TaxesAndWrapUp_RF1";
        public const string TAX_AND_WRAP_UP_EXTENSION_DATE = "TaxesAndWrapUp_RF2";
        public const string TAX_AND_WRAP_UP_FILING_DATE = "TaxesAndWrapUp_RF3";
        public const string TAX_AND_WRAP_UP_BANK_NAME = "TaxesAndWrapUp_RF4";
        public const string TAX_AND_WRAP_UP_ROUTING_NUMBER = "TaxesAndWrapUp_RF5";
        public const string TAX_AND_WRAP_UP_ACCOUNT_NUMBER = "TaxesAndWrapUp_RF6";
        public const string TAX_AND_WRAP_UP_TYPE_OF_ACCOUNT = "TaxesAndWrapUp_RF7";
        public const string TAX_AND_WRAP_UP_DESIGNEE_NAME = "TaxesAndWrapUp_RF8";
        public const string TAX_AND_WRAP_UP_DESIGNEE_PHONE_NO = "TaxesAndWrapUp_RF9";
        public const string TAX_AND_WRAP_UP_DESIGNEE_PERSONAL_IDENTIFICATION_NUMBER = "TaxesAndWrapUp_RF10";
        public const string TAX_AND_WRAP_UP_ROUTING_NUMBER_VALIDATION = "TaxesAndWrapUp_V1";
        public const string TAX_AND_WRAP_UP_ACCOUNT_NUMBER_VALIDATION = "TaxesAndWrapUp_V2";
        public const string TAX_AND_WRAP_UP_INVALID_DESIGNEE_PHONE_NUMBER = "TaxesAndWrapUp_V3";
        /* 27May2014 Sathish added error message for extenstion date dand filling date for spec Tax1040EZ-06_Taxes and Wrap Up _TY2014_V1 1 */
        public const string TAX_AND_WRAP_UP_REQUIRED_EXTENSION_FILED_DATE = "TaxesAndWrapUp_RF11";
        public const string TAX_AND_WRAP_UP_VALIDATION_EXTENSION_FILED_DATE = "TaxesAndWrapUp_V4";
        public const string TAX_AND_WRAP_UP_VALIDATION_FILED_DATE = "TaxesAndWrapUp_V5";
        public const string TAX_AND_WRAP_UP_VALIDATION_EXTENSION_DATE = "TaxesAndWrapUp_V6";
        public const string TAX_AND_WRAP_UP_INVALID_INCARE_PHONE_NUMBER = "TaxesAndWrapUp_V7";

        // 03July2014 Thileep Added constant for  validation field
        public const string TAX_AND_WRAP_UP_INVALID_INCARE_OF = "TaxesAndWrapUp_V9";
        public const string TAX_AND_WRAP_UP_INVALID_DESIGNEE_NAME = "TaxesAndWrapUp_V10";
        public const string TAX_AND_WRAP_UP_INVALID_BANK_NAME = "TaxesAndWrapUp_V8";
        public const string TAX_AND_WRAP_UP_INVALID_DESIGNEE_PERSONAL_IDENTIFICATION_NUMBER = "TaxesAndWrapUp_V11";

        // 13May2014 Sathish Added constant for required and validation field
        public const string PAYMENT_REQUIRED_TYPE_OF_ACCOUNT = "Payment_RF1";
        public const string PAYMENT_REQUIRED_ACCOUNT_NUMBER = "Payment_RF2";
        public const string PAYMENT_REQUIRED_ROUTING_NUMBER = "Payment_RF3";
        public const string PAYMENT_VALIDATION_ROUTING_NUMBER = "Payment_V1";
        public const string PAYMENT_REQUIRED_BANK_NAME = "Payment_RF15";
        public const string PAYMENT_REQUIRED_INSTRUCTION_DIRECT_DEBIT = "Payment_RF16";
        public const string PAYMENT_REQUIRED_INSTRUCTION_EFTPS = "Payment_RF17";
        public const string PAYMENT_REQUIRED_INSTRUCTION_CHECK_OR_MONEY_ORDER = "Payment_RF18";
        public const string PAYMENT_REQUIRED_FIRST_NAME = "Payment_RF4";
        public const string PAYMENT_VALIDATION_FIRST_NAME = "Payment_V2";
        public const string PAYMENT_REQUIRED_LAST_NAME = "Payment_RF19";
        public const string PAYMENT_VALIDATION_LAST_NAME = "Payment_V10";
        public const string PAYMENT_REQUIRED_STREET_ADDRESS = "Payment_RF5";
        public const string PAYMENT_VALIDATION_STREET_ADDRESS = "Payment_V3";
        public const string PAYMENT_REQUIRED_CITY_NAME = "Payment_RF6";
        public const string PAYMENT_VALIDATION_CITY_NAME = "Payment_V4";
        public const string PAYMENT_REQUIRED_ZIP_CODE = "Payment_RF8";
        public const string PAYMENT_REQUIRED_PHONE_NUMBER = "Payment_RF9";
        public const string PAYMENT_VALIDATION_PHONE_NUMBER = "Payment_V7";
        public const string PAYMENT_REQUIRED_STATE_CODE = "Payment_RF8";
        public const string PAYMENT_VALIDATION_STATE_NAME = "Payment_V6";
        public const string PAYMENT_REQUIRED_FOREIGN_COUNTRY_NAME = "Payment_RF10";
        public const string PAYMENT_REQUIRED_CARD_TYPE = "Payment_RF11";
        public const string PAYMENT_REQUIRED_CARD_NUMBER = "Payment_RF12";
        public const string PAYMENT_VALIDATION_CARD_NUMBER = "Payment_V8";
        public const string PAYMENT_REQUIRED_CVC = "Payment_RF13";
        public const string PAYMENT_REQUIRED_EXPIRATION_DATE = "Payment_RF14";
      //  public const string PAYMENT_REQUIRED_EXPIRATION_DATE = "Payment_V9";



        // 22May2014 Sathish Regex Pattern for Credit Card
        public const string REGEX_VISA_CARD = @"(^4\d{12}$)|(^4[0-8]\d{14}$)|(^(49)[^013]\d{13}$)|(^(49030)[0-1]\d{10}$)|(^(49033)[0-4]\d{10}$)|(^(49110)[^12]\d{10}$)|(^(49117)[0-3]\d{10}$)|(^(49118)[^0-2]\d{10}$)|(^(493)[^6]\d{12}$)";
        public const string REGEX_MASTER_CARD = @"^5[1-5]\d{2}-?\d{4}-?\d{4}-?\d{4}$";
        public const string REGEX_AMEX_CARD = @"^3[4,7]\d{13}$";
        public const string REGEX_DISCOVER_CARD = @"^6011-?\d{4}-?\d{4}-?\d{4}$";

        //PDF Schema File Name Constants
        //Added by Ashok Kumar
        //F1040EZ - PDF Mapper XML constants 
        public const string MAPPERXML_F1040EZ_OUTPUTFROM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.F1040EZPdfSchema.xml";
        public const string MAPPERXML_F1040EZ_EIC_WORKSHEET = "JTL.Tax1040.PDFBinding.PdfXmlMappers.EICWorkSheetPdfSchema.xml";
        public const string MAPPERXML_F1040EZ_SSB_WORKSHEET = "JTL.Tax1040.PDFBinding.PdfXmlMappers.SSBWorkSheetPdfSchema.xml";
        public const string MAPPERXML_F1040EZ_STANDARD_DEDUCTION_WORKSHEET = "JTL.Tax1040.PDFBinding.PdfXmlMappers.StandardDeductionWorkSheetPdfSchema.xml";
        public const string MAPPERXML_F1040EZ_FW2_OUTPUTFORM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.FW2PdfSchema.xml";
        //Bala.25-Jun-14, Added PDF Mapper
        public const string MAPPERXML_F8862_OUTPUTFORM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.F8862PdfSchema.xml";
        public const string MAPPERXML_F8879_OUTPUTFORM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.F8879PdfSchema.xml";
        public const string MAPPERXML_F1040V_OUTPUTFORM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.F1040VPdfSchema.xml";
        

        //Added by Praveen T on PDF Binding.
        public const string FORM1040EZ_BINDING = "F1040EZBinding";
        public const string EICWORKSHEET_BINDING = "EICWorkSheetBinding";
        public const string SSBWORKSHEET_BINDING = "SSBWorkSheetBinding";
        public const string STANDARDDEDUCTIONWORKSHEET_BINDING = "StandardDeductionWorkSheetBinding";
        public const string FORMW2_BINDING = "FW2Binding";
        //Bala.25-Jun-14, Added PDF Binding.
        public const string FORM8862_BINDING = "F8862Binding";
        

        //Yogalakshmi - 26th June 2014 - Added for Form 8879 PDF Binding
        public const string FORM8879_BINDING = "Form8879Binding";
        public const string MAPPERXML_FORM8879_OUTPUTFORM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.F8879PdfSchema.xml";

        //Yogalakshmi - 26th June 2014 - Added for Form 1040 V Binding PDF Binding 
        public const string FORM1040V_BINDING = "Form1040VBinding";
        public const string MAPPERXML_FORM1040V_OUTPUTFORM = "JTL.Tax1040.PDFBinding.PdfXmlMappers.F1040VPdfSchema.xml";
    }
}


