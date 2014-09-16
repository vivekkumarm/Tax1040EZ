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

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
//Boolean variables
var hasSsbAndRrb = false;
var hasAlaskaPermanantFund = false;
var hasStateTaxRefund = false;
var isOtherIncomePersist = false;

//CONSTANTS
var MARRIED_FILING_JOINTLY = 2;

//EligibilityCheck
var isEligibilityCheckFailed = false;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');

    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    //Yogalakshmi - 22st May 2014 - Not to allow alphabets to specific field
    //$("#txtTaxPayerNetBenefitSSB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtSpouseNetBenefitSSB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtTaxPayerFederalTaxSSB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtSpouseFederalTaxSSB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtTaxPayerNetBenefitsRRB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtSpouseNetBenefitsRRB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtTaxPayerFederalRRB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtSpouseFederalRRB").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtAlaskaTaxPayer").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    //$("#txtAlaskaSpouse").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
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

    //Defect TAX1040 - 13994 - Saravanan N - 9th June, 2014 - radio button click alone should raise the event not on DIV click.
    $('#radclaimItemizedYes').click(function () {
        if ($('#radclaimItemizedYes').is(':checked')) {
            $('#dvDeductState').show();
           
        }
        else {
            $('#dvDeductState').hide();
          
        }
        $('#dvStateAndLocal').hide();
        $('#radDeductStateYes').click(function () {
            $('#dvStateAndLocal').hide();
        });
        $('#dvItemize').hide();
       
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

    $('#txtSpouseNetBenefitSSB').hide();
    $('#txtSpouseFederalTaxSSB').hide();
    $('#txtSpouseNetBenefitsRRB').hide();
    $('#txtSpouseFederalRRB').hide();

    $('#popSpouseFederalRRB').hide();
    $('#popSpouseBenefitsRRB').hide();
    $('#popSpouseFederalTaxSSB').hide();
    $('#popSpouseNetBenefitSSB').hide();




    $('#lblspouse').hide();

    $('#divAlaskaSpouse').hide();

    GetOtherIncome();

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

    $(function () {
        $("#popAlaskaTaxPayer").popover({ title: '', content: "<h5>TaxPayer</h5>Enter Your Alaska Permanent Fund Dividend Income.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAlaskaSpouse").popover({ title: '', content: "<h5>Spouse</h5>Enter Your Alaska Permanent Fund Dividend Income.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxPayerNetBenefitSSB").popover({ title: '', content: "<h5>TaxPayer</h5>Enter your Social Security benefits amount reported on your Form SSA-1099.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpouseNetBenefitSSB").popover({ title: '', content: "<h5>Spouse</h5>Enter your Social Security benefits amount reported on your Form SSA-1099.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxPayerFederalTaxSSB").popover({ title: '', content: "<h5>TaxPayer</h5>Enter your Federal tax withheld amount reported on your Form SSA- 1099.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpouseFederalTaxSSB").popover({ title: '', content: "<h5>Spouse</h5>Enter your Federal tax withheld amount reported on your Form SSA- 1099.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxPayerBenefitsRRB").popover({ title: '', content: "<h5>TaxPayer</h5>Enter your Railroad Retirement benefits amount reported on your Form 1099- RRB.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpouseBenefitsRRB").popover({ title: '', content: "<h5>Spouse</h5>Enter your Railroad Retirement benefits amount reported on your Form 1099- RRB.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxPayerFederalRRB").popover({ title: '', content: "<h5>TaxPayer</h5>Enter your Federal tax withheld amount reported on your Form 1099-RRB.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpouseFederalRRB").popover({ title: '', content: "<h5>Spouse</h5>Enter your Federal tax withheld amount reported on your Form 1099-RRB.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

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
        return false;
    });

    $('#btnSubmitTwo').click(function () {
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#aAlaskaPF').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aStateAndLocalTax').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        return false;
    });

    //Focus Method form Diagnostics.
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
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
    }

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
//Vincent-22 May 2014 - Added a Null for Other income get method.

//Persist Other Income
function PersistOtherIncome() {
    var taxData = {
        HasSsbAndRrb: hasSsbAndRrb,
        HasAlaskaPermanantFund: hasAlaskaPermanantFund,
        HasStateTaxRefund: hasStateTaxRefund,
        SSB:
            {
                TaxpayerNetBenefits: $('#txtTaxPayerNetBenefitSSB').val().trim().length == 0 ? 0 : $('#txtTaxPayerNetBenefitSSB').val(),
                TaxPayerFederalTaxWithheld: $('#txtTaxPayerFederalTaxSSB').val().trim().length == 0 ? 0 : $('#txtTaxPayerFederalTaxSSB').val(),
                SpouseNetBenefits: $('#txtSpouseNetBenefitSSB').val().trim().length == 0 ? 0 : $('#txtSpouseNetBenefitSSB').val(),
                SpouseFederalTaxWithheld: $('#txtSpouseFederalTaxSSB').val().trim().length == 0 ? 0 : $('#txtSpouseFederalTaxSSB').val()
            },
        RRB:
            {
                TaxpayerNetBenefits: $('#txtTaxPayerNetBenefitsRRB').val().trim().length == 0 ? 0 : $('#txtTaxPayerNetBenefitsRRB').val(),
                TaxPayerFederalTaxWithheld: $('#txtTaxPayerFederalRRB').val().trim().length == 0 ? 0 : $('#txtTaxPayerFederalRRB').val(),
                SpouseNetBenefits: $('#txtSpouseNetBenefitsRRB').val().trim().length == 0 ? 0 : $('#txtSpouseNetBenefitsRRB').val(),
                SpouseFederalTaxWithheld: $('#txtSpouseFederalRRB').val().trim().length == 0 ? 0 : $('#txtSpouseFederalRRB').val()
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
            if (data != null) {
                if (data.m_Item2 != null && data.m_Item2 == MARRIED_FILING_JOINTLY) {
                    //Field for SSB & RRB
                    $('#lblspouse').show();
                    $('#txtSpouseNetBenefitSSB').show();
                    $('#txtSpouseFederalTaxSSB').show();
                    $('#txtSpouseNetBenefitsRRB').show();
                    $('#txtSpouseFederalRRB').show();

                    $('#popSpouseFederalRRB').show();
                    $('#popSpouseBenefitsRRB').show();
                    $('#popSpouseFederalTaxSSB').show();
                    $('#popSpouseNetBenefitSSB').show();


                    //Field for Alaska
                    $('#divAlaskaSpouse').show();

                    if (data.m_Item1 != null) {
                        if (data.m_Item1.HasSsbAndRrb) {
                            if (data.m_Item1.SSB != null) {
                                $('#txtSpouseNetBenefitSSB').val(data.m_Item1.SSB.SpouseNetBenefits == 0 ? "" : data.m_Item1.SSB.SpouseNetBenefits);
                                $('#txtSpouseFederalTaxSSB').val(data.m_Item1.SSB.SpouseFederalTaxWithheld == 0 ? "" : data.m_Item1.SSB.SpouseFederalTaxWithheld);
                            }

                            if (data.m_Item1.RRB != null) {
                                $('#txtSpouseNetBenefitsRRB').val(data.m_Item1.RRB.SpouseNetBenefits == 0 ? "" : data.m_Item1.RRB.SpouseNetBenefits);
                                $('#txtSpouseFederalRRB').val(data.m_Item1.RRB.SpouseFederalTaxWithheld == 0 ? "" : data.m_Item1.RRB.SpouseFederalTaxWithheld);
                            }
                        }

                        if (data.m_Item1.HasAlaskaPermanantFund) {
                            if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                                //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                                $('#txtAlaskaSpouse').val(data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend);
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
                        $("#collapseOne").addClass("panel-collapse collapse in");

                        /*SSB*/
                        if (data.m_Item1.SSB != null) {

                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.SSB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld);
                        }

                        /*RRB*/
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.RRB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld);
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
                        $("#collapseTwo").addClass("panel-collapse collapse in");

                        //Alaska
                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
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
                        $("#collapseThree").addClass("panel-collapse collapse in");

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

                        /*Remove Class*/
                        $("#collapseOne").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");

                        /*Add Class*/
                        $('#dvSocialSecurity').show();
                        $("#collapseOne").addClass("panel-collapse collapse in");

                        //SSB
                        if (data.m_Item1.SSB != null) {

                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.SSB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld);
                        }

                        //RRB
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.RRB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld);
                        }

                        /*Alaska accordion */
                        /*******************/

                        /*Remove Class*/
                        $("#collapseTwo").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");

                        /*Add Class*/
                        $('#dvAlaska').show();
                        $("#collapseTwo").addClass("panel-collapse collapse");
                        //Alaska
                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
                        }


                    }

                    /**if Alsaka & State local are checked**/
                    if (data.m_Item1.HasAlaskaPermanantFund == true && data.m_Item1.HasStateTaxRefund == true) {

                        /*Alaska accordion */
                        /*******************/

                        /*Remove Class*/
                        $("#collapseTwo").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");

                        /*Add Class*/
                        $('#dvAlaska').show();
                        $("#collapseTwo").addClass("panel-collapse collapse in");

                        //Alaska
                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
                        }

                        /*State and Local accordion*/
                        /****************************/
                        /*Remove Class*/
                        $("#collapseThree").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                        /*Add Class*/
                        $('#dvStateLocalTaxRefund').show();
                        $("#collapseThree").addClass("panel-collapse collapse");

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
                        /*Remove Class*/
                        $("#collapseOne").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                        /*Add Class*/
                        $('#dvSocialSecurity').show();
                        $("#collapseOne").addClass("panel-collapse collapse in");

                        /*SSB*/
                        if (data.m_Item1.SSB != null) {

                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.SSB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld);
                        }

                        /*RRB*/
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.RRB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld);
                        }

                        /*State and Local accordion*/
                        /****************************/
                        /*Remove Class*/
                        $("#collapseThree").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                        /*Remove Class*/
                        $('#dvStateLocalTaxRefund').show();
                        $("#collapseThree").addClass("panel-collapse collapse");

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
                        /*Remove Class*/
                        $("#collapseOne").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                        /*Add Class*/
                        $('#dvSocialSecurity').show();
                        $("#collapseOne").addClass("panel-collapse collapse in");

                        /*SSB*/
                        if (data.m_Item1.SSB != null) {

                            $("#txtTaxPayerNetBenefitSSB").val(data.m_Item1.SSB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.SSB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalTaxSSB").val(data.m_Item1.SSB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.SSB.TaxPayerFederalTaxWithheld);
                        }

                        /*RRB*/
                        if (data.m_Item1.RRB != null) {
                            $("#txtTaxPayerNetBenefitsRRB").val(data.m_Item1.RRB.TaxpayerNetBenefits == 0 ? "" : data.m_Item1.RRB.TaxpayerNetBenefits);
                            $("#txtTaxPayerFederalRRB").val(data.m_Item1.RRB.TaxPayerFederalTaxWithheld == 0 ? "" : data.m_Item1.RRB.TaxPayerFederalTaxWithheld);
                        }

                        /*State and Local accordion*/
                        /****************************/
                        /*Remove Class*/
                        $("#collapseThree").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                        /*Add Class*/
                        $('#dvStateLocalTaxRefund').show();
                        $("#collapseThree").addClass("panel-collapse collapse");

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
                        /*Remove Class*/
                        $("#collapseTwo").removeClass("panel-collapse collapse in").addClass("panel-collapse collapse");
                        /*Add Class*/
                        $('#dvAlaska').show();
                        $("#collapseTwo").addClass("panel-collapse collapse");

                        if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                            //Yogalakshmi - 9th June 2014 - Removed the null check as per the defect TAX1040-13991
                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
                        }
                    }


                }
            }
        }
    });
}
