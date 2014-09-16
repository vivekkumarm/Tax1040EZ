var personalInfoEligibilityErrorCount = 0;
var incomeEligibilityErrorCount = 0;
var deductionEligibilityErrorCount = 0;
var creditsEligibilityErrorCount = 0;
var taxesAndWrapUpEligibilityErrorCount = 0;
var stateEligibilityErrorCount = 0;
var personalinformationErrorCount = 0;
var personalinformationErrorCount = 0;
var primaryFilerErrorCount = 0;
var spouseErrorCount = 0;
var addressErrorCount = 0;


//breadcrum Controls.
//Modified by prasana Changed Spelling as Deduction to Deductions on 19.06.2014
document.write("<div class='row crumb'>" +
    "<div class='btn-group btn-breadcrumb'>" +
    "<a id='aHome' href='../PreLogin/WelcomePage.html' class='btn btn-default'><i class='glyphicon glyphicon-home'></i></a>" +
    "<a id='aPersonalInfo' href='../PersonalInfo/primaryfilerinfo.html' class='btn btn-default'>Personal Info<sup id='supPersonalInfoErrorTypeIcon' style='display:none;' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aIncome' href='../Income/incomegateway.html' class='btn btn-default'>Income<sup id='supIncomeErrorTypeIcon' style='display:none;' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aDeduction' href='../Deduction/deductiongateway.html' class='btn btn-default'>Deductions<sup id='supDeductionErrorTypeIcon' style='display:none;' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aCredits' href='../Credits/earnedincomecredits.html' class='btn btn-default'>Credit<sup id='supCreditsErrorTypeIcon' style='display:none;' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aTaxesAndWrapUp' href='../TaxesAndWrapUp/taxesandwrapupchecklist.html' class='btn btn-default'>Taxes & Wrap Up<sup id='supTaxesWrapUpErrorTypeIcon' style='display:none;' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
     "<a id='aState' href='../State/stategateway.html' class='btn btn-default'>State<sup id='supStateErrorTypeIcon' style='display:none;'  data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aReview' href='../Review/finalsummary.html' class='btn btn-default'>Review<sup id='supReviewErrorTypeIcon' style='display:none;'  data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aEfile' href='../Efile/filingoption.html' class='btn btn-default'>File<sup id='supEfileErrorTypeIcon' style='display:none;' data-toggle='tooltip'  data-placement='top' title=''></sup></a>" +
    "</div>" +
    "<a data-toggle='collapse' class='navbar-toggle pull-right' data-target='#leftmenu' href='#'><i class='glyphicon glyphicon-chevron-down'></i></a>" +
    "</div>");

//Saravanan N - 8th May, 2014 - Highlight the selected page's header in bredCrum.
//Thileep  - 17th June, 2014 - Changed the taxes and wrapup  header text in bredCrum.

//$(document).ready(function () {
//    $('a').click(
//        function (e) {
//            $(this).addClass("active").not(this).removeClass("active");
//        });
//});

