/* 27Mya2014 Sathish Get Tax wrap up  */
/* 28Mya2014 Sathish Implemented hot stop if tax able income is more that $100000  */
/* 06June2014 Bala Removed CheckList call and get the primary filer name from session to display*/

var name;
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    name = window.sessionStorage.getItem("PrimaryName");
    //11Aug2014,Code Commented by Thileep as per Spec changes in Taxeswrpup(V1.5)
    //13Aug2014,Code Remove Commented code by Thileep as per Spec changes in Taxeswrpup(V1.6)
    $('#lblFirstName').html(name);

    $.ajax({
        url: serviceUrl + 'taxesandwrapup/getfederaltaxsummary',
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
            $("#dvDiagnostics").empty();
            if (data != null) {
                if (data.m_Item3 != null) {
                    PageNavigate(data.m_Item3);
                }
            }
        }
    });

    //16Jun2014 Sathish navigated to download work sheet
    $('#btnContinue').click(function () {
        window.location.href = "../sample/worksheet.html";
        return false;
    });
});
function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        //21Aug2014-Thileep Commented setTimeout function to avoid page redirection delay
        //setTimeout(function () {
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            window.location.href = '../Review/finalsummary.html?Topic=TaxesAndWrapUp';
        //});
        return false;
    }
    else {
        return true;
    }
}
