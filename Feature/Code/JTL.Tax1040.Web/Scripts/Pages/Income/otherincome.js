// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncome.html page.****//
//Saravanan N - 11th April, 2014 - Obtaining from Session Storage.
//var userId;
//var userDataId;
// 03may2014 Sathish user Tax return bo for persist
//Vincent-22 May 2014 - Modified the Js file for Otherincome.
//Vincent- 23 May 2014- Made a changes in Panel Expando.
//Vincent-29May2014-Made a changes to the StateOrLocalIncomeTaxRefunds radio check.
//Vincent- 2Jun2014-Worked on radio button & focus.
//Vincent- 5Jun2014- Worked  on Hard stopper.
//Vincent-9
////Vincent-16July2014-Removed the SSB & RRB TaxpayerNet Benefits as ZERO and eempty string
//Saravanan N - 17th July, 2014 - Common issue resolved and removed unwanted junk code.
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
//Boolean variables
var hasSsbAndRrb = false;
var hasAlaskaPermanantFund = false;
var hasStateTaxRefund = false;
var isOtherIncomePersist = false;
var fromDiagnostics = false; 
//CONSTANTS
var MARRIED_FILING_JOINTLY = 2;

//EligibilityCheck
var isEligibilityCheckFailed = false;
var parameterName;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');

    //Focus Method form Diagnostics.
    if (parameterName.length == 2) {
        fromDiagnostics = true;
    }

    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    NumbersOnly('txtTaxPayerNetBenefitSSB');
    NumbersOnly('txtSpouseNetBenefitSSB');
    NumbersOnly('txtTaxPayerFederalTaxSSB');
    NumbersOnly('txtSpouseFederalTaxSSB');
    NumbersOnly('txtTaxPayerNetBenefitsRRB');
    NumbersOnly('txtSpouseNetBenefitsRRB');
    NumbersOnly('txtTaxPayerFederalRRB');
    NumbersOnly('txtSpouseFederalRRB');
    NumbersOnly('txtAlaskaTaxPayer');
    NumbersOnly('txtAlaskaSpouse');

    $('#dvDeductState').hide();
    $('#dvItemize').hide();
    $('#dvStateAndLocal').hide();
    

    //Thileep - 16th June, 2014 - Hide all accordions in page load.
    $('#dvSocialSecurity').hide();
    $('#dvAlaska').hide();
    $('#dvStateLocalTaxRefund').hide();
    $('#radclaimItemizedYes').removeClass("form-control tip amountField").addClass("form-radio");


    $('#txtSpouseNetBenefitSSB').hide();
    $('#txtSpouseNetBenefitSSBtd').hide();
    $('#txtSpouseFederalTaxSSB').hide();
    $('#txtSpouseFederalTaxSSBtd').hide();
    $('#txtSpouseNetBenefitsRRB').hide();
    $('#txtSpouseNetBenefitsRRBtd').hide();
    $('#txtSpouseFederalRRB').hide();
    $('#txtSpouseFederalRRBtd').hide();

    $('#popSpouseFederalRRB').show();
    $('#popSpouseBenefitsRRB').show();
    $('#popSpouseFederalTaxSSB').show();
    $('#popSpouseNetBenefitSSB').show();
    $('#lblspouse').hide();
    $('#divAlaskaSpouse').hide();

    BindEvents();
    SetPopOverMessage();
    GetOtherIncome();

    var divToExpand;
    var controlToFocus;
    //Focus Method form Diagnostics.
    if (parameterName.length == 2) {
         divToExpand = parameterName[0];
         controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
        //Thileep Added on 13June2014 for focus.
    else {
        var divToExpand = parameterName[0];
        if (divToExpand == 'collapseTwo') {
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
            $('#' + divToExpand).addClass('panel-collapse collapse in');
        }
            //Prasana Added on 16July2014 for focus.
        else if (divToExpand == 'collapseThree')
        {
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
            $('#' + divToExpand).addClass('panel-collapse collapse in');
            $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
            $('#' + divToExpand).addClass('panel-collapse collapse in');
        }
    }

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
        ValidateFirstAccordion();
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
        ValidateSecondAccordion();
    });


    //Saravanan N - 1st Sep, 2014 - For each text box in SECOND accordion onblur event added to check whether error icon need to display in this accordion.
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
        ValidateThirdAccordion();
    });

    ValidateFirstAccordion();
    ValidateSecondAccordion();
    ValidateThirdAccordion();

    if (divToExpand != null && controlToFocus != null) {
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
});

