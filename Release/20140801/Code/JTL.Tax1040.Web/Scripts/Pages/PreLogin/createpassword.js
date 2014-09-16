// validate signup form on keyup and submit
var pageNo;
var userName;
$(document).ready(function () {

    pageNo = window.sessionStorage.getItem('PrePage');
    if (pageNo=='1'||pageNo=='2') {
        if (pageNo == '1') {
            $('#txtUserName').hide();
            $('#popUserName').hide();
            $('#lblUserName').show();
            userName = window.sessionStorage.getItem("UserName");
            $('#lblUserName').html(userName);
        }
        else if (pageNo == '2') {
            $('#lblUserName').hide();
            $('#txtUserName').show();
            $('#popUserName').show();
        }
    }
    //    $('#divResetCodeByPassword').hide(); // for text box
    //    $('#divResetCodeUpdate').show(); //for lable

   
    $.validator.addMethod("usernameandpasswordsamevalidation", function (value, element) {
        if (($('#txtUserName').val() == $('#txtPassword').val()) || ($('#lblUserName').val() == $('#txtPassword').val())) {
            return this.optional(element) || false;
        }
        else {

            return this.optional(element) || true;
        }

    }, '');


    $('#divResetCodeUpdate').hide();
    //$('#divResetCodeByPassword').hide();
    var userId;
    userId = window.sessionStorage.getItem("UserId");
    $("#NewPassword").validate({
        rules: {
            txtUserName: {
                required: true
            },
            txtNewPassword: {
                required: true,
                minlength: 8,
                maxlength: 15,
                passwordvalidation: true,
                usernameandpasswordsamevalidation: true
            },
            txtConfirmPassword: {
                required: true,
                equalTo: "#txtNewPassword"
            }

        },
        messages: {
            txtUserName: "Username should not be Empty",
            txtNewPassword: {
                required: "New Password is missing.",
                minlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character.",
                maxlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character.",
                passwordvalidation: "Your Password must have 8 to 15 characters inclusive of one number and one special character.",
                usernameandpasswordsamevalidation: "Your Username and Password should not be same."
            },
            txtConfirmPassword: {
                required: "Confirm Password is missing.",
                equalTo: "'Confirm Password' should match 'Password'."
            }
        }
    });
    //Thileep Changed quickhelp content on 09July2014
    $(function () {
        $("#popUserName").popover({ title: '', content: "<h5>Where to find your Username?</h5>We have mailed your TaxGarden Username to the Email Address associated with your account. It's a part of our stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNewPassword").popover({ title: '', content: "<h5>How to set a New Password?</h5>The Password you enter here will be your New Tax Garden Password..<br/><br/> Make sure to throw in at least one alphabet, one number, and one special character. Use at least 8 characters and try keeping it hard for the hackers.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConfirmPassword").popover({ title: '', content: "<h5>Why should you retype the Password?</h5>How would you check if what you had typed has no typo errors?<br/><br/>Simple! Retype it here and see for yourself.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

});


function UpdateNewPassword() {
    var isPasswordUpdate = false;
    var userName;
    if (pageNo == '1') {
        userName = $("#lblUserName").text();
    }
    else if (pageNo == '2') {
        userName = $("#txtUserName").val();
    }
    
    if ($("#NewPassword").valid()) {
        $.ajax({
            url: serviceUrl + 'user/resetpassword',
            async: false,
            dataType: "json",
            type: "PUT",
            //beforeSend: function (request) {
            //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            //},
            data: JSON.stringify({
                "UserName": userName,
                "UserId": userId, // Have to get User Id from Session
                "Password": $("#txtNewPassword").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == false) {
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").html("You have entered an Incorrect Information. To retrieve your login information kindly contact our customer support.");
                }
                else {
                    isPasswordUpdate = true;
                    $("#divErrorMsg").hide();
                    setTimeout(function () {
                        window.location.href = '../Login.html';
                    });
                }
                //if (data != null) {
                //    $('#divResetCodeByPassword').hide(); // for text box
                //    $('#divResetCodeUpdate').show(); //for lable
                //    $('#lblUserName').html(data);
                //}

            }
        });
    }
    return isPasswordUpdate;
}