//Added for UpdateSecurityQuestion Script
$(document).ready(function () {
    //validate updatesecurityquestion form on keyup and submit
    $("#updatesecurityquestion").validate({
        rules: {
            ddlSecurityQuestion: {
                required: true

            },
            txtSecurityAnswer: {
                required: true,
                //minlength: 8,
                maxlength: 30
            },
            txtPasswordForSecurityQuestion: {
                required: true
            }

        },
        messages: {
            ddlSecurityQuestion: {
                required: "Security Question Missing"
            },
            txtSecurityAnswer: {
                required: "Answer for the question is Missing"
                //minlength: "Your Security Answer must have 8 to 15 characters inclusive of one number and one special character",
                //maxlength: "Your Security Answer "
            },
            txtPasswordForSecurityQuestion: {
                required: "Missing Password"
            }

        }

    });

    //Added by Thileep 04July 2014
    $("#txtSecurityAnswer").keyup(function () {
        $("#divValidationMsg").hide();
    });

    $("#txtPasswordForSecurityQuestion").keyup(function () {
        $("#divValidationMsg").hide();
    });
    //17July 2014 Thileep Added for hide Validation message when Enter values in control
    $("#ddlSecurityQuestion").change(function () {
        $("#divValidationMsg").hide();
    });

    $("#ddlSecuriyQuestion").ready(function () {
        $.ajax({
            url: serviceUrl + 'user/getsecurityquestion',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                UserId: userId,
            }),
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
                //for (var key in data) {
                //    $("#ddlSecurityQuestion").append($("<option></option>").val(key).html(data[key]));
                //}

                for (var key in data.m_Item1) {
                    $("#ddlSecurityQuestion").append($("<option></option>").val(key).html(data.m_Item1[key]));
                }
                $("#ddlSecurityQuestion").val(data.m_Item2);

            }
        });
    });

    //Quick help added by prasana on 24Jun2014
    //Quickhelp Message content changed 17July 2014 By Thileep
    $(function () {
        $("#popSecurityQuestion").popover({ title: '', content: "<h5>Wanna update your security question?</h5>Choose a question you wish to answer from this list to make it happen.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityAnswer").popover({ title: '', content: "<h5>What is 'Security Answer'?</h5>This is nothing but, the secret answer you gave for the Security Question you selected.  <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: '', content: "<h5>What is your Password? </h5>This is a secret string of characters you chose to secure your Tax Garden account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                if (data.m_Item1 == 4) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html("Invalid Password");
                } else if (data.m_Item1 == 0) {
                    $("#divValidationMsg").show();
                    //Changed div color for sucess message by prasana on 25.06.2014
                    $("#divValidationMsg").removeClass('error-alert').addClass('alert alert-success');
                    $("#divValidationMsg").html("The Security Question and Answer has been updated successfully.");
                    $("#txtSecurityAnswer").val("");
                    $("#txtPasswordForSecurityQuestion").val("");

                }
            }
        });
        return false;

    }
}