/// <reference path="config.js" />
//var serviceUrl = 'http://192.168.1.10:1040/';
var serviceUrl = 'http://localhost:9797/';
var userId;
var userDataId;
var userName = '';
var aLogOut = '';
$(document).ready(function () {
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    if (!window.sessionStorage.UserDataId) {
        userDataId = 0;
    } else {
        userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    }

    if (window.sessionStorage.SignInName != null) {
        $('#liSignIn').hide();
        $('#liLogOut').show();
        $('#liAccountSetting').show();

        var sigInName = window.sessionStorage.getItem('SignInName');
       
        //Changed by Thileep 01July2014 for Signinname display
        if (sigInName.indexOf('@') >= 0) {
            sigInName = sigInName.substring(0, sigInName.indexOf('@'));
            sigInName = sigInName.substring(0, 6);
            userName = 'Hi ' + sigInName;
        }
            
        else {
            sigInName = sigInName.substring(0, 6);
            userName = 'Hi ' + sigInName;
        }
        $('#lblSignInUserName').html(userName);
    }
    

    $("#aLogOut").click(function () {
        var lastVisitedUrl = window.location.href;

        //Ashok Kumar- 18th July, 2014 - Navigation changes on check Out page LogOut
        if (lastVisitedUrl.search('checkout.html')>=0)
        {
            lastVisitedUrl = lastVisitedUrl.replace('checkout.html', 'checkoutsummary.html');
        }

        //Saravanan N - 15th April, 2014 - Store the SessionData into db.
        $.ajax({
            url: serviceUrl + 'taxreturn/persistsessiondata',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "userId": JSON.parse(window.sessionStorage.getItem("UserId")),
                "userDataId": JSON.parse(window.sessionStorage.getItem("UserDataId")),
                'lastVisitedUrl': lastVisitedUrl,
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                alert(jqXHR + "-" + textStatus + "-" + errorThrown);
            },
            success: function (data, textStatus) {
            }
        });

        window.sessionStorage.clear();
    });
});


document.write("<header role='banner' class='navbar'>" +
    "<div class='navbar-header'>" +
    "<button data-target='.navbar-collapse' data-toggle='collapse' type='button' class='navbar-toggle'>" +
    "<span class='sr-only'>Toggle navigation</span>" +
    "<span class='icon-bar'></span>" +
    "<span class='icon-bar'></span>" +
    "<span class='icon-bar'></span>" +
    "</button>" +
    "<a alt='Less' class='navbar-brand' href='#'><img alt='' class='img-responsive' src='../images/Tax-Garden-Logo.png' /></a>" +
    "</div>" + "<nav role='navigation' class='navbar-collapse collapse'>" +
    "<ul class='nav navbar-nav'>" +
    "<li>" +
    "<a href='#'>Home</a>" +
    "</li>" +
    "<li>" +
    "<a href='#'>Service</a>" +
    "</li>" +
    "<li>" +
    "<a href='#' class='active'>Price</a>" +
    "</li>" +
    "<li>" +
    "<a href='#'> Tax Resources</a>" +
    "</li>" +
    "<li>" +
    "<a href='#'>Support</a>" +
    "</li>" +
    "<li>" +
    "<a href='#'>Blog</a>" +
    "</li>" +
    "<li id='liSignIn'>" +
    "<a href='../Login.html' class='btn btn-sign'>Sign In</a>" +
    "</li>" +
    //"<li id='liLogOut' style='display:none;'>" +
    //"<a href='../Login.html' id='aLogOut'>Logout</a>" +
    //"</li>" +
    "<li id='liAccountSetting' style='display:none;'>" +
    "<a href='#' data-toggle='dropdown'><label  id='lblSignInUserName'></label><i class='caret'></i></a>" +
    "<ul class='dropdown-menu pull-right' role='menu'><li><a href='../UserProfile/manageaccountgateway.html'>Account Settings</a></li>" +
    //"<li><a href='#'>Support</a></li>" +
    "<li id='liLogOut' style='display:none;'>" +
    "<a href='../Login.html' id='aLogOut'>Logout</a>" +
    "</li>" +
    "</li>" +
    "</ul>" +
    "</nav>" +
    "</header>");


