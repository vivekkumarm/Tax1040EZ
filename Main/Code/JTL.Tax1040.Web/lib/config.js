/// <reference path="../lib/popovercontent.js" />
/// <reference path="../Scripts/popover.js" />
/// <reference path="../Scripts/tooltip.js" />
/// <reference path="../Scripts/jquery.slidemenu.js" />



document.write("<script type='text/javascript' src='../Scripts/tooltip.js'></script>");

document.write("<script type='text/javascript' src='../Scripts/jquery.slidemenu.js'> </script>");

document.write("<script type='text/javascript' src='../Scripts/popover.js'> </script>");

// 09Jun2014 Sathish refer javascript for user ideal section
document.write("<script type='text/javascript' src='../Scripts/jquery.idletimeout.js'></script>");
document.write(" <script type='text/javascript' src='../Scripts/jquery.idletimer.js'></script>");
// 18Jun2014 Sathish refered constant to be used through out the application
document.write(" <script type='text/javascript' src='../lib/constants.js'></script>");


//var serviceUrl = 'http://192.168.1.200:1040/';
var userId;
var userDataId;
//var serviceUrl = 'http://192.168.1.10:1040/';
var serviceUrl = 'http://localhost:9797/';
var CURRENT_TAX_YEAR = '2014';  //Saravanan - 22nd April, 2014 - Constants added.
var FILLING_YEAR = 'April 15th 2015'; // Sathsih - 06 May 2014 Filling year
var previousPageURL; // Sathish - 25th April, 2014 maintain the previous page URL
var STATE_OF_RESIDENCE = '12/31/2014'; // vivek -18
var TAX_END_YEAR = 'December 31st,2014';//vivek 10-july-14 Added for the tax year 
var isOrderExist = false; //Sathish 18Jul2014 Sathish variable user to check order exist


var SERVED_IN_MILITARY_DURING = '2014';//vivek -4-july-14 Served in  Military 
//Saravanan - 23rd April, 2014 - Constants added.
var SINGLE_AGI_LIMIT = 14340;
var MFJ_AGI_LIMIT = 19680;
var FILING_STATUS_SINGLE = 1;
var FILING_STATUS_MFJ = 2;
var CONTINUE_BUTTON_CAPTION = 'CONTINUE';
var BACK_BUTTON_CAPTION = 'BACK';
var TITLE = 'TaxGarden.com';
var ZIPCODE5ZEROS = '00000';
//var ZIPCODE9ZEROSWITHHYPEN = '00000-0000';
//var ZIPCODE9NINESWITHHYPEN = '99999';
//var ZIPCODE5NINES = '99999-9999';
//var SSN9ZEROS = '000-00-0000';
//var SSN9Nines = '999-99-9999';
//var SSNNaturalNumbers = '123-45-6789';
var SSNInvalidAreaCodeRange = 772;
var SSNInvalidAreaCode = 666;
//var SSN10ZEROS = '000-000-0000';
//var SSN10Nines = '999-999-9999';
var EMPTY_RECORD = 'No Information Provided';
var currentObjectName = '';
var FILING_START_DATE = '01-01-2015';
var FILING_END_DATE = '04-15-2015';

