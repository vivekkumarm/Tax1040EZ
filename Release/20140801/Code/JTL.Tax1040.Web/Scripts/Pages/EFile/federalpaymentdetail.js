// 13May2014 Sathish  Get and persist IRS Payment option

//17July2014 Thileep Added Validation for Account number,Routing number

var filing;
$(document).ready(function () {
    //17July2014 Thileep Added Validation for radPaymentOption


    NumbersOnlyNotAcceptingDot('txtAccountNumber'); // 01Aug2014 Sathish added validation for the defect #TAX1040-14254
    NumbersLettersAndHyphen('txtBankName');// 01Aug2014 Sathish added validation for the defect #TAX1040-14254

    $('#irspayment').validate({
        rules: {
            radPaymentOption: {
                required: function () { $('#divIrsPaymentOptionValidation').html(''); true; },
            },
            txtAccountNumber: {
                required: function () { $('#radElectronicFundWithdrawal').prop('checked') },
                minlength: 4,
                maxlength: 17
            },
            txtBankRoutingNumber: {
                required: function () { $('#radElectronicFundWithdrawal').prop('checked') },
                minlength: 9,
                maxlength: 9
            },
            txtBankName: {
                required: function () { $('#radElectronicFundWithdrawal').prop('checked') }
            },
            radAccountType: {
                required: function () {
                    if ($('#radElectronicFundWithdrawal').prop('checked')) {
                        if ($('#radSaving').prop('checked') || $('#radChecking').prop('checked')) {
                            $('#divTypeErrorMsg').html('');
                            return true;
                        }
                    }
                }
            },
            chkIsPaymentOptionAgreed: {
                required: function () {
                    $('#divBankAccountDetailConfirmation').empty();
                    $('#divEFTPSccepted').empty();
                    $('#divCheckOrMoneyOrderAccepted').empty();
                    if ($('#radElectronicFundWithdrawal').prop('checked') == true && $('#chkBankAccountDetailConfirmation').prop('checked') == false) {
                        return true;
                    }
                    else if ($('#radElectronicFederalTaxPaymentSystem').prop('checked') == true && $('#chkEFTPSAccepted').prop('checked') == false) {
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
            radPaymentOption: {
                required: function () { $('#divIrsPaymentOptionValidation').html('IRS tax due payment option is not selected'); true; }
            },
            txtAccountNumber: {
                required: 'Missing Bank Account number',
                minlength: "Invalid Account Number",
                maxlength: "Invalid Account Number"
            },
            txtBankRoutingNumber: {
                required: 'Missing Routing Number',
                minlength: "Invalid Routing Number",
                maxlength: "Invalid Routing Number"
            },
            txtBankName: {
                required: 'Missing Bank Name'
            },
            radAccountType: {
                required: function () { $('#divTypeErrorMsg').html('Missing Type of account information.'); }
            },
            chkIsPaymentOptionAgreed: {
                required: function () {
                    if ($('#radElectronicFundWithdrawal').prop('checked') == true && $('#chkBankAccountDetailConfirmation').prop('checked') == false)
                        $('#divBankAccountDetailConfirmation').html('You have not accepted the information entered regarding the direct debit.');
                    else if ($('#radElectronicFederalTaxPaymentSystem').prop('checked') == true && $('#chkEFTPSAccepted').prop('checked') == false)
                        $('#divEFTPSccepted').html('You have not accepted your responsibility to schedule the tax due payment to the IRS using eftps.gov website.');
                    else if ($('#radCheckorMoneyOrder').prop('checked') == true && $('#chkCheckOrMoneyOrderAccepted').prop('checked') == false)
                        $('#divCheckOrMoneyOrderAccepted').html('Please accept to the declaration that the tax due payment will be paid by means of check or money order to the United States Treasury.');
                }
            }
        }
    });

    $('.spanTaxYear').html(CURRENT_TAX_YEAR);
    $("#divShowElectronicFundWithdrawal").hide();
    $("[name='radPaymentOption']").change(function () {
        //ON-Page 1
        if ($('#radElectronicFundWithdrawal').prop('checked')) {
            $('#divElectronicFundWithdrawal').show();
            $('#divElectronicFederalTaxPaymentSystem').hide();
            $('#chkEFTPSAccepted').prop('checked', false);
            $('#chkCheckOrMoneyOrderAccepted').prop('checked', false); //Saravanan N - 24th July, 2014 - Clear on-page3 selected option.
            $('#divCheckMyOrder').hide();
        }
        else if ($('#radElectronicFederalTaxPaymentSystem').prop('checked')) {
            //ON-Page 2
            $('#divElectronicFundWithdrawal').hide();
            $('#radSaving').prop('checked', false);
            $('#radChecking').prop('checked', false);
            $('#chkBankAccountDetailConfirmation').prop('checked', false);
            $('#txtAccountNumber').val('');
            $('#txtBankRoutingNumber').val('');
            $('#txtBankName').val('');
            $('#divElectronicFederalTaxPaymentSystem').show();
            $('#divCheckMyOrder').hide();
            $('#chkCheckOrMoneyOrderAccepted').prop('checked', false); //Saravanan N - 24th July, 2014 - Clear on-page3 selected option.
        }
        else if ($('#radCheckorMoneyOrder').prop('checked')) {
            //ON-Page 3
            $('#divElectronicFundWithdrawal').hide();
            $('#divElectronicFederalTaxPaymentSystem').hide();
            $('#divCheckMyOrder').show();
            $('#chkEFTPSAccepted').prop('checked', false);
            //Saravanan N - 24th July, 2014 - Clear on-page1 values of below 5 controls.
            $("[name='radAccountType']").prop('checked', false);
            $('#chkBankAccountDetailConfirmation').prop('checked', false);
            $('#txtAccountNumber').val('');
            $('#txtBankRoutingNumber').val('');
            $('#txtBankName').val('');

        }
    });

    $.ajax({
        url: serviceUrl + 'efile/getirspaymentoption',
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
                if (data.m_Item1 != null && data.m_Item1 > 0) {
                    $('#lblFederalTaxDue').html(data.m_Item1);
                }
                else {
                    //Saravanan N - 23rd July, 2014 - No Tax Due then redirec to next page.
                    setTimeout(function () {
                        window.location.href('../Efile/federalefileinformation.html');
                        return false;
                    });
                }
                if (data.m_Item2 != null && data.m_Item2.FederalFiling != null && data.m_Item2.FederalFiling.IRS != null) {
                    filing = data.m_Item2;
                    if (data.m_Item2.FederalFiling.IRS.PaymentOption != '') {
                        $('input[name=radPaymentOption][value=' + data.m_Item2.FederalFiling.IRS.PaymentOption + ']').prop('checked', true);
                        $('input[name=chkIsPaymentOptionAgreed][value=' + data.m_Item2.FederalFiling.IRS.PaymentOption + ']').prop('checked', true);
                        $('input:radio[name=radPaymentOption]').trigger('change');
                    }
                    if (data.m_Item2.FederalFiling.IRS.BankDetails != null) {
                        $('input[name=radAccountType][value=' + data.m_Item2.FederalFiling.IRS.BankDetails.BankAccountTypeCode + ']').prop('checked', true);
                        $('#txtAccountNumber').val(data.m_Item2.FederalFiling.IRS.BankDetails.AccountNumber);
                        $('#txtBankRoutingNumber').val(data.m_Item2.FederalFiling.IRS.BankDetails.RoutingTransitNumber);
                        $('#txtBankName').val(data.m_Item2.FederalFiling.IRS.BankDetails.BankName);
                        $('input:radio[name=chkBankAccountDetailConfirmation]').checked = true;
                    }

                }
                if (data.m_Item2 != null) {
                    if (data.m_Item2.FederalFiling.IsEfile) {
                        $("#divShowElectronicFundWithdrawal").show();
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
            PaymentOption: $('input:radio[name=radPaymentOption]:checked').val(),
            IsIRSPaymentOptionAgreed: $('input:checkbox[value=' + $('input:radio[name=radPaymentOption]:checked').val() + ']').prop('checked'),
            BankDetails: bankDetails,
            IRSTransmission: ((filing != null && filing.FederalFiling != null
                                              && filing.FederalFiling.IRS != null
                                              && filing.FederalFiling.IRS.IRSTransmission != null) ? filing.FederalFiling.IRS.IRSTransmission : null)
        };

        $.ajax({
            url: serviceUrl + 'efile/persistirspaymentoption',
            async: false,
            dataType: 'json',
            type: 'POST',
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                UserId: userId,
                UserDataId: userDataId,
                IRS: irs,
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
                        setTimeout(function () {
                            window.location.href = '../Efile/federalefileinformation.html';
                        });
                    }
                }
            }
        });
    }
}
