// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
// * 24Jul2014 Ashok Kumar Modified to add Start button to the Grid along with Delete
var stateRecordCount = 0;
var residentValue = "Resident";
var nonResidentValue = "NonResident";
var partYearResident = "PartYearResident";

function Getaddressinfo() {
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
            //Saravanan N - 26th June, 2014 - Commented to avoid Server Error in StateGateway continue button.
            //alert(jqXHR + "-" + textStatus + "-" + errorThrown); 
        },
        success: function (data, textStatus) {
            $('#lblPrimaryTaxPayerName').html(data.TaxPayerName);


            if (data.Taxablestate == null) {

                if (data.ResidenceState != null && data.ResidenceState.StateId != 0) {
                    if (data.SupportingState) {
                        $('#divp1').show();
                        $('#divp2').hide();
                        $('#divp6').hide();
                        $('#divp7').hide();
                        $('#divp8').hide();
                        $('#divO4').hide();
                        $('#lblNameOfState').html(data.ResidenceState.StateName);
                        $('#lblStateCodeP4').html(data.ResidenceState.StateName);
                        $('#lblStateCancelFiling').html(data.ResidenceState.StateName);
                        $('#lblStateCancelFilingName').html(data.ResidenceState.StateName);
                        $('#hdnstaticstate').val(data.ResidenceState.StateId);
                    }
                    else if (data.TaxExcemptionState) {
                        $('#divp1').hide();
                        $('#divp2').show();
                        $('#divp6').hide();
                        $('#divp7').hide();
                        $('#divp8').hide(); $('#divO4').hide();
                        $('#divoriginalresident').remove();
                    }
                    else if (data.ResidenceState.StateName == '' || data.ResidenceState.StateName == null) {
                        $('#divp7').show();
                        $('#divp6').hide();
                        $('#divp8').hide();
                        $('#divO4').hide();
                        $('#divoriginalresident').remove();
                    }
                    else {
                        $('#lblStateCancelFiling').html(data.ResidenceState.StateName);
                        $('#lblStateCancelFilingName').html(data.ResidenceState.StateName);
                        $('#lblNameOfState').html(data.ResidenceState.StateName);
                        $('#lblStateCodeP4').html(data.ResidenceState.StateName);
                        $('#divp1').hide();
                        $('#divp6').show();
                        $('#divp2').hide();
                        $('#divp7').hide();
                        $('#divp8').hide();
                        $('#divO4').hide();
                        $('#divO1').hide();
                        //   if (data.ResidenceState.StateId == 0) {
                        $('#divoriginalresident').remove();
                        $("#divAddingEmptyRecord").append('<span id="spnnoInformation" class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                     '</span>');
                        //   }
                    }
                }
                else {
                    NoResidentState();
                }
            }
            else {
                $('#divoriginalresident').remove();
                $('#divp1').show();
                $('#divp2').hide();
                $('#divp6').hide();
                $('#divp7').hide();
                $('#divp8').hide();
                $('#divO4').hide();

                if (data.Taxablestate != null) {
                    for (var i = 0; i < data.Taxablestate.length; i++) {
                        if (data.Taxablestate[i].ResidentType == residentValue) {
                            //   isresidentaailinlist = false;
                            $('#divoriginalresident').remove();
                            $('#divp8').hide();
                        }
                        if (data.Taxablestate[i].State != null)
                            bindList(data.Taxablestate[i].State.StateId, data.Taxablestate[i].State.StateName, data.Taxablestate[i].ResidentType);
                    }
                    if (data.Taxablestate.length == 0) {
                        $("#divAddingEmptyRecord").append('<span id="spnnoInformation"  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                       '</span>');
                    }
                }
            }
        }
    });
    getSupportingState();
}

function NoResidentState() {
    $('#divp1').hide();
    $('#divp2').hide();
    $('#divp6').hide();
    $('#divp7').show();
    $('#divp8').hide();
    $('#divO4').hide();
    $('#divO1').hide();
    // $('#divp10').hide();
    $('#divoriginalresident').remove();
    $("#divAddingEmptyRecord").append('<span id="spnnoInformation"  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
      '</span>');
}


