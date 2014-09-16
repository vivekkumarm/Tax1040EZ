document.write("<div class='menu' role='navigation'>" +
    "<ul class='nav  side-nav'>" +
    "<li id='aReviewLM'><a href='../Review/finalsummary.html'><i class='fa fa-clipboard'></i>Review</a></li>" +
    //"<li id='aFinalSummary'><a href='../Review/returnsummary.html'><i class='fa fa-th-list'></i>Final Summary</a></li>" +
    "</ul>" +
    "</div>");

$(document).ready(
    function () {
        var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();

        switch (selectedSection) {
            case 'finalsummary':
                $('#aReviewLM').addClass('active');
                $('#aFinalSummary').attr('style', 'display:none');
                break;

            case 'returnsummary':
                $('#aFinalSummary').addClass('active');
                break;

            default:
                $('#aFinalSummary').attr('style', 'display:inline');
                break;
        }
    })