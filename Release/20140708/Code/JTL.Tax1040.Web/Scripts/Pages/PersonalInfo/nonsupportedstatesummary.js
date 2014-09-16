//Added by prasana for displaying  on page logic <o6> on 23.06.2014
$(document).ready(function () {

    $('#btnCancelFilling').click(function () {
        window.location.href = '../PersonalInfo/nonsupportedstatefinal.html';
        return false;
    });
    $('#divresident').hide();
    $('#divpartyear').hide();
    $('#divNonresident').hide();

    if (window.sessionStorage.getItem("StateOfResidence") != '---Select---') {
        $('#divresident').show();
        $('#lblresident').html(window.sessionStorage.getItem("StateOfResidence"));

    }
    if (window.sessionStorage.getItem("EarnedIncomeStateNotLived") != '---Select---') {
        $('#divpartyear').show();
        $('#lblpartyear').html(window.sessionStorage.getItem("EarnedIncomeStateNotLived"));

    }
    if (window.sessionStorage.getItem("MorethanOneState") != '---Select---') {
        $('#divNonresident').show();
        $('#lblNonresident').html(window.sessionStorage.getItem("MorethanOneState"));
    }

    
    $('#btnAddessContinue').click(function () {
        window.location.href = '../PersonalInfo/personalsummary.html';
        return false;
    });
});