var previousPage;
var userId;

$(document).ready(function() {
    previousPage = window.sessionStorage.getItem("PreviousPage");
    userId = window.sessionStorage.getItem("UserId");

    $("#SecurityQuestion").validate({
        rules: {
            txtAnswer: "required"
        },
        messages: {
            txtAnswer: "Missing Secret Answer"
        }
    });

    GetSecurityQuestionByUserID();

    $(function() {
        $("#popSecurityAnswer").popover({ title: '', content: "<h5>Security Answer</h5>Enter the security answer to access your account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
});



function ValidateUserBySecurityInfoAndSendResetCode() {
    var isValidAnswer = false;
    if ($("#SecurityQuestion").valid()) {
        $.ajax({
            url: serviceUrl + "user/updatepasswordresetcode",
            async: false,
            dataType: "json",
            type: "PUT",
            data: JSON.stringify({
                "UserId": userId,
                "SecurityQuestionId": $("#hdnQuestionId").val(),
                "SecurityAnswer": $("#txtAnswer").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == false) {
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").html("You have entered the Invalid Secret Code. Please enter the valid Secret Code sent to your Email address.");
                }
                else {
                    isValidAnswer = true;
                    setTimeout(function () {
                        window.location.href = '../PreLogin/passwordresetcode.html';
                    });
                }
            }
        });
    }
    return isValidAnswer;
}

function ValidateUserBySecurityInfoAndSendUserName() {
    var isValidAnswer = false;
    if ($("#SecurityQuestion").valid()) {
        $.ajax({
            url: serviceUrl + "user/updateusernamepasswordresetcodebysecurityinfo",
            async: false,
            dataType: "json",
            type: "PUT",
           data: JSON.stringify({
                "UserId": userId, 
                "SecurityQuestionId": $("#hdnQuestionId").val(),
                "SecurityAnswer": $("#txtAnswer").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == false) {
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").html("You entered Incorrect Information. Please confirm all your entries.");
                } else {
                    isValidAnswer = true;
                    setTimeout(function () {
                        
                        window.location.href = '../PreLogin/emailrecoverybybothcondition.html';
                    });
                }
            }
        });
    }
    return isValidAnswer;
}

function UnabletoAccessEmailAddress() {
    var isValidAnswer = false;
    if ($("#SecurityQuestion").valid()) {
        $.ajax({
            url: serviceUrl + "user/updateemailbysecurityinfo",
            async: false,
            dataType: "json",
            type: "PUT",
            //beforeSend: function (request) {
            //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            //},
            data: JSON.stringify({
                "UserId": userId, // Have to get User Id from Session
                "SecurityQuestionId": $("#hdnQuestionId").val(),
                "SecurityAnswer": $("#txtAnswer").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == 0) {
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").html("You entered Incorrect Information. Please confirm all your entries.");
                } else {
                    isValidAnswer = true;
                    setTimeout(function () {
                        window.location.href = '../PreLogin/updateemailaddress.html';
                    });
                }
            }
        });
    }
    return isValidAnswer;
}




// TODO : Have to get previous page from session
function ValidateUserBySecurityInfo() {

    if (previousPage == 'DontRememberMyPassword') {
        return ValidateUserBySecurityInfoAndSendResetCode();
    } else if (previousPage == 'ForgotBothUsernameandPassword') {
        return ValidateUserBySecurityInfoAndSendUserName();
    } else if (previousPage == 'UnabletoAccessEmailAddress') {
        return UnabletoAccessEmailAddress();
    }
}


function GetSecurityQuestionByUserID() {
    $.ajax({
        url: serviceUrl + 'user/getsecurityquestionbyuserid',
        async: false,
        dataType: "json",
        type: "POST",
        data: JSON.stringify({
            "UserId": userId, // Have to get User Id from session
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data == 0) {
                $("#divSignInError").show();
                $("#divSignInError").html("The Username or Password entered is Incorrect. Please confirm your entries.");
            }
            else {
                $("#lblSelectedSecurityQuesiton").html(data.Value);
                $("#hdnQuestionId").val(data.Key);
            }
        }
    });
}