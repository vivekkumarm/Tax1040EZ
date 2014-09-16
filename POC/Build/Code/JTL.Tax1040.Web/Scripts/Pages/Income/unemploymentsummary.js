
// **** Saravanan N - 8th April, 2014 - File contains javascript methods required for UnemploymentSummary.html page.****//

/********************************* MODIFICATION HISTORY SECTION **********************************/
// Saravanan N. - 9th April, 2014 - Global Variable declaration. It can be used in all the below functions.
// Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
// Sathish N 02May2014 Changed delete functionality
// Saravanan N - 7th May, 2014 - UserDTO implemented in ajax call. P3 logic changes implemented.
//Ashok Kumar 29 May 2014- Made changes on handling navigation based on Income Gateway selection
//Vincent-2 Jun May2014-Made a changes in Page Navigation and Reload method if it is delete.


/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var isOtherIncomeHasValue, otherIncomeCount;
var hasIncomeEligibilityDiagnostics = false;// 17Jun2014 Sathish used to check eligibility check in continue click

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);
    //Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
    GetIncomeGatewayDataForUnemploymentSummary();

    $('#btnContinue').click(function () {
        var pageToNavigate;
        // 17Jun2014 Sathish redirected to finaldiagnostics if it has eligibility rule
        if (hasIncomeEligibilityDiagnostics) {
            pageToNavigate = '../Diagnostics/finaldiagnostics.html?Topic=' + Topic.UnemploymentCompensation;  // 20Jun2014 Sathish replaced hard coded value with the constant
        }
        else {
            if (isOtherIncomeHasValue) {
                if (otherIncomeCount > 0) {
                    pageToNavigate = 'otherincomesummary.html';
                }
                else {
                    pageToNavigate = 'otherincomegateway.html';
                }
            }
            else
                pageToNavigate = '../Income/incomesummary.html';

        }
        //On Continue button click navigate to the page.
        window.location.href = pageToNavigate;
        return false;
    });

    //if (isOtherIncomeHasValue) {
    //    $('#btnContinue').click(function () { window.location.href = '../Income/otherincome.html'; return false; });
    //}
    //else {
    //    $('#btnContinue').click(function () { window.location.href = '../Income/incomesummary.html'; return false; });
    //}

    //Saravanan N - 7th May, 2014 - Code moved from html page.
    $('#aAddNew').click(function () {
        AddNewUnemployment();
        return false;
    })

    //Saravanan N - 7th May, 2014 - Code moved from html page.
    GetAllUnemployment();

    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
        return false;
    });
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
            //Yogalakshmi - 22nd May 2014 - Changed the name of the div
            $("#dvUnemploymentSummary").empty();
            //Yogalakshmi - 16th June 2014 - Initializes the value when no records are in the grid.
            var hasRecords = false;
            //Yogalakshmi - 22nd May 2014 - Null Check
            if (data != null) {
                if (data.m_Item1.length > 0) {
                    $.each(data.m_Item1, function (index, value) {
                        //Yogalakshmi - 16th June 2014 - Initializes the value when records are in the grid.
                        hasRecords = true;
                        if (value.Form1099GId != 0) { //Saravanan N - It is not necessary to show this record.
                            var editRedirectLink = "../Income/unemployment.html?Form1099GId=" + value.Form1099GId;
                            var payerName = value.Payer.PayerName.trim().length > 0 ? value.Payer.PayerName : "Not Specified";
                            var unempCompensation = value.UnEmploymentCompensation > 0 ? value.UnEmploymentCompensation : 0;
                            //Yogalakshmi - 29th May 2014 - Null check for TaxPayerName
                            var taxPayerName = value.TaxPayerName != null ? value.TaxPayerName : "";

                            //Yogalakshmi - 16th June 2014 - Check for negative value.
                            var totalUnempCompensation = 0;
                            if (unempCompensation != "undefined") {
                                if (unempCompensation >= 0) {
                                    totalUnempCompensation = unempCompensation;
                                }
                            }

                            //Yogalakshmi - 22nd May 2014 - Changed the name of the div
                            //Defect TAX1040-13977 - Vivek - toFixed(2) added to round off to 2 digits in summary.
                            $("#dvUnemploymentSummary").append('<div class="pangird itm">' +
                                '<label class="col-md-4">' + payerName + '</label>' +
                                '<input type="hidden" id="hdnForm1099gId' + value.Form1099GId + '" value="' + value.Form1099GId + '"/>' +
                                '<label class="col-md-3">' + taxPayerName + '</label>' +
                                '<label class="col-md-3">' + totalUnempCompensation.toFixed(2) + '</label>' +
                                '<label class="col-md-2"><a href="' + editRedirectLink + '" title="Edit" class="fa fa-edit"></a><a href="#" title="Delete" onclick="DeleteUnEmployment(' + value.Form1099GId + ');return false;" class="fa fa-minus-square-o"></a></label></div>');

                        }
                    });
                }
                //Yogalakshmi - 16th June 2014 - Displays message when no records are binded in the grid.
                if (hasRecords == false) {
                    $("#dvUnemploymentSummary").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                           '</span>');
                }

                //Display Diagnostics.
                $("#dvDiagnostics").empty();  //Saravanan N - 8th May, 2014 - Clear the error messages while DELETE.
                $("#divDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.
                if (data.m_Item2 != null) {
                    // * 17Jun2014 Sathish Changed code for eligible navigation
                    var errorKnt = 0;
                    if (data.m_Item2.length > 0) {
                        $.each(data.m_Item2, function (index, value) {
                            if (value.MessageType == MessageType.ER) {
                                hasIncomeEligibilityDiagnostics = true;
                            }
                            else {
                                //Error Message navigation url
                                errorKnt += 1;
                                var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId;
                                $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');
                            }
                        });
                        if (errorKnt > 0) {
                            $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                            $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                            $("#divDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.
                        }

                    }
                }

                var summaryTotal = data.m_Item3 != null ? data.m_Item3 : 0;

                //Saravanan N - 7th May, 2014 - Display Total Unemployment Received. Added $ sign and space.
                //Defect TAX1040-13977 - Vivek - Amount rounded.
                //Defect TAX1040 - 13986 - Saravanan N - If negative values comes, display 0.
                //Yogalakshmi - 16th June 2014 - To round off the unemployment summary Total and not to allow negative value.
                var unemploymentsummaryTotal = 0;
                if (summaryTotal != "undefined") {
                    if (summaryTotal >= 0) {
                        unemploymentsummaryTotal = summaryTotal;
                    }
                }
                var value = Math.round(unemploymentsummaryTotal);
                //vivek 18-June-14 Added the Currency formate
                $('#spanTotalUnempReceived').html("$ " + currencyformate(value));
            }
        }
    });
};

function DeleteUnEmployment(unEmploymentId) {
    if (confirm("Are You Sure You want to delete the selected Form?")) {
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
                location.reload(true);
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
                isOtherIncomeHasValue = data.HasOtherIncome;
                otherIncomeCount = data.OtherIncomeCount;
            }
        }
    });
}


