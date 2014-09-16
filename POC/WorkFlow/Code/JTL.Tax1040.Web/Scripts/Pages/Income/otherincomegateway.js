// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncomeGateway.html page.****//
// Global Variable declaration. It can be used in all the below functions.
//Saravanan N - 11th April, 2014 - Obtaining from Session Storage.

//Saravanan N - 11th April, 2014 - Added by Saravanan to get UserID and UserDataId from Session.
// 03may2014 Sathish user Tax return bo for persist

function GetOtherIncome() {

    var otherIncome = {
        HasSsbAndRrb: $('#chkSSB').prop('checked'),
        HasAlaskaPermanantFund: $('#chkAlaska').prop('checked'),
        HasStateTaxRefund: $('#chkState').prop('checked')
    };

    $.ajax({
        url: serviceUrl + 'otherincome/persistotherincome',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
                {
                    UserDataId: userDataId,
                    TaxData: JSON.stringify(otherIncome),
                }

        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data);
            return false;
        }
    });
}