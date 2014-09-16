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

                if (data.m_Item5 != null) {
                    window.sessionStorage.setItem("UserDataId", data.m_Item5);
                }

                //Yogalakshmi - 24th June 2014 - To display First Name/Nick Name.
                if (data.m_Item4 != null || data.m_Item4 != "undefined") {
                    $("#lblTaxPayerName").html(data.m_Item4);
                }
                else if (data.m_Item4 == null || data.m_Item4 == "undefined") {
                    $("#lblTaxPayerName").html('Taxpayer');
                }
                if (data.m_Item1 != null) {
                    //Wages
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalWages').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalWages))));

                    //Interest Income
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalInterestIncome').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableInterest))));

                    //Unemployment Compensation
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalUnEmploymentCompensation').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.UnemploymentCompensation))));

                    //Adjusted Gross Income
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalAdjustedGrossIncome').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.AdjustedGrossIncome))));

                    //Standard Deduction
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalDeductions').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.StandardDeduction))));

                    //Taxable Income
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalTaxableIncome').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableIncome))));

                    //Federal Withheld
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalFederalWithheld').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.FederalTaxWithholdingAmount))));

                    //Earned Income Credits
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblEarnedIncomeCredits').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.EarnedIncomeCredit))));

                    //Non-taxable Combat Pay
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalNonTaxableCombatPay').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.NonTaxableCombatPayElection))));

                    //Total Payments
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalTotalPayments').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalPaymentsAndCredits))));

                    //Total Taxes
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblTotalTaxes').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxAmount))));

                    //Tax Refund
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    var totalRefundAmount = currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.RefundAmount)));
                    $('#lblTotalTaxRefund').html(totalRefundAmount);

                    //Tax Due
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    var totalTaxDue = currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxOweAmount)));
                    $('#lblTaxDue').html(totalTaxDue);
                    if (totalRefundAmount != "undefined") {
                        if (totalRefundAmount >= 0) {
                            $('#spnFederalRefund').html(totalRefundAmount);
                            $('#lblrefundorOweAmount').html("Refund");
                            $('#spnFederalRefund').addClass("text-success");
                        }
                        else {
                            $('#spnFederalRefund').html(totalTaxDue);
                            $('#lblrefundorOweAmount').html("Tax Due");
                            $('#spnFederalRefund').addClass("text-danger");
                        }
                    }
                    else {
                        $('#spnFederalRefund').html(totalTaxDue);
                        $('#lblrefundorOweAmount').html("Tax Due");
                        $('#spnFederalRefund').addClass("text-danger");
                    }
                    //Penalties and Interest
                    //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                    $('#lblPenaltiesAndInterest').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.PenaltiesAndInterest))));

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