//Added for Update Email Script
$(document).ready(function () {
    
    
    //validate updateemail form on keyup and submit
    $("#updateemail").validate({
        rules: {
            txtRetypeEmailid: {
                required: true,
                email: true
            },
            txtPasswordForEmail: {
                required: true
                //minlength: 8,
                //maxlength: 15,
                //passwordvalidation: true
            }

        },
        messages: {
            txtRetypeEmailid: {
                required: "Missing Email Address",
                email: "Invalid Email Address"
            },
            txtPasswordForEmail: {
                required: "Missing Password"
                //minlength: "Invalid Password",
                //maxlength: "Invalid Password",
                //passwordvalidation: "Invalid Password"
            }

        }

    }),

    $.ajax({
        url: serviceUrl + 'user/getuserdetailsbyuserid',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify
            ({
                "UserId": userId

            }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $('#lblEmailIdVal').html(data.Email);

        }
    });

    //Added by Thileep 04July 2014
    $("#txtRetypeEmailid").keyup(function () {
        $("#divValidationMsg").hide();
    });

    $("#txtPasswordForEmail").keyup(function () {
        $("#divValidationMsg").hide();
    });

    //Quick help added by prasana on 24Jun2014
    //Quickhelp Message content changed 17July 2014 By Thileep
    $(function () {
        $("#popEmailId").popover({ title: '', content: "<h5>Why do we need a New Email ID?</h5>We need your new Email ID to communicate to you without any interruption.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPassword").popover({ title: '', content: "<h5>What is your Password?</h5>This is a secret string of characters you chose to secure your Tax Garden account.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

});

//UpdateEmailId
function UpdateEmailId() {
    if ($('#updateemail').valid()) {
        $.ajax({
            url: serviceUrl + 'user/validatepasswordbyuserid',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "UserId": userId,
                "Email": $("#txtRetypeEmailid").val(),
                "Password": $("#txtPasswordForEmail").val()
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                //Changed by Thileep 26june2014
                if (data.m_Item1 == 3) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html(data.m_Item2);
                } else if (data.m_Item1 == 0) {
                    $("#divValidationMsg").show();
                    //Changed div color for sucess message by prasana on 25.06.2014
                    $("#divValidationMsg").removeClass('error-alert').addClass('alert alert-success');
                    $("#divValidationMsg").html("The EmailId has been updated successfully.");
                    //Added by Thileep 04July 2014
                    $('#lblEmailIdVal').html($("#txtRetypeEmailid").val());
                    $("#txtRetypeEmailid").val("");
                    $("#txtPasswordForEmail").val("");
                }
                else if (data.m_Item1 == 1) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html(data.m_Item2);

                }
                else if (data.m_Item1 == 4) {
                    $("#divValidationMsg").show();
                    $("#divValidationMsg").removeClass('alert alert-success').addClass('error-alert');//Added by Thileep for change div color on 26June2014
                    $("#divValidationMsg").html("Invalid Password");

                }
            }
        });
        return false;

    }

}