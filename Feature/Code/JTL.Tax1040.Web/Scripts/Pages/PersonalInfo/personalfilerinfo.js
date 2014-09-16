﻿//Scripts for primary Filer info
var filingStatus;
var pageURL;
var parameterName;
//Vincent-25Aug2014-Added a new Variable for Error tool tip 
var controlToFocus = '';
var divToExpand = '';
$(document).ready(function () {
    LettersAndSpaceOnly('txtfirstname');
    LettersAndSpaceOnly('txtlastname');
    //Yogalakshmi - 11th June 2014 - Allows only characters and space
    LettersAndSpaceOnly('txtnickname');
    //Modified by prasana on 11.07.2014 changed "NumbersOnlyNotAcceptingDot" method for retricting the fields to accept dot.
    NumbersOnlyNotAcceptingDot('txtssn');
    LettersOnly('txtmiddleinitial');
    LettersAndSpaceOnly('txtoccupation');
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    
    $('#dtdateofdeathshow').hide();
    //8-july-14 vivek hide the spouse for the default 
    $("#lblSpouse").hide();
    $('.error').hide();
    $('.spanCurrentYear').html(CURRENT_TAX_YEAR);
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

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
    
    $('.spanservedinmilitary').html(SERVED_IN_MILITARY_DURING);//7-July-14 vivek for the served year
    //7-July-14 vivek added for the date picker 
    $('#divDatedeployed').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });
    //7-July-14 vivek added for the date picker 
    $('#divDatedeployed').on('changeDate', function (ev) {
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
    $("#primaryfilerinfo").validate({
        rules: {
            //commented by vivek on 15-july-14 removed all client side validation and used only server side validation
            //dtdateofbirth:
            //    {
            //        validateDate: function () { $('#divDOBErrorMsg').html(''); true; },
            //        validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html(''); true; }
            //    },
            //dtdateofdeath:
            //    {
            //        validateDate: function () { $('#divDODErrorMsg').html(''); true; }
            //    },
            txtssn:
              {
                  minlength: 11,
                  validateSSN: true
              }
            
        },
        messages: {
            //comented by vivek on 15-july-14 removed all client side validation and used only server side validation
            //dtdateofbirth:
            //    {
            //        validateDate: function () { $('#divDOBErrorMsg').html('Enter a valid date'); },
            //        validateyearlessthantaxyear: function () { $('#divDOBErrorMsg').html('Your year of birth should not be greater than tax year'); }
            //    },
            //dtdateofdeath:
            //    {
            //        validateDate: function () { $('#divDODErrorMsg').html('Enter a valid date'); }
            //    },
            txtssn: {
                minlength: "Taxpayer SSN/ITIN is invalid.",
                validateSSN: "Taxpayer SSN/ITIN is invalid."
            }
            
        }
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
    //commented by vivek on 15-july-14 removed all client side validation and used only server side validation

    $('#divDateOfBirth').on('changeDate', function (ev) {     
        $(this).datepicker();
    //    $('#divDOBErrorMsg').html('');

    //    if ($('#dtdateofbirth').val() != "") {

    //        var splittedDate = $('#dtdateofbirth').val().split('/');
    //        var mm = parseInt(splittedDate[0], 10);
    //        var dd = parseInt(splittedDate[1], 10);
    //        var yyyy = parseInt(splittedDate[2], 10);
    //        var newDate = new Date(yyyy, mm - 1, dd);
    //        var currentYear = (new Date).getFullYear();
    //        if (newDate.getFullYear() >= currentYear) {
    //            $('#divDOBErrorMsg').html('Your year of birth should not be greater than tax year');
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
        $(this).datepicker();
        //commented by vivek on 15-july-14 removed all client side validation and used  only server side validation
        //$('#divDODErrorMsg').html('');

        //if ($('#dtdateofdeath').val() != "") {
        //    $('#divDODErrorMsg').html('');
        //}
        //else {
            
            //$('#divDODErrorMsg').html('Missing Date of Death');
        //}
    });
    //vivek 30-june-14 for the calendar focus
    $('#txtssn').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });

    //22Aug15, Bhavani code implemented for fixing Defect#14516
    $('#btnSubmitTwo').focusin(function () {
        $('#divDateOfBirth').datepicker('hide');
    });

    //vivek 30-june-14 for the calendar focus
    $('#chkStudent').focusin(function () {
        $('#divDateOfDeath').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chkclaimed').focusin(function () {
        $('#divDateOfDeath').datepicker('hide');
    });
    //vivek 30-Aug-14 for the calander focus
    $('#radOtherCombat').focusin(function () {
        $('#dtdatedeployed').datepicker('hide');
    });
    $('#chkdeparted').focusin(function () {
        $('#divDateOfDeath').datepicker('hide');
    });
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
    $('#btnPrimaryFilerInfo').focusin(function () {
        $('#dtdatedeployed').datepicker('hide');
    });
    
    ////////Vivek - 12-Aug-14 for date picker hide while Curser focus out for date of birth
    //$('#dtdateofbirth').focusout(function () {
    //    var $curr = $(".datepicker datepicker-dropdown dropdown-menu datepicker-orient-left datepicker-orient-top");
    //    $('.datepicker datepicker-dropdown dropdown-menu datepicker-orient-left datepicker-orient-top').attr("checked")
    //    //if ($('.datepicker datepicker-dropdown dropdown-menu datepicker-orient-left datepicker-orient-top').val() == undefined) {
    //    //    $('#divDateOfBirth').datepicker('show');
    //    //}
    //    //else {
    //    //    $('#divDateOfBirth').datepicker('hide');
    //    //}
    //});
    //////Vivek - 12-Aug-14 for date picker hide while Curser focus out for date of deployed
    ////$('#dtdatedeployed').focusout(function () {
    ////    $('#divDatedeployed').datepicker('hide');
    ////});
    //////Vivek - 12-Aug-14 for date picker hide while Curser focus out for date of death
    ////$('#dtdateofdeath').focusout(function () {
    ////    $('#divDateOfDeath').datepicker('hide');
    ////});
    $("#chkdeparted").change(function () {
        if ($('#chkdeparted').prop('checked')) {
            $('#dtdateofdeathshow').show();
        }
        else {
            $('#dtdateofdeathshow').hide();
            $('#dtdateofdeath').val('');
        }

    });
   
    

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

    //Vincent-5Aug2014-made a changes in quick help Scenario 
    $(function () {
        $("#popFirstName").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>What is your First Name?</h5>First name is your given name or personal name.<br /><br />Your First Name is often used by people in an informal situation. <br/><br/>E.g., if your full name is Luke Blake Watts. Luke will be the First Name.<br /><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMiddleInitial").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>What is your Middle Initial? </h5>It's nothing but the first letter of your Middle Name. <br/><br />E.g., if your full name is Luke Blake Watts. B from Blake will be the Middle Initial.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>What is your Last Name? </h5>Last name is your Family Name or Surname. <br/><br/> Your Last Name is often used by people during formal situation. <br/><br/>E.g., if your full name is Luke Blake Watts. <strong>Watts</strong> will be the Last Name.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popNickName").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>Why do we need your Nickname?</h5>Your Nick Name is used by TaxGarden to address you in a cordial manner. <br/><br />We prefer keeping our clients comfy in every way possible. <br/><br />Not to worry, as we will always use your Full Name for all tax filing purposes.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popOccupation").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>How to determine your Occupation?</h5>Tell us what you do for a living and your main source of income. <br/><br />Don't worry, this information doesn't affect your tax returns.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofBirth").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>Why do we need your Date of Birth?</h5>Your Date of Birth is a mandatory information for tax filing purposes. <br/><br />No worries! All your sensitive information are maintained with strict data protection. <br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSocialSecurityNumber").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>Why do we need your SSN?</h5>Social Security Number is used to identify your citizenship or Lawful alien Status. It is a mandatory information to file your tax return. <br/><br />No worries! Sensitive information like SSN/ITIN is maintained with strict data protection.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popDateofDeath").popover({ title: 'Quick Help', html: 'true', html: 'true', content: "<h5>What is the Taxpayer's Date of Death?</h5>We are sorry about your loss! <br/><br />Date of Death is the exact date on which the Taxpayer breathed their last. <br/><br />It is with which a final return is filed on behalf of the deceased. <br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        //vivek 8-July-2014 Added the Quick Helper as per the latest spec 2.4
        $("#popDateOfDeploy").popover({ title: 'Quick Help', html: 'true', content: "<h5>Date of Deploy</h5>Select your spouse date of deploy from the date picker icon.<br/><br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

    $('#btnSubmitOne').click(function () {
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#primaryinfo').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#aSsnbirth').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');

        if ($("#primaryfilerinfo").valid()) {

        }
            //window.location.href = '../../../PersonalInfo/primaryfilerinfo.html?collapseTwo-';

            //    var sigInName = window.sessionStorage.getItem('SignInName');
            //    if (sigInName.indexOf('@') > 0) {
            //        sigInName = sigInName.substring(0, sigInName.indexOf('@'));
            //        sigInName = sigInName.substring(0, 6);
            //    }
            //    userName = 'Hi ' + sigInName;
            //}
            //$('#lblSignInUserName').html(userName);

            //Changed by Thileep 01July2014 for Signinname display
            var sigInName = window.sessionStorage.getItem('SignInName');

            if (sigInName.indexOf('@') >= 0) {
                sigInName = sigInName.substring(0, sigInName.indexOf('@'));
                sigInName = sigInName.substring(0, 6);
                userName = 'Hi ' + sigInName;
            }

            else {
                sigInName = sigInName.substring(0, 6);
                userName = 'Hi ' + sigInName;
            }
            $('#lblSignInUserName').html(userName);
        return false;
    });

    $('#btnchromeenter').click(function () {
         if ($('#collapseOne').attr('class') == 'panel-collapse collapse in') {
            $('#btnSubmitOne').click();
            return false;
        }
        else if ($('#collapseTwo').attr('class') == 'panel-collapse collapse in') {
            $('#btnSubmitTwo').click();
            return false;
        }
        else if ($('#collapseThree').attr('class') == 'panel-collapse collapse in') {
            $('#btnSubmitThree').click();
            return false;
        }
        else if ($('#collapseFour').attr('class') == 'panel-collapse collapse in') {
            $('#btnPrimaryFilerInfo').click();
            return false;
        }
    });

    $('#btnSubmitTwo').click(function () {
        if ($("#primaryfilerinfo").valid()) {
            //To Do
        }
            $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#aSsnbirth').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
            $('#election').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
            validatePersonalFilerSecondAccordion();
            getErrorCountAndDisableBreadcrum();
        return false;
    });

    $('#btnSubmitThree').click(function () {
        if ($("#primaryfilerinfo").valid()) {
            //To Do
        }
            $('#collapseFour').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseThree').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#election').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
            $('#otherinformation').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
            return false;

    });


    //18Aug2014-Thileep Added Code on Accordion open,Collapse Functionalities
    $('#collapseOne').on('hidden.bs.collapse', function () {
        PersistPrimaryFiller(false);
        return false;
    });

    $('#collapseOne').on('shown.bs.collapse', function () {
        $('#primaryfilerinfo').valid();
    });

    $('#collapseTwo').on('hidden.bs.collapse', function () {
        validatePersonalFilerSecondAccordion();
        PersistPrimaryFiller(false);
        return false;
    });

    $('#collapseTwo').on('shown.bs.collapse', function () {
        if (!$('#primaryfilerinfo').valid()) {
            validatePersonalFilerSecondAccordion();
        }
    });

    $('#collapseThree').on('hidden.bs.collapse', function () {
        PersistPrimaryFiller(false);
        return false;
    });

    $('#collapseThree').on('shown.bs.collapse', function () {
        $('#primaryfilerinfo').valid();
    });
    $('#collapseFour').on('hidden.bs.collapse', function () {
        PersistPrimaryFiller(false);
        return false;
    });

    $('#collapseFour').on('shown.bs.collapse', function () {
        $('#primaryfilerinfo').valid();
    });

   
    //20Aug14, Bala, Validate client side validation during page load
    validatePersonalFilerSecondAccordion();

    //Vincent-26 Augest-Made required changes for Control focus as error tool tip check
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        divToExpand = parameterName[0];
        controlToFocus = parameterName[1];
   }

    GetTaxPayer();

    if (divToExpand != '' && controlToFocus != '') {
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
    

});

function DateValidation() {
    if ($('#primaryfilerinfo').valid()) {
        return false;
    }
};

//Bala, 20Aug2014, Showing error icon in accordian
function validatePersonalFilerSecondAccordion() {
    var validator = $('#primaryfilerinfo').validate();

    if (validator.invalid.txtssn == undefined ) {
        //No error in this accordion.
        $('#aSsnbirth').removeClass('error');
    }
    else {
        $('#aSsnbirth').addClass('error');
    }
}


function GetTaxPayer() {

    LoadUserIDandUserDataID();

    $.ajax({
        url: serviceUrl + 'personalinfo/getprimarytaxpayerwitherrorlist',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data.m_Item1.Person != null) {
                $("#txtfirstname").val(data.m_Item1.Person.FirstName);
                $("#txtmiddleinitial").val(data.m_Item1.Person.MiddleInitial);
                $("#txtlastname").val(data.m_Item1.Person.LastName);
                $("#txtnickname").val(data.m_Item1.Person.NickName);
                $("#txtoccupation").val(data.m_Item1.Person.Occupation);

                $("#chkfirstname").prop("checked", data.m_Item1.Person.HasPrimaryFilerEcfContributed);

                if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfBirth)) != '01/01/1900' &&
                    $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfBirth)) != '01/01/1') {
                    $("#dtdateofbirth").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfBirth)));
                    $('#divDateOfBirth').datepicker('update', $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfBirth)));
                }
                $("#txtssn").val(data.m_Item1.Person.SSN);

                $("#chklegallybliend").prop("checked", data.m_Item1.Person.IsLegallyBlind);

                $("#chkdisabled").prop("checked", data.m_Item1.Person.IsDisabled);
                $("#chkclaimed").prop("checked", data.m_Item1.Person.HasClaimedAsDependent);
                $("#chkdeparted").prop("checked", data.m_Item1.Person.IsDied);


                if ($("#chkdeparted").prop("checked") == true) {
                    $("#dtdateofdeathshow").show();
                    if (data.m_Item1.Person.DateOfDeath != null) {
                        $("#dtdateofdeath").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfDeath)));
                        $('#divDateOfDeath').datepicker('update', $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfDeath)));
                    }
                } else {
                    $("#dtdateofdeath").val('');
                    $("#dtdateofdeathshow").hide();
                }

                $("#chkStudent").prop("checked", data.m_Item1.Person.IsStudent);

                if ($("#chkStudent").prop("checked") == true) {
                    $("#FulltimeStudentShow").show();
                }
                if (data.m_Item1.Person.IsMilitary == true) {
                    if ($('#chkservedinMilitary').prop("checked", data.m_Item1.Person.IsMilitary)) {
                        $('#divServedinMilitary').show();
                    }
                } else {
                    $('#divOtherCombatZone').hide();
                }
                if (data.m_Item1.Person.ServedInMilitary > 0) {

                    $('input:radio[name=radservedinmilitary]')[data.m_Item1.Person.ServedInMilitary - 1].checked = true;
                    if (data.m_Item1.Person.ServedInMilitary == 13) {

                        $('#divOtherCombatZone').show();

                        if (data.m_Item1.Person.DateOfDeployed != null && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfDeployed)) != '01/01/1900'
                 && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfDeployed)) != '01/01/1') {
                            $("#dtdatedeployed").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfDeployed)));
                            $('#divDatedeployed').datepicker('update', $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.Person.DateOfDeployed)));
                        }

                    }
                } else {
                    $('#divOtherCombatZone').hide();
                }

                $("#chkfulltimestudent").prop("checked", data.m_Item1.Person.IsFullTimeStudent);
                $("#radWasStudentYes").prop("checked", data.m_Item1.Person.IsFullTimeStudent);
                if ($("#radWasStudentYes").prop("checked") == false)
                    $("#radWasStudentNo").prop("checked", true);

                $("#chkfirstname").prop("checked", data.m_Item1.Person.HasPrimaryFilerEcfContributed);

                if (data.m_Item1.FilingStatus == 2) {
                    $("#lblSpouse").css("display", "block");
                    $("#chkspouse").prop("checked", data.m_Item1.Person.HasSpouseEcfContributed);
                } else {
                    $("#lblSpouse").hide();
                    $("#chkspouse").hide();
                    $("#chkspouse").prop("checked", false);
                }
                var hasErrorInCollapseOne = false;
                var hasErrorInCollapseTwo = false;
                var hasErrorInCollapseThree = false;
                var hasErrorInCollapseFour = false;

                    $.each(data.m_Item2, function (index, value) {

                        var rfparameterName = value.FieldName.split('-');
                        if (rfparameterName.length == 2) {
                            var controlFocus = rfparameterName[1];
                            var divExpand = rfparameterName[0];
                            if (parameterName != undefined && parameterName.length == 2) {
                            //Vincent-26Augest2014-Made a control focus check for error tool tip
                            if (controlToFocus != controlFocus) {
                                $('#' + controlFocus).removeClass("form-control tip").addClass("tip error");
                                //28Aug2014 Bala add onblur event to the control to remove error class
                                RemoveControlHighlighting(controlToFocus);
                            }
                            }
                            if (divExpand == "collapseOne") {
                                hasErrorInCollapseOne = true;
                            }
                            else if (divExpand == "collapseTwo") {
                                hasErrorInCollapseTwo = true;
                            }
                            else if (divExpand == "collapseThree") {
                                hasErrorInCollapseThree = true;
                            }
                            else if (divExpand == "collapseFour") {
                                hasErrorInCollapseFour = true;
                            }
                        }
                    });
                //28Aug14, Bala, implemented to show/remove error icon in accordion for Required field and business validation
                    if (hasErrorInCollapseOne) {
                        $('#primaryinfo').addClass('error');
                    }
                    else {
                        $('#primaryinfo').removeClass('error');
                    }
                    if (hasErrorInCollapseTwo) {
                        $('#aSsnbirth').addClass('error');
                    }
                    else {
                        $('#aSsnbirth').removeClass('error');
                    }
                    if (hasErrorInCollapseThree) {
                        $('#election').addClass('error');
                    }
                    else {
                        $('#election').removeClass('error');
                    }
                    if (hasErrorInCollapseFour) {
                        $('#otherinformation').addClass('error');
                    }
                    else {
                        $('#otherinformation').removeClass('error');
                    }
            }


            //Vivek - 7-July-14 changed && to || 
            if ((data == null || data.m_Item1.Person == null) || ((data.m_Item1.Person.NickName == null || data.m_Item1.Person.NickName == '') && (data.m_Item1.Person.FirstName == null || data.m_Item1.Person.FirstName == ''))) {
                $('.spanFillerName').html('Taxpayer ');

            }
            else {
                if (data.m_Item1.Person.NickName != '')
                    $('.spanFillerName').html(data.m_Item1.Person.NickName + " ");
                else if (data.m_Item1.Person.FirstName != '')
                    $('.spanFillerName').html(data.m_Item1.Person.FirstName + " ");
            }

            filingStatus = data.m_Item1.FilingStatus;
            //4-july-14 vivek for the spouse hiding if the check box is single
            if (data.m_Item1.FilingStatus == 2) {
                $("#liSpouse").css("display", "block");
                $("#lblSpouse").show();
            }
        }
    });
}

