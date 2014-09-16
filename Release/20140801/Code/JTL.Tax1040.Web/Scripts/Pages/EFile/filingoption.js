// 14May2014 Sathish used to bind and IRS Filling information
//25Jul2014 Sathish changed UI according to new BO
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/

var filing;
var isFederalEfile;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    $('#aefileReview').hide();
    $('#aefileedit').hide();
    $('#aefilestart').hide();
    $('#aFinalReview').hide();

      $("#federalreturnsummary").validate({
        rules: {
            eFileType:
                {
                    required: function () { $('#divradError').html(''); true; }
                },
            txtEmailAddress:
                {
                    required: function () {
                        var isRequired = false;
                        if ($('#radFederalEFiling').prop('checked'))
                            isRequired = true;

                        $.each($('#divFilerState').children('div'), function (key, value) {
                            if ($("#radStateEFiling" + key).prop('checked'))
                                isRequired = true;
                        });

                        return isRequired;
                    },
                    email: true
                }
        },
        messages: {
            eFileType:
               {
                   required: function () { $('#divradError').html('Select your prior year return Information'); true; }
               },
            txtEmailAddress:
              {
                  required: 'Enter Your Email Address'
              }
        }
    });
    $.ajax({
        url: serviceUrl + 'efile/getefilingoption',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            filing = data.Filing;
            if (data != null && data.Filing != null) {
                if (data.Filing.HaveFiledPriorYearReturnElectronically)
                    $('#radFiledPriorTaxYearInEfile').prop('checked', data.Filing.HaveFiledPriorYearReturnElectronically);
                else
                    $('#radFirstTimefiler').prop('checked', true);

                $('#txtEmailAddress').val(data.Filing.Email);
                if (data.Filing.FederalFiling != null) {
                    isFederalEfile = data.Filing.FederalFiling.IsEfile;
                    if (data.Filing.FederalFiling.IsEfile != null) {
                        if (data.Filing.FederalFiling.IsEfile) {
                            $('#radFederalEFiling').prop('checked', data.Filing.FederalFiling.IsEfile);
                        }
                        else
                            $('#radFederalPaperFiling').prop('checked', true);
                    }
                    $('#lblStatus').html((data.Filing.FederalFiling.ReturnStatus != 0) ? data.Filing.FederalFiling.ReturnStatusDescription : '');
                }
            }
            if (data != null && data.StateFiling != null) {
                $.each(data.StateFiling, function (index, value) {
                    var stateReturnStatus = ((value.ReturnStatusDescription != 0 && value.ReturnStatusDescription != 'None') ? value.ReturnStatusDescription : '');
                    $("#divFilerState").append('<div class="pangird itm">' +
                                                    '<label class="col-md-3">' + value.StateName + '</label>' +
                                                    '<label class="col-md-7">' +
                                                    '<input type="hidden" id="hStateId' + index + '" value="' + value.StateId + '"/>' +
                                                                '<input type="hidden" id="hStateName' + index + '" value="' + value.StateName + '"/> ' +
                                                        '<span class="radio-inline">' +
                                                         '   <label>' +
                                                         '  <span id="spEfile">' +
                                                          '      <input type="radio" name="radStateFilingOption' + index + '" id="radStateEFiling' + index + '" />E-file '+
                                                          ' </label></span>' +
                                                        '<span class="radio-inline">' +
                                                         '   <label>' +
                                                          '      <input type="radio" name="radStateFilingOption' + index + '" id="radStatePaperFiling' + index + '" />Paper File ' +
                                                          '</label></span></label>' +
                                                    '<label class="col-md-2" id="lblStatus' + index + '">' + stateReturnStatus + '</label></div>');

                    if (value.IsEfile != null) {
                        if (value.IsEfile)
                            $('#radStateEFiling' + index).prop('checked', value.IsEfile);
                        else
                            $('#radStatePaperFiling' + index).prop('checked', true);
                    }
                });
            }
        }
    });


    //4-july-14 vivek for the persist after continue
    $('#btnEfileInformationContinue').click(function () {
        if ($("#federalreturnsummary").valid() == true) {
            PersistFiling();
            window.location.href = '../EFile/filingoptionsummary.html';
            return false;
        } else {
            return false;
        }
    });


    HasEligibilityDiagnosticsData(); // 01Aug2014 Sathish get eligiblity data

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

