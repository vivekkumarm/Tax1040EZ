//Added for Update Password Script

$(document).ready(function () {
      

    //validate updatepassword form on keyup and submit
    //Modified by prasana for adding validations 24Jun2014
    //Modified long error message to short error message on 25.06.2014
    $("#updatepassword").validate({
        rules: {
            txtOldPassword: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true
            },
            txtNewPassword: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true
            },
            txtConirmPassword: {
                required: true,
                equalTo: "#txtNewPassword"                
            }

        },
        messages: {
            txtOldPassword: {
                required: "Missing Old Password",
                minlength: "Invalid Password",
                maxlength: "Invalid Password",
                passwordvalidation: "Invalid Password"
            },
            txtNewPassword: {
                required: "Missing Password",
                minlength: "Invalid Password",
                maxlength: "Invalid Password",
                passwordvalidation: "Invalid Password"
            },
            txtConirmPassword: {
                required: "Missing Confirm Password",
                equalTo: "Confirm Password and Password does not match"
            }
        }
    });

    //Added by Thileep 04July 2014
    $("#txtNewPassword").keyup(function () {
        $("#divValidationMsg").hide();
    });
    $("#txtConirmPassword").keyup(function () {
        $("#divValidationMsg").hide();
    });
    $("#txtOldPassword").keyup(function () {
        $("#divValidationMsg").hide();
    });

    //Quick help added by prasana on 24Jun2014
    //Quickhelp Message content changed 17July 2014 By Thileep
    $(function () {
        $("#popOldPassword").popover({ title: '', content: "<h5>What is your  Old Password?</h5>Enter the Password that you used  earlier to secure your Tax Garden account. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNewPassword").popover({ title: '', content: "<h5>How to choose a New Password?</h5>This will be your new secret combination to secure your Tax Garden account.<br/><br/>Throw in a minimal of 8 characters, that surely includes at least one alphabet, one number, and one special character. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConirmPassword").popover({ title: '', content: "<h5>Why should you retype the New Password?</h5>Let's be sure of what you planned to use as your New Password is what actually you typed.<br/><br/>Retype your New Password to confirm it. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    });
});

//Updatepassword
function UpdatePassword() {
    if ($('#updatepassword').valid()) {
        $.ajax({
            url: serviceUrl + 'user/validatepasswordbyuserid',//Changed by Thileep 04July2014
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify(
                {
                    "UserId": userId,
                    "Password": $("#txtOldPassword").val(),
                    "NewPassword": $("#txtNewPassword").val()
                }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                //Changed by Thileep 26june2014
                if (data.m_Item1 == 0) {
                    $("#divValidationMsg").show();
                    //Changed div color for sucess message by prasana on 25.06.2014
                    $("#divValidationMsg").removeClass('error-alert').addClass('alert alert-success');
                    $("#divValidationMsg").html("The Password  has been updated successfully.");
                    //Added by Thileep 04July 2014
                    $("#txtOldPassword").val("");
                    $("#txtNewPassword").val("");
                    $("#txtConirmPassword").val("");
                }
                if(data.m_Item1 == 4)
                {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');
                    $("#divValidationMsg").html("Invalid Password");
                }

                else if (data.m_Item1 == 3) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html(data.m_Item2);
                }
            }
        });
        return false;

    }
}