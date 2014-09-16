var residentValue = "Resident";
var nonResidentValue = "NonResident";
var partYearResident = "PartYearResident";

$(document).ready(function () {
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');

    $('#hdnstateid').val(parameterName[0]);
    $('#lblstatename').html(parameterName[1]);
    $('#lblstatenameresident').html(parameterName[1]);
    $('#lblstatenamepartyear').html(parameterName[1]);
    $('#lblstatenamenonresident').html(parameterName[1]);
    $('#lblnonresidentstatename').html(parameterName[1]);


    if (parameterName[2] == "Resident") {
        $('#radResident').prop('checked', true);
    }
    else if (parameterName[2] == "NonResident") {
        $('#radNonResident').prop('checked', true);
    }
    else {
        $('#radPartYearResident').prop('checked', true);
    }

    $('#btnBackStateGateWay').click(function () {
        GoToPreviousPage();
        return false;
    });

    $('#btnContinue').click(function () {

        var selectedresident;

        if ($('#radResident').prop('checked')) {
            selectedresident = residentValue;
        }
        else if ($('#radNonResident').prop('checked')) {
            selectedresident = nonResidentValue;
        }
        else if ($('#radPartYearResident').prop('checked')) {
            selectedresident = partYearResident;
        }

        var stateResidenttype = {
            State: {
                StateId: $('#hdnstateid').val(),
                StateName: $('#lblstatename').html()
            },
            ResidentType: selectedresident,
            IsReviewed: true
        }



        $.ajax({
            url: serviceUrl + 'stategateway/persistResidentTypeConfirmation',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                userId: userId,
                UserDataId: userDataId,
                TaxableState: JSON.stringify(stateResidenttype)
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("UserDataId", data);
            }
        });

        // window.location.href = '../Review/nextpageNavigate.html';
        return false;
    });

});