$(document).ready(function () {
    //Saravanan N - 30th July, 2014 - As discussed with Praveen, for the Defect # 14337.
    $(this).bind("contextmenu", function (e) { e.preventDefault(); });

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

        jQuery.validator.addMethod("validateEINFor0000",
            function (value, element) {
                if ((value != null && value != '')) {
                    if (value.length == 10) {
                        //Yogalakshmi - 8th July 2014 - Defect fix for Tax1040-14103 - check for EIN/FIN format Eg: 00-0000000
                        if (value.indexOf('-') == -1) {
                            return false;
                        }
                        //if (value == '00-0000000' || value == '99-9999999') {
                        //    return false;
                        //}
                        //else {
                        return true;
                        //   }
                    }
                    else {
                        return true;
                    }
                }
                else {
                    return true;
                }
            }, ""
            );

        //Bala - 23rd June, 2014 - SSN validation modified to check Natural number and area code.
        //Bala - 25th June 2014, - As discussed with praveen, Format validations only done in client side. So commented
        jQuery.validator.addMethod("validateSSN",
        function (value, element) {
            if ((value != null && value != '')) {
                if (value.length == 11) {
                    //var areaCode = parseInt(value.substr(0, 3));
                    //if (value == SSN9ZEROS || value == SSN9Nines || value == SSNNaturalNumbers || areaCode == SSNInvalidAreaCode || areaCode > SSNInvalidAreaCodeRange) {
                    //    return false;
                    //}
                    //Bala, 8th July 2014, added to fix the hypen missing issue
                    if (value.indexOf('-') == -1) {
                        return false;
                    }
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return true;
            }
        }, ""
        );

        jQuery.validator.addMethod("validateZipCode",
         function (value, element) {
             if ((value != null && value != '')) {

                 if (value.length == 10 || value.length == 5) {
                     //Yogalakshmi - 8th July 2014 - Defect fix for Tax1040-14103 - check for zipcode Eg: 00000-0000
                     if (value.length == 10 && value.indexOf('-') == -1) {
                         return false;
                     }
                     //if (value == ZIPCODE5ZEROS || value == ZIPCODE9ZEROSWITHHYPEN || value == ZIPCODE5NINES || value == ZIPCODE9NINESWITHHYPEN) {
                     //    return false;
                     //}
                     return true;
                 }
                 else {
                     return false;
                 }
             }
             else {
                 return true;
             }
         }, ""
         );


        jQuery.validator.addMethod("validatePhoneNumber",
 function (value, element) {
     if ((value != null && value != '')) {

         if (value.length == 12) {
             //if (value == SSN10ZEROS || value == SSN10Nines) {
             //    return false;
             //}
             //Bala, 8th July 2014, added to fix the hypen missing issue
             if (value.indexOf('-') == -1) {
                 return false;
             }
             return true;
         }
         else {
             return false;
         }
     }
     else {
         return true;
     }
 }, ""
 );

        jQuery.validator.addMethod("validateyearlessthantaxyear",
         function (value, element) {
             var isValid = false;
             var reg = /^\d{1,2}\/\d{1,2}\/\d{4}$/;
             if (reg.test(value)) {
                 var splittedDate = value.split('/');
                 var mm = parseInt(splittedDate[0], 10);
                 var dd = parseInt(splittedDate[1], 10);
                 var yyyy = parseInt(splittedDate[2], 10);
                 var newDate = new Date(yyyy, mm - 1, dd);
                 var currentYear = (new Date).getFullYear();
                 isValid = true;
                 if (newDate.getFullYear() >= currentYear) {
                     isValid = false;
                 }
             }
             else
                 isValid = false;
             return this.optional(element) || isValid;
         }, ""
         );


        jQuery.validator.addMethod("notequalto",
        function (value, element, param) {
            var isValid = false;
            if (value != $(param).val()) {
                isValid = true;
            }
            else
                isValid = false;
            return this.optional(element) || isValid;
        }, ""
        );



        jQuery.validator.addMethod("lettersonly", function (value, element) {
            return this.optional(element) || /^[a-z]+$/i.test(value);
        }, "Letters only  please");


        //Password field validator method added by prasana on 24Jun2014
        //Password field validator changed by Thileep on 26Jun2014
        jQuery.validator.addMethod("passwordvalidation", function (value, element) {
            return this.optional(element) || /^(?=(.*\d){1,1})(?=.*[a-zA-Z])(?=.*[!@_#$%*_~-]{1,1})[0-9a-zA-Z!@_#$%*_~-]{8,15}$/.test(value);
        }, 'Invalid Password');

    }

    previousPageURL = document.referrer;


    LoadUserIDandUserDataID();


    // 09Jun2014 Sathish redirect to login and clear the session if the user is ideal for 20 min
    if (userId != null && userId != 0) {
        $.idleTimer(20 * 60 * 1000); // min * sec * microsecond
    }

    // 09Jun2014 Sathish redirect to login and clear the session if the user is ideal for 20 min
    $(document).bind("idle.idleTimer", function () {
        var lastVisitedUrl = window.location.href;

        //Saravanan N - 12th Aug, 2014 - At the time of session expiration, store the last visited URL. 
        if (lastVisitedUrl.search('checkout.html') >= 0) {
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

        // function you want to fire when the user goes idle
        window.sessionStorage.clear();
        window.location.href = "../login.html";
        $.idleTimer('destroy');
    });
});


function LoadUserIDandUserDataID() {
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));

    if (!window.sessionStorage.UserDataId) {

        userDataId = 0;

    } else {

        userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    }
}



//added by Swapnesh for Error Handling
function ErrorHandling(jqXHR, exception) {
    if (jqXHR.status === 0) {
        window.location.href = "../errorpage.html?Errormsg=" + "1.	You lost your dial-up Internet connection- Reconnect and try again!";
        return false;
    } else if (jqXHR.status == 404) {
        window.location.href = "../errorpage.html?Errormsg=" + "The requested page could not be found. Need Help? Feel free to contact our support team.";
        return false;
    } else if (jqXHR.status == 500) {
        window.location.href = "../errorpage.html?Errormsg=" + 'Server encountered an unexpected condition which stopped the request. Notify the administrator Or leave page now.';
        return false;
    } else if (jqXHR.status == 401) {
        window.location.href = "../Login.html";
        return false;
    } else if (exception == 'parsererror') {
        window.location.href = "../errorpage.html?Errormsg=" + 'Requested JSON parse failed.';
        return false;
    } else if (exception == 'timeout') {
        window.location.href = "../errorpage.html?Errormsg=" + 'Your session has timed out, please log-in again to continue.';
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
    $(".slide-menu").slideMenu();
});


//Saravanan N - 7th May, 2014 - If any Eligibility Check failed then Hardstop the user and redirect to final Diagnostics page otherwise move to as usual.
function PageNavigation(isHardStopOccurred, normalFlowPageNavigation, topic) {

    if (isHardStopOccurred) {
        setTimeout(function () {
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            window.location.href = '../Review/finalsummary.html?Topic=' + topic;


        });
    }
    else {
        setTimeout(function () {
            window.location.href = normalFlowPageNavigation;
        });
    }
}

//29May2014 Sathish Added the method to validate control to accept only letter
//12June2014 Prasanna removed shift key checking to fix the defect#TAX1040-14002 
function LettersOnly(cntrl) {
    //Prevent key press event
    $('#' + cntrl).keydown(function (e) {
        if (e.ctrlKey || e.altKey) {
            e.preventDefault();
        } else {
            var key = e.keyCode;
            if (!((key == 8) || (key == 9) || (key == 13) || (key == 45) || (key == 46) || (key >= 35 && key <= 40) || (key >= 65 && key <= 90))
                || (key == 32) // Back Space
                || (key >= 96 && key <= 105) // Number pad Numbers only
                ) {
                e.preventDefault();
            }
        }
    });

    //Avoid Pasting numbers only
    $('#' + cntrl).bind("paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^a-z]/g, ''));
        }, $(this)), 0);
    });
}

