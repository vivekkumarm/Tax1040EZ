//W2 Scripts

//22 Apr 2014- vincent Moved-w2LocalTaxInfo List to W2StateLocalTaxInfo
//13 May 14- Vincent-CheckBox Id name change.
//14 May 14-Vincent- Added th DDL fuction in Document ready 
//14 May 14-Vincent-Eligibility check occurred 
//19 May 14-Vincent-Made a numeric check for 'Dot'.
//16th June, 2014 - Saravanan N - Amount field allow 9.2 digits.
//25th June, 2014 - Yogalakshmi - Foreign employment div hide.
// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country

var w2Id;
var employmentType;
var ownerType;
var otherDeductionBenefitsRecordCount = 0;
var stateWagesRecordCount = 0;
var localTaxInfoRecordCount = 0;
var box14OtherCode;
var state;
var isEligibilityCheckFailed = false;
var controls;
var FOREIGN_EMPLOYMENT = 8;
var parameters;

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    $('#txtHouseholdEmployerCity').bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^a-zA-Z ]/g, ''));
        }, $(this)), 0);
    });

    jQuery.validator.addMethod("numbersonly", function (value, element) {
        return this.optional(element) || /^[0-9]+$/i.test(value);
    }, "numbers only please");


    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');
   
    //Added by Vivek on 30 May 2014

    NumbersOnly('txtW2FederalWages');
    NumbersOnly('txtW2FederalWithheld');
    NumbersOnly('txtW2SSWages');
    NumbersOnly('txtW2SSwithheld');
    NumbersOnly('txtW2MedicalWages');
    NumbersOnly('txtW2MedicalWithheld');
    NumbersOnly('txtW2SSTips');
    NumbersOnly('txtW2AllocatedTips');
    NumbersOnly('txtW2DependentCare');
    NumbersOnly('txtQualifiedPlan');
    NumbersOnly('txt12AAmount');
    NumbersOnly('txt12BAmount');
    NumbersOnly('txt12CAmount');
    NumbersOnly('txt12DAmount');
    NumbersOnly('txtW2Amount0');
    NumbersOnly('txtW2StateID0');
 
    NumbersOnly('txtW2StateWages0');
    NumbersOnly('txtW2LocalWages0');
    NumbersOnly('txtW2LocalWithHeld0');

    NumbersOnly('txtW2StateWithheld0');
    NumbersOnly('txtTaxableScholarshipAmount');

    NumbersOnly('txtHouseholdEmployeeWages');
    
  

    NumbersOnlyNotAcceptingDot('txtW2EmployerZip');
    NumbersOnlyNotAcceptingDot('txtHouseholdEmployerZip');
    NumbersOnlyNotAcceptingDot('txtW2EmployeeZip');
    NumbersOnlyNotAcceptingDot('txtW2EmployerID');
    NumbersOnlyNotAcceptingDot('txtInstitutionZip');
    LettersAndSpaceOnly('txtW2EmployerCity'); 
    LettersAndSpaceOnly('txtW2EmployeeCity'); //Saravanan N - 1st Aug, 2014 - Defect # 14028 - City should allow only alphabets and space as per the spec. requirement.
    NumbersLettersAndHyphen('txtW2EmployeeAddress');
    NumbersLettersAndHyphen('txtInstitutionAddress');
    NumbersLettersAndHyphen('txtW2EmployerAddress');
    NumbersLettersAndHyphen('txtHouseholdEmployerAddress');
    NumbersLettersAndHyphen('txtW2EmployerName');
    NumbersLettersAndHyphen('txtHouseholdEmployerName');
    //TAX1040-13952 - Yogalakshmi - 11th June 2014 - Client side validation 
    LettersAndSpaceOnly('txtHouseholdEmployerCity');
    //Thileep - 17th June 2014 - Client side validation 
    LettersAndSpaceOnly('txtInstitutionCity');

    //Yogalakshmi - 30th June 2014 - Defect fix for TAX1040-14093 where it should accept only numbers, alphabets, hyphen and space
    NumbersLettersAndHyphen('txtInstitutionName');

    //Yogalakshmi - 3rd July 2014 - Defect fix for TAX1040-14098 where it should accept only numbers, alphabets, hyphen and space
    NumbersLettersAndHyphen('txtW2LocalityName0');
    //Yogalakshmi - 3rd July 2014 - Added to allow only numbers, letters and hyphen.
    NumbersLettersAndHyphen('txtW2Description0');

    $("#W2").validate({

        rules: {
            txtW2FederalWages: {
                required: true,
                numbersonly: true
            },
            txtW2EmployerID:
                {
                    minlength: 10,
                    validateEINFor0000: true
                },
            //Yogalakshmi - 7th Aug 2014 - Added client side validation for Employer City which should atleast have 3 characters
            txtW2EmployerCity:
                {
                    minlength:3
                },
            //Yogalakshmi - 13th Aug 2014 - Added client side validation for City which should atleast have 3 characters
            txtHouseholdEmployerCity:
                {
                    minlength: 3
                },
            txtInstitutionCity:
                {
                    minlength: 3
                },
            txtW2EmployeeCity:
                {
                    minlength: 3
                },
            txtHouseholdEmployerZip: {
                minlength: 5,
                maxlength: 10,
                validateZipCode: true
            },
            txtW2EmployerZip:
                {
                    minlength: 5,
                    maxlength: 10,
                    validateZipCode: true
                },
            txtW2EmployeeZip:
                {
                    minlength: 5,
                    maxlength: 10,
                    validateZipCode: true
                },
            txtInstitutionZip:
                 {
                     minlength: 5,
                     maxlength: 10,
                     validateZipCode: true
                 },
        },
        messages: {
            txtW2FederalWages: {
                required: "Federal Wages should not be Empty",
                numbersonly: "Enter Number only"
            },
            txtW2EmployerID:
                {
                    minlength: "Invalid Employer Identification Number",
                    validateEINFor0000: "Invalid Employer Identification Number"
                },
            //Yogalakshmi - 7th Aug 2014 - Added client side validation for Employer City which should atleast have 3 characters
            txtW2EmployerCity:
                {
                    minlength: "Invalid Employer City"
                },
            //Yogalakshmi - 13th Aug 2014 - Added client side validation for City which should atleast have 3 characters
            txtHouseholdEmployerCity:
                {
                    minlength: "Invalid Employer City"
                },
            txtInstitutionCity:
                {
                    minlength: "Invalid City"
                },
            txtW2EmployeeCity:
                {
                    minlength: "Invalid Employee City"
                },
            txtW2EmployerZip:
                {
                    minlength: "Invalid Zip Code",
                    maxlength: "Invalid Zip Code",
                    validateZipCode: 'Invalid Zip Code'
                },
            txtHouseholdEmployerZip:
               {
                   minlength: "Invalid Zip Code",
                   maxlength: "Invalid Zip Code",
                   validateZipCode: 'Invalid Zip Code'
                },
            txtW2EmployeeZip:
                {
                    minlength: "Invalid Zip Code",
                    maxlength: "Invalid Zip Code",
                    validateZipCode: 'Invalid Zip Code'
                },
            txtInstitutionZip:
              {
                  minlength: "Invalid Zip Code",
                  maxlength: "Invalid Zip Code",
                  validateZipCode: 'Invalid Zip Code'
                }
        }

    });



    //Error message- focus method for user control
    fromSummary = false;
    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
   parameters = pageURL.split('&');
    //Vincent-23Jun2014-Added a or condition for parameter length while click the error message form Review section
    if (parameters.length == 2 || parameters.length == 3) {
        fromSummary = true;
        var controlParmeters = parameters[0];
        w2Id = parameters[1];
        controls = controlParmeters.split('-');
        if (controls.length == 2) {

            var divToExpand = controls[0];
            var controlToFocus = controls[1];
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#' + divToExpand).addClass('panel-collapse collapse in');
            $('#' + controlToFocus).focus();
        }
    }

    if (fromSummary = false) {
        var pageURL = window.location.search.substring(1);
    }

    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('W2Id') == 0) {
        w2Id = parameterName[1];
    }

    //DDL Method.
    GetState();
    GetEmployeeCode();
    GetW2OtherCode();

    //Saravanan N - 14th May, 2014 - Method code refactored from HTML.
    $('#btnBack').click(function () {
        PersistW2();

        //Saravanan N - 25th July, 2014 - Code changes done for the Defect # TAX1040-14285.
        if (document != null) {
            var previousPage = document.referrer;
            if (previousPage != '' || previousPage != null) {
                if (previousPage.lastIndexOf('w2employmentandownertype.html') > 0) {
                    window.location.href = '../Income/w2employmentandownertype.html?W2Id=' + w2Id;
                }
                else {
                    GoToPreviousPage();
                }
            }
        }

        //29May2014 Sathish previous page is hard coded while clicking back new record is added in 
        //                   Go to previous page previous page url is not having w2id
        //window.location.href = '../Income/w2employmentandownertype.html?W2Id=' + w2Id;
        
        return false;
    });

    //On-Page Logic EmployerAddess name change.
    $("#divEmployee").hide();
    $("#chkW2EmployerAddress").click(function () {
        //Yogalakshmi - 22nd July 2014 - Defect fix for TAX1040-14220 -To hide and show the div when checked and uncheckd
        //Yogalakshmi - 7th July 2014 - Defect fix for TAX1040-14115
        if ($('#chkW2EmployerAddress').prop('checked') == false) {
            resetEmployeeAddress();
            $("#divEmployee").hide();
        }
        
        else {
            $("#divEmployee").show();
        }
    });

    //OnPage Entry #10
    //Vincent-15 July 2014- Added a toggle for Foreign employment
    $("#divForeignEmploymentNo").hide();
    $("#radNo").click(function () {
        if ($('#radNo').is(':checked')) {
            $("#divForeignEmploymentNo").show();
        } 

    });

    $("#radYes").click(function () {
        if ($('#radYes').is(':checked')) {
            $("#divForeignEmploymentNo").hide();
        }

    });


    $('#btnContinue').click(function () {
        if (PersistW2()) {
            //Vincent- Hard Stopper
            //18Jun2014 Sathish page will be navigated to hot stop if it has navigation
            PageNavigation(isEligibilityCheckFailed, '../Income/w2summary.html', 'Wages');
        }
        return false;
    });

    $('#aBox14OtherInformation').click(function () {
        otherDeductionBenefitsRecordCount += 1;
        AddOtherDeductionBenefits(otherDeductionBenefitsRecordCount);
        return false;
    });

    $('#aStateWages').click(function () {
        stateWagesRecordCount += 1;
        AddStateWages(stateWagesRecordCount);
        return false;
    });

    $('#aLocalTaxInfo').click(function () {
        localTaxInfoRecordCount += 1;
        AddLocalTaxInfo(localTaxInfoRecordCount);
        return false;
    });

    $('.btnNextClass').click(function () {
        NextClick();
        return false;
    });


    GetW2Data();

    $('#btnSubmitOne').click(function () {
        if ($("#W2").valid()) {
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#aEmployerInfo').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aEmployeeAddress').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }
        return false;
    });

    $('#btnSubmitTwo').click(function () {
        if ($("#W2").valid()) {
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#aEmployeeAddress').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aWagesWithholding').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }
        return false;
    });

    $('#btnSubmitThree').click(function () {
        if ($("#W2").valid()) {
        $('#collapseFour').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseThree').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#aWagesWithholding').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aW2Benefits').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        RefundAmountCalculation();
        //Saravanan N - 7th Aug, 2014 - Added this to disable the breadcrum in Next button click if Eligibility error exists.
        getErrorCountAndDisableBreadcrum();
        }
        return false;
    });

    $('#btnSubmitFour').click(function () {
        if ($("#W2").valid()) {
        $('#collapseFive').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseFour').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#aW2Benefits').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aStateandLocalInfo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        RefundAmountCalculation();
        //Saravanan N - 7th Aug, 2014 - Added this to disable the breadcrum in Next button click if Eligibility error exists.
        getErrorCountAndDisableBreadcrum(); 
        }
        return false;
    });

});