$(document).ready(function () {
    if (window.sessionStorage.getItem("disable")) {
        $('#aIncome').attr('disabled', true);
        $('#aDeduction').attr('disabled', true);
        $('#aCredits').attr('disabled', true);
        $('#aTaxesAndWrapUp').attr('disabled', true);
        $('#aState').attr('disabled', true);
        $('#aReview').attr('disabled', true);
        $('#aEfile').attr('disabled', true);
        window.sessionStorage.removeItem("disable")
    }
    var containingFolder = window.location.pathname.split('/')[1];
    var topic;
    var hasEligibilityDiagnostics;
    var personalInfoDiagnosticsCount;
    
    //01 Aug 2014 Praveen T added to display bready crumb error icon
    var personalInfoErrorCount = 0;
    var personalInfoWarningCount = 0;
    var personalInfoInfoCount = 0;
    var incomeErrorCount = 0;
    var incomeWarningCount = 0;
    var incomeInfoCount = 0;
    var deductionErrorCount = 0;
    var deductionWarningCount = 0;
    var deductionInfoCount = 0;
    var creditsErrorCount = 0;
    var creditsWarningCount = 0;
    var creditsInfoCount = 0;
    var taxesAndWrapUpErrorCount = 0;
    var taxesAndWrapUpWarningCount = 0;
    var taxesAndWrapUpInfoCount = 0;
    var reviewErrorCount = 0;
    var reviewWarningCount = 0;
    var reviewInfoCount = 0;
    var stateErrorCount = 0;
    var stateWarningCount = 0;
    var stateInfoCount = 0;
  
    var stateDiagnosticsCount = 0;   


    //27May2014 - Added by Ashok for Bread Crum disable and also to show error count
    //Modified by prasana Changed Spelling as Deduction to Deductions on 19.06.2014
    //21July2014 - Modified by Thileep to display all Error messages count in breadcrum Except "Warning","Information" ErrorTypes
    $.ajax({
        url: serviceUrl + 'taxreturn/geteligibilitydiagnosticserrorlist',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId,
            "Topic": topic,
            "Tab": containingFolder
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null && data.m_Item1 != null) {
                $.each(data.m_Item1, function(index, value) {
                    // 20Jun2014 Sathish replaced hard coded value with the constant
                    if (value.Tab == Tab.PersonalInfo) {

                        if (value.ErrorType == ErrorType.Error) {
                            personalInfoErrorCount = personalInfoErrorCount + 1;
                        }
                         else if (value.ErrorType == ErrorType.Warning) {
                            personalInfoWarningCount = personalInfoWarningCount + 1;
                        }
                         else if (value.ErrorType == ErrorType.Information) {
                            personalInfoInfoCount = personalInfoInfoCount + 1;
                        }
                        
                    }

                    if (value.Tab == Tab.Income) {
                        if (value.ErrorType == ErrorType.Error) {
                            incomeErrorCount = incomeErrorCount + 1;
                        }
                        else if (value.ErrorType = ErrorType.Warning) {
                            incomeWarningCount = incomeWarningCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Information) {
                            incomeInfoCount = incomeInfoCount + 1;
                        }
                    }
                    
                    if (value.Tab == Tab.Deduction) {
                        if (value.ErrorType == ErrorType.Error) {
                            deductionErrorCount = deductionErrorCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Warning) {
                            deductionWarningCount = deductionWarningCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Information) {
                            deductionInfoCount = deductionInfoCount + 1;
                        }
                    }
                    
                    //11/6/14-Vincent- Modified the credit section by checking count for required field.
                    //21July2014-Thileep-Modified_Credit section by checking count for ErrorType of "Error"
                    if (value.Tab == Tab.Credits) {
                        if (value.ErrorType == ErrorType.Error) {
                            creditsErrorCount = creditsErrorCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Warning) {
                            creditsWarningCount = creditsWarningCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Information) {
                            creditsInfoCount = creditsInfoCount + 1;
                        }
                    }
                    
                    if (value.Tab == Tab.TaxesAndWrapUp) {
                        if (value.ErrorType == ErrorType.Error) {
                            taxesAndWrapUpErrorCount = taxesAndWrapUpErrorCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Warning) {
                            taxesAndWrapUpWarningCount = taxesAndWrapUpWarningCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Information) {
                            taxesAndWrapUpInfoCount = taxesAndWrapUpInfoCount + 1;
                        }
                    }
                    
                    if (value.Tab == Tab.Review) {
                        
                        if (value.ErrorType == ErrorType.Error) {
                            reviewErrorCount = reviewErrorCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Warning) {
                            reviewWarningCount = reviewWarningCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Information) {
                            reviewInfoCount = reviewInfoCount + 1;
                        }
                    }
                    
                    if (value.Tab == Tab.State) {
                        
                        if (value.ErrorType == ErrorType.Error) {
                            stateErrorCount = stateErrorCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Warning) {
                            stateWarningCount = stateWarningCount + 1;
                        }
                        else if (value.ErrorType == ErrorType.Information) {
                            stateInfoCount = stateInfoCount + 1;
                        }
                    }
                });

                //01 Aug 2014 Praveen T added to display bready crumb error icon
                if (personalInfoErrorCount > 0) {
                    $("#supPersonalInfoErrorTypeIcon").css("display", "inline");
                    $("#supPersonalInfoErrorTypeIcon").addClass('error');
                } else if (personalInfoWarningCount > 0) {
                    $("#supPersonalInfoErrorTypeIcon").css("display", "inline");
                    $("#supPersonalInfoErrorTypeIcon").addClass('alert');
                }
                else if (personalInfoInfoCount > 0) {
                    $("#supPersonalInfoErrorTypeIcon").css("display", "inline");
                    $("#supPersonalInfoErrorTypeIcon").addClass('info');
                }


                if (incomeErrorCount > 0) {
                    $("#supIncomeErrorTypeIcon").css("display", "inline");
                    $("#supIncomeErrorTypeIcon").addClass('error');
                } else if (incomeWarningCount > 0) {
                    $("#supIncomeErrorTypeIcon").css("display", "inline");
                    $("#supIncomeErrorTypeIcon").addClass('alert');
                }
                else if (incomeInfoCount > 0) {
                    $("#supPersonalInfoErrorCount").css("display", "inline");
                    $("#supPersonalInfoErrorCount").addClass('info');

                }

                if (deductionErrorCount > 0) {
                    $("#supDeductionErrorTypeIcon").css("display", "inline");
                    $("#supDeductionErrorTypeIcon").addClass('error');
                } else if (deductionWarningCount > 0) {
                    $("#supDeductionErrorTypeIcon").css("display", "inline");
                    $("#supDeductionErrorTypeIcon").addClass('alert');
                }
                else if (deductionInfoCount > 0) {
                    $("#supDeductionErrorTypeIcon").css("display", "inline");
                    $("#supDeductionErrorTypeIcon").addClass('info');
                }

                if (creditsErrorCount > 0) {
                    $("#supCreditsErrorTypeIcon").css("display", "inline");
                    $("#supCreditsErrorTypeIcon").addClass('error');
                } else if (creditsWarningCount > 0) {
                    $("#supCreditsErrorTypeIcon").css("display", "inline");
                    $("#supCreditsErrorTypeIcon").addClass('alert');
                }
                else if (creditsInfoCount > 0) {
                    $("#supCreditsErrorTypeIcon").css("display", "inline");
                    $("#supCreditsErrorTypeIcon").addClass('info');
                }
                
                if (taxesAndWrapUpErrorCount > 0) {
                    $("#supTaxesWrapUpErrorTypeIcon").css("display", "inline");
                    $("#supTaxesWrapUpErrorTypeIcon").addClass('error');
                } else if (taxesAndWrapUpWarningCount > 0) {
                    $("#supTaxesWrapUpErrorTypeIcon").css("display", "inline");
                    $("#supTaxesWrapUpErrorTypeIcon").addClass('alert');
                }
                else if (taxesAndWrapUpInfoCount > 0) {
                    $("#supTaxesWrapUpErrorTypeIcon").css("display", "inline");
                    $("#supTaxesWrapUpErrorTypeIcon").addClass('info');
                }

                if (reviewErrorCount > 0) {
                    $("#supReviewErrorTypeIcon").css("display", "inline");
                    $("#supReviewErrorTypeIcon").addClass('error');
                } else if (reviewWarningCount > 0) {
                    $("#supReviewErrorTypeIcon").css("display", "inline");
                    $("#supReviewErrorTypeIcon").addClass('alert');
                }
                else if (reviewInfoCount > 0) {
                    $("#supReviewErrorTypeIcon").css("display", "inline");
                    $("#supReviewErrorTypeIcon").addClass('info');
                }
                
                if (stateErrorCount > 0) {
                    $("#supStateErrorTypeIcon").css("display", "inline");
                    $("#supStateErrorTypeIcon").addClass('error');
                } else if (stateWarningCount > 0) {
                    $("#supStateErrorTypeIcon").css("display", "inline");
                    $("#supStateErrorTypeIcon").addClass('alert');
                }
                else if (stateInfoCount > 0) {
                    $("#supStateErrorTypeIcon").css("display", "inline");
                    $("#supStateErrorTypeIcon").addClass('info');
                }
            }

            var isFilingEnable = true;

            if (data != null && data.m_Item3 != null) {
                for (var key in data.m_Item3) {
                    switch (key) {
                        // 20Jun2014 Sathish replaced hard coded value with the constant
                        case Tab.PersonalInfo:
                            personalInfoEligibilityErrorCount = data.m_Item3[key];
                            break;
                        case Tab.Income:
                            incomeEligibilityErrorCount = data.m_Item3[key];
                            break;
                        case Tab.Deduction:
                            deductionEligibilityErrorCount = data.m_Item3[key];
                            break;
                        case Tab.Credits:
                            creditsEligibilityErrorCount = data.m_Item3[key];
                            break;
                        case Tab.TaxesAndWrapUp:
                            taxesAndWrapUpEligibilityErrorCount = data.m_Item3[key];
                            break;
                        case Tab.State:
                            stateEligibilityErrorCount = data.m_Item3[key];
                            break;
                    }
                }
                if (personalInfoEligibilityErrorCount > 0) {
                    $('#aIncome').attr('disabled', true).addClass('tip');
                    $('#aDeduction').attr('disabled', true);
                    $('#aCredits').attr('disabled', true);
                    $('#aTaxesAndWrapUp').attr('disabled', true);
                    $('#aReview').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    $('#aState').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    isFilingEnable = false;
                    $("#supIncomeErrorCount").css("display", "none");
                    $("#supDeductionErrorCount").css("display", "none");
                    $("#supCreditsErrorCount").css("display", "none");
                    $("#supTaxesWrapUpErrorCount").css("display", "none");
                    $("#supStateErrorCount").css("display", "none");
                    if ((containingFolder == Tab.Deduction && $('#aDeduction').prop("disabled"))
                        || (containingFolder == Tab.Income && $('#aIncome').prop("disabled"))
                        || (containingFolder == Tab.Credits && $('#aCredits').prop("disabled"))
                         || (containingFolder == Tab.TaxesAndWrapUp && $('#aTaxesAndWrapUp').prop("disabled"))
                         || (containingFolder == Tab.State && $('#aState').prop("disabled"))
                        ) {
                        history.go(-1);
                    }
                }
                else if (incomeEligibilityErrorCount > 0) {
                    $('#aDeduction').attr('disabled', true);
                    $('#aCredits').attr('disabled', true);
                    $('#aTaxesAndWrapUp').attr('disabled', true);
                    $('#aReview').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    $('#aState').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    isFilingEnable = false;
                    $("#supDeductionErrorCount").css("display", "none");
                    $("#supCreditsErrorCount").css("display", "none");
                    $("#supTaxesWrapUpErrorCount").css("display", "none");
                    $("#supStateErrorCount").css("display", "none");
                    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
                    $('#aIncome').attr("href", '../Review/finalsummary.html?Tab=' + Tab.Income);
                }
                else if (deductionEligibilityErrorCount > 0) {
                    $('#aCredits').attr('disabled', true);
                    $('#aTaxesAndWrapUp').attr('disabled', true);
                    $('#aReview').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    $('#aState').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    isFilingEnable = false;
                    $("#supCreditsErrorCount").css("display", "none");
                    $("#supTaxesWrapUpErrorCount").css("display", "none");
                    $("#supStateErrorCount").css("display", "none");
                    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
                    $('#aDeduction').attr("href", '../Review/finalsummary.html?Tab=' + Tab.Deduction);
                }
                else if (creditsEligibilityErrorCount > 0) {
                    $('#aTaxesAndWrapUp').attr('disabled', true);
                    $('#aReview').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    $('#aState').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    isFilingEnable = false;
                    $("#supTaxesWrapUpErrorCount").css("display", "none");
                    $("#supStateErrorCount").css("display", "none");
                    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
                    $('#aCredits').attr("href", '../Review/finalsummary.html?Tab=' + Tab.Credits);
                }
                else if (taxesAndWrapUpEligibilityErrorCount > 0) {
                    $('#aReview').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    $('#aState').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    isFilingEnable = false;
                    $("#supStateErrorCount").css("display", "none");
                    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
                    $('#aTaxesAndWrapUp').attr("href", '../Review/finalsummary.html?Tab=' + Tab.TaxesAndWrapUp);
                }
                else if (stateEligibilityErrorCount > 0) {
                    $('#aReview').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    $('#aEfile').attr('disabled', true);
                    isFilingEnable = false;
                    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
                    $('#aState').attr("href", '../Review/finalsummary.html?Tab=' + Tab.State);
                }
            }
            // 18Jul2014 Sathish enable or disable efile based on user order exist
            if (data != null && data.m_Item4 != null && isFilingEnable) {
                isOrderExist = data.m_Item4;
                $('#aEfile').attr('disabled', !data.m_Item4);
            }

            if (data.m_Item5.m_Item5 > 0) {
                primaryFilerErrorCount = data.m_Item5.m_Item5;
            }
            if (data.m_Item5.m_Item6 > 0) {
                spouseErrorCount = data.m_Item5.m_Item6;
            }
            if (data.m_Item5.m_Item7 > 0) {
                addressErrorCount = data.m_Item5.m_Item7;
            }
          


        }
    });

    switch (containingFolder) {
        // 18Jun2014 Sathish replaced hard coded value with the constant in case
        case Tab.PersonalInfo:
            $('#aPersonalInfo').addClass('active');
            break;

        case Tab.Income:
            $('#aIncome').addClass('active');
            break;

        case Tab.Deduction:
            $('#aDeduction').addClass('active');
            break;

        case Tab.Credits:
            $('#aCredits').addClass('active');
            break;

        case Tab.TaxesAndWrapUp:
            $('#aTaxesAndWrapUp').addClass('active');
            break;

        case Tab.State: //TODO: It will be done in the future. Saravanan N - 8th May, 2014.
            $('#aState').addClass('active');
            break;

        case Tab.Review:
            $('#aReview').addClass('active');
            break;

        case Tab.Efile:
            $('#aEfile').addClass('active');
            break;

        default:
            $('#aHome').addClass('active');
            var pageURL = window.location.search.substring(1);
            var parameterName = pageURL.split('=');
            if (parameterName.toString().indexOf('Tab') == 0) {
                containingFolder = parameterName[1];
            }
            break;

    }


});