function PersistPrimaryFiller(isContinue) {
    // if ($("#primaryfilerinfo").valid() == true) {
    //To Do

    //}
    //else {
    //    return false;
    //}

        var dataOfBirth;
        var dataOfDeath = null;
        var dateOfDeployed = null;
        var servedInMilitary = 0;
        if ($("#dtdateofbirth").val() == '')
            dataOfBirth = new Date('01/01/1900');
        else
            dataOfBirth = $("#dtdateofbirth").val();

        if ($('#chkdeparted').prop('checked') == true) {
            if ($("#dtdateofdeath").val() != '')
                dataOfDeath = $("#dtdateofdeath").val();
        }
        if ($('#chkservedinMilitary').prop("checked") == true) {

            servedInMilitary = $("input:radio[name=radservedinmilitary]:checked").val();

            if ($('#dtdatedeployed').val() != '') {
                dateOfDeployed = $('#dtdatedeployed').val();
            }
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
                        //Modified by prasana for triming the text boxes on 24.06.2014
                        "PersonType": 1, // 1April Sathish Since Person Type is spouse it is hard coded
                        "FirstName": $.trim($("#txtfirstname").val()),
                        "MiddleInitial": $("#txtmiddleinitial").val(),
                        "LastName": $.trim($("#txtlastname").val()),
                        "NickName": $.trim($("#txtnickname").val()),
                        "Occupation": $.trim($("#txtoccupation").val()),
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
                        "IsFullTimeStudent": $("#radWasStudentYes").prop("checked"),
                        "IsMilitary": $('#chkservedinMilitary').prop("checked"),//vivek 4-July-14 for the new property
                        "ServedInMilitary": servedInMilitary,//vivek 4-July-14 for the new property
                        "DateOfDeployed": dateOfDeployed//vivek 4-July-14 for the new property
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
}

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        window.location.href = '../Review/finalsummary.html?Topic=PrimaryFiler';
        return false;
    }
    else {
        return true;
    }
}