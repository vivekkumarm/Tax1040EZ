//Vincent-12/6/2014-Add a Script for Final Summary
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var userId;
var userDataId;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    var pageURL = window.location.search.substring(1);
    

    GetEligibilityDiagnosticsData();

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
                if (data.m_Item1 == null) {
                    $('#dvNoErrorDiagonstic').show();

                }
                else {

                    $('#dvWithErrorDiagonstic').show();
                }
                if (data.m_Item1 != null) {
                    $('#divDiagnosticsParentEZEligibility').hide();
                    $('#divDiagnosticParentErrorandOmission').hide();
                    $('#divDiagonsticParentWarning').hide();
                    $('#divDiagonsticParentInformation').hide();
                    $('#dvEZEligibility').hide();

                    $.each(data.m_Item1, function (index, value) {
                        //Error Message navigation url
                        var navigateURL = value.MessageTarget + "?" + value.FieldName;
                        if (value.FormId != 0) {
                            navigateURL = navigateURL + "&" + value.FormId;
                        }
                        
                        //EZ Eligibility
                        if (value.MessageType == 'ER') {
                            $('#divDiagnosticsParentEZEligibility').show();
                            $('#dvEZEligibility').show();
                            $("#dvDiagnosticsEZEligibility").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');

                        }
                         //Error and Omission
                        else if (((value.MessageType == 'BR') || (value.MessageType == 'V') || (value.MessageType == 'RF')) && (value.ErrorType == 'Error')) {
                            $('#divDiagnosticParentErrorandOmission').show();
                            $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a><br/>');

                        }
                         //Warning
                        else if ((value.ErrorType == 'Warning')) {

                            $('#divDiagonsticParentWarning').show();
                            $("#dvDiagonsticWarning").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a><br/>');

                        }
                        //Information
                        else if ((value.ErrorType == 'Information')) {
                            $('#divDiagonsticParentInformation').show();
                            $("#dvDiagonsticInformation").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a><br/>');

                        }

                    });

                }
            }
        }
    });

}