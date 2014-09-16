//Vincent-3 JULY 2014 -Added a get method for Filing option Summary
//Vincent-14 JULY 2014- Worked on Hidden functionialty.
//25Jul2014 Sathish changed UI according to new BO
/**************************************** PAGE LOAD ACTION ****************************************/
var federalReturnStatus;
var efileStateId = null;
var filing;
$(document).ready(function () {

    var pageURL = window.location.search.substring(1);

    $("#btnReplan").click(function () {
        window.location.href = '../EFile/filingoption.html';
        return false;
    });

    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('EfileStateId') == 0) {
        efileStateId = parameterName[1];
    }

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
            if (data != null) {
                filing = data.Filing;
                if (data.Filing != null && data.Filing.FederalFiling != null) {
                    if (data.Filing.FederalFiling != null) {
                        //Federal Binding
                        $("#divFilingOptionBody").append('<div class="pangird itm">' +
                                                                   '<label class="col-md-6">Federal</label>' +
                                                                   '<label class="col-md-6">' + ((data.Filing.FederalFiling.IsEfile == null) ?
                                                                                                            "No option selected" : (data.Filing.FederalFiling.IsEfile ?
                                                                                                                                        "E-File" : "Paper File")) + '</label>' +
                                                                '</div>');
                    }

                    if (data.StateFiling != null) {

                        $.each(data.StateFiling, function (index, value) {
                            var stateReturnStatus = value.ReturnStatusDescription;
                            //State Efiling
                            $("#divFilingOptionBody").append('<div class="pangird itm">' +
                                                                  '<label class="col-md-6">' + value.StateName + '</label>' +
                                                                  '<label class="col-md-6">' + ((value.IsEfile == null) ?
                                                                                                       "No option selected" : (value.IsEfile ?
                                                                                                                                   "E-File" : "Paper File")) + '</label>' +
                                                              '</div>');
                        });
                    }
                }
                //18Aug2014 Sathish binded tax payer name based on spec 1.5
                if (data.TaxPayerFirstNameOrNickName != null) {
                    $("#lblTaxPayerFirstNameOrNickName").html(data.TaxPayerFirstNameOrNickName);
                }
            }
        }
    });

    //On-Page Logic #8
    $("#btnContinue").click(function () {
        //28Jul2014 Sathish Removed condition is efile true if filing is selected will be redirected to payment
        if (filing != null && filing.FederalFiling != null && filing.FederalFiling.IsEfile != null)
            //20Aug2014 Sathsih Redirect to Federal Efile Information in Tax own is zero to avoid flickering issue
            if (GetTaxOwnAmount() > 0)
                window.location.href = '../EFile/federalpaymentdetail.html';
            else
                window.location.href = '../EFile/federalefileinformation.html';
        else {
            window.location.href = '../EFile/federalfilingnotselected.html';
        }
        return false;
    });

});


//20Aug2014 Sathsih Redirect to Federal Efile Information in Tax own is zero to avoid flickering issue
function GetTaxOwnAmount() {

    var taxOwnAmount = 0;
    $.ajax({
        url: serviceUrl + 'efile/getirspaymentoption',
        async: false,
        dataType: 'json',
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: 'POST',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null && data.m_Item1 != null) {
                taxOwnAmount =  data.m_Item1;
            }
        }
    });

    return taxOwnAmount;
}
