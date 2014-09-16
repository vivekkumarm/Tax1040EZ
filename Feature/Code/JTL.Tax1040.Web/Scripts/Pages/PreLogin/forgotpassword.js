$(document).ready(function () {
    $("#forgotpassword").validate({
        rules: {
            UserName: "required"
                
        },
        messages: {
            UserName: "Username is missing."

        }
        
    });
    //Vincent-5Aug2014-made a changes in quick help Scenario 
    $(function () {
        $("#popUserName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is a Tax Garden Username?</h5>It's how we address you and identify your account.<br/><br/> You might have chosen to use your Email Address as your Username.<br /><a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
    //vivek - 31-Aug-14 for hiding the Error message during typing the text
    $('#txtUserName').keyup(function () {
        $("#divErrorMsg").hide();
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
                    $("#divErrorMsg").html("You have entered invalid Username. Please enter a valid Username.");

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