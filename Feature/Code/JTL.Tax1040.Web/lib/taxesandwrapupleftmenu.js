document.write("<div id='taxesandwrapupleftmenu' class='menu btn-breadcrumb' role='navigation'>" +
    "<div id='lftmenu'>" +
    "<ul class='nav  side-nav'>" +
    "<li id='aTaxesAndWrapupChecklist'><a href='../TaxesAndWrapUp/taxesandwrapupinfo.html'><i class='fa fa-file-code-o'></i>Federal Taxes<sup id='suptaxAndWrapupErrorCount' class='badge tip' data-toggle='tooltip' data-placement='top'></sup></a></li>" +
    "<li id='aFederalWrapupSummary'><a href='../TaxesAndWrapUp/federaltaxsummary.html'><i class='fa fa-th-list'></i>Federal Summary</a></li>" +
    "</ul>" +
    "</div>" +
    "</div>");

var tab = Tab.TaxandWrapup;
var topic;
$(document).ready(function () {

    var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();


    if (taxAndWrapupErrorCount > 0) {
        $('#suptaxAndWrapupErrorCount').html(taxAndWrapupErrorCount);
    }


    switch (selectedSection) {
        case 'taxesandwrapupinfo':
            $('#aTaxesAndWrapupChecklist').addClass('active');
            break;

        case 'federaltaxsummary':
            $('#aFederalWrapupSummary').addClass('active');
            break;
    }
});








