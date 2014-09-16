/* 27Mya2014 Sathish Get Tax wrap up  */
/* 28Mya2014 Sathish Implemented hot stop if tax able income is more that $100000  */


$(document).ready(function () {
    
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    $.ajax({
        url: serviceUrl + 'taxesandwrapup/taxableincomeeligibilitycheck',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            userDataId: userDataId,

        }
        ),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item2 != null) {
                    PageNavigate(data.m_Item2)
                }
                if (data.m_Item1 != null && data.m_Item2 == false) {
                    $('#lblFirstName').html(data.m_Item1);
                }
            }
        }
    });
}
);

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        setTimeout(function () {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=TaxesAndWrapUp';
        });
        return false;
    }
    else {
        return true;
    }
}