//29Apr2014, Bala  Added Script file for interest income eligibility diagnostics

var userId;
var userDataId;
var topic;
var tab;
var hasPersonalInfoEligibilityDiagnostics;
var filingStatus;
$(document).ready(function () {
    
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    var pageURL = window.location.search.substring(1);
    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('Topic') == 0)
        topic = parameterName[1];
    else if (parameterName.toString().indexOf('Tab') == 0)
        tab = parameterName[1];

    //var paramFilingStatus = pageURL.split('&');
    //if (paramFilingStatus != null) {
    //    paramFilingStatus = paramFilingStatus[1].split('=');
    //    if (paramFilingStatus.toString().indexOf('FilingStatus') == 0) {
    //        filingStatus = paramFilingStatus[1];
    //    }
    //}
});


function GetEligibilityDiagnosticsData() {

    //27May2014 - Added by Ashok for Diagnostic Heading on Tab or Topic availability
    if (topic != null) {
        $('#lblTitle').html(topic + " Diagnostic");
        $('#lblPanelHead').html(topic + " Diagnostics");
    }
    else if (tab != null) {
        $('#lblTitle').html(tab + " Diagnostic");
        $('#lblPanelHead').html(tab + " Diagnostics");
    }

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
            "UserDataId": userDataId,
            "Topic": topic,
            "Tab": tab
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data != null && data.m_Item2 != null)
            {
                $.each(data.m_Item2, function (index, value) {
                    //Error Message navigation url
                    var navigateURL = value.MessageTarget + "?" + value.FieldName;
                    if (value.FormId != 0) {
                        navigateURL = navigateURL + "&" + value.FormId;
                    }
                    $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');

                    //27May2014 - Added by Ashok for left menu visible/hide on Eligibility errors availability
                    if ((value.Tab == 'PersonalInfo') && (value.MessageType == 'ER')) {
                        hasPersonalInfoEligibilityDiagnostics = true;
                    }
                    if (hasPersonalInfoEligibilityDiagnostics) {
                        $("#liDiagnostics").css("display", "inline");
                        $("#lipersonalSummary").css("display", "none");
                        //if (filingStatus == 2)
                        //    $("#liSpouse").css("display", "inline");
                    }
                });

            }
        }
    });

}