$(function () {
    //Yogalakshmi - 5th August 2014 -  Changes done for Quick Help flickering Problem 
    //Quick Help for W2 Basic Details
    $("#popEmployerID").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is EIN (Employer Identification Number) and where to find it?</h5>EIN is a 9 digit number assigned to your Employer. <br /><br/>This can be seen in Line B of your Form W-2 as Employer Identification Number.<br /> <a href='target='_blank' class='more'>Read Common Question</a>" });

    $("#popEmployerName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's Name and where to find it?</h5>Name of the organization that you worked for is your Employer's Name. <br /><br/>Line C of your Form W-2 is where you can find this.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popEmployerAddress").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's Address and where to find it?</h5>This is your Employer' physical mailing address. <br /><br/>Line C of Form W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popEmployerCity").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's City and where to find it?</h5>Your Employer's City is a part of their physical mailing address. <br /><br/>Line C of Form W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popEmployerState").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's State and where to find it?</h5>Your Employer's State is a part of their physical mailing address. <br /><br/>Line C of Form W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popEmployerZipCode").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's Zip Code and where to find it?</h5>Your Employer's Zip Code is a part of their physical mailing address. <br /><br/>Line C of Form W-2 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popFederalWages").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is your Federal Wages?</h5>Federal Wages is your taxable wages, salaries, tips and other compensations. <br /><br/>Box 1 of Form W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popFederalTaxWithheld").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Federal Tax Withheld?</h5>This is the total amount of Federal Tax withheld from your wages. <br /><br/>Box 2 of Form W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSocialSecurityWages").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Social Security Wages?</h5>Box 3 reports the total amount of wages subject to the Social Security tax.<br/><br/> The base limit for 2014 Social security wages is $117,000. <br /><br/>Box 3 of Form W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSocialSecurityTaxWithheld").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Social Security Tax Withholding?</h5>This is the amount of Social Security Tax withheld (6.20% of Social Security Wages) from your wages. <br /><br/>Box 4 of Form W-2 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popMedicalWages").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Medicare Wages?</h5>The employee's earnings that are subject to a U.S. payroll tax known as the 'Medicare tax'. <br /><br/>The amount of Medicare tax calculated on Wages is Medicare wages and this amount is reported in Box 5 of Form W-2.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popMedicalTaxWithheld").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Medicare Tax Withholding?</h5>Medicare tax is used to fund the Government's Medicare program, which provides subsidized healthcare and hospital insurance benefits to retirees and the disabled. <br /><br/>Medicare tax percentage is 1.45%.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSocialSecurityTips").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Social Security Tips'?</h5>This is total amount of reported tips or commissions subject to Social Security Tax. <br /><br/>This amount is reported in Box 7 of Form W-2.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popAllocatedTips").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Allocated Tips?</h5>The amount tip income allocated to you when you are employed in any food and beverage establishments. <br /><br/>Box 8 of Form W-2 is where you can pick this from. <br /><br/>This amount is not included in the wages reported in Boxes 1, 3, 5, or 7. <br /><br/>Instead, you must add this to your taxable wages on Form 1040 Line 7, and calculate your Social Security and Medicare taxes on this tip income using Form 4137 (PDF).<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popDependentCareBenefits").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Dependent Care Benefit?</h5>This is the total amount of dependent care benefits that your employer paid to you or incurred on your behalf. <br /><br/>Box 10 of Form W-2 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popNonQualifiedPlan").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is your Non-Qualified Plan payment?</h5>This is the amount you are paid from your employer’s nonqualified deferred compensation or retirement plan.<br/><br/> Box 11 of Form W-2 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    //Yogalakshmi - 17th July 2014 - Updated Quick help content.
    // swapnesh not available
    $("#popProceedWithYourStateAndLocal").popover({ title: 'Quick Help', html: 'true', content: "<h5>Where to find State Identification Number?</h5>Your Employer's State Identification Number is available in Box-15a of your Form W-2.<br/><br/><h5>What is State Wages?</h5>This is your total wages for the year that is subject to the State Income Tax. <br /><br/>If you worked for the same employer in multiple state, there may be multiple lines of information. <br/><br />Box 16 of your W-2 Form is where you can pick this from.<br /><br/><h5>Where to find State Tax Withholding?</h5>The amount of State Income Taxes withheld from your Paychecks. <br/><br />Box 17 of your W-2 Form is where you can pick this from.<br /><br/><h5>What is Local Wages?</h5>This is nothing but your total amount of income that qualifies for local taxation. <br />Box 18 of your W-2 Form is where you can pick this from.<br /><br/><h5>What is Local Tax Withholding?</h5>This the amount of Local Tax (if applicable) that is withheld from your wages. <br /><br/>Box 19 of  your Form W-2 is where you can pick this from.<br /><br/><h5>What is Locality Name?</h5>It is the Locality in which your Local Tax Withheld is deducted or  locality that corresponds to the income and taxation reported in Boxes 18 and 19.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    
    //Added By Yogalakshmi on 13th May 2014
    
    //Quick Help for W2 benefits and other information 
    $("#popW212A").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br /><br/>You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#pop12AAmount").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br/><br />You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popW212B").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br /><br/>You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popW212BAmount").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br /><br/>You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popW212C").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br /><br/>You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#pop12CAmount").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br /><br/>You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popW212D").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Codes and Amounts in Box 12 and what needs to be done with them?</h5>This contains an amount and a letter code. This area is used to report a variety of benefits and Forms of compensation not captured in Boxes 1-11. <br /><br/>The codes in Box 12 of Form W-2 are essential data for tax filing. Some of these codes affect the current year return, while the others are meant for the sake of information. <br /><br/>You will have to select the codes that you see in the Box 12 of your W-2 from the drop down Box here. Also, fill in the amount corresponding to the codes selected in the amount box.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    
    //Quick help for Household Employee Wages 
    $("#popHouseholdEmployerName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Employer's Name'?</h5>Employer name is the name of the person/company who hires you as their Household Employee.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerAddress").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's Address?</h5>This is the physical mailing address of the Employer who hires you as their Household Employee.<hr /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerCity").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's City?</h5>Name of the city that appears in the mailing address of  your Employer is their City.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerState").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employer's State?</h5>Name of the State that appears in the mailing address of the Employer is their State.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerZip").popover({ title: 'Quick Help', html: 'true', content: "<h5>What's your Employer's Zip Code?</h5>This is the Zip Code that is found in the physical mailing address of your Employer.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployeeWages").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Household Employee Wages'?</h5>Wages paid to those who work in or around private residence are listed under Household Employee Wages. <br /><br/><b>Note:</b> The Household Employee wages you receive should be less than $1,800 and not reported on Form W-2.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    
    //Quick help for Taxable Scholarship Income
    $("#popInstitutionName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Institution Name'?</h5>This is the full name of the Institution that gives you scholarship income or fellowship grants.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionAddress").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is the Address of the Institution that gives you Scholarship Income?</h5>The physical mailing address of the Institution is its Address.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionCity").popover({ title: 'Quick Help', html: 'true', content: "<h5>In which city is the Institution that gives you Scholarship Income located?</h5>City that appears on the physical mailing address of the Institution is its City.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionState").popover({ title: 'Quick Help', html: 'true', content: "<h5>State</h5>Select the Name of the State of your Institution.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionZip").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is the Zip Code of the Institution that gives you Scholarship Income?</h5>This is the Zip Code seen on the physical mailing address of the Institution that gives scholarship or fellowship grants.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popTaxableScholarshipAmount").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Taxable Scholarship Amount?</h5>It's the amount of Scholarship that a student receives from an institution to help pursue studies.  <br /><br/>Line 1 of 1040EZ is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    //Quick Help for Employee 
    $("#popEmployeeAddress").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employee Address?</h5>Employee Address is nothing but your Street Address. <br /><br/>Box F of your W-2 is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployeeCity").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employee City?</h5>This is nothing but your City. <br /><br/>Box F of your W-2 is where you can pick this from.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployeeState").popover({ title: 'Quick Help', html: 'true', content: "<h5>Employee State</h5>Select the Employee State on your Form W-2.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployeeZipCode").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Employee Zip Code?</h5>This is nothing but your Zip Code. <br /><br/>Box F of your W-2 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
});

