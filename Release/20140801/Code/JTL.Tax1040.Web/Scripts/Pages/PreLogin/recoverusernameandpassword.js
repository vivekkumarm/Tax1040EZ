
// validate signup form on keyup and submit
$(document).ready(function () {
    
    LettersAndSpaceOnly('txtFirstName');
    LettersAndSpaceOnly('txtLastName');

    //Bala StartDate added to restrict the selection of start date 07July14
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
    $('#txtEmail').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });
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
        txtEmail: {
            required: true
               
        }

    },
    messages: {
        txtFirstName: {
            required: "Missing Taxpayer First Name.",
            lettersonly: "First Name can have only alphabets."
        },
        txtLastName: {
            required: "Missing Taxpayer Last Name.",
            lettersonly: "Last Name can have only alphabets"
        },
        dtDateofBirth: {
            required: function () { $('#divDOBErrorMsg').html('Missing Taxpayer Date of Birth.'); true; },
              
            validateDate: function () { $('#divDOBErrorMsg').html('You have entered a invalid date'); true; }
        },
        txtEmail: {
            required: "Email Address is missing."
                
        }
    }
});
    //Thileep Changed quickhelp content on 09July2014
$(function () {
    $("#popFirstName").popover({ title: '', content: "<h5>Why do we need your First Name?</h5>We ask for your First Name to pull out your records.<br/><br/>Don't worry! It's a part of our stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popLastName").popover({ title: '', content: "<h5>Why do we need your Last Name?</h5>We ask for your Last Name to pull out your records.<br/><br/>Don't worry! It's a part of our stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popDateofBirth").popover({ title: '', content: "<h5>Why do we need your Date of Birth?</h5>Don't Panic! Your Date of Birth is required for verification and security purposes.<br/><br/>All your personal information are safe with us!<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmail").popover({ title: '', content: "<h5>Which Email Address do we need?</h5>Share us the Email Address that you used while creating the account.<br/><br/>We will use it to mail you the account reset information.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
});
});
function DateValidate() {
    if ($("#UnableToAccessAccount").valid()) {
        return false;
    }
}
function GetUserNameByPesonalInfo() {
    var isUserExist = false;
    if ($("#UnableToAccessAccount").valid()) {

        $.ajax({
            url: serviceUrl + 'user/getusernameandidbyuserdetails',
            async: false,
            dataType: "json",
            type: "POST",
            data: JSON.stringify({
                "FirstName": $("#txtFirstName").val(),
                "LastName": $("#txtLastName").val(),
                "DateOfBirth": $("#dtDateofBirth").val(),
                "Email": $("#txtEmail").val(),
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data == 0) {
                    $("#divValidationMsg").show();
                    //16July 2014 Thileep Changed Error message as per PreloginSpec(V1.9)
                    $("#divValidationMsg").html("Incorrect Information. Contact Customer Support!");                    
                } else {
                    isUserExist = true;
                    $("#divValidationMsg").hide();                    
                    window.sessionStorage.setItem("UserId", data);
                    window.sessionStorage.setItem("PreviousPage", "ForgotBothUsernameandPassword");
                    setTimeout(function () {
                        window.location.href = '../PreLogin/securityquestionbycondition.html';
                    });
                }

            }
        });
    }
    return isUserExist;
}