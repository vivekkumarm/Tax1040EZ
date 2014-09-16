//18Jul2014 Sathish created to refer user friend 
//25Aug2014 Thileep changed Error Messages  Regarding File spec(V1.6)

var userReferrralUpdate = false;
$(document).ready(function () {

    jQuery.validator.addMethod("userreferralemailvalidation",
     function (value, element) {
         var referralEmail = value.split(',');
         var referralEmailValid = false;
         if (referralEmail.length > 0) {
             for (var r = 0; r < referralEmail.length; r++) {
                 if (this.optional(element) || /^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$/.test(referralEmail[r]))
                     referralEmailValid = true;
                 else
                     referralEmailValid = false;
             }
         }
         return referralEmailValid;
     }, "You have entered invalid Email Address. Please enter a valid Email Address."
     );

    //Saravanan N - 23rd July, 2014 - As discussed with Praveen no need to do client side validation here.
    $("#frmUserReferral").validate({
        rules: {
            txtReferralEmailId0: {
                required: true,
                userreferralemailvalidation: true
            }
        },
        messages: {
            txtReferralEmailId0: {
                required: "Enter Referral Mailing address",
                userreferralemailvalidation: "Email Address is invalid"
            }
        }
    });

    //22Jul2014 Sathish Dynamic adding user referrral
    $('#btnaddNewReferral').click(function () {
        var userReferrralCount = parseInt($('#hReferralCount').val());
        if (userReferrralCount < 9) {
            userReferrralCount = userReferrralCount + 1;
            $('#hReferralCount').val(userReferrralCount);
            $('#divReferFriendEmail').append('<br/><input id="txtReferralEmailId' + userReferrralCount + '" name="txtReferralEmailId' + userReferrralCount + '" type="text" maxlength="100" />');
            $("#frmUserReferral").validate();
            $('#txtReferralEmailId' + userReferrralCount).rules("add", {
                // required: true,
                userreferralemailvalidation: true,
                messages: {
                    txtReferralEmailId: {
                        //  required: "Missing Email Address",
                        userreferralemailvalidation: "You have entered invalid Email Address. Please enter a valid Email Address."
                    }
                }
            }
            )
        };
    });

    $('#btnReferFriend').click(function () {
        if ($("#frmUserReferral").valid()) {
            PersistUserReferrral();
            // $('#divUserReferral').show();
            // $('#divUserReferral').text('Thanks for referring your friend(s). Please feel free to refer more friends for Tax Garden');
            userReferrralUpdate = true;
            window.location.href = '../Finalpage/userrating.html';
            return false;
        }
    });


    //$('#btnUserContinue').click(function () {
    //    if (!userReferrralUpdate) {
    //        if ($("#frmUserReferral").valid()) {
    //            PersistUserReferrral();
    //        }
    //    }
    //    window.location.href = '../Finalpage/userrating.html';
    //    return false;
    //});
});

function SkipReferalPage() {
    window.location.href = '../Finalpage/userrating.html';
    return false;
}


function PersistUserReferrral() {

    //22Jul2014 Sathish passed multiple referrral
    var userReferrral = [];
    var newUserRefrral;
    for (var referralCount = 0; referralCount <= parseInt($('#hReferralCount').val()) ; referralCount++) {
        if ($('#txtReferralEmailId' + referralCount).val() != '') {
            newUserRefrral = {
                ReferralEmailId: $('#txtReferralEmailId' + referralCount).val()
            }
            userReferrral.push(newUserRefrral);
        }
    }

    $.ajax({
        url: serviceUrl + 'taxreturn/persistuserreferral',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserDTO: {
                UserId: userId,
                UserDataId: userDataId
            },
            ReferralRating:
                {
                    UserReferral: userReferrral
                }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            return true;
        }
    });
}
