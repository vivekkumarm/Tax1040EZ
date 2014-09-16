// 06May2014 Sathish Get Federal Tax summary

$(document).ready(function () {

    $.ajax({
        url: serviceUrl + 'taxesandwrapup/gettaxandwrapup',
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
            if (data != null) {
                if (data.m_Item1 != null) {
                    $('#lblTotalWages').html(data.m_Item1.TotalWages);
                    $('#lblTotalInterestIncome').html(data.m_Item1.TaxableInterest);
                    $('#lblTotalUnEmploymentCompensation').html(data.m_Item1.UnemploymentCompensation);
                    $('#lblTotalAdjustedGrossIncome').html(data.m_Item1.AdjustedGrossIncome);
                    $('#lblTotalTaxableIncome').html(data.m_Item1.TaxableIncome);
                    $('#lblTotalFederalWithheld').html(data.m_Item1.FederalTaxWithholdingAmount);
                    $('#lblEarnedIncomeCredits').html(data.m_Item1.EarnedIncomeCredit);
                    $('#lblTotalNonTaxableCombatPay').html(data.m_Item1.NonTaxableCombatPayElection);
                    $('#lblTotalTotalPayments').html(data.m_Item1.TotalPaymentsAndCredits);
                    $('#lblTotalTaxes').html(data.m_Item1.TaxAmount);
                    $('#lblTotalTaxRefund').html(data.m_Item1.RefundAmount);
                    $('#lblTaxDue').html(data.m_Item1.TaxOweAmount);
                    $('#lblTotalDeductions').html(data.m_Item1.StandardDeduction);
                    $('#lblPenaltiesAndInterest').html(data.m_Item1.PersonalDeduction);
                }
            }
        }
    });

});