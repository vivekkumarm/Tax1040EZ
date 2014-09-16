// 06May2014 Sathish Get Federal Tax summary
// 28May2014 Sathish Implemented pre page logic for Refund,Tax Due and Penalties And Interest

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    
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
                if (data.m_Item1 != null) {
                    $('#lblTotalWages').html(data.m_Item1.TotalWages);
                    $('#lblTotalInterestIncome').html(data.m_Item1.TaxableInterest);
                    $('#lblTotalUnEmploymentCompensation').html(data.m_Item1.UnemploymentCompensation);
                    $('#lblTotalAdjustedGrossIncome').html(data.m_Item1.AdjustedGrossIncome);
                    $('#lblTotalDeductions').html(data.m_Item1.StandardDeduction);
                    $('#lblTotalTaxableIncome').html(data.m_Item1.TaxableIncome);
                    $('#lblTotalFederalWithheld').html(data.m_Item1.FederalTaxWithholdingAmount);
                    $('#lblEarnedIncomeCredits').html(data.m_Item1.EarnedIncomeCredit);
                    $('#lblTotalNonTaxableCombatPay').html(data.m_Item1.NonTaxableCombatPayElection);
                    $('#lblTotalTotalPayments').html(data.m_Item1.TotalPaymentsAndCredits);
                    $('#lblTotalTaxes').html(data.m_Item1.TaxAmount);
                    $('#lblTotalTaxRefund').html(data.m_Item1.RefundAmount);
                    $('#lblTaxDue').html(data.m_Item1.TaxOweAmount);
                    $('#lblPenaltiesAndInterest').html(data.m_Item1.PenaltiesAndInterest);

                    // Hides tax due if payer has refund
                    if (data.m_Item1.RefundAmount != 0) {
                        $('#divTaxDue').hide();
                    }
                    // Hides Re fund if payer has tax own amount
                    if (data.m_Item1.TaxOweAmount != 0) {
                        $('#divTaxRefund').hide();
                    }

                    // Hides penalties and intrest if zero
                    if (data.m_Item1.PenaltiesAndInterest == 0) {
                        $('#divPenaltiesAndInterest').hide();
                    }
                }
                if (data.m_Item2 != null) {
                    var errorKnt = data.m_Item2.length;
                    if (errorKnt > 0) {
                        $('#supErrorCount').html(errorKnt); 
                        $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                        $("#divDiagnosticsParent").show(); 

                        $.each(data.m_Item2, function (index, value) {
                            var navigateURL = value.MessageTarget + "?" + value.FieldName;
                            $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '</a>');
                        });
                    }
                }
            }
        }
    });

});