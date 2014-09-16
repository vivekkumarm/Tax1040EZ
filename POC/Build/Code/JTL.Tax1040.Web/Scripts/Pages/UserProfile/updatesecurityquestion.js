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
                //minlength: 8,
                maxlength: 30
            },
            txtPasswordForSecurityQuestion: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true
            }

        },
        messages: {
            ddlSecurityQuestion: {
                required: "Security Question Missing",
            },
            txtSecurityAnswer: {
                required: "Answer for the question is Missing",
                //minlength: "Your Security Answer must have 8 to 15 characters inclusive of one number and one special character",
                 //maxlength: "Your Security Answer "
            },
            txtPasswordForSecurityQuestion: {
                required: "Missing Password",
                minlength: "Invalid Password",
                maxlength: "Invalid Password",
                passwordvalidation: "Invalid Password"
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
            //Added by prasana on 25.06.2014 for adding default select option
                $("#ddlSecurityQuestion").append($("<option></option>").val('').html('---Select---'));
                for (var key in data) {
                    $("#ddlSecurityQuestion").append($("<option></option>").val(key).html(data[key]));
                }
            }
        });
    });

    //Quick help added by prasana on 24Jun2014
    $(function () {
        $("#popSecurityQuestion").popover({ title: '', content: "<h5>Security Question</h5>Please select anyone of the security question from the dropdown.  Security Question is used to reset your Password, or to retrieve your forgotten Username.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityAnswer").popover({ title: '', content: "<h5>Security Answer</h5>Specify the correct answer to your security question. By answering the correct answer to your question, you can reset your forgotten password and username. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: '', content: "<h5>Password</h5>Passwords are case sensitive,should contain more than 8 characters. You can use combination of letters,symbols, and numbers for creating your password.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                //Changed by Thileep 26june2014
                if (data.m_Item1== 4) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html("Invalid Password");
                } else if (data.m_Item1 == 0) {
                    $("#divValidationMsg").show();
                    //Changed div color for sucess message by prasana on 25.06.2014
                    $("#divValidationMsg").removeClass('error-alert').addClass('alert alert-success');
                    $("#divValidationMsg").html("The Security Question and Answer has been updated successfully.");

                }
            }
        });
        return false;

    }
}