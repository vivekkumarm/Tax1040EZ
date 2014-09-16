// validate signup form on keyup and submit
$(document).ready(function () {
    var email;

    $.validator.addMethod("usernamevalidation", function (value, element) {
        return this.optional(element) || /^\w{6,64}$/.test(value);
    }, 'Your Username must have atleast 6 Characters which includes alphabets, numbers and underscore.');

    $.validator.addMethod("passwordvalidation", function (value, element) {
        return this.optional(element) || /^(?=(.*\d){1,1})(?=.*[a-zA-Z])(?=.*[!@_#$%]{1,1})[0-9a-zA-Z!@_#$%]{8,15}$/.test(value);
    }, 'Your Password must have 8 to 15 characters inclusive of one number and one special character.');


    $('#chkEmail').click(function () {
        if ($(this).is(":checked")) {
            $('#txtUserName').val($("#txtEmail").val());
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
    
    $("#registration").validate({

        rules: {
            txtEmail: {
                required: true,
                email: true
            },
            txtUserName: {
                required: true,
                minlength: 6,
                maxlength: 64,
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
            }

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
        $("#popEmail").popover({ title: '', content: "<h5>Email Address</h5>Email Address should be in the format(test@gmail.com).Email Address is used to communicate you <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popUserName").popover({ title: '', content: "<h5>UserName</h5>Username must be atleast 6 characters which includes alphabets, numbers, and underscore. You can choose your own name or memorable one <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: '', content: "<h5>Password</h5>Passwords are case sensitive,should contain more than 8 characters. You can use combination of letters,symbols, and numbers for creating your password.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConfirmPassword").popover({ title: '', content: "<h5>Confirm Password</h5>Confirm Password should match the exact characters entered in password field.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityQuestion").popover({ title: '', content: "<h5>Security Question</h5>Please select anyone of the security question from the dropdown.  Security Question is used to reset your Password, or to retrieve your forgotten Username.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSecurityAnswer").popover({ title: '', content: "<h5>Security Answer</h5>Specify the correct answer to your security question. By answering the correct answer to your question, you can reset your forgotten password and username. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTermsofServices").popover({ title: '', content: "<h5>Terms Of Service</h5>Read the Tems and Services carefully and agree<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        //$("#Remember me on this computer").popover({ title: '', content: "<h5>Click on this option, if you want your computer to remember your login credentials whenever you try to access our application. No need for the user to type the login credentials repeatedly.<hr/> <a href='' target='_blank' class='more'>Read Common Question</a>" })

    });

});

function username() {
    $('#chkEmail').prop('checked', false);
}
$("#ddlSecurityQuestion").ready(function () {
    $.ajax({
        url: serviceUrl + 'user/getsecurityquestion',
        async: false,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlSecurityQuestion").append($("<option></option>").val('').html('---Select---'));
            for (var key in data) {
                $("#ddlSecurityQuestion").append($("<option></option>").val(key).html(data[key]));
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