function socialsecurityTax() {
    if ($('#txtW2SSwithheld').val() < 7254) {
        $('#divW2SSwithheldErrorMsg').html('Box 4 Employee social security Tax should be 6.20% of Social security wages.');
    }
    else {
        $('#divW2SSwithheldErrorMsg').html('');
    }
}
function W2FederalWithheld() {  
    if ($('#txtW2FederalWages').val() == $('#txtW2FederalWithheld').val()) {
        $('#divW2FederalWithheldErrorMsg').html('Box2 Federal Tax Withheld should not be greater than Box1 Wages.');
    }
    else {
        $('#divW2FederalWithheldErrorMsg').html('');
    }
}

//Yogalakshmi - 7th July 2014 - Added a method to reset the values
function resetEmployeeAddress() {
    $('#txtW2EmployeeAddress').val('');
    $('#txtW2EmployeeCity').val('');
    $("#ddlW2EmployeeState").val(0);
    $('#txtW2EmployeeZip').val('');
    $("#W2").valid();
}

//Saravanan N - 14th May, 2014 - Code refactored.
function GetState() {
    $.ajax({
        url: serviceUrl + 'personalinfo/getstate',
        async: false,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            state = data;
            $("#ddlW2State").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlW2EmployeeState").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlW2Box15State0").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlW2AssociatedState0").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlHouseholdEmployerState").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlInstitutionState").append($("<option></option>").val(0).html('---Select---'));
            $.each(data, function (key, value) {
                $("#ddlW2State").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlW2EmployeeState").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlW2Box15State0").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlW2AssociatedState0").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlHouseholdEmployerState").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlInstitutionState").append($("<option></option>").val(value.StateId).html(value.StateCode));
            });
        }
    });
}

