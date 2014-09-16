﻿//Added for Update Password Script

$(document).ready(function () {
      

    //validate updatepassword form on keyup and submit
    //Modified by prasana for adding validations 24Jun2014
    //Modified long error message to short error message on 25.06.2014
    $("#updatepassword").validate({
        rules: {
            txtNewPassword: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true
            },
            txtConirmPassword: {
                required: true,
                equalTo: "#txtNewPassword",
                passwordvalidation: true
            }

        },
        messages: {
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

    //Quick help added by prasana on 24Jun2014
    $(function () {
        $("#popNewPassword").popover({ title: '', content: "<h5>Password</h5>Passwords are case sensitive,should contain more than 8 characters. You can use combination of letters,symbols, and numbers for creating your password.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConirmPassword").popover({ title: '', content: "<h5>Confirm Password</h5>Confirm Password should match the exact characters entered in password field.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

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
                //Changed by Thileep 26june2014
                if (data.m_Item1 == 0) {
                    $("#divValidationMsg").show();
                    //Changed div color for sucess message by prasana on 25.06.2014
                    $("#divValidationMsg").removeClass('error-alert').addClass('alert alert-success');
                    $("#divValidationMsg").html("The Password  has been updated successfully.");
                }
                else if (data.m_Item1 == 3) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html(dat.m_Item2);
                }
            }
        });
        return false;

    }
}