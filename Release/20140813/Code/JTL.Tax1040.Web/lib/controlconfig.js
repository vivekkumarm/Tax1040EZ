//22Jul2014 Sathish configure control enable or disabled

$(document).ready(function () {

    $.ajax({
        url: serviceUrl + 'efile/getirsreturnstatus',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
                UserId: userId,
                UserDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data == 1) {
                $('input:radio').prop('disabled', 'disabled');
                $('input:text').prop('disabled', 'disabled');
                $('input:checkbox').prop('disabled', 'disabled');
            }
        }
    });

    $(".input-group date").off('click');

});