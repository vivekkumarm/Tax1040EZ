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
        //window.location.href = '../State/stategateway.html';
        window.location.href = '../Efile/efileinformation.html';
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
                else if (data.m_Item4 == null ||data.m_Item4 == "undefined" ) {
                        $("#lblTaxPayerName").html('Taxpayer');
                }
                if (data.m_Item1 != null) {
                    if (data.m_Item1.RefundAmount > 0) {
                        $("#federalTaxRefund").html(data.m_Item1.RefundAmount);
                    }
                    else if (data.m_Item1.RefundAmount <= 0) {
                        $("#divFederalTaxRefund").hide();
                        $("#dvNoDues").hide();
                    }

                    if (data.m_Item1.TaxOweAmount > 0) {
                        $("#federalTaxOwe").html(data.m_Item1.TaxOweAmount);
                    }
                    else if (data.m_Item1.TaxOweAmount <= 0) {
                        $("#divFederalTaxOwe").hide();
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