//Vincent-12/6/2014-Add a Script for Final Summary
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var userId;
var userDataId;
var hasEligibilityErrorMessage = false;
var hasErrorAndOmission = false;
var hasWarningErrorMessage=false;
var hasInformationalErrorMessage = false;


/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    var pageURL = window.location.search.substring(1);
    

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
        else if (!hasEligibilityErrorMessage && hasErrorAndOmission) {
            //Screen Navigation #2
            //On-Page #O2
            window.location.href = '../Review/efilerejection.html';
            return false;
        } else if (!hasEligibilityErrorMessage && !hasErrorAndOmission) {

            //Screen Navigation #3
            window.location.href = '../Review/taxaccuracyguarantee.html';
            return false;
        }

});

});
/*************************************** COMMON FUNCTIONS SECTION *********************************/

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
                    $('#pVerifyAndedit').hide();

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
                            $("#dvDiagnosticsEZEligibility").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');
                            hasEligibilityErrorMessage = true;
                            //Pre-Logic #P8
                            $('#pVerifyAndedit').show();

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

                    if (hasErrorAndOmission || hasWarningErrorMessage || hasInformationalErrorMessage) {
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