//Added for Update Username Script

$(document).ready(function () {

    
    //username and password samevalidation method added by prasana on 24Jun2014
    $.validator.addMethod("usernameandpasswordsamevalidation", function (value, element) {
        if (($('#txtRetypeUserName').val() == $('#txtPasswordForUsername').val())) {
            return this.optional(element) || false;
        }
        else {

            return this.optional(element) || true;

        }

    }, 'Your Username and Password should not be same.');

    //User name validation added by prasana on 24Jun2014
    if (jQuery.validator != null) {
        jQuery.validator.addMethod("usernamevalidation",
          function (value, element) {
              var isValid = false;             
              return this.optional(element) || /^\w{6,100}$/.test(value);//Changed by Thileep 30June2014 for username length.
          }, 'Invalid Username'
          );
    }

    //validate updateusername form on keyup and submit
    //Modified by prasana for adding validations 24Jun2014
    //Modified long error message to short error message on 25.06.2014
    $("#updateusername").validate({
        rules: {
            txtRetypeUserName: {
                required: true,
                minlength: 6,
                usernamevalidation:true
            
            },
            txtPasswordForUsername: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true,
                usernameandpasswordsamevalidation: true
            }

        },
        messages: {
            txtRetypeUserName: {
                required: "Missing Username",
                minlength: "Invalid Username",
                usernamevalidation: "Invalid Username"
            },
            txtPasswordForUsername: {
                required: "Missing Password",
                minlength: "Invalid Password",
                maxlength: "Invalid Password",
                passwordvalidation: "Invalid Password",
                usernameandpasswordsamevalidation: "Your Username and Password should not be same."
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


    //Quick help added by prasana on 24Jun2014
    $(function () {
        $("#popUserName").popover({ title: '', content: "<h5>UserName</h5>Username must be atleast 6 characters which includes alphabets, numbers, and underscore. You can choose your own name or memorable one <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: '', content: "<h5>Password</h5>Passwords are case sensitive,should contain more than 8 characters. You can use combination of letters,symbols, and numbers for creating your password.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                //Changed by Thileep 26june2014
                if (data.m_Item1==3) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html(data.m_Item2);
                } else if (data.m_Item1 == 0) {
                    $("#divValidationMsg").show();
                    //Changed div color for sucess message by prasana on 25.06.2014
                    $("#divValidationMsg").removeClass('error-alert').addClass('alert alert-success');
                    $("#divValidationMsg").html("The Username has been updated successfully.");
                }
                else if (data.m_Item1 == 2) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html(data.m_Item2);
                }
                else if (data.m_Item1 == 4) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html("Invalid Password");

                }
            }
        });
        return false;

    }

}