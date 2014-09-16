////7 Apr 2014 added the script for Form1099INT
//Script for f1099INT

//Vincent - 16th April 2014- added a error message navigation for required user control.
//Vincent - 23 Apr 2014 - Added ToggleTaxExempt() method to toggle the Tax exempt accordion.
//Sathish - 03May2014 Used Tax Return Data BO for persist
//Vincent-26May2014-Refatored the code for Get and Persist method

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var F1099INTPersistData, f1099INT;
var form1099INTId;
var isEligibilityCheckFailed = false;
var controlParmeters;
var parameters;
var stateTaxExempt = 0;
var state;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');
    //Yogalakshmi - 11th August 2014 - Defect fix for TAX1040-14426
    $('#btnSubmitTwo').hide();
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    //Getting the ID form Session.
    if (!window.sessionStorage.Form1099INTId) {
        form1099INTId = 0;
    } else {
        form1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
    }

    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    parameters = pageURL.split('&');

    //Click on INT Error Message in InterestIncome Summary Diagnostic page, the below code will be executed.
    if (parameters.length == 3) {
        controlParmeters = parameters[0];
        var FormType = parameters[2];

        //Form Type INT
        if (FormType.toString() == 'FormINT') {
            form1099INTId = parameters[1];

        }
    }

    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('Form1099INTId') == 0) {
        form1099INTId = parameterName[1];
    }

    //Saravanan N - 27th May, 2014 - Moved code to separate functions.
    populateState();
    populateCountry();
    bindEvents();
    F1099INTGetData();
    setPopup();

    var divToExpand;
    var controlToFocus;
    //Defect # TAX1040-13968 - Vivek - 10th June, 2014.
    if (controlParmeters != null && controlParmeters.trim().length > 0) {
        var controls = controlParmeters.split('-');
        if (controls.length == 2) {
            var divToExpand = controls[0];
            var controlToFocus = controls[1];
        }
    }

    //Saravanan N - 18th Aug, 2014 - While collapse the accordion do Persist.
    //Yogalakshmi - 20th August 2014 - Added getErrorCountAndDisableBreadcrum() to disable the breadcrum when there is an eligibility error.
    $('#collapseOne').on('hidden.bs.collapse', function () {
        PersistF1099INT();
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    //Saravanan N - 18th Aug, 2014 - While collapse the accordion do Persist.
    $('#collapseTwo').on('hidden.bs.collapse', function () {
        PersistF1099INT();
        return false;
    });

    //Saravanan N - 18th Aug, 2014 - While collapse the accordion do Persist.
    $('#collapseThree').on('hidden.bs.collapse', function () {
        PersistF1099INT();
        return false;
    });

    //Yogalakshmi - 21st August 2014 - Implemented Add State in State Tax Exempt
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
        ValidateINTFirstAccordion();
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
        ValidateINTSecondAccordion();
    });

    //Saravanan N - 1st Sep, 2014 - For each text box in THIRD accordion onblur event added to check whether error icon need to display in this accordion.
    $('#collapseThree input:text, select').each(function () {
        $(this).addClass('validateControl3');

        //if ($(this).hasClass('error')) {
        //    //Add class only if it is having 'error' class (i.e., having red border)            
        //    $(this).addClass('validateControl3');
        //}
        //else {
        //    $(this).removeClass('validateControl3');
        //}
    })

    $('.validateControl3').blur(function () {
        ValidateINTThirdAccordion();
    });

    ValidateINTFirstAccordion();
    ValidateINTSecondAccordion();
    ValidateINTThirdAccordion();

    if (divToExpand != null && controlToFocus != null) {
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
});

//------------------------------------------------------------- FIRST ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateINTFirstAccordion() {
    var isServerSideValidationFailed = GetFirstAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#collapselinkOne').addClass('error');
    }
    else {
        $('#collapselinkOne').removeClass('error');
    }
}

function GetFirstAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseOne input[type=text]').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

//------------------------------------------------------------- SECOND ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateINTSecondAccordion() {
    var isServerSideValidationFailed = GetSecondAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#collapselinktwo').addClass('error');
    }
    else {
        $('#collapselinktwo').removeClass('error');
    }
}

function GetSecondAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseTwo input:text, select').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    //$('#collapseTwo select').each(function () {
    //    if ($(this).hasClass('error')) {
    //        alert($(this).attr('id'));
    //        isValidationFailed = true;
    //    }
    //});


    return isValidationFailed;
}

