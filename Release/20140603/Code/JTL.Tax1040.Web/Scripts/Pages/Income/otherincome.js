// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncome.html page.****//
//Saravanan N - 11th April, 2014 - Obtaining from Session Storage.
//var userId;
//var userDataId;
// 03may2014 Sathish user Tax return bo for persist
//Vincent-22 May 2014 - Modified the Js file for Otherincome.
//Vincent- 23 May 2014- Made a changes in Panel Expando.
//Vincent-29May2014-Made a changes to the StateOrLocalIncomeTaxRefunds radio check.
//Vincent- 2Jun2014-Worked on radio button & focus.

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
//Boolean variables
var hasSsbAndRrb = false;
var hasAlaskaPermanantFund = false;
var hasStateTaxRefund = false;

//CONSTANTS
var MARRIED_FILING_JOINTLY = 2;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');


    //Yogalakshmi - 22st May 2014 - Not to allow alphabets to specific field
    $("#txtTaxPayerNetBenefitSSB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtSpouseNetBenefitSSB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    }); $("#txtTaxPayerFederalTaxSSB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtSpouseFederalTaxSSB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtTaxPayerNetBenefitsRRB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtSpouseNetBenefitsRRB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtTaxPayerFederalRRB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtSpouseFederalRRB").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtAlaskaTaxPayer").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtAlaskaSpouse").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });




    $('#dvDeductState').hide();
    $('#dvItemize').hide();
    $('#dvStateAndLocal').hide();

    $('#dvClaimYes').click(function () {
        $('#dvDeductState').toggle();
        $('#dvStateAndLocal').hide();
        $('#dvYesStateDeduct').click(function () {
            $('#dvStateAndLocal').hide();
        });
        $('#dvItemize').hide();
    });

    $('#dvClaimNo').click(function () {
        $('#dvItemize').toggle();
        //$('#dvItemizeddeduction').hide();
        $('#dvStateAndLocal').hide(); //Thileep - 26th May, 2014 - 
        $('#dvDeductState').hide();

    });

    $('#dvNoStateDeduct').click(function () {
        $('#dvStateAndLocal').toggle();
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

    $('#btnSubmitOne').click(function () {
        PersistOtherIncome();
        return false;
    });

    //Continue
    $('#btnContinue').click(function () {
        PersistOtherIncome();
        window.location.href = '../Income/otherincomesummary.html';
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
                window.sessionStorage.setItem("UserDataId", data);
            }
        }
    });
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
                                $('#txtAlaskaSpouse').val(data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend == 0 ? "" : data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend);
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

                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == 0 ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
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
                            } else if (data.m_Item1.StateOrLocalIncomeTaxRefunds.HasClaimedItemizedDeductionPriorYear == false) {

                                $("#radclaimItemizedNo").prop('checked', true);

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

                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == 0 ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
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

                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == 0 ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
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

                            $("#txtAlaskaTaxPayer").val(data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend == 0 ? "" : data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend);
                        }
                    }


                }
            }
        }
    });
}
