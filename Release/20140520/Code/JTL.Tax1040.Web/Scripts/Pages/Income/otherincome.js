// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncome.html page.****//
//Saravanan N - 11th April, 2014 - Obtaining from Session Storage.
//var userId;
//var userDataId;
// 03may2014 Sathish user Tax return bo for persist

$(document).ready(function () {

    //TODO: It will be removed after testing - Saravanan N
    //if (ssbSelectio == "true") {
    //    $("#collapseOne").addClass("panel-collapse collapse in");
    //}
    //if (alaskaSelection == "true") {
    //    $("#collapseTwo").addClass("panel-collapse collapse in");
    //}
    //if (stateSelection == "true") {
    //    $("#collapseThree").addClass("panel-collapse collapse in");
    //}
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
    $('#divDeductState').hide();
    $('#divItemize').hide();
    $('#show').hide();

    $('#ClaimYes').click(function () {
        $('#divDeductState').toggle();
        $('#yes').click(function () {
        });
    });
    $('#ClaimNo').click(function () {
        $('#divItemize').toggle();
        $('#show').hide();

    });
    $('#No').click(function () {
        $('#show').toggle();
    });

    $('#txtSpouseNetBenefitSSB').hide();
    $('#txtSpouseFederalTaxSSB').hide();
    $('#txtSpouseNetBenefitsRRB').hide();
    $('#txtSpouseFederalRRB').hide();
    $('#txtAlaskaSpouse').hide();
    $('#lblspouse').hide();
    $('#lblSpouseAlaska').hide();
    $(function () {
        //$("#pop"To Date").popover({ title: '', content: "<h5>From Date</h5><br />Enter the date when you moved out of the new state./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //$("#pop"Taxpayer").popover({ title: '', content: "<h5>Taxpayer</h5><br />Total amount of dividend income received from Alaska./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //$("#pop"Box5 Net Benefits Paid(From SSA-1099)").popover({ title: '', content: "<h5>Box5 Net Benefits Paid(From SSA-1099)</h5><br />Amount of Social Security Benefits you have paid as shown in box 5 of Form SSA-1099./><a href='' target='_blank' class='more'>Read Common Question</a>" });

        //$("#pop"Box5 Net Benefits Paid(From SSA-1099)").popover({ title: '', content: "<h5>Box5 Net Benefits Paid(From SSA-1099)</h5><br />Amount of Social Security Benefits paid  by your spouse as shown in Box5 of Form SSA-1099./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //$("#pop"Box6 Voluntary Federal Tax Withheld(Form 1099SSA)").popover({ title: '', content: "<h5>Box6 Voluntary Federal Tax Withheld(Form 1099SSA )</h5><br />Total amount of Federal tax withheld for Voluntary benefits you have received for any disability or medical expenses as shown in Box 6 of Form 1099SSA./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //$("#pop"Box6 Voluntary Federal Tax Withheld(Form 1099SSA)").popover({ title: '', content: "<h5>Payer Name</h5><br />Total amount of Federal tax withheld for any voluntary benefits  received by your spouse as shown in Box6 of Form 1099SSA/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //    $("#pop"Box6 Voluntary Federal Tax Withheld(Form 1099SSA)").popover({ title: '', content: "<h5>Payer Name</h5><br />Total amount of Federal tax withheld for any voluntary benefits  received by your spouse as shown in Box6 of Form 1099SSA./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        //    $("#pop"Box5 Net Benefits Paid(Form 1099 RRB)").popover({ title: '', content: "<h5>Box5 Net Benefits Paid(Form 1099 RRB)</h5><br />Total amount of Railroad benefits you have paid as shown in box5 of Form 1099 RRB./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        //$("#pop"Box10 Federal Tax Witheld(Form 1099RRB)").popover({ title: '', content: "<h5>Box10 Federal Tax Witheld(Form 1099RRB)</h5><br />Amount of Federal income Tax Withheld for railroad benefits you have received as shown in Box10 of Form 1099RRB./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        //$("#pop"Box10 Federal Tax Witheld(Form 1099RRB)").popover({ title: '', content: "<h5>Box10 Federal Tax Witheld(Form 1099RRB)</h5><br />Federal income tax withheld for the railroad benefits received by your spouse as shown in Box 10 of Form 1099RRB./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        //$("#pop"Taxpayer").popover({ title: '', content: "<h5>Taxpayer</h5><br />Total amount of dividend income received from Alaska./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        //$("#pop"Spouse").popover({ title: '', content: "<h5>Spouse</h5><br />Total amount of dividend income your spouse received from Alaska./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    });


});

function PersisttOtherIncome() {
    var taxData = {
        SSB:
            {
                TaxpayerNetBenefits: $('#txtTaxPayerNetBenefitSSB').val(),
                TaxPayerFederalTaxWithheld: $('#txtTaxPayerFederalTaxSSB').val(),
                SpouseNetBenefits: $('#txtSpouseNetBenefitSSB').val(),
                SpouseFederalTaxWithheld: $('#txtSpouseFederalTaxSSB').val(),
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
        StateLocalTaxRefund:
            {
                HasClaimedItemizedDeductionPriorYear: $('#radclaimItemized').prop('checked'),
                HasStateAndLocalTaxDeductionPriorYear: $('#radDeductState').prop('checked')
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
        }
         ),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data);
        }
    });
}

