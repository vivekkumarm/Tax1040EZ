var stateIds;
//25Jul2014 Sathish changed UI according to new BO
$(document).ready(function () {
    $('#btnDownload').click(function () {
        Genernate1040EZForm();
        return false;
    });
   
       $.ajax({
        url: serviceUrl + 'efile/getefilingoption',
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
            if (data != null && data.Filing != null) {
                if (data.Filing.FederalFiling != null && data.Filing.FederalFiling.IsEfile) {
                   // $('#lblStatus').html((data.Filing.FederalFiling.ReturnStatus != 0) ? data.Filing.FederalFiling.ReturnStatusDescription : '');
                }
            }
            if (data.StateFiling != null) {
                $.each(data.StateFiling, function (index, value) {
                    $("#divFiling").append('<div class="pangird itm"> ' +
                                                    '<label class="col-md-4">' + value.StateName + '</label>' +
                                                    '<label class="col-md-4"><a href="#" title="Downlode" id="btnDownload" class="fa fa-file-pdf-o"></a></label>' +
                                                    '<label class="col-md-4">' +
                                                    '<button type="submit" id="btnTransmission" disabled="disabled" class="btn btn btn-primary btn-xs">Transmit</button></label>' +
                                                  '</div>');
                });
            }

        }
    });

    $('#btnTransmission').click(function () {

        $.ajax({
            url: serviceUrl + 'efile/email',
            async: false,
            dataType: "json",
            data: JSON.stringify({
                UserId: userId,
                UserDataId: userDataId
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                setTimeout(function () {
                    window.location.href = '../Efile/federalreturnstatus.html';
                });
            }
        });
    });
});