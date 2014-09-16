var stateRecordCount = 0;
var residentValue = "Resident";
var nonResidentValue = "Non Resident";

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
            alert(jqXHR + "-" + textStatus + "-" + errorThrown);
        },
        success: function (data, textStatus) {
            $('#lblPrimaryTaxPayerName').html(data.TaxPayerName);

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
                }
                else if (data.TaxExcemptionState) {
                    $('#divp1').hide();
                    $('#divp2').show();
                    $('#divp6').hide();
                    $('#divp7').hide();
                    $('#divp8').hide(); $('#divO4').hide();
                }
                else if (data.ResidenceState.StateName == '' || data.ResidenceState.StateName == null) {
                    $('#divp7').show();
                    $('#divp6').hide();
                    $('#divp8').hide();
                    $('#divO4').hide();
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
                    if (data.ResidenceState.StateId == 0) {
                        $('#divoriginalresident').remove();
                        $("#divAddingEmptyRecord").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                     '</span>');
                    }
                }
            }
            else {
                $('#divp1').hide();
                $('#divp2').hide();
                $('#divp6').hide();
                $('#divp7').show();
                $('#divp8').hide();
                $('#divO4').hide();
                $('#divO1').hide();
                $('#divp10').hide();
                $('#divoriginalresident').remove();
                $("#divAddingEmptyRecord").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                  '</span>');
            }

            if (data.Taxablestate != null) {
                for (var i = 0; i < data.Taxablestate.length; i++) {
                    if (data.Taxablestate[i].ResidentType == residentValue) {
                        //   isresidentaailinlist = false;
                        $('#divoriginalresident').remove();
                        $('#divp8').hide();
                    }
                    bindList(data.Taxablestate[i].StateId, data.Taxablestate[i].StateName, data.Taxablestate[i].ResidentType);
                }
            }
        }
    });

    getState();
}


function getState() {
    $.ajax({
        url: serviceUrl + 'personalinfo/getstate',
        async: false,
        dataType: "json",
        type: "GET",
        data: { "supporting_state": true },
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
           '<label class="col-md-3">' +
          '<a href="#" title="Delete" id="lnkdeleteResidentState' + stateRecordCount + '" onclick="DeleteResidentState(this.id);return false;">Delete</a> ' +
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

    $('#btnSkipState').click(function () {
        alert("Need to Do..  Navigate to next section");

    });

    $('#btnAddstate').click(function () {
        if ($("#stategateway").valid()) {
            var isavailable = true;
            var isresidenttypeavailable = false;
            var isstateavailable = false;

            $('*[id*=hdnStateId]').each(function () {

                var controlname = $(this).attr("id");
                var getid = controlname.split("hdnStateId");
                var residentcontrol = 'lblResident' + getid[1];

                if ($('[id^=' + residentcontrol + ']:first').text() == residentValue && $("#ddlResidentType option:selected").text() != nonResidentValue) {
                    isresidenttypeavailable = true;
                    isavailable = false;
                }
                else if ($('#lblTypeOfResident').html() == $("#ddlResidentType").val()) {
                    isresidenttypeavailable = true;
                    isavailable = false;
                }

                if ($(this).val() == $("#ddlState").val()) {
                    $('#divErrorMessage').html('State already available in the List');
                    isavailable = false;
                }
                else if ($("#ddlState option:selected").text() == $('#lblNameOfState').html()) {
                    isstateavailable = true;
                    isavailable = false;
                }
            });

            if ($('#lblTypeOfResident').html() == $("#ddlResidentType").val()) {
                isresidenttypeavailable = true;
                isavailable = false;
            }
            if ($("#ddlState option:selected").text() == $('#lblNameOfState').html()) {
                isstateavailable = true;
                isavailable = false;
            }

            if ($("#ddlState").val() == 0) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have missed out to select the State Name');
                return false;

            } else if (isresidenttypeavailable) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have already selected Resident State');
                return false;

            } else if (isstateavailable) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have already selected the state as Resident');
                return false;
            }

            if ($("#ddlState").val() != '') {
                if (isavailable) {
                    stateRecordCount += 1;
                    var newresidenadress = ' <div class="pangird itm" id="divstateInformation' + stateRecordCount + '">' +
                          ' <input type="hidden" id="hdnStateId' + stateRecordCount + '" value="' + $("#ddlState").val() + '" />' +
                           ' <label class="col-md-4">' +
                          '  <label id="lblStateName' + stateRecordCount + '">' + $("#ddlState option:selected").text() + '</label>' +
                           '   </label>' +
                          '<label class="col-md-4">' +
                           '  <label id="lblResident' + stateRecordCount + ' ">' + $("#ddlResidentType").val() + '</label>' +
                           '   </label>' +
                          '</label>' +
                            '<label class="col-md-3">' +
                         '<a href="#" title="Delete" id="lnkdeleteResidentState' + stateRecordCount + '" onclick="DeleteResidentState(this.id);return false;">Delete</a> ' +
                         '   </label>' +
                          ' </div>';


                    $('#divdynamicList').append(newresidenadress);
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
        $('#divoriginalresident').remove();
        $('#divp8').show();
    }
}

function DeleteResidentState(controlid) {

    if (confirm("Are you sure, you want to delete the selected State ?")) {
        var getid = controlid.split("lnkdeleteResidentState");
        var residentcontrol = 'divstateInformation' + getid[1];
        $('[id^=' + residentcontrol + ']:first').remove();
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
                $('#lblStateCancelFiling').html($('#lblNameOfState').html());
                $('#lblStateCancelFilingName').html($('#lblNameOfState').html());
            }
            else {
                isResidentAvailable = false;
            }
        }
        lstDynamicResident.push({ StateId: $('[id^=' + stateidcontrol + ']:first').val(), StateName: $(this).text(), ResidentType: $('[id^=' + residentcontrol + ']:first').text() });
    });


    if ($('#lblTypeOfResident').html() == residentValue) {
        residentCount = 1;
    }

    if (isResidentAvailable) {
        $('#divErrorMessage').html('Resident Already Available');
    }

    else if (residentCount == 0) {
        $('#divErrorMessage').html('You have not selected your Residential state Information. Click Add New State  to select your Residential State');
    }
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
                //alert('success  Need to redirect to next section');
                window.location.href = '../Payment/federalreturnsummary.html';
                return false;
            }
        });
    }
}

