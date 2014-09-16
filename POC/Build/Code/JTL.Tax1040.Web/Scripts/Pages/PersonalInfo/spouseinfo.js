﻿//Script file for Spouse info
var personId;
var pageURL;
var parameterName;
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    LettersAndSpaceOnly('txtoccupation');
    LettersAndSpaceOnly('txtfirstname');
    LettersAndSpaceOnly('txtlastname');
    LettersOnly('txtmiddleinitial');
    NumbersOnly('txtSSN');
    $("#spouseinfo").validate({
        rules: {
            dtdateofbirth:
                {
                    validateDate: function () { $('#divDOBErrorMsg').html(''); true; },
                    validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html(''); true; }
                },
            dtDOD:
                {
                    validateDate: function () { $('#divDOBErrorMsg1').html(''); true; }
                },
            txtSSN:
                {
                    minlength: 11,
                    validateSSN: true
                }
        },
        messages: {

            dtdateofbirth:
                {
                    validateDate: function () { $('#divDOBErrorMsg').html('Enter a valid date'); },
                    validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html('Your Spouse year of birth should not be greater than tax year'); }
                },
            dtDOD:
               {
                   validateDate: function () { $('#divDOBErrorMsg1').html('You have entered a invalid date'); }
               },
            txtSSN:
                {
                    minlength: "Invalid Spouse SSN",
                    validateSSN: "Invalid Spouse SSN"
                }
        }
    });

    //Thileep added datepicker event on 12Jun2014
    $('#divDateOfBirth').datepicker({
        format: "mm/dd/yyyy",
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divDateOfBirth').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divDOBErrorMsg').html('');

        if ($('#dtdateofbirth').val() != "") {
            var splittedDate = $('#dtdateofbirth').val().split('/');
            var mm = parseInt(splittedDate[0], 10);
            var dd = parseInt(splittedDate[1], 10);
            var yyyy = parseInt(splittedDate[2], 10);
            var newDate = new Date(yyyy, mm - 1, dd);
            var currentYear = (new Date).getFullYear();
            if (newDate.getFullYear() >= currentYear) {
                $('#divDOBErrorMsg').html('Your Spouse year of birth should not be greater than tax year');
            }
            else {
                $('#divDOBErrorMsg').html('');
            }
        }
        else {
            $('#divDOBErrorMsg').html('Missing Date of Birth');
        }
    });

    //Thileep added datepicker event on 12Jun2014
    $('#divDateOfDeath').datepicker({
        format: "mm/dd/yyyy",
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); },
    });

    $('#divDateOfDeath').on('changeDate', function (ev) {
        $(this).datepicker('hide');
        $('#divDOBErrorMsg1').html('');

        if ($('#dtDOD').val() != "") {
            $('#divDOBErrorMsg1').html('');
        }
        else {
            $('#divDOBErrorMsg1').html('Missing Date of Death');
        }
    });


    $('.spanCurrentYear').html(CURRENT_TAX_YEAR);


    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();

    }

    personId = 0;


    $('#divDataofdeath').hide();
    $('#divStudent').hide();
    $('#chkIsDied').change(function () {
        if ($('#chkIsDied').prop('checked') == true) {
            $('#divDataofdeath').show();
            $('#dtDOD').val('');
        }
        else {
            $('#divDataofdeath').hide();
        }
        //$('#divDataofdeath').toggle();
        //$('#dtDOD').val('');
    });
    $('#chkstudent').change(function () {
        if ($('#chkstudent').prop('checked') == true) {
            $('#divStudent').show();
            $('#radWasStudentYes').prop('checked', false);
            $('#radWasStudentNo').prop('checked', true);
        }
        else {
            $('#divStudent').hide();

        }


    });

    $.ajax({
        url: serviceUrl + 'personalinfo/getstate',
        async: false,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlStateCode").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlStateCode").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });


    $("#divState").hide();
    $("#chkspouselived").change(function () {
        if ($("#chkspouselived").prop('checked') == true)
            $("#divState").show();
        else {
            $("#divState").hide();
            $("#ddlStateCode").val(0);
        }
    });


    GetSpouse();

    $('#btnPersistSpouseInfo').click(function () {
        if (PersistSpouseInfo(true)) {
            window.location.href = '../PersonalInfo/address.html';
        }
        return false;
    });

    $('#btnBackSpouseInfo').click(function () {
        PersistSpouseInfo(true);
        GoToPreviousPage();
        return false;
    });

    $(function () {
        //Changes done by Yogalakshmi on 16th May 2014
        $("#popFirstName").popover({ title: '', content: "<h5>First Name</h5>First Name of your spouse.Should hold atleast 6 characters.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMiddleName").popover({ title: '', content: "<h5>Middle Initial</h5>Enter your spouse initial.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>Last Name</h5>Last Name of your spouse which is the surname or family name.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateOfBirth").popover({ title: '', content: "<h5>Date of Birth</h5>Select your spouse date of birth from the date picker icon.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSSN").popover({ title: '', content: "<h5>Social Security Number</h5>Unique 9 digit SSN number of your spouse.You can find SSN nine digits in the format as XXX-XX-XXXX.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popOccupation").popover({ title: '', content: "<h5>Occupation</h5>Mention your spouse profession.If he/she is a teacher,lawyer, retired person, police,journalist etc..<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateOfDeath").popover({ title: '', content: "<h5>Date of Death</h5>If your spouse has expired before filing the tax return, select the death date from date picker icon.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popStateCode").popover({ title: '', content: "<h5>State Name</h5>Enter the name of the state where Spouse lived in 2014.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    });


    $('#btnSubmitOne').click(function () {
        if ($('#spouseinfo').valid()) {
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#collpselinkone').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
            $('#collpselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
                        
        }
        return false;
    });

});
//function DateValidation() {
//    if ($('#spouseinfo').valid()) {
//        return false;
//    }
//}
function GetSpouse() {
    $.ajax({
        url: serviceUrl + 'personalinfo/getspouseinfo',
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

            if (data.FilingStatus == 2) {
                $("#liSpouse").css("display", "inline");
            }

            if (data != null && data.Spouse != null && data.Spouse.Person != null) {

                $("#txtfirstname").val(data.Spouse.Person.FirstName);
                $("#txtmiddleinitial").val(data.Spouse.Person.MiddleInitial);
                $("#txtlastname").val(data.Spouse.Person.LastName);

                if ($.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfBirth)) != '01/01/1900'
                    && $.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfBirth)) != '01/01/1')
                    $("#dtdateofbirth").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfBirth)));

                $("#txtSSN").val(data.Spouse.Person.SSN);
                $("#txtoccupation").val(data.Spouse.Person.Occupation);

                $("#chkSpouseBlind").prop("checked", data.Spouse.Person.IsLegallyBlind);
                $("#chkSpouseDisablie").prop("checked", data.Spouse.Person.IsDisabled);
                $("#chkClaimed").prop("checked", data.Spouse.Person.HasClaimedAsDependent);
                $("#chkIsDied").prop("checked", data.Spouse.Person.IsDied);
                if (data.Spouse.Person.IsDied == true) {
                    $('#divDataofdeath').show();
                } else {
                    $('#divDataofdeath').hide();
                }
                if (data.Spouse.Person.DateOfDeath != null)
                    $("#dtDOD").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfDeath)));
                else
                    $("#dtDOD").val('');
                $("#chkstudent").prop("checked", data.Spouse.Person.IsStudent);
                if (data.Spouse.Person.IsStudent == true) {
                    $('#divStudent').show();
                }
                else {
                    $('#divStudent').hide();
                }
                //$('#chkstudent').trigger('change');
                $("#radWasStudentYes").prop("checked", data.Spouse.Person.IsFullTimeStudent);
                if ($("#radWasStudentYes").prop("checked") == false)
                    $("#radWasStudentNo").prop("checked", true);


                $("#chkspouselived").prop("checked", data.Spouse.HasLivedInAnotherState);
                $("#ddlStateCode").val(data.Spouse.LivedInAnotherStateId);


                if ($("#chkspouselived").prop("checked") == true) {
                    $("#divState").show();
                }

                personId = data.Spouse.Person.PersonId;



                if ((data.Spouse.Person.NickName == null || data.Spouse.Person.NickName == '') && (data.Spouse.Person.FirstName == null || data.Spouse.Person.FirstName == '')) {

                    $("#lblSpouseNameIsBlind").html("Spouse");
                    $("#lblSpouseNameIsDisabled").html("Spouse");
                    $("#lblSpouseNameWasStuedent").html("Spouse");

                } else {

                    if (data.Spouse.Person.NickName != null && data.Spouse.Person.NickName != '') {
                        $("#lblSpouseNameIsBlind").html(data.Spouse.Person.NickName);
                        $("#lblSpouseNameIsDisabled").html(data.Spouse.Person.NickName);
                        $("#lblSpouseNameWasStuedent").html(data.Spouse.Person.NickName);
                    }
                    else {
                        $("#lblSpouseNameIsBlind").html(data.Spouse.Person.FirstName);
                        $("#lblSpouseNameIsDisabled").html(data.Spouse.Person.FirstName);
                        $("#lblSpouseNameWasStuedent").html(data.Spouse.Person.FirstName);
                    }
                }
            }
            else {

                $("#lblSpouseNameIsBlind").html("Spouse");
                $("#lblSpouseNameIsDisabled").html("Spouse");
                $("#lblSpouseNameWasStuedent").html("Spouse");
            }
        }
    });
}

