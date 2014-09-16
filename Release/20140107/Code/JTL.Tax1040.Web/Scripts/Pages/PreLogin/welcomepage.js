$(document).ready(function () {

    //16Jun2014 sathish redirected to login if user id not found in the session
    if (window.sessionStorage.getItem("UserId") == null) {
        window.location.href = "../login.html";
    }
    else {

        $('#btnWelcomePage').click(function () {
            window.location.href = '../PersonalInfo/filingstatus.html';
            return false;
        });

        $('#btnEligibility').click(function () {
            window.location.href = '../F1040Eligibility/1040EZEligibilityCheck.html';
            return false;
        });
    }
});