// Swapnesh 6-62014
//Modified by prasana for retricting characters ~ and ` on 18.06.2014
//Modified by prasana for retricting character _ on 23.06.2014
function LettersAndSpaceOnly(cntrl, e) {
    $('#' + cntrl).keydown(function (e) {
        var currentindex = getCaret(this);
        if (e.keyCode == 220) {
            e.preventDefault();
        }
        else {
            var controlValue = this.value;
            var iChars = "!@#$%^&*()0123456789+=-[]\\\';,./{}|\":<>?`~_";
            var lengthoftext = controlValue.length;
            for (var i = 0; i < lengthoftext; i++) {
                if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                    if (controlValue.charAt(i) == '[') {
                        controlValue = controlValue.replace(/\[/g, '');
                    }
                    else if (controlValue.charAt(i) == ']') {
                        controlValue = controlValue.replace(/\]/g, '');
                    }
                    else if (controlValue.charAt(i) == '^') {
                        controlValue = controlValue.replace(/\^/g, '');
                    }
                    else {
                        var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                        controlValue = controlValue.replace(removespecialcharacter, '');
                    }
                    this.value = controlValue;
                    if (event.keyCode == 46) {
                        this.selectionStart = currentindex;
                        this.selectionEnd = currentindex;
                    }
                    else {
                        this.selectionStart = currentindex - 1;
                        this.selectionEnd = currentindex - 1;
                    }
                }
            }
        }
    });


    $('#' + cntrl).keyup(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = "!@#$%^&*()0123456789+=-[]\\\';,./{}|\":<>?`~_";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                if (controlValue.charAt(i) == '[') {
                    controlValue = controlValue.replace(/\[/g, '');
                }
                else if (controlValue.charAt(i) == ']') {
                    controlValue = controlValue.replace(/\]/g, '');
                }
                else if (controlValue.charAt(i) == '^') {
                    controlValue = controlValue.replace(/\^/g, '');
                }
                else {
                    var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                    controlValue = controlValue.replace(removespecialcharacter, '');
                }
                this.value = controlValue;

                if (event.keyCode == 46) {
                    this.selectionStart = currentindex;
                    this.selectionEnd = currentindex;
                }
                else {
                    this.selectionStart = currentindex - 1;
                    this.selectionEnd = currentindex - 1;
                }
            }
        }
    });

}

