
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
    jQuery.validator.addMethod("lettersonly", function (value, element) {
        return this.optional(element) || /^[a-z]+$/i.test(value);
    }, "Letters only please");

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
                required: true,
                validateDate: true
            },
            txtEmail: {
                required: true,
                email: true
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
                required: "Date of Birth should not be Empty",
              
                validateDate: 'Enter a valid date'
            },
            txtEmail: {
                required: "Email Address should not be Empty",
                email: "You have entered invalid Email Address. Please enter a valid Email Address"
            }
        }
    });
    $(function () {
        $("#popFirstName").popover({ title: '', content: "<h5>First Name</h5>First Name of the taxpayer.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>Last Name</h5>Last Name of the taxpayer.Last name is your family name or your surname.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofBirth").popover({ title: '', content: "<h5>Date of Birth</h5>Date of Birth of the taxpayer.Date of Birth Should be in the format(MM/DD/YYYY).<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popEmail").popover({ title: '', content: "<h5>Email</h5>Email Address of the taxpayer.Specify the Email Address you have used while creating the account.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
});

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
                    $("#divValidationMsg").html("You entered Incorrect Information. Please confirm all your entries.");
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