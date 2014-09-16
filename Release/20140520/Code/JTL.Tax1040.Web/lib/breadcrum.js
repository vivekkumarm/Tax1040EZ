//breadcrum Controls.
document.write("<div class='row crumb'>" +
        "<div class='btn-group btn-breadcrumb'>"+
            "<a id='aHome' href='../PreLogin/WelcomePage.html' class='btn btn-default'><i class='glyphicon glyphicon-home'></i></a>" +
            "<a id='aPersonalInfo' href='../PersonalInfo/primaryfilerinfo.html' class='btn btn-default'>Personal Info<sup style='display:none; class='badge tip' data-toggle='tooltip'  data-placement='top' title='You Have 42 Errors' >42</sup></a>" +
            "<a id='aIncome' href='../Income/incomegateway.html' class='btn btn-default'>Income<sup style='display:none; class='badge tip' data-toggle='tooltip'  data-placement='top' title='You Have 42 Errors' >42</sup></a>" +
            "<a id='aDeduction' href='../Deduction/deductiongateway.html' class='btn btn-default'>Deduction<sup style='display:none; class='badge tip' data-toggle='tooltip'  data-placement='top' title='You Have 42 Errors' >42</sup></a>" +
            "<a id='aCredits' href='../Credits/earnedincomecredits.html' class='btn btn-default'>Credit<sup style='display:none; class='badge tip' data-toggle='tooltip'  data-placement='top' title='You Have 42 Errors' >42</sup></a>" +
            "<a id='aTaxesAndWrapUp' href='../TaxesAndWrapUp/taxesandwrapupchecklist.html' class='btn btn-default'>Tax & Wrap Up<sup style='display:none; class='badge tip' data-toggle='tooltip'  data-placement='top' title='You Have 42 Errors' >42</sup></a>" +
            "<a id='aState' href='#' class='btn btn-default'>State</a>"+
        "</div>" +
    "<a data-toggle='collapse' class='navbar-toggle pull-right' data-target='#leftmenu' href='#'><i class='glyphicon glyphicon-chevron-down'></i></a>" +
"</div>")

//Saravanan N - 8th May, 2014 - Highlight the selected page's header in bredCrum.

//$(document).ready(function () {
//    $('a').click(
//        function (e) {
//            $(this).addClass("active").not(this).removeClass("active");
//        });
//});

$(document).ready(function () {
    var containingFolder = window.location.pathname.split('/')[1];

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
            break;

    }
});