﻿//Yogalakshmi - 11th August 2014 - Added a new js for efile rejection page.

$(document).ready(function () {
    //Yogalakshmi R - 7th Aug, 2014 - Changes done to implement the FILE spec changes ver 1.4
    $('#btnContinue').click(function () {
        //  window.location.href = '../Payment/federalreturnsummary.html';

        if (isOrderExist) // 21Aug2014 Sathish redirecte to efile page if order exist for the user
            window.location.href = '../EFile/filingoption.html';
        else
            window.location.href = '../Payment/federalreturnsummary.html';
        return false;
    });
    //Yogalakshmi - 11th August 2014 - Added back button functionality.
    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });
});