//------------------------------------------------------------- FIRST ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateFirstAccordion() {
    var isServerSideValidationFailed = GetFirstAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#aSSBAndRRB').addClass('error');
    }
    else {
        $('#aSSBAndRRB').removeClass('error');
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
function ValidateSecondAccordion() {
    var isServerSideValidationFailed = GetSecondAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#aAlaskaPF').addClass('error');
    }
    else {
        $('#aAlaskaPF').removeClass('error');
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

//------------------------------------------------------------- THIRD ACCORDION VALIDATION -----------------------------------------------------------//

//Saravanan N - 19th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateThirdAccordion() {
    var isServerSideValidationFailed = GetThirdAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isServerSideValidationFailed) {
        $('#aStateAndLocalTax').addClass('error');
    }
    else {
        $('#aStateAndLocalTax').removeClass('error');
    }
}

function GetThirdAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseThree input:text, input:radio').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

/*************************************** COMMON FUNCTIONS SECTION *********************************/
function BindEvents() {
    $('#btnchromeenter').click(function () {
        if ($('#collapseOne').attr('class') == 'panel-collapse collapse in') {
            $('#btnSubmitOne').click();
            return false;
        }
        else if ($('#collapseTwo').attr('class') == 'panel-collapse collapse in') {
            $('#btnSubmitTwo').click();
            return false;
        }
        else if ($('#collapseThree').attr('class') == 'panel-collapse collapse in') {
            $('#btnContinue').click();
            return false;
        }

    });

    $('#btnSubmitOne').click(function () {
        //Saravanan N - 13th June, 2014 - Persist done while click NEXT in SSB & RRB.
        PersistOtherIncome();

        if (hasSsbAndRrb && hasStateTaxRefund && !hasAlaskaPermanantFund) {
            $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#aSSBAndRRB').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
            $('#aStateAndLocalTax').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }
        else {

            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#aSSBAndRRB').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
            $('#aAlaskaPF').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }

        //Saravanan N - 7th Aug, 2014 - Added this to disable the breadcrum in Next button click if Eligibility error exists.
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    $('#btnSubmitTwo').click(function () {
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#aAlaskaPF').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aStateAndLocalTax').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        RefundAmountCalculation();
        return false;
    });

    //Back
    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

    //Next

    $('#btnSSBNext').click(function () {
        PersistOtherIncome();
        return false;
    });

    //Continue
    $('#btnContinue').click(function () {
        if (PersistOtherIncome()) {
            PageNavigation(isEligibilityCheckFailed, '../Income/otherincomesummary.html', Topic.OtherIncome);  // 20Jun2014 Sathish replaced hard coded value with the constant
        }
        return false;
    });

    //Yogalakshmi - 18th August 2014 - Persist when accordion is closed and validates when accordion is opened.
    $('#collapseOne').on('hidden.bs.collapse', function () {
        PersistOtherIncome();
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    $('#collapseTwo').on('hidden.bs.collapse', function () {
        PersistOtherIncome();
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    $('#collapseThree').on('hidden.bs.collapse', function () {
        PersistOtherIncome();
        getErrorCountAndDisableBreadcrum(); //Yogalakshmi - 20th July 2014 - Breadcrum disabled if any eligibility error occurs.
        return false;
    });

    //Defect TAX1040 - 13994 - Saravanan N - 9th June, 2014 - radio button click alone should raise the event not on DIV click.
    $('#radclaimItemizedYes').click(function () {
        if ($('#radclaimItemizedYes').is(':checked')) {
            $('#dvDeductState').show();
        }
        else {
            $('#dvDeductState').hide();
        }
        $('#dvStateAndLocal').hide();
        $('#dvItemize').hide();
        ClearErrorIcon();
    });

    $('#radDeductStateYes').click(function () {
        $('#dvStateAndLocal').hide();
    });

    //Defect TAX1040 - 13994 - Saravanan N - 9th June, 2014 - radio button click alone should raise the event not on DIV click.
    $('#radclaimItemizedNo').click(function () {
        if ($('#radclaimItemizedNo').is(':checked')) {
            $('#dvItemize').show();
        } else {
            $('#dvItemize').hide();
        }

        $('#dvStateAndLocal').hide(); //Thileep - 26th May, 2014 - 
        $('#dvDeductState').hide();
        $('#radDeductStateYes').prop('checked', false);
        $('#radDeductStateNo').prop('checked', false);
        ClearErrorIcon();
    });

    //Defect TAX1040 - 13994 - Saravanan N - 9th June, 2014 - radio button click alone should raise the event not on DIV click.
    $('#radDeductStateNo').click(function () {
        if ($('#radDeductStateNo').is(':checked')) {
            $('#dvStateAndLocal').show();
        }
        else {
            $('#dvStateAndLocal').hide();
        }
    });
}

//Saravanan N - 1st Sep, 2014 - If error icon displayed in third accordion hide it.
function ClearErrorIcon() {
    $('#aStateAndLocalTax').removeClass('error');
}

function SetPopOverMessage() {
    $("#popAlaskaTaxPayer").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Alaska Dividend?</h5>This is the Permanent Dividend Fund paid directly by the Alaska State Government to you. <br/><br/>This is a taxable income under the Federal Government but is non-taxable under the State.<br/><br/> Form 1099-MISC is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popAlaskaSpouse").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Alaska Dividend?</h5>This is the Permanent Dividend Fund paid directly by the Alaska State Government to your Spouse. <br/><br/>This is a taxable income under the Federal Government but is non-taxable under the State. <br/><br/>Form 1099-MISC is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popTaxPayerNetBenefitSSB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Net Benefit Paid?</h5>This is the net benefit amount received from the Social Security Administration after deducting the benefits repaid amount from the Gross benefits.<br/><br/>Box 5 of Form SSA-1099 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSpouseNetBenefitSSB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Net Benefit paid?</h5>This is the net benefit your Spouse received for the year. <br/><br/>This is the net benefit amount received from the Social Security Administration after deducting the benefits repaid amount from the Gross benefits.<br/><br/>Box 5 of Form SSA-1099 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popTaxPayerFederalTaxSSB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Voluntary Federal Tax Withheld?</h5>This is the total amount of Federal Income Tax that is withheld from your benefits. <br/><br/>Voluntary withholding is applicable only for Federal taxes and not applicable for State or Local Taxes. <br/><br/>Box 6 of Form SSA-1099 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSpouseFederalTaxSSB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Voluntary Federal Tax Withheld?</h5>This is the total amount of Federal Income Tax that is withheld from your Spouse's benefits. <br/><br/>Voluntary withholding is only for Federal taxes and not applicable for State or Local Taxes.<br/><br/> Box 6 of Form SSA-1099 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popTaxPayerBenefitsRRB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is the Net Benefit paid?</h5>This is the net benefit amount received from the Railroad Retirement board after deducting the benefits repaid amount from the Gross benefits.<br/><br/>Box 5 of Form RRB 1099 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSpouseBenefitsRRB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Net Benefits paid?</h5>This is the net benefit amount received from the Railroad Retirement board after deducting the benefits repaid amount from the Gross benefits.<br/><br/> Box 5 of Form RRB 1099 is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popTaxPayerFederalRRB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Federal Tax Withheld?</h5>This is the total amount of Federal Income Tax Withheld from your Railroad Retirement Benefit.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popSpouseFederalRRB").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Federal Tax Withheld?</h5>This is the total amount of Federal Income Tax Withheld from your Spouse's Railroad Retirement Benefit.<br/><br/> Box 10 of Form 1099 RRB is where you can pick this from.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
}

//Persist Other Income
function PersistOtherIncome() {
    var taxData = {
        HasSsbAndRrb: hasSsbAndRrb,
        HasAlaskaPermanantFund: hasAlaskaPermanantFund,
        HasStateTaxRefund: hasStateTaxRefund,
        SSB:
            {
                TaxpayerNetBenefits: $('#txtTaxPayerNetBenefitSSB').val(),
                TaxPayerFederalTaxWithheld: $('#txtTaxPayerFederalTaxSSB').val(),
                SpouseNetBenefits: $('#txtSpouseNetBenefitSSB').val(),
                SpouseFederalTaxWithheld: $('#txtSpouseFederalTaxSSB').val()
            },
        RRB:
            {
                TaxpayerNetBenefits: $('#txtTaxPayerNetBenefitsRRB').val(),
                TaxPayerFederalTaxWithheld: $('#txtTaxPayerFederalRRB').val(),
                SpouseNetBenefits: $('#txtSpouseNetBenefitsRRB').val(),
                SpouseFederalTaxWithheld: $('#txtSpouseFederalRRB').val()
            },

        AlaskaPermanentFundDividend:
            {
                PrimaryTaxpayerAlaskaFundDividend: $('#txtAlaskaTaxPayer').val(),
                SpouseAlaskaFundDividend: $('#txtAlaskaSpouse').val()
            },
        StateOrLocalIncomeTaxRefunds:
            {
                HasClaimedItemizedDeductionPriorYear: ($('#radclaimItemizedYes').prop('checked') == false && $('#radclaimItemizedNo').prop('checked') == false) ? null : $('#radclaimItemizedYes').prop('checked'),
                HasStateAndLocalTaxDeductionPriorYear: ($('#radDeductStateYes').prop('checked') == false && $('#radDeductStateNo').prop('checked') == false) ? null : $('#radDeductStateYes').prop('checked')
            }
    };

    $.ajax({
        url: serviceUrl + 'otherincome/persistotherincome',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            fromIncomeGateway: false,
            TaxReturnData:
                {
                    UserDataId: userDataId,
                    TaxData: JSON.stringify(taxData),
                }
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {

                isOtherIncomePersist = true;
                if (data.m_Item1 != null) {
                    window.sessionStorage.setItem("UserDataId", data.m_Item1);
                }

                //Hard Stopper
                isEligibilityCheckFailed = data.m_Item2;

            }
        }
    });
    return isOtherIncomePersist;
}

//Get other income.
function GetOtherIncome() {
    $.ajax({
        url: serviceUrl + 'otherincome/getotherincome',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            userDataId: userDataId
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            //Yogalakshmi - 19th August 2014 - All the amount field should be fixed to two zeros after the decimal point - fixed.
            if (data != null) {
                if (data.m_Item2 != null && data.m_Item2 == MARRIED_FILING_JOINTLY) {
                    //Field for SSB & RRB
                    $('#lblspouse').show();
                    $('#txtSpouseNetBenefitSSB').show();
                    $('#txtSpouseFederalTaxSSB').show();
                    $('#txtSpouseNetBenefitsRRB').show();
                    $('#txtSpouseFederalRRB').show();
                    $('#txtSpouseNetBenefitSSBtd').show();
                    $('#txtSpouseFederalTaxSSBtd').show();
                    $('#txtSpouseNetBenefitsRRBtd').show();
                    $('#txtSpouseFederalRRBtd').show();
                    $('#popSpouseFederalRRB').show();
                    $('#popSpouseBenefitsRRB').show();
                    $('#popSpouseFederalTaxSSB').show();
                    $('#popSpouseNetBenefitSSB').show();


                    //Field for Alaska
                    $('#divAlaskaSpouse').show();

                    if (data.m_Item1 != null) {
                        if (data.m_Item1.HasSsbAndRrb) {
                            if (data.m_Item1.SSB != null) {
                                $('#txtSpouseNetBenefitSSB').val(data.m_Item1.SSB.SpouseNetBenefits == null ? "" : data.m_Item1.SSB.SpouseNetBenefits.toFixed(2));
                                $('#txtSpouseFederalTaxSSB').val(data.m_Item1.SSB.SpouseFederalTaxWithheld == null ? "" : data.m_Item1.SSB.SpouseFederalTaxWithheld.toFixed(2));
                            }

                            if (data.m_Item1.RRB != null) {
                                $('#txtSpouseNetBenefitsRRB').val(data.m_Item1.RRB.SpouseNetBenefits == null ? "" : data.m_Item1.RRB.SpouseNetBenefits.toFixed(2));
                                $('#txtSpouseFederalRRB').val(data.m_Item1.RRB.SpouseFederalTaxWithheld == null ? "" : data.m_Item1.RRB.SpouseFederalTaxWithheld.toFixed(2));
                            }
                        }

                        if (data.m_Item1.HasAlaskaPermanantFund) {
                            if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                                //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                                $('#txtAlaskaSpouse').val(data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend == null ? "" : data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend.toFixed(2));
                            }
                        }
                    }
                }

                if (data.m_Item1 != null) {
                    $('#dvSocialSecurity').hide();
                    $('#dvAlaska').hide();
                    $('#dvStateLocalTaxRefund').hide();

                    /**To get other income bool values.**/
                    hasSsbAndRrb = data.m_Item1.HasSsbAndRrb;
                    hasAlaskaPermanantFund = data.m_Item1.HasAlaskaPermanantFund;
                    hasStateTaxRefund = data.m_Item1.HasStateTaxRefund;


                    /**If SSB & RRB Are Check**/
                    if (data.m_Item1.HasSsbAndRrb == true) {

                        //SSB & RRB accordion
                        /**********************/
                        $('#dvSocialSecurity').show();

                        if (!fromDiagnostics) {
                            $("#collapseOne").addClass("panel-collapse collapse in");
                        }

                        /*SSB*/
                        if (data.m_Item1.SSB != null) {

                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == null ? "" : data.m_Item1.SSB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        /*RRB*/
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == null ? "" : data.m_Item1.RRB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        //Vincent-18jun2014-added the Next button section for SSB & RRB.The method was removed
                        //Show/Hide Next button
                        if ((data.m_Item1.HasAlaskaPermanantFund == true) || (data.m_Item1.HasStateTaxRefund == true)) {
                            $('#btnSubmitOne').show();
                        } else {
                            $('#btnSubmitOne').hide();
                        }
                    }

                    /**If  AlaskaPermanantFund are check**/
                    if (data.m_Item1.HasAlaskaPermanantFund == true) {
                        /*Alaska accordion */
                        /*******************/
                        $('#dvAlaska').show();

                        if (!fromDiagnostics) {
                            $("#collapseTwo").addClass("panel-collapse collapse in");
                        }

                        //Alaska
                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == null ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend.toFixed(2));
                        }

                        //Show/Hide Next button
                        if (data.m_Item1.HasStateTaxRefund == true) {
                            $('#btnSubmitTwo').show();
                        } else {
                            $('#btnSubmitTwo').hide();
                        }
                    }

                    /**If State tax refund are Check **/
                    if (data.m_Item1.HasStateTaxRefund == true) {

                        /*State and Local accordion*/
                        /****************************/
                        $('#dvStateLocalTaxRefund').show();

                        if (!fromDiagnostics) {
                            $("#collapseThree").addClass("panel-collapse collapse in");
                        }

                        //Defect TAX1040-13995 - Saravanan N - 10th June, 2014 - div display logic implemented.
                        $('#dvDeductState').hide();
                        $('#dvItemize').hide();
                        $('#dvStateAndLocal').hide();
                        if (data.m_Item1.StateOrLocalIncomeTaxRefunds != null) {
                            if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == true) {
                                $("#radclaimItemizedYes").prop('checked', true);
                                $('#dvDeductState').show();
                                

                                if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == true) {

                                    $("#radDeductStateYes").prop('checked', true);
                                }
                                else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == false) {
                                    $("#radDeductStateNo").prop('checked', true);
                                    $('#dvStateAndLocal').show();
                                }
                            } else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == false) {
                                $("#radclaimItemizedNo").prop('checked', true);
                                $('#dvItemize').show();
                            }
                        }
                    }

                    /**If SSB , RRB && Alaska are Check**/

                    if (data.m_Item1.HasSsbAndRrb == true && data.m_Item1.HasAlaskaPermanantFund == true) {
                        //SSB & RRB accordion
                        /**********************/
                        $('#dvSocialSecurity').show();

                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseOne").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $("#collapseOne").addClass("panel-collapse collapse in");
                        }

                        //SSB
                        if (data.m_Item1.SSB != null) {
                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == null ? "" : data.m_Item1.SSB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        //RRB
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == null ? "" : data.m_Item1.RRB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        /*Alaska accordion */
                        /*******************/
                        $('#dvAlaska').show();

                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseTwo").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $("#collapseTwo").addClass("panel-collapse collapse");
                        }

                        //Alaska
                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == null ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend.toFixed(2));
                        }


                    }

                    /**if Alsaka & State local are checked**/
                    if (data.m_Item1.HasAlaskaPermanantFund == true && data.m_Item1.HasStateTaxRefund == true) {
                        $('#dvAlaska').show();

                        /*Alaska accordion */
                        /*******************/
                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseTwo").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");

                            /*Add Class*/
                            $("#collapseTwo").addClass("panel-collapse collapse in");
                        }

                        //Alaska
                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == null ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend.toFixed(2));
                        }

                        /*State and Local accordion*/
                        /****************************/
                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseThree").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $('#dvStateLocalTaxRefund').show();
                            $("#collapseThree").addClass("panel-collapse collapse");
                        }

                        if (data.m_Item1.StateOrLocalIncomeTaxRefunds != null) {
                            if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == true) {
                                $("#radclaimItemizedYes").prop('checked', data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear);
                                if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == true) {
                                    $('#dvDeductState').show();
                                    $("#radDeductStateYes").prop('checked', data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear);
                                }
                                else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == false) {
                                    $("#radDeductStateNo").prop('checked', true);
                                    $('#dvDeductState').show();
                                }
                            }
                            else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == false) {

                                $("#radclaimItemizedNo").prop('checked', true);

                            }
                        }

                    }

                    /**If SSB and RRB && State local **/
                    if (data.m_Item1.HasSsbAndRrb == true && data.m_Item1.HasStateTaxRefund == true) {
                        //SSB & RRB accordion
                        /**********************/
                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseOne").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $("#collapseOne").addClass("panel-collapse collapse in");
                        }

                        /*SSB*/
                        if (data.m_Item1.SSB != null) {
                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == null ? "" : data.m_Item1.SSB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        /*RRB*/
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == null ? "" : data.m_Item1.RRB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        /*State and Local accordion*/
                        /****************************/
                        /*Remove Class*/
                        if (!fromDiagnostics) {
                            $("#collapseThree").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Remove Class*/
                            $('#dvStateLocalTaxRefund').show();
                            $("#collapseThree").addClass("panel-collapse collapse");
                        }

                        if (data.m_Item1.StateOrLocalIncomeTaxRefunds != null) {
                            if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == true) {
                                $("#radclaimItemizedYes").prop('checked', data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear);
                                if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == true) {
                                    $('#dvDeductState').show();
                                    $("#radDeductStateYes").prop('checked', data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear);
                                }
                                else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == false) {
                                    $("#radDeductStateNo").prop('checked', true);
                                    $('#dvDeductState').show();
                                }
                            }
                            else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == false) {

                                $("#radclaimItemizedNo").prop('checked', true);

                            }
                        }
                    }


                    /**If SSB and RRB && State local && Alaska **/
                    if (data.m_Item1.HasSsbAndRrb == true && data.m_Item1.HasStateTaxRefund == true && data.m_Item1.HasAlaskaPermanantFund == true) {
                        //SSB & RRB accordion
                        /**********************/
                        $('#dvSocialSecurity').show();

                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseOne").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $("#collapseOne").addClass("panel-collapse collapse in");
                        }

                        /*SSB*/
                        if (data.m_Item1.SSB != null) {
                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == null ? "" : data.m_Item1.SSB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        /*RRB*/
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == null ? "" : data.m_Item1.RRB.TaxpayerNetBenefits.toFixed(2));
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == null ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld.toFixed(2));
                        }

                        /*State and Local accordion*/
                        /****************************/
                        $('#dvStateLocalTaxRefund').show();

                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseThree").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $("#collapseThree").addClass("panel-collapse collapse");
                        }

                        if (data.m_Item1.StateOrLocalIncomeTaxRefunds != null) {
                            if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == true) {
                                $("#radclaimItemizedYes").prop('checked', data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear);
                                if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == true) {
                                    $('#dvDeductState').show();
                                    $("#radDeductStateYes").prop('checked', data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear);
                                }
                                else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasStateAndLocalTaxDeductionPriorYear == false) {
                                    $("#radDeductStateNo").prop('checked', true);
                                    $('#dvDeductState').show();
                                }
                            }
                            else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == false) {

                                $("#radclaimItemizedNo").prop('checked', true);

                            }
                        }


                        /*Alaska accordion */
                        /*******************/
                        $('#dvAlaska').show();

                        if (!fromDiagnostics) {
                            /*Remove Class*/
                            $("#collapseTwo").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                            /*Add Class*/
                            $("#collapseTwo").addClass("panel-collapse collapse");
                        }

                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == null ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend.toFixed(2));
                        }
                    }
                }
                //vivek - 6-Aug-14 - Added the focus for the error message control focus 
                if (data.m_Item3 != null) {
                    if (parameterName != undefined && parameterName.length == 2) {
                        $.each(data.m_Item3, function (index, value) {

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
