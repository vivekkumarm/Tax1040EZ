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
   


    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
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
                        '<a href="../PersonalInfo/filingstatus.html" title="Edit" class="i-edit"></a>' +
                   '</label>');
            } else {

                $("#divSpouseInfo").hide();
                $("#divFillingStatus").append('<label class="col-md-4"></label>' +
               '<label class="col-md-3">&nbsp;</label>' +
               '<label class="col-md-3">&nbsp;</label>' +
               '<label class="col-md-2">' +
                    '<a href="../PersonalInfo/filingstatus.html" title="Edit" class="i-edit"></a>' +
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
                     '<a href="../PersonalInfo/primaryfilerinfo.html" title="Edit" class="i-edit"></a>' +
                '</label>');
            } else {
                $("#divPrimaryFiler").append('<label class="col-md-4"></label>' +
              '<label class="col-md-3">&nbsp;</label>' +
              '<label class="col-md-3">&nbsp;</label>' +
              '<label class="col-md-2">' +
                   '<a href="../PersonalInfo/primaryfilerinfo.html" title="Edit" class="i-edit"></a>' +
              '</label>');
            }
            if (filingStatus == 2) {
                if (data.m_Item1 != null && data.m_Item1.Spouse != null && data.m_Item1.Spouse.Person != null) {

                    var spouseDOB = '';
                    if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Spouse.Person.DateOfBirth)) != '01/01/1900'
                                    && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Spouse.Person.DateOfBirth)) != '01/01/1')
                        spouseDOB = $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Spouse.Person.DateOfBirth));

                    $("#divSpouse").append('<label class="col-md-4">' + GetEmptyOnNull(data.m_Item1.Spouse.Person.FirstName) + '</label>' +
              '<label class="col-md-3">&nbsp;' + spouseDOB + '</label>' +
                  '<label class="col-md-3">&nbsp;' + GetEmptyOnNull(data.m_Item1.Spouse.Person.SSN) + '</label>' +
              '<label class="col-md-2">&nbsp;' +
                   '<a href="../PersonalInfo/spouseinfo.html" title="Edit" class="i-edit"></a>' +
              '</label>');//Thileep Removed ; on 17Jun2014
                } else {
                    $("#divSpouse").append('<label class="col-md-4">&nbsp;</label>' +
                    '<label class="col-md-3">&nbsp;</label>' +
                    '<label class="col-md-3">&nbsp;</label>' +
                '<label class="col-md-2">' +
                '<a href="../PersonalInfo/spouseinfo.html" title="Edit" class="i-edit"></a>' +
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
            '<label class="col-md-6">' + stateOfResidence + '</label>' +

              '<label class="col-md-2">' +
                   '<a href="../PersonalInfo/address.html" title="Edit" class="i-edit"></a>' +
              '</label>');
            } else {
                $("#divAddress").append('<label class="col-md-4"></label>' +
                '<label class="col-md-6">&nbsp;</label>' +
                '<label class="col-md-2">' +
                '<a href="../PersonalInfo/address.html" title="Edit" class="i-edit"></a>' +
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

                //Modified by prasana made changes for displaying error based on the type on 14.07.2014
                //Modified by prasana added null check for value and changed to Switch case on 15.07.2014
                $.each(data.m_Item2, function (index, value) {
                    if (value != null) {
                        if ((value.Tab == Tab.PersonalInfo) && (value.MessageType == MessageType.ER)) {
                            hasPersonalInfoEligibilityDiagnostics = true;
                        }
                        else {
                            errorKnt += 1;
                            navigateValue = value.MessageTarget + "?" + value.FieldName;

                            var errorType = value.ErrorType.trim();
                            var className = '';

                            switch (errorType) {
                                case ErrorType.Error:
                                    className = "dierror";
                                    break;

                                case ErrorType.Warning:
                                    className = "diwarn";
                                    break;

                                case ErrorType.Information:
                                    className = "diinfo";
                                    break;
                            }

                            //Assign class dynamically based on ErrorType.
                            $("#dvDiagnostics").append('<div class="msgerrors"> <a class="' + className + ' tip" data-toggle="tooltip" data-placement="top"  href="' + navigateValue + '"  title="' + value.LongErrorText + '"> ' + value.ErrorText + '.</a><span>' + value.Topic + '</span></div>');
                        }
                    }
                });

                //27May2014 - Added by Ashok for Diagnostic Navigtion on Eligibility errors
                if (hasPersonalInfoEligibilityDiagnostics) {
                    // 20Jun2014 Sathish replaced hard coded value with the constant
                    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
                    window.location.href = '../Review/finalsummary.html?Tab=' + Tab.PersonalInfo + '&FilingStatus=' + filingStatus;
                    return false;
                }
            }
            if (data.m_Item2 == null || data.m_Item2.length == 0) {
                $("#divDiagnosticsParent").hide();
            }
            //07Aug2014 Sathish saved user data id.
            if (data.m_Item3 != null)
                window.sessionStorage.setItem("UserDataId", data.m_Item3);
        }
    });
}

function GetEmptyOnNull(value) {
    if (value == null)
        return '';
    else
        return value;
}

