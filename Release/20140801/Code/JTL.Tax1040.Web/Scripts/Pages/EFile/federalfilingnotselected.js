// 28Jul2014 Sathish used to bind and person details

$(document).ready(function () {
    $.ajax({
        url: serviceUrl + 'efile/getpersonandirstransmission',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data != null) {
                if (data.m_Item1 != null)
                    $('#lblTaxPayerName').html(data.m_Item1);
            }
        }
    });
});