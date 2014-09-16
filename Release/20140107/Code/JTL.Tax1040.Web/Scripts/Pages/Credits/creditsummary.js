/* 23Apr2014 Sathish Get Credit summary */



/* Modification History:
    ------------------------
* 25Apr2014 Sathish Show Toal in HTML Header
* 4Jun2014- Vincent modified the diagnostic section
* 17Jun2014-Vincent Added a dollar sign in EIC amount.
*/

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var navigateValue;

/**************************************** PAGE LOAD ACTION ****************************************/
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
                //Yogalakshmi - 16th June 2014 - Check for non-negative and round off.
                var finalTotalEIC=0;
                if (data.TotalEIC != "undefined") {
                    if (data.TotalEIC >= 0) {
                        finalTotalEIC = data.TotalEIC;
                    }
                }
                $('.spanEICWorksheetValue').html('$ ' + Math.round(finalTotalEIC));
                //Vincent-18Jun2014-EIC Eligibility  check condition.
                if (data.EICEligibility) {
                    $('#divNotQualifiedForEIC').hide();
                }
                else {
                    $('#divQualifiedForEIC').hide();
                }


                $("#dvDiagnostics").empty();
                $("#divDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.

                if (data.ErrorMessages != null) {
                    var errorKnt = data.ErrorMessages.length;
                    if (errorKnt > 0) {
                        $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                        $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                        $("#divDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.

                        $.each(data.ErrorMessages, function (index, value) {
                            //Error Message navigation url
                        navigateValue = value.MessageTarget + "?" + value.FieldName;
                        $("#dvDiagnostics").append('<a href="' + navigateValue + '">' + value.ErrorText + '.</a>');
                    });
                }
                }


            }
        }
    });


    //Continue Added by prasana on 09.06.2014
    $('#btnContinue').click(function () {
        window.location.href = '../TaxesAndWrapUp/taxesandwrapupchecklist.html';
        return false;
    });

    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
        return false;
    });

});