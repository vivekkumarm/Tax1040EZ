//Added for Update Password Script

$(document).ready(function () {
    //validate updatepassword form on keyup and submit
    $("#updatepassword").validate({
        rules: {
            txtNewPassword: {
                required: true,
                minlength: 8,
                maxlength: 15
            },
            txtConirmPassword: {
                required: true,
                equalTo: "#txtNewPassword"
            }

        },
        messages: {
            txtNewPassword: {
                required: "New Password should not be Empty",
                minlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character"
            },
            txtConirmPassword: {
                required: "Confirm Password should not be Empty",
                equalTo: "Your Password and Confirm Password must be same"
            }
        }
    });
});

//Updatepassword
function UpdatePassword() {
    if ($('#updatepassword').valid()) {
        $.ajax({
            url: serviceUrl + 'user/updateuserdetailsbyuserid',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify(
                {
                    "UserId": userId,
                    "Password": $("#txtNewPassword").val()

                }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == 0) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").html("The Password  has been updated successfully.");
                }
            }
        });
        return false;

    }
}