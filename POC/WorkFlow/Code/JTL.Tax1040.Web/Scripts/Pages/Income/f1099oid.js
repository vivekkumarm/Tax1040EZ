//10 Apr 14 Vincent Added a new Script file for 1099OID
//Vincent - 16th April 2014- added a error message navigation for required user control.
// Sathish 03May2014 User Tax Return Data bo for presist
var F1099OIDPersistData, f1099OID;
var form1099OIDId;
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
        if (FormType.toString() == 'FormOID') {
            form1099OIDId = parameters[1];
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

    if (!window.sessionStorage.Form1099OIDId) {
        form1099OIDId = 0;
    } else {
        form1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
    }

    //Check box hide for other info section
    $("#Taxexemptshow").hide(); {
        $("#Taxexempt").click(function () {
            if ($("#chktaxexempt").prop("checked") == true) {
                $("#Taxexemptshow").toggle();
            }
        });
    }
    $("#OIDadjusshow").hide(); {
        $("#OIDadjus").click(function () {
            if ($("#chkadjustment").prop("checked") == true) {
                $("#OIDadjusshow").toggle();
            }
        });
    }


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
            //alert(data);
            $.each(data, function (key, value) {
                $("#ddlStateCodeID").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateCode2").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateCode3").append($("<option></option>").val(value.StateId).html(value.StateCode));

            });
        }
    });

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
            //alert(data);
            $.each(data, function (key, value) {
                $("#ddlForeginCountryID").append($("<option></option>").val(value.CountryId).html(value.CountryName));

            });
        }
    });

    $(function () {
        $("#popOriginalIssueDiscount").popover({ title: '', content: "<h5>Original Issue Discount</h5><br />Enter the amount of discount issued by any bond./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popOtherPeriodicalInterest").popover({ title: '', content: "<h5>Other Periodical Interest</h5><br /> Interest earned or paid on for other periodical actvities./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popEarlyWithdrawalPenalty").popover({ title: '', content: "<h5>Box3 Early Withdrawal Penalty</h5><br />Enter the  penalty amount charged by bank for  early  withdrawal of money deposit for your own purpose.For example early withdrawal of  money from your retirement account, bank will charge you with penalty./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popFederalTaxWithheld ").popover({ title: '', content: "<h5>Box4 Federal Tax Withheld</h5><br />Enter the amount of Federal income tax withheld./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popForeignTaxWithheld").popover({ title: '', content: "<h5>Foriegn Tax Withheld</h5><br />Enter the amount of foriegn tax withheld discount./> <a href='' target='_blank' class='more'>Read Common Question</a>" });



        $("#popForiegnCountryorUS").popover({ title: '', content: "<h5>Box6 Foriegn Tax Withheld</h5><br />Select the foreign country name  or  U.S Possession to which the witheld tax applies to./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popOIDonUSTreasuryObligation").popover({ title: '', content: "<h5>Box8 OID on U.S Treasury Obligation</h5><br />Enter the interest amount for OID on U.S Treasury Obligation./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popInvestmentExpenses").popover({ title: '', content: "<h5>Box9 Investment Expenses</h5><br />Interest you paid for your own interest expenses./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popAccountNumber").popover({ title: '', content: "<h5>Account Number</h5><br />Enter your bank account number./> <a href='' target='_blank' class='more'>Read Common Question</a>" });



        $("#popPayerStateId").popover({ title: '', content: "<h5>Box 12 Payer's State ID</h5><br />State Taxpayer Identification number is assigned by the state authority to an individual tax payer for identification purpose./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popStateTaxWithheld").popover({
            title: '', content: "<h5>Box13 State Tax Withheld</h5><br />Total amount of tax withheld for the state./> <a href='' target='_blank' class='more'>Read Common Question</a>"
        });

    });


    function ContinueAndPersistF1099OID() {
        PersistF1099OID();
        setTimeout(function () {
            window.location.href = '../Income/interestincomesummary.html';
        });
        return false;
    }

    //Saravanan N - 9th May, 2014 - FormId name altered in data param.
    //Persist for Form 1099OID
    function PersistF1099OID() {
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
                if (data != null) {
                    f1099OID = data;
                }
            }
        });

        if (f1099OID != null && (f1099OID.Payer != null || f1099OID.Owner != null || f1099OID.Form != null)) {
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
                HasToReportTaxExempt: $("#chktaxexempt").prop('checked'),
                HasToReportAdjustment: $("#chkadjustment").prop('checked'),
                TaxExemptInterest: $("#txttaxexempt").val(),
                AdjustmentAmount: $("#txtajusment").val(),
                ForeignTaxPaid: $("txtForeignTaxPaid").val(),
                ForeignCountryId: $("#ddlForeginCountryID").val(),
                TaxExemptInterestStateId: $("#ddlStateCode3").val(),
                StateExemptInterest: $("#txtstateexempt").val(),
                Form1099StateInfo: [
                        {
                            StateId: $("#ddlStateCodeID").val(),
                            StateIdentificationNumber: $("#txtStateIdentificationNumber").val(),
                            StateTaxWithholdingAmount: $("#txtStateTaxWithholdingAmount").val()
                        },

                        {
                            StateId: $("#ddlStateCode2").val(),
                            StateIdentificationNumber: $("#txtPayerStateID").val(),
                            StateTaxWithholdingAmount: $("#txtPayerStateWithheld").val()
                        }

                ],
                Owner: f1099OID.Owner,
                Payer: {
                    PayerName: f1099OID.Payer.PayerName,
                    PayerIdentificationNumber: f1099OID.Payer.PayerIdentificationNumber
                },
                Form: f1099OID.Form
            };
        }
        else {
            F1099OIDPersistData = {
                Form1099OIDId: form1099OIDId,
                OriginalIssueDiscount: GetZeroOnIsNullOrEmpty($("#txtOriginalIssueDiscount").val()),
                OtherPeriodicInterest: GetZeroOnIsNullOrEmpty($("#txtOtherPeriodicInterest").val()),
                EarlyWithdrawalPenalty: $("#txtEarlyWithdrawalPenalty").val(),
                FederalTaxWithHoldingAmount: GetZeroOnIsNullOrEmpty($("#txtFederalTaxWithHoldingAmount").val()),
                Description: $("#txtDescription").val(),
                USTreasuryObligations: GetZeroOnIsNullOrEmpty($("#txtUSTreasuryObligations").val()),
                InvestmentExpenses: GetZeroOnIsNullOrEmpty($("#txtInvestmentExpenses").val()),
                AccountNumber: $("#txtAccNo").val(),
                HasToReportTaxExempt: $("#chktaxexempt").prop('checked'),
                HasToReportAdjustment: $("#chkadjustment").prop('checked'),
                TaxExemptInterest: $("#txttaxexempt").val(),
                AdjustmentAmount: $("#txtajusment").val(),
                ForeignTaxPaid: $("#txtForeignTaxPaid").val(),
                ForeignCountryId: $("#ddlForeginCountryID").val(),
                TaxExemptInterestStateId: $("#ddlStateCode3").val(),
                StateExemptInterest: $("#txtstateexempt").val(),
                Form1099StateInfo: [
                        {
                            StateId: $("#ddlStateCodeID").val(),
                            StateIdentificationNumber: $("#txtStateIdentificationNumber").val(),
                            StateTaxWithholdingAmount: GetZeroOnIsNullOrEmpty($("#txtStateTaxWithholdingAmount").val())
                        },

                        {
                            StateId: $("#ddlStateCode2").val(),
                            StateIdentificationNumber: $("#txtPayerStateID").val(),
                            StateTaxWithholdingAmount: GetZeroOnIsNullOrEmpty($("#txtPayerStateWithheld").val())
                        }
                ],
            };
        }
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
                        TaxData: JSON.stringify(F1099OIDPersistData),
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

    function GetZeroOnIsNullOrEmpty(value) {
        if (value == "" || value == null)
            return 0;
        else {
            return value;
        }
    }

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
                if (data != null) {
                    $("#txtOriginalIssueDiscount").val(data.OriginalIssueDiscount),
                    $("#txtOtherPeriodicInterest").val(data.OtherPeriodicInterest),
                    $("#txtEarlyWithdrawalPenalty").val(data.EarlyWithdrawalPenalty),
                    $("#txtFederalTaxWithHoldingAmount").val(data.FederalTaxWithHoldingAmount),
                    $("#txtDescription").val(data.Description),
                    $("#txtUSTreasuryObligations").val(data.USTreasuryObligations),
                    $("#txtInvestmentExpenses").val(data.InvestmentExpenses),
                    $("#chktaxexempt").prop('checked', data.HasToReportTaxExempt),
                    $("#chkadjustment").prop('checked', data.HasToReportAdjustment),
                    $("#txttaxexempt").val(data.TaxExemptInterest),
                    $("#txtajusment").val(data.AdjustmentAmount),
                    $("#txtForeignTaxPaid").val(data.ForeignTaxPaid),
                    $("#ddlForeginCountryID").val(data.ForeignCountryId),
                    $("#txtAccNo").val(data.AccountNumber),
                    $("#ddlStateCode3").val(data.TaxExemptInterestStateId),
                    $("#txtstateexempt").val(data.StateExemptInterest);

                    if (data.Form1099StateInfo != null) {
                        if (data.Form1099StateInfo[0] != null) {
                            $("#ddlStateCodeID").val(data.Form1099StateInfo[0].StateId),
                            $("#txtStateIdentificationNumber").val(data.Form1099StateInfo[0].StateIdentificationNumber),
                            $("#txtStateTaxWithholdingAmount").val(data.Form1099StateInfo[0].StateTaxWithholdingAmount);
                        }

                        if (data.Form1099StateInfo[1] != null) {

                            $("#ddlStateCode2").val(data.Form1099StateInfo[1].StateId),
                            $("#txtPayerStateID").val(data.Form1099StateInfo[1].StateIdentificationNumber),
                            $("#txtPayerStateWithheld").val(data.Form1099StateInfo[1].StateTaxWithholdingAmount);
                        }
                    }
                }
            }

        });
    }
});