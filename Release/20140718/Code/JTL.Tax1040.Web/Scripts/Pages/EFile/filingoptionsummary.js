//Vincent-3 JULY 2014 -Added a get method for Filing option Summary
//Vincent-14 JULY 2014- Worked on Hidden functionialty.

/**************************************** PAGE LOAD ACTION ****************************************/
var federalReturnStatus;
$(document).ready(function () {

    //On-Page Logic #8
    $("#btnContinue").click(function () {
        window.location.href = '../EFile/federalfilingdetail.html';
        return false;
    });


    $("#btnReplan").click(function () {
        window.location.href = '../EFile/efileinformation.html';
        return false;
    });

    $.ajax({
        url: serviceUrl + 'efile/getfilingoptionsummary',
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
            if (data != null)
                {
            $('#divEfileOPtion').hide();
            $('#divPaperFilingOption').hide();
            if (data.FederalFiling != null) {
                var federal = 'Federal';
                //Pre-Page Logic #4
                if (data.FederalFiling != null) {
                    if (data.FederalFiling.IsEfile == true) {
                        federalReturnStatus = "In-Progress";
                       // var federalReturnStatus = data.FederalFiling.ReturnStatusDescription;
                    }
                    else {
                        federalReturnStatus = "Not Started";
                    }

                    if (data.FederalFiling.IsEfile) {
                        //Federal Efiling
                        $('#divEfileOPtion').show();

                        $("#divEfileOptionFederal").append('<div class="pangird itm"><label class="col-md-6">' + federal + '</label>' +
                   //'<label class="col-md-3">&nbsp;</label>' +
                   //'<label class="col-md-3">&nbsp;</label>' +
                   '<label class="col-md-6">' + federalReturnStatus +
                   '</label></div>');

                    } else {
                        //Federal Paper filing
                        $('#divPaperFilingOption').show();

                        $("#divPaperFileOptionFederal").append('<div class="pangird itm"><label class="col-md-6">' + federal + '</label>' +
                   //'<label class="col-md-3">&nbsp;</label>' +
                   //'<label class="col-md-3">&nbsp;</label>' +
                   '<label class="col-md-6">' + federalReturnStatus +
                   '</label></div>');
                    }


                }

                if (data.StateFiling != null) {

                    $.each(data.StateFiling, function (index, value) {
                        var stateReturnStatus = value.ReturnStatusDescription;
                  //      if (value.IsEfile == true) {
                  //          //State Efiling
                  //          $('#divEfileOPtion').show();

                  //          $("#divEfileOptionState").append('<div class="pangird itm"><label class="col-md-4">' + value.State.StateName + '</label>' +
                  //'<label class="col-md-3">&nbsp;</label>' +
                  //'<label class="col-md-3">&nbsp;</label>' +
                  //'<label class="col-md-2">' + stateReturnStatus +
                  //'</label></div>');
                  //      }
                  //      else {
                  //          $('#divPaperFilingOption').show();
                  //          //State Paper filing
                  //          $("#divPaperFileOptionState").append('<div class="pangird itm"><label class="col-md-4">' + value.State.StateName + '</label>' +
                  //'<label class="col-md-3">&nbsp;</label>' +
                  //'<label class="col-md-3">&nbsp;</label>' +
                  //'<label class="col-md-2">' + stateReturnStatus +
                  //'</label></div>');
                  //      }

                    });

                }
            }
            }

        }
    });

});
