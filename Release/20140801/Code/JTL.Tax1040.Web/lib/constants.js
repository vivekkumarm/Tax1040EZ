/*
Copyright   : Copyright Jeevan Technologies
File Name   : constants.js 
Description : Constants
Author      : Sathish
Created Date : 20Jun2014
*/

// 24Jun2014 Sathish given semi colon for each constant

var Tab = {
    SignUp: 'SignUp',
    SignIn: 'SignIn',
    SignInIssues: 'SignInIssues',
    PersonalInfo: 'PersonalInfo',
    Income: 'Income',
    Credits: 'Credits',
    TaxesAndWrapUp: 'TaxesAndWrapUp',
    File: 'File',
    State: 'State',
    Deduction: 'Deduction',
    Review: 'Review',
    Efile: 'EFile'
};

var Topic = {
    Address: 'Address',
    Alaska: 'Alaska',
    EarnedIncomeCredit: 'EarnedIncomeCredit',
    Efile: 'Efile',
    EZEligibility: 'EZEligibility',
    FilingStatus: 'FilingStatus',
    FormINT: 'FormINT',
    FormOID: 'FormOID',
    InterestIncome: 'InterestIncome',
    OtherIncome: 'OtherIncome',
    Payment: 'Payment',
    PreLogin: 'PreLogin',
    PrimaryFiler: 'PrimaryFiler',
    Spouse: 'Spouse',
    SSBRRB: 'SSB&RRB',
    Statelocal: 'State&local',
    TaxesAndWrapUp: 'TaxesAndWrapUp',
    UnemploymentCompensation: 'UnemploymentCompensation',
    Wages: 'Wages'
};

var MessageType = {
    BR: 'BR',
    ER: 'ER',
    RF: 'RF',
    V: 'V'
};

var ErrorType = {
    Error: 'Error',
    Information: 'Information',
    Warning: 'Warning'
};


var FilingStatus
{
    None = 0,
    Single = 1,
    MarriedFilingJointly = 2,
    MarriedFilingSeperately = 3,
    CivilUnion = 4,
    SameSexMarriage = 5,
    Widower = 6,
    HeadofHousehold = 7
};

//23Jul2014 Sathish added filing return status constant
var ReturnStatus
{
    None = 0,
    Transmitted = 1,
    Rejected = 2,
    NotStarted = 3,
    InProgress = 4,
    Accepted = 5,
    PrintPaperCopy = 6
};

var ErrorTypeIcon =
{
    PersonalInfo : '#supPersonalInfoErrorTypeIcon',
    Income : '#supIncomeErrorTypeIcon',
    Deduction : '#supDeductionErrorTypeIcon',
    Credits : '#supCreditsErrorTypeIcon',
    TaxesWrapUp : '#supTaxesWrapUpErrorTypeIcon',
    Review : '#supReviewErrorTypeIcon',
    State : '#supStateErrorTypeIcon'
};
