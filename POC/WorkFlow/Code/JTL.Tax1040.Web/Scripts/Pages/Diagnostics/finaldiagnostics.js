//29Apr2014, Bala  Added Script file for interest income eligibility diagnostics

var userId;
var userDataId;
var topic;
$(document).ready(function () {

    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    var pageURL = window.location.search.substring(1);
    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('Topic') == 0)
        topic = parameterName[1];


});


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
            "UserDataId": userDataId,
            "Topic": topic
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            $('#lblTitle').html(topic + " Diagnostic");
            $('#lblPanelHead').html(topic + " Diagnostics");

            $.each(data, function (index, value) {
                //Error Message navigation url

                
                var navigateURL = value.MessageTarget + "?" + value.FieldName;
                if (value.FormId != 0) {
                   navigateURL = navigateURL + "&" + value.FormId;
                }
                $("#dvDiagnostics").append('<a href="' + navigateURL + '">"' + value.ErrorText + '</a></br>');
            });
        }
    });

}