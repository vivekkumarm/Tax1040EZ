//breadcrum Controls.
document.write("<div class='row crumb'>" +
    "<div class='btn-group btn-breadcrumb'>" +
    "<a id='aHome' href='../PreLogin/WelcomePage.html' class='btn btn-default'><i class='glyphicon glyphicon-home'></i></a>" +
    "<a id='aPersonalInfo' href='../PersonalInfo/primaryfilerinfo.html' class='btn btn-default'>Personal Info<sup id='supPersonalInfoErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aIncome' href='../Income/incomegateway.html' class='btn btn-default'>Income<sup id='supIncomeErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aDeduction' href='../Deduction/deductiongateway.html' class='btn btn-default'>Deduction<sup id='supDeductionErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aCredits' href='../Credits/earnedincomecredits.html' class='btn btn-default'>Credit<sup id='supCreditsErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aTaxesAndWrapUp' href='../TaxesAndWrapUp/taxesandwrapupchecklist.html' class='btn btn-default'>Tax & Wrap Up<sup id='supTaxesWrapUpErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aReview' href='#' class='btn btn-default'>Review<sup id='supReviewErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "<a id='aState' href='../State/stategateway.html' class='btn btn-default'>State<sup id='supStateErrorCount' style='display:none;' class='badge tip' data-toggle='tooltip'  data-placement='top' title='' ></sup></a>" +
    "</div>" +
    "<a data-toggle='collapse' class='navbar-toggle pull-right' data-target='#leftmenu' href='#'><i class='glyphicon glyphicon-chevron-down'></i></a>" +
    "</div>");

//Saravanan N - 8th May, 2014 - Highlight the selected page's header in bredCrum.

//$(document).ready(function () {
//    $('a').click(
//        function (e) {
//            $(this).addClass("active").not(this).removeClass("active");
//        });
//});

