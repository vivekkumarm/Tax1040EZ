//Script for W2GetData Summary
//Vincent - 16th April 2014- added a error message navigation for required user control.
//Vincent - 13th April 2014-Added pre-pages logic for wages amount
var isInterestIncomeHasValue, isUnemploymentHasValue, isOtherIncomeHasValue;

$(document).ready(function () {
    GetW2SummaryData();
    GetIncomeGatewayDataForW2Summary(); //Saravanan N - 29th April, 2014 - Added to decide Continue button navigation.

    if (isInterestIncomeHasValue) {
        $('#btnContinue').click(function () { window.location.href = '../Income/interestincome.html'; });
    }
    else if (isUnemploymentHasValue) {
        $('#btnContinue').click(function () { window.location.href = '../Income/unemployment.html'; });
    }
    else if (isOtherIncomeHasValue) {
        $('#btnContinue').click(function () { window.location.href = '../Income/otherincome.html'; });
    }
    else {
        $('#btnContinue').click(function () { window.location.href = '../Income/incomesummary.html'; });
    }

    return false;
});

function GetW2SummaryData() {
    $("#w2Summary").empty();
    $.ajax({
        url: serviceUrl + 'w2/getw2listanderrorlist',
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
            alert(jqXHR + "-" + textStatus + "-" + errorThrown);
            $("#divDiagnosticsParent").hide();//Saravanan N - 14th May, 2014 - Default hide the diagnostics.
        },
        success: function (data, textStatus) {

            var w2EmployerOrganizationName;
            var w2TaxPayerName;
            var taxPayerName;
            var spouseName;
            var totalWages = 0;
            if (data.m_Item3 != null) {
                taxPayerName = data.m_Item3.PrimaryTaxPayerName;
                spouseName = data.m_Item3.SpouseName;
                totalWages = data.m_Item3.TotalWages;
            }
            //Pre-Page getting the total Wages amount (P6)
            $('#lblTotalWagesAmount').html('$ ' + (typeof totalWages != "undefined" ? totalWages : 0));
            
            if (data.m_Item1 != null) {
            $.each(data.m_Item1, function (index, value) {
                w2EmployerOrganizationName = '';
                w2TaxPayerName = '';
                if (value.W2Id != 0) {

                    if (value.OwnerType == 2) {
                        w2TaxPayerName = spouseName;
                    }
                    else {
                        w2TaxPayerName = taxPayerName;
                    }

                        var employerName = "Not Specified"; //Saravanan N - 12th May, 2014 - Added to display NotSpecified as per spec changes.
                    if (value.Employer != null) {
                        if (value.Employer.Organization != null && value.Employer.Organization.Name != null) {
                            if (value.Employer.Organization.Name.trim().length > 0) {
                                employerName = value.Employer.Organization.Name;
                            }
                            
                        }
                    }

                    //Pre-Page logic for Wages amount.
                    var wagesAmount = 0;

                   
                    if (value.EmploymentType > 0 && value.EmploymentType < 6) {
                        wagesAmount = value.WagesAmount != null ? value.WagesAmount : 0;
                    } else {
                        if (value.Employer != null) {

                            if (value.EmploymentType == 6) {

                                wagesAmount = value.Employer.HouseholdEmployeeWages != null ? value.Employer.HouseholdEmployeeWages : 0;
                            }
                            else if (value.EmploymentType == 7) {

                                wagesAmount = value.Employer.TaxableScholarshipAmount != null ? value.Employer.TaxableScholarshipAmount : 0;

                            }
                        }
                    }

                    $("#w2Summary").append('<div class="pangird itm"><label class="col-md-4">'
                        + employerName + '</label>' +
                                       '<input type="hidden" id="hdnW2Id' + value.W2Id + '" value="' + value.W2Id + '"></input>' +
                                       '<label class="col-md-3">' + w2TaxPayerName + '</label>' +
                                       '<label class="col-md-3">' + wagesAmount + '</label>' +
                                            '<label class="col-md-2">' +
                                                 '<a href="../Income/w2employmentandownertype.html?W2Id=' + value.W2Id
                                                 + '" title="Edit" class="fa fa-edit"></a>' +
                                                 '<a href="#" title="Delete" onclick="DeleteW2('
                                                 + value.W2Id + ');return false;"  class="fa fa-minus-square-o"></a>' +
                                       '</label></div>');
                }

            });
            }

            $("#dvDiagnostics").empty();
            $("#divDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.

            if (data.m_Item2 != null) {
            var errorKnt = data.m_Item2.length;
            if (errorKnt > 0) {
                $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                $("#divDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.

                $.each(data.m_Item2, function (index, value) {
                    //Error Message navigation url
                    var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId;
                    $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '.</a>');
                });
            }
            }

            return false;
        }
    });
}

function DeleteW2(w2ID) {
    if (confirm("Are you sure, you want to delete the selected Form W2?")) {
        $.ajax({
            url: serviceUrl + 'w2/deletew2byid',
            async: false,
            dataType: "json",
            data: JSON.stringify({
                "UserId": userId,
                "UserDataId": userDataId,
                "FormId": w2ID
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
                GetW2SummaryData();
            }
        });
    }
}

//Saravanan N - 29th April, 2014 - As per IncomeGateway selected options Continue button's navigation will be decided here.
function GetIncomeGatewayDataForW2Summary() {
    $.ajax({
        url: serviceUrl + 'incomegateway/getincomegatewaydata',
        async: false,
        dataType: 'json',
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId
        }),
        type: 'POST',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: 'application/json',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                //Store the values into local variables.
                
                isInterestIncomeHasValue = data.m_Item2;
                isUnemploymentHasValue = data.m_Item3;
                isOtherIncomeHasValue = data.m_Item4;
            }
        }
    });
}
