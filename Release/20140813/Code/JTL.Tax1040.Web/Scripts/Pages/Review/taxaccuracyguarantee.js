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

    //Saravanan N - 13th Aug, 2014 - Defect 14156 as well as File Spec > Review <p9> logic implemented.
    $('#dvStateValidations').hide();
    GetTaxableState();
});

//Saravanan N - 13th Aug, 2014 - This method used to get the States selected by the user to file return.
function GetTaxableState() {
    $.ajax({
        url: serviceUrl + 'stategateway/getaddress',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            userDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data.Taxablestate != null && data.Taxablestate.length > 0) {
                $('#dvStateValidations').show();
            }
        }
    });
}