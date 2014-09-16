// 7 Apr 2014 Vincent Added script for  Interest income check list
// 28 Apr 2014 Sathish Saved user data id in session and also deleted user id assigned from session.
// 30 Apr 2014 Bala Persist methd modified to navigate to eligibility diagnostics page.
//23 May 2014 Ashok Kumar added Diagnostic Error Message control focus script
//Script for Interest income check list


/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/



/**************************************** PAGE LOAD ACTION ****************************************/

var isformvalid = false;

$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.CurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);
    ValidateCheckBox();
    BindEvents();
    GetInterestIncomeEligibility();
    focusControlFromDiagnosticPage();

    //Saravanan N - 30th May, 2014 - Code added to display Error Message.
    $('#dvError').hide(); //Default hide.

    $("[name='chkListINT']").click(function () {
        if (this.checked) {
            $('#dvError').hide();
        }
        else {
            if ($("#frmInterestIncomeChkList").valid() == false) {
                $('#dvError').show();
            }
        }
    });

    //Saravanan N - 12th June, 2014 - Code added to toggle the check box.
    $('.chkOthers').click(function () {
        if (this.checked) {
            $('.chkNone').attr('checked', false);
        }
    });

    //Saravanan N - 12th June, 2014 - Code added to toggle the check box.
    $('.chkNone').click(function () {
        if (this.checked) {
            $('.chkOthers').attr('checked', false);
        }
    });
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
function setDefaultValues() {
    $('#currentYear1').text(CURRENT_TAX_YEAR);
    $('#currentYear2').text(CURRENT_TAX_YEAR);
    $('#currentYear3').text(CURRENT_TAX_YEAR);

    $('#dvError').hide();
}

//Saravanan N - 28th May, 2014 - Method refactored.
function focusControlFromDiagnosticPage() {
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var controlToFocus = parameterName[1];
        $('#' + controlToFocus).focus();
    }
}

//Saravanan N - 28th May, 2014 - Method refactored.
//Saravanan N - 12th Aug, 2014 - Error message changed as suggested by Rajadurai.
function ValidateCheckBox() {
    $("#frmInterestIncomeChkList").validate({
        rules: {
            chkListINT: "required"
        },
        messages: {
            chkListINT: "You missed to make a selection. If nothing applies, select “None of the above”.",
        },
        errorPlacement: function (error, element) {
            $('#dvError').show();
            error.appendTo('#dvError');
        }
    });
}

//Saravanan N - 28th May, 2014 - Method refactored.
function BindEvents() {
    $('#btnContinue').click(function () {

        var isvalid = PersistInterestIncomeEligibility(true);

        if (isformvalid) {
            PageNavigate(isvalid);
            return false;
        }
        else {
         
        }




    });
    //Added by prasana for back button on 01.08.2014
    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });
}

//Get Method
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

//Persist Method.
function PersistInterestIncomeEligibility(isContinue) {
    var IntIncomeEligibilityData;
    var fxnavigation;
   
    if ($("#frmInterestIncomeChkList").valid()) {

        isformvalid = true;

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

        var userDTOData = {
            UserId: userId,
            UserDataId: userDataId
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
                UserDTO: userDTOData,
                InterestIncomeEligibility: IntIncomeEligibilityData
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data != null) {
                    userDataId = data.m_Item1;
                    window.sessionStorage.setItem("UserDataId", userDataId);
                    if (isContinue) {
                        // PageNavigate(data.m_Item2);
                        // return false;
                        fxnavigation = data.m_Item2;
                    }
                }
            }
        });

        return fxnavigation;
    }
 
}

//Navigate method
function PageNavigate(isDiagonstics) {
    if (isDiagonstics) {
        // swapnesh removed setTimeout
        //  setTimeout(function () {
        //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
        window.location.href = '../Review/finalsummary.html?Topic=InterestIncome';
        return false;
        //  });
    }
    else if (!isDiagonstics) {
        // setTimeout(function () {
        window.location.href = '../Income/interestincome.html';
        return false;
        //  });
    }

}