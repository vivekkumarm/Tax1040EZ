document.write("<div id='incomeleftmenu' class='menu' role='navigation'>" +
    "<ul class='nav  side-nav'>" +
    "<li><a id='aW2Summary' href='../Income/w2summary.html'><i class='fa fa-exchange'></i>Wages</a></li>" +
    "<li><a id='aInterestIncomeSummary' href='../Income/interestincomesummary.html'><i class='fa fa-user'></i>Interest Income</a></li>" +
    "<li><a id='aunemploymentSummary' href='../Income/unemploymentsummary.html'><i class='fa fa-users'></i>UnEmployment </a></li>" +
    "<li><a id='aOtherIncomeSummary' href='../Income/otherincomesummary.html'><i class='fa fa-users'></i>Other Income </a></li>" +
    "</ul>" +
    "</div>");


var tab = "Income";
var topic;
var hasWagesEligibilityDiagnostics;
var hasInterestIncomeEligibilityDiagnostics;
var hasUnemploymentCompensationEligibilityDiagnostics;
var hasOtherIncomeEligibilityDiagnostics;
$(document).ready(
    function ()
    {
        GetIncomeGatewayData();

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
                    $.each(data.m_Item2, function (index, value) {
                        if ((value.Topic == 'Wages') && (value.MessageType == 'ER')) {
                            hasWagesEligibilityDiagnostics = true;
                        }
                        if ((value.Topic == 'InterestIncome') && (value.MessageType == 'ER')) {
                            hasInterestIncomeEligibilityDiagnostics = true;
                        }
                        if ((value.Topic == 'Unemployment Compensation') && (value.MessageType == 'ER')) {
                            hasUnemploymentCompensationEligibilityDiagnostics = true;
                        }
                        if ((value.Topic == 'Other Income') && (value.MessageType == 'ER')) {
                            hasOtherIncomeEligibilityDiagnostics = true;
                        }
                    });

                }
            }
        });

        if (hasWagesEligibilityDiagnostics) {
            $("#aInterestIncomeSummary").css("display", "none");
            $("#aunemploymentSummary").css("display", "none");
            $("#aOtherIncomeSummary").css("display", "none");
        }
        else if (hasInterestIncomeEligibilityDiagnostics) {
            $("#aunemploymentSummary").css("display", "none");
            $("#aOtherIncomeSummary").css("display", "none");
        }
        else if (hasUnemploymentCompensationEligibilityDiagnostics) {
            $("#aOtherIncomeSummary").css("display", "none");
        }
    });

function GetIncomeGatewayData() {
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
        error: function(jqXHR, textStatus, errorThrown) {
            alert(jqXHR + "-" + textStatus + "-" + errorThrown);
        },
        success: function(data, textStatus) {
            if (data != null) {
                //Store the values into local variables.
                var isW2HasValue, isInterestIncomeHasValue, isUnemploymentHasValue, isOtherIncomeHasValue;
                isW2HasValue = data.HasW2Wages;
                isInterestIncomeHasValue = data.HasInterestIncome;
                isUnemploymentHasValue = data.HasUnemploymentCompensation;
                isOtherIncomeHasValue = data.HasOtherIncome;

                (isW2HasValue == true ? $('aW2Summary').attr('style', 'display:inline') : $('#aW2Summary').attr('style', 'display:none'));
                (isInterestIncomeHasValue == true ? $('aInterestIncomeSummary').attr('style', 'display:inline') : $('#aInterestIncomeSummary').attr('style', 'display:none'));
                (isUnemploymentHasValue == true ? $('aunemploymentSummary').attr('style', 'display:inline') : $('#aunemploymentSummary').attr('style', 'display:none'));
                (isOtherIncomeHasValue == true ? $('aOtherIncomeSummary').attr('style', 'display:inline') : $('#aOtherIncomeSummary').attr('style', 'display:none'));

            }
        }
    });
}