//Saravanan N - 14th May, 2014 - Code refactored.
function GetEmployeeCode() {
    $.ajax({
        url: serviceUrl + 'w2/getemployeecode',
        async: false,
        dataType: "json",
        type: "GET",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $.each(data, function (key, value) {
                $("#ddlW212A").append($("<option></option>").val(value.Value).html(value.Text));
                $("#ddlW212B").append($("<option></option>").val(value.Value).html(value.Text));
                $("#ddlW212C").append($("<option></option>").val(value.Value).html(value.Text));
                $("#ddlW212D").append($("<option></option>").val(value.Value).html(value.Text));
            });
        }
    });
}

//Saravanan N - 14th May, 2014 - Code refactored.
function GetW2OtherCode() {
    $.ajax({
        url: serviceUrl + 'w2/getw2othercode',
        async: false,
        dataType: "json",
        type: "GET",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            box14OtherCode = data;
            $.each(box14OtherCode, function (key, value) {
                $("#ddlW2OtherCode0").append($("<option></option>").val(value.Value).html(value.Text));
            });
        }
    });
}

//TODO: Has to see the possibility to move this method to common place, since it is used from W2employmentandownertype.js also. - Saravanan N - 14th May, 2014
function PersistW2() {
    if ($("#W2").valid()) {
    var householdEmployeeWages;
    var taxableScholarshipAmount;
    //Yogalakshmi - 20th June 2014 - Assigned a variable to check for foreign employment
    var hasForeignEmployment = false;
    var name;
    var ein;
    var streetAddress;
    var city;
    var zip;
    var stateId;
    var stateName;
    var otherDeductionBenefit;
    var otherDeductionBenefits = [];
    var stateLocalWage;
    var StateLocalWagesInfo = [];
    var localTax;
    var localTaxInfo = [];

    $.each($('#divBox14OtherInformation').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;
        otherDeductionBenefit = {
            W2OtherId: $("#ddlW2OtherCode" + rowIndex).val(),
            //Yogalakshmi - 24th June 2014 - Defect fix for TAX1040-14030 - Triming done for Description textbox.
            Description: $("#txtW2Description" + rowIndex).val().trim(),
            Amount: ($.isNumeric($("#txtW2Amount" + rowIndex).val().trim()) ? $("#txtW2Amount" + rowIndex).val().trim() : null),
        }
        otherDeductionBenefits.push(otherDeductionBenefit);
    });

    $.each($('#divLocalTaxInfo').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;
        localTax = {
            StateCode: $("#ddlW2AssociatedState" + rowIndex).val(),
            LocalWagesAmount: $("#txtW2LocalWages" + rowIndex).val().trim(),
            LocalTaxWithholdingAmount: ($.isNumeric($("#txtW2LocalWithHeld" + rowIndex).val().trim()) ? $("#txtW2LocalWithHeld" + rowIndex).val().trim() : null),
            LocalityName: $("#txtW2LocalityName" + rowIndex).val()
        }
        localTaxInfo.push(localTax);
    });

    $.each($('#divLocalStateWagesInfo').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;

        var stateLocalTax = [];
        if (localTaxInfo[rowIndex] != null)
            stateLocalTax.push(localTaxInfo[rowIndex]);

        stateLocalWage = {
            State: {
                StateCode: $("#txtW2StateID" + rowIndex).val(),
                StateId: $("#ddlW2Box15State" + rowIndex).val()
            },
            StateWagesAmount: $("#txtW2StateWages" + rowIndex).val().trim(),
            StateTaxWithholdingAmount: ($.isNumeric($("#txtW2StateWithheld" + rowIndex).val().trim()) ? $("#txtW2StateWithheld" + rowIndex).val().trim() : null),
            W2LocalTaxInfo: stateLocalTax,
        }
        StateLocalWagesInfo.push(stateLocalWage);
    });

    if (employmentType > 0 && employmentType != 6 && employmentType != 7 && employmentType != 8) {
        //Yogalakshmi - 16th July 2014 - Defect fix for TAX1040-14174 added trim to remove space
        name = $("#txtW2EmployerName").val().trim();
        ein = $("#txtW2EmployerID").val();
        streetAddress = $("#txtW2EmployerAddress").val().trim();
        city = $("#txtW2EmployerCity").val().trim();
        zip = $("#txtW2EmployerZip").val();
        stateId = $("#ddlW2State").val();
        stateName = $("#ddlW2State option:selected").text();
    } else if (employmentType == 6) {

        householdEmployeeWages = ($.isNumeric($("#txtHouseholdEmployeeWages").val().trim()) ? $("#txtHouseholdEmployeeWages").val().trim() : null),
        //Yogalakshmi - 16th July 2014 - Defect fix for TAX1040-14174 added trim to remove space
        name = $("#txtHouseholdEmployerName").val().trim(),
        streetAddress = $("#txtHouseholdEmployerAddress").val().trim(),
        city = $("#txtHouseholdEmployerCity").val().trim(),
        zip = $("#txtHouseholdEmployerZip").val(),
        stateId = $("#ddlHouseholdEmployerState").val();
        stateName = $("#ddlHouseholdEmployerState option:selected").text();
    } else if (employmentType == 7) {

        taxableScholarshipAmount = ($.isNumeric($("#txtTaxableScholarshipAmount").val().trim()) ? $("#txtTaxableScholarshipAmount").val().trim() : null),
        //Yogalakshmi - 16th July 2014 - Defect fix for TAX1040-14174 added trim to remove space
        name = $("#txtInstitutionName").val().trim(),
        streetAddress = $("#txtInstitutionAddress").val().trim(),
        city = $("#txtInstitutionCity").val().trim(),
        zip = $("#txtInstitutionZip").val(),
        stateId = $("#ddlInstitutionState").val();
        stateName = $("#ddlInstitutionState option:selected").text();
    }
        //Yogalakshmi - 20th June 2014 - Get the radio button value
    else if (employmentType == FOREIGN_EMPLOYMENT) {
        hasForeignEmployment = ($('#radYes').prop('checked') == false && $('#radNo').prop('checked') == false) ? null : $('#radYes').prop('checked');

    }

    var w2Data = {
        W2Id: w2Id,
        EmploymentType: employmentType,
        OwnerType: ownerType,
        WagesAmount: ($.isNumeric($("#txtW2FederalWages").val().trim()) ? $("#txtW2FederalWages").val().trim() : null),
        FederalTaxWithholdingAmount: ($.isNumeric($("#txtW2FederalWithheld").val().trim()) ? $("#txtW2FederalWithheld").val().trim() : null),
        SocialSecurityWagesAmount: ($.isNumeric($("#txtW2SSWages").val().trim()) ? $("#txtW2SSWages").val().trim() : null),
        SocialSecurityTaxWithholdingAmount: ($.isNumeric($("#txtW2SSwithheld").val().trim()) ? $("#txtW2SSwithheld").val().trim() : null),
        MedicareWagesAmount: ($.isNumeric($("#txtW2MedicalWages").val().trim()) ? $("#txtW2MedicalWages").val().trim() : null),
        MedicareTaxWithholdingAmount: ($.isNumeric($("#txtW2MedicalWithheld").val().trim()) ? $("#txtW2MedicalWithheld").val().trim() : null),
        SocialSecurityTipsAmount: ($.isNumeric($("#txtW2SSTips").val().trim()) ? $("#txtW2SSTips").val().trim() : null),
        AllocatedTipsAmount: ($.isNumeric($("#txtW2AllocatedTips").val().trim()) ? $("#txtW2AllocatedTips").val().trim() : null),
        DependentCareBenefitsAmount: ($.isNumeric($("#txtW2DependentCare").val().trim()) ? $("#txtW2DependentCare").val().trim() : null),
        //NotInUseAmount: $("#txtW2NotInUse").val(),
        IsStatutoryEmployee: $('#rdW2Statutory').prop('checked'),
        HasRetirementPlan: $('#rdW2RetirementPlan').prop('checked'),
        HasThirdPartySickPay: $('#rdW2ThridPartySick').prop('checked'),
        NonQualifiedPlansAmount: GetZeroOnIsNullOrEmpty($.isNumeric($("#txtQualifiedPlan").val().trim()) ? $("#txtQualifiedPlan").val().trim() : null),
        HasEmployeeAddress: $("#chkW2EmployerAddress").prop("checked"),
        EmployeeAddress: {
            //Yogalakshmi - 16th July 2014 - Defect fix for TAX1040-14174 added trim to remove space
            StreetAddress: $("#txtW2EmployeeAddress").val().trim(),
            City: $("#txtW2EmployeeCity").val().trim(),
            State:
                {
                    StateId: $("#ddlW2EmployeeState").val(),
                    StateCode: $("#ddlW2EmployeeState option:selected").text()
                },
            ZipCode: $("#txtW2EmployeeZip").val()
        },
        IsCorrectedW2: $("#chkW2correct").prop("checked"),
        IsNonStandardW2: $("#chkW2NonStandard").prop("checked"),
        //Yogalakshmi - 20th June 2014 - Inserting Foreign Employment
        HasForeignEmployment: hasForeignEmployment,
        //Vincent-24 June 2014- Remove the Getting Zero value
        W2EmployerCodes: [
            {
                EmployerCode: $("#ddlW212A").val(),
                Amount: ($.isNumeric($("#txt12AAmount").val().trim()) ? $("#txt12AAmount").val().trim() : null)
            },
            {
                EmployerCode: $("#ddlW212B").val(),
                Amount: ($.isNumeric($("#txt12BAmount").val().trim()) ? $("#txt12BAmount").val().trim() : null)
            },
            {
                EmployerCode: $("#ddlW212C").val(),
                Amount: ($.isNumeric($("#txt12CAmount").val().trim()) ? $("#txt12CAmount").val().trim() : null)
            },
            {
                EmployerCode: $("#ddlW212D").val(),
                Amount: ($.isNumeric($("#txt12DAmount").val().trim()) ? $("#txt12DAmount").val().trim() : null)
            }
        ],

        OtherDeductsBenefits: otherDeductionBenefits,

        W2StateLocalTaxInfo: StateLocalWagesInfo,



        Employer: {
            TaxableScholarshipAmount: taxableScholarshipAmount,
            HouseholdEmployeeWages: householdEmployeeWages,
            Organization: {
                Name: name,
                EIN: ein,
                Address: {
                    CompanyAddress: {
                        StreetAddress: streetAddress,
                        City: city,
                        Zip: zip,
                        State: {
                            StateId: stateId,
                                StateName: stateName
                        }
                    }
                }
            }
        }
    };

    var isW2Persist = false;
    $.ajax({
        url: serviceUrl + 'w2/persistw2data',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
               {
                   UserDataId: userDataId,
                   TaxData: JSON.stringify(w2Data),
               }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            isW2Persist = true;
            //Hard Stopper
            isEligibilityCheckFailed = data.isEligibilityCheckFailed;
        }
    });
    return isW2Persist;

    } else {
        return false;
    }
}

