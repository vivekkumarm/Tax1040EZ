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
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                $('#lblPayment').html(data.TotalAmount);
                $('#lblInvoiceNumber').html(data.OrderId);
                if (data.PaymentDate != null)
                    $("#lblDate").html($.datepicker.formatDate('mm/dd/yy', new Date(data.PaymentDate)));
                $('#lblName').html(data.Name);
                if (data.BillingDetails != null) {
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
});