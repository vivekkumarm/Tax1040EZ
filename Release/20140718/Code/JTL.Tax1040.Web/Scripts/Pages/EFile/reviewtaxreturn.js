var stateIds;

$(document).ready(function () {
    $('#btnDownload').click(function () {
        Genernate1040EZForm();
        return false;
    });
   
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
            ErrorHandling(jqXHR, errorThrown);//vivek 2-july-14 added the handaler 
        },
        success: function (data, textStatus) {
            if (data.Taxablestate != null) {
                stateIds = data.ResidenceState.StateId;
                for (var i = 0; i < data.Taxablestate.length; i++) {
                    stateIds = stateIds + ',' + data.Taxablestate[i].StateId
                }
            }
        }
    });

    $.ajax({
        url: serviceUrl + 'efile/getefiledetails',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            "StateIDs": stateIds
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                var federal = 'Federal';
                var status = data.FederalFiling.ReturnStatusDescription;
                if (data.FederalFiling != null) {
                    var federal = 'Federal';

                    if (data.FederalFiling != null) {
                       // if (data.FederalFiling) {
                       //     $("#divSelectReturnFile").append('<div id="divReviewTaxReturn">' + '<div class="">' +

                       //'<label class="col-md-4">' + federal + '</label>' +
                       //'<label class="col-md-4"><a href="#" title="Edit" class="fa fa-file-pdf-o"></a>' + +'</label>' +
                       //'<label class="col-md-4" >' + ' <button type="submit" id="btnTransmission" class="btn btn-primary">Transmission</button>' +
                       //'</label></div></div>');

                       // }
                    }
                }
               

            }
        }
    });
    //<label class="col-md-4">Federal</label>
    //                                                            <label class="col-md-4"><a href="#" title="Downlode" id="btnDownload" class="fa fa-file-pdf-o"></a></label>
    //                                                            <label class="col-md-4"><button type="submit" id="btnTransmission" class="btn btn-primary">Transmission</button></label>
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