$(document).ready(function () {
    $("#lblEmailID").html(window.sessionStorage.getItem("EmailId"));
    $("#lblEmailID1").html(window.sessionStorage.getItem("EmailId"));//Added by Thileep for bind email id 26June2014
});

function ResendEmailForForgotUserName() {
    var status = false;
    $.ajax({
        url: serviceUrl + 'user/resendemailforforgotusername',
        async: false,
        dataType: "json",
        type: "POST",
        //beforeSend: function (request) {
        //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        //},
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
                $("#divErrorMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for Error message color 27June2014
                $("#divErrorMsg").html("Email has not been resend. Please resend again to your email address.");
            } else {
                status = true;
                $("#divErrorMsg").show();
                $("#divErrorMsg").removeClass('error-alert').addClass('alert alert-success');//Added by Thileep for Error message color 27June2014
                $("#divErrorMsg").html("Resent the email successfully. Check your Email.");//Message Changed by thileep on 26 jun2014
                $("#divEmailResent").show();//Added by thileep to show resent email on 20jun2014
                $("#divSentEmail").hide();//Added by thileep to show resent email on 20jun2014

            }
        }
    });
    return status;
}