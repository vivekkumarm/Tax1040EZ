//Added for Update Username Script

//var oldUserName = "";
$(document).ready(function () {
    

    GetUserDetails();
    //username and password samevalidation method added by prasana on 24Jun2014
    $.validator.addMethod("usernameandpasswordsamevalidation", function (value, element) {
        if (($('#txtRetypeUserName').val().toLowerCase() == $('#txtPasswordForUsername').val().toLowerCase())) {//Changed By Thileep on 11July 2014
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
                //minlength: 8,
                //maxlength: 15,
                //passwordvalidation: true,
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
                //minlength: "Invalid Password",
                //maxlength: "Invalid Password",
                //passwordvalidation: "Invalid Password",
                usernameandpasswordsamevalidation: "Your Username and Password should not be same."
            }

        }
    })
    

    //Added by Thileep 04July 2014
    $("#txtRetypeUserName").keyup(function () {
        $("#divValidationMsg").hide();
    });
    $("#txtPasswordForUsername").keyup(function () {
        $("#divValidationMsg").hide();
    });


    //Quick help added by prasana on 24Jun2014
    //Quickhelp Message content changed 17July 2014 By Thileep
    $(function () {
        $("#popUserName").popover({ title: '', content: "<h5>How to choose a New Username?</h5>Type in a New Username with at least 6 characters.<br/><br/>You may throw in numbers, alphabets and underscore if you like to.<br/><br/>Remember that this is your new identity and also a credential for your TaxGarden Account. <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: '', content: "<h5>What is your Password?</h5>This is a secret string of characters you chose to secure your Tax Garden account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
});


function GetUserDetails() {
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
            //oldUserName = data.UserName;

        }
    });
}

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
                    //GetUserDetails();
                    var signInName = window.sessionStorage.getItem('SignInName');
                    var oldUserName = $('#lblUserNameVal').html();
                    if (signInName != null && signInName != "" && signInName == oldUserName) {                        
                        window.sessionStorage.setItem('SignInName', $("#txtRetypeUserName").val());
                        signInName = window.sessionStorage.getItem('SignInName');
                        if (signInName.indexOf('@') >= 0) {
                            signInName = signInName.substring(0, sigInName.indexOf('@'));
                            signInName = signInName.substring(0, 6);
                            userName = 'Hi ' + signInName;
                        }

                        else {
                            signInName = signInName.substring(0, 6);
                            userName = 'Hi ' + signInName;
                        }
                        $('#lblSignInUserName').html(userName);
                    }
                    //Added by Thileep 04July 2014
                    $("#lblUserNameVal").html($("#txtRetypeUserName").val());
                    $("#txtPasswordForUsername").val("");
                    $("#txtRetypeUserName").val("");
                    window.sessionStorage.setItem('UserName', $("#txtRetypeUserName").val());
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