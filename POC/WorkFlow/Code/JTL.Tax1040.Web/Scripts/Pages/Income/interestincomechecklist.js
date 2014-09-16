// 7 Apr 2014 Vincent Added script for  Interest income check list
// 28 Apr 2014 Sathish Saved user data id in session and also deleted user id assigned from session.
// 30 Apr 2014 Bala Persist methd modified to navigate to eligibility diagnostics page.
//Script for Interest income check list


$(document).ready(function () {

    $("#CheckListvalidate").validate({
        rules: {

            chkListINT: "required"
        },
        messages: {
            chkListINT: "You have missed to select  the option none of the above.",


        }
    });

    GetInterestIncomeEligibility();

});

function GetInterestIncomeEligibility() {
    $.ajax({
        url: serviceUrl + 'interestincome/getinterestincomeeligibilitydata',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            //alert('success');
            //var EmployerName = data.;
            //var PayerName = data;
            //var WagesAmount = data;
            if (data != null) {
                $("#chkNomineeInterest").prop("checked", data.HasInterestReceivedAsNominee);
                $("#chkUSSavingBond").prop("checked", data.HasPreviousYearsUSBondsInterest);
                $("#chkForeignFinancial").prop("checked", data.HasOwnedForeignFinancialAccounts);
                $("#chkSellerMortgage").prop("checked", data.HasSellerFinancedMortageInterest);
                $("#chkOrginalIssueDiscount").prop("checked", data.IsReportingLesserOID);
                $("#chkAmortizable").prop("checked", data.IsExemptByAmortizableBond);
                $("#chkEEorUS").prop("checked", data.IsClaimingEEOrIUSBondsInterestAfter1989);
                $("#chkForeignTaxCredit").prop("checked", data.HasForeignTaxCredit);
                $("#chkEarlyPenalty").prop("checked", data.HasEarlyWithdrawalPenalty);
                $("#chkNoneAbove").prop("checked", data.HasNoneOfOptions);
            }
        }
    });
}


function PersistInterestIncomeEligibility(isContinue) {
    var IntIncomeEligibilityData;
    if ($("#CheckListvalidate").valid()) {

        IntIncomeEligibilityData = {
            HasInterestReceivedAsNominee: $("#chkNomineeInterest").prop('checked'),
            HasPreviousYearsUSBondsInterest: $("#chkUSSavingBond").prop('checked'),
            HasOwnedForeignFinancialAccounts: $("#chkForeignFinancial").prop('checked'),
            HasSellerFinancedMortageInterest: $("#chkSellerMortgage").prop('checked'),
            IsReportingLesserOID: $("#chkOrginalIssueDiscount").prop('checked'),
            IsExemptByAmortizableBond: $("#chkAmortizable").prop('checked'),
            IsClaimingEEOrIUSBondsInterestAfter1989: $("#chkEEorUS").prop('checked'),
            HasForeignTaxCredit: $("#chkForeignTaxCredit").prop('checked'),
            HasEarlyWithdrawalPenalty: $("#chkEarlyPenalty").prop('checked'),
            HasNoneOfOptions: $("#chkNoneAbove").prop('checked')
        };

        $.ajax({
            url: serviceUrl + 'interestincome/persistinterestincomeeligibilitydata',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                UserId: userId,
                UserDataId: userDataId,
                TaxData: IntIncomeEligibilityData
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                userDataId = data.m_Item1;
                window.sessionStorage.setItem("UserDataId", userDataId);
                if (isContinue) {
                    PageNavigate(data.m_Item2);
                    return false;
            }
            }
        });
    }
}

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        setTimeout(function() {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=InterestIncome';
        });
    }
    else {
        setTimeout(function() {
            window.location.href = '../Income/interestincome.html';
        });
    }
}