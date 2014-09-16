//Saravanan N - 22nd July, 2014  - File created to display Left Menu for FILE sections.
//File Left Memu Controls.

//Left Menu Construction.
var isFederalEfile;
var hasError = false;
document.write("<div id='reviewleftmenu' class='menu' role='navigation'>" +
    "<div class='collapse navbar-collapse' id='rvwlftmenu'>" +
    "<ul id='nav' class='nav side-nav'>" +
    "<li id='liFilingStatus'><a id='lnkFileInformation' href='../Efile/filingoption.html'><i class='fa fa-exchange'></i>Filing Option</a></li>" +
    "<li id='liFederal'><a id='lnkFederal' href='../Efile/federalpaymentdetail.html'><i class='fa fa-user'></i>Federal</a></li>" +
    "<li id='liState'><a id='lnkState' href='#'><i class='fa fa-female'></i>State</a></li>" +
    "<ul id='ulFilingState' class='list-group' style='list-style:none; margin:10px 0 10px;'></ul>" +
    //"<li id='lifilingsummary'><a id='aFilingSummary' href='../Efile/reviewtaxreturn.html'><i class='fa fa-th-list'></i>Filing Summary</a></li>" +
    //"<input type='hidden' ID='hdnFilingOptionSelected' />" +
    "</ul>" +
    "</div>" +
    "</div>");


$(document).ready(function () {
    var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();

    switch (selectedSection) {
        //Wages
        case 'filingoption':
        case 'filingoptionsummary':
            $('#liFilingStatus').addClass('active');
            break;

        case 'federalpaymentdetail':
        case 'federalefileinformation':
            $('#liFederal').addClass('active');
            break;

        case 'statefilingdetail':
            $('#liState').addClass('active');
            break;

            //case 'reviewtaxreturn':
            //    $('#aFilingSummary').addClass('active');
            //    break;
    }

    populateStatesInLeftMenu();

    if (isFederalEfile != null)
        GetEligibilityDiagnosticsData();

    setPageNavigation();


});


//Saravanan N - 22nd July, 2014 - This function added to get the States selected in the StateGateWay page.
function populateStatesInLeftMenu() {
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
            userDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null && data.Filing != null) {
                if (data.Filing.FederalFiling != null)
                    isFederalEfile = data.Filing.FederalFiling.IsEfile;
                // $('#hdnFilingOptionSelected').val('true');
                //  setPageNavigation();
            }
            if (data != null && data.StateFiling != null) {
                $.each(data.StateFiling, function (index, value) {
                    if (value.IsEfile != null) {
                        if (value.StateId == 5)
                            $('#ulFilingState').append("<li id='liState" + index + "' style='border-bottom:2px solid #5bc0de'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href='../Efile/capaymentdetail.html?EfileStateId=" + value.StateId + "'>" + value.StateName + "</a></li>");
                        else
                            $('#ulFilingState').append("<li id='liState" + index + "' style='border-bottom:2px solid #5bc0de'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href='../Efile/filingoption.html'>" + value.StateName + "</a></li>");
                    }
                    else
                        $('#ulFilingState').append("<li id='liState" + index + "' style='border-bottom:2px solid #5bc0de'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href='../Efile/filingoption.html'>" + value.StateName + "</a></li>");
                });
            }
        }
    });
}

//Saravanan N - 22nd July, 2014 - Set left menu link button page navigation reference.
function setPageNavigation() {
    if (isFederalEfile == null || (isFederalEfile && hasError))
        $('#lnkFederal').attr('href', '../Efile/filingoption.html');
    //$('#lnkState').attr('href', '../Efile/statefilingdetail.html');
    //$('aFilingSummary').attr('href', '../Efile/reviewtaxreturn.html');
}


function GetEligibilityDiagnosticsData() {


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
                        hasError = true;
                    }
                });
        }
    });
}