$(document).ready(function () {
    var containingFolder = window.location.pathname.split('/')[1];
    var topic;
    var hasEligibilityDiagnostics;
    var personalInfoDiagnosticsCount = 0;
    var incomeDiagnosticsCount = 0;
    var deductionDiagnosticsCount = 0;
    var creditDiagnosticsCount = 0;
    var taxesAndWrapupDiagnosticsCount = 0;
    var reviewDiagnosticsCount = 0;
    var stateDiagnosticsCount = 0;


    switch(containingFolder)
    {
        case 'PersonalInfo':
            $('#aPersonalInfo').addClass('active');
            break;

        case 'Income':
            $('#aIncome').addClass('active');
            break;

        case 'Deduction':
            $('#aDeduction').addClass('active');
            break;

        case 'Credits':
            $('#aCredits').addClass('active');
            break;

        case 'TaxesAndWrapUp':
            $('#aTaxesAndWrapUp').addClass('active');
            break;

        case 'State': //TODO: It will be done in the future. Saravanan N - 8th May, 2014.
            $('#aState').addClass('active');
            break;

        default:
            $('#aHome').addClass('active');
            var pageURL = window.location.search.substring(1);
            var parameterName = pageURL.split('=');
            if (parameterName.toString().indexOf('Tab') == 0)
                containingFolder = parameterName[1];
            break;

    }
    //27May2014 - Added by Ashok for Bread Crum disable and also to show error count
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

            if (data != null && data.m_Item2 != null && data.m_Item2.length>0) {
                switch (containingFolder) {
                    case 'PersonalInfo':
                        $('#aIncome').attr('disabled', true);
                        $('#aDeduction').attr('disabled', true);
                        $('#aCredits').attr('disabled', true);
                        $('#aTaxesAndWrapUp').attr('disabled', true);
                        $('#aReview').attr('disabled', true);
                        $('#aState').attr('disabled', true);
                        break;

                    case 'Income':
                        $('#aDeduction').attr('disabled', true);
                        $('#aCredits').attr('disabled', true);
                        $('#aTaxesAndWrapUp').attr('disabled', true);
                        $('#aReview').attr('disabled', true);
                        $('#aState').attr('disabled', true);
                        break;

                    case 'Deduction':
                        $('#aCredits').attr('disabled', true);
                        $('#aTaxesAndWrapUp').attr('disabled', true);
                        $('#aReview').attr('disabled', true);
                        $('#aState').attr('disabled', true);
                        break;

                    case 'Credits':
                        $('#aTaxesAndWrapUp').attr('disabled', true);
                        $('#aReview').attr('disabled', true);
                        $('#aState').attr('disabled', true);
                        break;

                    case 'TaxesAndWrapUp':
                        $('#aReview').attr('disabled', true);
                        $('#aState').attr('disabled', true);
                        break;

                    case 'State':
                        $('#aReview').attr('disabled', true);
                        break;

                    default:
                        $('#aHome').addClass('active');
                        break;
                }            
            }
            if (data != null && data.m_Item1 != null) {
                $.each(data.m_Item1, function (index, value) {
                    if (value.Tab == 'PersonalInfo') {
                        personalInfoDiagnosticsCount = personalInfoDiagnosticsCount + 1;
                    }
                    if (value.Tab == 'Income') {
                        incomeDiagnosticsCount = incomeDiagnosticsCount + 1;
                    }
                    if (value.Tab == 'Deduction') {
                        deductionDiagnosticsCount = deductionDiagnosticsCount + 1;
                    }
                    if (value.Tab == 'Credits') {
                        creditDiagnosticsCount = creditDiagnosticsCount + 1;
                    }
                    if (value.Tab == 'TaxesAndWrapUp') {
                        taxesAndWrapupDiagnosticsCount = taxesAndWrapupDiagnosticsCount + 1;
                    }
                    if (value.Tab == 'Review') {
                        reviewDiagnosticsCount = reviewDiagnosticsCount + 1;
                    }
                    if (value.Tab == 'State') {
                        stateDiagnosticsCount = stateDiagnosticsCount + 1;
                    }
                });
                if (personalInfoDiagnosticsCount > 0)
                {
                    $("#supPersonalInfoErrorCount").css("display", "inline");
                    $('#supPersonalInfoErrorCount').html(personalInfoDiagnosticsCount);
                    $('#supPersonalInfoErrorCount').attr('title', 'You have ' + personalInfoDiagnosticsCount + ' Errors');
                }

                if (incomeDiagnosticsCount > 0)
                {
                    $("#supIncomeErrorCount").css("display", "inline");
                    $('#supIncomeErrorCount').html(incomeDiagnosticsCount);
                    $('#supIncomeErrorCount').attr('title', 'You have ' + incomeDiagnosticsCount + ' Errors');
                }

                if (deductionDiagnosticsCount > 0) {
                    $("#supDeductionErrorCount").css("display", "inline");
                    $('#supDeductionErrorCount').html(deductionDiagnosticsCount);
                    $('#supDeductionErrorCount').attr('title', 'You have ' + deductionDiagnosticsCount + ' Errors');
                }

                if (creditDiagnosticsCount > 0) {
                    $("#supCreditsErrorCount").css("display", "inline");
                    $('#supCreditsErrorCount').html(creditDiagnosticsCount);
                    $('#supCreditsErrorCount').attr('title', 'You have ' + creditDiagnosticsCount + ' Errors');
                }

                if (taxesAndWrapupDiagnosticsCount > 0) {
                    $("#supTaxesWrapUpErrorCount").css("display", "inline");
                    $('#supTaxesWrapUpErrorCount').html(taxesAndWrapupDiagnosticsCount);
                    $('#supTaxesWrapUpErrorCount').attr('title', 'You have ' + taxesAndWrapupDiagnosticsCount + ' Errors');
                }

                if (reviewDiagnosticsCount > 0) {
                    $("#supReviewErrorCount").css("display", "inline");
                    $('#supReviewErrorCount').html(reviewDiagnosticsCount);
                    $('#supReviewErrorCount').attr('title', 'You have ' + reviewDiagnosticsCount + ' Errors');
                }

                if (stateDiagnosticsCount > 0) {
                    $("#supStateErrorCount").css("display", "inline");
                    $('#supStateErrorCount').html(stateDiagnosticsCount);
                    $('#supStateErrorCount').attr('title', 'You have ' + stateDiagnosticsCount + ' Errors');
                }
            }

        }
    });

});