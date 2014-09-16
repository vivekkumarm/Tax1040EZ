// validate signup form on keyup and submit
$(document).ready(function () {
    //var date = new Date();
    //var currentMonth = date.getMonth();
    //var currentDate = date.getDate();
    //var currentYear = date.getFullYear();
    //$('#dtDateofBirth').datepicker({
    //    showOn: 'button',
    //    buttonText: 'Show Date',
    //    buttonImageOnly: true,
    //    buttonImage: 'http://jqueryui.com/resources/demos/datepicker/images/calendar.gif',
    //    dateFormat: 'mm/dd/yy',
    //    constrainInput: true,

    //    maxDate: new Date(currentYear, currentMonth, currentDate)
    //});
    
    
    NumbersOnlyNotAcceptingDot('txtSSN');
    LettersAndSpaceOnly('txtFirstName');
    LettersAndSpaceOnly('txtLastName');
   

    $("#UnableToAccessAccount").validate({
        rules: {
            txtFirstName: {
                required: true,
                lettersonly: true
            },
            txtLastName: {
                required: true,
                lettersonly: true
            },
            dtDateofBirth: {
                required: function () { $('#divDOBErrorMsg').html(''); true; },
                validateDate: function () { $('#divDOBErrorMsg').html(''); true; }
            },
            txtSSN: {
                required: true,
                minlength: 11,
                validateSSN: true
            }

        },
        messages: {
            txtFirstName: {
                required: "Missing Taxpayer First Name.",
                lettersonly: "First Name can have only alphabets."
            },
            txtLastName: {
                required: "Missing Taxpayer Last Name.",
                lettersonly: "Last Name can have only alphabets."
            },
            dtDateofBirth: {
                required: function () { $('#divDOBErrorMsg').html('Missing Taxpayer Date of Birth.'); true; },

                validateDate: function () { $('#divDOBErrorMsg').html('Incorrect Date of birth.'); true; }
            },
            txtSSN: {
                required: "Missing Taxpayer Social Security Number.",
                minlength: "Incorrect Social security Number.",
                validateSSN: "Incorrect Social security Number."
            }
        }
    });

    $('#divDateOfBirth').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,       
        onClose: function () { $(this).valid(); },
    });

    $('#divDateOfBirth').on('changeDate', function (ev) {
        $(this).datepicker('hide');
        $('#divDOBErrorMsg').html('');

        if ($('#dtDateofBirth').val() != "") {
            $('#divDOBErrorMsg').html('');
        }
        else {
            $('#divDOBErrorMsg').html('Missing Taxpayer Date of Birth.');
        }
    });
    //vivek 30-june-14 for the calendar focus
    $('#txtLastName').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#txtSSN').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });
    //vivek 12-Aug-14 for the calendar focus
    //$('#dtDateofBirth').focusout(function () {
    //    $('#divDateOfBirth').datepicker('hide');
    //});
    //Thileep Changed quickhelp content on 09July2014
    //Vincent-5Aug2014-made a changes in quick help Scenario 
    $(function () {
        $("#popFirstName").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your First Name?</h5>We ask for your First Name to pull out your records.<br/><br/>Don't worry! It's a part of our stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your Last Name?</h5>We ask for your Last Name to pull out your records.<br/><br/>Don't worry! It's a part of our stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofBirth").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your Date of Birth?</h5>Don't Panic! Your Date of Birth is required for verification and security purposes.<br/><br/>All your personal information are safe with us!<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSSN").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your SSN?</h5>Your Social Security Number(SSN) is a unique data we use to validate your Tax Garden account.<br/><br/>Don't worry! We maintain high security standards to make sure that we correspond only to you.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
    var date = new Date();
    var currentMonth = date.getMonth();
    var currentDate = date.getDate();
    var currentYear = date.getFullYear();

    //25 Aug 2014- Bala- For removing setTimeOut function 
    $('#cmdSubmit').click(function () {

        if (GetUserNameByPesonalInfo()) {
            window.location.href = '../PreLogin/securityquestionbycondition.html';
        }
        return false;
    });

    
});

function GetUserNameByPesonalInfo() {
    $("#dtDateofBirth").val();
    var isUserExist = false;
    if ($("#UnableToAccessAccount").valid()) {
        $.ajax({
            url: serviceUrl + 'user/getuseridbyuserdetails',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "FirstName": $("#txtFirstName").val(),
                "LastName": $("#txtLastName").val(),
                "DateOfBirth": $("#dtDateofBirth").val(),
                "SSN": $("#txtSSN").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == 0) {
                    $("#divErrorMsg").show();
                    //16July 2014 Thileep Changed Error message as per PreloginSpec(V1.9) 
                    $("#divErrorMsg").html("Incorrect Information. Contact Customer Support!.");
                }
                else {
                    isUserExist = true;
                    $("#divErrorMsg").hide();                   
                    window.sessionStorage.setItem("UserId", data);
                    window.sessionStorage.setItem("PreviousPage", "UnabletoAccessEmailAddress");
                }
            }
        });
    }
    return isUserExist;
}