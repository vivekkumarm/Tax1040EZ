var efileErrorCount = 0;

$(document).ready(function () {
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

            $.each(data, function (index, value) {
                efileErrorCount += 1;
                var efileinfolist =

                      ' <li id="lblefileerrorcode' + efileErrorCount + '" >' + value.ErrorText + '</li>';
                $("#uldiagnostic").append(efileinfolist);

            });
           
        }

    });
    // 20Aug2014 Sathish checked error count for navigation
    $('#btnContinue').click(function () {
        if (efileErrorCount > 0) {
            window.location.href = '../EFile/efiledisclaimer.html'; 
        }
        else {
            window.location.href = '../EFile/efileacknowledge.html';
        }
        return false;
    });
});
