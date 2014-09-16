//29Apr2014, Bala  Added Script file for interest income eligibility diagnostics

var userId;
var userDataId;
var topic;
var tab;
var hasPersonalInfoEligibilityDiagnostics;
var filingStatus = 1;
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
    // 20Jun2014 Sathish replaced hard coded value with the constant
    if (tab == Tab.PersonalInfo) {
        return '<script type="text/javascript" src="../lib/leftmenu.js"></script>';
    }
        //Yogalakshmi - 17th June 2014 - Changed UnemploymentCompensation to Unemployment Compensation.
        //18Jun2014 Sathish removed hard coded value and used constants
    else if (tab == Tab.Income || topic == Topic.Wages || topic == Topic.InterestIncome || topic == Topic.UnemploymentCompensation || topic == Topic.OtherIncome) {
        return '<script type="text/javascript" src="../lib/incomeleftmenu.js"></script>';
    }
    else if (tab == Tab.Credit || topic == Topic.EarnedIncomeCredit) {
        return '<script type="text/javascript" src="../lib/creditleftmenu.js"></script>';
    }
    else if (tab == Tab.TaxesAndWrapUp || topic == Topic.TaxesAndWrapUp) {
        return '<script type="text/javascript" src="../lib/taxesandwrapupleftmenu.js"></script>';
    }
    else if (tab == Tab.Deduction || topic == Topic.Deduction) {
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
        // Swapnesh Added for multibrowser browser (23-06-2014)
        tab = tab.replace("%20", " ");

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

            if (data != null && data.m_Item2 != null) {
                if (data.m_Item2.length > 0) {
                    $.each(data.m_Item2, function (index, value) {
                        //Error Message navigation url
                        var navigateURL = value.MessageTarget + "?" + value.FieldName;
                        if (value.FormId != 0) {
                            navigateURL = navigateURL + "&" + value.FormId;
                        }
                        $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');

                        //27May2014 - Added by Ashok for left menu visible/hide on Eligibility errors availability
                        //18Jun2014 Sathish removed hard coded value and used constant
                        if ((value.Tab == Tab.PersonalInfo) && (value.MessageType == MessageType.ER)) {
                            hasPersonalInfoEligibilityDiagnostics = true;
                        }
                        if (hasPersonalInfoEligibilityDiagnostics) {
                            // 19Jun2014 Sathish commented the below code to avoid hiding spouse info while clicking diagnostics.
                            // $("#liDiagnostics").css("display", "inline");
                            //   $("#lipersonalSummary").css("display", "none");
                            //if (filingStatus == 2)
                            //    $("#liSpouse").css("display", "inline");
                        }
                    });
                }
                    //27Jun2014 Sathish will be redirected to apporiate summary page if no diagnotics
                else {
                    if (topic == Topic.Address || topic == Topic.FilingStatus || topic == Topic.PrimaryFiler || topic == Topic.Spouse) {
                        window.location.href = "../PersonalInfo/personalsummary.html";
                    }
                    else if (topic == Topic.InterestIncome || topic == Topic.FormINT) {
                        window.location.href = "../Income/interestincomesummary.html";
                    }
                    else if (topic == Topic.Wages) {
                        window.location.href = "../Income/w2summary.html";
                    }
                    else if (topic == Topic.OtherIncome || topic == Topic.FormOID
                        || topic == Topic.Alaska || topic == Topic.SSBRRB || topic == Topic.Statelocal) {
                        window.location.href = "../Income/otherincomesummary.html";
                    }
                    else if (topic == Topic.UnemploymentCompensation) {
                        window.location.href = "../Income/unemploymentsummary.html";
                    }
                    else if (topic == Topic.EarnedIncomeCredit) {
                        window.location.href = "../Credits/creditsummary.html";
                    }
                    else if (topic == Topic.TaxesAndWrapUp) {
                        window.location.href = "../TaxesAndWrapUp/federaltaxsummary.html";
                    }
                }

            }
        }
    });

}