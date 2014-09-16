////7 Apr 2014 added the script for Form1099INT
//Script for f1099INT

//Vincent - 16th April 2014- added a error message navigation for required user control.
//Vincent - 23 Apr 2014 - Added ToggleTaxExempt() method to toggle the Tax exempt accordion.
//Sathish - 03May2014 Used Tax Return Data BO for persist

var F1099INTPersistData, f1099INT;
var form1099INTId;
var fromSummary;
$(document).ready(function () {

    //Error message- focus method for user control
    fromSummary = false;
    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    var parameters = pageURL.split('&');
    if (parameters.length == 3) {
        fromSummary = true;
        var controlParmeters = parameters[0];

        var FormType = parameters[2];

        //Form Type INT

        if (FormType.toString() == 'FormINT') {
            form1099INTId = parameters[1];
            var controls = controlParmeters.split('-')
            if (controls.length == 2) {

                var divToExpand = controls[0];
                var controlToFocus = controls[1];
                $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
                $('#' + divToExpand).addClass('panel-collapse collapse in');
                $('#' + controlToFocus).focus();
            }
        }

    }

    if (!window.sessionStorage.Form1099INTId) {
        form1099INTId = 0;
    } else {
        form1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
    }

    $("#InterestIncome").validate({
        rules: {
            InterestIncome: "required",
            USSavingBonds: "required",
            ddlStateExemptCode: {
                required: true,
            },
            ExemptAmount: {
                required: true,
            },
        },
        messages: {
            InterestIncome: "Missing Taxpayer or Spouse Code.",
            USSavingBonds: "Payer Name Should not be Empty.",
            ddlStateExemptCode: {
                required: "Missing State Exempt code",
                Test: "Missing State Exempt code"
            },
            ExemptAmount: {
                required: "Exempt Amount should not be empty",
                Test: "Exempt Amount should not be empty"
            }
        }
    });

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
            $.each(data, function (key, value) {
                $("#ddlStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlPayerStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateExempt").append($("<option></option>").val(value.StateId).html(value.StateCode));

            });
        }
    });


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
            $.each(data, function (key, value) {
                $("#ddlForeginCountryID").append($("<option></option>").val(value.CountryId).html(value.CountryName));

            });
        }
    });

    $(function () {
        $("#popInterestIncome").popover({ title: '', content: "<h5>Box1 Federal Income</h5><br />Interest income earned from any savings account for Federal./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popEarlyWithdrawalPenalty").popover({ title: '', content: "<h5>Box2 Early Withdrawal Penalty</h5><br />Penalties charged for withdrawing money from any bank account./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popUSSavingBonds").popover({ title: '', content: "<h5>Box3 Interest on U.S Saving bonds & Treasury Obligation</h5><br />Interest income earned on any U.S Saving bonds & Treasury Obligation./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popFederalTaxWitheld").popover({ title: '', content: "<h5>Box4 Federal Tax Withheld</h5><br />Total amount of Federal Tax Withheld on your interest income received from your renumerator ./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popInvestmentExpenses").popover({ title: '', content: "<h5>Box5 Investment Expenses</h5><br />Interest you paid for your own investment expenses./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignTaxWithheld").popover({ title: '', content: "<h5>Box6 Foriegn Tax Withheld</h5><br />Foriegn tax withheld for investments on any foreign bank or borrowed loans from foreign bank./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeginCountry").popover({ title: '', content: "<h5>Box7 Foreign Country</h5><br />Select the foriegn country name to whom you paid the interest./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popExemptInterest").popover({ title: '', content: "<h5>Box8 Tax Exempt Interest</h5><br />Total amount of Tax exempt interest you received. Tax exempt interest are social security benefits, scholarships, or fellowships, death benefits/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpecifiedPrivateActivity").popover({ title: '', content: "<h5>Specified Private Activity</h5><br />Interest amount on any private activity bonds./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAccountNo").popover({ title: '', content: "<h5>Account Number</h5><br />Enter your bank account number./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPayerStateID").popover({ title: '', content: "<h5>Payer's State ID</h5><br />Payers state identification number.State will assign unique number for an individual for identification purpose./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPayerStateTaxWithheld").popover({ title: '', content: "<h5>State Tax Withheld</h5><br />Total amount of tax withheld for state./> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

});

function ToggleTaxExempt() {
    var ExemptInterestVal = $('input#txtExemptInterest').val();
    if (ExemptInterestVal != null && ExemptInterestVal != '') {

        $('#PanelDisplay').show();
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in')
    }
    else {

        $("#PanelDisplay").hide();

    }
    return false;
}

//While Continue button click call to this function. 
function PersistandContinueF1099INT() {

    PersistF1099INT();
    setTimeout(function () {
        window.location.href = '../Income/interestincomesummary.html';
    });
    return false;
}

//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
//While Next button click call to this function. 
function PersistF1099INT() {
    if ($("#InterestIncome").valid()) {
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
                if (data != null) {
                    f1099INT = data;
                }
            }
        });

        if (f1099INT != null && (f1099INT.Payer != null || f1099INT.Owner != null || f1099INT.Form != null)) {
            F1099INTPersistData = {
                Form1099INTId: form1099INTId,
                InterestIncome: GetZeroOnIsNullOrEmpty($("#txtInterestIncome").val()),
                FederalTaxWithHoldingAmount: GetZeroOnIsNullOrEmpty($("#txtFederalTaxWitheld").val()),
                USBondsTreasury: GetZeroOnIsNullOrEmpty($("#txtUSSavingBonds").val()),
                EarlyWithdrawalPenalty: $("#txtEarlyWithdrawal").val(),
                InvestmentExpenses: GetZeroOnIsNullOrEmpty($("#txtInvestmentExpenses").val()),
                ForeignTaxPaid: $("#txtForeignWithheld").val(),
                ForeignCountryId: $("#ddlForeginCountryID").val(),
                TaxExemptInterest: $("#txtExemptInterest").val(),
                SpecifiedPrivateActivityBond: $("#txtSpecifiedPrivate").val(),
                AccountNumber: $("#txtAccountNo").val(),
                Form1099StateInfo: [
                        {
                            StateId: $("#ddlStateCode").val(),
                            StateIdentificationNumber: $("#txtStatePayer").val(),
                            StateTaxWithholdingAmount: GetZeroOnIsNullOrEmpty($("#txtStateWithheld").val())
                        },

                        {
                            StateId: $("#ddlPayerStateCode").val(),
                            StateIdentificationNumber: $("#txtPayerStateID").val(),
                            StateTaxWithholdingAmount: GetZeroOnIsNullOrEmpty($("#txtPayerStateWithheld").val())
                        }

                ],
                Owner: f1099INT.Owner,
                Payer: {
                    PayerName: f1099INT.Payer.PayerName,
                    PayerIdentificationNumber: f1099INT.Payer.PayerIdentificationNumber
                },
                Form: f1099INT.Form
            };
        }
        else {
            F1099INTPersistData = {
                Form1099INTId: form1099INTId,
                InterestIncome: $("#txtInterestIncome").val(),
                FederalTaxWithHoldingAmount: $("#txtFederalTaxWitheld").val(),
                USBondsTreasury: $("#txtUSSavingBonds").val(),
                EarlyWithdrawalPenalty: $("#txtEarlyWithdrawal").val(),
                InvestmentExpenses: $("#txtInvestmentExpenses").val(),
                ForeignTaxPaid: $("#txtForeignWithheld").val(),
                ForeignCountryId: $("#ddlForeginCountryID").val(),
                TaxExemptInterest: $("#txtExemptInterest").val(),
                SpecifiedPrivateActivityBond: $("#txtSpecifiedPrivate").val(),
                AccountNumber: $("#txtAccountNo").val(),
                Form1099StateInfo: [
                        {
                            StateId: $("#ddlStateCode").val(),
                            StateIdentificationNumber: $("#txtStatePayer").val(),
                            StateTaxWithholdingAmount: GetZeroOnIsNullOrEmpty($("#txtStateWithheld").val())
                        },

                        {
                            StateId: $("#ddlPayerStateCode").val(),
                            StateIdentificationNumber: $("#txtPayerStateID").val(),
                            StateTaxWithholdingAmount: GetZeroOnIsNullOrEmpty($("#txtPayerStateWithheld").val())
                        }

                ],
            };
        }
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
                            TaxData: JSON.stringify(F1099INTPersistData),
                        }

            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("UserDataId", data);
            }
        });
    }
}

function GetZeroOnIsNullOrEmpty(value) {
    if (value == "" || value == null)
        return 0;
    else {
        return value;
    }
}

//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
//While Getting the data back
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
            if (data != null) {
                $("#txtInterestIncome").val(data.InterestIncome),
                $("#txtFederalTaxWitheld").val(data.FederalTaxWithHoldingAmount),
                $("#txtUSSavingBonds").val(data.USBondsTreasury);
                $("#txtEarlyWithdrawal").val(data.EarlyWithdrawalPenalty),
                $("#txtInvestmentExpenses").val(data.InvestmentExpenses),
                $("#txtForeignWithheld").val(data.ForeignTaxPaid),
                $("#ddlForeginCountryID").val(data.ForeignCountryId),
                $("#txtExemptInterest").val(data.TaxExemptInterest),
                $("#txtSpecifiedPrivate").val(data.SpecifiedPrivateActivityBond),
                $("#txtAccountNo").val(data.AccountNumber);

                if (data.Form1099StateInfo != null) {
                    if (data.Form1099StateInfo[0] != null) {
                        $("#ddlStateCode").val(data.Form1099StateInfo[0].StateId),
                        $("#txtStatePayer").val(data.Form1099StateInfo[0].StateIdentificationNumber),
                        GetZeroOnIsNullOrEmpty($("#txtStateWithheld").val(data.Form1099StateInfo[0].StateTaxWithholdingAmount));
                    }

                    if (data.Form1099StateInfo[1] != null) {

                        $("#ddlPayerStateCode").val(data.Form1099StateInfo[1].StateId),
                        $("#txtPayerStateID").val(data.Form1099StateInfo[1].StateIdentificationNumber),
                        GetZeroOnIsNullOrEmpty($("#txtPayerStateWithheld").val(data.Form1099StateInfo[1].StateTaxWithholdingAmount));
                    }
                }
            }
        }

    });
}