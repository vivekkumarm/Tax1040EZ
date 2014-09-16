/// <reference path="../lib/popovercontent.js" />
/// <reference path="../Scripts/popover.js" />
/// <reference path="../Scripts/tooltip.js" />


document.write("<script type='text/javascript' src='../Scripts/tooltip.js'> </script>");
document.write("<script type='text/javascript' src='../Scripts/popover.js'> </script>");
//document.write("<script type='text/javascript' src='../lib/popovercontent.js' </script>");


//var serviceUrl = 'http://192.168.1.200:1040/';
var userId;
var userDataId;
var serviceUrl = 'http://localhost:9797/';
var CURRENT_TAX_YEAR = '2014';  //Saravanan - 22nd April, 2014 - Constants added.
var FILLING_YEAR = 'April 15th 2015'; // Sathsih - 06 May 2014 Filling year
var previousPageURL; // Sathish - 25th April, 2014 maintain the previous page URL

//Saravanan - 23rd April, 2014 - Constants added.
var SINGLE_AGI_LIMIT = 14340;
var MFJ_AGI_LIMIT = 19680;
var FILING_STATUS_SINGLE = 1;
var FILING_STATUS_MFJ = 2;

$(document).ready(function () {


    if (jQuery.validator != null) {
        jQuery.validator.addMethod("validateDate",
          function (value, element) {
              var isValid = false;
              var reg = /^\d{1,2}\/\d{1,2}\/\d{4}$/;
              if (reg.test(value)) {
                  var splittedDate = value.split('/');
                  var mm = parseInt(splittedDate[0], 10);
                  var dd = parseInt(splittedDate[1], 10);
                  var yyyy = parseInt(splittedDate[2], 10);
                  var newDate = new Date(yyyy, mm - 1, dd);
                  if ((newDate.getFullYear() == yyyy) && (newDate.getMonth() == mm - 1)
                      && (newDate.getDate() == dd)) {

                      isValid = true;
                      if (newDate > new Date('1/1/1753 12:00:00 AM') && (newDate < new Date('12/31/9999 11:59:59 PM'))) {
                          isValid = true;
                      } else {
                          isValid = false;
                      }

                  }
                  else
                      isValid = false;
              }
              else
                  isValid = false;
              return this.optional(element) || isValid;
          }, ""
          );
    }

    previousPageURL = document.referrer;


    userId = JSON.parse(window.sessionStorage.getItem("UserId"));

    if (!window.sessionStorage.UserDataId) {

        userDataId = 0;

    } else {

        userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    }
});

//added by Swapnesh for Error Handling
function ErrorHandling(jqXHR, exception) {
    if (jqXHR.status === 0) {
        window.location.href = "../errorpage.html?Errormsg=" + "Not connect.\n Verify Network.";
        return false;
    } else if (jqXHR.status == 404) {
        window.location.href = "../errorpage.html?Errormsg=" + "Requested page not found. [404]";
        return false;
    } else if (jqXHR.status == 500) {
        window.location.href = "../errorpage.html?Errormsg=" + 'Internal Server Error [500].    ';
        return false;
    } else if (jqXHR.status == 401) {
        window.location.href = "../errorpage.html?Errormsg=" + 'Unauthorized ';
        return false;
    } else if (exception == 'parsererror') {
        window.location.href = "../errorpage.html?Errormsg=" + 'Requested JSON parse failed.';
        return false;
    } else if (exception == 'timeout') {
        window.location.href = "../errorpage.html?Errormsg=" + 'Time out error.';
        return false;
    } else if (exception == 'abort') {
        window.location.href = "../errorpage.html?Errormsg=" + 'Ajax request aborted.';
        return false;
    } else {
        window.location.href = "../errorpage.html?Errormsg=" + 'Uncaught Error.\n';
        return false;
    }
}


// Sathish - 25th April, 2014 redirect to previous page
function GoToPreviousPage() {
    if (previousPageURL != '') {
        window.location.href = previousPageURL;
        return false;
    }
}

$(document).ready(function () {
    $('.tip').tooltip();
});

//Saravanan N - 7th May, 2014 - If any Eligibility Check failed then Hardstop the user and redirect to final Diagnostics page otherwise move to as usual.
function PageNavigation(isHardStopOccurred, normalFlowPageNavigation, topic) {

    if (isHardStopOccurred) {
        setTimeout(function () {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=' + topic;
        });
    }
    else {
        setTimeout(function () {
            window.location.href = normalFlowPageNavigation;
        });
    }
}


