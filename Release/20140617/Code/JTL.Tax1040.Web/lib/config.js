/// <reference path="../lib/popovercontent.js" />
/// <reference path="../Scripts/popover.js" />
/// <reference path="../Scripts/tooltip.js" />


document.write("<script type='text/javascript' src='../Scripts/tooltip.js'> </script>");
document.write("<script type='text/javascript' src='../Scripts/popover.js'> </script>");
//document.write("<script type='text/javascript' src='../lib/popovercontent.js' </script>");

// 09Jun2014 Sathish refer javascript for user ideal section
document.write("<script type='text/javascript' src='../Scripts/jquery.idletimeout.js'></script>");
document.write(" <script type='text/javascript' src='../Scripts/jquery.idletimer.js'></script>");

//var serviceUrl = 'http://192.168.1.200:1040/';
var userId;
var userDataId;
var serviceUrl = 'http://localhost:9797/';
var CURRENT_TAX_YEAR = '2014';  //Saravanan - 22nd April, 2014 - Constants added.
var FILLING_YEAR = 'April 15th 2015'; // Sathsih - 06 May 2014 Filling year
var previousPageURL; // Sathish - 25th April, 2014 maintain the previous page URL
var STATE_OF_RESIDENCE = '12/31/2014'; // vivek -18

//Saravanan - 23rd April, 2014 - Constants added.
var SINGLE_AGI_LIMIT = 14340;
var MFJ_AGI_LIMIT = 19680;
var FILING_STATUS_SINGLE = 1;
var FILING_STATUS_MFJ = 2;
var CONTINUE_BUTTON_CAPTION = 'CONTINUE';
var BACK_BUTTON_CAPTION = 'BACK';
var TITLE = 'TaxGarden.com';
var ZIPCODE5ZEROS = '00000';
var ZIPCODE9ZEROSWITHHYPEN = '00000-0000';
var ZIPCODE9NINESWITHHYPEN = '99999';
var ZIPCODE5NINES = '99999-9999';
var SSN9ZEROS = '000-00-0000';
var SSN9Nines = '999-99-9999';
var SSN10ZEROS = '000-000-0000';
var SSN10Nines = '999-999-9999';
var EMPTY_RECORD = 'No Information Provided';
var currentObjectName = '';
var FILING_START_DATE = '01-01-2015';
var FILING_END_DATE = '04-15-2015';

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

        jQuery.validator.addMethod("validateEINFor0000",
            function (value, element) {
                if ((value != null && value != '')) {
                    if (value.length == 10) {
                        if (value == '00-0000000' || value == '99-9999999') {
                            return false;
                        }
                        else {
                            return true;
                        }
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


        jQuery.validator.addMethod("validateSSN",
        function (value, element) {
            if ((value != null && value != '')) {
                if (value.length == 11) {
                    if (value == SSN9ZEROS || value == SSN9Nines) {
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
                     if (value == ZIPCODE5ZEROS || value == ZIPCODE9ZEROSWITHHYPEN || value == ZIPCODE5NINES || value == ZIPCODE9NINESWITHHYPEN) {
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


        jQuery.validator.addMethod("validatePhoneNumber",
 function (value, element) {
     if ((value != null && value != '')) {

         if (value.length == 12) {
             if (value == SSN10ZEROS || value == SSN10Nines) {
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



        jQuery.validator.addMethod("lettersonly", function (value, element) {
            return this.optional(element) || /^[a-z]+$/i.test(value);
        }, "Letters only  please");

    }

    previousPageURL = document.referrer;


    userId = JSON.parse(window.sessionStorage.getItem("UserId"));

    if (!window.sessionStorage.UserDataId) {

        userDataId = 0;

    } else {

        userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    }


    // 09Jun2014 Sathish redirect to login and clear the session if the user is ideal for 20 min
    if (userId != null && userId != 0) {
        $.idleTimer(20 * 60 * 1000); // min * sec * microsecond
    }

    // 09Jun2014 Sathish redirect to login and clear the session if the user is ideal for 20 min
    $(document).bind("idle.idleTimer", function () {
        // function you want to fire when the user goes idle
        window.sessionStorage.clear();
        window.location.href = "../login.html";
        $.idleTimer('destroy');
    });

});



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
function LettersAndSpaceOnly(cntrl, e) {
    $('#' + cntrl).keydown(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = "!@#$%^&*()0123456789+=-[]\\\';,./{}|\":<>?`~";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                controlValue = controlValue.replace(controlValue.charAt(i), '')
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


    $('#' + cntrl).keyup(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = "!@#$%^&*()0123456789+=-[]\\\';,./{}|\":<>?`~";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                controlValue = controlValue.replace(controlValue.charAt(i), '')
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
            if ((key < 47 || key > 57) && (key < 96 || key > 105) // Check is the key number only
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
        var controlValue = this.value;
        var iChars = "!@#$%^&*()+=_[]\\\';,./{}|\":<>?`~";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt()) != -1) {
                controlValue = controlValue.replace(controlValue.charAt(i), '')
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

    $('#' + cntrl).keyup(function (e) {
        var currentindex = getCaret(this);
        var controlValue = this.value;
        var iChars = "!@#$%^&*()+=_[]\\\';,./{}|\":<>?`~";
        var lengthoftext = controlValue.length;
        for (var i = 0; i < lengthoftext; i++) {
            if (iChars.indexOf(controlValue.charAt(i)) != -1) {
                controlValue = controlValue.replace(controlValue.charAt(i), '')
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
            //return false;
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
    else {
         //  obj.selectionStart = currentindex + 1;
         //  obj.selectionEnd = currentindex + 1;
    }


    //if (decimalPlaces != 0) {
    //    var reg3 = /\./g;
    //    var reg3Array = reg3.exec(temp);
    //    if (reg3Array != null) {

    //        // keep only first occurrence of .
    //        //  and the number of places specified by decimalPlaces or the entire string if decimalPlaces < 0
    //        var reg3Right = temp.substring(reg3Array.index + reg3Array[0].length);
    //        reg3Right = reg3Right.replace(reg3, '');
    //        reg3Right = decimalPlaces > 0 ? reg3Right.substring(0, decimalPlaces) : reg3Right;
    //        var zerovalue = '00';
    //        if (reg3Right == "00") {
    //            zerovalue = '';
    //        }
    //        if (reg3Right.length == 1) {
    //            decimalindex = 1;
    //            temp = temp.substring(0, reg3Array.index) + '.' + reg3Right + "0";
    //        }
    //        else if (reg3Right != '' && reg3Right.length == 0) {
    //            temp = temp + '0';
    //        }
    //        else if (reg3Right == '') {
    //            temp = temp + zerovalue;
    //        }
    //    }
    //    else {
    //        if (temp == '') {
    //            // temp = temp + '0.00';
    //        }
    //        else {
    //            temp = temp + '.00';
    //        }
    //    }
    //}
    //obj.value = temp;


    //if (e.keyCode == undefined) {
    //    e.preventDefault();
    //}

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
            input = input.substring(0, 10)
        }
        else {
            if (input.length > 9) {
                input = input.substring(0, 9)
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
                    if (inputCharCount == locs[delimCount]) {

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
            input = input.substring(0, 9)
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

//vivek 18-june-14 US currency formate
function currencyformate(value) {
    var formate = value.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",")
    return formate;
}