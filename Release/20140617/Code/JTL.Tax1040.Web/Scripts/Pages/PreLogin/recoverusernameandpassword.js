
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
    $("#popFirstName").popover({ title: '', content: "<h5>First Name</h5>First Name of the taxpayer.Use only alphabets. (No special characters, numbers and Punctuations)<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popLastName").popover({ title: '', content: "<h5>Last Name</h5>Last Name of the taxpayer.Last name is your family name or your surname.Use only alphabets. (No special characters, numbers and Punctuations)<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popDateofBirth").popover({ title: '', content: "<h5>Date of Birth</h5>Date of Birth of the taxpayer.Date of Birth Should be in the format(MM/DD/YYYY).<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmail").popover({ title: '', content: "<h5>Email</h5>Email Address of the taxpayer.Specify the Email Address you have used while creating the account.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
                    $("#divValidationMsg").html("You have entered invalid Email Address. Please enter a valid Email Address.");
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