//11 Augest 2014-Vincent-Implemented the caincomesummary
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var caAddition = 0;
var caSubraction = 0;
var totalFederalAGIAmount = 0;
var totalCaliforinaAGIAmount = 0;

/**************************************** PAGE LOAD ACTION ****************************************/

$(document).ready(function () {

    GetFederalDetails();
    DefaultBinding();
    GetDeductionDetails();
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

function GetFederalDetails() {
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
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item5 != null) {
                    window.sessionStorage.setItem("UserDataId", data.m_Item5);
                }

                if (data.m_Item1 != null) {
                  //Adjusted Gross Income
                    totalFederalAGIAmount = $('#lblAGIAmount').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.AdjustedGrossIncome))));
                }

            }
        }
    });
}

function DefaultBinding()
{
    //Pre-Logic #5
    //TODO: have to sum the value and have get the value form taxobject.
    if (caAddition > 0) {
        $('#lblCaAddition').html(caAddition);
    } else {

        $('#lblCaAddition').html(0);
    }

    if (caSubraction > 0) {
        $('#lblCaSubtraction').html(caSubraction);
    }
    else {
        $('#lblCaSubtraction').html(0);
    }

    totalCaliforinaAGIAmount = totalFederalAGIAmount + caAddition - caSubraction;

    $('#lblCaAGIAmount').html(totalCaliforinaAGIAmount);

}

function GetDeductionDetails()
{
    $.ajax({
        //TODO: Have to finialized the controller and Repository for CA
        url: serviceUrl + '',
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
                //Pre-Logic #6: Step 1;
                if (data.m_Item3 !=null)
                {
                    //Deduction page display only if we have checked the other adjustment option as 'Yes'
                    if (data.m_Item3.HasOtherAdjustments = true)
                    {
                        if (data.m_Item1 != null) {

                            if (data.m_Item1.FilingStatus == "Single" && !data.m_Item1.Person.HasClaimedAsDependent) {
                                var singleDeduction = 3906 + 106;
                                $('#lblTotalDeduction').html(SingleDeduction);
                            }
                            else if (data.m_Item1.FilingStatus == "MarriedFilingJointly" &&
                                (!data.m_Item1.Person.HasClaimedAsDependent && !data.m_Item1.Spouse.Person.HasClaimedAsDependent)) {
                                var mjfDeduction = 7812 + 212;
                                $('#lblTotalDeduction').html(mjfDeduction);
                            }
                            else if (data.m_Item1.FilingStatus == "Single" && data.m_Item1.Person.HasClaimedAsDependent &&
                                (data.m_Item2 != null && data.m_Item2.HasEligibilityTofile540)) {
                                //TODO: Based on the worksheet in form 540 we must set the value.
                                var singleEligibility540Deduction = 0;
                                $('#lblTotalDeduction').html(singleEligibility540Deduction);
                            }
                            else if (data.m_Item1.FilingStatus == "Single" && data.m_Item1.Person.HasClaimedAsDependent &&
                                (data.m_Item2 != null && data.m_Item2.HasEligibilityTofile540EZ)) {
                                //TODO: Based on the worksheet in form 540 EZ we must set the value.
                                var singleEligibility540EZDeduction = 3906;
                                $('#lblTotalDeduction').html(singleEligibility540EZDeduction);
                            }
                            else if (data.m_Item1.FilingStatus == "MarriedFilingJointly" &&
                                (data.m_Item1.Person.HasClaimedAsDependent && data.m_Item1.Spouse.Person.HasClaimedAsDependent) &&
                                data.m_Item2.HasEligibilityTofile540) {
                                //TODO: Based on the worksheet in form 540 we must set the value.
                                var mjfEligibility540Deduction = 0;
                                $('#lblTotalDeduction').html(mjfEligibility540Deduction);

                            }
                            else if (data.m_Item1.FilingStatus == "MarriedFilingJointly" &&
                                (data.m_Item1.Person.HasClaimedAsDependent && data.m_Item1.Spouse.Person.HasClaimedAsDependent) &&
                                data.m_Item2.HasEligibilityTofile540EZ) {
                                var mjfEligibility540EZDeduction = 7812;
                                $('#lblTotalDeduction').html(mjfEligibility540EZDeduction);

                            }
                            else if (data.m_Item1.FilingStatus == "MarriedFilingJointly" &&
                               (data.m_Item1.Person.HasClaimedAsDependent || data.m_Item1.Spouse.Person.HasClaimedAsDependent) &&
                               data.m_Item2.HasEligibilityTofile540EZ) {
                                var mjfEligibility540EZDeduction1 = 7812 + 106;
                                $('#lblTotalDeduction').html(mjfEligibility540EZDeduction1);
                            }
                        }
                    }
                }
            }
        }
    });
}