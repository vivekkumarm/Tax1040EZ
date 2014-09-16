var userId;

$(document).ready(function () {
    userId = window.sessionStorage.getItem("UserId");
    $("#updateemailaddress").validate({
        rules: {
            Email: {
                required: true,
                email: true
            }
        },
        messages: {
            Email: {
                required: "Email Address is missing.",
                email: "Email Address is Invalid."
            },

        }
    });

    //Thileep Added quickhelp content on 17Jun2014
    //Thileep Changed quickhelp content on 09July2014
    //Vincent-5Aug2014-made a changes in quick help Scenario 
    $(function () {
        $("#popNewEmail").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your Email Address?</h5>Update your New Email Address here to help us maintain our records with correct user information.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    });
});


function UpdateEmailByUserID() {
    var isEmailUpdated = false;
    if ($("#updateemailaddress").valid()) {
        $.ajax({
            url: serviceUrl + 'user/updateemailbyuserid',
            async: false,
            dataType: "json",
            type: "PUT",
            //beforeSend: function (request) {
            //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            //},
            data: JSON.stringify({
                "UserId": userId, // Have to get from session
                "Email": $("#txtNewEmailAddress").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == false) {
                    $("#divErrorMsg").show();
                    $("#divErrorMsg").html("This Email ID already exists. Sign in or recover old account.");
                }
                else {
                    isEmailUpdated = true;
                    $("#divErrorMsg").hide();
                    setTimeout(function () {
                        window.location.href = '../Login.html';
                    });
                }
            }
        });
        return isEmailUpdated;
    }
}