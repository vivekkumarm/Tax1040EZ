//10 Apr 14 Vincent Added a new Script file for 1099OID
//Vincent - 16th April 2014- added a error message navigation for required user control.
// Sathish 03May2014 User Tax Return Data bo for presist
//Vincent-26May2014-Refatored the code for Get and Persist method
//Vincent-29May2014-Made a cahnges in get data method
// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var F1099OIDPersistData, f1099OID;
var form1099OIDId;
var isEligibilityCheckFailed = false;
var parameters;
var stateTaxExempt = 0;
var state;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    //Getting Session Data.
    if (!window.sessionStorage.Form1099OIDId) {
        form1099OIDId = 0;
    } else {
        form1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
    }

    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    parameters = pageURL.split('&');

    //Click on OID Error Message in InterestIncome Summary Diagnostic page, the below code will be executed.
    var controlParmeters;
    if (parameters.length == 3) {
        controlParmeters = parameters[0];
        var FormType = parameters[2];

        //Form Type OID
        if (FormType.toString() == 'FormOID') {
            form1099OIDId = parameters[1];
        }
    }

    //Yogalakshmi - 16.07.2014 - Defect fix for TAX1040-14191 - Reset other info
    //Yogalakshmi - 27th August 2014 - Added for loop as it is a list.
    function resetOtherInfoOID() {
        for (var loopIndex = 0; loopIndex < 10; loopIndex++) {
            
            if (('#txtTaxExempt') != 'undefined') {
                $('#txtTaxExempt').val('');
            }
            if (("#ddlStateExemptCode" + loopIndex) != 'undefined') {
                $("#ddlStateExemptCode" + loopIndex).val(0);
            }
            if (('#txtExempt' + loopIndex) != 'undefined') {
                $('#txtExempt' + loopIndex).val('');
            }
            //$("#frm1099OID" + i).valid();
        }
    }
    //Yogalakshmi - 16.07.2014 - Defect fix for TAX1040-14191 - Reset OID Adjustment
    function resetOIDAdjustment() {
        $('#txtajusment').val('');
        $("#frm1099OID").valid();
    }

    //Show Exempt Amount div.
    $("#dvTaxExemptShow").hide();

    $("#chkTaxExempt").click(function () {
        if ($('#chkTaxExempt').is(':checked')) {
            $('#dvTaxExemptShow').show();

        }
        else {
            //Yogalakshmi - 16.07.2014 - Defect fix for TAX1040-14191 - Reset other info
            resetOtherInfoOID();
            $('#dvTaxExemptShow').hide();
        }

    });

    //Show Adjusted Amount div.
    $("#dvAdjustedAmount").hide();

    $("#chkadjustment").click(function () {
        if ($('#chkadjustment').is(':checked')) {
            $('#dvAdjustedAmount').show();
        }
        else {
            //Yogalakshmi - 16.07.2014 - Defect fix for TAX1040-14191 - Reset OID Adjustment
            resetOIDAdjustment();
            $('#dvAdjustedAmount').hide();
        }
    });

    //Saravanan N - 27th May, 2014 - Moved code to separate functions.
    populateState();
    populateCountry();
    bindEvents();
    F1099OIDGetData();
    setPopup();

    var divToExpand;
    var controlToFocus;
    if (controlParmeters != null && controlParmeters.trim().length > 0) {
        var controls = controlParmeters.split('-');
        if (controls.length == 2) {
            var divToExpand = controls[0];
            var controlToFocus = controls[1];
        }
    }

    //Vincent-1/7/2014- Added next button functionality
    $('#btnSubmitOne').click(function () {
        PersistF1099OID();
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#lnkOIDInterestIncome').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#lnkOIDStateInformation').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        //Saravanan N - 7th Aug, 2014 - Added this to disable the breadcrum in Next button click if Eligibility error exists.
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    //Saravanan N - 18th Aug, 2014 - While collapse the accordion do Persist.
    //Yogalakshmi - 20th August 2014 - Added getErrorCountAndDisableBreadcrum() to disable the breadcrum when there is an eligibility error.
    $('#collapseOne').on('hidden.bs.collapse', function () {
        PersistF1099OID();
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    //Saravanan N - 18th Aug, 2014 - While collapse the accordion do Persist.
    $('#collapseTwo').on('hidden.bs.collapse', function () {
        PersistF1099OID();
        return false;
    });

    //Yogalakshmi - 25th August 2014 - Implemented Add State in State Tax Exempt
    $('#aStateTaxExempt').click(function () {
        stateTaxExempt += 1;
        AddStateTaxExempt(stateTaxExempt);
        return false;
    });

    //Saravanan N - 1st Sep, 2014 - For each text box in FIRST accordion onblur event added to check whether error icon need to display in this accordion.
    $('#collapseOne input:text, select').each(function () {
        $(this).addClass('validateControl1');

        //if ($(this).hasClass('error')) {
        //    //Add class only if it is having 'error' class (i.e., having red border)            
        //    $(this).addClass('validateControl1');
        //}
        //else {
        //    $(this).removeClass('validateControl1');
        //}
    })

    $('.validateControl1').blur(function () {
        ValidateOIDFirstAccordion();
    });

    //Saravanan N - 1st Sep, 2014 - For each text box in SECOND accordion onblur event added to check whether error icon need to display in this accordion.
    $('#collapseTwo input:text, select').each(function () {
        $(this).addClass('validateControl2');

        //if ($(this).hasClass('error')) {
        //    //Add class only if it is having 'error' class (i.e., having red border)            
        //    $(this).addClass('validateControl2');
        //}
        //else {
        //    $(this).removeClass('validateControl2');
        //}
    })

    $('.validateControl2').blur(function () {
        ValidateOIDSecondAccordion();
    });

    ValidateOIDFirstAccordion();
    ValidateOIDSecondAccordion();

    if (divToExpand != null && controlToFocus != null) {
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
});

//------------------------------------------------------------- FIRST ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateOIDFirstAccordion() {
    var isServerSideValidationFailed = GetFirstAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#lnkOIDInterestIncome').addClass('error');
    }
    else {
        $('#lnkOIDInterestIncome').removeClass('error');
    }
}

function GetFirstAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseOne input:text').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

//------------------------------------------------------------- SECOND ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateOIDSecondAccordion() {
    var isServerSideValidationFailed = GetSecondAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#lnkOIDStateInformation').addClass('error');
    }
    else {
        $('#lnkOIDStateInformation').removeClass('error');
    }
}

function GetSecondAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseTwo input:text, select').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

/*************************************** COMMON FUNCTIONS SECTION *********************************/

//Saravanan N - 27th May, 2014 - Refactored method.
function populateState() {
    //Getiing state details
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
            $("#ddlStateCodeID").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlStateCode2").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlStateExemptCode0").append($("<option></option>").val(0).html("---Select---"));

            $.each(data, function (key, value) {
                $("#ddlStateCodeID").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateCode2").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateExemptCode0").append($("<option></option>").val(value.StateId).html(value.StateCode));

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function populateCountry() {
    //Getting country details
    $.ajax({
        url: serviceUrl + 'personalinfo/getcountry',
        async: false,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlForeginCountryID").append($("<option></option>").val(0).html("---Select---"));

            $.each(data, function (key, value) {
                $("#ddlForeginCountryID").append($("<option></option>").val(value.CountryId).html(value.CountryName));

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function bindEvents() {
    //TAX1040-13966 - Saravanan N - 9th June, 2014.
    $('#txtForeignTaxPaid').blur(function (e) {
        if ($("#txtForeignTaxPaid").val().trim().length == 0) {
            if ($("#ddlForeginCountryID").prop('disabled') == false) {
                $("#ddlForeginCountryID").val(0);
                $("#ddlForeginCountryID").attr('disabled', true);
                $('#txtForeignTaxPaid').focus();
            }
        }
        else {
            if ($("#ddlForeginCountryID").prop('disabled') == true) {
                $("#ddlForeginCountryID").attr('disabled', false);
                $("#ddlForeginCountryID").focus();
            }
        }

        e.preventDefault();
        return false;
    });

    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

    $('#btnContinue').click(function () {
        ContinueAndPersistF1099OID();
        //Saravanan N - 7th May, 2014 - Eligibility check occurred.
        PageNavigation(isEligibilityCheckFailed, '../Income/interestincomesummary.html', 'InterestIncome');
        return false;
    });

    ////Thileep Added Filtering funtion 27.05.14
    //$("#txtOriginalIssueDiscount").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtOriginalIssueDiscount');

    //$("#txtOtherPeriodicInterest").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtOtherPeriodicInterest');

    //$("#txtEarlyWithdrawalPenalty").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtEarlyWithdrawalPenalty');

    //$("#txtFederalTaxWithHoldingAmount").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtFederalTaxWithHoldingAmount');

    //$("#txtForeignTaxPaid").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtForeignTaxPaid');

    //$("#txtUSTreasuryObligations").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtUSTreasuryObligations');

    //$("#txtInvestmentExpenses").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtInvestmentExpenses');

    //Yogalalkshmi - 4th July 2014 - Added for back arrow and cursor jumb  problems
    NumbersOnly('txtAccNo');
    //$("#txtAccNo").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9]/g, ''));
    //    }, $(this)), 0);
    //});

    // NumbersOnly('txtTaxPayerNetBenefitSSB');

    //$("#txtStateTaxWithholdingAmount").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
    NumbersOnly('txtStateTaxWithholdingAmount0');

    //Yogalalkshmi - 4th July 2014 - Added for back arrow and cursor jumb  problems
    NumbersOnly('txtStateIdentificationNumber');
    //$("#txtStateIdentificationNumber").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});

    //Yogalalkshmi - 4th July 2014 - Added for back arrow and cursor jumb  problems
    NumbersOnly('txtPayerStateID');
    //$("#txtPayerStateID").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});

    //$("#txtPayerStateWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
    NumbersOnly('txtStateTaxWithholdingAmount1');

    //$("#txtTaxExempt").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtTaxExempt');

    //$("#txtStateExempt0").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtStateExempt0');

    //$("#txtajusment").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtajusment');
}

//Saravanan N - 27th May, 2014 - Refactored method.
//Yogalakshmi - 16th July 2014 - Updated Quick help content.
//Yogalakshmi - 5th August 2014 -  Changes done for Quick Help flickering Problem 
function setPopup() {
    $("#popOriginalIssueDiscount").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is an Original Issue Discount?</h5>When a bond or note is issued at an amount lesser than its face value, the discount thus earned is the Original Issue Discount. <br/><br/>A portion of this discount is annually recognized as taxable interest and is reported in Box 1 of your Form 1099OID.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popOtherPeriodicalInterest").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Other Periodical Interest?</h5>This is the other additional Periodical Interest amount that you might have earned during the Tax year 2014. <br/><br/>Box 2 of your Form 1099OID  is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popEarlyWithdrawalPenalty").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Early Withdrawal Penalty?</h5>This is the penalty paid if you had to withdraw the deposited money before the maturity date of the agreement. <br/><br/>This penalty is reported in Box 3 of Form 1099OID.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popFederalTaxWithheld ").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Federal Tax Withheld?</h5>This is the total amount of Federal Tax Withheld from your wages.<br/><br/> Your withholding is reported in Box 4 of Form 1099OID.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popForeignTaxWithheld").popover({ title: 'Quick Help', html: 'true', content: "<h5>Where to report the foreign tax paid?</h5>If you have paid income tax to a foreign country, it means that you might be eligible to take foreign tax credit on your 1040 individual tax return.<br/><br/> If your total foreign taxes was more than $300 (not more than $600 if married filing jointly), you  will have to attach Form 1116.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popForiegnCountryorUS").popover({ title: 'Quick Help', html: 'true', content: "<h5>Box6 Foriegn Tax Withheld</h5>Select the foreign country name  or  U.S Possession to which the witheld tax applies to.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popDescription").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Description name on Form 1099OID?</h5>This field is used to report the CUSIP number, if any. <br/><br/>If there is no CUSIP number, enter the abbreviation for the issuer that is used by the stock exchange, the coupon rate, and the year of maturity. <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popOIDonUSTreasuryObligation").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is OID on US Treasury Obligation?</h5>OID on a U.S. Treasury Obligation for the part of the year you owned, it is reported as interest income.<br/><br/> Box 8 of Form 1099OID is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popInvestmentExpenses").popover({ title: 'Quick Help', html: 'true', content: "<h5>What are Investment Expenses?</h5>It is nothing but the investment related expenses that can be deducted on Schedule A subject to 2%. <br/><br/>Your Investment Expense is reported in Box 9 of Form 1099OID.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popAccountNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>What Account Number is required here?</h5>This is the Bank Account Number in which the interest income is received.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popTaxExempt").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Tax Exempt OID Interest?</h5>It is the Tax Exemption allowed to you on your Original Issue Discount interest earned.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popTaxExemptCodeAndAmount").popover({ title: 'Quick Help', html:'true', content: "<h5>Tax Exempt Interest</h5><b>What is State Code?</b><br/><br/>Enter Your In State Code on Your OID TaxExempt Interest. <br/><br/><b>What is State Exempt Amount?</b><br/><br/>It is an exempt interest amount that you receive from your resident State municipal bonds or mutual funds. <br/><br/>This interest amount is relieved from your State tax return."});

    $("#popOldAdjustment").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is OID adjustment amount?</h5>A debt instrument you purchased after the date of original issue may have premium, acquisition premium, or market discount. <br/><br/>If so, the OID reported to you on Form 1099OID may have to be adjusted.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popStateInfoOnForm1099OID").popover({ title: 'Quick Help', html: 'true', content: "<h5>State Information on Form 1099OID</h5><b>Where to find  Payer State Identification Number?</b><br/><br/>Your Payer's State Identification Number is available in Box-11 of your Form 1099OID.<br/><br/><b>What is State Tax Withheld?</b><br /><br/>It is nothing but the amount of State Income Tax that has been withheld from you interest income.<br/><br/> Some States follow variable income tax rate, while some go with flat rate.<br/><br/> Your State Tax Withholding is reported in Box 12 of Form 1099OID.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
}

//F1099OID Persist
function ContinueAndPersistF1099OID() {
    PersistF1099OID();
    //Yogalakshmi - 20th August 2014 - Removed setTimeout as per Swapnesh mail.
    //setTimeout(function () {
        window.location.href = '../Income/interestincomesummary.html';
    //});
    return false;
}

//Saravanan N - 9th May, 2014 - FormId name altered in data param.
//Persist for Form 1099OID
function PersistF1099OID() {
    var form1099OIDId, owner, payerName, payerIdentificationNumber, form;
    var taxExemptStateAndAmount;
    var taxExemptStateAndAmountInfo = [];

    //Get values from existing object.
    if (f1099OID != null) {
        form1099OIDId = f1099OID != null ? f1099OID.Form1099OIDId : form1099OIDId;
        owner = f1099OID != null ? f1099OID.Owner : 0;
     
        form = f1099OID != null ? f1099OID.Form : '0';

        if (f1099OID.Payer != null) {
            payerName = f1099OID.Payer != null ? f1099OID.Payer.PayerName : '';
            payerIdentificationNumber = f1099OID.Payer != null ? f1099OID.Payer.PayerIdentificationNumber : '0';
        }
    }
    else {
        form1099OIDId = form1099OIDId;
    }

    //Get values from existing object.
 
    //Yogalakshmi - 25th August 2014 - 
    $.each($('#divStateTaxExempt').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;
        taxExemptStateAndAmount = {
            TaxExemptInterestState: {
                //StateCode: $("#txtW2StateID" + rowIndex).val(),
                StateId: $("#ddlStateExemptCode" + rowIndex).val()
            },
            StateExemptInterest: $("#txtExempt" + rowIndex).val().trim(),
        }
        taxExemptStateAndAmountInfo.push(taxExemptStateAndAmount);
    });

    

    F1099OIDPersistData = {
        Form1099OIDId: form1099OIDId,
        OriginalIssueDiscount: $("#txtOriginalIssueDiscount").val(),
        OtherPeriodicInterest: $("#txtOtherPeriodicInterest").val(),
        EarlyWithdrawalPenalty: $("#txtEarlyWithdrawalPenalty").val(),
        FederalTaxWithHoldingAmount: $("#txtFederalTaxWithHoldingAmount").val(),
        Description: $("#txtDescription").val(),
        USTreasuryObligations: $("#txtUSTreasuryObligations").val(),
        InvestmentExpenses: $("#txtInvestmentExpenses").val(),
        AccountNumber: $("#txtAccNo").val(),
        HasToReportTaxExempt: $("#chkTaxExempt").prop('checked'),
        HasToReportAdjustment: $("#chkadjustment").prop('checked'),
        TaxExemptInterest: $("#txtTaxExempt").val(),
        AdjustmentAmount: $("#txtajusment").val(),
        ForeignTaxPaid: $("#txtForeignTaxPaid").val(),
        ForeignCountryId: $("#ddlForeginCountryID").val(),
    //    TaxExemptInterestState:  // * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
    //{

    //    StateId: $("#ddlStateExemptCode0").val(),
    //    StateName: $("#ddlStateExemptCode0 option:selected").text()

    //},
        //    StateExemptInterest: $("#txtStateExempt0").val(),
        TaxExemptStateCodeAndAmount: taxExemptStateAndAmountInfo,
        Form1099StateInfo: [
                {
                    State: {
                        StateId: $("#ddlStateCodeID").val(),
                        StateCode: $("#ddlStateCodeID option:selected").text()
                    },
                    StateIdentificationNumber: $("#txtStateIdentificationNumber").val(),
                    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                    StateTaxWithholdingAmount: $("#txtStateTaxWithholdingAmount0").val()
                },

                {
                    State: {
                        StateId: $("#ddlStateCode2").val(),
                        StateIdentificationNumber: $("#txtPayerStateID").val()
                    },
                    StateIdentificationNumber: $("#txtPayerStateID").val(),
                    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                    StateTaxWithholdingAmount: $("#txtStateTaxWithholdingAmount1").val()
                }
        ],
        Owner: owner,
        Payer: {
            PayerName: payerName,
            PayerIdentificationNumber: payerIdentificationNumber
        },
        Form: form
    };

    $.ajax({
        url: serviceUrl + 'InterestIncome/F1099OIDinfocreate',
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
                    TaxData: JSON.stringify(F1099OIDPersistData)
                }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
                window.sessionStorage.setItem("Form1099OIDId", data.Form1099OIDId);
                //Saravanan N - 7th May, 2014 - Hard Stop eligibility check.
                isEligibilityCheckFailed = data.isEligibilityCheckFailed;
            }
        }
    });
}

//F1099OID Get Data
//Saravanan N - 9th May, 2014 - FormId name altered in data param.
function F1099OIDGetData() {
    $.ajax({
        url: serviceUrl + 'InterestIncome/F1099OIDgettaxdata',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId,
            "FormId": form1099OIDId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            //Yogalakshmi - 19th August 2014 - All the amount field should be fixed to two zeros after the decimal point - fixed.
            if (data != null) {
                if (data.m_Item1 != null) {
                    f1099OID = data.m_Item1;
                    $("#txtOriginalIssueDiscount").val(data.m_Item1.OriginalIssueDiscount == null ? "" : data.m_Item1.OriginalIssueDiscount.toFixed(2));
                    $("#txtOtherPeriodicInterest").val(data.m_Item1.OtherPeriodicInterest == null ? "" : data.m_Item1.OtherPeriodicInterest.toFixed(2));
                    $("#txtEarlyWithdrawalPenalty").val(data.m_Item1.EarlyWithdrawalPenalty == null ? "" : data.m_Item1.EarlyWithdrawalPenalty.toFixed(2));
                    $("#txtFederalTaxWithHoldingAmount").val(data.m_Item1.FederalTaxWithHoldingAmount == null ? "" : data.m_Item1.FederalTaxWithHoldingAmount.toFixed(2));
                    $("#txtDescription").val(data.m_Item1.Description);
                    $("#txtUSTreasuryObligations").val(data.m_Item1.USTreasuryObligations == null ? "" : data.m_Item1.USTreasuryObligations.toFixed(2));
                    $("#txtInvestmentExpenses").val(data.m_Item1.InvestmentExpenses == null ? "" : data.m_Item1.InvestmentExpenses.toFixed(2));
                    $("#txtForeignTaxPaid").val(data.m_Item1.ForeignTaxPaid == null ? "" : data.m_Item1.ForeignTaxPaid.toFixed(2));
                    $("#ddlForeginCountryID").val(data.m_Item1.ForeignCountryId);
                    $("#txtAccNo").val(data.m_Item1.AccountNumber);

                    if (data.m_Item1.HasToReportTaxExempt == true) {
                        $("#chkTaxExempt").prop('checked', data.m_Item1.HasToReportTaxExempt);
                        $("#txtTaxExempt").val(data.m_Item1.TaxExemptInterest == null ? "" : data.m_Item1.TaxExemptInterest.toFixed(2));
                        //if (data.m_Item1.TaxExemptInterestState != null) {
                        //    $("#ddlStateExemptCode0").val(data.m_Item1.TaxExemptInterestState.StateId);
                        //    $("#txtStateExempt0").val(data.m_Item1.StateExemptInterest == null ? "" : data.m_Item1.StateExemptInterest.toFixed(2));
                        //}
                        //Yogalakshmi - 21st August 2014 - 
                        if (data.m_Item1.TaxExemptStateCodeAndAmount != null) {
                            $.each(data.m_Item1.TaxExemptStateCodeAndAmount, function (index, value) {
                                stateTaxExempt = index;
                                if (index != 0) {
                                    AddStateTaxExempt(stateTaxExempt);
                                }
                                $("#ddlStateExemptCode" + stateTaxExempt).val(value.TaxExemptInterestState.StateId);
                                $("#txtExempt" + stateTaxExempt).val(value.StateExemptInterest == null ? "" : value.StateExemptInterest.toFixed(2));
                            });
                        }
                        $("#dvTaxExemptShow").show();
                    }

                    if (data.m_Item1.HasToReportAdjustment == true) {
                        $("#chkadjustment").prop('checked', data.m_Item1.HasToReportAdjustment);
                        $("#txtajusment").val(data.m_Item1.AdjustmentAmount == null ? "" : data.m_Item1.AdjustmentAmount.toFixed(2));
                        $("#dvAdjustedAmount").show();
                    }


                    if (data.m_Item1.Form1099StateInfo != null) {
                        if (data.m_Item1.Form1099StateInfo[0].State != null && data.m_Item1.Form1099StateInfo[0] != null) {
                            $("#ddlStateCodeID").val(data.m_Item1.Form1099StateInfo[0].State.StateId);
                            $("#txtStateIdentificationNumber").val(data.m_Item1.Form1099StateInfo[0].StateIdentificationNumber);
                            //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                            $("#txtStateTaxWithholdingAmount0").val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount == null ? "" : data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount.toFixed(2));
                        }

                        if (data.m_Item1.Form1099StateInfo[1].State != null && data.m_Item1.Form1099StateInfo[1] != null) {
                            $("#ddlStateCode2").val(data.m_Item1.Form1099StateInfo[1].State.StateId);
                            $("#txtPayerStateID").val(data.m_Item1.Form1099StateInfo[1].StateIdentificationNumber);
                            //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox

                            $("#txtStateTaxWithholdingAmount1").val(data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount == null ? "" : data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount.toFixed(2));
                        }
                    }
                }

                //TAX1040-13966 - Saravanan N - 9th June, 2014.
                $("#ddlForeginCountryID").attr('disabled', $("#txtForeignTaxPaid").val().trim().length == 0);
                //vivek - 6-Aug-14 - Added the focus for the error message control focus 
                if (data.m_Item3.errorlist != null) {
                    if (parameters != undefined && parameters.length == 3) {
                        $.each(data.m_Item3.errorlist, function (index, value) {

                            var rfparameterName = value.FieldName.split('-');
                            if (rfparameterName.length == 2) {
                                var controlToFocus = rfparameterName[1];
                                $('#' + controlToFocus).removeClass("form-control tip amountField").addClass("amountField tip error");
                                //06Aug2014 Sathish add onblur event to the control to remove error class
                                RemoveControlHighlighting(controlToFocus);
                            }
                        });
                    }
                }
            }
        }
    });
}

//Yogalakshmi - 25st August 2014 - Added a new method for Add State in StateTaxExempt
function AddStateTaxExempt(rowIndex) {
    //StateWages
    if (rowIndex <= 9) {
        var newStateWages = '  <div id="divStateTaxExempt"> ' +
               ' <div id="divStateTaxExempt' + rowIndex + '"> ' + '<div class="pangird itm">' +
               '     <input type="hidden" id="hStateTaxExempt0' + rowIndex + '" value="' + rowIndex + '" /> ' +
               '   <label class="col-md-6" id="lblEmployerName"> ' +
               '     <select tabIndex="19" id="ddlStateExemptCode' + rowIndex + '" name="ddlStateExemptCode"> ' +
               '   </select> ' +
               ' </label> ' +
               ' <label class="col-md-6"> ' +
               '             <input type="text" id="txtExempt' + rowIndex + '" name="ExemptAmount" placeholder="" class="form-control tip amountField" data-toggle="tooltip" data-placement="right" title="Amount of State Tax Exemption" data-trigger="focus" tabindex="20" onblur="extractNumberBlur(this,event,2,false,true);" onkeyup="extractNumber(this,event,2,false,false);" /> ' +
               '       </label> ' +
               ' </div> ' + ' </div> ' +
               ' </div> ';

        $('#divStateTaxExempt').append(newStateWages);
        $('#ddlStateExemptCode' + rowIndex).append($("<option></option>").val(0).html('---Select---'));
        $.each(state, function (key, value) {
            $('#ddlStateExemptCode' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateCode));
        });

        //$("#txtW2StateWages" + rowIndex).bind("keyup paste", function () {
        //    setTimeout(jQuery.proxy(function () {
        //        this.val(this.val().replace(/[^0-9.]/g, ''));
        //    }, $(this)), 0);
        //});

        NumbersOnly('txtExempt' + rowIndex);
        NumbersOnly('ddlStateExemptCode' + rowIndex);
    }
}
