$(document).ready(function () {

    $('#lblDeductionYear').html(' ' + CURRENT_TAX_YEAR);

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