//4-july-14 vivek for the persist after continue
function PersistFiling() {

    var stateFiling = [];
    var selectedStateFile;
    $.each($('#divFilerState').children('div'), function (key, value) {
        selectedStateFile = {
            IsEfile: ($("#radStateEFiling" + key).prop('checked') ? true : ($("#radStatePaperFiling" + key).prop('checked') ? false : null)),
            State: {
                StateId: $('#hStateId' + key).val(),
                StateName: $("#hStateName" + key).val()
            },
            ReturnStatus: (($("#radStateEFiling" + key).prop('checked')) ? 4 : 6),
            //TODO:Sathish need to update bank detail 
            BankDetails: ((filing != null && filing.StateFiling != null && filing.StateFiling[key] != null) ? filing.StateFiling[key].BankDetails : null),
            PaymentOption: ((filing != null && filing.StateFiling != null && filing.StateFiling[key] != null) ? filing.StateFiling[key].PaymentOption : 0),
            IsIRSPaymentOptionAgreed: ((filing != null && filing.StateFiling != null && filing.StateFiling[key] != null) ?
                                                                                                    filing.StateFiling[key].IsIRSPaymentOptionAgreed : false),
            StateTransmission: ((filing != null && filing.StateFiling != null && filing.StateFiling[key] != null) ?
                                                                                                    filing.StateFiling[key].StateTransmission : null),
        };
        stateFiling.push(selectedStateFile);
    });

    filing = {
        HaveFiledPriorYearReturnElectronically: $('#radFiledPriorTaxYearInEfile').prop('checked'),
        Email: $('#txtEmailAddress').val(),
        FederalFiling: {
            IsEfile: ($("#radFederalEFiling").prop('checked') ? true : ($("#radFederalPaperFiling").prop('checked') ? false : null)),
            ReturnStatus: ($("#radFederalEFiling").prop('checked') ? 4 : 6),
            IRS: ((filing != null && filing.FederalFiling != null && filing.FederalFiling.IRS != null) ? filing.FederalFiling.IRS : null)
        },
        StateFiling: stateFiling
    };

    $.ajax({
        url: serviceUrl + 'efile/persistfiling',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
            {
                UserDataId: userDataId,
                TaxData: JSON.stringify(filing),
            }
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
            if (data != null) {
                window.sessionStorage.setItem("UserId", data.m_Item1);
                if (data.m_Item2 != null && data.m_Item2.length > 0) {
                    $.each(data.m_Item2, function (index, value) {
                        $("#divEfileInformationError").show();
                        $("#divEfileInformationError").append(value.ErrorText + '<br />');
                    });
                }

            }
        }
    });

}

function HasEligibilityDiagnosticsData() {


    $.ajax({
        url: serviceUrl + 'taxreturn/geteligibilitydiagnosticserrorlist',
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
            if (data != null && data.m_Item1 != null)
                $.each(data.m_Item1, function (index, value) {
                    if (((value.MessageType == MessageType.ER) ||
                        (value.MessageType == MessageType.BR) ||
                        (value.MessageType == MessageType.V) ||
                        (value.MessageType == MessageType.RF)) &&
                        (value.ErrorType == ErrorType.Error)) {
                        // 01Aug2014 Sathish check has error
                        $('#aFinalReview').show();
                        $('#spEfile').hide();
                        $('#radFederalEFiling').prop('checked', false);
                        $('#radFederalEFiling').prop('disabled', true);
                        $('#lblStatus').html('');
                        if (isFederalEfile != null && isFederalEfile) {
                            //  $('#radFederalPaperFiling').prop('disabled', true);
                            DeleteIRSFilingInformation();
                        }
                        
                    }
                });
        }
    });
}

function DeleteIRSFilingInformation() {
    $.ajax({
        url: serviceUrl + 'efile/deleteefileinformation',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
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
        }
    });
}