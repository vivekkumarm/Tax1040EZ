﻿//7 Apr 2014 Added a Script for interest income summary
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

        //On Continue button click navigate to the page.
        window.location.href = pageToNavigate;
        return false;
    });

    //Added by Ashok - Clearing session data
    window.sessionStorage.Form1099INTId = 0;
    window.sessionStorage.Form1099OIDId = 0;
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

                                if (value.Payer != null)
                                    payerName = value.Payer.PayerName.trim().length == 0 ? NOT_SPECIFIED_TEXT : value.Payer.PayerName;

                                $("#dvInterestIncomeSummary").append('<div class="pangird itm"><label class="col-md-4">' + payerName + '</label>' +
                                                                    '<label class="col-md-3">' + value.RecipientName + '</label>' +
                                                                    '<label class="col-md-3">' + interestIncomeF1099INT + '</label>' +
                                                                    '<label class="col-md-2">' +
                                                                    '<a class="fa fa-edit" href="../Income/interestincome.html?Form1099INTId=' +
                                                                    value.Form1099INTId + '" title="Edit" "></a>' +
                                                                    '<a href="#" title="Delete" onclick="DeleteINT(' +
                                                                    value.Form1099INTId + ');return false;" class="fa fa-minus-square-o"></a>' +
                                                                    '</label></div>');

                                //Total interest income
                                interestIncomeAmount = interestIncomeAmount + interestIncomeF1099INT;
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

                                if (value.Payer != null)
                                    payerName = value.Payer.PayerName.trim().length == 0 ? NOT_SPECIFIED_TEXT : value.Payer.PayerName;

                                $("#dvInterestIncomeSummary").append('<div class="pangird itm"><label class="col-md-4">' + payerName + '</label>' +
                                                                 '<label class="col-md-3">' + value.RecipientName + '</label>' +
                                                                 '<label class="col-md-3">' + interestIncomeF1099OID + '</label>' +
                                                                 '<label class="col-md-2">' +
                                                                     '<a class="fa fa-edit" href="../Income/interestincome.html?Form1099OIDId=' +
                                                                     value.Form1099OIDId + '" title="Edit" "></a>' +
                                                                     '<a href="#" title="Delete" onclick="DeleteOID(' + value.Form1099OIDId +
                                                                     ');return false;" class="fa fa-minus-square-o"></a>' +
                                                                 '</label></div>');

                                //Total interest income
                                interestIncomeAmount = interestIncomeAmount + interestIncomeF1099OID;
                            }
                        });

                        
                    }
                }
                //Total Interest income
                $("#spnTotalInterestIncome").html('$ ' + interestIncomeAmount);
                

                if (hasRecords) {
                    $("#dvInterestIncomeSummary").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                           '</span>');
                }

                //Diagnostic Page
                $("#dvDiagnostics").empty();
                $("#divDiagnosticsParent").hide();

                if (data.m_Item2 != null) {
                    //Loop over InterIncome Error List.
                    var errorKnt = data.m_Item2.length;
                    if (errorKnt > 0) {
                        $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                        $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                        $("#divDiagnosticsParent").show();

                        $.each(data.m_Item2, function (index, value) {
                            var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId + "&" + value.Topic;
                            $("#dvDiagnostics").append('<a href=' + navigateURL + '>' + value.ErrorText + '.</a>');
                        });
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