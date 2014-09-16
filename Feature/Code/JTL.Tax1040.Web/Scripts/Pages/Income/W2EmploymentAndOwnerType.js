//w2Employmentandownertype script
// 03may2014 Sathish user Tax return bo for persist
//13 May14-Vincent Pre-Page Logic Change for P3.

var w2Id = 0;
var w2;

$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    var pageURL = window.location.search.substring(1);
    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('W2Id') == 0)
        w2Id = parameterName[1];

    //Saravanan N - 14th May, 2014 - Method code refactored from HTML.
    $('#btnBack').click(function () {
        if (w2Id > 0) {
            PersistW2();
        }
        GoToPreviousPage();
        return false;
    });

    //Saravanan N - 14th May, 2014 - Method code refactored from HTML.
    $('#btnContinue').click(function() {
        if (PersistW2())
            window.location.href = '../Income/w2.html?W2Id=' + w2Id;
        return false;
    });

    GetW2Data();
});

//Saravanan N - 14th May, 2014 - Method code refactored.
function GetW2Data() {
    $.ajax({
        url: serviceUrl + 'w2/getw2data',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId,
            "FormId": w2Id
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data.m_Item1 != null) {
                //Yogalakshmi - 14th August, 2014 - Disable radio buttons in Wages Employment type, if user comes here in Edit mode.
                disableRadioButtonInEditMode();
                w2 = data.m_Item1;
                w2Id = data.m_Item1.W2Id;
                $('input:radio[name=radEmploymentType]')[data.m_Item1.EmploymentType - 1].checked = true;
                $('input:radio[name=radOwnerType]')[data.m_Item1.OwnerType - 1].checked = true;

            }
            if (data.m_Item2 != null) {
                if (data.m_Item2.PrimaryTaxPayerFirstName != null && data.m_Item2.PrimaryTaxPayerFirstName != "") {
                    $('#lblPrimaryFilerFirstName').html(data.m_Item2.PrimaryTaxPayerFirstName);
                }
                else {
                    //Defect TAX1040-14006 - Prasanna Sri - 11th June, 2014 - Taxpayer static text altered.
                    $('#lblPrimaryFilerFirstName').html("Taxpayer");
                }

                if (data.m_Item2.SpouseFirstName != null && data.m_Item2.SpouseFirstName != "") {
                    $('#lblSpouseFirstName').html(data.m_Item2.SpouseFirstName);
                }
                else {
                    $('#lblSpouseFirstName').html("Spouse");
                }
                if (data.m_Item2.FilingStatus == null || data.m_Item2.FilingStatus != 2) {
                        $('#divOwnerType').hide();
                }
                if (data.m_Item1 == null) {
                    $("#radW2TaxPayer")[0].checked = true;
                    $("#radRegularW2Wages")[0].checked = true;
                }
            } else {
                //Defect TAX1040-14006 - Prasanna Sri - 11th June, 2014 - Taxpayer static text altered.
                $('#lblPrimaryFilerFirstName').html("Taxpayer");
                $('#lblSpouseFirstName').html("Spouse");
                $('#divOwnerType').hide();
                if (data.m_Item1 == null) {
                    $("#radW2TaxPayer")[0].checked = true;
                    $("#radRegularW2Wages")[0].checked = true;
                }
            }

        }
    });
}

//TODO: This method should be moved to common place, since it is used from W2.js also. - Saravanan N - 14th May, 2014
function PersistW2() {
    var isW2Persisted = false; //29May2014 Sathish variable used to check navigation

    var employementType = $("input:radio[name='radEmploymentType']:checked").val();
    var ownerType = $("input:radio[name='radOwnerType']:checked").val();
    var w2Data;
    if (w2 != null) {
        if (w2.EmploymentType != employementType) {
            if (employementType > 0 && employementType < 6) {
                w2Data = w2;
                w2Data.EmploymentType = employementType;
                w2Data.OwnerType = ownerType;
            } else {
                w2Data = {
                    EmploymentType: employementType,
                    //OwnerType: ownerType,
                    W2Id: w2.W2Id,
                };
            }
        } else {
            w2Data = w2;
        }
    } else {
        w2Data = {
            EmploymentType: employementType,
            //OwnerType: ownerType,
            W2Id: w2Id,
        };
    }

    //Pre-Page Logic Change for P3.
    w2Data.OwnerType = ownerType;

    $.ajax({
        url: serviceUrl + 'w2/persistw2data',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
                {
                    UserDataId: userDataId,
                    TaxData: JSON.stringify(w2Data),
                }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data.UserDataId);
            w2Id = data.W2Id;
            isW2Persisted = true;
        }
    });
    return isW2Persisted;

}

//Yogalakshmi - 14th August, 2014 - Disable radio buttons in Wages Employment type, if user comes here in Edit mode.
function disableRadioButtonInEditMode() {
    $('input[name=radEmploymentType]').attr('disabled', true);
}
