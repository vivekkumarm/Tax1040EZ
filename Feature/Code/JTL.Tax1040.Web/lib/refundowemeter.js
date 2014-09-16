document.write("<div class='refund'>"+
"<label id='lblRefundOweMeter'></label>" +
"<h3><label id='lblRefundOrOweAmount'></label></h3>" +
"</div>");

$(document).ready(function () {
    RefundAmountCalculation();
});


function RefundAmountCalculation() {

    $.ajax({
        url: serviceUrl + 'taxreturn/getfederalsummarydetails',
        async: true,
        dataType: 'json',
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        })
        ,
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                var totalRefundAmount = currencyformate(Math.round(Math.abs(data)));
                if (data == 0) {
                    $('#lblRefundOweMeter').html("Federal Tax Due");
                }
                else if (data < 0) {
                    $('#lblRefundOweMeter').html("Federal Refund");
                }
                else {
                    $('#lblRefundOweMeter').html("Federal Tax Due");
                }
                $('#lblRefundOrOweAmount').html(totalRefundAmount);


            }
        }
    });
}