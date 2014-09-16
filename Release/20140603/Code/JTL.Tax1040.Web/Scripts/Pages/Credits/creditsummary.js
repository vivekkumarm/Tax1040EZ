/* 23Apr2014 Sathish Get Credit summary */


/* Modification History:
    ------------------------
* 25Apr2014 Sathish Show Toal in HTML Header
*/
var navigateValue;
$(document).ready(function () {

    $('.spanCurrentTaxyear').html(CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);

    $.ajax({
        url: serviceUrl + 'earnedincomecredit/getcreditsummary',
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
                $('.spanTaxPayer').html(data.PrimaryTaxPayerName);
                $('.spanEICWorksheetValue').html(data.TotalEIC);
                if (data.TotalEIC > 0)
                    $('#divNotQualifiedForEIC').hide();
                else
                    $('#divQualifiedForEIC').hide();

                if (data.ErrorMessages != null) {
                    $.each(data.ErrorMessages, function (index, value) {
                        navigateValue = value.MessageTarget + "?" + value.FieldName;
                        $("#dvDiagnostics").append('<a href="' + navigateValue + '">"' + value.ErrorText + '"</a></br>');
                    });
                }

            }
        }
    });


});