$(document).ready(function () {
    $("#PasswordResetCode").validate({
        rules: {
            txtPassworResetCode: "required"
        },
        messages: {
            txtPassworResetCode: "Secret Code should not be Empty"

        }
    });

    $(function () {
        $("#popPassworResetCode").popover({ title: '', content: "<h5>Password Resed Code</h5>Enter the Password resed code that you received in email to access your account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
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
                    $("#divErrorMsg").html("You have entered the Invalid Secret Code. Please enter the valid Secret Code sent to your Email address.");
                } else {
                    isUserExist = true;
                    $("#divErrorMsg").hide();
                    setTimeout(function () {
                        window.sessionStorage.setItem('PrePage', '1');
                        window.location.href = '../PreLogin/createpassword.html';
                    });
                }
            }
        });
    }
    return isUserExist;
}

function ResendEmailForForgotPassword() {

    $.ajax({
        url: serviceUrl + 'user/resendemailforforgotpassword',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
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
                $("#divErrorMsg").html("Email has not been resend. Please resend again to your email address.");
            } else {
                status = true;
                $("#divErrorMsg").show();
                $("#divErrorMsg").html("Your Reset code has been sent  successfully through email");

            }
        }
    });

}