function getSupportingState() {
    $.ajax({
        url: serviceUrl + 'stategateway/getallsupportingstate',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        type: "GET",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            alert(jqXHR + "-" + textStatus + "-" + errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlState").append($("<option></option>").val('').html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlState").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });
}

function bindList(stateid, statename, residenttype) {
    stateRecordCount += 1;
    var newresidenadress = ' <div class="pangird itm" id="divstateInformation' + stateRecordCount + '">' +
         ' <input type="hidden" id="hdnStateId' + stateRecordCount + '" value="' + stateid + '" />' +

          '  <label id="lblStateName' + stateRecordCount + '" class="col-md-4">' + statename + '</label>' +


           '  <label id="lblResident' + stateRecordCount + ' " class="col-md-4">' + residenttype + '</label>' +

          '</label>' +
           '<label class="col-md-4">' +
          '<a href="#" title="Delete" id="lnkdeleteResidentState' + stateRecordCount + '" onclick="DeleteResidentState(this.id);return false;">Delete</a> ' +
          '<a href="#" title="Start" id="lnkStartResidentState' + stateRecordCount + '" onclick="SaveStates();return false;">Start</a> ' +
        '   </label>' +
          ' </div>';


    $('#divdynamicList').append(newresidenadress);

    return false;
}

$(document).ready(function () {
    Getaddressinfo();
    $('#divO1').hide();
    $('#btnaddNewState').click(function () {
        $('#divO1').show();
        return false;
    });

    $('#btncancel').click(function () {
        $('#divO1').hide();
        return false;
    });

    $(function () {
        $("#popStateOfResidence").popover({ title: '', content: "<h5>State Of Residence</h5>Select the state where you resides and the place where you permitted to Vote/Maintaining Bank Account /Driving license issued by State Government.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popuptypeofResidence").popover({ title: '', content: "<h5>Type Of Residence</h5>Select the type of Residence.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

    $('#btncancelFiling').click(function () {
        if (confirm("Are you sure, you want to Cancel Filing of your Federal tax return ?")) {
            $('#divCancelFiling').hide();
            $('#divO4').show();
        }
        return false;
    });

    $("#stategateway").validate({
        rules: {
            ddlState: {
                required: true
            }
        },
        messages: {
            ddlState: {
                required: "You have missed out to select the State Name"
            }
        }
    });

    // 4-july-2014 vivek redirect to review page while clicking skip state button
    $('#btnSkipState').click(function () {
        PersistUserFeature();
        SaveStates();
        window.location.href = '../Review/finalsummary.html';
        return false;
    });

    //4-july-2014 vivek redirect to the previous page
    $('#btnBackStateGateWay').click(function () {
        GoToPreviousPage();
        return false;
    });

    $('#btnAddstate').click(function () {
        if ($("#stategateway").valid()) {
            $("#divErrorMessage").hide();
            var isavailable = true;
            var isresidenttypeavailable = false;
            var isstateavailable = false;
            var ispartyearresidentavailable = false;

            $('*[id*=hdnStateId]').each(function () {

                var controlname = $(this).attr("id");
                var getid = controlname.split("hdnStateId");
                var residentcontrol = 'lblResident' + getid[1];

                if ($('[id^=' + residentcontrol + ']:first').text() == residentValue && $("#ddlResidentType option:selected").text() != nonResidentValue) {
                    isresidenttypeavailable = true;
                    isavailable = false;
                }
                else if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == $("#ddlResidentType").val()) {
                    isresidenttypeavailable = true;
                    isavailable = false;
                }

                if ($(this).val() == $("#ddlState").val()) {
                    $("#divErrorMessage").show();
                    $('#divErrorMessage').html('You have already selected the '+ $("#ddlState option:selected").text() +' state');
                    isstateavailable = true;
                    isavailable = false;
                    return false;
                }
                else if ($('#lblNameOfState').html() != undefined && $("#ddlState option:selected").text() == $('#lblNameOfState').html()) {
                    isstateavailable = true;
                    isavailable = false;
                }


                if ($("#ddlResidentType").val() == partYearResident) {
                    ispartyearresidentavailable = true;
                }

                if ($('[id^=' + residentcontrol + ']:first').text() == partYearResident) {
                    ispartyearresidentavailable = true;
                }

            });

            if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == $("#ddlResidentType").val() && $('#lblTypeOfResident').html() != partYearResident) {
                isresidenttypeavailable = true;
                isavailable = false;
            }

            if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == partYearResident) {
                ispartyearresidentavailable = true;
            }

            if ($('#lblNameOfState').html() != undefined && $("#ddlState option:selected").text() == $('#lblNameOfState').html()) {
                isstateavailable = true;
                isavailable = false;
            }

            if ($("#ddlState").val() == 0) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have missed out to select the State Name');
                return false;

            } else if (isresidenttypeavailable && $("#ddlResidentType").val() != partYearResident &&  $("#ddlResidentType").val() != nonResidentValue) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have already selected the Type of return as Resident.');
                return false;

            } else if (isstateavailable) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have already selected the state as Resident');
                return false;
            }

            if ($("#ddlResidentType").val() == partYearResident) {

                ispartyearresidentavailable = true;
            }

            if (isresidenttypeavailable && $("#ddlResidentType").val() == partYearResident) {
                isavailable = true;
            }

            if (ispartyearresidentavailable && $("#ddlResidentType").val() == residentValue) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('Part Year Resident state is available');
                isavailable = false;
                return false;
            }

            if ($("#ddlResidentType").val() == nonResidentValue && !isstateavailable) {
                isavailable = true;
            }

            if ($("#ddlState").val() != '') {
                if (isavailable) {

                    var Partyearbindvalue = partYearResident;

                    if (ispartyearresidentavailable && $("#ddlResidentType").val() != nonResidentValue) {
                        Partyearbindvalue = partYearResident;
                    }
                    else {
                        Partyearbindvalue = $("#ddlResidentType").val();
                    }

                    stateRecordCount += 1;
                    var newresidenadress = ' <div class="pangird itm" id="divstateInformation' + stateRecordCount + '">' +
                          ' <input type="hidden" id="hdnStateId' + stateRecordCount + '" value="' + $("#ddlState").val() + '" />' +
                           ' <label class="col-md-4">' +
                          '  <label id="lblStateName' + stateRecordCount + '">' + $("#ddlState option:selected").text() + '</label>' +
                           '   </label>' +
                          '<label class="col-md-4">' +
                           '  <label id="lblResident' + stateRecordCount + ' ">' + Partyearbindvalue + '</label>' +
                           '   </label>' +
                          '</label>' +
                            '<label class="col-md-4">' +
                         '<a href="#" title="Delete" id="lnkdeleteResidentState' + stateRecordCount + '" onclick="DeleteResidentState(this.id);return false;">Delete</a> ' +
                         '<a href="#" title="Start" id="lnkStartResidentState' + stateRecordCount + '" onclick="SaveStates();return false;">Start</a> ' +
                         '   </label>' +
                          ' </div>';

                    if (ispartyearresidentavailable && ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == residentValue)) {
                        $('#lblTypeOfResident').html(partYearResident);
                    }

                    $('#divdynamicList').append(newresidenadress);

                    if ($('#lblNameOfState').html() == undefined && $('#spnnoInformation') != undefined) {
                        $('#spnnoInformation').remove();
                    }

                    // Clear Stata and resident type dropdowm
                    $("#ddlState").val('');
                    $("#ddlResidentType").val(nonResidentValue);

                    if (ispartyearresidentavailable && isresidenttypeavailable) {
                        $('#divdynamicList').html($('#divdynamicList').html().replace(">" + residentValue + "<", ">" + partYearResident + "<"));
                    }

                }
                return false;
            }
            else {
                return false;
            }
        }
    });
});

