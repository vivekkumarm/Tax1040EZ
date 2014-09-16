$(document).ready(function () {
    $('#btnWelcomePage').click(function () {
        window.location.href = '../PersonalInfo/filingstatus.html';
        return false;
    });

    $('#btnEligibility').click(function () {
        window.location.href = '../F1040Eligibility/1040EZEligibilityCheck.html';
        return false;
    });
});