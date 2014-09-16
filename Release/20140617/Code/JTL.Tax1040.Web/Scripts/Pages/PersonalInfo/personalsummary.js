//Scripts for personalSummary
var navigateValue;
var dateOfBirth;
var hasPersonalInfoEligibilityDiagnostics;
var filingStatus = 1;
$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    GetPersonalSummary();
    $('#btnContinue').click(function () {
        window.location.href = '../Income/incomegateway.html';
        return false;
});
});


function GetPersonalSummary() {
    

    $.ajax({
        url: serviceUrl + 'personalinfo/getpersonaldetailsbyuseridanduserdataid',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
           
            if (data.m_Item1 != null && data.m_Item1.PrimaryTaxPayer != null) {
                filingStatus = data.m_Item1.PrimaryTaxPayer.FilingStatus;
                if (filingStatus == 2) {
                    $("#liSpouse").css("display", "inline");
                } else {
                    $("#divSpouseInfo").hide();
                }
                $("#divFillingStatus").append('<label class="col-md-4">' + data.m_Item1.PrimaryTaxPayer.FilingStatusDescription + '</label>' +
                   '<label class="col-md-3">&nbsp;</label>' +
                   '<label class="col-md-3">&nbsp;</label>' +
                   '<label class="col-md-2">' +
                        '<a href="../PersonalInfo/filingstatus.html" title="Edit" class="fa fa-edit"></a>' +
                   '</label>');
            } else {

                $("#divSpouseInfo").hide();
                $("#divFillingStatus").append('<label class="col-md-4"></label>' +
               '<label class="col-md-3">&nbsp;</label>' +
               '<label class="col-md-3">&nbsp;</label>' +
               '<label class="col-md-2">' +
                    '<a href="../PersonalInfo/filingstatus.html" title="Edit" class="fa fa-edit"></a>' +
               '</label>');
            
            }

            if (data.m_Item1 != null &&
                data.m_Item1.PrimaryTaxPayer != null &&
                data.m_Item1.PrimaryTaxPayer.Person != null) {

                var personDOB = '';
                if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1900'
                     && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1')
                    personDOB = $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.PrimaryTaxPayer.Person.DateOfBirth));

                $("#divPrimaryFiler").append('<label class="col-md-4">' + GetEmptyOnNull(data.m_Item1.PrimaryTaxPayer.Person.FirstName) + '</label>' +
                '<label class="col-md-3">' + personDOB + '</label>' +
                '<label class="col-md-3">' + GetEmptyOnNull(data.m_Item1.PrimaryTaxPayer.Person.SSN) + '</label>' +
                '<label class="col-md-2">' +
                     '<a href="../PersonalInfo/primaryfilerinfo.html" title="Edit" class="fa fa-edit"></a>' +
                '</label>');
            } else {
                $("#divPrimaryFiler").append('<label class="col-md-4"></label>' +
              '<label class="col-md-3">&nbsp;</label>' +
              '<label class="col-md-3">&nbsp;</label>' +
              '<label class="col-md-2">' +
                   '<a href="../PersonalInfo/primaryfilerinfo.html" title="Edit" class="fa fa-edit"></a>' +
              '</label>');
            }
            if (filingStatus == 2 )
                {
                if (data.m_Item1 != null && data.m_Item1.Spouse != null && data.m_Item1.Spouse.Person != null) {

                var spouseDOB = '';
                    if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Spouse.Person.DateOfBirth)) != '01/01/1900'
                                    && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Spouse.Person.DateOfBirth)) != '01/01/1')
                    spouseDOB = $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Spouse.Person.DateOfBirth));

                    $("#divSpouse").append('<label class="col-md-4">' + GetEmptyOnNull(data.m_Item1.Spouse.Person.FirstName) + '</label>' +
              '<label class="col-md-3">&nbsp;' + spouseDOB + '</label>' +
                  '<label class="col-md-3">&nbsp;' + GetEmptyOnNull(data.m_Item1.Spouse.Person.SSN) + '</label>' +
              '<label class="col-md-2">&nbsp;' +
                   '<a href="../PersonalInfo/spouseinfo.html" title="Edit" class="fa fa-edit"></a>' +
              '</label>');//Thileep Removed ; on 17Jun2014
            } else {
                    $("#divSpouse").append('<label class="col-md-4">&nbsp;</label>' +
                    '<label class="col-md-3">&nbsp;</label>' +
                    '<label class="col-md-3">&nbsp;</label>' +
                '<label class="col-md-2">' +
                '<a href="../PersonalInfo/spouseinfo.html" title="Edit" class="fa fa-edit"></a>' +
                '</label>');
            }
        }
            if (data.m_Item1 != null &&
                data.m_Item1.PrimaryTaxPayer != null &&
                data.m_Item1.PrimaryTaxPayer.Person != null &&
                data.m_Item1.PrimaryTaxPayer.Person.Address != null) {
                        var stateOfResidence = '';
                        var apartmentNumber = '';
                        var address = '';

                        if (data.m_Item1.PrimaryTaxPayer.Person.Address.ResidenceState != null
                            && data.m_Item1.PrimaryTaxPayer.Person.Address.ResidenceState.StateId != 0) {
                            stateOfResidence = data.m_Item1.PrimaryTaxPayer.Person.Address.ResidenceState.StateName;
                        }
                        if (data.m_Item1.PrimaryTaxPayer.Person.Address.AddressType == 1) {
                            //apartmentNumber = data.m_Item1.PrimaryTaxPayer.Person.Address.PersonalAddress.ApartmentNumber;
                            address = data.m_Item1.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress;
                            } 
                        else {
                            //apartmentNumber = data.m_Item1.PrimaryTaxPayer.Person.Address.ForeignAddress.ApartmentNumber;
                            address = data.m_Item1.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress;
                        }

                        $("#divAddress").append('<label class="col-md-4">' + address + '</label>' +
                    '<label class="col-md-3">' + stateOfResidence + '</label>' +
                    '<label class="col-md-3">&nbsp;</label>' +
                      '<label class="col-md-2">' +
                           '<a href="../PersonalInfo/address.html" title="Edit" class="fa fa-edit"></a>' +
                      '</label>');
            } else {
                $("#divAddress").append('<label class="col-md-4"></label>' +
                '<label class="col-md-3">&nbsp;</label>' +
                '<label class="col-md-3">&nbsp;&nbsp;</label>' +
                '<label class="col-md-2">' +
                '<a href="../PersonalInfo/address.html" title="Edit" class="fa fa-edit"></a>' +
                '</label>');
            }
            //}
            //   }
            
            if (data.m_Item2 != null && data.m_Item2.length > 0) {

                var errorKnt = data.m_Item2.length;
                if (errorKnt > 0) {
                    $('#supErrorCount').html(errorKnt); 
                    $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                    $("#divDiagnosticsParent").show();
                }
                $.each(data.m_Item2, function (index, value) {
                    navigateValue = value.MessageTarget + "?" + value.FieldName;
                    $("#dvDiagnostics").append('<a href="' + navigateValue + '">' + value.ErrorText + '</a>');
                    //27May2014 - Added by Ashok for Diagnostic Navigtion on Eligibility errors
                    if ((value.Tab == 'PersonalInfo') && (value.MessageType == 'ER')) {
                        hasPersonalInfoEligibilityDiagnostics = true;
                    }
                  
                });
                //27May2014 - Added by Ashok for Diagnostic Navigtion on Eligibility errors
                if (hasPersonalInfoEligibilityDiagnostics) {
                    window.location.href = '../Diagnostics/finaldiagnostics.html?Tab=Personal Info&FilingStatus=' + filingStatus;
                    return false;
                }
            }
            if (data.m_Item2 == null||data.m_Item2.length == 0) {
                $("#divDiagnosticsParent").hide();
            }
            }
        });
    }

function GetEmptyOnNull(value) {
    if (value == null)
        return '';
    else
        return value;
}

