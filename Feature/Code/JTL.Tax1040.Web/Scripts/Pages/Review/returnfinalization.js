// 24th June, 2014 - YogalkashmiRangan - Newly added.

$(document).ready(function () {
    $('.Title').html(TITLE);
    displayFederalSummary();
    bindEvents();
});

//Yogalakshmi - 25th June 2014 - Navigation for back button
function bindEvents() {
    $('#btnBack').click(function () {
        window.location.href = '../Review/returnsummary.html';
        return false;
    });

    $('#btnContinue').click(function () {
        //4-july-14 vivek commented and redirect to the e file section
        //window.location.href = '../StateGateway/stategateway.html';
        if (isOrderExist) // 18Jul2014 Sathish redirecte to efile page if order exist for the user
            window.location.href = '../EFile/filingoption.html';
        else
            window.location.href = '../Payment/federalreturnsummary.html';
        return false;
    });
}

function displayFederalSummary() {
    $.ajax({
        url: serviceUrl + 'taxesandwrapup/getfederaltaxsummary',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            userDataId: userDataId,
        }
        ),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#dvDiagnostics").empty();
            if (data != null) {
                if (data.m_Item4 != null || data.m_Item4 != "undefined") {
                    $("#lblTaxPayerName").html(data.m_Item4);
                }
                else if (data.m_Item4 == null || data.m_Item4 == "undefined") {
                    $("#lblTaxPayerName").html('Taxpayer');
                }
                if (data.m_Item1 != null) {
                    if (data.m_Item1.RefundAmount > 0) {
                        //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                        $("#federalTaxRefund").html(currencyformate(data.m_Item1.RefundAmount));
                    }
                    else if (data.m_Item1.RefundAmount <= 0) {
                        $("#divFederalTaxRefund").hide();
                        //$("#dvNoDues").hide();  //Saravanan N - 11th Aug, 2014 - Commented and moved logic separtely.
                    }

                    if (data.m_Item1.TaxOweAmount > 0) {
                        //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                        $("#federalTaxOwe").html(currencyformate(data.m_Item1.TaxOweAmount));
                    }
                    else if (data.m_Item1.TaxOweAmount <= 0) {
                        $("#divFederalTaxOwe").hide();
                        //$("#dvNoDues").hide(); //Saravanan N - 11th Aug, 2014 - Commented and moved logic separtely.
                    }

                    //Saravanan N - 11th Aug, 2014 - No Dues display logic altered.
                    //Thileepkumar U - 18Aug2014 - No Dues display logic altered as per BA discussion
                    if (data.m_Item1.TaxOweAmount == 0 && data.m_Item1.RefundAmount == 0) {
                        $("#dvNoDues").show();
                    }
                    else {
                        $("#dvNoDues").hide();
                    }

                    if (data.m_Item1.TaxAmount = 0) {
                        $("#divFederalTaxOwe").hide();
                        $("#divFederalTaxRefund").hide();
                    }
                }
            }
        }
    });
}