//Vincent-11July2014-Added the Federalreturn transmitted method

$(document).ready(function () {

    $.ajax({
        url: serviceUrl + 'efile/getfilingoptionsummary',
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
            $('#divlistTransmitted').hide();
            
            if (data.FederalFiling != null) {
                var federal = 'Federal';
                
                if (data.FederalFiling != null) {


                    if (data.FederalFiling.ReturnStatusDescription == "Transmitted")
                    {
                        var federalReturnStatus = "Transmitted";

                        if (data.FederalFiling.IsEfile) {
                           
                            $('#divlistTransmitted').show();

                            $("#divReturnTransmission").append('<div class="pangird itm"><label class="col-md-6 col-xs-6">' + federal + '</label>' +
                       '<label class="col-md-6 col-xs-6">' + federalReturnStatus +
                       '</label></div>');

                        }
                    }

                    

                }
                if (data.StateFiling != null) {

                    $.each(data.StateFiling, function (index, value) {

                        if (value.ReturnStatusDescription == "Transmitted")
                        {

                            var stateReturnStatus = "Transmitted";

                            if (value.IsEfile == true) {
                                $('#divlistTransmitted').show();

                                $("#divReturnTransmission").append('<div class="pangird itm"><label class="col-md-6 col-xs-6">' + value.State.StateName + '</label>' +
                      '<label class="col-md-6 col-xs-6">' + stateReturnStatus +
                      '</label></div>');
                            }
                        }

                       

                    });

                }

            }

        }
    });

});