//29May2014 Sathish Added the method to validate control to accept only Number
function NumbersOnly(cntrl) {
    //Prevent key press event
    $('#' + cntrl).keydown(function (e) {
        if (e.shiftKey || e.ctrlKey || e.altKey) {
            e.preventDefault();
        } else {
            var key = e.keyCode;
            if ((key < 47 || key > 57) && (key < 96 || key > 105) && (key != 190) && (key != 110) // Check is the key number only
                && !(key == 8 || key == 9 || key == 13 || key == 45 || key == 46)  // Backspace, Tab, Enter, Insert, and Delete
                && !((key > 16 && key < 21) || (key > 34 && key < 41)) // Ctrl, Alt, CapsLock, Home, End, and Arrows
                ) {
                e.preventDefault();
            }
        }
    });

    //Prevent key press event
    $('#' + cntrl).bind("paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });
}

//Added by prasana on 11.07.2014 for SSN Number Phone Number and Zipccode
//vivek 14-7-14 modified for the not accepting Dot 
function NumbersOnlyNotAcceptingDot(cntrl) {
    //Prevent key press event
    $('#' + cntrl).keydown(function (e) {
        if (e.shiftKey || e.ctrlKey || e.altKey) {
            e.preventDefault();
        } else {
            var key = e.keyCode;
            if ((key < 47 || key > 57) && (key < 96 || key > 105 || key == 110)  // Check is the key number only
                && !(key == 8 || key == 9 || key == 13 || key == 45 || key == 46)  // Backspace, Tab, Enter, Insert, and Delete
                && !((key > 16 && key < 21) || (key > 34 && key < 41)) // Ctrl, Alt, CapsLock, Home, End, and Arrows
                ) {
                e.preventDefault();
            }
        }
    });

    //Prevent key press event
    $('#' + cntrl).bind("paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });
}

//29May2014 Vivek Added the method to validate control to accept only letter,White space,numbers and _ symbols
//Modified by prasana for restricting characters ~ and ` and accepting - instead of _ on 18.06.2014
function NumbersLettersAndHyphen(cntrl) {
    //Prevent key press event
    $('#' + cntrl).keydown(function (e) {
        var currentindex = getCaret(this);
        if (e.keyCode == 220) {
            e.preventDefault();
        }
        else {
            var controlValue = this.value;
            var iChars = "!@#$%^&*()+=_[]\\\';,./{}|\":<>?`~";
            var lengthoftext = controlValue.length;
            for (var i = 0; i < lengthoftext; i++) {
                if (iChars.indexOf(controlValue.charAt()) != -1) {
                    if (controlValue.charAt(i) == '[') {
                        controlValue = controlValue.replace(/\[/g, '');
                    }
                    else if (controlValue.charAt(i) == ']') {
                        controlValue = controlValue.replace(/\]/g, '');
                    }
                    else if (controlValue.charAt(i) == '^') {
                        controlValue = controlValue.replace(/\^/g, '');
                    }
                    else {
                        var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                        controlValue = controlValue.replace(removespecialcharacter, '');
                    }
                    this.value = controlValue;
                    if (event.keyCode == 46) {
                        this.selectionStart = currentindex;
                        this.selectionEnd = currentindex;
                    }
                    else {
                        this.selectionStart = currentindex - 1;
                        this.selectionEnd = currentindex - 1;
                    }
                }
            }
        }
    });

    $('#' + cntrl).keyup(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = "!@#$%^&*()+=_[]\\\';,./{}|\":<>?`~";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                if (controlValue.charAt(i) == '[') {
                    controlValue = controlValue.replace(/\[/g, '');
                }
                else if (controlValue.charAt(i) == ']') {
                    controlValue = controlValue.replace(/\]/g, '');
                }
                else if (controlValue.charAt(i) == '^') {
                    controlValue = controlValue.replace(/\^/g, '');
                }
                else {

                    var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                    controlValue = controlValue.replace(removespecialcharacter, '');
                }
                this.value = controlValue;

                if (event.keyCode == 46) {
                    this.selectionStart = currentindex;
                    this.selectionEnd = currentindex;
                }
                else {
                    this.selectionStart = currentindex - 1;
                    this.selectionEnd = currentindex - 1;
                }
            }
        }

    });
}




//11Aug2014 Thileep Added the method to validate control to accept only letter,hyphen and numbers
function NumbersLettersAndHyphenWithoutSpace(cntrl) {
    //Prevent key press event
    $('#' + cntrl).keydown(function (e) {
        var currentindex = getCaret(this);
        if (e.keyCode == 220) {
            e.preventDefault();
        }
        else {
            var controlValue = this.value;
            var iChars = " !@#$%^&*()+=_[]\\\';,./{}|\":<>?`~ ";
            var lengthoftext = controlValue.length;
            for (var i = 0; i < lengthoftext; i++) {
                if (iChars.indexOf(controlValue.charAt()) != -1) {
                    if (controlValue.charAt(i) == '[') {
                        controlValue = controlValue.replace(/\[/g, '');
                    }
                    else if (controlValue.charAt(i) == ']') {
                        controlValue = controlValue.replace(/\]/g, '');
                    }
                    else if (controlValue.charAt(i) == '^') {
                        controlValue = controlValue.replace(/\^/g, '');
                    }
                    else {
                        var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                        controlValue = controlValue.replace(removespecialcharacter, '');
                    }
                    this.value = controlValue;
                    if (event.keyCode == 46) {
                        this.selectionStart = currentindex;
                        this.selectionEnd = currentindex;
                    }
                    else {
                        this.selectionStart = currentindex - 1;
                        this.selectionEnd = currentindex - 1;
                    }
                }
            }
        }
    });

    $('#' + cntrl).keyup(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = " !@#$%^&*()+=_[]\\\';,./{}|\":<>?`~";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                if (controlValue.charAt(i) == '[') {
                    controlValue = controlValue.replace(/\[/g, '');
                }
                else if (controlValue.charAt(i) == ']') {
                    controlValue = controlValue.replace(/\]/g, '');
                }
                else if (controlValue.charAt(i) == '^') {
                    controlValue = controlValue.replace(/\^/g, '');
                }
                else {

                    var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                    controlValue = controlValue.replace(removespecialcharacter, '');
                }
                this.value = controlValue;

                if (event.keyCode == 46) {
                    this.selectionStart = currentindex;
                    this.selectionEnd = currentindex;
                }
                else {
                    this.selectionStart = currentindex - 1;
                    this.selectionEnd = currentindex - 1;
                }
            }
        }

    });
}

