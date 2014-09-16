﻿
// **** Saravanan N - 8th April, 2014 - File contains javascript methods required for UnemploymentSummary.html page.****//

/********************************* MODIFICATION HISTORY SECTION **********************************/
// Saravanan N. - 9th April, 2014 - Global Variable declaration. It can be used in all the below functions.
// Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
// Sathish N 02May2014 Changed delete functionality
// Saravanan N - 7th May, 2014 - UserDTO implemented in ajax call. P3 logic changes implemented.

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var isOtherIncomeHasValue;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
    GetIncomeGatewayDataForUnemploymentSummary();

    if (isOtherIncomeHasValue) {
        $('#btnContinue').click(function () { window.location.href = '../Income/otherincome.html'; return false; });
    }
    else {
        $('#btnContinue').click(function () { window.location.href = '../Income/incomesummary.html'; return false; });
    }

    //Saravanan N - 7th May, 2014 - Code moved from html page.
    $('#aAddNew').click(function () {
        AddNewUnemployment();
        return false;
    })

    //Saravanan N - 7th May, 2014 - Code moved from html page.
    GetAllUnemployment();
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
//Saravanan N - 8th April, 2014 - Get all the Form1099G data to display in the Unemployment Summary page grid.
//Vincent - 15th April 2014 - Added a error message navigation Url method.
function GetAllUnemployment() {
    //Ajax call 
    $.ajax({
        url: serviceUrl + 'unemployment/getallunemployment',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#unemploymentSummary").empty();
            if (data.m_Item1.length > 0) {
                $.each(data.m_Item1, function (index, value) {
                    if (value.Form1099GId != 0) { //Saravanan N - It is not necessary to show this record.
                        var editRedirectLink = "../Income/unemployment.html?Form1099GId=" + value.Form1099GId;
                        var payerName = value.Payer.PayerName.trim().length > 0 ? value.Payer.PayerName : "Not Specified";
                        var unempCompensation = value.UnEmploymentCompensation > 0 ? value.UnEmploymentCompensation : 0;
                        $("#unemploymentSummary").append('<div class="pangird itm">' +
                            '<label class="col-md-4">' + payerName + '</label>' +
                            '<input type="hidden" id="hdnForm1099gId' + value.Form1099GId + '" value="' + value.Form1099GId + '"/>' +
                            '<label class="col-md-3">' + value.TaxPayerName + '</label>' +
                            '<label class="col-md-3">' + unempCompensation + '</label>' +
                            '<label class="col-md-2"><a href="' + editRedirectLink + '" title="Edit" class="fa fa-edit"></a><a href="#" title="Delete" onclick="DeleteUnEmployment(' + value.Form1099GId + ');return false;" class="fa fa-minus-square-o"></a></label></div>');

                    }
                });
            }

            //Display Diagnostics.
            $("#dvDiagnostics").empty();  //Saravanan N - 8th May, 2014 - Clear the error messages while DELETE.
            $("#divDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.
            var errorKnt = data.m_Item2.length;
            if (errorKnt > 0) {
                $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                $("#divDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.

                $.each(data.m_Item2, function (index, value) {
                    //Error Message navigation url
                    var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId;
                    $("#dvDiagnostics").append('<a href="' + navigateURL + '">"' + value.ErrorText + '"</a></br>');
                });
            }

            //Saravanan N - 7th May, 2014 - Display Total Unemployment Received.
            $('#spanTotalUnempReceived').html(data.m_Item3);
        }
    });
};

function DeleteUnEmployment(unEmploymentId) {
    if (confirm("Are you sure you want to Delete ?")) {
        $.ajax({
            url: serviceUrl + 'unemployment/deleteunemploymentbyid',
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                UserId: userId,
                UserDataId: userDataId,
                FormId: unEmploymentId
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                GetAllUnemployment();
            }
        });
    }
}

//Saravanan N - 10th April, 2014 - Calling from AddNew button click.
function AddNewUnemployment() {
    window.sessionStorage.setItem("Form1099GId", '0');
    window.location.href = '../Income/unemployment.html';
}

//Saravanan N - 29th April, 2014 - As per IncomeGateway selected options Continue button's navigation will be decided here.
function GetIncomeGatewayDataForUnemploymentSummary() {
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
                isOtherIncomeHasValue = data.m_Item4;
            }
        }
    });
}

