$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);

    $.ajax({
        url: serviceUrl + 'deduction/getdeductionsummary',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                $('#lblPrimaryTaxPayerName').html(data.PrimaryTaxPayerName);
                $('#lblTotalWorksheetStandardDeduction').html(data.TotalWorksheetStandardDeduction);
            }
        }
    });
});
