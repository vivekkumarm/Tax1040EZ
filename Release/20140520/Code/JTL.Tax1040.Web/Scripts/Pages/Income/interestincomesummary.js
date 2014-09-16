//7 Apr 2014 Added a Script for interest income summary
//Vincent - 16th April 2014- added a error message navigation for required user control.
//Sathish - 02May2014 Changed unemployment functionality
var InterestIncomeF1099INT;
var InterestIncomeF1099OID;
var form1099OIDId;
var form1099INTId;
var userId;
var userDataId;
//Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
var isUnemploymentHasValue, isOtherIncomeHasValue;

$(document).ready(function () {
    //Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
    GetIncomeGatewayForInterestIncome();

    if (isUnemploymentHasValue) {
        $('#btnContinue').click("click", (function () { window.location.href = '../Income/unemployment.html'; }));
    }
    else if (isOtherIncomeHasValue) {
        $('#btnContinue').click(function () { window.location.href = '../Income/otherincome.html'; });
    }
    else {
        $('#btnContinue').click(function () { window.location.href = '../Income/incomesummary.html'; });
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
});


function InterestGetData() {
    $.ajax({
        url: serviceUrl + 'F1099INT/GetTaxReturn1099INTListandErrorList',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId

        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            var payerName;
            $("#InterestIncomeSummary").empty();
            $.each(data.m_Item1, function (index, value) {
                payerName = '';
                if (value.Form1099INTId != 0) {

                    var ownerName = "";
                    if (value.OwnerType == "1") {
                        //PrimaryTaxPayer
                        ownerName = data.m_Item3;
                    } else if (value.OwnerType == "2") {
                        //Spouse
                        ownerName = data.m_Item4;
                    } else {
                        //OwnerType not MFJ.
                        ownerName = data.m_Item5;
                    }
                    InterestIncomeF1099INT = value.InterestIncome + value.USBondsTreasury;

                    if (value.Payer != null)
                        payerName = value.Payer.PayerName;

                    $("#InterestIncomeSummary").append('<div class="pangird itm"><label class="col-md-4">' + payerName + '</label>' +
                                                        '<label class="col-md-3">' + payerName + '</label>' +
                                                        '<label class="col-md-3">' + InterestIncomeF1099INT + '</label>' +
                                                        '<label class="col-md-2">' +
                                                            '<a class="fa fa-edit" href="../Income/interestincome.html?Form1099INTId=' + value.Form1099INTId + '" title="Edit" "></a>' +
                                                            '<a href="#" title="Delete" onclick="DeleteINT(' + value.Form1099INTId + ');return false;" class="fa fa-minus-square-o"></a>' +
                                                        '</label></div>');
                }

            });

            $.each(data.m_Item2, function (index, value) {
                var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId + "&FormINT";
                $("#dvDiagnostics").append('<a href="' + navigateURL + '">"' + value.ErrorText + '</label></br>');
            });
        }
    });

    $.ajax({
        url: serviceUrl + 'InterestIncome/GetTaxReturn1099OIDListandErrorList',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#OIDSummary").empty();
            var payerName;
            $.each(data.m_Item1, function (index, value) {
                payerName = '';
                if (value.Form1099OIDId != 0) {

                    var ownerName = "";
                    if (value.OwnerType == "1") {
                        //PrimaryTaxPayer
                        ownerName = data.m_Item3;
                    } else if (value.OwnerType == "2") {
                        //Spouse
                        ownerName = data.m_Item4;
                    } else {
                        //OwnerType not MFJ.
                        ownerName = data.m_Item5;
                    }

                    InterestIncomeF1099OID = value.OriginalIssueDiscount + value.OtherPeriodicInterest + value.USTreasuryObligations - value.AdjustmentAmount

                    if (value.Payer != null)
                        payerName = value.Payer.PayerName;

                    $("#OIDSummary").append('<div class="pangird itm"><label class="col-md-4">' + payerName + '</label>' +
                                                     '<label class="col-md-3">' + payerName + '</label>' +
                                                     '<label class="col-md-3">' + InterestIncomeF1099OID + '</label>' +
                                                     '<label class="col-md-2">' +
                                                         '<a class="fa fa-edit" href="../Income/interestincome.html?Form1099INTId=' + value.Form1099OIDId + '" title="Edit" "></a>' +
                                                         '<a href="#" title="Delete" onclick="DeleteOID(' + value.Form1099OIDId + ');return false;" class="fa fa-minus-square-o"></a>' +
                                                     '</label></div>');
                }

            });


            $.each(data.m_Item2, function (index, value) {
                //Error Message navigation url
                var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId + "&FormOID";

                $("#dvDiagnostics").append('<label> <a href="../Income/f1099int.html "></a> ' + value.ErrorText + '</label><br />');
            });


        }
    });
}

//Saravanan N - 9th May, 2014 - FormId name altered in data param.
function DeleteOID(OIDId) {
    if (confirm("Are you sure you want to Delete ?")) {
        $.ajax({
            url: serviceUrl + 'InterestIncome/deleteform1099OIDbyid',
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "userId": userId,
                "userDataId": userDataId,
                "FormId": OIDId
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },

            success: function (data, textStatus) {
                InterestGetData();
            }
        });
    }
}

function DeleteINT(INTId) {
    if (confirm("Are you sure you want to Delete ?")) {
        $.ajax({
            url: serviceUrl + 'F1099INT/deleteform1099INTbyid',
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "userId": userId,
                "userDataId": userDataId,
                "Form1099INTId": INTId
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                InterestGetData();
            }
        });
    }
}

//Saravanan N - 29th April, 2014 - As per IncomeGateway selected options Continue button's navigation will be decided here.
function GetIncomeGatewayForInterestIncome() {
    $.ajax({
        url: serviceUrl + 'incomegateway/getincomegatewaydata',
        async: false,
        dataType: 'json',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId
        }),
        type: 'POST',
        contentType: 'application/json',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                //Store the values into local variables.
                isUnemploymentHasValue = data.m_Item3;
                isOtherIncomeHasValue = data.m_Item4;
            }
        }
    });
}