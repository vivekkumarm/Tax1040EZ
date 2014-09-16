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
    
    
    NumbersOnly('txtSSN');
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
                required: "Missing First Name",
                lettersonly: "Use only alphabets. (No special characters, numbers and Punctuations)"
            },
            txtLastName: {
                required: "Missing Last Name",
                lettersonly: "Use only alphabets. (No special characters, numbers and Punctuations)"
            },
            dtDateofBirth: {
                required: function () { $('#divDOBErrorMsg').html('Missing Date of Birth'); true; },

                validateDate: function () { $('#divDOBErrorMsg').html('Incorrect Date of birth'); true; }
            },
            txtSSN: {
                required: "Missing Social security Number",
                minlength: "Incorrect Social security Number",
                validateSSN: "Incorrect Social security Number"
            }
        }
    });

    $('#divDateOfBirth').datepicker({
        format: "mm/dd/yyyy",
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
            $('#divDOBErrorMsg').html('Missing Date of Birth');
        }
    });


    $(function () {
        $("#popFirstName").popover({ title: '', content: "<h5>Why do we need your First Name?</h5>Your First Name is required to maintain a valid database and for security purposes. Don't worry! We maintain all your data with stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>Why do we need your Last Name?</h5>Your Last Name is required to maintain a valid database and for security purposes. Don't worry! We maintain all your data with stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofBirth").popover({ title: '', content: "<h5>Why do we need your Date of Birth?</h5>Don't Panic! Your Date of Birth is required for verification and security purposes. All your personal information are safe with us!<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSSN").popover({ title: '', content: "<h5>Why do we need your SSN?</h5>Your Social Security Number (SSN) is a unique data we use to validate your Tax Garden account. We maintain high security standards to make sure that we correspond only to you. Don't worry! We always make sure to protect all your sensitive information.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
    var date = new Date();
    var currentMonth = date.getMonth();
    var currentDate = date.getDate();
    var currentYear = date.getFullYear();

    
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
                    $("#divErrorMsg").html("Confirm your entries are correct. We don't recognize your information.");
                    $("#divIncorrectInformation").show();
                }
                else {
                    isUserExist = true;
                    $("#divErrorMsg").hide();
                    $("#divIncorrectInformation").hide();
                    window.sessionStorage.setItem("UserId", data);
                    window.sessionStorage.setItem("PreviousPage", "UnabletoAccessEmailAddress");
                    setTimeout(function () {
                        window.location.href = '../PreLogin/securityquestionbycondition.html';
                    });
                }

            }
        });
    }
    return isUserExist;
}