//Script file for Spouse info
// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
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
    //Modified by prasana on 11.07.2014 changed "NumbersOnlyNotAcceptingDot" method for retricting the fields to accept dot.
    NumbersOnlyNotAcceptingDot('txtSSN');

    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();

    }

    $("#spouseinfo").validate({
        rules: {
            //commented by vivek on 15-july-14 removed all client side validation and used only server side validation
            ////dtdateofbirth:
            ////    {
            ////        validateDate: function () { $('#divDOBErrorMsg').html(''); true; },
            ////        validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html(''); true; }
            ////    },
            ////dtDOD:
            ////    {
            ////        validateDate: function () { $('#divDOBErrorMsg1').html(''); true; }
            ////    },
            txtSSN:
                {
                    minlength: 11,
                    validateSSN: true
                }
        },
        messages: {
            //commented by vivek on 15-july-14 removed all client side validation and used only server side validation
            //dtdateofbirth:
            //    {
            //        validateDate: function () { $('#divDOBErrorMsg').html('Enter a valid date'); },
            //        validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html('Your Spouse year of birth should not be greater than tax year'); }
            //    },
            //dtDOD:
            //   {
            //       validateDate: function () { $('#divDOBErrorMsg1').html('You have entered a invalid date'); }
            //   },
            txtSSN:
                {
                    minlength: "Invalid Spouse SSN",
                    validateSSN: "Invalid Spouse SSN"
                }
        }
    });


    if ($('#chkservedinMilitary').prop('checked')) {
        $('#divServedinMilitary').show();
    }
    else {
        $('#divServedinMilitary').hide();
    }
    //4-july-14 vivek added as per the latest spec 
    $('#chkservedinMilitary').change(function () {
        if ($('#chkservedinMilitary').prop('checked')) {
            $('#divServedinMilitary').show();

        }
        else {
            $('input[name=radservedinmilitary]').prop('checked', false);
            $('#dtdatedeployed').val('');
            $('#divOtherCombatZone').hide();
            $('#divServedinMilitary').hide();

        }
    });

    if ($('#radOtherCombat').prop('checked')) {

        $('#divOtherCombatZone').show();
    }
    else {
        $('#dtdatedeployed').val('');
        $('#divOtherCombatZone').hide();
    }  

    $('.spanservedinmilitary').html(SERVED_IN_MILITARY_DURING);//7-July-14 vivek for the served year
    //4-july-14 vivek added as per the latest spec 
    $('input[name=radservedinmilitary]').change(function () {
        if ($('#radOtherCombat').prop('checked')) {
            $('#divOtherCombatZone').show();
        }
        else {
            $('#dtdatedeployed').val('');
            $('#divOtherCombatZone').hide();
        }
    });

    $('#divdatedeployed').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divdatedeployed').on('changeDate', function (ev) {
        $(this).datepicker();

        //commented by vivek on 15-july-14 removed all client side validation and used only server side validation
        //if ($('#dtdatedeployed').val() != "") {

        //    var splittedDate = $('#dtdateofbirth').val().split('/');
        //    var mm = parseInt(splittedDate[0], 10);
        //    var dd = parseInt(splittedDate[1], 10);
        //    var yyyy = parseInt(splittedDate[2], 10);
        //    var newDate = new Date(yyyy, mm - 1, dd);
        //    var currentYear = (new Date).getFullYear();
        //if (newDate.getFullYear() >= currentYear) {
        //    $('#divDOBErrorMsg').html('Your year of birth should not be greater than tax year');
        //}
        //else {
        //    $('#divDOBErrorMsg').html('');
        //}
        //}
        //else {
        //$('#divDOBErrorMsg').html('Missing Date of Birth');
        //}
    });

    //Thileep added datepicker event on 12Jun2014
    //Bala StartDate added to restrict the selection of start date 07July14
    $('#divDateOfBirth').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divDateOfBirth').on('changeDate', function (ev) {
        $(this).datepicker();

        //commented by vivek on 15-july-14 removed all client side validation and used only server side validation
        //    $('#divDOBErrorMsg').html('');

        //    if ($('#dtdateofbirth').val() != "") {
        //        var splittedDate = $('#dtdateofbirth').val().split('/');
        //        var mm = parseInt(splittedDate[0], 10);
        //        var dd = parseInt(splittedDate[1], 10);
        //        var yyyy = parseInt(splittedDate[2], 10);
        //        var newDate = new Date(yyyy, mm - 1, dd);
        //        var currentYear = (new Date).getFullYear();
        //        if (newDate.getFullYear() >= currentYear) {
        //            $('#divDOBErrorMsg').html('Your Spouse year of birth should not be greater than tax year');
        //        }
        //        else {
        //            $('#divDOBErrorMsg').html('');
        //        }
        //    }
        //    else {
        //        $('#divDOBErrorMsg').html('Missing Date of Birth');
        //    }
    });

    //Thileep added datepicker event on 12Jun2014
    //Bala StartDate added to restrict the selection of start date 07July14
    $('#divDateOfDeath').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); },
    });

    $('#divDateOfDeath').on('changeDate', function (ev) {
        $(this).datepicker('hide');
        //$('#divDOBErrorMsg1').html('');

        //if ($('#dtDOD').val() != "") {
        //    $('#divDOBErrorMsg1').html('');
        //}
        //else {
        //    $('#divDOBErrorMsg1').html('Missing Date of Death');
        //}
    });
    //vivek 30-june-14 for the calendar focus
    $('#txtlastname').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#txtSSN').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chkstudent').focusin(function () {
        $('#divDateOfDeath').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chkClaimed').focusin(function () {
        $('#divDateOfDeath').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('.spanCurrentYear').html(CURRENT_TAX_YEAR);

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
        $("#popFirstName").popover({ title: '', content: "<h5>What is your Spouse's First Name?</h5>First name is your Spouse's given name or personal name. <br />Your First Name is often used by people during an informal conversation. <br />E.g., if your Spouse's full name is Jane Blake Watts. Jane will be the First Name.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMiddleName").popover({ title: '', content: "<h5>What is your Spouse's Middle Initial?</h5>It's nothing but the first letter of your Spouse's Middle Name. <br />E.g., if your Spouse's full name is Jane Blake Watts. B from Blake will be the Middle Initial.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>What is your Spouse's Last Name?</h5>Last name is your Spouse's Family Name or Surname. <br />Last Name is often used by people during formal conversation. <br />E.g., if your Spouse's full name is Jane Blake Watts. Watts will be the Last Name.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateOfBirth").popover({ title: '', content: "<h5>Why do we need your Spouse's Date of Birth?</h5>Your Spouse's Date of Birth is a mandatory information for tax filing purposes. <br />No worries! All sensitive information are maintained with strict data protection.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSSN").popover({ title: '', content: "<h5>Why do we need your Spouse's SSN?</h5>Social Security Number is used to identify their Citizenship or Lawful Alien Status. It is a mandatory information to file your tax return. <br />No worries! We maintain your sensitive information with stringent data security process.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popOccupation").popover({ title: '', content: "<h5>How to determine your Spouse's Occupation?</h5>Your Spouse's occupation is what he/she does for a living or their main source of income. <br />No worries! All personal information are maintained under strict data protection. <br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateOfDeath").popover({ title: '', content: "<h5>What is your Spouse’s Date of Death?</h5>We are sorry about your loss! <br />Date of Death is the exact date on which your Spouse breathed their last. <br />It is with which a final return is filed on behalf of the deceased. <br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popStateCode").popover({ title: '', content: "<h5>State Name</h5>Enter the name of the state where Spouse lived in 2014.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        //vivek 8-July-2014 Added the Quick Helper as per the latest spec 2.4
        $("#popDateOfDeploy").popover({ title: '', content: "<h5>Date of Deploy</h5>Select your spouse date of deploy from the date picker icon.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
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

                if (data.Spouse.HasLivedInAnotherState) {
                    $("#chkspouselived").prop("checked", data.Spouse.HasLivedInAnotherState);
                    if ($("#chkspouselived").prop("checked") == true) {
                        $("#divState").show();
                    }
                    if (data.Spouse.LivedInAnotherState != null)
                        {// 09Jul2014 Sathsih checked null reference
                        $("#ddlStateCode").val(data.Spouse.LivedInAnotherState.StateId);
                        if (parameterName != undefined && parameterName.length == 2) {
                            if (parameterName[1] == "ddlStateCode" && $("#ddlStateCode").val() == 0)
                                $('#ddlStateCode').focus();
                        }
                    }
                }



                personId = data.Spouse.Person.PersonId;
                if (data.Spouse.Person.IsMilitary == true) {
                    if ($('#chkservedinMilitary').prop("checked", data.Spouse.Person.IsMilitary)) {
                        $('#divServedinMilitary').show();
                    }
                    else {
                        $('#divServedinMilitary').hide();
                    }
                }
                if (data.Spouse.Person.ServedInMilitary > 0) {
                    $('input:radio[name=radservedinmilitary]')[data.Spouse.Person.ServedInMilitary - 1].checked = true;


                    if (data.Spouse.Person.ServedInMilitary == 13) {

                        $('#divOtherCombatZone').show();

                        if (data.Spouse.Person.DateOfDeployed != null && $.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfDeployed)) != '01/01/1900'
                           && $.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfDeployed)) != '01/01/1')
                            $("#dtdatedeployed").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Spouse.Person.DateOfDeployed)));

                        if (parameterName != undefined && parameterName.length == 2) {
                            if (parameterName[1] == "dtdatedeployed" && $("#dtdatedeployed").val() == '')
                                $('#dtdatedeployed').focus();
                        }
                    }
                }

                if ((data.Spouse.Person.NickName == null || data.Spouse.Person.NickName == '') && (data.Spouse.Person.FirstName == null || data.Spouse.Person.FirstName == '')) {

                    $("#lblSpouseNameIsBlind").html("Spouse");
                    $("#lblSpouseNameIsDisabled").html("Spouse");
                    $("#lblSpouseNameWasStuedent").html("Spouse");
                    $('#lblServedinmilitary').html("Spouse ");
                    $("#lblServedinmilitaryduring").html("Spouse ");
                    $("#lblcombatzone").html("Spouse");

                } else {

                    if (data.Spouse.Person.NickName != null && data.Spouse.Person.NickName != '') {
                        $("#lblSpouseNameIsBlind").html(data.Spouse.Person.NickName);
                        $("#lblSpouseNameIsDisabled").html(data.Spouse.Person.NickName);
                        $("#lblSpouseNameWasStuedent").html(data.Spouse.Person.NickName);
                        $('#lblServedinmilitary').html(data.Spouse.Person.NickName + " ");
                        $("#lblServedinmilitaryduring").html(data.Spouse.Person.NickName + " ");
                        $("#lblcombatzone").html(data.Spouse.Person.NickName);
                    }
                    else {
                        $("#lblSpouseNameIsBlind").html(data.Spouse.Person.FirstName);
                        $("#lblSpouseNameIsDisabled").html(data.Spouse.Person.FirstName);
                        $("#lblSpouseNameWasStuedent").html(data.Spouse.Person.FirstName);
                        $('#lblServedinmilitary').html(data.Spouse.Person.FirstName + " ");
                        $("#lblServedinmilitaryduring").html(data.Spouse.Person.FirstName + " ");
                        $("#lblcombatzone").html(data.Spouse.Person.FirstName);
                    }
                }
            }
            else {

                $("#lblSpouseNameIsBlind").html("Spouse");
                $("#lblSpouseNameIsDisabled").html("Spouse");
                $("#lblSpouseNameWasStuedent").html("Spouse");
                $('#lblServedinmilitary').html("Spouse");
                $("#lblServedinmilitaryduring").html('Spouse');
            }


            //Vincent - 9-July-14 getting spouse  first name last name
            if ((data == null || data.Spouse == null || data.Spouse.Person == null) || ((data.Spouse.Person.NickName == null || data.Spouse.Person.NickName == '') && (data.Spouse.Person.FirstName == null || data.Spouse.Person.FirstName == ''))) {
                $('.spanFillerName').html('Spouse');
            }
            else {
                //Yogalakshmi - 11th July 2014 - Defect Fix for TAX1040-14147 - Checked for null
                if (data.Spouse.Person.NickName != null && data.Spouse.Person.NickName != '')
                    $('.spanFillerName').html(data.Spouse.Person.NickName);
                else if (data.Spouse.Person.FirstName != null && data.Spouse.Person.FirstName != '')
                    $('.spanFillerName').html(data.Spouse.Person.FirstName);
            }
        }
    });
}

