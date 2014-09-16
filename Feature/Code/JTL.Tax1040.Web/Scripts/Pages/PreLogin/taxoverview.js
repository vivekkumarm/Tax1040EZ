//Saravanan N  - 15th April, 2014 - New file added.
/// <reference path="../../../lib/config.js" />


//var serviceUrl = 'http://192.168.1.200:1040/';
var serviceUrl = 'http://localhost:9797/';

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    var CURRENT_TAX_YEAR = '2014';
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    
    $.ajax({
        url: serviceUrl + 'user/getsessiondatabyuseridanduserdataid',
        async: false,
        dataType: "json",
        type: "POST",
        //beforeSend: function (request) {
        //    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        //},
        data: JSON.stringify({
            'userId': JSON.parse(window.sessionStorage.getItem("UserId")),
            'userDataId': JSON.parse(window.sessionStorage.getItem("UserDataId")),
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            welcomePageNavigation(data);
        }
    });
});

//TODO: Saravanan N - 8th May, 2014 - From login.js file this functionality has to be done.

function welcomePageNavigation(pageToNavigate) {
    if (pageToNavigate.trim().length == 0) {
        window.location.href = '../Prelogin/welcomepage.html';
        return false;
    } else {
        $('#btnYourTaxReturn').click(function () {
            window.location.href = pageToNavigate;
            return false;
        });

        $('#btnContinueStepByStep').click(function () {
            window.location.href = '../PersonalInfo/FilingStatus.html';
            return false;
        });
    }
};

