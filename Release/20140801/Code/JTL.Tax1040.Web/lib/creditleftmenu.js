document.write("<div class='menu' role='navigation'>" +
                            "<ul class='nav  side-nav'>" +
                                "<li id='aEarnedIncomeCredit'><a href='earnedincomecredits.html'><i class='fa fa-exchange'></i>Earned Income Credit</a></li>" +
                                "<li id='aCreditSummary'><a href='creditsummary.html'><i class='fa fa-th-list'></i>Credit Summary</a></li>" +
                            "</ul>" +
                        "</div>")



$(document).ready(
    function () {
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