function GetOtherIncomeDataById() {
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
            if (data != null && data.m_Item2 != null) {
                if (data.m_Item2 == 2) {
                    $('#lblspouse').show();
                    $('#txtSpouseNetBenefitSSB').show();
                    $('#txtSpouseFederalTaxSSB').show();
                    $('#txtSpouseNetBenefitsRRB').show();
                    $('#txtSpouseFederalRRB').show();
                    $('#txtAlaskaSpouse').show();
                    $('#txtSpouseNetBenefitSSB').val(data.SSB.SpouseNetBenefits),
                    $('#txtSpouseFederalTaxSSB').val(data.SSB.SpouseFederalTaxWithheld),
                    $('#txtSpouseNetBenefitsRRB').val(data.RRB.SpouseNetBenefits),
                    $('#txtSpouseFederalRRB').val(data.RRB.SpouseFederalTaxWithheld),
                    $('#lblSpouseAlaska').show();
                    $('#txtAlaskaSpouse').val(data.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend);
                }

                if (data.m_Item1 != null) {
                    if (data.m_Item1.HasSsbAndRrb) {
                        $("#collapseOne").addClass("panel-collapse collapse in");
                        $("#txtTaxPayerNetBenefitSSB").val(data.SSB.TaxpayerNetBenefits),
                        $("#txtTaxPayerFederalTaxSSB").val(data.SSB.TaxPayerFederalTaxWithheld),
                $("#txtTaxPayerNetBenefitsRRB").val(data.RRB.TaxpayerNetBenefits),
                        $("#txtTaxPayerFederalRRB").val(data.RRB.TaxPayerFederalTaxWithheld)
                    }
                    if (data.m_Item1.HasAlaskaPermanantFund) {
                        $("#collapseTwo").addClass("panel-collapse collapse in"),
                        $("#txtAlaskaTaxPayer").val(data.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend)
                    }
                    if (data.m_Item1.HasStateTaxRefund) {
                        $("#collapseThree").addClass("panel-collapse collapse in");
                        $("#txtAlaskaTaxPayer").val(data.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend),
                                $("#radclaimItemized").prop('checked', data.HasClaimedItemizedDeductionPriorYear);
                    }

                    $("#radDeductState").prop('checked', data.HasStateAndLocalTaxDeductionPriorYear)
                    if (data.SSB != null || data.RRB != null) {
                        $("#collapseOne").addClass("panel-collapse collapse in");
                    }
                    if (data.AlaskaPermanentFundDividend != null) {
                        $("#collapseTwo").addClass("panel-collapse collapse in");
                    }
                    if (data.HasClaimedItemizedDeductionPriorYear != null || data.HasStateAndLocalTaxDeductionPriorYear != null) {
                        $("#collapseThree").addClass("panel-collapse collapse in");

                    }
                }
            }
        }
    });
}