//Added by prasana on accepting letter and numbers alone(alphanumeric) oon 27.06.2014
function NumbersLetters(cntrl) {
    //Prevent key press event
    $('#' + cntrl).keydown(function (e) {
        var currentindex = getCaret(this);
        if (e.keyCode == 220 || e.keyCode == 32) {
            e.preventDefault();
        }
        else {
            var controlValue = this.value;
            var iChars = "!@#$%^&*()+=_[]\\\';,./{}|\":<>?`~-";
            var lengthoftext = controlValue.length;
            for (var i = 0; i < lengthoftext; i++) {
                if (iChars.indexOf(controlValue.charAt()) != -1) {
                    if (controlValue.charAt(i) == '[') {
                        controlValue = controlValue.replace(/\[/g, '');
                    }
                    else if (controlValue.charAt(i) == ']') {
                        controlValue = controlValue.replace(/\]/g, '');
                    }
                    else if (controlValue.charAt(i) == '^') {
                        controlValue = controlValue.replace(/\^/g, '');
                    }
                    else {
                        var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                        controlValue = controlValue.replace(removespecialcharacter, '');
                    }
                    this.value = controlValue;
                    if (event.keyCode == 46) {
                        this.selectionStart = currentindex;
                        this.selectionEnd = currentindex;
                    }
                    else {
                        this.selectionStart = currentindex - 1;
                        this.selectionEnd = currentindex - 1;
                    }

                }

            }

        }
    });

    $('#' + cntrl).keyup(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = "!@#$%^&*()+=_[]\\\';,./{}|\":<>?`~-";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                if (controlValue.charAt(i) == '[') {
                    controlValue = controlValue.replace(/\[/g, '');
                }
                else if (controlValue.charAt(i) == ']') {
                    controlValue = controlValue.replace(/\]/g, '');
                }
                else if (controlValue.charAt(i) == '^') {
                    controlValue = controlValue.replace(/\^/g, '');
                }
                else {

                    var removespecialcharacter = new RegExp('[' + controlValue.charAt(i) + ']', 'g');
                    controlValue = controlValue.replace(removespecialcharacter, '');
                }
                this.value = controlValue;

                if (event.keyCode == 46) {
                    this.selectionStart = currentindex;
                    this.selectionEnd = currentindex;
                }
                else {
                    this.selectionStart = currentindex - 1;
                    this.selectionEnd = currentindex - 1;
                }
            }
        }

    });
}

function extractNumberBlur(obj, e, decimalPlaces, allowNegative, blurevent) {
    if (e.keyCode != 37 && e.keyCode != 38 && e.keyCode != 39 && e.keyCode != 40 && e.keyCode != 17) {
        var temp = obj.value;
        if (blurevent) {

            if (temp.indexOf("..") > -1) {
                temp = temp.replace(/\./g, '');
            }

            if (decimalPlaces != 0) {
                var reg3 = /\./g;
                var reg3Array = reg3.exec(temp);
                if (reg3Array != null) {

                    // keep only first occurrence of .
                    //  and the number of places specified by decimalPlaces or the entire string if decimalPlaces < 0
                    var reg3Right = temp.substring(reg3Array.index + reg3Array[0].length);
                    reg3Right = reg3Right.replace(reg3, '');
                    reg3Right = decimalPlaces > 0 ? reg3Right.substring(0, decimalPlaces) : reg3Right;
                    var zerovalue = '00';
                    if (reg3Right == "00") {
                        zerovalue = '';
                    }
                    if (reg3Right.length == 1) {
                        temp = temp.substring(0, reg3Array.index) + '.' + reg3Right + "0";
                    }
                    else if (reg3Right != '' && reg3Right.length == 0) {
                        temp = temp + '0';
                    }
                    else if (reg3Right == '') {
                        temp = temp + zerovalue;
                    }
                    else if (reg3Right.length == decimalPlaces) {
                        temp = temp.substring(0, reg3Array.index) + '.' + reg3Right;
                    }
                }
                else {
                    if (temp == '') {
                        // temp = temp + '0.00';
                    }
                    else {
                        if (temp.length + 1 == obj.maxLength) {
                            temp = temp.substring(0, obj.maxLength - (decimalPlaces + 1)) + '.' + temp.substring((obj.maxLength - (decimalPlaces + 1)), obj.maxLength);
                        }
                        else {
                            temp = temp + '.00';
                        }
                    }
                }
            }
            obj.value = temp;
        }
    }

    if (currentObjectName != '' && currentObjectName != obj.id) return;

    currentObjectName = obj.id;

    currentObjectName = '';
    return true;

}

