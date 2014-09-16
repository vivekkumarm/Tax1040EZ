//Script for W2GetData Summary
//Vincent - 16th April 2014- added a error message navigation for required user control.
//Vincent - 13th April 2014-Added pre-pages logic for wages amount
//Ashok Kumar 29 May 2014- Made changes on handling navigation based on Income Gateway selection
//Vincent-2 Jun May2014-Made a changes in Page Navigation and Reload method if it is delete.

var isInterestIncomeHasValue, isUnemploymentHasValue, isOtherIncomeHasValue;
var form1099INTCount, form1099OIDCount, form1099GCount, otherIncomeCount;
var hasIncomeEligibilityDiagnostics = false;// 17Jun2014 Sathish used to check eligibility check in continue click

$(document).ready(function () {
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    GetW2SummaryData();
    GetIncomeGatewayDataForW2Summary(); //Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.

    $('#btnContinue').click(function () {
        var pageToNavigate;
        //17Jun2014 Sathish will be redirected to diagnotics if income has eligibility error
        if (hasIncomeEligibilityDiagnostics) {
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            pageToNavigate = '../Review/finalsummary.html?Topic=' + Topic.Wages;   // 20Jun2014 Sathish replaced hard coded value with the constant
        }
        else {
            if (isInterestIncomeHasValue) {
                if (form1099INTCount > 0 || form1099OIDCount > 0) {
                    pageToNavigate = 'interestincomesummary.html';
                }
                else {
                    pageToNavigate = 'interestincomechecklist.html';
                }
            }
            else if (isUnemploymentHasValue) {
                if (form1099GCount > 0) {
                    pageToNavigate = 'unemploymentsummary.html';
                }
                else {
                    pageToNavigate = 'Unemployment.html';
                }
            }
            else if (isOtherIncomeHasValue) {
                if (otherIncomeCount > 0) {
                    pageToNavigate = 'otherincomesummary.html';
                }
                else {
                    pageToNavigate = 'otherincomegateway.html';
                }
            }
            else
                pageToNavigate = '../Income/incomesummary.html';
        }
        //On Continue button click navigate to the page.
        window.location.href = pageToNavigate;
        return false;

    });

    //if (isInterestIncomeHasValue) {
    //    $('#btnContinue').click(function () { window.location.href = '../Income/interestincome.html'; });
    //}
    //else if (isUnemploymentHasValue) {
    //    $('#btnContinue').click(function () { window.location.href = '../Income/unemployment.html'; });
    //}
    //else if (isOtherIncomeHasValue) {
    //    $('#btnContinue').click(function () { window.location.href = '../Income/otherincome.html'; });
    //}
    //else {
    //    $('#btnContinue').click(function () { window.location.href = '../Income/incomesummary.html'; });
    //}

    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
        return false;
    });

    return false;
});

