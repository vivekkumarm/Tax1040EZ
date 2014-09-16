//Left Memu Controls.

document.write("<div id='incomeleftmenu' class='menu' role='navigation'>" +
    "<div class='collapse navbar-collapse' id='lftmenu'>" +
    "<ul id='nav' class='nav side-nav'>" +
    "<li id='aW2Summary'> <a href='../Income/w2summary.html'><i class='fa fa-exchange'></i>Wages</a></li>" +
    "<li id='aInterestIncomeSummary'> <a href='../Income/interestincomesummary.html'><i class='fa fa-user'></i>Interest Income</a></li>" +
    "<li id='aunemploymentSummary'><a href='../Income/unemploymentsummary.html'><i class='fa fa-users'></i>Unemployment </a></li>" +
    "<li id='aOtherIncomeSummary'><a href='../Income/otherincomesummary.html'><i class='fa fa-suitcase'></i>Other Income </a></li>" +
    "<li id='aIncomeSummary'><a href='../Income/incomesummary.html'><i class='fa fa-th-list'></i>Income Summary</a></li>" +
    "</ul>" +
     "</div>" +
    "</div>");


var tab = Tab.Income; // 18Jun2014 Sathish replaced hard coded value with the constant
var topic;
var hasWagesEligibilityDiagnostics;
var hasInterestIncomeEligibilityDiagnostics;
var hasUnemploymentCompensationEligibilityDiagnostics;
var hasOtherIncomeEligibilityDiagnostics;
$(document).ready(
    function () {

        //Yogalakshmi - 7th July 2014 - Defect fix for TAX1040-14130
        //Yogalakshmi - 9th July 2014 - Converting the pathname form upper case to lowercase using toLowerCase() method.
        var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();
        //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
           if (selectedSection == "finalsummary") {
            var pageURL = window.location.search.substring(1);
            var parameterName = pageURL.split('=');
            if (parameterName.toString().indexOf('Topic') == 0)
                topic = parameterName[1];
            switch (topic) {
                case 'PrimaryFiler':
                    $('#aW2Summary').attr('style', 'display:none');
                    $('#aInterestIncomeSummary').attr('style', 'display:none');
                    $('#aunemploymentSummary').attr('style', 'display:none');
                    $('#aOtherIncomeSummary').attr('style', 'display:none');
                    $('#aIncomeSummary').attr('style', 'display:none');
                    break;
                default:
            }
        }
        else {
            switch (selectedSection) {
                //Wages
                case 'w2summary':
                    $('#aW2Summary').addClass('active');
                    break;
                case 'w2employmentandownertype':
                    $('#aW2Summary').addClass('active');
                    break;
                case 'w2':
                    $('#aW2Summary').addClass('active');
                    break;
                //Income Interest
                case 'interestincomesummary':
                    $('#aInterestIncomeSummary').addClass('active');
                    break;
                case 'interestincome':
                    $('#aInterestIncomeSummary').addClass('active');
                    break;
                case 'interestincomechecklist':
                    $('#aInterestIncomeSummary').addClass('active');
                    break;
                case 'f1099int':
                    $('#aInterestIncomeSummary').addClass('active');
                    break;
                case 'f1099oid':
                    $('#aInterestIncomeSummary').addClass('active');
                    break;
                //Unemployment
                case 'unemploymentsummary':
                    $('#aunemploymentSummary').addClass('active');
                    break;
                case 'unemployment':
                    $('#aunemploymentSummary').addClass('active');
                    break;
                //Other Income
                case 'otherincomesummary':
                    $('#aOtherIncomeSummary').addClass('active');
                    break;
                case 'otherincome':
                    $('#aOtherIncomeSummary').addClass('active');
                    break;
                case 'otherincomegateway':
                    $('#aOtherIncomeSummary').addClass('active');
                    break;
                case 'incomesummary':
                    $('#aIncomeSummary').addClass('active');
                    break;
                default:
            }
        }


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
                        // 20Jun2014 Sathish replaced hard coded value with the constant
                        if ((value.Topic == Topic.Wages) && (value.MessageType == MessageType.ER)) {
                            hasWagesEligibilityDiagnostics = true;
                        }
                        if ((value.Topic == Topic.InterestIncome) && (value.MessageType == MessageType.ER)) {
                            hasInterestIncomeEligibilityDiagnostics = true;
                        }
                        if ((value.Topic == Topic.UnemploymentCompensation) && (value.MessageType == MessageType.ER)) {
                            hasUnemploymentCompensationEligibilityDiagnostics = true;
                        }
                        if ((value.Topic == Topic.OtherIncome) && (value.MessageType == MessageType.ER)) {
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
            $("#aIncomeSummary").css("display", "none");
        }
        else if (hasInterestIncomeEligibilityDiagnostics) {
            $("#aunemploymentSummary").css("display", "none");
            $("#aOtherIncomeSummary").css("display", "none");
            $("#aIncomeSummary").css("display", "none");
        }
        else if (hasUnemploymentCompensationEligibilityDiagnostics) {
            $("#aOtherIncomeSummary").css("display", "none");
            $("#aIncomeSummary").css("display", "none");
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
        error: function (jqXHR, textStatus, errorThrown) {
            alert(jqXHR + "-" + textStatus + "-" + errorThrown);
        },
        success: function (data, textStatus) {
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

