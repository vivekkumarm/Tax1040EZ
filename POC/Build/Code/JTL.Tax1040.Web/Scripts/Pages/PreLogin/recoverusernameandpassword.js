
// validate signup form on keyup and submit
$(document).ready(function () {
    
    LettersAndSpaceOnly('txtFirstName');
    LettersAndSpaceOnly('txtLastName');

    
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
            $('#divDOBErrorMsg').html('Date of Birth should not be Empty');
        }
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
            required: "First name should not be Empty",
            lettersonly: "Use only alphabets. (No special characters, numbers and Punctuations)"
        },
        txtLastName: {
            required: "Last name should not be Empty",
            lettersonly: "Use only alphabets. (No special characters, numbers and Punctuations)"
        },
        dtDateofBirth: {
            required: function () { $('#divDOBErrorMsg').html('Date of Birth should not be Empty'); true; },
              
            validateDate: function () { $('#divDOBErrorMsg').html('You have entered a invalid date'); true; }
        },
        txtEmail: {
            required: "Email Address should not be Empty"
                
        }
    }
});
$(function () {
    $("#popFirstName").popover({ title: '', content: "<h5>Why do we need your First Name?</h5>Your First Name is required to maintain a valid database and for security purposes. Don't worry! We maintain all your data with stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popLastName").popover({ title: '', content: "<h5>Why do we need your Last Name?</h5>Your Last Name is required to maintain a valid database and for security purposes.Don't worry! We maintain all your data with stringent security measures.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popDateofBirth").popover({ title: '', content: "<h5>Why do we need your Date of Birth?</h5>Don't Panic! Your Date of Birth is required for verification and security purposes.All your personal information are safe with us!<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmail").popover({ title: '', content: "<h5>Which Email Address do we need?</h5>Share us the Email Address that you used while creating the account.We will use it to mail you the account reset information.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                    $("#divValidationMsg").html("Confirm your entries are correct. We don't recognize your information.");
                    $("#divIncorrectInformation").show();
                } else {
                    isUserExist = true;
                    $("#divValidationMsg").hide();
                    $("#divIncorrectInformation").hide();
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