//------------------------------------------------------------- THIRD ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateINTThirdAccordion() {
    var isServerSideValidationFailed = GetThirdAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#collapselinkThree').addClass('error');
    }
    else {
        $('#collapselinkThree').removeClass('error');
    }
}

function GetThirdAccordionServerSideValidationStatus() {
    var isValidationFailed = false;

    $('#collapseThree input[type=text], select').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

/*************************************** COMMON FUNCTIONS SECTION *********************************/
//Saravanan N - 27th May, 2014 - Refactored method.
function populateState() {
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
            $("#ddlStateCode").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlPayerStateCode").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlStateExemptCode0").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlPayerStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateExemptCode0").append($("<option></option>").val(value.StateId).html(value.StateCode));
            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function populateCountry() {
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
                //Saravanan N - 16th July, 2014 - Country Drop Down List altered.
                var countryDisplayText = value.CountryCode + " - " + value.CountryName;
                $("#ddlForeginCountryID").append($("<option></option>").val(value.CountryId).html(countryDisplayText));//Thileep Changed to get Country code 27.05.14

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function bindEvents() {
    //TAX1040-13966 - Saravanan N - 9th June, 2014.
    $('#txtForeignWithheld').blur(function (e) {
        if ($("#txtForeignWithheld").val().trim().length == 0) {
            if ($("#ddlForeginCountryID").prop('disabled') == false) {
                $("#ddlForeginCountryID").val(0);
                $("#ddlForeginCountryID").attr('disabled', true);
                $('#txtExemptInterest').focus();
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

    $('.nextButton').click(function () {
        PersistF1099INT();
        return false;
    });

    //Changed click function by Thileep on 19Jun2014 for accordion 'Next' button click should focus 'Box 8 Tax Exempt Interest' accordion's 'State Code'  control should get focus.
    $('#btnSubmitOne').click(function () {
        firstAccordionNextClick();
    });

    $('#btnSubmitTwo').click(function () {
        secondAccordionNextClick();
    });

    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

   

    $('#btnContinue').click(function () {
        PersistandContinueF1099INT();
        //Saravanan N - 7th May, 2014 - Eligibility check occurred.
        PageNavigation(isEligibilityCheckFailed, '../Income/interestincomesummary.html', 'InterestIncome');
        return false;
    });

    //Thileep Added Filtering funtion 27.05.14
    //$("#txtInterestIncome").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtInterestIncome');

    //$("#txtEarlyWithdrawal").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtEarlyWithdrawal');

    //$("#txtUSSavingBonds").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtUSSavingBonds');

    //$("#txtFederalTaxWitheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtFederalTaxWitheld');

    //$("#txtInvestmentExpenses").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtInvestmentExpenses');

    //$("#txtForeignWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtForeignWithheld');

    //$("#txtExemptInterest").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtExemptInterest');

    //$("#txtSpecifiedPrivate").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtSpecifiedPrivate');

    //Yogalalkshmi - 4th July 2014 - Added for back arrow and cursor jumb  problems
    NumbersOnly('txtAccountNo');
    //$("#txtAccountNo").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9]/g, ''));
    //    }, $(this)), 0);
    //});

    //$("#txtStatePayer").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtStatePayer');

    //$("#txtStateWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
    NumbersOnly('txtStateWithheld0');

    //$("#txtPayerStateID").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtPayerStateID');

    //$("#txtPayerStateWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
    NumbersOnly('txtStateWithheld1');

    //$("#txtExempt").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtExempt');
}

//Saravanan N - 27th May, 2014 - Refactored method.
//Yogalakshmi - 16th July 2014 - Updated Quick help content.
//Yogalakshmi - 5th August 2014 -  Changes done for Quick Help flickering Problem 
function setPopup() {
    SetPopupForControl('popInterestIncome', 'What is Interest Income?', 'The money you made from an interest bearing account is your Interest Income.<br/><br/> This Interest Income is reported in Box 1 of your Form 1099INT.');

    SetPopupForControl('popEarlyWithdrawalPenalty', 'What is Early Withdrawal Penalty?', 'This is the amount of interest or principal forfeited because of an early withdrawal you make from a certificate of deposit. <br/><br/>This penalty is reported in Box 2 of your Form 1099INT.');

    SetPopupForControl('popUSSavingBonds', 'Are US Treasury Bonds and Savings Bonds Taxable?', 'Your Interest on US Treasury obligation and Savings Bonds are taxable on your Federal return, but are tax-free at State level.<br/><br/> This interest amount is reported in Box 3 of your Form 1099INT.');

    SetPopupForControl('popFederalTaxWitheld', 'What is Federal Tax Withheld?', 'This is the total amount of Federal Tax Withheld from your wages.<br/><br/> This withholding is reported in Box 4 of Form 1099INT.');

    SetPopupForControl('popInvestmentExpenses', 'What is Investment Expenses?', 'This is an amount of Interest you paid for your share of investment expenses of a single-class REMIC.<br/><br/> Your share of expenses of a REMIC that may be deductible on Schedule A is subjected to the 2% limit. <br/><br/>Your Investment Expense is reported in Box 5 of Form 1099INT.');

    SetPopupForControl('popForeignTaxWithheld', 'Where to report the Foreign Tax Paid?', 'If you paid income tax to a foreign country, it means that you might be eligible to take foreign tax credit on your 1040 individual tax return. <br/><br/>If your total foreign taxes was more than $300 (not more than $600 if married filing jointly), you  will have to attach Form 1116.');

    SetPopupForControl('popForeginCountry', 'Box7 Foreign Country', 'Select the foreign country name to whom you paid the interest.');

    SetPopupForControl('popExemptInterest', 'What is Tax Exempt Interest?', 'This is the amount of interest income that is not subjected to Federal Income Tax.<br/><br/> This Interest amount is reported in Box 8 of Form 1099INT.');

    SetPopupForControl('popSpecifiedPrivateActivity', 'What is Specified Private Interest?', 'This is the portion of tax-exempt interest earned from private activity bonds.<br/><br/> Refer Box 9 of your Form 1099INT to know your Specified Private Interest amount.');

    SetPopupForControl('popAccountNo', 'What Account Number is this?', 'Enter the Bank Account Number in which the interest income is received.');

    SetPopupForControl('popBox8TaxExemptCodeAndAmount', '<h5>Box 8 Tax Exempt Interest</h5>', '<b>What is State Code?</b><br/><br/>Select your Residential state code for the ‘Tax exempt Interest‘ received from your own state. <br/><br/><b>What is State Exempt Amount?</b><br/><br/>It is an exempt interest amount that you receive from your resident State municipal bonds or mutual funds.<br/><br/> This interest amount is relieved from your State tax return.');

    SetPopupForControl('popStateInfoOnForm1099INT', '<h5>State Information on Form 1099INT</h5>', '<b>Where to find  Payer State Identification Number?</b><br/><br />Your Payers State Identification Number is available in Box-14 of your Form 1099INT.<br/></br><b>What is  State Tax Withheld?</b><br/><br/>It is nothing but the amount of State Income Tax that has been withheld from you interest income. <br/>Some States follow variable income tax rate, while some go with flat rate.<br/><br/> Your State Tax Withholding is reported in Box 15 of Form 1099INT.');
}

//Saravanan N - 4th June, 2014 - Common method created.
//Yogalakshmi - 5th August 2014 - Changed as per Swapnesh 
function SetPopupForControl(controlToSetPopup, headerText, bodyText) {
    $('#' + controlToSetPopup).popover({ title: 'Quick Help', html: 'true', content: "<h5>" + headerText + "</h5>" + bodyText + "<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
}

function ToggleTaxExempt() {
    var ExemptInterestVal = $('input#txtExemptInterest').val();
    if (ExemptInterestVal != null && ExemptInterestVal != '') {
        $('#btnSubmitTwo').show();
        $('#PanelDisplay').show();
    }
    else {
        $("#PanelDisplay").hide();
        $('#btnSubmitTwo').hide();
        ResetBox8TaxExemptInterestGridControlValues();
    }
    return false;
}

//Saravanan N - 28th Aug, 2014 - Clear Box 8 Tax Exempt Amount control values.
function ResetBox8TaxExemptInterestGridControlValues() {
    for (var loopIndex = 0; loopIndex < 10; loopIndex++) {
        if (('#txtExempt' + loopIndex) != 'undefined') {
            $('#txtExempt' + loopIndex).val('');
        }
        if (("#ddlStateExemptCode" + loopIndex) != 'undefined') {
            $("#ddlStateExemptCode" + loopIndex).val(0);
        }
    }
}

//While Continue button click call to this function. 
function PersistandContinueF1099INT() {

    PersistF1099INT();
    //Yogalakshmi - 20th August 2014 - Removed setTimeout as per Swapnesh mail.
    //setTimeout(function () {
        window.location.href = '../Income/interestincomesummary.html';
    //});
    return false;
}

//F1099INT Persist Data

//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
//While Next button click call to this function. 
function PersistF1099INT() {
    var form1099INTId, owner, payerName, payerIdentificationNumber, form;
    payerName = '';
    payerIdentificationNumber = 0;
    owner = 0;
    form = 0;
    //var rowIndex = index[0].value;
    var taxExemptStateAndAmount;
    var taxExemptStateAndAmountInfo = [];

    //Get values from existing object.
    if (f1099INT != null) {
        form1099INTId = f1099INT.Form1099INTId;
        owner = f1099INT.Owner;
        form = f1099INT.Form;

        if (f1099INT.Payer != null) {
            payerName = f1099INT.Payer.PayerName;
            payerIdentificationNumber = f1099INT.Payer.PayerIdentificationNumber;
        }
    }
    else {
        form1099INTId = form1099INTId;
    }

    var stateExemptInterestValue = '';
    var stateExemptIdValue = 0;
    var stateExemptName = '';
    //TODO
    //if ($("#txtExemptInterest").val() > 0) {
    //    stateExemptIdValue = $("#ddlStateExemptCode").val();
    //    stateExemptInterestValue = $("#txtExempt").val();
    //}
    //Yogalakshmi - 21st August 2014 - 
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

    //Populate data into INT object.
    F1099INTPersistData = {
        Form1099INTId: form1099INTId,
        InterestIncome: ($("#txtInterestIncome").val()),
        FederalTaxWithHoldingAmount: ($("#txtFederalTaxWitheld").val()),
        USBondsTreasury: ($("#txtUSSavingBonds").val()),
        EarlyWithdrawalPenalty: $("#txtEarlyWithdrawal").val(),
        InvestmentExpenses: ($("#txtInvestmentExpenses").val()),
        ForeignTaxPaid: $("#txtForeignWithheld").val(),
        ForeignCountryId: $("#ddlForeginCountryID").val(),
        TaxExemptInterest: $("#txtExemptInterest").val(),
        SpecifiedPrivateActivityBond: $("#txtSpecifiedPrivate").val(),
        AccountNumber: $("#txtAccountNo").val(),
        //TaxExemptInterestState: // * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
        //    {
        //        StateId: stateExemptIdValue,
        //        StateCode: stateExemptName,
        //    },
        //StateExemptInterest: stateExemptInterestValue,
        TaxExemptStateCodeAndAmount:taxExemptStateAndAmountInfo,
        Form1099StateInfo: [
                {
                    State: {
                        StateId: $("#ddlStateCode").val(),
                        StateCode: $("#ddlStateCode option:selected").text(),
                    },
                    StateIdentificationNumber: $("#txtStatePayer").val(),
                    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                    StateTaxWithholdingAmount: ($("#txtStateWithheld0").val())
                },
                {
                    State: {
                        StateId: $("#ddlPayerStateCode").val(),
                        StateCode: $("#ddlPayerStateCode option:selected").text()
                    },
                    StateIdentificationNumber: $("#txtPayerStateID").val(),
                    //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                    StateTaxWithholdingAmount: ($("#txtStateWithheld1").val())
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
        url: serviceUrl + 'F1099INT/F1099INTinfocreate',
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
                        TaxData: JSON.stringify(F1099INTPersistData)
                    }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
                window.sessionStorage.setItem("Form1099INTId", data.Form1099INTId);
                //Saravanan N - 7th May, 2014 - Hard Stop eligibility check.
                isEligibilityCheckFailed = data.isEligibilityCheckFailed;
            }
        }
    });
}





//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
function F1099INTGetData() {
    $.ajax({
        url: serviceUrl + 'F1099INT/F1099INTgettaxdata',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId,
            "FormId": form1099INTId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            //Yogalakshmi - 19th August 2014 - All the amount field should be fixed to two zeros after the decimal point - fixed.
            if (data != null) {
                if (data.m_Item1 != null) {
                    f1099INT = data.m_Item1;
                    $("#txtInterestIncome").val(data.m_Item1.InterestIncome == null ? "" : data.m_Item1.InterestIncome.toFixed(2));
                    $("#txtFederalTaxWitheld").val(data.m_Item1.FederalTaxWithHoldingAmount == null ? "" : data.m_Item1.FederalTaxWithHoldingAmount.toFixed(2));
                    $("#txtUSSavingBonds").val(data.m_Item1.USBondsTreasury == null ? "" : data.m_Item1.USBondsTreasury.toFixed(2));
                    $("#txtEarlyWithdrawal").val(data.m_Item1.EarlyWithdrawalPenalty == null ? "" : data.m_Item1.EarlyWithdrawalPenalty.toFixed(2));
                    $("#txtInvestmentExpenses").val(data.m_Item1.InvestmentExpenses == null ? "" : data.m_Item1.InvestmentExpenses.toFixed(2));
                    $("#txtForeignWithheld").val(data.m_Item1.ForeignTaxPaid == null ? "" : data.m_Item1.ForeignTaxPaid.toFixed(2));
                    $("#ddlForeginCountryID").val(data.m_Item1.ForeignCountryId);
                    $("#txtExemptInterest").val(data.m_Item1.TaxExemptInterest == null ? "" : data.m_Item1.TaxExemptInterest.toFixed(2));
                    $("#txtSpecifiedPrivate").val(data.m_Item1.SpecifiedPrivateActivityBond == null ? "" : data.m_Item1.SpecifiedPrivateActivityBond.toFixed(2));
                    $("#txtAccountNo").val(data.m_Item1.AccountNumber);

                    //Saravanan N - 12th Aug, 2014 - If Box 8 entered valid number then while get the Box 8 value display Box 8 accordion.
                    ToggleTaxExempt();

                    //TODO
                    //if (data.m_Item1.TaxExemptInterest > 0) {
                    //    $('#PanelDisplay').show();
                    //    if (data.m_Item1.TaxExemptInterestState != null)  // * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
                    //        $("#ddlStateExemptCode").val(data.m_Item1.TaxExemptInterestState.StateId);
                    //    $("#txtExempt").val(data.m_Item1.StateExemptInterest == null ? "" : data.m_Item1.StateExemptInterest.toFixed(2));
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

                    if (data.m_Item1.Form1099StateInfo != null) {
                        if (data.m_Item1.Form1099StateInfo[0] != null && data.m_Item1.Form1099StateInfo[0] != null) {  // * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
                            $("#ddlStateCode").val(data.m_Item1.Form1099StateInfo[0].State.StateId);
                            $("#txtStatePayer").val(data.m_Item1.Form1099StateInfo[0].StateIdentificationNumber);
                            //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                            $("#txtStateWithheld0").val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount == null ? "" : data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount.toFixed(2));
                        }

                        if (data.m_Item1.Form1099StateInfo[1].State != null && data.m_Item1.Form1099StateInfo[1] != null) {  // * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
                            $("#ddlPayerStateCode").val(data.m_Item1.Form1099StateInfo[1].State.StateId);
                            $("#txtPayerStateID").val(data.m_Item1.Form1099StateInfo[1].StateIdentificationNumber);
                            //Yogalakshmi - 22nd August 2014 - Added index for the State Withheld textbox
                            $("#txtStateWithheld1").val(data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount == null ? "" : data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount.toFixed(2));
                        }
                    }

                    //TAX1040-13966 - Saravanan N - 9th June, 2014.
                    $("#ddlForeginCountryID").attr('disabled', $("#txtForeignWithheld").val().trim().length == 0);
                }
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

//Saravanan N - 18th Aug, 2014 - Method code separated.
function firstAccordionNextClick() {
    var ExemptInterestVal = $('input#txtExemptInterest').val();
    if (ExemptInterestVal != null && ExemptInterestVal != '') {
        $('#PanelDisplay').show();
        //Yogalakshmi - 11th August 2014 - Defect fix for TAX1040-14426
        $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse in');
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#collapselinkOne').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#collapselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
        $('#collapselinkThree').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
        $('#btnSubmitTwo').show();
    }
    else {
        $("#PanelDisplay").hide();
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        //Yogalakshmi - 11th August 2014 - Defect fix for TAX1040-14426
        $('#btnSubmitTwo').hide();
        $('#collapselinkOne').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#collapselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
    }
    RefundAmountCalculation();
    //Saravanan N - 7th Aug, 2014 - Added this to disable the breadcrum in Next button click if Eligibility error exists.
    getErrorCountAndDisableBreadcrum();

    return false;
}

//Saravanan N - 18th Aug, 2014 - Method code separated.
function secondAccordionNextClick() {
    $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
    $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');

    return false;
}

//Yogalakshmi - 21st August 2014 - Added a new method for Add State in StateTaxExempt
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