function GetW2SummaryData() {
    $("#w2summaryinfo").empty();
    $.ajax({
        url: serviceUrl + 'w2/getw2listanderrorlist',
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
            alert(jqXHR + "-" + textStatus + "-" + errorThrown);
            $("#divDiagnosticsParent").hide();//Saravanan N - 14th May, 2014 - Default hide the diagnostics.
        },
        success: function (data, textStatus) {

            var w2EmployerOrganizationName;
            var w2TaxPayerName;
            var taxPayerName;
            var spouseName;
            var totalWages = 0;
            var employmentType = 0;
            if (data.m_Item3 != null) {
                taxPayerName = data.m_Item3.PrimaryTaxPayerName;
                spouseName = data.m_Item3.SpouseName;
                totalWages = data.m_Item3.TotalWages;
            }
            //Pre-Page getting the total Wages amount (P6)
            //Yogalakshmi - 16th June 2014 - To round off the total wages and not to allow negative value.
            var finalWages = 0;
            if (totalWages != "undefined") {
                if (totalWages >= 0) {
                    finalWages = totalWages;
                }
            }
            var value = Math.round(finalWages);
            //vivek 18-June-14 Added the Currency formate
            $('#lblTotalWagesAmount').html('$ ' + currencyformate(value));

            var hasRecords = true;
            if (data.m_Item1 != null) {
                $.each(data.m_Item1, function (index, value) {
                    //Vincent-16July2014-Checked the EmploymentType as 8 not to display in summary grid. 
                    if (value.EmploymentType != 8) {
                        hasRecords = false;
                        w2EmployerOrganizationName = '';
                        w2TaxPayerName = '';
                        if (value.W2Id != 0) {

                            if (value.OwnerType == 2) {
                                w2TaxPayerName = spouseName;
                            }
                            else {
                                w2TaxPayerName = taxPayerName;
                            }

                            var employerName = "Not Specified"; //Saravanan N - 12th May, 2014 - Added to display NotSpecified as per spec changes.
                            if (value.Employer != null) {
                                if (value.Employer.Organization != null && value.Employer.Organization.Name != null) {
                                    if (value.Employer.Organization.Name.trim().length > 0) {
                                        employerName = value.Employer.Organization.Name;
                                    }

                                }
                            }

                            //Pre-Page logic for Wages amount.
                            var wagesAmount = 0;


                            if (value.EmploymentType > 0 && value.EmploymentType < 6) {
                                wagesAmount = value.WagesAmount != null ? value.WagesAmount : 0;
                            } else {
                                if (value.Employer != null) {

                                    if (value.EmploymentType == 6) {

                                        wagesAmount = value.Employer.HouseholdEmployeeWages != null ? value.Employer.HouseholdEmployeeWages : 0;
                                    }
                                    else if (value.EmploymentType == 7) {

                                        wagesAmount = value.Employer.TaxableScholarshipAmount != null ? value.Employer.TaxableScholarshipAmount : 0;

                                    }
                                }
                            }

                            //Yogalakshmi - 16th June 2014 - Check for negative value.

                            var totalWagesAmount = 0;
                            if (wagesAmount != "undefined") {
                                if (wagesAmount >= 0) {
                                    totalWagesAmount = wagesAmount;
                                }
                            }

                            //Yogalakshmi - 16th June 2014 - To allow only two digits after decimal.
                            //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                            $("#w2summaryinfo").append('<div class="pangird itm"><label class="col-md-4">'
                                + employerName + '</label>' +
                                               '<input type="hidden" id="hdnW2Id' + value.W2Id + '" value="' + value.W2Id + '"></input>' +
                                               '<label class="col-md-3">' + w2TaxPayerName + '</label>' +
                                               '<label class="col-md-3">' + currencyformate(totalWagesAmount.toFixed(2)) + '</label>' +
                                                    '<label class="col-md-2">' +
                                                         '<a href="../Income/w2employmentandownertype.html?W2Id=' + value.W2Id
                                                         + '" title="Edit" class="fa fa-edit"></a>' +
                                                         '<a href="#" title="Delete" onclick="DeleteW2('
                                                         + value.W2Id + ');return false;"  class="fa fa-minus-square-o"></a>' +
                                               '</label></div>');
                        }
                    }

                });
            }

            if (hasRecords) {
                $("#w2summaryinfo").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                       '</span>');
            } 

            $("#dvDiagnostics").empty();
            $("#divDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.

            if (data.m_Item2 != null) {
                // * 17Jun2014 Sathish Changed code for eligible navigation
                var errorKnt = 0;
                if (data.m_Item2.length > 0) {
                    //Modified by prasana added null check for value and changed to Switch case on 15.07.2014
                    $.each(data.m_Item2, function (index, value) {
                        if (value != null) {
                            //17Jun2014 Sathish will be redirected to diagnotics if income has eligibility error
                            // 20Jun2014 Sathish replaced hard coded value with the constant
                            if ((value.Topic == Topic.Wages) && (value.MessageType == MessageType.ER)) {
                                hasIncomeEligibilityDiagnostics = true;
                            }
                            else {
                                //Error Message navigation url
                                errorKnt += 1;
                                var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId;

                                var errorType = value.ErrorType.trim();
                                var className = '';

                                switch (errorType) {
                                    case ErrorType.Error:
                                        className = "dierror";
                                        break;

                                    case ErrorType.Warning:
                                        className = "diwarn";
                                        break;

                                    case ErrorType.Information:
                                        className = "diinfo";
                                        break;
                                }

                                //Assign class dynamically based on ErrorType.
                                $("#dvDiagnostics").append('<a  class=' + className + ' href="' + navigateURL + '">' + value.ErrorText + '.</a>');
                            }
                        }
                    });
                    if (errorKnt > 0) {
                        $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                        $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                        $("#divDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.
                    }
                }
            }

            return false;
        }
    });
}

function DeleteW2(w2ID) {
    if (confirm("Are you sure, you want to delete the selected Form W2?")) {
        $.ajax({
            url: serviceUrl + 'w2/deletew2byid',
            async: false,
            dataType: "json",
            data: JSON.stringify({
                "UserId": userId,
                "UserDataId": userDataId,
                "FormId": w2ID
            }),
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                location.reload(true);
            }
        });
    }
}

//Saravanan N - 29th April, 2014 - As per IncomeGateway selected options Continue button's navigation will be decided here.
function GetIncomeGatewayDataForW2Summary() {
    $.ajax({
        url: serviceUrl + 'incomegateway/getincomegatewaydata',
        async: false,
        dataType: 'json',
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId
        }),
        type: 'POST',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: 'application/json',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                //Store the values into local variables.

                isInterestIncomeHasValue = data.HasInterestIncome;
                isUnemploymentHasValue = data.HasUnemploymentCompensation;
                isOtherIncomeHasValue = data.HasOtherIncome;
                //showInterestIncomeChkListPage = data.ShowInterestIncomeChkListPage;
                form1099INTCount = data.Form1099INTCount;
                form1099OIDCount = data.Form1099OIDCount;
                form1099GCount = data.Form1099GCount;
                otherIncomeCount = data.OtherIncomeCount;

            }
        }
    });
}
