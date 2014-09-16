//Added for Update Email Script

$(document).ready(function () {
    //validate updateemail form on keyup and submit
    $("#updateemail").validate({
        rules: {
            txtRetypeEmailid: {
                required: true,
                email: true
            },
            txtPasswordForEmail: {
                required: true,
                minlength: 8,
                maxlength: 15
            }

        },
        messages: {
            txtRetypeEmailid: {
                required: "Email Address should not be Empty",
                email: "You have entered invalid Email Address. Please enter a valid Email Address"
            },
            txtPasswordForEmail: {
                required: "Password should not be Empty",
                minlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character"
            }

        }

    }),

    $.ajax({
        url: serviceUrl + 'user/getuserdetailsbyuserid',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify
            ({
                "UserId": userId

            }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $('#lblUserNameVal').html(data.UserName);
            $('#lblEmailIdVal').html(data.Email);

        }
    });

});

//UpdateEmailId
function UpdateEmailId() {
    if ($('#updateemail').valid()) {
        $.ajax({
            url: serviceUrl + 'user/validatepasswordbyuserid',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "UserId": userId,
                "Email": $("#txtRetypeEmailid").val(),
                "Password": $("#txtPasswordForEmail").val()
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == 3) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").html("The Password entered is Incorrect. Please confirm your entry.");
                } else if (data == 0) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").html("The EmailId has been updated successfully.");
                }
                else if (data == 1) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").html("The EmailId Already Exist.");
                }
            }
        });
        return false;

    }

}