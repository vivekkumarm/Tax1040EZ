// 14May2014 Sathish used to bind and IRS Filling information

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var stateIds;
var Isstate;
var IsFederal;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    $('#aefileReview').hide();
    $('#aefileedit').hide();
    $('#aefilestart').hide();
    $("#federalreturnsummary").validate({
        rules: {
            eFileType:
                {
                    required: function () { $('#divradError').html(''); true; }
                },
            txtEmailAddress:
                {
                    required: true,
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
        url: serviceUrl + 'efile/getfiling',
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
            if (data != null) {

                $('#txtEmailAddress').val(data.Email);
                if (data.HaveFiledPriorYearReturnElectronically) {
                    $('#radFiledPriorTaxYearInEfile').prop('checked', data.HaveFiledPriorYearReturnElectronically);
                }
                if (data.HaveFiledPriorYearReturnElectronically == false) {
                    $('#radFirstTimefiler').prop('checked', true)
                }
                if (data.FederalFiling.IsEfile == true) {
                    $('#chkfederal').prop('checked', true);
                    $('#lblStatus').html("In-Progress");
                }

                $.each(data.StateFiling, function (index, value) {
                    if (value.IsEfile) {
                        $('#chkstate').prop('checked', true)

                    }


                });


            }
        }
    });


    $.ajax({
        url: serviceUrl + 'efile/getefiledetails',
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
            var federal = 'Federal';
            var status = data.FederalFiling.ReturnStatusDescription;
            if (data.FederalFiling != null) {
                if (data.FederalFiling.ReturnStatusDescription == "None") {
                    $('#lblStatus').html("Not Started");
                    $('#spanbutton').append('<a href="#" id="aefilenStart" class="btn btn-default btn-sm">Not Started</a>')
                }
                else {
                    $('#lblStatus').html(data.FederalFiling.ReturnStatusDescription);
                    $('#spanbutton').append('<a href="#" id="aefilenStart" class="btn btn-default btn-sm">' + data.FederalFiling.ReturnStatusDescription + '</a>')
                }
                //var federal = 'Federal';

                //if (data.FederalFiling != null) {
                //    if (data.FederalFiling) {
                //        if (data.FederalFiling.IsEfile) {
                //            $('#lblStatus').html("In-progress");
                //        }
                //        //     $("#divSelectReturnFile").append('<div id="divSelectedReturn">' + '<div class="pangird itm">' +
                //        //         '<label class="col-md-4"><input type="checkbox" id="chkfederal"/>' + '' + '</label>' +
                //        //'<label class="col-md-3">' + federal + '</label>' +
                //        //'<label class="col-md-3" id="lblStatus">' + data.FederalFiling.ReturnStatusDescription + '</label>' +
                //        //'<label class="col-md-2" >' + '<span id="spanbutton"></span>' +
                //        //'</label></div>');
                //        //     if (data.FederalFiling.ReturnStatusDescription == "None") {
                //        //         $('#lblStatus').html("Not Started");
                //        //         $('#spanbutton').append('<a href="#" id="aefilenStart" class="btn btn-default btn-sm">Not Started</a>');
                //        //     }
                //        // }

                //        // $('#chkfederal').prop('checked', data.FederalFiling.IsEfile);
                //    }
                //if (data.FederalFiling.ReturnStatusDescription == "Transmitted" || data.FederalFiling.ReturnStatusDescription == "Accepted") {
                //    $('#spanbutton').append('<a href="#" id="aefilereview" class="WagesSelected rvw">Review</a>');

                //}
                //else if (data.FederalFiling.ReturnStatusDescription == "Rejected") {
                //    $('#spanbutton').append('<a href="#" id="aefileedit" class="WagesSelected rvw">Edit</a> ');

                //}
                //else if (data.FederalFiling.ReturnStatusDescription == "NotStarted") {
                //    $('#spanbutton').append('<a href="#" id="aefilenStart" class="WagesSelected rvw">Star</a> ');

                //}
                //else if (data.FederalFiling.ReturnStatusDescription == "Completed") {

                //    $('#spanbutton').append('<a href="#" id="aefilereview" class="WagesSelected rvw">Review</a>');
                //}



            }
            if (data.StateFiling != null) {
                $.each(data.StateFiling, function (index, value) {
                    var stateReturnStatus = value.ReturnStatusDescription;
                    if (value.IsEfile == true) {
                        //State Efiling


                        $("#divSelectReturnFile").append('<div id="divSelectedReturn">' + '<div class="pangird itm">' +
                           '<label class="col-md-4"><input type="checkbox" id="chkfederal"/>' + '' + '</label>' +
                  '<label class="col-md-3">' + value.State.StateName + '</label>' +
                  '<label class="col-md-3" id="lblStatus">' + stateReturnStatus + '</label>' +
                  '<label class="col-md-2" >' + '' +
                  '</label></div>');
                    }
                });
            }
            }
        });
      

    $('#chkfederal').change(function () {
        if ($('#chkfederal').prop('checked')) {
            $('#lblStatus').html("In-Progress");
        }
        else {
            $('#lblStatus').html("Not Started");
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



});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

//4-july-14 vivek for the persist after continue
function PersistFiling() {

    var stateFiling = [];
    var selectedStateFile;
    //TODO: commented by vivek on 17-july-14 this is for the state binding 
    //$.each($('#divSelectReturnFile').children('div'), function (key, value) {
    //    selectedStateFile = {
    //        IsEfile: $("#chkstate" + key).prop('checked'),
    //        State: {
    //            StateId: $("#hSkuID" + key).val(),
    //            StateName: $("#hSkuName" + key).val()
    //        }
    //    };
    //    stateFiling.push(selectedStateFile);
    //});
    var isEfile = $("#chkfederal").prop('checked');
    var returnStatus = 0;
    if(isEfile)
    {
        returnStatus = 4;
    }
    else
    {
        returnStatus = 3;
    }
    var taxdata = {
        HaveFiledPriorYearReturnElectronically: $('#radFiledPriorTaxYearInEfile').prop('checked'),
        Email: $('#txtEmailAddress').val(),
        FederalFiling: {
            IsEfile: isEfile,
            ReturnStatus: returnStatus
        },
        StateFiling: stateFiling
    }

    $.ajax({
        url: serviceUrl + 'efile/persistfiling',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
            {
                UserDataId: userDataId,
                TaxData: JSON.stringify(taxdata),
            }
        }),
        type: "POST",
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
