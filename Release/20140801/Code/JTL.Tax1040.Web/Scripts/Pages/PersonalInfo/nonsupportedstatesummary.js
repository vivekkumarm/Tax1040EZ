//Added by prasana for displaying  on page logic <o6> on 23.06.2014
$(document).ready(function () {

    $('#btnCancelFilling').click(function () {
        window.sessionStorage.setItem('disable', 'true');
        window.location.href = '../PersonalInfo/nonsupportedstatefinal.html';
        return false;
    });
    $('#divresident').hide();
    $('#divpartyear').hide();
    $('#divNonresident').hide();

    var stateOfResidence = window.sessionStorage.getItem("StateOfResidence");
    var earnedIncomeStateNotLived = window.sessionStorage.getItem("EarnedIncomeStateNotLived");
    var morethanOneState = window.sessionStorage.getItem("MorethanOneState");

    if (stateOfResidence != '---Select---' && stateOfResidence !=null ) {
        $('#divresident').show();
        $('#lblresident').html(window.sessionStorage.getItem("StateOfResidence"));

    }
    if (earnedIncomeStateNotLived != '---Select---' && earnedIncomeStateNotLived !=null) {
        $('#divNonresident').show();
        $('#lblNonresident').html(window.sessionStorage.getItem("EarnedIncomeStateNotLived "));
    }
    if (morethanOneState != '---Select---' && morethanOneState !=null) {
        $('#divpartyear').show();
        $('#lblpartyear').html(window.sessionStorage.getItem("MorethanOneState"));

    }

    
    $('#btnAddessContinue').click(function () {
        window.location.href = '../PersonalInfo/personalsummary.html';
        return false;
    });
});