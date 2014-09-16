$(document).ready(function () {
    $("#forgotpassword").validate({
        rules: {
            UserName: "required"
                
        },
        messages: {
            UserName: "Username should not be Empty"

        }
        
    });
    $(function () {
        $("#popUserName").popover({ title: '', content: "<h5>Username</h5>Enter the Username you use to access your account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
});

function GetUserIdByUserName() {

    var isUserExist = false;
    if ($("#forgotpassword").valid()) {

        $.ajax({
            url: serviceUrl + 'user/getuseridbyusername',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "UserName": $("#txtUserName").val()
            }
        ),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == 0) {
                    isUserExist = true;
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").html("You have entered Incorrect Information. Please check all your entries.");

                }
                else {
                    isUserExist = true;
                    window.sessionStorage.setItem("UserId", data);
                    window.sessionStorage.setItem("PreviousPage", "DontRememberMyPassword");
                    window.sessionStorage.setItem("UserName", $("#txtUserName").val());
                    window.location.href = '../PreLogin/securityquestionbycondition.html';
                }
            }
        });
    }
    return isUserExist;
}