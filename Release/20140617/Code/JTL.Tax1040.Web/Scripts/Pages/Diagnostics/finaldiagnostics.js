//29Apr2014, Bala  Added Script file for interest income eligibility diagnostics

var userId;
var userDataId;
var topic;
var tab;
var hasPersonalInfoEligibilityDiagnostics;
var filingStatus =1;
$(document).ready(function () {
    
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    GetQueryStringValue();

    // Hide spouse in left pan if filing status is MFJ
    if (filingStatus == 2) {
        $("#liSpouse").css("display", "inline");
    }

    GetEligibilityDiagnosticsData();

});


function GetLeftMenu() {

    GetQueryStringValue();

    if (tab == 'Personal Info') {
        return '<script type="text/javascript" src="../lib/leftmenu.js"></script>';
    }
    //Yogalakshmi - 17th June 2014 - Changed UnemploymentCompensation to Unemployment Compensation.
    else if (tab == 'Income' || topic == "Wages" || topic == "InterestIncome" || topic == "Unemployment Compensation" || topic == "Other Income") {
        return '<script type="text/javascript" src="../lib/incomeleftmenu.js"></script>';
    }
    else if (tab == 'Credit' || topic == "Earned Income Credit") {
        return '<script type="text/javascript" src="../lib/creditleftmenu.js"></script>';
    }
    else if (tab == 'TaxesAndWrapUp' || topic == "TaxesAndWrapUp") {
        return '<script type="text/javascript" src="../lib/taxesandwrapupleftmenu.js"></script>';
    }
    else if (tab == 'Deduction' || topic == "Deduction") {
        return '<script type="text/javascript" src="../lib/deductionleftmenu.js"></script>';
    }
}

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

    //27May2014 - Added by Ashok for Diagnostic Heading on Tab or Topic availability
    if (topic != null) {
        $('#lblTitle').html(topic + " Diagnostic");
        $('#lblPanelHead').html(topic + " Diagnostics");
    }
    else if (tab != null) {
        $('#lblTitle').html(tab + " Diagnostic");
        $('#lblPanelHead').html(tab + " Diagnostics");
        tab = tab.replace(/\s/g, ''); 
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