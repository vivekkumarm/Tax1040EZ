//Modified by prasana for displaying text as Deductions Summary on 18.06.2014
//Modified by prasana Changed Spelling as Deduction to Deductions on 19.06.2014
document.write("<div class='menu' role='navigation'>" +
    "<ul class='nav  side-nav'>" +
    "<li id='aDeductionGateway'><a href='deductiongateway.html'><i class='fa fa-ban'></i>Deductions</a></li>" +
    "<li id='aDeductionSummary'><a href='deductionsummary.html'><i class='fa fa-th-list'></i>Deduction Summary</a></li>" +
    "</ul>" +
    "</div>");


$(document).ready(
    function () {
        var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();

        switch (selectedSection) {
            case 'deductionsummary':
                $('#aDeductionSummary').addClass('active');
                break;

            case 'deductiongateway':
                $('#aDeductionGateway').addClass('active');
                break;
        }
    })