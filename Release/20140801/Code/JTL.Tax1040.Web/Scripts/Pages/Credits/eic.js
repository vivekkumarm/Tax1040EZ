//Created by Saravanan N - 21st April, 2014
/* Modification History
* 23Apr2014 Sathish  Added method for EIC persist
* 11Jun2014 Vincent Refactor the code changes.
*/

//Saravanan N - 23rd April, 2014 - The below line will provide intellisense for Constants.
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var isEicEligible;
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
    //Thileep Commented 25July2014 as per Credit spec (V1.4)
    //NumbersOnly('txtTaxableScholarship');
    //NumbersOnly('txtPensionAnnuity');
    NumbersOnly('txtInmateWages');
    NumbersOnlyNotAcceptingDot('txtNoOfDaysTaxPayerLivedInUS');
    NumbersOnlyNotAcceptingDot('txtNoOfDaysSpouseLivedInUS');




    $('.spanCurrentTaxyear').html(CURRENT_TAX_YEAR);
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    //Thileep Commented 25July2014 as per Credit spec (V1.4)
    //$('#radTaxableScholarshipYes').click(function () {
    //    $('#divTaxableScholarship').show();
    //});    
    //$('#radTaxableScholarshipNo').click(function () {
    //    $('#divTaxableScholarship').hide();
    //});    
    //$('#radPensionAnnuityYes').click(function () {
    //    $('#divPensionAnnuity').show();
    //});   
    //$('#radPensionAnnuityNo').click(function () {
    //    $('#divPensionAnnuity').hide();
    //});

    $('#radInmateWagesYes').click(function () {
        $('#divInmateWages').show();
    });

    $('#radInmateWagesNo').click(function () {
        $('#divInmateWages').hide();
    });

    $('#radEICforPriorYearDisallowanceYes').click(function () {
        $('#divEICforPriorYearDisallowance').show();
        $('#radIncorrectlyReportedEarnedIncomeYes').prop('checked', false);
        $('#radIncorrectlyReportedEarnedIncomeNo').prop('checked', false);


    });

    $('#radEICforPriorYearDisallowanceNo').click(function () {
        $('#divEICforPriorYearDisallowance').hide();
    });

    //Modified by prasana on 09/06/2014 for showing "next" button when chkNoticeFromIRSToFileForm8862 is clicked
    //7thJuly2014 Sathish modified checkbox change event to avoid showing EIC for disallowance
    $('#chkNoticeFromIRSToFileForm8862').change(function () {
        if ($('#chkNoticeFromIRSToFileForm8862').prop('checked')) {
            $('#divEicForDisallowance').show();
            $('#divNextButton').show();
            //Changed by Thileep on 10July2014 - selecting radio button by default if 'chkNoticeFromIRSToFileForm8862' checked
            //Commented by Thileep-25July2014 as per  Credit spec(Version V1.4)
            $("#radEICforPriorYearDisallowanceNo").attr('checked', false);
            $("#radEICforPriorYearDisallowanceYes").attr('checked', false);
            $('#divEICforPriorYearDisallowance').hide();
        }
        else {
            $('#divEicForDisallowance').hide();
            $('#divNextButton').hide();

        }
    });

    $('#btnContinue').click(function () {
        if (PersistEIC()) {

            //11Jun2014-Vincent-modified EIC eligible check navigation
            if (!isEicEligible) {

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
        //Thileep Commented 25July2014 as per Credit spec (V1.4)
        //$("#popTaxableScholarship").popover({ title: 'Quick Help', content: "<h5>What is Taxable Scholarship or Fellowship Income?</h5>This is the total amount of scholarship or fellowship earned during the tax year. <br />Fellowship is paid for research purposes and scholarship is paid for learning.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        //$("#popPensionAnnuity").popover({ title: '', content: "<h5>What is Non Qualified Deferred Compensation?</h5>Non Qualified Deferred Compensation might be elective or nonelective, agreement, method, or arrangement between the employer and an employee. <br />This is a type of compensation that is paid to the employee sometime in the future. <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popInmateWages").popover({ title: '', content: "<h5>Did Income from penal Institution consider as Earned Income in EIC Worksheet?</h5>Income you earned for work performed while as an inmate in a penal institution are not considered as Earned Income in EIC Worksheet.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNoOfDaysTaxPayerLivedInUs").popover({ title: '', content: "<h5>How long did you live in the US for the tax year?</h5>This is nothing but the total number of days you lived in the US during the tax year. <br />We need this to claim your prior year disallowance credit (Earned Income Credit). <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNoOfDaysSpouseLivedInUs").popover({ title: '', content: "<h5>How long did your Spouse live in the US for the tax year?</h5>This is nothing but the total number of days your  Spouse lived in the USA during the tax year. <br />We need this to claim your prior year disallowance credit (Earned Income Credit).<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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
            isEicEligible = data.m_Item3;

            //Hi Text removed by thileep as per spec on 10July2014
            spanTPNameInP1 = taxPayerName + ', you have qualified for Earned income Credit.';
            spanTPNameInP2 = taxPayerName + ', you are not qualified for Earned Income Credit for any of the following reasons';

            $('#spanTaxPayerInP1').text(spanTPNameInP1);
            $('#spanTaxPayerInP2').text(spanTPNameInP2);

            if (!isEicEligible) {
                $('#divCheckbox').hide();
                $('#divAdditionalInformation').hide();
                //Thileep Commented 25July2014 for unwanted div
                //$('#dvPensionAnnuity').hide();

                //30July2014-Thileep Added to Get EligiblityInformation Messages in Credit Section
                if (data.m_Item4.length > 0) {
                    $.each(data.m_Item4, function (key, value) {
                        // $('#olEIInformation').append(('<li' + value.ErrorText + '</li>'));
                        $('#olEIInformation').append((value.ErrorText));
                        $('#olEIInformation').append('</br>');
                    });
            }
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

                    if (data.m_Item1.HasIncorrectlyReportedEarnedIncome != null && !data.m_Item1.HasIncorrectlyReportedEarnedIncome) {
                        $("#radIncorrectlyReportedEarnedIncomeNo").attr('checked', 'checked');
                    }

                    if (data.m_Item1.HasEICForPriorYearDisallowance != null && !data.m_Item1.HasEICForPriorYearDisallowance) {

                        $("#radEICforPriorYearDisallowanceNo").attr('checked', 'checked');
                    }


                    //check <r6> control checked status
                    //This BO-HasTaxableScholarshipCredits not needed as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
                    //if (data.m_Item1.HasTaxableScholarshipCredits) {                        
                    //    //$("#radTaxableScholarshipYes").attr('checked', 'checked');
                    //    //$('#divTaxableScholarship').show();
                    //}

                    //check <r8> control checked status
                    //This BO-HasPensionAnnuity not needed as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
                    //if (data.m_Item1.HasPensionAnnuity) {                        
                    //    //$("#radPensionAnnuityYes").attr('checked', 'checked');
                    //    //$('#divPensionAnnuity').show();
                    //}

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

                    //Control not needed as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
                    //$("#txtTaxableScholarship").val((data.m_Item1.TaxableScholarshipCredit == null) ? '' : data.m_Item1.TaxableScholarshipCredit);

                    //implemented as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
                    if (data.m_Item1.TaxableScholarshipCredit != null) {
                        $('#divTaxableScholarship').show();
                        $("#lblTaxableScholarship").html((data.m_Item1.TaxableScholarshipCredit == null) ? '' : data.m_Item1.TaxableScholarshipCredit);
                    }

                    //This was not needed as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
                    //$("#txtPensionAnnuity").val((data.m_Item1.PensionAnnuity == null) ? '' : data.m_Item1.PensionAnnuity);

                    //implemented as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
                    if (data.m_Item1.PensionAnnuity != null) {
                        $('#divPensionAnnuity').show();
                        $("#lblPensionAnnuity").html((data.m_Item1.PensionAnnuity == null) ? '' : data.m_Item1.PensionAnnuity);

                    }
                    $("#txtInmateWages").val((data.m_Item1.PenalInstitutionInmateWages == null) ? '' : data.m_Item1.PenalInstitutionInmateWages);
                    $("#txtNoOfDaysTaxPayerLivedInUS").val((data.m_Item1.NumberOfDaysTaxPayerLivedInUS == null) ? '' : data.m_Item1.NumberOfDaysTaxPayerLivedInUS);
                    $("#txtNoOfDaysSpouseLivedInUS").val((data.m_Item1.NumberOfDaysSpouseLivedInUS == null) ? '' : data.m_Item1.NumberOfDaysSpouseLivedInUS);
                }
            }
            
            window.sessionStorage.setItem("UserDataId", data.m_Item5);
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
        //07Jul2014 Sathish assigned null instead of zero since we need to pass null #TAX1040-14125	
        numberOfDaysTaxpayerLivedInUS = null;
        numberOfDaysSpouseLivedInUS = null;
        //Changed by Thileep on 10July2014 - Setting to false by default if 'chkNoticeFromIRSToFileForm8862' not checked
        //Changed by Thileep on 25July2014 for No selection of Yes or No radio buttons of EICForPriorYearDisallowance 
        hasEICForPriorYearDisallowance = null;
        hasIncorrectlyReportedEarnedIncome = null;
    }


    //If <r6> radio button not selected set its value to 0.
    //Not needed as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
    //taxableScholarshipAmount = ($("#radTaxableScholarshipYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtTaxableScholarship").val()) : null);

    //Added By Thileep 25July2014 as per Credit Spec (VersionV1.4) 
    taxableScholarshipAmount = (GetZeroOnIsNullOrEmpty($("#lblTaxableScholarship").html()));


    //If <r8> radio button not selected set its value to 0.
    //Not needed as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
    //pensionAnnuityAmount = ($("#radPensionAnnuityYes").prop("checked") ? GetZeroOnIsNullOrEmpty($("#txtPensionAnnuity").val()) : null);


    //Added By Thileep 25July2014 as per Credit Spec (VersionV1.4) 
    pensionAnnuityAmount = (GetZeroOnIsNullOrEmpty($("#lblPensionAnnuity").html()));

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
        //Not needed BO as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
        //HasTaxableScholarshipCredits: $("#radTaxableScholarshipYes").prop("checked"),
        TaxableScholarshipCredit: taxableScholarshipAmount,
        //Not needed BO as per Credit Spec(Spec Version V1.4).So this was commented by Thileep25July2014
        //HasPensionAnnuity: $("#radPensionAnnuityYes").prop("checked"),
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
                 Year: CURRENT_TAX_YEAR//Added by thileep on !0july 2014
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