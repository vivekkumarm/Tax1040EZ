//Added for Update Username Script

$(document).ready(function () {
    //validate updateusername form on keyup and submit
    $("#updateusername").validate({
        rules: {
            txtRetypeUserName: {
                required: true,
                minlength: 6
            },
            txtPasswordForUsername: {
                required: true,
                minlength: 8,
                maxlength: 15
            }

        },
        messages: {
            txtRetypeUserName: {
                required: "username should not be empty",
                minlength: "your username must have atleast 6 characters which includes alphabets, numbers and underscore."
            },
            txtPasswordForUsername: {
                required: "password should not be empty",
                minlength: "your password must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "your password must have 8 to 15 characters inclusive of one number and one special character"
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

//Updateusername
function UpdateUserName() {
    if ($("#updateusername").valid()) {
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
                "Password": $("#txtPasswordForUsername").val(),
                "UserName": $("#txtRetypeUserName").val(),

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
                    $("#divValidationMsg").html("The Username has been updated successfully.");
                }
                else if (data == 2) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").html("The Username Already Exist.");
                }
            }
        });
        return false;

    }

}