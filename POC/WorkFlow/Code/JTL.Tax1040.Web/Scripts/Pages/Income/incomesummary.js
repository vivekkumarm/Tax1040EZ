//28 Apr 2014 - Vincent-Added a income summary Section.
//30 Apr 2014 - Vincent-Changes to the income summary Section.

$(document).ready(function () {

    GetIncomeSummary();
});


function GetIncomeSummary() {

    $.ajax({
        url: serviceUrl + 'taxreturn/getincomesummary',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            //Wages
            $('#lblWagesAmount').html(data.m_Item1);

            //Interest Income
            $('#lblInterestIncome').html(data.m_Item2);

            //Unemployment Compensation
            $('#lblF1099G').html(data.m_Item3);

            //Other Income
            $('#lblOtherIncome').html(data.m_Item4);

            return false;


        }
    });
}






