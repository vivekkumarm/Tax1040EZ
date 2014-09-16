/// <reference path="../../../lib/config.js" />
var userName;
$(document).ready(function () {

    //16Jun2014 Sathish cleared a session every time user login.
    //commented by thileep on 17thJune 2014 to shown Successful message.
    //window.sessionStorage.clear();

    //17Jun2014 Thileep added userId session remove every time user login.
    window.sessionStorage.removeItem('UserId');


    window.sessionStorage.removeItem('SignInName');
    window.sessionStorage.removeItem('UserName');
    $('.error').hide();

    window.sessionStorage.removeItem('SignInName');
    window.sessionStorage.removeItem('UserName');



    if (localStorage) {
        var RememberMe = localStorage.getItem('RememberMe');
        var isRegistered = sessionStorage.getItem('isRegistered');
        if (isRegistered == "true") {
            $("#divSignInError").show();
            //Thileep - 20 June 2014 - Change message as per spec.
            $("#divSignInError").html("Your account has been successfully created. Enter your Sign In information received in your Email.");
            //Yogalakshmi - 4th June 2014 - Setting colour for success message
            $("#divSignInError").removeClass('error-alert').addClass('alert alert-success');
            sessionStorage.removeItem('isRegistered');
        }
        if (RememberMe == "false") {
            localStorage.removeItem('name');
            $('#chkRememberMe').prop('checked', false);
            $('#txtSignInUserName').val('');
        }
        //if (localStorage.getItem('') == true) {
        //}
        var userName = localStorage.getItem('name');
        if (userName != null && userName != '') {
            $('#chkRememberMe').prop('checked', true);
            localStorage.setItem('RememberMe', true);
            $('#txtSignInUserName').val(userName);
        }
    }
    $('#txtSignInUserName').keyup(function () {
       $('.error').hide();
    });
    $('#txtSignInPassword').keyup(function () {
        $('.error').hide();
    });
   
    //$('#diverror').hide();
    //$("#PreLogin").validate({
    //    rules: {
    //        txtSignInUserName: {
    //            required: true
    //        },
    //        txtSignInPassword: {
    //            required: true
    //        }
    //    },
    //    messages: {
    //        txtSignInUserName: {
    //            required: $('.error')
    //        },
    //        txtSignInPassword: {
    //            required: $('.error')
    //        }

    //    }
    //});

});

function SignInUserName() {
    localStorage.setItem('name', $('#txtSignInUserName').val());
   
}

function SignInError(e) {
    if (e.keyCode != 13) {
        $("#divSignInError").hide();
    }
}


function rememberme() {

    if ($('#chkRememberMe').prop('checked')) {
        if ($('#txtSignInUserName').val() != '') {
        localStorage.setItem('name', $('#txtSignInUserName').val());
        localStorage.setItem('RememberMe', true);
    }
    }
    else {
        //commented by vivek on 5-june-2014 for remember me 
        //$('#txtSignInUserName').val('');
        localStorage.removeItem('name');
        localStorage.setItem('RememberMe', false);
    }
}

//$('#txtSignInUserName').keyup(function () {
//    $('.error').hide();
//});
//function Signinvalidation() {
//    if(($('#txtSignInUserName').val() || $('#txtSignInPassword').val()) !== '')
//    {
//        $('.error').hide();
//        }
//}
function SignInUser() {
    var isSignedIn = false;

    $("#divSignInError").hide();//Added by thileep to hide Error div on button click on 27June2014
    //Three conditions Added by Thileep to Validate the Username,password on 27June2014
    if ($("#txtSignInUserName").val() == '' && $("#txtSignInPassword").val() !== '') {
        $('.error').show();
        $("#divMissingUsername").show();
        $("#divMissingPassword").hide();
        return false;
    }
    else if ($("#txtSignInPassword").val() == '' && $("#txtSignInUserName").val() !== '') {
        $('.error').show();
        $("#divMissingPassword").show();
        $("#divMissingUsername").hide();
        return false;
    }
    if ($("#txtSignInUserName").val() == '' && $("#txtSignInPassword").val() == '') {
        $('.error').show();
        $("#divMissingUsername").show();
        $("#divMissingPassword").show();
        return false;
           }
   
        $.ajax({
            url: serviceUrl + 'user/signin',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "UserName": $("#txtSignInUserName").val(),
            "Password": $("#txtSignInPassword").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
               
            },
            success: function (data, textStatus) {
                if (data.UserId == 0) {
                    $("#divSignInError").show();
                    //Error message changed by thileep 23June2014
                    $("#divSignInError").html("The Username or Password entered is Incorrect. Please confirm your entries.");
                    $("#divSignInError").removeClass('alert alert-success').addClass('error-alert');
                    $('.error').hide();
                } else {
                    isSignedIn = true;
                    window.sessionStorage.setItem("UserId", data.UserId);
                    window.sessionStorage.setItem('UserName', $('#txtSignInUserName').val());
                    //Uncomment when security is implemented
                    window.sessionStorage.setItem("EncryptedTocken", data.EncryptedTocken);
                    GetUserDataIdByUserId();
                    //setTimeout(function () {
                    //    window.location.href = '../PreLogin/welcomepage.html';
                    //});
                }
            }
        });
    return isSignedIn;
}

function GetUserDataIdByUserId() {
    $.ajax({
        url: serviceUrl + 'personalinfo/getuserdataidbyuserid',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": JSON.parse(window.sessionStorage.getItem("UserId")),
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != 0) {
                window.sessionStorage.setItem("UserDataId", data);
                GetPersonDetail();
                //Saravanan N - 19th May, 2014 - TaxOverview page will decide which page has to open next.
                window.location.href = '../PreLogin/taxoverview.html';
            } else {
                window.sessionStorage.setItem('SignInName', $('#txtSignInUserName').val());
                window.sessionStorage.setItem('UserName', $('#txtSignInUserName').val());
                window.location.href = '../PreLogin/welcomepage.html';
            }
        }
    });
}

function GetPersonDetail() {
    $.ajax({
        url: serviceUrl + 'personalinfo/getprimarytaxpayer',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {        
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": JSON.parse(window.sessionStorage.getItem("UserId")),
            "UserDataId": JSON.parse(window.sessionStorage.getItem("UserDataId")),
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data.Person != null) {
                if (data.Person.NickName != null && data.Person.NickName != "") {
                    window.sessionStorage.setItem('SignInName', data.Person.NickName);
                } else if (data.Person.FirstName != null && data.Person.FirstName != "") {
                    window.sessionStorage.setItem('SignInName', data.Person.FirstName);
                } else if ($('#txtSignInUserName').val() != "") {
                    window.sessionStorage.setItem('SignInName', $('#txtSignInUserName').val());
                }
            } else if ($('#txtSignInUserName').val() != "") {
                window.sessionStorage.setItem('SignInName', $('#txtSignInUserName').val());
            }
        }
    });
}