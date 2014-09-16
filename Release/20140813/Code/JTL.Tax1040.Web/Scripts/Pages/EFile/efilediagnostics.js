
$(document).ready(function () {

    $('#btnContinue').click(function () {
        navigatetoAcknowledgementpage();
        return false;
    });


    $('#btnBack').click(function () {
        if (document != null) {
            GoToPreviousPage();
        }
        return false;
    });


    $.ajax({
        url: serviceUrl + 'efile/getEfileerrormessage',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#dvDiagnostics").empty();
            var efileErrorCount = 0;

            $.each(data, function (index, value) {
                efileErrorCount += 1;
                var efileinfolist =

                      ' <li id="lblefileerrorcode' + efileErrorCount + '" >' + value.ErrorText + '</li>';
                $("#uldiagnostic").append(efileinfolist);
              
            });
        }

    });
});


function navigatetoAcknowledgementpage() {
    if (confirm("Continuing with error will lead to Efile Rejection.  \n Do you want to Proceed ?")) {
        window.location.href = '../EFile/efileacknowledge.html'; return false;
    }
}



