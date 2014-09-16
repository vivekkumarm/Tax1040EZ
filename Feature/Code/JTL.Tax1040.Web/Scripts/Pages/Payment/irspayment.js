// 13May2014 Sathish  Get and persist IRS Payment option

$(document).ready(function () {

    $('#irspayment').validate({
        rules: {
            //radPaymentOption: {
            //    required:true,
            //}
            txtAccountNumber: {
                required: function () { $('#radElectronicFundWithdrawal').prop('checked') }
            },
            txtBankRoutingNumber: {
                required: function () { $('#radElectronicFundWithdrawal').prop('checked') }
            },
            txtBankName: {
                required: function () { $('#radElectronicFundWithdrawal').prop('checked') }
            },
            radAccountType: {
                required: function () {
                    if ($('#radSaving').prop('checked') == true || $('#radChecking').prop('checked') == true) {
                        return true;
                    }
                }
            },
            chkIsIRSPaymentOptionAgreed: {
                required: function () {
                    $('#divBankAccountDetailConfirmation').empty();
                    $('#divEFTPSccepted').empty();
                    $('#divCheckOrMoneyOrderAccepted').empty();
                    if ($('#radElectronicFundWithdrawal').prop('checked') == true && $('#chkBankAccountDetailConfirmation').prop('checked') == false) {
                        return true;
                    }
                    else if ($('#radElectronicFederalTaxPaymentSystem').prop('checked') == true && $('#chkEFTPSccepted').prop('checked') == false) {
                        return true;
                    }
                    else if ($('#radCheckorMoneyOrder').prop('checked') == true && $('#chkCheckOrMoneyOrderAccepted').prop('checked') == false) {
                        return true;
            }
                    else
                        return false;
                }
            }
        },
        messages: {
            //radPaymentOption: {
            //    required: 'Missing Type of account information.',
            //}
            txtAccountNumber: {
                required: 'Missing Bank Account number'
            },
            txtBankRoutingNumber: {
                required: 'Missing Routing Number'
            },
            txtBankName: {
                required: 'Missing Bank Name'
            },
            radAccountType: {
                required: ''
            },
            chkIsIRSPaymentOptionAgreed: {
                required: function () {
                    if ($('#radElectronicFundWithdrawal').prop('checked') == true && $('#chkBankAccountDetailConfirmation').prop('checked') == false)
                         $('#divBankAccountDetailConfirmation').html('You have not accepted the information entered regarding the direct debit.');
                    else if ($('#radElectronicFederalTaxPaymentSystem').prop('checked') == true && $('#chkEFTPSccepted').prop('checked') == false)
                         $('#divEFTPSccepted').html('You have not accepted your responsibility to schedule the tax due payment to the IRS using eftps.gov website.');
                    else if ($('#radCheckorMoneyOrder').prop('checked') == true && $('#chkCheckOrMoneyOrderAccepted').prop('checked') == false)
                         $('#divCheckOrMoneyOrderAccepted').html('Please accept to the declaration that the tax due payment will be paid by means of check or money order to the United States Treasury.');
                }
            }
        }
    });

    $('.spanTaxYear').html(CURRENT_TAX_YEAR);

    $("[name='radPaymentOption']").change(function () {
        if ($('#radElectronicFundWithdrawal').prop('checked')) {
            $('#divElectronicFundWithdrawal').show();
            $('#divElectronicFederalTaxPaymentSystem').hide();
            $('#divCheckMyOrder').hide();
        }
        else if ($('#radElectronicFederalTaxPaymentSystem').prop('checked')) {
            $('#divElectronicFundWithdrawal').hide();
            $('#divElectronicFederalTaxPaymentSystem').show();
            $('#divCheckMyOrder').hide();
        }
        else if ($('#radCheckorMoneyOrder').prop('checked')) {
            $('#divElectronicFundWithdrawal').hide();
            $('#divElectronicFederalTaxPaymentSystem').hide();
            $('#divCheckMyOrder').show();
        }
    });

    $.ajax({
        url: serviceUrl + 'payment/getirspaymentoption',
        async: false,
        dataType: 'json',
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: 'POST',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item1 != null) {
                    $('#lblFederalTaxDue').html(data.m_Item1);
                }
                if (data.m_Item2 != null) {
                    if (data.m_Item2.FederalFiling.IRS.IRSPaymentOption != '') {
                        $('input[name=radPaymentOption][value=' + data.m_Item2.FederalFiling.IRS.IRSPaymentOption + ']').prop('checked', true);
                        $('input[name=chkIsIRSPaymentOptionAgreed][value=' + data.m_Item2.FederalFiling.IRS.IRSPaymentOption + ']').prop('checked', true);
                        $('input:radio[name=radPaymentOption]').trigger('change');
                    }
                    if (data.m_Item2.BankDetails != null) {
                        $('input[name=radAccountType][value=' + data.m_Item2.FederalFiling.IRS.BankDetails.BankAccountTypeCode + ']').prop('checked', true);
                        $('#txtAccountNumber').val(data.m_Item2.FederalFiling.IRS.BankDetails.AccountNumber);
                        $('#txtBankRoutingNumber').val(data.m_Item2.FederalFiling.IRS.BankDetails.RoutingTransitNumber);
                        $('#txtBankName').val(data.m_Item2.FederalFiling.IRS.BankDetails.BankName);
                        $('input:radio[name=chkBankAccountDetailConfirmation]').checked = true;
                    }

                }
            }
        }
    });

});

function PersistIrsPayment() {
    $("#divIrsPaymentOptionError").empty();
    if ($('#irspayment').valid()) {


        var bankDetails;

        if ($('#radElectronicFundWithdrawal').prop('checked')) {
            bankDetails = {
                RoutingTransitNumber: $('#txtBankRoutingNumber').val(),
                AccountNumber: $('#txtAccountNumber').val(),
                BankName: $('#txtBankName').val(),
                BankAccountTypeCode: $('input:radio[name=radAccountType]:checked').val()
            };
        }

        var irs = {
            IRSPaymentOption: $('input:radio[name=radPaymentOption]:checked').val(),
            IsIRSPaymentOptionAgreed: $('input:checkbox[value=' + $('input:radio[name=radPaymentOption]:checked').val() + ']').prop('checked'),
            BankDetails: bankDetails
        };

        $.ajax({
            url: serviceUrl + 'payment/persistirspaymentoption',
            async: false,
            dataType: 'json',
            type: 'POST',
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                UserId: userId,
                TaxReturnData:
                    {
                        UserDataId: userDataId,
                        TaxData: JSON.stringify(irs),
                    }
            }),
            contentType: 'application/json; charset=utf-8',
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data.m_Item1 != null) {
                    window.sessionStorage.setItem('UserDataId', data.m_Item1);
                }
                if (data.m_Item2 != null) {
                    if (data.m_Item2.length > 0) {
                        $.each(data.m_Item2, function (index, value) {
                            $("#divIrsPaymentOptionError").show();
                            $("#divIrsPaymentOptionError").append(value.ErrorText + '<br />');
                        });
                    }
                    else {
                        //21Aug2014-Thileep Commented setTimeout function to avoid page redirection delay
                       // setTimeout(function () {
                            window.location.href = '../Payment/federalreturnsummary.html';
                       // });
                    }
                }
            }
        });
    }
}
