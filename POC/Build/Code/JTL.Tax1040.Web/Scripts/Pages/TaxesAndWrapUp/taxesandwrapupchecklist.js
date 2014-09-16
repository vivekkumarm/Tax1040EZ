/* 27Mya2014 Sathish Added Tax and wrap up Bind and persist  */


var taxData;
var taxWrapUpData;

$(document).ready(function () {
    
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);


    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 1) {
        var controlToFocus = parameterName[0];
        $('#' + controlToFocus).focus();
    }

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
                    taxWrapUpData = data.m_Item1;
                    $('#chkHouseHoldWages').prop('checked', data.m_Item1.HasOwedHouseholdEmploymentTax);
                    $('#chkAlternateMinimumTaxes').prop('checked', data.m_Item1.HasAlternativeMinimumTax);
                    $('#chkMedicareTaxes').prop('checked', data.m_Item1.HasAdditionalSocialSecurityOrMedicareTax);
                    $('#chkFederalQuaterlyEstimatePaid').prop('checked', data.m_Item1.HasFederalQuarterlyEstimatesPaid);
                }
                if (data.m_Item2 != null) {
                    $('#lblFirstName').html(data.m_Item2);
                }
            }
        }
    });
}
);
function TaxandWrapupPersist(isContinue) {

    if (taxWrapUpData != null) {
        taxData = {
            HasOwedHouseholdEmploymentTax: $('#chkHouseHoldWages').prop('checked'),
            HasAlternativeMinimumTax: $('#chkAlternateMinimumTaxes').prop('checked'),
            HasAdditionalSocialSecurityOrMedicareTax: $('#chkMedicareTaxes').prop('checked'),
            HasFederalQuarterlyEstimatesPaid: $('#chkFederalQuaterlyEstimatePaid').prop('checked'),
            FederalExtensionFiledDate: taxWrapUpData.FederalExtensionFiledDate,
            HasFiledForm4868: taxWrapUpData.HasFiledForm4868,
            HasPaidFederalExtensionWithForm4868: taxWrapUpData.HasPaidFederalExtensionWithForm4868,
            FederalExtensionAmount: taxWrapUpData.FederalExtensionAmount,
            FilingDate: taxWrapUpData.FilingDate,
            IsFilingReturnAfterDueDate: taxWrapUpData.IsFilingReturnAfterDueDate,
            FederalExtensionAmountPaidDate: taxWrapUpData.FederalExtensionAmountPaidDate,
            HasToDepositTaxRefundsToBankAccount: taxWrapUpData.HasToDepositTaxRefundsToBankAccount,
            HasThirdPartyDesignee: taxWrapUpData.HasThirdPartyDesignee,
            InCareOf: taxWrapUpData.InCareOf,
            InCareOfPhoneNumber: taxWrapUpData.InCareOfPhoneNumber,
            BankDetails: taxWrapUpData.BankDetails,
            ThirdPartyDesignee: taxWrapUpData.ThirdPartyDesignee,
        };
    }
    else {
        taxData = {
            HasOwedHouseholdEmploymentTax: $('#chkHouseHoldWages').prop('checked'),
            HasAlternativeMinimumTax: $('#chkAlternateMinimumTaxes').prop('checked'),
            HasAdditionalSocialSecurityOrMedicareTax: $('#chkMedicareTaxes').prop('checked'),
            HasFederalQuarterlyEstimatesPaid: $('#chkFederalQuaterlyEstimatePaid').prop('checked'),
        };
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
            window.location.href = '../TaxesAndWrapUp/taxesandwrapupinfo.html';
        });
    }
}