function extractNumber(obj, e, decimalPlaces, allowNegative, blurevent) {

    var temp = obj.value;
    if (temp == '.') {
        temp = '';
    }

    var currentindex = getCaret(obj);
    obj.selectionStart = currentindex;
    obj.selectionEnd = currentindex;
    var decimalindex = 0
    if (e.keyCode != 37 && e.keyCode != 38 && e.keyCode != 39 && e.keyCode != 40 && e.keyCode != 17) {
        // if (e.keyCode != 37 && e.keyCode != 39 && e.keyCode != 46 && e.keyCode != 8 && e.keyCode != undefined && e.keyCode != 17) {
        // avoid changing things if already formatted correctly
        var reg0Str = '[0-9]$';
        if (decimalPlaces > 0) {
            reg0Str += '\\.?[0-9]{0,' + decimalPlaces + '}';
        } else if (decimalPlaces < 0) {
            reg0Str += '\\.?[0-9]*';
        }
        reg0Str = allowNegative ? '^-?' + reg0Str : '^' + reg0Str;
        reg0Str = reg0Str + '$';

        var maxlengthspecified = obj.maxLength;

        maxlengthspecified = maxlengthspecified - (decimalPlaces + 1);
        if (decimalPlaces != 0 && maxlengthspecified != 2147483647 && temp.length > maxlengthspecified && temp.indexOf('.') == -1) {

            temp = temp.substring(0, maxlengthspecified) + '.' + temp.substring(maxlengthspecified, maxlengthspecified + 1);
        }

        var reg0 = new RegExp(reg0Str);
        if (reg0.test(temp)) return true;

        // first replace all non numbers
        var reg1Str = '[^0-9' + (decimalPlaces != 0 ? '.' : '') + (allowNegative ? '-' : '') + ']';
        var reg1 = new RegExp(reg1Str, 'g');
        temp = temp.replace(reg1, '');

        if (allowNegative) {
            // replace extra negative
            var hasNegative = temp.length > 0 && temp.charAt(0) == '-';
            var reg2 = /-/g;
            temp = temp.replace(reg2, '');
            if (hasNegative) temp = '-' + temp;
        }

        if (decimalPlaces != 0) {
            var reg3 = /\./g;
            var reg3Array = reg3.exec(temp);
            if (reg3Array != null) {

                // keep only first occurrence of .
                //  and the number of places specified by decimalPlaces or the entire string if decimalPlaces < 0
                var reg3Right = temp.substring(reg3Array.index + reg3Array[0].length);
                reg3Right = reg3Right.replace(reg3, '');
                reg3Right = decimalPlaces > 0 ? reg3Right.substring(0, decimalPlaces) : reg3Right;
                if (reg3Right.length == 1)
                    decimalindex = 1;
                if (blurevent && reg3Right == '') {
                    temp = temp.substring(0, reg3Array.index) + '.00';
                }
                else {

                    temp = temp.substring(0, reg3Array.index) + '.' + reg3Right;
                }
            }
        }

        obj.value = temp;

        if (currentindex != 'undefined') {
            obj.selectionStart = currentindex + decimalindex;
            obj.selectionEnd = currentindex + decimalindex;
        }


    }
    else if (e.keyCode == 46 || e.keyCode == 8) {
        obj.selectionStart = currentindex;
        obj.selectionEnd = currentindex;
    }

    return false;

}

function blockNonNumbers(obj, eventoftxtbox, allowDecimal, allowNegative) {
    // if (eventoftxtbox.keyCode != 37 && eventoftxtbox.keyCode != 38 && eventoftxtbox.keyCode != 39 && eventoftxtbox.keyCode != 40) {
    var key;
    var isCtrl = false;
    var keychar;
    var reg;

    if (window.event) {
        key = eventoftxtbox.keyCode;
        isCtrl = window.event.ctrlKey
    }
    else if (eventoftxtbox.which) {
        key = eventoftxtbox.which;
        isCtrl = eventoftxtbox.ctrlKey;
    }

    if (isNaN(key)) return true;

    keychar = String.fromCharCode(key);

    // check for backspace or delete, or if Ctrl was pressed
    if (key == 8 || isCtrl) {
        return true;
    }

    reg = /\d/;
    var isFirstN = allowNegative ? keychar == '-' && obj.value.indexOf('-') == -1 : false;
    var isFirstD = allowDecimal ? keychar == '.' && obj.value.indexOf('.') == -1 : false;

    return isFirstN || isFirstD || reg.test(keychar);
    // }
}

function blockSpace(obj, e) {
    var key;
    var isCtrl = false;
    var keychar;
    var reg;

    if (window.event) {
        key = e.keyCode;
        isCtrl = window.event.ctrlKey;
    }
    else if (e.which) {
        key = e.which;
        isCtrl = e.ctrlKey;
    }

    keychar = String.fromCharCode(key);

    // check for backspace or delete, or if Ctrl was pressed
    if (key == 8 || isCtrl) {
        return true;
    }

    if (key == 32) {
        return false;
    }
    return keychar;
}

function getCaret(el) {
    if (el.selectionStart) {
        return el.selectionStart;
    } else if (document.selection) {
        el.focus();

        var r = document.selection.createRange();
        if (r == null) {
            return 0;
        }

        var re = el.createTextRange(),
            rc = re.duplicate();
        re.moveToBookmark(r.getBookmark());
        rc.setEndPoint('EndToStart', re);

        return rc.text.length;
    }
    return 0;
}

