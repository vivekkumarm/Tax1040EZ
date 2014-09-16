
//Yogalakshmi- 4th July 2014 - Added deduction year
//DEDUCTION_YEAR- commented by Thileep on 06Aug2014 -We are using CURRENT_TAX_YEAR
//var DEDUCTION_YEAR = 2013;

$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);

    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
        return false;
    });


    //Added by prasana on 16 June 2014
    //Changed by Thileep on 06Aug2014 . Using CURRENT_TAX_YEAR regarding DEDUCTION_YEAR
    $('#spCurrentYear1').html(' ' + CURRENT_TAX_YEAR);
    $('#spCurrentYear2').html(' ' + CURRENT_TAX_YEAR);
    $('#spCurrentYear3').html(' ' + CURRENT_TAX_YEAR);
    $('#spCurrentYear4').html(' ' + CURRENT_TAX_YEAR);

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
                //Yogalakshmi - 16th June 2014 - To round off the Deduction Amount and not to allow negative value.
                var finalTotalWorksheetStandardDeduction = 0;
                if (data.TotalWorksheetStandardDeduction != "undefined") {
                    if (data.TotalWorksheetStandardDeduction >= 0) {
                        finalTotalWorksheetStandardDeduction = data.TotalWorksheetStandardDeduction;
                    }
                }
                //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                $('#lblTotalWorksheetStandardDeduction').html('$' + currencyformate(Math.round(finalTotalWorksheetStandardDeduction)));
                //Added by Ashok Kumar when personal details is null in deduction section
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
            }
        }
    });
});
