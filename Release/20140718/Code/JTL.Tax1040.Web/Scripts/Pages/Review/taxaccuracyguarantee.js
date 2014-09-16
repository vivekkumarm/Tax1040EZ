/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    
    $('.Title').html(TITLE);

    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    userDataId = JSON.parse(window.sessionStorage.getItem("UserDataId"));
    var pageURL = window.location.search.substring(1);

    $('#btnContinue').click(function () {

        window.location.href = '../Review/returnsummary.html';
        return false;

    });

});