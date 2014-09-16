//Created by Saravanan N - 21st April, 2014
/* Modification History
* 23Apr2014 Sathish  Added method for EIC persist
* 11Jun2014 Vincent Refactor the code changes.
*/

//Saravanan N - 23rd April, 2014 - The below line will provide intellisense for Constants.
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var isEciEligible;
var isEICUpdated = false;
var taxPayerName;
var numberOfDaysTaxpayerLivedInUS, numberOfDaysSpouseLivedInUS, taxableScholarshipAmount, pensionAnnuityAmount, inmateWagesAmount;
var spanTPNameInP1;
var spanTPNameInP2;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');

    //Modified by prasana on 06/06/2014 for textbox allowing only  numeric characters 
    NumbersOnly('txtTaxableScholarship');
    NumbersOnly('txtPensionAnnuity');
    NumbersOnly('txtInmateWages');
    NumbersOnly('txtNoOfDaysTaxPayerLivedInUS');
    NumbersOnly('txtNoOfDaysSpouseLivedInUS');

    
   

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

    //Modified by prasana on 09/06/2014 for showing "next" button when chkNoticeFromIRSToFileForm8862 is clicked
    $('#chkNoticeFromIRSToFileForm8862').click(function () {
        $('#divEicForDisallowance').toggle();
        $('#divNextButton').toggle();
    });

    $('#btnContinue').click(function () {
        if (PersistEIC()) {

            //11Jun2014-Vincent-modified EIC eligible check navigation
            if (!isEciEligible) {

                window.location.href = '../TaxesAndWrapUp/taxesandwrapupchecklist.html';
            }
            else {
                window.location.href = '../Credits/creditsummary.html';
            }
        }
        return false;
    });

 
    //Added by prasana for Next button on 09.06.2014
    $('#btnSubmitOne').click(function () {
        if ($("#frmUnemployment").valid()) {
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#creditGateway').removeClass('accordion-toggle').addClass('accordion-toggle  collapsed');
            $('#earnedIncomeCredit').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }

        return false;

    });

    GetEarnedIncomeCredit();


    //Focus Method form Diagnostics.
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }


    //Added by Prasana on 06/06/2014
    $(function () {
        $("#popTaxableScholarship").popover({ title: '', content: "<h5>Amount</h5>Enter your taxable Scholarship or Fellowship income not reported on Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPensionAnnuity").popover({ title: '', content: "<h5>Amount</h5>Enter your pension or annuity compensation from an non qualified deferred compensation  plan not reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popInmateWages").popover({ title: '', content: "<h5>Amount</h5>Enter your Wages received while worked as a inmate in a penal Institution.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNoOfDaysTaxPayerLivedInUs").popover({ title: '', content: "<h5>Number of days Taxpayer lived in US</h5>Enter the number of days that you lived in United states.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNoOfDaysSpouseLivedInUs").popover({ title: '', content: "<h5>Number of days Spouse lived in US</h5>Enter the number of days that your Spouse lived in United states.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

//Get EIC
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
           

            taxPayerName = data.m_Item2;
            isEciEligible = data.m_Item3;

            spanTPNameInP1 = 'Hi'+" "+ taxPayerName + ', you have qualified for Earned income Credit.'
            spanTPNameInP2 = 'Hi'+" " + taxPayerName + ', you are not qualified for Earned Income Credit for any of the following reasons'

            $('#spanTaxPayerInP1').text(spanTPNameInP1);
            $('#spanTaxPayerInP2').text(spanTPNameInP2);

            if (!isEciEligible) {
                $('#divCheckbox').hide();
                $('#divAdditionalInformation').hide();
                $('#dvPensionAnnuity').hide();
            }
            else {
                //If ECI not eligible, for the user then no need to do the below check.
                $('#divEicNotEligible').hide();

            if (data.m_Item1 != null) {
                $("#chkHasValidSSN").prop("checked", data.m_Item1.HasValidSSN);
                $("#chkLivedInUSMoreThanHalfYear").prop("checked", data.m_Item1.IsInUSMorethanHalfYear);
                $("#chkClaimedAsQualifiedChild").prop("checked", data.m_Item1.HasClaimedAsQualifyingChild);
                $("#chkNoticeFromIRSToClaimEIC").prop("checked", data.m_Item1.HasReceivedIRSNoticeOnEICNotEligible);

                $("#radEICforPriorYearDisallowanceYes").prop("checked", data.m_Item1.HasEICForPriorYearDisallowance);
                $("#radIncorrectlyReportedEarnedIncomeYes").prop("checked", data.m_Item1.HasIncorrectlyReportedEarnedIncome);
                $("#txtNoOfDaysTaxPayerLivedInUS").val(data.m_Item1.NumberOfDaysTaxPayerLivedInUS);
                $("#txtNoOfDaysSpouseLivedInUS").val(data.m_Item1.NumberOfDaysSpouseLivedInUS);

                    //check <c5> check box control checked status
                    if (data.m_Item1.HasReceivedIRSNoticeOnFiling8862) {
                        $("#chkNoticeFromIRSToFileForm8862").prop('checked', 'checked');
                        $('#divEicForDisallowance').show();
                    }

                    if (data.m_Item1.HasIncorrectlyReportedEarnedIncome!=null &&!data.m_Item1.HasIncorrectlyReportedEarnedIncome)
                    {
                        $("#radIncorrectlyReportedEarnedIncomeNo").attr('checked', 'checked');
                    }

                    if (data.m_Item1.HasEICForPriorYearDisallowance !=null &&!data.m_Item1.HasEICForPriorYearDisallowance) {
                        
                        $("#radEICforPriorYearDisallowanceNo").attr('checked', 'checked');
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

                //Added by prasana on 06.09.2014 for Showing next button when check box values binded
                    if ($('#chkNoticeFromIRSToFileForm8862').prop('checked')) {
                        $('#divNextButton').show();
                    }
                    else {
                        $('#divNextButton').hide();
                    }


                //Modified by Thileep on 09.06.2014 for displaying place holder
                //01Jul2014 Sathish checked null and assigned value
                    $("#txtTaxableScholarship").val((data.m_Item1.TaxableScholarshipCredit == null) ? '' : data.m_Item1.TaxableScholarshipCredit);
                    $("#txtPensionAnnuity").val((data.m_Item1.PensionAnnuity == null) ? '' : data.m_Item1.PensionAnnuity);
                    $("#txtInmateWages").val((data.m_Item1.PenalInstitutionInmateWages == null) ? '' : data.m_Item1.PenalInstitutionInmateWages);
                    $("#txtNoOfDaysTaxPayerLivedInUS").val((data.m_Item1.NumberOfDaysTaxPayerLivedInUS == null) ? '' : data.m_Item1.NumberOfDaysTaxPayerLivedInUS);
                    $("#txtNoOfDaysSpouseLivedInUS").val((data.m_Item1.NumberOfDaysSpouseLivedInUS == null) ? '' : data.m_Item1.NumberOfDaysSpouseLivedInUS);
                
            }
        }
        }
    });
}


//Persist EIC
//* 23Apr2014 Sathish  Added method for EIC persist
function PersistEIC() {
    

    //30Jun2014 Sathish will set null if IRS 
    var hasEICForPriorYearDisallowance;
    var hasIncorrectlyReportedEarnedIncome;
    //If <r12> radio button not selected set its value to 0.
    if ($("#chkNoticeFromIRSToFileForm8862").prop("checked")) {
        if ($("#radEICforPriorYearDisallowanceYes").prop("checked")) {
            numberOfDaysTaxpayerLivedInUS = GetZeroOnIsNullOrEmpty($("#txtNoOfDaysTaxPayerLivedInUS").val());
            numberOfDaysSpouseLivedInUS = GetZeroOnIsNullOrEmpty($("#txtNoOfDaysSpouseLivedInUS").val());
        }
        hasEICForPriorYearDisallowance = ($('#radEICforPriorYearDisallowanceYes').prop('checked') == false
                                             && $('#radEICforPriorYearDisallowanceNo').prop('checked') == false)
                                                ? null : $('#radEICforPriorYearDisallowanceYes').prop('checked');
        hasIncorrectlyReportedEarnedIncome = ($('#radIncorrectlyReportedEarnedIncomeYes').prop('checked') == false &&
                                             $('#radIncorrectlyReportedEarnedIncomeNo').prop('checked') == false)
                                             ? null : $('#radIncorrectlyReportedEarnedIncomeYes').prop('checked');
    }
    else {
        numberOfDaysTaxpayerLivedInUS = 0;
        numberOfDaysSpouseLivedInUS = 0;
        hasEICForPriorYearDisallowance = null;
        hasIncorrectlyReportedEarnedIncome = null;
    }


    //If <r6> radio button not selected set its value to 0.
    taxableScholarshipAmount = ($("#radTaxableScholarshipYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtTaxableScholarship").val()) : null);

    //If <r8> radio button not selected set its value to 0.
    pensionAnnuityAmount = ($("#radPensionAnnuityYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtPensionAnnuity").val()) : null);

    //If <r10> radio button not selected set its value to 0.
    inmateWagesAmount = ($("#radInmateWagesYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtInmateWages").val()) : null);

    var EIC = {
        HasValidSSN: $("#chkHasValidSSN").prop("checked"),
        IsInUSMorethanHalfYear: $("#chkLivedInUSMoreThanHalfYear").prop("checked"),
        HasClaimedAsQualifyingChild: $("#chkClaimedAsQualifiedChild").prop("checked"),
        HasReceivedIRSNoticeOnEICNotEligible: $("#chkNoticeFromIRSToClaimEIC").prop("checked"),
        HasReceivedIRSNoticeOnFiling8862: $("#chkNoticeFromIRSToFileForm8862").prop("checked"),
        HasEICForPriorYearDisallowance: hasEICForPriorYearDisallowance,
        HasIncorrectlyReportedEarnedIncome: hasIncorrectlyReportedEarnedIncome,
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
        return null;
    else {
        return value;
    }
}