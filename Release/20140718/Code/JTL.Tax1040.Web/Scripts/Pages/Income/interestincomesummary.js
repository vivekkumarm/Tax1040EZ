//7 Apr 2014 Added a Script for interest income summary
//Vincent - 16th April 2014- added a error message navigation for required user control.
//Sathish - 02May2014 Changed unemployment functionality
//Vincent-26May2014Refacored Interest income Summary Page.
//Vincent-28May2014Refacored Interest income Summary Page as required by error message.
//Ashok Kumar 29 May 2014- Made changes on handling navigation based on Income Gateway selection
//Vincent-2 Jun May2014-Made a changes in Page Navigation and Reload method if it is delete.

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/

var interestIncomeF1099INT=0;
var interestIncomeF1099OID=0;
//Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
var isUnemploymentHasValue, isOtherIncomeHasValue;
var  form1099GCount, otherIncomeCount;
var NOT_SPECIFIED_TEXT = 'Not Specified';

var hasEligibility = false; // 17Jun2014 Sathish used to check eligibility check in continue click

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.CurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);
    //InterestIncomeGetAll();
    GetAllInterestIncome();

    //Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.
    GetIncomeGatewayForInterestIncome();

    $('#btnContinue').click(function () {
        var pageToNavigate;
        // 17Jun2014 Sathish redirected to finaldiagnostics if it has eligibility rule
        if (hasEligibility) {
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            pageToNavigate = ' ../Review/finalsummary.html?Topic=InterestIncome';
        }
        else {
            if (isUnemploymentHasValue) {
                if (form1099GCount > 0) {
                    pageToNavigate = 'unemploymentsummary.html';
                }
                else {
                    pageToNavigate = 'Unemployment.html';
                }
            }
            else if (isOtherIncomeHasValue) {
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

    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
        return false;
    });


    //27Jun2014 Sathish Int/Oid Id in session will be cleared only in add. Issue No #TAX1040-14041
    $('#aAddNew').click(function () {
        window.location.href = '../Income/interestincome.html';
        //Added by Ashok - Clearing session data
        window.sessionStorage.Form1099INTId = 0;
        window.sessionStorage.Form1099OIDId = 0;
        return false;
    });
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
function setDefaultValues() {
    $('#currentTaxYear').text(CURRENT_TAX_YEAR);
    $('#currentTaxYear1').text(CURRENT_TAX_YEAR);
}

//Delete FormOID Data
function DeleteOID(formOIDId) {
    DeleteCommonAction('InterestIncome/deleteform1099OIDbyid', formOIDId);
}

//Delete FormINT Data
function DeleteINT(formINTId) {
    DeleteCommonAction('F1099INT/deleteform1099INTbyid', formINTId);
}

//Saravanan N - 28th May, 2014 - Common Delete method created.
function DeleteCommonAction(serviceURLParam, formId) {
    if (confirm("Are you sure you want to delete the selected Form ?")) {
        $.ajax({
            url: serviceUrl + serviceURLParam,
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "userId": userId,
                "userDataId": userDataId,
                "FormId": formId
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

//Vincent- 26 May,2014 - Getting all the Interest income section.
function GetAllInterestIncome()
{
    $.ajax({
        url: serviceUrl + 'InterestIncome/getallinterestincome',
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
            if (data != null) {
                var payerName;
                var interestIncomeAmount = 0;

                $("#dvInterestIncomeSummary").empty();
                var hasRecords = true;
                //Get all FormINT & FormOID Data.
                if (data.m_Item1 != null) {

                    //Display F1099INT record in the Summary  Grid.
                    if (data.m_Item1.Form1099INT != null) {

                        //Loop over Form1099INT list.
                        $.each(data.m_Item1.Form1099INT, function (index, value) {
                            hasRecords = false;
                            payerName = NOT_SPECIFIED_TEXT;
                            if (value.Form1099INTId != 0) {
                                interestIncomeF1099INT = value.InterestIncome + value.USBondsTreasury;
                                //Yogalakshmi - 16th June 2014 - Check for negative value.
                                var totalInterestIncomeF1099INT = 0;
                                if (interestIncomeF1099INT != "undefined") {
                                    if (interestIncomeF1099INT >= 0) {
                                        totalInterestIncomeF1099INT = interestIncomeF1099INT;
                                    }
                                }
                                if (value.Payer != null)
                                    payerName = value.Payer.PayerName.trim().length == 0 ? NOT_SPECIFIED_TEXT : value.Payer.PayerName;
                                //Yogalakshmi - 16th June 2014 - To allow only two digits after decimal.
                                //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                                $("#dvInterestIncomeSummary").append('<div class="pangird itm"><label class="col-md-4">' + payerName + '</label>' +
                                                                    '<label class="col-md-3">' + value.RecipientName + '</label>' +
                                                                    '<label class="col-md-3">' + currencyformate(totalInterestIncomeF1099INT.toFixed(2)) + '</label>' +
                                                                    '<label class="col-md-2">' +
                                                                    '<a class="fa fa-edit" href="../Income/interestincome.html?Form1099INTId=' +
                                                                    value.Form1099INTId + '" title="Edit" "></a>' +
                                                                    '<a href="#" title="Delete" onclick="DeleteINT(' +
                                                                    value.Form1099INTId + ');return false;" class="fa fa-minus-square-o"></a>' +
                                                                    '</label></div>');

                                //Total interest income
                                interestIncomeAmount = interestIncomeAmount + totalInterestIncomeF1099INT;
                            }
                        });
                    }

                    //Display F1099OID record in the Summary  Grid.
                    if (data.m_Item1.Form1099OID != null) {

                        //Loop over Form1099INT list.
                        $.each(data.m_Item1.Form1099OID, function (index, value) {
                            hasRecords = false;
                            payerName = '';
                            if (value.Form1099OIDId != 0) {

                                interestIncomeF1099OID = value.OriginalIssueDiscount + value.OtherPeriodicInterest + value.USTreasuryObligations -
                                    value.AdjustmentAmount;
                                //Yogalakshmi - 16th June 2014 - Check for negative value.
                                var totalInterestIncomeF1099OID = 0;
                                if (interestIncomeF1099OID != "undefined") {
                                    if (interestIncomeF1099OID >= 0) {
                                        totalInterestIncomeF1099OID = interestIncomeF1099OID;
                                    }
                                }
                                if (value.Payer != null)
                                    payerName = value.Payer.PayerName.trim().length == 0 ? NOT_SPECIFIED_TEXT : value.Payer.PayerName;
                                //Yogalakshmi - 16th June 2014 - To allow only two digits after decimal.
                                //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                                $("#dvInterestIncomeSummary").append('<div class="pangird itm"><label class="col-md-4">' + payerName + '</label>' +
                                                                 '<label class="col-md-3">' + value.RecipientName + '</label>' +
                                                                 '<label class="col-md-3">' + currencyformate(totalInterestIncomeF1099OID.toFixed(2)) + '</label>' +
                                                                 '<label class="col-md-2">' +
                                                                     '<a class="fa fa-edit" href="../Income/interestincome.html?Form1099OIDId=' +
                                                                     value.Form1099OIDId + '" title="Edit" "></a>' +
                                                                     '<a href="#" title="Delete" onclick="DeleteOID(' + value.Form1099OIDId +
                                                                     ');return false;" class="fa fa-minus-square-o"></a>' +
                                                                 '</label></div>');

                                //Total interest income
                                interestIncomeAmount = interestIncomeAmount + totalInterestIncomeF1099OID;
                            }
                        });


                    }
                }
                //Total Interest income
                //Yogalakshmi - 16th June 2014 - To round off the interestIncomeAmount and not to allow negative value.
                var finalinterestIncomeAmount = 0;
                if (interestIncomeAmount != "undefined") {
                    if (interestIncomeAmount >= 0) {
                        finalinterestIncomeAmount = interestIncomeAmount;
                    }
                }                
                var value = Math.round(finalinterestIncomeAmount);
                //vivek 18-June-14 Added the Currency formate
                $("#spnTotalInterestIncome").html('$ ' + currencyformate(value));

                if (hasRecords) {
                    $("#dvInterestIncomeSummary").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                           '</span>');
                }

                //Diagnostic Page
                $("#dvDiagnostics").empty();
                $("#divDiagnosticsParent").hide();

                if (data.m_Item2 != null) {
                    // * 17Jun2014 Sathish Changed code for eligible navigation
                    //Loop over InterIncome Error List.
                    //    var errorKnt = data.m_Item2.length;
                    var errorKnt = 0;
                    if (data.m_Item2.length > 0) {
                        //Modified by prasana made changes for displaying error based on the type on 14.07.2014
                        //Modified by prasana added null check for value and changed to Switch case on 15.07.2014
                        $.each(data.m_Item2, function (index, value) {
                            if (value != null) {
                                if ((value.Topic == Topic.InterestIncome) && (value.MessageType == MessageType.ER)) {
                                    hasEligibility = true;
                                }
                                else {
                                    errorKnt += 1;
                                    var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId + "&" + value.Topic;


                                    var errorType = value.ErrorType.trim();
                                    var className = '';

                                    switch (errorType) {
                                        case ErrorType.Error:
                                            className = "dierror";
                                            break;

                                        case ErrorType.Warning:
                                            className = "diwarn";
                                            break;

                                        case ErrorType.Information:
                                            className = "diinfo";
                                            break;
                                    }

                                    //Assign class dynamically based on ErrorType.
                                    $("#dvDiagnostics").append('<a class=' + className + ' href=' + navigateURL + '>' + value.ErrorText + '.</a>');

                                }
                            }
                        });
                        if (errorKnt > 0) {
                            $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                            $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                            $("#divDiagnosticsParent").show();
                        }
                    }
                }
            }
        }
    });
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
                isUnemploymentHasValue = data.HasUnemploymentCompensation;
                isOtherIncomeHasValue = data.HasOtherIncome;
                form1099GCount = data.Form1099GCount;
                otherIncomeCount = data.OtherIncomeCount;
            }
        }
    });
}