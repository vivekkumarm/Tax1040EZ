//28 Apr 2014 - Vincent-Added a income summary Section.
//30 Apr 2014 - Vincent-Changes to the income summary Section.
//var hasIncomeEligibilityDiagnostics = false;
$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);
    GetIncomeSummary();

    //$('#btnContinue').click(function () {

    //    //17Jun2014 Sathish will be redirected to diagnotics if income has eligibility error
    //    if (hasIncomeEligibilityDiagnostics) {
    //        //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
    //        window.location.href = '../Review/finalsummary.html?Topic=' + Tab.Income;   // 20Jun2014 Sathish replaced hard coded value with the constant
    //    }
    //    //On Continue button click navigate to the page.
    //    window.location.href = "../Deduction/deductiongateway.html";
    //    return false;

    //});
});


function GetIncomeSummary() {

    $.ajax({
        url: serviceUrl + 'taxreturn/getincomesummary',
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

            //Wages
            //Yogalakshmi - 16th June 2014 - To round off the Wages Amount and not to allow negative value.
            var finalWages = 0;
            var finalInterestIncome = 0;
            var finalUnemployment = 0;
            var finalOtherIncome = 0;
            var nickName = '';

            if (data != null) {
                if (data.m_Item5 != "") {
                    nickName = data.m_Item5;
                }

                if (data.m_Item1 != "undefined") {
                    if (data.m_Item1 > 0) {
                        finalWages = data.m_Item1;
                    }
                }

                //Interest Income
                //Yogalakshmi - 16th June 2014 - To round off the Interest Income Amount and not to allow negative value.

                if (data.m_Item2 != "undefined") {
                    if (data.m_Item2 > 0) {
                        finalInterestIncome = data.m_Item2;
                    }
                }

                //Unemployment Compensation
                //Yogalakshmi - 16th June 2014 - To round off the Unemployment Amount and not to allow negative value.

                if (data.m_Item3 != "undefined") {
                    if (data.m_Item3 > 0) {
                        finalUnemployment = data.m_Item3;
                    }
                }

                //Other Income
                //Yogalakshmi - 16th June 2014 - To round off the Other Income Amount and not to allow negative value.

                if (data.m_Item4 != "undefined") {
                    if (data.m_Item4 > 0) {
                        finalOtherIncome = data.m_Item4;
                    }
                }
                // 18Jun2014 Sathish hides the income base on the selected income
                if (data.m_Item6 != null) {
                    if (data.m_Item6.m_Item1 != null) {
                        if (data.m_Item6.m_Item1 == false) {
                            $('#divWages').hide();
                        }
                    }
                    if (data.m_Item6.m_Item2 != null) {
                        if (data.m_Item6.m_Item2 == false) {
                            $('#divIntrestIncome').hide();
                        }
                    }
                    if (data.m_Item6.m_Item3 != null) {
                        if (data.m_Item6.m_Item3 == false) {
                            $('#divUnemploymentCompensaiton').hide();
                        }
                    }
                    if (data.m_Item6.m_Item4 != null) {
                        if (data.m_Item6.m_Item4 == false) {
                            $('#divOtherIncome').hide();
                        }
                    }
                }

                $("#dvDiagnostics").empty();
                $("#divDiagnosticsParent").hide();

                if (data.m_Item7 != null) {
                    // * 17Jun2014 Sathish Changed code for eligible navigation
                    var errorKnt = 0;
                    if (data.m_Item7.length > 0) {
                        //Modified by prasana added null check for value and changed to Switch case on 15.07.2014
                        $.each(data.m_Item7, function (index, value) {
                            if (value != null) {
                                //17Jun2014 Sathish will be redirected to diagnotics if income has eligibility error
                                // 20Jun2014 Sathish replaced hard coded value with the constant


                                if (value.MessageType == MessageType.ER) {
                                    window.location.href = '../Review/finalsummary.html?Topic=' + Tab.Income;
                                }
                                else {
                                    //Error Message navigation url
                                    errorKnt += 1;

                                    //Saravanan N - 31st July, 2014 - FormID param has to be added in the query string, based on the section.
                                    var navigateURL = '';
                                    switch (value.Topic.toUpperCase()) {
                                        case 'FORMINT':
                                        case 'FORMOID':
                                        case 'INTERESTINCOME':
                                            navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId + "&" + value.Topic;;
                                            break;
                                        case 'WAGES':
                                        case 'UNEMPLOYMENTCOMPENSATION':
                                            navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId;
                                            break;
                                        default:
                                            navigateURL = value.MessageTarget + "?" + value.FieldName
                                            break;
                                    }

                                    var errorType = value.ErrorType.trim();
                                    var className = '';

                                    switch (errorType) {
                                        case ErrorType.Error:
                                            className = "dierror tip";
                                            break;

                                        case ErrorType.Warning:
                                            className = "diwarn";
                                            break;

                                        case ErrorType.Information:
                                            className = "diinfo";
                                            break;
                                    }

                                    //Assign class dynamically based on ErrorType.
                                    $("#dvDiagnostics").append('<div class="msgerrors"> <a class="' + className + ' tip"  data-toggle="tooltip" data-placement="top" href="' + navigateURL + '"  title="' + value.LongErrorText + '"> ' + value.ErrorText + '.</a><span>' + value.Topic + '</span></div>');
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
            }

            //Saravanan N - 16th June, 2014 - Code refactored.
            //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
            $('#lblWagesAmount').html(currencyformate(Math.round(finalWages)));
            $('#lblInterestIncome').html(currencyformate(Math.round(finalInterestIncome)));
            $('#lblF1099G').html(currencyformate(Math.round(finalUnemployment)));
            $('#lblOtherIncome').html(currencyformate(Math.round(finalOtherIncome)));
            $('.spanNickName').html(nickName);

            return false;


        }
    });
}






