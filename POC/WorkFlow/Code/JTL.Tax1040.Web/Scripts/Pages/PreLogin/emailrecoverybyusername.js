$("#lblEmailID").ready(function () {
    $("#lblEmailID").html(window.sessionStorage.getItem("EmailId"));
});

function ResendEmailForForgotUserName() {
    var status = false;
    $.ajax({
        url: serviceUrl + 'user/resendemailforforgotusername',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            // Get User Name and email id from session.
            "Email": window.sessionStorage.getItem("EmailId"),
            "UserName": window.sessionStorage.getItem("UserName")
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data == false) {
                $("#divErrorMsg").show();
                $("#divErrorMsg").html("Email has not been resend. Please resend again to your email address.");
            } else {
                status = true;
                $("#divErrorMsg").show();
                $("#divErrorMsg").html("Email has been resend.");
            }
        }
    });
    return status;
}