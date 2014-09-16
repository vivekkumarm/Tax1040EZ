//7 Apr 2014 added the script for Interest Income
//Script for Interest Income
//Vincent - 16th April 2014- added a error message navigation for required user control.
//Sathish - 2May2014  Added TaxReturnData for PersistTaxReturnForm1099INTData

var F1099INTPersistData, F1099OIDPersistData, f1099INT, f1099OID;
var currentForm1099INTId = 0;
var currentForm1099OIDId = 0;
var form1099OIDId;
var form1099INTId;
var userId;
var userDataId;
var form1099OIDId;
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
                //$('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
                //$('#' + divToExpand).addClass('panel-collapse collapse in');
                $('#' + controlToFocus).focus();
            }
        }
            //Form Type OID
        else if (FormType.toString() == 'FormOID') {

            form1099OIDId = parameters[1];
            var controls = controlParmeters.split('-')
            if (controls.length == 2) {

                var divToExpand = controls[0];
                var controlToFocus = controls[1];
                //$('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
                //$('#' + divToExpand).addClass('panel-collapse collapse in');
                $('#' + controlToFocus).focus();
            }


        }
    }


    if (!window.sessionStorage.Form1099OIDId) {
        form1099OIDId = 0;
    } else {
        form1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
    }

    if (!window.sessionStorage.Form1099INTId) {
        form1099INTId = 0;
    } else {
        form1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
    }

    //Get query method
    GetQueryStringData();

    //Validation
    //$("#InterestIncome").validate({
    //    rules: {
    //        rdInterestIncomeSelect: "required",
    //        payerName: "required"
    //    },
    //    messages: {
    //        rdInterestIncomeSelect: "Missing Taxpayer or Spouse Code.",
    //        payerName: "Payer Name Should not be Empty."

    //    }
    //});

    //Nagivation Pages Method

    $('#btnSubmit').click(function () {
        //Vincent - 08th Mar, 2014 - As per Interest Income selected, next page will be decided.
        if ($("#InterestIncome").valid()) {

            var INTIncome = $("#rad1099INT").prop('checked');
            var OIDIncome = $("#rad1099OID").prop('checked');

            if (INTIncome == true) {

                PersistF1099INT();
                window.location.href = '../Income/f1099int.html';
            }
            if (OIDIncome == true) {
                PersistF1099OID();
                window.location.href = '../Income/f1099oid.html';
            }
        }
        return false;

    });

    //Nagivation Pages Method for Back.
    $('#btnBack').click(function () {
        //Vincent- 14th Mar, 2014 - As per Interest Income selected, next page(back button) will be decided.


        var INTIncome = $("#rad1099INT").prop('checked');
        var OIDIncome = $("#rad1099OID").prop('checked');

        if (INTIncome == true) {

            PersistF1099INT();

        }
        else (OIDIncome == true)
        {
            PersistF1099OID();
            window.location.href = '../Income/interestincomesummary.html';
        }
        window.location.href = '../Income/interestincomesummary.html';
        return false;

    });

    $(function () {
        $("#popPayerName").popover({ title: '', content: "<h5>PayerName</h5><br />Full Name of the tax payer./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerEIN").popover({ title: '', content: "<h5>City</h5><br /> Unique 9 digit identification number assigned by IRS for an individual for identification purposes. You can find the digits of EIN in the format as XX-XXXXXXX /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });


});



//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
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
                alert(jqXHR + "-" + textStatus + "-" + errorThrown);
            },
            success: function (data, textStatus) {
                if (data != null) {
                    f1099INT = data;
                }
            }
        });

        if (f1099INT != null) {
            F1099INTPersistData = {
                Form1099INTId: f1099INT.Form1099INTId,
                InterestIncome: f1099INT.InterestIncome,
                FederalTaxWithHoldingAmount: f1099INT.FederalTaxWithHoldingAmount,
                USBondsTreasury: f1099INT.USBondsTreasury,
                EarlyWithdrawalPenalty: f1099INT.EarlyWithdrawalPenalty,
                InvestmentExpenses: f1099INT.InvestmentExpenses,
                ForeignTaxPaid: f1099INT.ForeignTaxPaid,
                ForeignCountryId: f1099INT.ForeignCountryId,
                TaxExemptInterest: f1099INT.TaxExemptInterest,
                SpecifiedPrivateActivityBond: f1099INT.SpecifiedPrivateActivityBond,
                AccountNumber: f1099INT.AccountNumber,
                Form1099StateInfo: f1099INT.Form1099StateInfo,
                Owner: $('input:radio[name=rdInterestIncomeSelect]:checked').val(),
                Payer: {
                    PayerName: $("#txtpayername").val(),
                    PayerIdentificationNumber: $("#txtpayerEIN").val()
                },
                Form: $('input:radio[name=radioIncome]:checked').val()
            };
        }
        else {
            F1099INTPersistData = {
                Form1099INTId: form1099INTId,
                Form: $('input:radio[name=radioIncome]:checked').val(),
                Owner: $('input:radio[name=rdInterestIncomeSelect]:checked').val(),
                Payer: {
                    PayerName: $("#txtpayername").val(),
                    PayerIdentificationNumber: $("#txtpayerEIN").val()
                },
                Form: $('input:radio[name=radioIncome]:checked').val()
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


function GetQueryStringData() {

    if (fromSummary == false) {

        var sPageURL = window.location.search.substring(1);
        var sParameterName = sPageURL.split('=');

        if (sParameterName[0].toString() == 'Form1099INTId') {
            if (sParameterName.toString().indexOf('Form1099INTId') == 0) {
                currentForm1099INTId = sParameterName[1];
                F1099INTGetData();
            } else {

                //TODO: Get the value from session storage. 
                currentForm1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
            }

        }
        else if (sParameterName[0].toString() == 'Form1099OIDId') {
            if (sParameterName.toString().indexOf('Form1099OIDId') == 0) {
                currentForm1099OIDId = sParameterName[1];
                F1099OIDGetData();
            } else {
                //TODO: Get the value from session storage. 

                currentForm1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
            }

        }
    }
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
            "FormId": currentForm1099INTId,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                f1099INT = data;
                if (data.Payer != null) {
                    $("#txtpayername").val(data.Payer.PayerName),
                    $("#txtpayerEIN").val(data.Payer.PayerIdentificationNumber)
                }
                $("input[name=radioIncome][value=" + data.Form + "]").prop('checked', true);
                $("input[name=rdInterestIncomeSelect][value=" + data.Owner + "]").prop('checked', true);

                //Pre-PageLogic
                if (data.FilingStatus == 2) {
                    $("#divWhoseInterest").css("display", "inline");
                }
            }
        }
    });
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

    if ((f1099OID != null) && (f1099OID.Payer != null || f1099OID.Owner != null || f1099OID.Form != null)) {
        F1099OIDPersistData = {
            Form1099OIDId: form1099OIDId,
            OriginalIssueDiscount: f1099OID.OriginalIssueDiscount,
            OtherPeriodicInterest: f1099OID.OtherPeriodicInterest,
            EarlyWithdrawalPenalty: f1099OID.EarlyWithdrawalPenalty,
            FederalTaxWithHoldingAmount: f1099OID.FederalTaxWithHoldingAmount,
            Description: f1099OID.Description,
            USTreasuryObligations: f1099OID.USTreasuryObligations,
            InvestmentExpenses: f1099OID.InvestmentExpenses,
            AccountNumber: f1099OID.AccountNumber,
            IsReportYourTaxExempt: f1099OID.IsReportYourTaxExempt,
            IsReportYourAdjustment: f1099OID.IsReportYourAdjustment,
            TaxExemptInterest: f1099OID.TaxExemptInterest,
            AdjustmentAmount: f1099OID.AdjustmentAmount,
            ForeignTaxPaid: f1099OID.ForeignTaxPaid,
            ForeignCountryId: f1099OID.ForeignCountryId,
            TaxExemptInterestStateId: f1099OID.TaxExemptInterestStateId,
            StateExemptInterest: f1099OID.StateExemptInterest,
            Form1099StateInfo: f1099OID.Form1099StateInfo,
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
            Form: $('input:radio[name=radioIncome]:checked').val(),
            Owner: $('input:radio[name=rdInterestIncomeSelect]:checked').val(),
            Payer: {
                PayerName: $("#txtpayername").val(),
                PayerIdentificationNumber: $("#txtpayerEIN").val()
            },
            Form: $('input:radio[name=radioIncome]:checked').val()
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
            "FormId": currentForm1099OIDId

        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                f1099OID = data;
                if (data.Payer != null) {
                    $("#txtpayername").val(data.Payer.PayerName),
                    $("#txtpayerEIN").val(data.Payer.PayerIdentificationNumber)
                }
                $("input[name=radioIncome][value=" + data.Form + "]").prop('checked', true);
                $("input[name=rdInterestIncomeSelect][value=" + data.Owner + "]").prop('checked', true);

                if (data.FilingStatus == 2) {
                    $("#divWhoseInterest").css("display", "inline");
                }
            }
        }

    });
}


