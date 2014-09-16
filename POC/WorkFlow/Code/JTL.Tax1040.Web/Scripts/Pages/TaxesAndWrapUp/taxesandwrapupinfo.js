
var BankDetails;
var ThirdPartyDesignee;
var BankAccountTypeCode;
var taxData;
var taxWrapUpData;
$(document).ready(function () {

    $('.spanFillingYear').html(FILLING_YEAR);

    $('#divDirectDepositofFederalTaxRefundShow').hide();
    $('#divOtherPersonShow').hide();
    $('#divFederalExtensionPaidShow').hide();
    $('#divLateFilingShow').hide();
    $('#divDirectDeposityYes').click(function () {
        $('#divDirectDepositofFederalTaxRefundShow').show();
    });
    $('#divDirectDepositNo').click(function () {
        $('#divDirectDepositofFederalTaxRefundShow').hide();
    });
    $('#divAllowOtherPersonYes').click(function () {
        $('#divOtherPersonShow').show();
    });
    $('#divAllowOtherPersonNo').click(function () {
        $('#divOtherPersonShow').hide();
    });
    $('#chkFederalExtensionPaid').click(function () {
        $('#divFederalExtensionPaidShow').toggle();
    });
    $('#chklateFiling').click(function () {
        $('#divLateFilingShow').toggle();
    });
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
                if (data.m_Item2 != null) {
                    taxWrapUpData = data.m_Item2;
                    $('#chkFiledForm4868').prop('checked', data.m_Item2.HasFiledForm4868);

                    $('#chkFederalExtensionPaid').prop('checked', data.m_Item2.HasPaidFederalExtensionWithForm4868);
                    $("#txtFederalExtensionAmount").val(data.m_Item2.FederalExtensionAmount);
                    if (data.m_Item2.FilingDate != null)
                        $("#txtDatePaid").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.FilingDate)));

                    if (data.m_Item2.HasPaidFederalExtensionWithForm4868) {
                        $("#chkFederalExtensionPaid").prop('checked', 'checked');
                        $('#divFederalExtensionPaidShow').show();
                    }

                    $('#chklateFiling').prop('checked', data.m_Item2.IsFilingReturnAfterDueDate);

                    if (data.m_Item2.FederalExtensionAmountPaidDate != null)
                        $("#txtDateOfFiling").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.FederalExtensionAmountPaidDate)));

                    if (data.m_Item2.IsFilingReturnAfterDueDate) {
                        $("#chklateFiling").prop('checked', 'checked');
                        $('#divLateFilingShow').show();
                    }

                    $('#radIsDirectDepositYes').prop('checked', data.m_Item2.HasToDepositTaxRefundsToBankAccount);
                    $("#txtBankRoutingNumber").val(data.m_Item2.BankDetails.RoutingTransitNumber);
                    $("#txtBankAccountNumber").val(data.m_Item2.BankDetails.AccountNumber);
                    $("#txtBankName").val(data.m_Item2.BankDetails.BankName);
                    if (data.m_Item2.BankDetails.BankAccountTypeCode == 1) {
                        $("#radChecked").prop("checked", true);
                    }
                    else if (data.m_Item2.BankDetails.BankAccountTypeCode == 2) {
                        $('#radSaved').prop('checked', true);
                    }
                    if (data.m_Item2.HasToDepositTaxRefundsToBankAccount) {
                        $("#radIsDirectDepositYes").prop('checked', 'checked');
                        $('#divDirectDepositofFederalTaxRefundShow').show();
                    }


                    $('#radIsAllowOtherPersonYes').prop('checked', data.m_Item2.HasThirdPartyDesignee),
                    $("#txtDesignName").val(data.m_Item2.ThirdPartyDesignee.DesigneeName),
                    $("#txtPhoneno").val(data.m_Item2.ThirdPartyDesignee.PhoneNumber),
                    $("#txtPersonalIdentificationNumber").val(data.m_Item2.ThirdPartyDesignee.PIN)

                    if (data.m_Item2.HasThirdPartyDesignee) {
                        $("#radIsAllowOtherPersonYes").prop('checked', 'checked');
                        $('#divOtherPersonShow').show();
                    }


                    $("#txtIncareof").val(data.m_Item2.InCareOf),
                    $("#txtPhoneNumber").val(data.m_Item2.InCareOfPhoneNumber)
                }
            }
        }
    });
});

