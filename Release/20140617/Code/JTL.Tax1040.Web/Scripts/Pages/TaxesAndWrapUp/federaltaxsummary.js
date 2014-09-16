// 06May2014 Sathish Get Federal Tax summary
// 28May2014 Sathish Implemented pre page logic for Refund,Tax Due and Penalties And Interest
// 06June2014 Bala Modified method call to check Eligibility diagnostics and  get the primary filer name.

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 1) {
        var controlToFocus = parameterName[0];
        $('#' + controlToFocus).focus();
    }

    //Yogalakshmi - 16th June 2014 - A common functionality for Not allowing Negative values in the summary.
    function NotToAllowNegativeValue(value) {
        var finalAmount = 0;
        if (value != "undefined") {
            if (value >= 0) {
                finalAmount  = value;
            }
        }
        return finalAmount;
    }
   
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
                    //Wages
                    //Yogalakshmi - 16th June 2014 - To round off the Wages Amount and not to allow negative value.
                    $('#lblTotalWages').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalWages)));

                    //Interest Income
                    //Yogalakshmi - 16th June 2014 - To round off the Interest Income Amount and not to allow negative value.
                    $('#lblTotalInterestIncome').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableInterest)));

                    //Unemployment Compensation
                    //Yogalakshmi - 16th June 2014 - To round off the Unemployment Compensation Amount and not to allow negative value.
                    $('#lblTotalUnEmploymentCompensation').html(Math.round(NotToAllowNegativeValue(data.m_Item1.UnemploymentCompensation)));

                    //Adjusted Gross Income
                    //Yogalakshmi - 16th June 2014 - To round off the Adjusted Gross Income Amount and not to allow negative value.
                    $('#lblTotalAdjustedGrossIncome').html(Math.round(NotToAllowNegativeValue(data.m_Item1.AdjustedGrossIncome)));

                    //Standard Deduction
                    //Yogalakshmi - 16th June 2014 - To round off the Deduction Amount and not to allow negative value.
                    $('#lblTotalDeductions').html(Math.round(NotToAllowNegativeValue(data.m_Item1.StandardDeduction)));

                    //Taxable Income
                    //Yogalakshmi - 16th June 2014 - To round off the Taxable Income Amount and not to allow negative value.
                    $('#lblTotalTaxableIncome').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableIncome)));

                    //Federal Withheld
                    //Yogalakshmi - 16th June 2014 - To round off the Federal Tax Withholding Amount and not to allow negative value.
                    $('#lblTotalFederalWithheld').html(Math.round(NotToAllowNegativeValue(data.m_Item1.FederalTaxWithholdingAmount)));

                    //Earned Income Credits
                    //Yogalakshmi - 16th June 2014 - To round off the Federal Tax Withholding Amount and not to allow negative value.
                    $('#lblEarnedIncomeCredits').html(Math.round(NotToAllowNegativeValue(data.m_Item1.EarnedIncomeCredit)));

                    //Non-taxable Combat Pay
                    //Yogalakshmi - 16th June 2014 - To round off the Non-Taxable Combat Pay Election Amount and not to allow negative value.
                    $('#lblTotalNonTaxableCombatPay').html(Math.round(NotToAllowNegativeValue(data.m_Item1.NonTaxableCombatPayElection)));

                    //Total Payments
                    //Yogalakshmi - 16th June 2014 - To round off the Total Payments And Credits Amount and not to allow negative value.
                    $('#lblTotalTotalPayments').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalPaymentsAndCredits)));

                    //Total Taxes
                    //Yogalakshmi - 16th June 2014 - To round off the Tax Amount and not to allow negative value.
                    $('#lblTotalTaxes').html(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxAmount)));

                    //Tax Refund
                    //Yogalakshmi - 16th June 2014 - To round off the Refund Amount and not to allow negative value.
                    var totalRefundAmount = Math.round(NotToAllowNegativeValue(data.m_Item1.RefundAmount));
                    $('#lblTotalTaxRefund').html(totalRefundAmount);
                    
                    //Tax Due
                    //Yogalakshmi - 16th June 2014 - To round off the Tax Owe Amount and not to allow negative value.
                    var totalTaxDue = Math.round(NotToAllowNegativeValue(data.m_Item1.TaxOweAmount));
                    $('#lblTaxDue').html(totalTaxDue);
                    //Yogalakshmi - 16th June 2014 - To display the amount in federal refund
                    if (totalRefundAmount != "undefined") {
                        if (totalRefundAmount >= 0) {
                            $('#lblFederalRefund').html('-' + totalRefundAmount);
                        }
                    }
                    else {
                        $('#lblFederalRefund').html(totalTaxDue);
                    }
                    //Penalties and Interest
                    //Yogalakshmi - 16th June 2014 - To round off the Penalties And Interest Amount and not to allow negative value.
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
                if (data.m_Item4 != null) {
                    window.sessionStorage.setItem("PrimaryName", data.m_Item4);
                }
            }
        }
    });

});