function PersistSpouseInfo(isContinue) {
    var dataOfBirth;
    var dataOfDeath = null;
    var dateOfDeployed = null;
    var servedInMIlitary = 0;
    if ($("#dtdateofbirth").val() == '')
        dataOfBirth = new Date('01/01/1900');
    else
        dataOfBirth = $("#dtdateofbirth").val();

    if ($('#chkIsDied').prop('checked') == true) {
        if ($("#dtDOD").val() != '')
            dataOfDeath = $("#dtDOD").val();
    }
    if ($('#chkservedinMilitary').prop("checked")) {

        servedInMIlitary = $("input:radio[name=radservedinmilitary]:checked").val();

        if ($('#dtdatedeployed').val() != '') {
            dateOfDeployed = $('#dtdatedeployed').val();
        }
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
                    LivedInAnotherState: {
                        "StateId": $("#ddlStateCode").val(),
                        "StateName": $("#ddlStateCode option:selected").text()
                    },
                    "Person":
                    {
                        //Modified by prasana for triming the text boxes on 24.06.2014
                        "PersonType": 2, // 28Mar2014 Sathish Since Person Type is spouce it is hard coded
                        "PersonId": personId,
                        "FirstName": $.trim($("#txtfirstname").val()),
                        "MiddleInitial": $("#txtmiddleinitial").val(),
                        "LastName": $.trim($("#txtlastname").val()),
                        "DateOfBirth": dataOfBirth,
                        "SSN": $("#txtSSN").val(),
                        "Occupation": $.trim($("#txtoccupation").val()),
                        "IsLegallyBlind": $("#chkSpouseBlind").prop("checked"),
                        "IsDisabled": $("#chkSpouseDisablie").prop("checked"),
                        "HasClaimedAsDependent": $("#chkClaimed").prop("checked"),
                        "IsDied": $("#chkIsDied").prop("checked"),
                        "DateOfDeath": dataOfDeath,
                        "IsStudent": $("#chkstudent").prop("checked"),
                        "IsFullTimeStudent": $("#radWasStudentYes").prop("checked"),
                        "IsMilitary": $('#chkservedinMilitary').prop("checked"),//vivek 4-July-14 for the new property
                        "ServedInMilitary": servedInMIlitary,//vivek 4-July-14 for the new property
                        "DateOfDeployed": dateOfDeployed//vivek 4-July-14 for the new property
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
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            window.location.href = '../Review/finalsummary.html?Topic=Spouse';
        });

        return false;
    }
    else {
        return true;
    }
}
