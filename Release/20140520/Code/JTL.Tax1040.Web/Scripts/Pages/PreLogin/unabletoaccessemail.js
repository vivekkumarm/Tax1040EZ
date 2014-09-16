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
            },
            txtSSN: {
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
                required: "Date of Birth should not be Empty"
            },
            txtSSN: {
                required: "Social security number should not be Empty"
            }
        }
    });
    $(function () {
        $("#popFirstName").popover({ title: '', content: "<h5>First Name</h5>First Name of the taxpayer.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>Last Name</h5>Last Name of the taxpayer.Last name is your family name or your surname.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofBirth").popover({ title: '', content: "<h5>Date of Birth</h5>Date of Birth of the taxpayer.Date of Birth Should be in the format(MM/DD/YYYY).<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSSN").popover({ title: '', content: "<h5>SSN</h5>Social Security Number of the taxpayer.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
    var date = new Date();
    var currentMonth = date.getMonth();
    var currentDate = date.getDate();
    var currentYear = date.getFullYear();

    
});

function GetUserNameByPesonalInfo() {
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
                    $("#divErrorMsg").html("You entered Incorrect Information. Please confirm all your entries.");
                }
                else {
                    isUserExist = true;
                    $("#divErrorMsg").hide();
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