//Masked the input phone number to display in "123-23-1234" format
function maskInput(input, textbox, location, eventoftxtbox, checkforZipCode, Phonenumber) {
    var currentindex = getCaret(textbox);
    var reg0Str = '^\d{3}-?\d{2}-?\d{4}$';

    if (checkforZipCode == undefined) {
        checkforZipCode = false;
    }
    if (Phonenumber == undefined) {
        Phonenumber = false;
    }

    if (checkforZipCode) {
        reg0Str = '^\d{5}-?\d{4}$';
    }

    if (Phonenumber) {
        reg0Str = '^\d{3}-?\d{3}-?\d{4}$';
    }

    var reg0 = new RegExp(reg0Str);
    if (reg0.test(input)) return true;


    if (eventoftxtbox.keyCode != 37 && eventoftxtbox.keyCode != 38 && eventoftxtbox.keyCode != 39 && eventoftxtbox.keyCode != 40 && eventoftxtbox.keyCode != 17) {
        var delimiter = '-';
        if (input != '') {
            input = input.replace(/\-/g, '');
        }
        if (Phonenumber) {
            input = input.substring(0, 10);
        }
        else {
            if (input.length > 9) {
                input = input.substring(0, 9);
            }
        }
        //Get the delimiter positons
        var locs = location.split(',');

        if (checkforZipCode) {
            //Iterate until all the delimiters are placed in the textbox
            for (var delimCount = 0; delimCount <= locs.length; delimCount++) {
                for (var inputCharCount = 0; inputCharCount <= 5; inputCharCount++) {

                    //Check for the actual position of the delimiter
                    if (inputCharCount == locs[delimCount] && input.length > 5) {

                        //Confirm that the delimiter is not already present in that position
                        if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                            input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                            if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                                input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                            }
                        }
                    }
                }
            }
        }
        else {
            //Iterate until all the delimiters are placed in the textbox
            for (var delimCount = 0; delimCount <= locs.length; delimCount++) {
                for (var inputCharCount = 0; inputCharCount <= input.length; inputCharCount++) {

                    //Check for the actual position of the delimiter
                    if (inputCharCount == locs[delimCount] && input.length > locs[delimCount]) {

                        //Confirm that the delimiter is not already present in that position
                        if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                            input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                            if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                                input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                            }
                        }
                    }
                }
            }
        }

        textbox.value = input;
        if (currentindex != 'undefined') {

            if (eventoftxtbox.keyCode == 46) {
                textbox.selectionStart = currentindex;
                textbox.selectionEnd = currentindex;
            }
            else {
                textbox.selectionStart = currentindex + 1;
                textbox.selectionEnd = currentindex + 1;
            }
        }
    }
}

//Masked the input EIN to display in "33-3456789" format
function maskInputForEIN(input, textbox, location, eventoftxtbox) {

    var currentindex = getCaret(textbox);
    var reg0Str = '^\d{2}-?\d{7}$';
    var reg0 = new RegExp(reg0Str);
    if (reg0.test(input)) return true;

    if (eventoftxtbox.keyCode != 37 && eventoftxtbox.keyCode != 38 && eventoftxtbox.keyCode != 39 && eventoftxtbox.keyCode != 40 && eventoftxtbox.keyCode != 17) {
        var delimiter = '-';
        if (input != '') {
            input = input.replace(/\-/g, '');
        }

        if (input.length > 9) {
            input = input.substring(0, 9);
        }
        //Get the delimiter positons
        var locs = location.split(',');


        //Iterate until all the delimiters are placed in the textbox
        for (var delimCount = 0; delimCount <= locs.length; delimCount++) {
            for (var inputCharCount = 0; inputCharCount <= input.length; inputCharCount++) {

                //Check for the actual position of the delimiter
                if (inputCharCount == locs[delimCount] && input.length > locs[delimCount]) {

                    //Confirm that the delimiter is not already present in that position
                    if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                        input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                        if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                            input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                        }
                    }
                }
            }
        }

        textbox.value = input;
        if (currentindex != 'undefined') {

            if (eventoftxtbox.keyCode == 46) {
                textbox.selectionStart = currentindex;
                textbox.selectionEnd = currentindex;
            }
            else {

                textbox.selectionStart = currentindex + 1;
                textbox.selectionEnd = currentindex + 1;
            }
        }
    }
}

