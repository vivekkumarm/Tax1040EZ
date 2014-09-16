//created by Yogalakshmi on 15th May 2014
var stateIds, total = 0;
$(document).ready(function () {
    $.ajax({
        url: serviceUrl + 'stategateway/getaddress',
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
            if (data.Taxablestate != null) {
                stateIds = data.ResidenceState.StateId;
                for (var i = 0; i < data.Taxablestate.length; i++) {
                    stateIds = stateIds + ',' + data.Taxablestate[i].StateId
                }
            }
        }
    });


    $.ajax({
        url: serviceUrl + 'payment/getproductskubystateids',
        async: false,
        dataType: "json",
        type: "POST",
        data: JSON.stringify({
            "StateIDs": stateIds
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $.each(data, function (index, value) {
                $("#divProductSku").append('<div class="c4c8">' +
                                            '<div class="left">' +
                                                '<h4><label>' + value.SkuName + '</label></h4>' +
                                            '</div><div class="right">' +
                                                '<h4><label>$' + value.SkuPrice + '</label></h4>' +
                                             '</div></div>');
                total = total + value.SkuPrice;
            });
            $("#divProductSku").append('<div class="c4c8">' +
                                           '<div class="left">' +
                                               '<h4><label> Total </label></h4>' +
                                           '</div><div class="right">' +
                                               '<h4><label>$' + total + '</label></h4>' +
                                            '</div></div>');
        }
    });
});


function checkOutSummaryPersist() {
    $.ajax({
        url: serviceUrl + 'payment/checkoutsummarypersist',
        async: false,
        dataType: 'json',
        type: 'POST',
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId,
            StateIDs: stateIds
        }),
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            sessionStorage.setItem("ShopingCartId", data);

            setTimeout(function () {
                window.location.href = '../Payment/checkout.html'; return false;
            });
        }
    });
}