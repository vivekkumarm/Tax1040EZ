// validate signup form on keyup and submit
$(document).ready(function () {
    var email;

    //$.validator.addMethod("usernamevalidation", function (value, element) {
    //    return this.optional(element) || /^\w{6,64}$/.test(value);
    //}, 'Your Username must have atleast 6 Characters which includes alphabets, numbers and underscore.');


    $('#chkEmail').click(function () {
        if ($(this).is(":checked")) {
            $('#txtUserName').val($("#txtEmail").val());
            $('#txtUserName').focus();
            $(this).focus();
        }
        else {
            $('#txtUserName').val("");
        }
    });

    $.validator.addMethod("usernameandpasswordsamevalidation", function (value, element) {
        if (($('#txtUserName').val().toLowerCase() == $('#txtPassword').val().toLowerCase())) {//Changed By Thileep on 11July 2014
            return this.optional(element) || false;
        }
        else {

            return this.optional(element) || true;

        }

    }, '');


    if (jQuery.validator != null) {
        jQuery.validator.addMethod("usernamevalidation",
          function (value, element) {
              var isValid = false;
              if ($("#txtUserName").val() != '' && $("#txtUserName").val() == $("#txtEmail").val()) {
                  return true;
              }
              return this.optional(element) || /^\w{6,64}$/.test(value);
          }, 'Your Username must have atleast 6 Characters which includes alphabets, numbers and underscore.'
          );

        //Added by vivek for the validation on 27-jun-14 for Defect TAX1040-14058
        jQuery.validator.addMethod("method",
         function (value, element) {
             if ($('#chkEmail').is(':checked')) {
                 return this.optional(element) || /^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$/.test(value);
             }
             else {
                 return {
                     method: true,
                     minlength: 6,
                     maxlength: 100,
                     usernamevalidation: true

                 }
             }
         }, "You have entered invalid Email Address. Please enter a valid Email Address."
         );
    }


    //17July 2014 Thileep Added for hide Validation message when Enter values in controls
    $("#txtEmail").keyup(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });
    $("#txtUserName").keyup(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });
    $("#txtPassword").keyup(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });
    $("#txtConfirmPassword").keyup(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });
    $("#txtSecurityAnswer").keyup(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });
    $("#txtSecurityAnswer").keyup(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });
    $("#ddlSecurityQuestion").change(function () {
        if (event.keyCode != 13) {
            $("#divSignUpValidation").hide();
        }
    });


    //Modified by prasana on 11.07.2014 changed error message display from txtUserName to txtEmail
    $("#registration").validate({

        rules: {
            txtEmail: {
                required: true,
                method: true,
                email: true
            },
            txtUserName: {
                required: true,
                minlength: 6,
                maxlength: 100,
                usernamevalidation: true
            },
            txtPassword: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true,
                usernameandpasswordsamevalidation: true
            },
            txtConfirmPassword: {
                required: true,
                equalTo: "#txtPassword"
            },
            txtSecurityAnswer: {
                required: true,
            },
            chkTermsofServices: {
                required: true
            },
            ddlSecurityQuestion: {
                required: true
            },
        },
        messages: {
            txtEmail: {
                required: "Email Address is missing.",
                method: "Email Address is Invalid.",
                email: "Email Address is Invalid."
            },
            txtUserName: {
                minlength: "Your Username must have at least 6 Characters which may include alphabets, numbers and underscore.",
                required: "Username is missing.",
                usernamevalidation: "Your Username must have at least 6 Characters which may include alphabets, numbers and underscore."
            },
            txtPassword: {
                minlength: "Password must have 8 to 15 characters with at least one alphabet, one number, and one special character.",
                maxlength: "Password must have 8 to 15 characters with at least one alphabet, one number, and one special character.",
                required: "Password is missing.",
                passwordvalidation: "Password must have 8 to 15 characters with at least one alphabet, one number, and one special character.",
                usernameandpasswordsamevalidation: "Your Username and Password should not be same."

            },
            txtConfirmPassword: {
                equalTo: "Password and Confirm Password must be same",
                required: "Password confirmation is missing."

            },

            txtSecurityAnswer: {
                required: "Answer for Security Question is missing."
            },
            chkTermsofServices:
                {
                    required: "</br>To use our services, you must agree to Terms of Service.</br>"
                },
            ddlSecurityQuestion:
                {
                    required: "Security question is not selected."
                }
        }
    });

    $(function () {
        //TermsofServices Popup Removed By Thileep As per PreloginSpec(V1.9) on 16July2014
        $("#popEmail").popover({ title: 'Email Address', html: 'true', content: "<h5>Why do we need your Email Address?</h5>We mainly use your Email Address to communicate to you and drop in your credentials reset mailer, offers and other important alerts.<br/><br/> Worried about receiving unwanted mailers? We don’t share your Email Address with anyone. <hr /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popUserName").popover({ title: 'Username', html: 'true', content: "<h5>How to choose your Username?</h5>Use at least 6 characters and try keeping it unique.<br/><br/>You may throw in numbers, alphabets and underscore if you like to.  Username is your identity and also a credential.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: 'Password', html: 'true', content: "<h5>How to choose your Password?</h5> Come up with a secret combination to secure your Tax Garden account.<br/><br/> Make sure to throw in at least one alphabet, one number, and one special character.<br/><br/> Use at least 8 characters and try keeping it hard for the hackers.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConfirmPassword").popover({ title: 'Confirm Password', html: 'true', content: "<h5>Why should you retype the Password?</h5>How would you check if what you had planned to type is what you did?<br/><br/> Simple! Retype it here and see for yourself. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityQuestion").popover({ title: 'Security Question', html: 'true', content: "<h5>Why do we ask for a Security Question?</h5>Help us add another level of security to your TaxGarden account.<br/><br/> Your Security Question also comes handy when you want to reset your forgotten credentials.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityAnswer").popover({ title: 'Security Answer', html: 'true', content: "<h5>Why should you answer the Security Question?</h5>Giving the right answer to your Secret Question, is as important as remembering your password.<br/><br/> This will help you regain access to your account when needed and serves as an additional layer of security.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

    //25 Aug 2014- Bala- For removing setTimeOut function 
    $('#cmdSubmit').click(function () {

        if (RegisterUser()) {
            sessionStorage.setItem('isRegistered', true);
            window.location.href = '../Login.html';
        }
        return false;
    });

});

function username() {
    $('#chkEmail').prop('checked', false);

    if ($("#txtUserName").val() != '' && $("#txtUserName").val() == $("#txtEmail").val()) {
        $('#chkEmail').prop('checked', true);
    }

}
$("#ddlSecurityQuestion").ready(function () {
    $.ajax({
        url: serviceUrl + 'user/getsecurityquestion',
        async: false,
        dataType: "json",
        type: "POST",
        data: JSON.stringify({
            UserId: 0,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlSecurityQuestion").append($("<option></option>").val('').html('---Select---'));
            for (var key in data.m_Item1) {
                $("#ddlSecurityQuestion").append($("<option></option>").val(key).html(data.m_Item1[key]));
            }
        }
    });
});

function RegisterUser() {
    var isRegistered = false;
    if ($("#registration").valid()) {
        $.ajax({
            url: serviceUrl + 'user/create',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "Email": $("#txtEmail").val(),
                "UserName": $("#txtUserName").val(),
                "Password": $("#txtPassword").val(),
                "SecurityQuestionId": $("#ddlSecurityQuestion").val(),
                "SecurityAnswer": $("#txtSecurityAnswer").val(),
                "IsActive": $("#chkTerms").val(),
                "SecurityQuestion": $("#ddlSecurityQuestion option:selected").text(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data.message.length > 0) {
                    for (var i = 0; i < data.message.length; i++) {
                        $("#divSignUpValidation").html(data.message[i]);
                        $("#divSignUpValidation").show();
                    }
                }
                else {
                    isRegistered = true;
                }
            }
        });
    }
    return isRegistered;


}




