//Added for UpdateSecurityQuestion Script
$(document).ready(function () {
    //validate updatesecurityquestion form on keyup and submit
    $("#updatesecurityquestion").validate({
        rules: {
            ddlSecurityQuestion: {
                required: true,

            },
            txtSecurityAnswer: {
                required: true,
                minlength: 8,
                maxlength: 15
            },
            txtPasswordForSecurityQuestion: {
                required: true,
                minlength: 8,
                maxlength: 15
            }

        },
        messages: {
            ddlSecurityQuestion: {
                required: "Security Question should not be Empty",
            },
            txtSecurityAnswer: {
                required: "Security Answer should not be Empty",
                minlength: "Your Security Answer must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "Your Security Answer must have 8 to 15 characters inclusive of one number and one special character"
            },
            txtPasswordForSecurityQuestion: {
                required: "Password should not be Empty",
                minlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character"
            }

        }

    });

    $("#ddlSecuriyQuestion").ready(function () {
        $.ajax({
            url: serviceUrl + 'user/getsecurityquestion',
            async: false,
            dataType: "json",
            type: "GET",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                for (var key in data) {
                    $("#ddlSecurityQuestion").append($("<option></option>").val(key).html(data[key]));
                }
            }
        });
    });
});
//UpdateSecurityQuestion
function UpdateSecurityQuestion() {
    if ($('#updatesecurityquestion').valid()) {
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
                "Password": $("#txtPasswordForSecurityQuestion").val(),
                "SecurityQuestionId": $("#ddlSecurityQuestion").val(),
                "SecurityAnswer": $("#txtSecurityAnswer").val()

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
                    $("#divValidationMsg").html("The Security Question and Answer has been updated successfully.");

                }
            }
        });
        return false;

    }
}