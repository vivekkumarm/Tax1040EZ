// validate signup form on keyup and submit
$(document).ready(function () {
    $("#forgotusername").validate({
        rules: {
            txtEmailAddress: {
                required: true
            }
        },
        messages: {
            txtEmailAddress: {
                required: "Email Address is missing."
            }

        }
    });
    $(function () {
        $("#popEmail").popover({ title: '', content: "<h5>Why do we need your Email Address?</h5>This is how we authorize your account and communicate with you.<br/><br/> Help us drop in credentials reset mailer, offers and important alerts to the right inbox.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

});

function GetUserNameByEmail() {
    var isValidUser = false;
    if ($("#forgotusername").valid()) {
        $.ajax({
            url: serviceUrl + 'user/getusernamebyemail',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "Email": $("#txtEmailAddress").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == false) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").html("Email Address is Invalid.");
                }
                else {
                    isValidUser = true;
                    $("#divValidationMsg").hide();
                    //alert('success');
                    window.sessionStorage.setItem("EmailId", $("#txtEmailAddress").val());
                    window.sessionStorage.setItem("UserName", data);
                    setTimeout(function () {
                        window.location.href = '../PreLogin/emailrecoverybyusername.html';
                    });
                }
            }
        });
    }
    return isValidUser;
}