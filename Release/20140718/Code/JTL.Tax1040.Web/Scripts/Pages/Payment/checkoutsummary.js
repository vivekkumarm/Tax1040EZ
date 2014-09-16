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
                    if (data.Taxablestate.State != null)
                        stateIds = stateIds + ',' + data.Taxablestate[i].State.StateId;
                }
            }
        }
    });


    $.ajax({
        url: serviceUrl + 'payment/getuserfeaturesku',
        async: false,
        dataType: "json",
        type: "POST",
        data: JSON.stringify({
            UserId: userId,
            userDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            var stateName = '';
            var featureName = '';
            var total = 0;
            if (data != null) {
                if (data.FederalFeature != null && data.FederalFeature.FederalFeatureSKU != null) {
                    $('#divFederal').empty();
                    $.each(data.FederalFeature.FederalFeatureSKU, function (index, value) {
                        featureName = '';
                        if (value.Feature != null) 
                            featureName = value.Feature.FeatureName;

                        $('#divFederal').append('<div class="row ">' +
                                                    '<div class="col-md-6">' + featureName + '</div>' +
                                                    '<div class="col-md-6"><span>' + value.FederalFeaturePrice + '</span></div>' +
                                                '</div>');
                        total = total + value.FederalFeaturePrice;
                    });
                }
                if (data.StateFeature != null) {
                    $('#divState').empty();
                    //$('#divState').append('<div class="row gren">' +
                    //                            '<div class="col-md-6"><strong>State Name</strong></div>' +
                    //                            '<div class="col-md-6"><strong>Price Per State Preparation</strong></div>' +
                    //                       '</div>');
                    $.each(data.StateFeature, function (index, value) {

                        stateName = '';
                        if (value.State != null)
                            stateName = value.State.StateName;

                        $.each(value.StateFeatureSKU, function (index, stateFeatureSKU) {
                            $('#divState').append('<div class="row ">' +
                                                  '<div class="col-md-6">' + stateName + '</div>' +
                                                  '<div class="col-md-6"><span>' + stateFeatureSKU.StatePrice + '</span></div>' +
                                                '</div>');
                            total = total + stateFeatureSKU.StatePrice;
                        });
                        
                    });

                    $('#divState').append('<div class="row gren">' +
                                       '<div class="col-md-6"><strong>Total</strong></div>' +
                                       '<div class="col-md-6"><strong>' + total + '</strong></div>' +
                                  '</div>');

                }
            }
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