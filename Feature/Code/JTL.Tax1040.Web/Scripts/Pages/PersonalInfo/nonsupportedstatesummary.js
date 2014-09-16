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
    

    if (stateOfResidence != '---Select---' && stateOfResidence != null) {
        if(!stateOfResidence)
        {
            $('#divresident').hide();
        }else {
        $('#divresident').show();
        $('#lblresident').html(stateOfResidence);
    }
    }
    if (earnedIncomeStateNotLived != '---Select---' && earnedIncomeStateNotLived != null) {
        if (!earnedIncomeStateNotLived) {
            $('#divNonresident').hide();
        } else {
            $('#divNonresident').show();
            $('#lblNonresident').html(earnedIncomeStateNotLived);
        }
    }
    if (morethanOneState != '---Select---' && morethanOneState != null ) {
        if (!morethanOneState) {
            $('#divpartyear').hide();
        } else {
            $('#divpartyear').show();
            $('#lblpartyear').html(morethanOneState);
        }

    }

    
    $('#btnAddessContinue').click(function () {
        window.location.href = '../PersonalInfo/personalsummary.html';
        return false;
    });

    var taxPayerName = window.sessionStorage.getItem('SignInName');
    var userName = window.sessionStorage.getItem('UserName');

    if (taxPayerName != null && taxPayerName != '' && taxPayerName != userName) {
        $('.spanFillerName').html(taxPayerName + " ");
    }
    else{ 

        $('.spanFillerName').html('Taxpayer ');
    }
});