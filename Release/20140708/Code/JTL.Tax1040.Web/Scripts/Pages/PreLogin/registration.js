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
        if (($('#txtUserName').val() == $('#txtPassword').val())) {
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

    $("#registration").validate({

        rules: {
            txtEmail: {
                required: true,
                email: true
            },
            txtUserName: {
                required: true,
                method: true ,
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
                required: "Missing Email Address",
                email: "You have entered invalid Email Address. Please enter a valid Email Address."
            },
            txtUserName: {
                minlength: "Your Username must have atleast 6 Characters which includes alphabets, numbers and underscore.",
                required: "Missing Username",
                usernamevalidation: "Your Username must have atleast 6 Characters which includes alphabets, numbers and underscore." 
            },
            txtPassword: {
                minlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character",
                required: "Missing Password",
                passwordvalidation: "Your Password must have 8 to 15 characters inclusive of one number and one special character.",
                usernameandpasswordsamevalidation: "Your Username and Password should not be same."

            },
            txtConfirmPassword: {
                equalTo: "Your Password and Confirm Password must be same",
                required: "Missing Confirm Password"

            },

            txtSecurityAnswer: {
                required: "Answer for the question is Missing"
            },
            chkTermsofServices:
                {
                    required: "</br>Terms of Services not accepted</br>"
                },
            ddlSecurityQuestion:
                {
                    required: "Security Question Missing"
                }
        }
    });

    $(function () {

        $("#popEmail").popover({ title: 'Email Address', html: 'true', content: "User Name Should at least 6 characters. You can choose your own name or memorable one <hr /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popUserName").popover({ title: 'Username', html: 'true', content: "<h5>How to choose your Username?</h5>Use at least 6 characters and try keeping it unique. You may throw in numbers, alphabets and underscore if you like to.  Username is your identity and also a credential.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: 'Password', html: 'true', content: "<h5>How to choose your Password?</h5> You may come up with a combination of special characters, numbers and alphabets of your choice with at least 8 characters. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConfirmPassword").popover({ title: 'Confirm Password', html: 'true', content: "<h5>Why should you retype the Password?</h5>How would you check if what you had planned to type is what you did? Simple! Retype it here and see for yourself. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityQuestion").popover({ title: 'Security Question', html: 'true', content: "<h5>Why do we ask for a Security Question?</h5>Secret Question comes in handy when you want to reset your forgotten credentials. Help us add another level of security to your account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityAnswer").popover({ title: 'Security Answer', html: 'true', content: "<h5>What if you forget the Answer?</h5>Don’t Panic! We can still help you. You can try another way to regain your access or reach our support team anytime!<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTermsofServices").popover({ title: 'Terms and Service', html: 'true', content: "<h5>Terms Of Service</h5>Read the Tems and Services carefully and agree<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                    setTimeout(function () {
                        sessionStorage.setItem('isRegistered', true);
                        window.location.href = '../Login.html';
                    });
                }
            }
        });
    }
    return isRegistered;


}




