// 23rd June, 2014 - Saravanan N - Newly added.

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    displayFederalSummary();
    bindEvents();
});

function NotToAllowNegativeValue(value) {
    var finalAmount = 0;
    if (value != "undefined") {
        if (value >= 0) {
            finalAmount = value;
        }
    }
    return finalAmount;
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
                //Yogalakshmi - 24th June 2014 - To display First Name/Nick Name.
                if (data.m_Item4 != null || data.m_Item4 != "undefined") {
                    $("#lblTaxPayerName").html(data.m_Item4);
                }
                else if (data.m_Item4 == null || data.m_Item4 == "undefined") {
                    $("#lblTaxPayerName").html('Taxpayer');
                }
                if (data.m_Item1 != null) {
                    //Wages
                    $('#lblTotalWages').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalWages)));

                    //Interest Income
                    $('#lblTotalInterestIncome').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableInterest)));

                    //Unemployment Compensation
                    $('#lblTotalUnEmploymentCompensation').html(Math.round(NotToAllowNegativeValue(data.m_Item1.UnemploymentCompensation)));

                    //Adjusted Gross Income
                    $('#lblTotalAdjustedGrossIncome').html(Math.round(NotToAllowNegativeValue(data.m_Item1.AdjustedGrossIncome)));

                    //Standard Deduction
                    $('#lblTotalDeductions').html(Math.round(NotToAllowNegativeValue(data.m_Item1.StandardDeduction)));

                    //Taxable Income
                    $('#lblTotalTaxableIncome').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableIncome)));

                    //Federal Withheld
                    $('#lblTotalFederalWithheld').html(Math.round(NotToAllowNegativeValue(data.m_Item1.FederalTaxWithholdingAmount)));

                    //Earned Income Credits
                    $('#lblEarnedIncomeCredits').html(Math.round(NotToAllowNegativeValue(data.m_Item1.EarnedIncomeCredit)));

                    //Non-taxable Combat Pay
                    $('#lblTotalNonTaxableCombatPay').html(Math.round(NotToAllowNegativeValue(data.m_Item1.NonTaxableCombatPayElection)));

                    //Total Payments
                    $('#lblTotalTotalPayments').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalPaymentsAndCredits)));

                    //Total Taxes
                    $('#lblTotalTaxes').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxAmount)));

                    //Tax Refund
                    var totalRefundAmount = Math.round(NotToAllowNegativeValue(data.m_Item1.RefundAmount));
                    $('#lblTotalTaxRefund').html(totalRefundAmount);

                    //Tax Due
                    var totalTaxDue = Math.round(NotToAllowNegativeValue(data.m_Item1.TaxOweAmount));
                    $('#lblTaxDue').html(totalTaxDue);
                    if (totalRefundAmount != "undefined") {
                        if (totalRefundAmount >= 0) {
                            $('#lblFederalRefund').html('-' + totalRefundAmount);
                        }
                    }
                    else {
                        $('#lblFederalRefund').html(totalTaxDue);
                    }
                    //Penalties and Interest
                    $('#lblPenaltiesAndInterest').html(Math.round(NotToAllowNegativeValue(data.m_Item1.PenaltiesAndInterest)));

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

            }
        }
    });

}

//Saravanan N - 24th June, 2014 - Function refactored from html page.
function bindEvents() {
    $('#btnContinue').click(function () {
        window.location.href = '../Review/returnfinalization.html';
        return false;
    });
}