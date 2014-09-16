// 13May2014 Sathish Get Invoice details
var orderId;
$(document).ready(function () {

    if (sessionStorage.getItem("OrderId") != null)
        orderId = sessionStorage.getItem("OrderId");

    $.ajax({
        url: serviceUrl + 'payment/getorderbyorderid',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId,
            Order: {
                OrderId: orderId
            }
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
                $('#lblPayment').html(data.TotalAmount);
                $('#lblInvoiceNumber').html(data.OrderId);
              
              
                if (data.BillingDetails != null) {
                    $("#lblDate").html($.datepicker.formatDate('mm/dd/yy', new Date(data.BillingDetails.PaymentDate)));
                    $('#lblName').html(data.BillingDetails.FirstName + " " + (data.BillingDetails.LastName == null ? "" : data.BillingDetails.LastName));
                    if (data.BillingDetails.BillingAddress != null) {
                        $('#lblAddress').html(data.BillingDetails.BillingAddress.StreetAddress + '<br />' +
                                         data.BillingDetails.BillingAddress.ApartmentNumber + '<br />' +
                                         data.BillingDetails.BillingAddress.City + '<br />' +
                                         data.BillingDetails.BillingAddress.StateOrProvince + '<br />' +
                                         data.BillingDetails.BillingAddress.ZipCode);
                    }
                }

                $.each(data.ShoppingCart, function (index, value) {
                    $("#divSelectedState").append('<label class="col-md-4">' + value.SkuName + '</label>' +
                                                                    '<label class="col-md-3"></label>' +
                                                                    '<label class="col-md-3">' + ' ' + '</label>' +
                                                                    '<label class="col-md-2">' + value.SkuPrice + '</label>');

                });

            }
        }
    });


    $.ajax({
        url: serviceUrl + 'payment/getuserfeaturesku',
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

                        $('#divFederal').append(
                                                    '<div class="col-md-6"><strong>' + featureName + ':</strong></div>' +
                                                    '<div class="col-md-8"><span>' + value.FederalFeaturePrice + '</span></div>');
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
                            $('#divState').append(
                                                  '<div class="col-md-6">' + stateName + ':</div>' +
                                                  '<div class="col-md-8"><span>' + stateFeatureSKU.StatePrice + '</span></div>' );
                            total = total + stateFeatureSKU.StatePrice;
                        });

                    });

                    $('#divState').append(
                                       '<div class="col-md-6"><strong>Total:</strong></div>' +
                                       '<div class="col-md-8"><strong>' + total + '</strong></div>');

                }
            }
        }
    });
});