//18Jul2014 Sathish created get or persist user rating 

$(document).ready(function () {

    $(function () {
      // Vincent-24 July 2014- Star rating binding.
      //Star Rating
        $('#starRating').barrating({ showSelectedRating: false });

        $('.rating-enable').trigger('click');
    });

    $.ajax({
        url: serviceUrl + 'taxreturn/getuserrating',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            userDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                $("#starRating").val(data.Rating);
                $('#txtUserComment').val(data.Comment); //22Jul2014 Sathish passed rating comment
            }
        }
    });

    $('#btnNext').click(function () {
        PersistUserRating();
        window.location.href('../FinalPage/signout.html');
        return false;
    });

});

function PersistUserRating() {

    $.ajax({
        url: serviceUrl + 'taxreturn/persistuserrating',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserDTO:{
                UserId: userId,
                UserDataId: userDataId
            },
            UserRating:{
                //Rating: $("input:radio[name=radUserRating]:checked").val(),
                Rating: $('#starRating').val(),
                Comment: $('#txtUserComment').val()
            }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
         //   $('#divUserRating').show();
         //   $('#divUserRating').text("Thank you for your Rating")
        }
    });

}
