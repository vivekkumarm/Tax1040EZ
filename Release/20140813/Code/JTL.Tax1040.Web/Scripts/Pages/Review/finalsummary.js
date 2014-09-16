//Vincent-12/6/2014-Add a Script for Final Summary
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var userId;
var userDataId;
var hasEligibilityErrorMessage = false;
var hasErrorAndOmission = false;
var hasWarningErrorMessage = false;
var hasInformationalErrorMessage = false;
var hasEarnedIncomeCredits = false; /// 05Aug2014 Sathish Get Has Earned income credit not to show Credit error message in review.


//Thileep Added variables on 09july2014
var topic;
var tab;
var hasPersonalInfoEligibilityDiagnostics;
var filingStatus = 1;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    var pageURL = window.location.search.substring(1);

    ////15Jul2014 Sathish Persist user feature
    PersistUserFeature();
    if (userDataId != 0) {
        userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    }
    GetQueryStringValue();

    GetHasEarnedIncomeCredits();/// 05Aug2014 Sathish Get Has Earned income credit not to show Credit error message in review.

    GetEligibilityDiagnosticsData();
    //Yogalakshmi - 25th June 2014 - Navigation for back button
    $('#btnBack').click(function () {
        GoToPreviousPage();
        //window.location.href = '../Sample/worksheet.html';
        return false;
    });

    $('#btnContinue').click(function () {
        //Screen Navigation #1
        if (hasEligibilityErrorMessage) {
            //On-Page #O1
            window.location.href = '../Review/noteligibilityfor1040EZ.html';
            return false;
        }
        else if (hasErrorAndOmission) {
            //Screen Navigation #2
            //On-Page #O2
            window.location.href = '../Review/efilerejection.html';
            return false;
        }
        //Yogalakshmi - 11th August 2014 - Navigate to tax accuracy page when there is no Eligibility error and other validations error.
        else {
            window.location.href = '../Review/taxaccuracyguarantee.html';
            return false;
        }
    });



});
/*************************************** COMMON FUNCTIONS SECTION *********************************/

//Thileep Added the Method on 09july2014
function GetLeftMenu() {

    GetQueryStringValue();
    // 20Jun2014 Sathish replaced hard coded value with the constant
    if (tab != undefined) {
        if (tab == Tab.PersonalInfo) {
            return '<script type="text/javascript" src="../lib/leftmenu.js"></script>';
        }
            //Yogalakshmi - 17th June 2014 - Changed UnemploymentCompensation to Unemployment Compensation.
            //18Jun2014 Sathish removed hard coded value and used constants
        else if (tab == Tab.Income || topic == Topic.Wages || topic == Topic.InterestIncome || topic == Topic.UnemploymentCompensation || topic == Topic.OtherIncome && tab != undefined) {
            return '<script type="text/javascript" src="../lib/incomeleftmenu.js"></script>';
        }
        else if (tab == Tab.Credits || topic == Topic.EarnedIncomeCredit) {
            return '<script type="text/javascript" src="../lib/creditleftmenu.js"></script>';
        }
        else if (tab == Tab.TaxesAndWrapUp || topic == Topic.TaxesAndWrapUp) {
            return '<script type="text/javascript" src="../lib/taxesandwrapupleftmenu.js"></script>';
        }
        else if (tab == Tab.Deduction || topic == Topic.Deduction) {
            return '<script type="text/javascript" src="../lib/deductionleftmenu.js"></script>';
        }
    }
    else {
        return '<script type="text/javascript" src="../lib/reviewleftmenu.js"></script>';
    }
}

/// 05Aug2014 Sathish Get Has Earned income credit not to show Credit error message in review.
function GetHasEarnedIncomeCredits() {
    $.ajax({
        url: serviceUrl + 'earnedincomecredit/gethasearnedincomecredits',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId

        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            hasEarnedIncomeCredits = data;
        }
    });
}

//Thileep Added the Method on 09july2014
function GetQueryStringValue() {
    //11Jun2014 Sathish changed to get filling status to show or hide spouse
    var pageURL = window.location.search.substring(1);
    var parameters = pageURL.split('&');
    if (parameters.length == 2) {
        var parameterName = parameters[0].split('=');
        if (parameterName.toString().indexOf('Topic') == 0)
            topic = parameterName[1];
        else if (parameterName.toString().indexOf('Tab') == 0)
            tab = parameterName[1];

        paramFilingStatus = parameters[1].split('=');
        if (paramFilingStatus.toString().indexOf('FilingStatus') == 0) {
            filingStatus = paramFilingStatus[1];
        }

    }
    else {
        var parameterName = pageURL.split('=');
        if (parameterName.toString().indexOf('Topic') == 0)
            topic = parameterName[1];
        else if (parameterName.toString().indexOf('Tab') == 0)
            tab = parameterName[1];
    }
}