function GetZeroOnIsNullOrEmpty(value) {
    if (value == "" || value == null)
        return 0;
    else {
        return value;
    }
}

function GetW2Data() {
    $.ajax({
        url: serviceUrl + 'w2/getw2data',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId,
            "FormId": w2Id,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data != null) {

                if (data.m_Item1.W2Id != 0) {
                    w2Id = data.m_Item1.W2Id;
                }
                if (data.m_Item1.EmploymentType != 0) {

                    employmentType = data.m_Item1.EmploymentType;
                }
                if (data.m_Item1.OwnerType != 0) {

                    ownerType = data.m_Item1.OwnerType;
                }

                if (data.m_Item1.EmploymentType > 0 && data.m_Item1.EmploymentType != 6 && data.m_Item1.EmploymentType != 7) {

                    if (data.m_Item1.Employer != null && data.m_Item1.Employer.Organization != null) {
                        $("#txtW2EmployerID").val(data.m_Item1.Employer.Organization.EIN);
                        $("#txtW2EmployerName").val(data.m_Item1.Employer.Organization.Name);
                        $("#txtW2EmployerAddress").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StreetAddress);
                        $("#txtW2EmployerCity").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.City);
                        $("#txtW2EmployerZip").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.Zip);
                        if (data.m_Item1.Employer.Organization.Address.CompanyAddress.State != null)
                            $("#ddlW2State").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.State.StateId);
                    }

                    if (data.m_Item1.W2EmployerCodes != null) {
                        $.each(data.m_Item1.W2EmployerCodes, function (index, value) {
                            //Defect 14193 - 16th July, 2014 - 0 value removed. Code changes done by Praveen
                            if (value != null) {
                                if (index == 0) {
                                    $("#ddlW212A").val(value.EmployerCode);
                                    //TODO:Vincent-NUll check should be done.
                                    $("#txt12AAmount").val(value.Amount);
                                }
                                if (index == 1) {
                                    $("#ddlW212B").val(value.EmployerCode);
                                    //TODO:Vincent-NUll check should be done.
                                    $("#txt12BAmount").val(value.Amount);
                                }
                                if (index == 2) {
                                    $("#ddlW212C").val(value.EmployerCode);
                                    //TODO:Vincent-NUll check should be done.
                                    $("#txt12CAmount").val(value.Amount);
                                }
                                if (index == 3) {
                                    $("#ddlW212D").val(value.EmployerCode);
                                    //TODO:Vincent-NUll check should be done.
                                    $("#txt12DAmount").val(value.Amount);
                                }
                            }
                        });
                    }

                    if (data.m_Item1.OtherDeductsBenefits != null) {
                        $.each(data.m_Item1.OtherDeductsBenefits, function (index, value) {
                            otherDeductionBenefitsRecordCount = index;
                            if (index != 0) {
                                AddOtherDeductionBenefits(otherDeductionBenefitsRecordCount);
                            }
                            $("#hW2OtherInfoIndex" + otherDeductionBenefitsRecordCount).val(otherDeductionBenefitsRecordCount);
                            $("#ddlW2OtherCode" + otherDeductionBenefitsRecordCount).val(value.W2OtherId);
                            $("#txtW2Description" + otherDeductionBenefitsRecordCount).val(value.Description);
                            $("#txtW2Amount" + otherDeductionBenefitsRecordCount).val(value.Amount);
                        });
                    }


                    if (data.m_Item1.W2StateLocalTaxInfo != null) {
                        $.each(data.m_Item1.W2StateLocalTaxInfo, function (index, value) {
                            stateWagesRecordCount = index;
                            if (index != 0) {
                                AddStateWages(stateWagesRecordCount);
                            }

                            if (data.m_Item1.W2StateLocalTaxInfo[stateWagesRecordCount].W2LocalTaxInfo != null) {
                                $.each(data.m_Item1.W2StateLocalTaxInfo[stateWagesRecordCount].W2LocalTaxInfo, function (index, value) {
                                    localTaxInfoRecordCount = stateWagesRecordCount;
                                    $("#hLocalTaxInfoIndex" + localTaxInfoRecordCount).val(localTaxInfoRecordCount);
                                    $("#ddlW2AssociatedState" + localTaxInfoRecordCount).val(value.StateCode);
                                    $("#txtW2LocalWages" + localTaxInfoRecordCount).val(value.LocalWagesAmount);
                                    $("#txtW2LocalWithHeld" + localTaxInfoRecordCount).val(value.LocalTaxWithholdingAmount);
                                    $("#txtW2LocalityName" + localTaxInfoRecordCount).val(value.LocalityName);
                                });
                            }

                            $("#hLocalStateWagesIndex" + stateWagesRecordCount).val(stateWagesRecordCount);
                            if (value.State != null) {
                                $("#ddlW2Box15State" + stateWagesRecordCount).val(value.State.StateId);
                                $("#txtW2StateID" + stateWagesRecordCount).val(value.State.StateCode);
                            }
                            $("#txtW2StateWages" + stateWagesRecordCount).val(value.StateWagesAmount);
                            $("#txtW2StateWithheld" + stateWagesRecordCount).val(value.StateTaxWithholdingAmount);
                        });
                    }

                    $("#txtW2FederalWages").val(data.m_Item1.WagesAmount),
                    $("#txtW2FederalWithheld").val(data.m_Item1.FederalTaxWithholdingAmount),
                    $("#txtW2SSWages").val(data.m_Item1.SocialSecurityWagesAmount),
                    $("#txtW2SSwithheld").val(data.m_Item1.SocialSecurityTaxWithholdingAmount);
                    $("#txtW2MedicalWages").val(data.m_Item1.MedicareWagesAmount);
                    $("#txtW2MedicalWithheld").val(data.m_Item1.MedicareTaxWithholdingAmount),
                    $("#txtW2SSTips").val(data.m_Item1.SocialSecurityTipsAmount),
                    $("#txtW2AllocatedTips").val(data.m_Item1.AllocatedTipsAmount),
                    $("#txtW2DependentCare").val(data.m_Item1.DependentCareBenefitsAmount),
                    //$("#txtW2NotInUse").val(data.m_Item1.NotInUseAmount),
                    $("#rdW2Statutory").attr('checked', (data.m_Item1.IsStatutoryEmployee)),
                    $("#rdW2RetirementPlan").attr('checked', data.m_Item1.HasRetirementPlan),
                    $("#rdW2ThridPartySick").attr('checked', data.m_Item1.HasThirdPartySickPay),
                    //TODO:Vincent-After getting the value it return Zero value ,nullable should be done for NON Qualifield Plans amount. 
                    $("#txtQualifiedPlan").val(data.m_Item1.NonQualifiedPlansAmount == 0 ? "" : data.m_Item1.NonQualifiedPlansAmount),
                    $("#chkW2EmployerAddress").prop("checked", data.m_Item1.HasEmployeeAddress);

                    if ($("#chkW2EmployerAddress").prop("checked") == true) {
                        $("#divEmployee").show();
                    } else {


                        $("#divEmployee").hide();
                    }

                    if (data.m_Item1.HasEmployeeAddress != null) {
                        $("#txtW2EmployeeAddress").val(data.m_Item1.EmployeeAddress.StreetAddress);
                        $("#txtW2EmployeeCity").val(data.m_Item1.EmployeeAddress.City);
                        if (data.m_Item1.EmployeeAddress.State != null)
                            $("#ddlW2EmployeeState").val(data.m_Item1.EmployeeAddress.State.StateId);
                        $("#txtW2EmployeeZip").val(data.m_Item1.EmployeeAddress.ZipCode);
                    }
                    $("#chkW2correct").prop("checked", data.m_Item1.IsCorrectedW2),
                    $("#chkW2NonStandard").prop("checked", data.m_Item1.IsNonStandardW2);
                } else if (data.m_Item1.EmploymentType == 6) {
                    if (data.m_Item1.Employer != null && data.m_Item1.Employer.Organization != null) {
                        $("#txtHouseholdEmployerName").val(data.m_Item1.Employer.Organization.Name);
                        $("#txtHouseholdEmployerAddress").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StreetAddress);
                        $("#txtHouseholdEmployerCity").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.City);
                        $("#txtHouseholdEmployerZip").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.Zip);
                        $("#txtHouseholdEmployeeWages").val(data.m_Item1.Employer.HouseholdEmployeeWages);
                        if (data.m_Item1.Employer.Organization.Address.CompanyAddress.State != null)
                            $("#ddlHouseholdEmployerState").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.State.StateId);
                    }
                } else if (data.m_Item1.EmploymentType == 7) {
                    if (data.m_Item1.Employer != null && data.m_Item1.Employer.Organization != null) {
                        $("#txtInstitutionName").val(data.m_Item1.Employer.Organization.Name);
                        $("#txtInstitutionAddress").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StreetAddress);
                        $("#txtInstitutionCity").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.City);
                        $("#txtInstitutionZip").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.Zip);
                        $("#txtTaxableScholarshipAmount").val(data.m_Item1.Employer.TaxableScholarshipAmount);
                        if (data.m_Item1.Employer.Organization.Address.CompanyAddress.State != null)
                            $("#ddlInstitutionState").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.State.StateId);
                    }
                }
                //Yogalakshmi - 20th June 2014 - Binding Foreign Employment
                if (data.m_Item1.EmploymentType == FOREIGN_EMPLOYMENT) {
                    if (data.m_Item1.HasForeignEmployment) {
                        $("#radYes").attr("checked", true);
                    }
                    else if (data.m_Item1.HasForeignEmployment == false) //Yogalakshmi - 12th August 2014 - FALSE condition checked for the Defect TAX1040-14457.
                    {
                        $("#radNo").attr("checked", true);
                    }
                }
                //vivek - 6-Aug-14 - Added the focus for the error message control focus 
                if (data.m_Item2.errorlist != null) {
                    if (parameters != undefined && parameters.length == 2 || parameters.length == 3) {
                        $.each(data.m_Item2.errorlist, function (index, value) {

                            var rfparameterName = value.FieldName.split('-');
                            if (rfparameterName.length == 2) {
                                var controlToFocus = rfparameterName[1];
                                $('#' + controlToFocus).removeClass("form-control tip").addClass("tip error");
                                //06Aug2014 Sathish add onblur event to the control to remove error class
                                RemoveControlHighlighting(controlToFocus);
                            }
                        });
                    }
                }

            }

            //Praveen - 17th July, 2014 - Defect 14194 - Control not getting focus in IE. Issue resolved.
            if (controls != undefined && controls.length == 2) {
                var controlToFocus = controls[1];
                $('#' + controlToFocus).focus();
            }
        }
    });

    if (employmentType == 6 || employmentType == 7 || employmentType == 8) {
        $('.W2Employment').hide();
        if (employmentType == 6) {
            $('#divInstution').hide();
            $('#divForeignEmployment').hide();
        } else if (employmentType == 7) {
            $('#divHouseHold').hide();
            $('#divForeignEmployment').hide();
        }
        else if 
            (employmentType == 8) {
            $('#divHouseHold').hide();
            $('#divInstution').hide();
        }
    } else {
        $('#divHouseHold').hide();
        $('#divInstution').hide();
        $('#divForeignEmployment').hide();

    }
}

