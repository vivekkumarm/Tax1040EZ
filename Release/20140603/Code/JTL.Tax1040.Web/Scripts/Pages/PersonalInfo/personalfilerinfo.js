//Scripts for primary Filer info
var filingStatus;
var pageURL;
var parameterName;

$(document).ready(function () {
    LettersAndSpaceOnly('txtfirstname');
    LettersAndSpaceOnly('txtlastname');
    NumbersOnly('txtssn');
    LettersOnly('txtmiddleinitial');
    LettersAndSpaceOnly('txtoccupation');
   userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
    $('.error').hide();
    $('.spanCurrentYear').html(CURRENT_TAX_YEAR);
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    $("#primaryfilerinfo").validate({
        rules: {
            dtdateofbirth:
                {
                    validateDate: function () { $('#divDOBErrorMsg').html(''); true; },
                    validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html(''); true; }
                },
            dtdateofdeath:
                {
                    validateDate: function () { $('#divDODErrorMsg').html(''); true; }
                },
            txtssn:
              {
                  minlength: 11,
                  validateSSN: true
                }
        },
        messages: {
            dtdateofbirth:
                {
                    validateDate: function () { $('#divDOBErrorMsg').html('Enter a valid date'); },
                    validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html('Your year of birth should not be greater than tax year'); }
                },
            dtdateofdeath:
                {
                    validateDate: function () { $('#divDODErrorMsg').html('Enter a valid date'); }
                },
            txtssn: {
                minlength: "Invalid Social Security Number",
                validateSSN : "Invalid Social security Number"
                }
                }
    });
    
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
        }
    $('.error').hide();
    $('.spanCurrentYear').html(CURRENT_TAX_YEAR);


    //$("#txtssn").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    $("#chkStudent").change(function () {
        if ($('#chkStudent').prop('checked')) {
            $('#FulltimeStudentShow').show();
        $('#radWasStudentYes').prop('checked', false);
        $('#radWasStudentNo').prop('checked', true);
        }
        else {
            $('#FulltimeStudentShow').hide();
        }
    });

    $("#chkdeparted").change(function () {
        if ($('#chkdeparted').prop('checked')) {
            $('#dtdateofdeathshow').show();
        }
        else {
            $('#dtdateofdeathshow').hide();
        $('#dtdateofdeath').val('');
        }

    });

    GetTaxPayer();

    $('#btnPrimaryFilerInfo').click(function () {
        if (PersistPrimaryFiller(true)) {

            if (filingStatus == 2) {
                window.location.href = '../PersonalInfo/spouseinfo.html';
            } else {
                window.location.href = '../PersonalInfo/address.html';
            }
        }
        return false;
    });


    $(function () {
        $("#popFirstName").popover({ title: '', content: "<h5>First Name</h5>Enter your first name. Should hold atleast 6 characters.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMiddleInitial").popover({ title: '', content: "<h5>Middle Initial</h5>Enter your initial.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>Last Name</h5>Last Name is your surname or your family name.Should hold atleast 6 characters.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNickName").popover({ title: '', content: "<h5>Nick Name</h5>An alternate name to refer a person other than his real name.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popOccupation").popover({ title: '', content: "<h5>Occupation</h5>Enter your own profession i.e if you are  a teacher, software engineer, lawyer, retired person, journalist etc..<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofBirth").popover({ title: '', content: "<h5>Date of Birth</h5>Select your date of birth from the date picker icon.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSocialSecurityNumber").popover({ title: '', content: "<h5>Social Security Number</h5>Unique 9-digit number assigned by IRS for identification purposes. Social security number appears in the format as XXX-XX- XXXX.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofDeath").popover({ title: '', content: "<h5>Date of Death</h5>If the tax payer has expired before filing the return, select the death date from the date picker icon.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    });

    $('#btnSubmitOne').click(function () {
        if ($("#primaryfilerinfo").valid()) {
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in ');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse accordion-toggle');
        $('#primaryinfo').removeClass('accordion-toggle').addClass('accordion-toggle  collapsed');
        $('#datebirth').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }

        return false;
       
    });

    $('#btnSubmitTwo').click(function () {
        if ($("#primaryfilerinfo").valid()) {
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#datebirth').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#election').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }
        return false;
    });

    $('#btnSubmitThree').click(function () {
        if ($("#primaryfilerinfo").valid()) {
        $('#collapseFour').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseThree').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#election').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#otherinformation').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }
        return false;
        
    });

});

function DateValidation() {
    if ($('#primaryfilerinfo').valid()) {
        return false;
    }
};

function GetTaxPayer() {
    $.ajax({
        url: serviceUrl + 'personalinfo/getprimarytaxpayer',
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

            if (data.Person != null) {
                $("#txtfirstname").val(data.Person.FirstName);
                $("#txtmiddleinitial").val(data.Person.MiddleInitial);
                $("#txtlastname").val(data.Person.LastName);
                $("#txtnickname").val(data.Person.NickName);
                $("#txtoccupation").val(data.Person.Occupation);

                $("#chkfirstname").prop("checked", data.Person.HasPrimaryFilerEcfContributed);

                if ($.datepicker.formatDate('mm/dd/yy', new Date(data.Person.DateOfBirth)) != '01/01/1900' &&
                    $.datepicker.formatDate('mm/dd/yy', new Date(data.Person.DateOfBirth)) != '01/01/1')
                    $("#dtdateofbirth").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Person.DateOfBirth)));
                $("#txtssn").val(data.Person.SSN);

                $("#chklegallybliend").prop("checked", data.Person.IsLegallyBlind);

                $("#chkdisabled").prop("checked", data.Person.IsDisabled);
                $("#chkclaimed").prop("checked", data.Person.HasClaimedAsDependent);
                $("#chkdeparted").prop("checked", data.Person.IsDied);


                if ($("#chkdeparted").prop("checked") == true) {
                    $("#dtdateofdeathshow").show();
                    if (data.Person.DateOfDeath != null) {
                        $("#dtdateofdeath").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Person.DateOfDeath)));
                    }
                } else {
                    $("#dtdateofdeath").val('');
                    $("#dtdateofdeathshow").hide();
                }

                $("#chkStudent").prop("checked", data.Person.IsStudent);

                if ($("#chkStudent").prop("checked") == true) {
                    $("#FulltimeStudentShow").show();
                } 

                $("#chkfulltimestudent").prop("checked", data.Person.IsFullTimeStudent);
                $("#radWasStudentYes").prop("checked", data.Person.IsFullTimeStudent);
                if ($("#radWasStudentYes").prop("checked") == false)
                    $("#radWasStudentNo").prop("checked", true);

                $("#chkfirstname").prop("checked", data.Person.HasPrimaryFilerEcfContributed);

                if (data.FilingStatus == 2) {
                    $("#lblSpouse").css("display", "block");
                    $("#chkspouse").prop("checked", data.Person.HasSpouseEcfContributed);
                } else {
                    $("#lblSpouse").hide();
                    $("#chkspouse").hide();
                    $("#chkspouse").prop("checked", false);
                }
            }

            if ((data == null && data.Person == null) || ((data.Person.NickName == null || data.Person.NickName == '') && (data.Person.FirstName == null || data.Person.FirstName == ''))) {
                $('.spanFillerName').html('Taxpayer');
            }
            else {
                if (data.Person.NickName != '')
                    $('.spanFillerName').html(data.Person.NickName);
                else if (data.Person.FirstName != '')
                    $('.spanFillerName').html(data.Person.FirstName);
            }

            filingStatus = data.FilingStatus;

            if (data.FilingStatus == 2) {
                $("#liSpouse").css("display", "block");
            }
        }
    });
        }


function PersistPrimaryFiller(isContinue) {
    if ($("#primaryfilerinfo").valid() == true) {
        var dataOfBirth;
        var dataOfDeath = null;
        if ($("#dtdateofbirth").val() == '')
            dataOfBirth = new Date('01/01/1900');
        else
            dataOfBirth = $("#dtdateofbirth").val();

        if ($('#chkdeparted').prop('checked') == true) {
            if ($("#dtdateofdeath").val() != '')
            dataOfDeath = $("#dtdateofdeath").val();
        }

        $.ajax({
            url: serviceUrl + 'personalinfo/primarytaxpayercreate',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "UserDataId": userDataId,
                "UserId": userId,
                "Topic": 'PrimaryFiler',
                "PrimaryTaxPayer":
                {
                    "FilingStatus": filingStatus, // filingStatus,TODO : Have to get filling status from session
                    "Person":
                    {
                        "PersonType": 1, // 1April Sathish Since Person Type is spouse it is hard coded
                        "FirstName": $("#txtfirstname").val(),
                        "MiddleInitial": $("#txtmiddleinitial").val(),
                        "LastName": $("#txtlastname").val(),
                        "NickName": $("#txtnickname").val(),
                        "Occupation": $("#txtoccupation").val(),
                        "DateOfBirth": dataOfBirth,
                        "SSN": $("#txtssn").val(),
                        "HasPrimaryFilerEcfContributed": $("#chkfirstname").prop("checked"),
                        "HasSpouseEcfContributed": $("#chkspouse").prop("checked"),
                        "IsLegallyBlind": $("#chklegallybliend").prop("checked"),
                        "IsDisabled": $("#chkdisabled").prop("checked"),
                        "HasClaimedAsDependent": $("#chkclaimed").prop("checked"),
                        "IsDied": $("#chkdeparted").prop("checked"),
                        "DateOfDeath": dataOfDeath,
                        "IsStudent": $("#chkStudent").prop("checked"),
                        "IsFullTimeStudent": $("#radWasStudentYes").prop("checked")
                    }
                }
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if ($("#txtnickname").val() != "")
                    window.sessionStorage.setItem('SignInName', $("#txtnickname").val());
                else if ($("#txtfirstname").val() != "")
                    window.sessionStorage.setItem('SignInName', $("#txtfirstname").val());
                else {
                    var userName = window.sessionStorage.getItem('UserName');
                    if (userName != null && userName != "")
                        window.sessionStorage.setItem('SignInName', userName);
                }

                //$('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
                window.sessionStorage.setItem("UserDataId", data.m_Item1);
                if (isContinue) {
                    //Commented in order to avoid navigating to diagnostics page
                    //return PageNavigate(data.m_Item2);
                    return true;
                }
                else {
                    GetTaxPayer();
                }
            }
        });
        return true;

    } else {
        return false;
    }
}

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        setTimeout(function () {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=PrimaryFiler';
        });
        return false;
    }
    else {
        return true;
    }
}