function PersistSpouseInfo(isContinue) {
    var dataOfBirth;
    var dataOfDeath = null;
    if ($("#dtdateofbirth").val() == '')
        dataOfBirth = new Date('01/01/1900');
    else
        dataOfBirth = $("#dtdateofbirth").val();

    if ($('#chkIsDied').prop('checked') == true) {
        if ($("#dtDOD").val() != '')
            dataOfDeath = $("#dtDOD").val();
    }

    if ($("#spouseinfo").valid() == true) {
        $.ajax({
            url: serviceUrl + 'personalinfo/spouse',
            async: false,
            dataType: "json",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "userDataId": userDataId,
                "userId": userId,
                "Spouse": {
                    "HasLivedInAnotherState": $("#chkspouselived").prop("checked"),
                    "LivedInAnotherStateId": $("#ddlStateCode").val(),
                    "Person":
                    {
                        //Modified by prasana for triming the text boxes on 24.06.2014
                        "PersonType": 2, // 28Mar2014 Sathish Since Person Type is spouce it is hard coded
                        "PersonId": personId,
                        "FirstName": $.trim($("#txtfirstname").val()),
                        "MiddleInitial": $("#txtmiddleinitial").val(),
                        "LastName":  $.trim($("#txtlastname").val()),
                        "DateOfBirth": dataOfBirth,
                        "SSN": $("#txtSSN").val(),
                        "Occupation": $.trim($("#txtoccupation").val()),
                        "IsLegallyBlind": $("#chkSpouseBlind").prop("checked"),
                        "IsDisabled": $("#chkSpouseDisablie").prop("checked"),
                        "HasClaimedAsDependent": $("#chkClaimed").prop("checked"),
                        "IsDied": $("#chkIsDied").prop("checked"),
                        "DateOfDeath": dataOfDeath,
                        "IsStudent": $("#chkstudent").prop("checked"),
                        "IsFullTimeStudent": $("#radWasStudentYes").prop("checked")
                    }
                }
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("UserDataId", data.m_Item1);
                if (isContinue) {
                    //Commented in order to avoid navigating to diagnostics page
                    //return PageNavigate(data.m_Item2);
                    return true;
                }
                else {
                    GetSpouse();
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
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=Spouse';
        });

        return false;
    }
    else {
        return true;
    }
}