//14July2014 Script Changed By Thileep To limit the Rows Upto 15Rows only as per Income Spec V2.3  - Suggestion Defect # 14085
//Yogalakshmi - 7th Aug 2014 - Defect 14394 - Added tabindex
function AddOtherDeductionBenefits(rowIndex) {
    if (rowIndex <= 14) {
        var newBox14OtherDeductionBenefits = ' <div id="divBox14OtherInformation' + rowIndex + '">' + '<div class="pangird itm">' +
            ' <input type="hidden" id="hW2OtherInfoIndex' + rowIndex + '" value="' + rowIndex + '" />' +
            '<label class="col-md-4">' +
            '   <input type="text" id="txtW2Description' + rowIndex + '" class="form-control" tabindex="41" />' +
            '</label>' +
            '<label class="col-md-4">' +
            '   <input type="text" id="txtW2Amount' + rowIndex + '" class="form-control" maxlength="12" onblur="extractNumberBlur(this,event,2,false,true);" onkeyup="extractNumber(this,event,2,false,false);" tabindex="41"/>' +
            '</label>' +
            '<label class="col-md-4">' +
            '   <select name="ddlW2OtherCode"  ID="ddlW2OtherCode' + rowIndex + '" tabindex="41" >' +
            '        </select>' +
            '   </label>' + ' </div>' +
            ' </div>';


        $('#divBox14OtherInformation').append(newBox14OtherDeductionBenefits);


        NumbersOnly('txtW2Amount' + rowIndex);
        //Yogalakshmi - 3rd July 2014 - Added to allow only numbers, letters and hyphen.
        NumbersLettersAndHyphen('txtW2Description' + rowIndex);

        $.each(box14OtherCode, function (key, value) {
            $('#ddlW2OtherCode' + rowIndex).append($("<option></option>").val(value.Value).html(value.Text));
        });
    }
}

