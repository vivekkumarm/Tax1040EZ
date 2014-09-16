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
                maxlength: 15
            },
            txtConfirmPassword: {
                required: true,
                equalTo: "#txtNewPassword"
            }

        },
        messages: {
            txtUserName: "Username should not be Empty",
            txtNewPassword: {
                required: "New Password should not be Empty",
                minlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character",
                maxlength: "Your Password must have 8 to 15 characters inclusive of one number and one special character"
            },
            txtConfirmPassword: {
                required: "Confirm Password should not be Empty",
                equalTo: "Your Password and Confirm Password  must be same "
            }
        }
    });
    $(function () {
        $("#popUserName").popover({ title: '', content: "<h5>Username</h5>To reset your password, you need to specify your username, used for accessing your account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNewPassword").popover({ title: '', content: "<h5>Password</h5>To reset your password, you need to enter a new password with more than 6 characters.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popConfirmPassword").popover({ title: '', content: "<h5>Confirm Password</h5>Confirm Password should match the exact characters entered in New Password.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
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
                    $("#divErrorMsg").html("You entered Incorrect Information. Please confirm all your entries.");
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