function GetEligibilityDiagnosticsData() {


    $.ajax({
        url: serviceUrl + 'taxreturn/geteligibilitydiagnosticserrorlist',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId

        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {


            if (data != null) {

                $('#dvNoErrorDiagonstic').hide();
                $('#dvWithErrorDiagonstic').hide();
                if (data.m_Item1.length == 0) {
                    //Pre-Logic #P1
                    $('#dvNoErrorDiagonstic').show();

                }
                else {
                    //Pre-Logic #P2
                    $('#dvWithErrorDiagonstic').show();
                }
                if (data.m_Item1 != null) {
                    $('#divDiagnosticsParentEZEligibility').hide();
                    $('#divDiagnosticParentErrorandOmission').hide();
                    $('#divDiagonsticParentWarning').hide();
                    $('#divDiagonsticParentInformation').hide();
                    $('#dvEZEligibility').hide();
                    $('#dvErrorMessage').hide();
                    //14July2014 Commented By Thileep on as per File Spec V1.2
                    //$('#pVerifyAndedit').hide();

                    // 15Jul2014 Sathish filter credits error message based on credits eligibility
                    if (!hasEarnedIncomeCredits) { //if Credits not eligible will remove all the error message associated to credits
                        data.m_Item1 = $.grep(data.m_Item1, function (er) {
                            return er.Tab != Tab.Credits;
                        });
                    }
                    //else {
                    //    data.m_Item1 = $.grep(data.m_Item1, function (er) {
                    //        return (er.Tab != Tab.Credits) || (er.Tab === Tab.Credits && er.MessageType != MessageType.BR && er.MessageType != MessageType.EI);
                    //    });
                    //}

                    $.each(data.m_Item1, function (index, value) {
                        //Error Message navigation url
                        var navigateURL = value.MessageTarget + "?" + value.FieldName;
                        if (value.FormId != 0) {
                            navigateURL = navigateURL + "&" + value.FormId + "&" + value.Topic;
                        }

                        //EZ Eligibility
                        //Pre-Logic #P4
                        if (value.MessageType == MessageType.ER) {
                            $('#divDiagnosticsParentEZEligibility').show();
                            $('#dvEZEligibility').show();
                            $("#dvDiagnosticsEZEligibility").append('<a href="' + navigateURL + '" class="text-danger"><i class="fa fa-bug"></i> ' + value.ErrorText + '</a><br/><br/>');
                            hasEligibilityErrorMessage = true;
                            //14July2014 Commented By Thileep on as per File Spec V1.2
                            //Pre-Logic #P8
                            //$('#pVerifyAndedit').show();                         

                        }
                            //Error and Omission
                            //Pre-Logic #P5
                        else if (((value.MessageType == MessageType.BR) || (value.MessageType == MessageType.V) || (value.MessageType == MessageType.RF)) && (value.ErrorType == ErrorType.Error)) {
                            $('#divDiagnosticParentErrorandOmission').show();
                            $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');
                            hasErrorAndOmission = true;

                        }
                            //Warning
                            //Pre-Logic #P6
                        else if ((value.ErrorType == 'Warning')) {

                            $('#divDiagonsticParentWarning').show();
                            $("#dvDiagonsticWarning").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');
                            hasWarningErrorMessage = true;

                        }
                            //Information
                            //Pre-Logic #P7
                        else if ((value.ErrorType == 'Information')) {
                            $('#divDiagonsticParentInformation').show();
                            $("#dvDiagonsticInformation").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');
                            hasInformationalErrorMessage = true;
                        }



                    });
                    //Thileep Added the Method for elizibility check on 09july2014
                    if (hasEligibilityErrorMessage) {
                        $('#divDiagnosticsParentEZEligibility').show();
                        $('#divDiagnosticParentErrorandOmission').hide();
                        $('#divDiagonsticParentWarning').hide();
                        $('#divDiagonsticParentInformation').hide();
                        //14July2014 Commented By Thileep on as per File Spec V1.2
                        //$('#btnContinue').hide();

                    }
                    else if (hasErrorAndOmission || hasWarningErrorMessage || hasInformationalErrorMessage) {
                        //Pre-Logic #P3
                        $('#dvErrorMessage').show();
                    }


                }
                else {
                    window.location.href = '../Payment/federalreturnsummary.html';
                    return false;
                }
            }
        }
    });

}

function PersistUserFeature() {

    //15Jul2014 Sathish Persist user feature
    $.ajax({
        url: serviceUrl + 'payment/persistuserfeature',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data);
            //alert('success  Need to redirect to next section');
            //window.location.href = '../Payment/federalreturnsummary.html'; //4-july-14 vivek and redirect to review page
          //  window.location.href = '../Review/finalsummary.html';
            return false;
        }
    });
}