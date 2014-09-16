document.write("<div class='menu btn-breadcrumb' id='creditleftmenu' role='navigation'>" +
    "<div id='lftmenu'>" +
    "<ul class='nav  side-nav'>" +
    "<li id='aEarnedIncomeCredit'><a href='earnedincomecredits.html'><i class='fa fa-exchange'></i>EIC<sup id='supCreditErrorCount' class='badge tip' data-toggle='tooltip' data-placement='top'></sup></a></li>" +
    "<li id='aCreditSummary'><a href='creditsummary.html'><i class='fa fa-th-list'></i>Credit Summary</a></li>" +
    "</ul>" +
    "</div>" +
    "</div>");



$(document).ready(function () {

    if (creditsErrorCountleftmenu > 0) {
        $('#supCreditErrorCount').html(creditsErrorCountleftmenu);
    }
        var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();

       
        switch (selectedSection) {
            case 'earnedincomecredits':
                $('#aEarnedIncomeCredit').addClass('active');
                break;

            case 'creditsummary':
                $('#aCreditSummary').addClass('active');
                break;
        }
    })