function DeleteState() {
    if (confirm("Are you sure, you want to delete the selected State ?")) {
        if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == residentValue) {
            $('#divp8').show();
        }
        $('#divoriginalresident').remove();
    }
}

function DeleteResidentState(controlid) {

    if (confirm("Are you sure, you want to delete the selected State ?")) {
        var getid = controlid.split("lnkdeleteResidentState");
        var residentcontrol = 'divstateInformation' + getid[1];
        $('[id^=' + residentcontrol + ']:first').remove();

        if ($('[id^=divstateInformation]').length == 0 && $('#lblTypeOfResident').html() == undefined) {
            $("#divAddingEmptyRecord").append('<span id="spnnoInformation"  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
     '</span>');
        }
    }
}

function SaveStates() {
    var isResidentAvailable = false;
    var residentCount = 0;

    var lstDynamicResident = [];
    $('*[id*=lblStateName]').each(function () {
        var controlname = $(this).attr("id");
        var getid = controlname.split("lblStateName");
        var residentcontrol = 'lblResident' + getid[1];
        var stateidcontrol = 'hdnStateId' + getid[1];

        if ($('[id^=' + residentcontrol + ']:first').text() == residentValue) {
            residentCount = 1;
            $('#lblStateCancelFiling').html($(this).text());
            $('#lblStateCancelFilingName').html($(this).text());
            if ($('#lblresident_type').html() == residentValue) {
                isResidentAvailable = true;
                residentCount = 1;
                if ($('#lblNameOfState').html() != undefined) {
                    $('#lblStateCancelFiling').html($('#lblNameOfState').html());
                    $('#lblStateCancelFilingName').html($('#lblNameOfState').html());
                }
            }
            else {
                isResidentAvailable = false;
            }
        }
        lstDynamicResident.push({
            State: {
                StateId: $('[id^=' + stateidcontrol + ']:first').val(),
                StateName: $(this).text()
            },
            ResidentType: $('[id^=' + residentcontrol + ']:first').text()
        });
    });


    if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == partYearResident) {
        lstDynamicResident.push({
            State: {
                StateId: $('#hdnstaticstate').val(),
                StateName: $('#lblNameOfState').html()
            },
            ResidentType: partYearResident
        });
    }
    else if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == residentValue) {
        lstDynamicResident.push({
            State: {
                StateId: $('#hdnstaticstate').val(),
                StateName: $('#lblNameOfState').html()
            },
            ResidentType: residentValue
        });
    }

    if ($('#lblTypeOfResident').html() != undefined && $('#lblTypeOfResident').html() == residentValue) {
        residentCount = 1;
    }

    if (isResidentAvailable) {
        $('#divErrorMessage').html('Resident Already Available');
    }
        // swapnesh 30-july-2014   resident is not manatory 
        //else if (residentCount == 0) {
        //    $('#divErrorMessage').html('You have not selected your Residential state Information. Click Add New State  to select your Residential State');
        //    //TODO - Yogalakshmi - 9th July 2014 - For time being its is redirected
        //    window.location.href = '../Review/finalsummary.html';
        //}
    else {

        $.ajax({
            url: serviceUrl + 'stategateway/persistTaxablestate',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                userId: userId,
                UserDataId: userDataId,
                TaxableState: JSON.stringify(lstDynamicResident)
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                alert(jqXHR + "-" + textStatus + "-" + errorThrown);
            },
            success: function (data, textStatus) {
                // alert('success  Need to redirect to next section');
                // window.location.href = '../Payment/federalreturnsummary.html'; 4-july-14 vivek and redirect to review page
                window.location.href = '../Review/finalsummary.html';
                return false;
            }
        });
    }
}

function PersistUserFeature() {

    //15Jul2014 Sathish Persist user feature
    $.ajax({
        url: serviceUrl + 'payment/persistuserfeature',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            // alert('success  Need to redirect to next section');
            // window.location.href = '../Payment/federalreturnsummary.html'; //4-july-14 vivek and redirect to review page
            //  window.location.href = '../Review/finalsummary.html';
            return false;
        }
    });
}
