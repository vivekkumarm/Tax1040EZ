//Created by Saravanan N - 21st April, 2014
/* Modification History
* 23Apr2014 Sathish  Added method for EIC persist
*/

//Saravanan N - 23rd April, 2014 - The below line will provide intellisense for Constants.

$(document).ready(function () {

    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        
        $('#' + divToExpand).show();
        $('#' + controlToFocus).focus();
    }

    $('.spanCurrentTaxyear').html(CURRENT_TAX_YEAR);
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    $('#radTaxableScholarshipYes').click(function () {
        $('#divTaxableScholarship').show();
    });

    $('#radTaxableScholarshipNo').click(function () {
        $('#divTaxableScholarship').hide();
    });

    $('#radPensionAnnuityYes').click(function () {
        $('#divPensionAnnuity').show();
    });

    $('#radPensionAnnuityNo').click(function () {
        $('#divPensionAnnuity').hide();
    });

    $('#radInmateWagesYes').click(function () {
        $('#divInmateWages').show();
    });

    $('#radInmateWagesNo').click(function () {
        $('#divInmateWages').hide();
    });

    $('#radEICforPriorYearDisallowanceYes').click(function () {
        $('#divEICforPriorYearDisallowance').show();
    });

    $('#radEICforPriorYearDisallowanceNo').click(function () {
        $('#divEICforPriorYearDisallowance').hide();
    });

    $('#chkNoticeFromIRSToFileForm8862').click(function () {
        $('#divEicForDisallowance').toggle();
    });

    $('#btnContinue').click(function () {
        if (PersistEIC()) {
            window.location.href = '../Credits/creditsummary.html';
        }
        return false;
    });
});

//Sathish N - 22nd April, 2014
function GetEarnedIncomeCredit() {
    $.ajax({
        url: serviceUrl + 'earnedincomecredit/getearnedincomecredit',
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
            var taxPayerName, isEciEligible;

            taxPayerName = data.m_Item2;
            isEciEligible = data.m_Item3;

            //adjustedGrossIncome = data.m_Item1.AdjustedGrossIncome;
            //$('#lblPayerName').html(data.PrimaryTaxPayerName);
            var spanTPNameInP1 = taxPayerName + ', you have qualified for Earned income Credit.'
            var spanTPNameInP2 = taxPayerName + ', you are not qualified for Earned Income Credit for any of the following reasons.'

            $('#spanTaxPayerInP1').text(spanTPNameInP1);
            $('#spanTaxPayerInP2').text(spanTPNameInP2);

            if (!isEciEligible) {
                $('#divCheckbox').hide();
                $('#divAdditionalInformation').hide();
            }
            else {
                //If ECI not eligible, for the user then no need to do the below check.
                $('#divEicNotEligible').hide();

            if (data.m_Item1 != null) {
                $("#chkHasValidSSN").prop("checked", data.m_Item1.HasValidSSN);
                $("#chkLivedInUSMoreThanHalfYear").prop("checked", data.m_Item1.IsInUSMorethanHalfYear);
                $("#chkClaimedAsQualifiedChild").prop("checked", data.m_Item1.HasClaimedAsQualifyingChild);
                $("#chkNoticeFromIRSToClaimEIC").prop("checked", data.m_Item1.IsProhibitedFromClaimingEIC);

                $("#radEICforPriorYearDisallowanceYes").prop("checked", data.m_Item1.HasEICForPriorYearDisallowance);
                    $("#radIncorrectlyReportedEarnedIncomeYes").prop("checked", data.m_Item1.HasIncorrectlyReportedEarnedIncome);
                $("#txtNoOfDaysTaxPayerLivedInUS").val(data.m_Item1.NumberOfDaysTaxPayerLivedInUS);
                $("#txtNoOfDaysSpouseLivedInUS").val(data.m_Item1.NumberOfDaysSpouseLivedInUS);

                    //check <c5> check box control checked status
                    if (data.m_Item1.HasReceivedIRSNoticeOnFiling8862) {
                        $("#chkNoticeFromIRSToFileForm8862").prop('checked', 'checked');
                        $('#divEicForDisallowance').show();
                    }

                    //check <r6> control checked status
                    if (data.m_Item1.HasTaxableScholarshipCredits) {
                        $("#radTaxableScholarshipYes").attr('checked', 'checked');
                        $('#divTaxableScholarship').show();
                    }

                    //check <r8> control checked status
                    if (data.m_Item1.HasPensionAnnuity) {
                        $("#radPensionAnnuityYes").attr('checked', 'checked');
                        $('#divPensionAnnuity').show();
                    }

                    //check <r10> control checked status
                    if (data.m_Item1.HasPenalInstitutionInmateWages) {
                        $("#radInmateWagesYes").attr('checked', 'checked');
                        $('#divInmateWages').show();
                    }

                    if (data.m_Item1.HasEICForPriorYearDisallowance) {
                        $("#radEICforPriorYearDisallowanceYes").prop('checked', 'checked');
                        $('#divEICforPriorYearDisallowance').show();
                    }

                $("#txtTaxableScholarship").val(data.m_Item1.TaxableScholarshipCredit);
                $("#txtPensionAnnuity").val(data.m_Item1.PensionAnnuity);
                $("#txtInmateWages").val(data.m_Item1.PenalInstitutionInmateWages);
            }
        }
        }
    });
}

