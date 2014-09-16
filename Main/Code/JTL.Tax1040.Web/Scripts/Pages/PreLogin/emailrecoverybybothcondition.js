﻿$(document).ready(function () {

    $("#PasswordResetCode").validate({
        rules: {
            txtPassworResetCode: "required"
        },
        messages: {
            txtPassworResetCode: "Secret Code is missing."
        }
    });
    $.ajax({
        url: serviceUrl + 'user/getemailbyuserid',
        async: false,
        dataType: "json",
        type: "POST",
        //beforeSend: function (request) {
        //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        //},
        data: JSON.stringify({
            // Have to get User Name from session
            "UserId": window.sessionStorage.getItem("UserId")
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            $('#lblEmail').html(data);
            $('#lblEmail1').html(data);

        }
    });

    //Thileep Added quickhelp content on 17Jun2014
    //Thileep Changed quickhelp content on 09July2014
    //Vincent-5Aug2014-made a changes in quick help Scenario 
    $(function () {
        $("#popPassworResetCode").popover({ title: 'Quick Help', html: 'true', content: "<h5>Where to find this Secret Code?</h5>We have mailed you the Secret Code.<br/><br/>Just copy paste or type it in here to validate your identity.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
});


function ValidatePasswordResetCode() {
    var isUserExist = false;
    if ($("#PasswordResetCode").valid()) {

        $.ajax({
            url: serviceUrl + 'user/validateuserpasswordresetcode',
            async: false,
            dataType: "json",
            type: "POST",
            //beforeSend: function (request) {
            //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            //},
            data: JSON.stringify({
                // Have to get User Name from session
                "UserId": window.sessionStorage.getItem("UserId"),
                "PasswordResetCode": $("#txtPassworResetCode").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == false) {
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for Error message color 27June2014
                    $("#divErrorMsg").html("You have entered the Invalid Secret Code. Please enter the valid Secret Code sent to your Email address.");
                } else {
                    isUserExist = true;
                    $("#divErrorMsg").hide();
                    setTimeout(function () {
                        window.sessionStorage.setItem('PrePage', '2');
                        window.location.href = '../PreLogin/createpassword.html';
                    });
                }
            }
        });
    }
    return isUserExist;
}

function ResendEmailForForgotUsernamePassword() {
    var status = false;
    $.ajax({
        url: serviceUrl + 'user/resendemailforforgotusernamepassword',
        async: false,
        dataType: "json",
        type: "POST",
        //beforeSend: function (request) {
        //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        //},
        data: JSON.stringify({
            // Have to get User Name from session
            "UserId": window.sessionStorage.getItem("UserId")
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
                $("#divErrorMsg").html("We have resent the Email successfully! Check your inbox.");//Message Changed by thileep on 26 jun2014
                $("#divResentEmail").show();//Added by thileep to show resent email on 20jun2014
                $("#divSentEmail").hide();//Added by thileep to show resent email on 20jun2014
            }
        }
    });
    return status;
}
