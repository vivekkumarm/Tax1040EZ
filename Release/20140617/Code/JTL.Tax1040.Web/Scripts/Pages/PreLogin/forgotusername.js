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
                required: "Missing Email address"
            }

        }
    });
    $(function () {
        $("#popEmail").popover({ title: '', content: "<h5>Email Address</h5>To restore your username,enter the email address you used for creating your account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                    $("#divValidationMsg").html("Invalid Email ID");
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