//* 23Apr2014 Sathish  Added method for EIC persist
function PersistEIC() {
    var isEICUpdated = false;
    var numberOfDaysTaxpayerLivedInUS, numberOfDaysSpouseLivedInUS, taxableScholarshipAmount, pensionAnnuityAmount, inmateWagesAmount;


    //If <r12> radio button not selected set its value to 0.
    if ($("#radEICforPriorYearDisallowanceYes").prop("checked")) {
        numberOfDaysTaxpayerLivedInUS = GetZeroOnIsNullOrEmpty($("#txtNoOfDaysTaxPayerLivedInUS").val());
        numberOfDaysSpouseLivedInUS = GetZeroOnIsNullOrEmpty($("#txtNoOfDaysSpouseLivedInUS").val());
    }
    else
    {
        numberOfDaysTaxpayerLivedInUS = 0;
        numberOfDaysSpouseLivedInUS = 0;
    }

    //If <r6> radio button not selected set its value to 0.
    taxableScholarshipAmount = ($("#radTaxableScholarshipYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtTaxableScholarship").val()) : 0);

    //If <r8> radio button not selected set its value to 0.
    pensionAnnuityAmount = ($("#radPensionAnnuityYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtPensionAnnuity").val()) : 0);

    //If <r10> radio button not selected set its value to 0.
    inmateWagesAmount = ($("#radInmateWagesYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtInmateWages").val()) : 0);

    var EIC = {
        HasValidSSN: $("#chkHasValidSSN").prop("checked"),
        IsInUSMorethanHalfYear: $("#chkLivedInUSMoreThanHalfYear").prop("checked"),
        HasClaimedAsQualifyingChild: $("#chkClaimedAsQualifiedChild").prop("checked"),
        IsProhibitedFromClaimingEIC: $("#chkNoticeFromIRSToClaimEIC").prop("checked"),
        HasReceivedIRSNoticeOnFiling8862: $("#chkNoticeFromIRSToFileForm8862").prop("checked"),
        HasEICForPriorYearDisallowance: $("#radEICforPriorYearDisallowanceYes").prop("checked"),
        HasIncorrectlyReportedEarnedIncome: $("#radIncorrectlyReportedEarnedIncomeYes").prop("checked"),
        NumberOfDaysTaxPayerLivedInUS: numberOfDaysTaxpayerLivedInUS,
        NumberOfDaysSpouseLivedInUS: numberOfDaysSpouseLivedInUS,
        HasTaxableScholarshipCredits: $("#radTaxableScholarshipYes").prop("checked"),
        TaxableScholarshipCredit: taxableScholarshipAmount,
        HasPensionAnnuity: $("#radPensionAnnuityYes").prop("checked"),
        PensionAnnuity: pensionAnnuityAmount,
        HasPenalInstitutionInmateWages: $("#radInmateWagesYes").prop("checked"),
        PenalInstitutionInmateWages: inmateWagesAmount,
    }

    $.ajax({
        url: serviceUrl + 'earnedincomecredit/persistearnedincomecredit',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            TaxReturnData:
             {
                 UserDataId: userDataId,
                 TaxData: JSON.stringify(EIC),
             }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data);
            isEICUpdated = true;
        }
    });
    return isEICUpdated;
}

// 23Apr2014 Sathish Method will return 0 on is null or empty
// TODO: It can be removed after NULL check added for double value in workflow - Saravanan N.
function GetZeroOnIsNullOrEmpty(value) {
    if (value == "" || value == null)
        return 0;
    else {
        return value;
    }
}