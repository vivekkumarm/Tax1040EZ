document.write("<div class='menu' role='navigation'>" +
                            "<ul class='nav  side-nav'>" +
                                "<li id='aTaxesAndWrapupChecklist'><a href='../TaxesAndWrapUp/taxesandwrapupinfo.html'><i class='fa fa-file-code-o'></i>Federal Taxes</a></li>" +
                                "<li id='aFederalWrapupSummary'><a href='../TaxesAndWrapUp/federaltaxsummary.html'><i class='fa fa-th-list'></i>Federal Summary</a></li>" +
                            "</ul>" +
                        "</div>")


$(document).ready(
    function () {
        var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();

        switch (selectedSection) {
            case 'taxesandwrapupinfo':
                $('#aTaxesAndWrapupChecklist').addClass('active');
                break;

            case 'federaltaxsummary':
                $('#aFederalWrapupSummary').addClass('active');
                break;
        }
    })