//14July2014 Script Changed By Thileep To limit the Rows Upto 15Rows only as per Income Spec V2.3  - Suggestion Defect # 14085
//Saravanan N - 1st August, 2014 -  Defect # 14291, tabIndex added for dynamic controls.
function AddStateWages(rowIndex) {
    //StateWages
    if (rowIndex <= 14) {   
        var newStateWages = '  <div id="divLocalStateWagesInfo"> ' +
               ' <div id="divLocalStateWagesInfo' + rowIndex + '"> ' + '<div class="pangird itm">' +
               '     <input type="hidden" id="hLocalStateWagesIndex' + rowIndex + '" value="' + rowIndex + '" /> ' +
               '   <label class="col-md-3" id="lblEmployerName"> ' +
               '     <select tabIndex="47" id="ddlW2Box15State' + rowIndex + '" name="ddlBox15State"> ' +
               '   </select> ' +
               ' </label> ' +
               ' <label class="col-md-3"> ' +
               '   <input type="text" tabIndex="47" id="txtW2StateID' + rowIndex + '" class="form-control" maxlength="9" onkeyup="extractNumber(this,event,0,false,false);"/> ' +
               ' </label> ' +
               ' <label class="col-md-3"> ' +
               ' <input type="text" tabIndex="47" id="txtW2StateWages' + rowIndex + '" maxlength="12" class="form-control" onblur="extractNumberBlur(this,event,2,false,true);"  onkeyup="extractNumber(this,event,2,false,false);"/> ' +
               ' </label> ' +
               ' <label class="col-md-3"> ' +
               '             <input type="text" tabIndex="47" id="txtW2StateWithheld' + rowIndex + '" maxlength="12" class="form-control" onblur="extractNumberBlur(this,event,2,false,true);" onkeyup="extractNumber(this,event,2,false,false);"/> ' +
               '       </label> ' +
               ' </div> ' + ' </div> ' +
               ' </div> ';


        $('#divLocalStateWagesInfo').append(newStateWages);
        $('#ddlW2Box15State' + rowIndex).append($("<option></option>").val(0).html('---Select---'));
        $.each(state, function (key, value) {
            $('#ddlW2Box15State' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateCode));
        });

        //$("#txtW2StateWages" + rowIndex).bind("keyup paste", function () {
        //    setTimeout(jQuery.proxy(function () {
        //        this.val(this.val().replace(/[^0-9.]/g, ''));
        //    }, $(this)), 0);
        //});

        NumbersOnly('txtW2StateID' + rowIndex);
        NumbersOnly('txtW2StateWages' + rowIndex);
        NumbersOnly('txtW2StateWithheld' + rowIndex);

        //$("#txtW2StateWithheld" + rowIndex).bind("keyup paste", function () {
        //    setTimeout(jQuery.proxy(function () {
        //        this.val(this.val().replace(/[^0-9.]/g, ''));
        //    }, $(this)), 0);
        //});

        //LocalTaxInfo
        var newLocalTaxInfo = ' <div id="divLocalTaxInfo' + rowIndex + '"> ' + '<div class="pangird itm">' +
          ' <label class="col-md-3"> ' +
          '   <input type="hidden" id="hLocalTaxInfoIndex' + rowIndex + '" value="' + rowIndex + '" /> ' +
          ' <input type="text" tabIndex="51" id="txtW2LocalWages' + rowIndex + '" class="form-control" maxlength="12" onblur="extractNumberBlur(this,event,2,false,true);" onkeyup="extractNumber(this,event,2,false,false);"/> ' +
          ' </label> ' +
          ' <label class="col-md-3"> ' +
          '   <input type="text" tabIndex="51" id="txtW2LocalWithHeld' + rowIndex + '" class="form-control" maxlength="12" onblur="extractNumberBlur(this,event,2,false,true);" onkeyup="extractNumber(this,event,2,false,false);"/> ' +
          ' </label> ' +
          ' <label class="col-md-3"> ' +
          '  <input type="text" tabIndex="51" id="txtW2LocalityName' + rowIndex + '" class="form-control" /> ' +
          ' </label> ' +
          ' <label class="col-md-3"> ' +
          ' <select name="ddlW2AssociatedState" tabIndex="51" id="ddlW2AssociatedState' + rowIndex + '"> ' +
          ' </select> ' +
          ' </label> ' + '</div> ' +
          ' </div> ';

        $('#divLocalTaxInfo').append(newLocalTaxInfo);
        $('#ddlW2AssociatedState' + rowIndex).append($("<option></option>").val(0).html('---Select---'));
        $.each(state, function (key, value) {
            $('#ddlW2AssociatedState' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateCode));
        });
        //Yogalakshmi - 3rd July 2014 - Defect fix for TAX1040-14098 where it should accept only numbers, alphabets, hyphen and space
        NumbersLettersAndHyphen('txtW2LocalityName' + rowIndex);

        //Saravanan N - 7th July, 2014 - Changes done for Defect 14098. - rowIndex added for dynamic controls.
        NumbersOnly('txtW2LocalWages' + rowIndex);
        NumbersOnly('txtW2LocalWithHeld' + rowIndex);

        //$("#txtW2LocalWithHeld" + rowIndex).bind("keyup paste", function () {
        //    setTimeout(jQuery.proxy(function () {
        //        this.val(this.val().replace(/[^0-9.]/g, ''));
        //    }, $(this)), 0);
        //});
    }
}


function RemoveDiv(divId) {
    $('#' + divId.id).remove();
    return false;
}

function NextClick() {
    PersistW2();
    return false;
}

//Defect 14186 - 16th July, 2014 - Resolved accordion open issue in chrome.
function keypress(e) {
    if (e.keyCode == 13) {
        var tb = document.getElementsByTagName("input");
        eval(tb.value);
        return false;
    }
}