function DecimalNumberCheck(input, textbox, location, eventoftxtbox) {
    // obj, e, decimalPlaces, allowNegative, blurevent
    var currentindex = getCaret(textbox);
    var reg0Str = '^\d{7}.?\d{2}$';
    var reg0 = new RegExp(reg0Str);
    if (reg0.test(input)) return true;

    if (eventoftxtbox.keyCode != 37 && eventoftxtbox.keyCode != 38 && eventoftxtbox.keyCode != 39 && eventoftxtbox.keyCode != 40 && eventoftxtbox.keyCode != 17 && eventoftxtbox.keyCode != 116) {
        var delimiter = '.';
        //if (input != '') {
        //    input = input.replace(/\./g, '');
        //}
        var isdecimal = false;
        var deciamlpoint;
        var splitvalue = input.split('.');
        if (splitvalue[1] != undefined && splitvalue[1].length != 0) {
            input = splitvalue[0];
            deciamlpoint = splitvalue[1].substring(0, 2);
            isdecimal = true;
        }


        if (input.length > 9) {
            input = input.substring(0, 9);
        }
        //Get the delimiter positons
        var locs = location.split(',');


        //Iterate until all the delimiters are placed in the textbox
        for (var delimCount = 0; delimCount <= locs.length; delimCount++) {
            for (var inputCharCount = 0; inputCharCount <= input.length; inputCharCount++) {

                //Check for the actual position of the delimiter
                if (inputCharCount == locs[delimCount]) {

                    //Confirm that the delimiter is not already present in that position
                    if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                        if (isdecimal) {
                            input = input.substring(0, inputCharCount);
                        }
                        else {
                            input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                        }
                        //if (input.substring(inputCharCount, inputCharCount + 1) != delimiter) {
                        //    input = input.substring(0, inputCharCount) + delimiter + input.substring(inputCharCount, input.length);
                        //}
                    }
                }
            }
        }

        if (isdecimal && deciamlpoint != "") {
            input = input + "." + deciamlpoint;
        }

        textbox.value = input;
        if (currentindex != 'undefined') {

            if (eventoftxtbox.keyCode == 46) {
                textbox.selectionStart = currentindex;
                textbox.selectionEnd = currentindex;
            }
            else {

                textbox.selectionStart = currentindex;
                textbox.selectionEnd = currentindex;
            }
        }
    }
}

function DecimalNumberCheckBlur(obj, e, decimalPlaces) {

    var temp = obj.value;

    if (decimalPlaces != 0) {
        var reg3 = /\./g;
        var reg3Array = reg3.exec(temp);
        if (reg3Array != null) {

            // keep only first occurrence of .
            //  and the number of places specified by decimalPlaces or the entire string if decimalPlaces < 0
            var reg3Right = temp.substring(reg3Array.index + reg3Array[0].length);
            reg3Right = reg3Right.replace(reg3, '');
            reg3Right = decimalPlaces > 0 ? reg3Right.substring(0, decimalPlaces) : reg3Right;
            var zerovalue = '00';
            if (reg3Right == "00") {
                zerovalue = '';
            }
            if (reg3Right.length == 1) {
                decimalindex = 1;
                temp = temp.substring(0, reg3Array.index) + '.' + reg3Right + "0";
            }
            else if (reg3Right != '' && reg3Right.length == 0) {
                temp = temp + '0';
            }
            else if (reg3Right == '') {
                temp = temp + zerovalue;
            }
        }
        else {
            if (temp == '') {
                // temp = temp + '0.00';
            }
            else {
                temp = temp + '.00';
            }
        }
    }
    obj.value = temp;

    if (currentObjectName != '' && currentObjectName != obj.id) return;

    currentObjectName = obj.id;


    currentObjectName = '';
    return true;

}

//vivek 18-june-14 US currency formate
function currencyformate(value) {
    var formate = value.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    return formate;
}

//Vincent-26/06/14- Genernating 1040EZ Output Form
function Genernate1040EZForm() {
    $.ajax({
        url: serviceUrl + 'taxesandwrapup/genernate1040ezform',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            var worksheet = serviceUrl + 'taxreturn/getworksheet/' + userId + '/' + userDataId
            window.location.href = worksheet + '/F1040EZBinding';

        }
    });


}


//06Aug2014 Sathish To remove control Highlighting 
function RemoveControlHighlighting(cntrlId) {
    $('#' + cntrlId).blur(function (e) {
        if ($('#' + cntrlId).prop('type') == "select-one") {
            if($('#' + cntrlId).val() != '0' || $('#' + cntrlId).val() != '')
                $('#' + cntrlId).removeClass("amountField tip error").addClass("form-control tip amountField");
        }
        else {
            if($('#' + cntrlId).val() != '')
            $('#' + cntrlId).removeClass("amountField tip error").addClass("form-control tip amountField");
        }
    });
}

//Saravanan N - 8th Aug, 2014 - Since, rightmenu.js reference removed from Income related HTML pages, moved this method from rightmenu.js to here.
function RefundAmountCalculation() {

    $.ajax({
        url: serviceUrl + 'taxreturn/getfederalsummarydetails',
        async: true,
        dataType: 'json',
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        })
        ,
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                var totalRefundAmount = currencyformate(Math.round(Math.abs(data)));
                if (data == 0) {
                    $('#lblrefundorOweAmount').html("");
                }
                else if (data < 0) {
                    $('#lblrefundorOweAmount').html("Refund");
                    $('#spnFederalRefund').addClass("text-success");
                }
                else {
                    $('#lblrefundorOweAmount').html("Tax Due");
                    $('#spnFederalRefund').addClass("text-danger");
                }
                $('#spnFederalRefund').html(totalRefundAmount);


            }
        }
    });
}