function PersistTaxAndwrapup(isContinue) {
    if ($('#radChecked').prop('checked')) {
        BankAccountTypeCode = 1;
    }
    else if ($('#radSaved').prop('checked')) {
        BankAccountTypeCode = 2;
    }
    if ($('#radIsDirectDepositYes').prop('checked')) {
        BankDetails = {
            RoutingTransitNumber: $('#txtBankRoutingNumber').val(),
            AccountNumber: $('#txtBankAccountNumber').val(),
            BankName: $('#txtBankName').val(),
            BankAccountTypeCode: BankAccountTypeCode
        }
    }
    else {
        BankDetails = null;
    }
    if ($('#radIsAllowOtherPersonYes').prop('checked')) {
        ThirdPartyDesignee =
        {
            DesigneeName: $('#txtDesignName').val(),
            PhoneNumber: $('#txtPhoneno').val(),
            PIN: $('#txtPersonalIdentificationNumber').val(),
        }
    }
    else {
        ThirdPartyDesignee = null;
    }

    if (taxWrapUpData != null) {
        taxData = {
            HasOwedHouseholdEmploymentTax: taxWrapUpData.HasOwedHouseholdEmploymentTax,
            HasAlternativeMinimumTax: taxWrapUpData.HasAlternativeMinimumTax,
            HasAdditionalSocialSecurityOrMedicareTax: taxWrapUpData.HasAdditionalSocialSecurityOrMedicareTax,
            HasFederalQuarterlyEstimatesPaid: taxWrapUpData.HasFederalQuarterlyEstimatesPaid,
            HasFiledForm4868: $('#chkFiledForm4868').prop('checked'),
            HasPaidFederalExtensionWithForm4868: $('#chkFederalExtensionPaid').prop('checked'),
            FederalExtensionAmount: $('#txtFederalExtensionAmount').val(),
            FilingDate: $('#txtDatePaid').val(),
            IsFilingReturnAfterDueDate: $('#chklateFiling').prop('checked'),
            FederalExtensionAmountPaidDate: $('#txtDateOfFiling').val(),
            HasToDepositTaxRefundsToBankAccount: $('#radIsDirectDepositYes').prop('checked'),
            HasThirdPartyDesignee: $('#radIsAllowOtherPersonYes').prop('checked'),
            InCareOf: $('#txtIncareof').val(),
            InCareOfPhoneNumber: $('#txtPhoneNumber').val(),
            BankDetails: BankDetails,
            ThirdPartyDesignee: ThirdPartyDesignee
        }
    }
    else {
        taxData = {
            HasFiledForm4868: $('#chkFiledForm4868').prop('checked'),
            HasPaidFederalExtensionWithForm4868: $('#chkFederalExtensionPaid').prop('checked'),
            FederalExtensionAmount: $('#txtFederalExtensionAmount').val(),
            FilingDate: $('#txtDatePaid').val(),
            IsFilingReturnAfterDueDate: $('#chklateFiling').prop('checked'),
            FederalExtensionAmountPaidDate: $('#txtDateOfFiling').val(),
            HasToDepositTaxRefundsToBankAccount: $('#radIsDirectDepositYes').prop('checked'),
            HasThirdPartyDesignee: $('#radIsAllowOtherPersonYes').prop('checked'),
            InCareOf: $('#txtIncareof').val(),
            InCareOfPhoneNumber: $('#txtPhoneNumber').val(),
            BankDetails: BankDetails,
            ThirdPartyDesignee: ThirdPartyDesignee
        }
    }

    $.ajax({
        url: serviceUrl + 'taxesandwrapup/persisttaxesandwrapupdata',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
                 {
                     userDataId: userDataId,
                     TaxData: JSON.stringify(taxData),
                 }
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data.m_Item1);
            if (isContinue) {
                PageNavigate(data.m_Item2);
                return false;
            }
        }
    });
}

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        setTimeout(function () {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=TaxesAndWrapUp';
        });
    }
    else {
        setTimeout(function () {
            window.location.href = '../TaxesAndWrapUp/federaltaxsummary.html';
        });
    }
}