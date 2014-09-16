﻿//Scripts for address   
// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
//28 JUly 2014 Vincent implemented the added methed for lived in state and earned lived sate and commented state from and to
//Vincent - 30 JULY 2014 - worked on list method for EarnedStateNotLived & LivedStateInfo and refatored the code and worked rowindex, persist & get method.
var validator = [];
var filingStatus;
var otherlivedinstateRecordCount = 0;
var otherEarnedIncomeStateRecordCount = 0;
var livedInAnotherState;
var livedInAnotherStates = [];
var EarnedIncomeFromNonLivedState;
var EarnedIncomeFromNonLivedStates = [];

var otherStateinformation;
$(document).ready(function () {
    //Added by prasana on 26.06.2014
    LettersAndSpaceOnly('txtCity');
    LettersAndSpaceOnly('txtForeignCity');
    LettersAndSpaceOnly('txtStateorprovince');

    //Added by prasana on 27.06.2014 for fixing a bug Apartment number accepting special characters
    //Bala, 16Jul2014, Modified from NumersOnly to NumbersLetters based on the spec updation 
    NumbersLetters('txtApartmentNumber');
    NumbersLetters('txtApartmentNumberForeign');

    //Added by Praveen T on 02 June 2014
    $('#spCurrentYear').html(CURRENT_TAX_YEAR);
    $('#spanstateofresidence').html(STATE_OF_RESIDENCE);// vivek 18-June-14 Added for state residence
    $('#divDtFromDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/2014',
        endDate: '12/31/2014',
        forceParse: false,
        autoclose: true
    });

    $('#divDtFromDate').on('changeDate', function (ev) {
       
        $(this).datepicker('hide');
        //$('#divFromDateErrorMsg').html('');

        //if ($("#dtFromDate").val() != '') {

        //    var fromDate = validateDate($("#dtFromDate").val());
            
        //    if (fromDate) {
        //        $('#divFromDateErrorMsg').html('You have entered an Invalid Date. Check your From date for New state of Residence.');
        //    }
        //    else {
        //        $('#divFromDateErrorMsg').html('');
        //        $('#divToDateErrorMsg').html('');
        //    }
        //}
      });


    $('#alivedinstate').click(function () {
        otherlivedinstateRecordCount += 1;
        Addlivedinstate(otherlivedinstateRecordCount);
        return false;
    });

    $('#aEarnedIncomeState').click(function () {
        otherEarnedIncomeStateRecordCount += 1;
        AddEarnedIncomeState(otherEarnedIncomeStateRecordCount);
        return false;
    });

    $('#divDtToDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/2014',
        endDate: '12/31/2014',
        forceParse: false,
        autoclose: true
    });

    $('#divDtToDate').on('changeDate', function (ev) {
     
        $(this).datepicker('hide');
        //$('#divToDateErrorMsg').html('');

        //if ($("#dtToDate").val() != '') {

        //    var toDate = validateDate($("#dtToDate").val());

        //    if (toDate) {
        //        $('#divToDateErrorMsg').html('You have entered an Invalid Date. Check your To date for New state of Residence.');
        //    }
        //    else {
        //        $('#divFromDateErrorMsg').html('');
        //        $('#divToDateErrorMsg').html('');
        //    }
        //}
    });

    //vivek 30-june-14 for the calendar focus
    //$('#ddlMoreThanOneState').focusin(function () {
    //    $('#divDtFromDate').datepicker('hide');
    //});
    ////vivek 30-june-14 for the calendar focus
    //$('#dtToDate').focusin(function () {
    //    $('#divDtFromDate').datepicker('hide');
    //});
    ////vivek 30-june-14 for the calendar focus
    //$('#dtFromDate').focusin(function () {
    //    $('#divDtToDate').datepicker('hide');
    //});
    ////vivek 30-june-14 for the calendar focus
    //$('#chkEarnedIncomeSateYouNotLived').focusin(function () {
    //    $('#divDtToDate').datepicker('hide');
    //});

    //Added by prasana on 27.06.2014 Since the apartment field is alpha numeric
    // NumbersOnly('txtApartmentNumber');
    //Modified by prasana on 11.07.2014 changed "NumbersOnlyNotAcceptingDot" method for retricting the fields to accept dot.
    NumbersOnlyNotAcceptingDot('txtPhoneNumber');
    NumbersOnlyNotAcceptingDot('txtZipCode');
    NumbersOnlyNotAcceptingDot('txtForeignPhoneNumber');
    NumbersOnlyNotAcceptingDot('txtPostalCode');
    NumbersLettersAndHyphen('txtStreetAddress');    
    NumbersLettersAndHyphen('txtForeignStreetAddress');//Added by Thileep  on 06 June 2014
    //Bala 23Jun14, code commented to fix the Focus issues
    //$('#divlivedinstate').hide();
    //$('#divEarnedIncomeState').hide();
   
    //Modified by prasana for adding new on page logic <o5> & <o6> on 23.06.2014 
    //Modified by prasana added '---Select---' in all if conditions on 24.06.2014
    //Modified by prasana in order to display non supported state selected in either one dropdown on 26.06.2014(temporary change for now after spec change will change)
    //Vincent - 30 JULY 2014 - worked on list method for EarnedStateNotLived & LivedStateInfo and refatored the code.
    $('#btnAddessContinue').click(function () {
        if (PersistAddress()) {
            var stateOfResidence = $("#ddlStateOfResidence option:selected").text();
            //Earned Income From Non Lived States
            var earnedStateNotLived = "";
            var earnedIncomeStateNotLived = EarnedIncomeFromNonLivedStates; 
            $.each(earnedIncomeStateNotLived, function (key, value) {
                if (value.StateName != '---Select---' && value.StateName != 'California' && value.StateName != 'New York' && value.StateName != 'Illinois' && value.StateName != 'Michigan' && value.StateName != 'Georgia') {

                    if (earnedStateNotLived == "") {
                        earnedStateNotLived = value.StateName; //window.sessionStorage.setItem("MorethanOneState", value.StateName);
                    }
                    else {

                        earnedStateNotLived += ", " + value.StateName;
                    }
                }
            });

            //lived In Another States
            var morethanOneState = livedInAnotherStates; 
            var livedStateInfo = "";
            $.each(morethanOneState, function (key, value) {
                if (value.StateName != '---Select---' && value.StateName != 'California' && value.StateName != 'New York' && value.StateName != 'Illinois' && value.StateName != 'Michigan' && value.StateName != 'Georgia') {
                    if (livedStateInfo == "") {
                        livedStateInfo = value.StateName; 
                    }
                    else {

                        livedStateInfo += ", " + value.StateName;
                    }
                   
                }
            });

            if (stateOfResidence != '---Select---' && stateOfResidence != 'California' && stateOfResidence != 'New York' && stateOfResidence != 'Illinois' && stateOfResidence != 'Michigan' && stateOfResidence != 'Georgia') {
                window.sessionStorage.setItem("StateOfResidence", $("#ddlStateOfResidence option:selected").text());
                if (earnedStateNotLived != "") {
                    window.sessionStorage.setItem("EarnedIncomeStateNotLived", earnedStateNotLived);
                }
                if (livedStateInfo != "") {
                    window.sessionStorage.setItem("MorethanOneState", livedStateInfo);
                }
                window.location.href = '../PersonalInfo/nonsupportedstatesummary.html';
            }
            else if (earnedStateNotLived != "") {

                window.sessionStorage.setItem("StateOfResidence", $("#ddlStateOfResidence option:selected").text());
                window.sessionStorage.setItem("EarnedIncomeStateNotLived", earnedStateNotLived);
                
                if (livedStateInfo != "") {
                    window.sessionStorage.setItem("MorethanOneState", livedStateInfo);
                }
                window.location.href = '../PersonalInfo/nonsupportedstatesummary.html';
            }
            
            else if (livedStateInfo != "" ) {
                window.sessionStorage.setItem("StateOfResidence", $("#ddlStateOfResidence option:selected").text());
                if (earnedStateNotLived != "") {
                    window.sessionStorage.setItem("EarnedIncomeStateNotLived", earnedStateNotLived);
                }
                    window.sessionStorage.setItem("MorethanOneState", livedStateInfo);
                window.location.href = '../PersonalInfo/nonsupportedstatesummary.html';              
            }
            
            else
                window.location.href = '../PersonalInfo/personalsummary.html';
            }
        return false;

    });

     jQuery.validator.addMethod("IsCurrentYear",
         function (value, element) {
             var isValid = false;
             var reg = /^\d{1,2}\/\d{1,2}\/\d{4}$/;
             if (reg.test(value)) {
                 var splittedDate = value.split('/');
                 var mm = parseInt(splittedDate[0], 10);
                 var dd = parseInt(splittedDate[1], 10);
                 var yyyy = parseInt(splittedDate[2], 10);
                 var newDate = new Date(yyyy, mm - 1, dd);
                 var currentYear = (new Date).getFullYear();
                 isValid = true;
                 if (newDate.getFullYear() != currentYear) {
                     isValid = false;
                 }
             }
             else
                 isValid = false;
             return this.optional(element) || isValid;
         }, ""
         );

    jQuery.validator.addMethod("IsValidFromAndToDate",
        function (value, element) {

            if ($("#dtFromDate").val() != '' && $("#dtToDate").val() != '') {

                var fromDate = validateDate($("#dtFromDate").val());
                var toDate = validateDate($("#dtToDate").val());

                if (fromDate && toDate && $("#dtFromDate").val() > $("#dtToDate").val()) {
                    return false;
                }
                else {
                    return true;
                }
            }
            return true;

        }, ""
         );

    jQuery.validator.addMethod("dropdownResident",
       function (value, element) {
           var moreresident = $("#ddlMoreThanOneState").val();
           var earnedIncome = $("#ddlEarnedIncomeStateNotLived0").val();


           if (value != 0 && moreresident != 0 && value == moreresident) {
               return false;
           }
           else if (value != 0 && earnedIncome != 0 && value == earnedIncome) {
               return false;
           }
           else {
               return true;
           }
       }, ""
         );


    jQuery.validator.addMethod("dropdownmoreresident",
     function (value, element) {
         var stateresident = $("#ddlStateOfResidence").val();
         var earnedIncome = $("#ddlEarnedIncomeStateNotLived0").val();


         if (value != 0 && stateresident != 0 && value == stateresident) {
             return false;
         }
         else if (value != 0 && earnedIncome != 0 && value == earnedIncome) {
             return false;
         }
         else {
             return true;
         }
     }, ""
       );

    jQuery.validator.addMethod("dropdownEarnedIncomeresident",
     function (value, element) {
         var stateresident = $("#ddlStateOfResidence").val();
         var earnedIncome = $("#ddlMoreThanOneState").val();


         if (value != 0 && stateresident != 0 && value == stateresident) {
             return false;
         }
         else if (value != 0 && earnedIncome != 0 && value == earnedIncome) {
             return false;
         }
         else {
             return true;
         }
     }, ""
       );

    $("#Address").validate({

        rules: {
            //dtFromDate: {
            //    IsCurrentYear: function () { $('#divFromDateErrorMsg').html(''); true; },
            //    IsValidFromAndToDate: function () { $('#divFromDateErrorMsg').html(''); true; }
            //    },
            //dtToDate:
            //    {
            //        IsCurrentYear: function () { $('#divToDateErrorMsg').html(''); true; },
            //        IsValidFromAndToDate: function () { $('#divToDateErrorMsg').html(''); true; }
            //    },
            //ddlStateOfResidence:
            //    {
            //     dropdownResident: function () { $('#divStateOfResidenceError').html(''); true; }
            //    },
            //ddlMoreThanOneState:
            //    {
            //        dropdownmoreresident: function () { $('#divMoreThanOneStateError').html(''); true; }
            //    },
            //ddlEarnedIncomeStateNotLived:
            //    {
            //        dropdownEarnedIncomeresident: function () { $('#divddlEarnedIncomeStateNotLived').html(''); true; }
            //    },
            txtZipCode:
               {
                   validateZipCode: true
               },
            txtPostalCode:
                {
                    minlength: 3,
                    maxlength: 10,
                    ////Yogalakshmi - 8th July 2014 - Validation for Postal code
                    //validateZipCode: true
                },
            //Modified by prasana added Validation for PhoneNumber & ForeignPhonenumber on 08.07.2014
            txtPhoneNumber:
                {
                    minlength: 12,
                    validatePhoneNumber: true
                },
            txtForeignPhoneNumber:
                {
                    minlength: 12,
                    validatePhoneNumber: true
                }

        },
        messages: {
            //dtFromDate: {
            //    IsCurrentYear: function () { $('#divFromDateErrorMsg').html('You have entered an Invalid Date. Check your To date for New state of Residence.'); true; },
            //    IsValidFromAndToDate: function () { $('#divFromDateErrorMsg').html('You have entered an Invalid Date. Check your From date for New state of Residence.'); true; }
            //     },
            //dtToDate:
            //    {
            //        IsCurrentYear: function () { $('#divToDateErrorMsg').html('New State of Residence To Date should be within Tax year'); true; },
            //        IsValidFromAndToDate: function () { $('#divToDateErrorMsg').html('Your Part year resident "To date" should not be earlier than "From date". Check your entry'); true; }
            //    },
        //    ddlStateOfResidence:
        //        {
        //dropdownResident: function () { $('#divStateOfResidenceError').html('Your Resident State name and Non resident state name should not be same.'); true; }
        //        },
        //    ddlMoreThanOneState:
        //        {
        //          dropdownmoreresident: function () { $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same'); true; }
        //        },
        //    ddlEarnedIncomeStateNotLived:
        //        {
        //            dropdownEarnedIncomeresident: function () { $('#divddlEarnedIncomeStateNotLived').html('Your Resident State name and Non resident state name should not be same.'); true; }
        //        },
            txtZipCode:
                {
                    validateZipCode: 'Invalid Zip Code'
                },
            txtPostalCode:
                {
                    minlength: "Invalid Postal Code",
                    maxlength: "Invalid Postal Code",
                    ////Yogalakshmi - 8th July 2014 - Validation for Postal code
                    //validateZipCode: 'Invalid Postal Code'
                },
            //Modified by prasana added Validation for PhoneNumber & ForeignPhonenumber on 08.07.2014
            txtPhoneNumber:
                {
                    minlength: "Invalid Phone Number",
                    validatePhoneNumber: "Invalid Phone Number"
                },
            txtForeignPhoneNumber:
                {
                    minlength: "Invalid Phone Number",
                    validatePhoneNumber: "Invalid Phone Number"
                }
        }

    });

    //Thileep added datepicker event on 12Jun2014
    //Bala StartDate added to restrict the selection of start date 07July14
    $('#divFromDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
       onClose: function () { $(this).valid(); },      
    });
    

    $('#divFromDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divFromDateErrorMsg').html('');

        if ($('#dtFromDate').val() != "") {
            $('#divFromDateErrorMsg').html('');
    }
        //else {
        //    $('#divFromDateErrorMsg').html('Missing From Date');
        //}
    });

    //Thileep added datepicker event on 12Jun2014
    $('#divToDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        onClose: function () { $(this).valid(); },
    });

    $('#divToDate').on('changeDate', function (ev) {
        $(this).datepicker();
        //$('#divToDateErrorMsg').html('');

        //if ($('#dtToDate').val() != "") {
        //    $('#divToDateErrorMsg').html('');
        //}
        //else {
        //    $('#divToDateErrorMsg').html('Missing To Date');
        //}
    });


    //Commented by prasana - While clicking back button in address page it navigates from address page to personal summary page if error in address page on 24.06.2014
    //$('#btnAddressBack').click(function () {
    //    PersistAddress();
    //    filingStatus;
    //    if (filingStatus == 2) {
    //        window.location.href = '../PersonalInfo/spouseinfo.html';
    //    }
    //    else {
    //        window.location.href = '../PersonalInfo/primaryfilerinfo.html';
    //    }
    //    return false;
    //});
    
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
            $("#ddlStateOfResidence").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlMoreThanOneState0").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlEarnedIncomeStateNotLived0").append($("<option></option>").val(0).html("---Select---"));
            otherStateinformation = data;
            $.each(otherStateinformation, function (key, value) {
                $("#ddlStateOfResidence").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlMoreThanOneState0").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlEarnedIncomeStateNotLived0").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });

    $.ajax({
        url: serviceUrl + 'personalinfo/getalllivingstates',
        async: false,
        dataType: "json",
        type: "GET",
        data: JSON.stringify({
            "IsAdditionalMailingAddress": JSON.stringify(true),
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlState").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlState").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });

        $.ajax({
            url: serviceUrl + 'personalinfo/getcountry',
            async: false,
            dataType: "json",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                $("#ddlCountryName").append($("<option></option>").val(0).html("---Select---"));
                $.each(data, function (key, value) {
                    $("#ddlCountryName").append($("<option></option>").val(value.CountryId).html(value.CountryName));
                });
            }
        });

    $.ajax({
        url: serviceUrl + 'personalinfo/getaddress',
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
            if (data != null) {
                if (data.FilingStatus == 2) {
                    filingStatus = data.FilingStatus;
                    $("#liSpouse").css("display", "inline");
                }
                $("#lblTaxPayerName").html(data.TaxPayerName);
                if (data.Address != null) {
                    $("#hdAddressId").val(data.Address.AddressId);
                    $("#ddlStateOfResidence").val(data.Address.ResidenceState.StateId);
                    $("#chkLivedMoreThenOneStatCode").prop("checked", data.Address.HasLivedInMoreThanOneState);

                   if (data.Address.HasLivedInMoreThanOneState == true) {
                       $('#divlivedinstate').show();
                    }
                    else {
                       $('#divlivedinstate').hide();
                    }
                    //$('#divLivedInMoreThanOneState').show();
                    $("#chkEarnedIncomeSateYouNotLived").prop("checked", data.Address.HasEarnedIncomeFromNonLivedState);
                    if (data.Address.HasEarnedIncomeFromNonLivedState == true) {
                        $('#divEarnedIncomeState').show();
                    }
                    else {
                        $('#divEarnedIncomeState').hide();
                    }
                    if (data.Address.LivedInAnotherStates != null) {
                        // 09Jul2014 Sathsih checked null for  LivedInAnotherState

                        $.each(data.Address.LivedInAnotherStates, function (index, value) {
                            otherlivedinstateRecordCount = index;
                            if (index != 0) {
                                Addlivedinstate(otherlivedinstateRecordCount);
                            }
                            $("#ddlMoreThanOneState" + otherlivedinstateRecordCount).val(value.StateId);
                        });
                    }


                    //if (data.Address.LivedInAnotherStateFrom != null)
                    //$("#dtFromDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Address.LivedInAnotherStateFrom)));
                    //else
                    //    $("#dtFromDate").val('');
                    //if (data.Address.LivedInAnotherStateTo != null)
                    //$("#dtToDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Address.LivedInAnotherStateTo)));
                    //else
                    //    $("#dtToDate").val('');

                    if (data.Address.EarnedIncomeFromNonLivedStates != null)

                        // 09Jul2014 Sathsih  checked null reference
                        $.each(data.Address.EarnedIncomeFromNonLivedStates, function (index, value) {
                            otherEarnedIncomeStateRecordCount = index;
                            if (index != 0) {
                                AddEarnedIncomeState(otherEarnedIncomeStateRecordCount);
                            }
                            $("#ddlEarnedIncomeStateNotLived" + otherEarnedIncomeStateRecordCount).val(value.StateId);
                        });


                    if (data.Address.AddressType == 1) {
                        $("#radUsAddress").prop("checked", true);
                        $('#divShowForeignAddress').hide();
                        $('#divShowUSAddress').show();
                    }
                    else {
                        $("#radForeignAddress").prop("checked", true);
                        $('#divShowUSAddress').hide();
                        $('#divShowForeignAddress').show();
                    }
                   
                    if (data.Address.PersonalAddress != null) {
                        $("#divShowuUSAddress").show();
                        $("#divShowForeignAddress").hide();
                        $("#txtStreetAddress").val(data.Address.PersonalAddress.StreetAddress);
                        $("#txtApartmentNumber").val(data.Address.PersonalAddress.ApartmentNumber);
                        $("#txtCity").val(data.Address.PersonalAddress.City);
                        if (data.Address.PersonalAddress.State != null) // 09Jul2014 Sathsih  checked null reference
                            $("#ddlState").val(data.Address.PersonalAddress.State.StateId);
                        $("#txtZipCode").val(data.Address.PersonalAddress.ZipCode);
                        $("#txtPhoneNumber").val(data.Address.PersonalAddress.PhoneNumber);
                    } else if (data.Address.ForeignAddress != null) {
                        $("#divShowuUSAddress").hide();
                        $("#divShowForeignAddress").show();
                        $("#txtStateorprovince").val(data.Address.ForeignAddress.StateOrProvince);
                        if (data.Address.ForeignAddress.Country != null) // 09Jul2014 Sathsih  checked null reference
                            $("#ddlCountryName").val(data.Address.ForeignAddress.Country.CountryId);
                        $("#txtForeignStreetAddress").val(data.Address.ForeignAddress.StreetAddress);
                        $("#txtApartmentNumberForeign").val(data.Address.ForeignAddress.ApartmentNumber);
                        $("#txtPostalCode").val(data.Address.ForeignAddress.PostalCode);
                        $("#txtForeignPhoneNumber").val(data.Address.ForeignAddress.PhoneNumber);
                        $("#txtForeignCity").val(data.Address.ForeignAddress.City);
                    }
                } 
            }
        }
    });


    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        //$('#divShowForeignAddress').show();
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }


    
    $("#chkLivedMoreThenOneStatCode").change(function () {
        if ($('#chkLivedMoreThenOneStatCode').prop('checked')) {
            $('#divlivedinstate').show();
        }
        else {
            $('#divlivedinstate').hide();
            $('#divMoreThanOneStateError').hide();//Added by Thileep to hide error message on 26june2014
            $('#divStateOfResidenceError').hide();//Added by Thileep to hide error message on 26june2014
            //Added By vincent on 31 July 2014 to clear rowindex value
            $("#ddlMoreThanOneState0").val(0);
            $("#ddlMoreThanOneState1").val(0);
            $("#ddlMoreThanOneState2").val(0);
            //$('#dtFromDate').val('');
            //$('#dtToDate').val('');
        }

    });


    
    $("#chkEarnedIncomeSateYouNotLived").click(function () {
        $("#divEarnedIncomeState").toggle();
        //Added By vincent on 31 July 2014 to clear rowindex value
        $("#ddlEarnedIncomeStateNotLived0").val(0);
        $("#ddlEarnedIncomeStateNotLived1").val(0);
        $("#ddlEarnedIncomeStateNotLived2").val(0);
    });
    
    $("[name='radAddress']").click(function () {

        $("#txtStreetAddress").val('');
        $("#txtApartmentNumber").val('');
        $("#txtCity").val('');
        $("#ddlState").val(0);
        $("#txtZipCode").val('');
        $("#txtPhoneNumber").val('');
        $("#txtStateorprovince").val('');
        $("#ddlCountryName").val(0);
        $("#txtForeignStreetAddress").val('');
        $("#txtApartmentNumberForeign").val('');
        $("#txtPostalCode").val('');
        $("#txtForeignPhoneNumber").val('');
        $("#txtForeignCity").val('');

        if ($('#radUsAddress').prop('checked')) {
            $("#divShowUSAddress").show();
            $("#divShowForeignAddress").hide();
        }
        else if ($('#radForeignAddress').prop('checked')) {
            $("#divShowForeignAddress").show();
            $("#divShowUSAddress").hide();
        }
    });


   

    jQuery.validator.addMethod("lettersonly", function (value, element) {
        return this.optional(element) || /^[a-z]+$/i.test(value);
    }, "Letters only please");

    $.validator.addMethod('selectNone',
        function (value, element) {
            return this.optional(element)
            (value.indexOf("--Select--") == -1);
        }, "Please select an option");

    $(function () {
        
        $("#popStreetAddress").popover({ title: '', content: "<h5>Why do we need your Street Name?</h5>Your Street Name is an essential part of your full mailing address. <br /><br/>Make sure to receive all mail correspondence from the IRS and States by filling in your Street Name appropriately.<br/><br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popApartmentNumber").popover({ title: '', content: "<h5>Why do we need your Apartment Number?</h5>Your Apartment Number is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS by filling in your Apartment Number appropriately.<br/><br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCity").popover({ title: '', content: "<h5>Why do we need your City Name?</h5>Your City Name is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your City Name appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popState").popover({ title: '', content: "<h5>Why do we need your State?</h5>Your State is an essential part of your full mailing address. <br /><br/>Make sure to receive all mail correspondence from the IRS and States by filling in your State appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popZipCode").popover({ title: '', content: "<h5>Why do we need your Zip Code?</h5>Your Zip Code is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your Zip Code appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPhoneNumber").popover({ title: '', content: "<h5>Why do we need your Phone Number?</h5>We can certainly understand your privacy concern! <br/><br />It is just another information required to fill in your tax return to the IRS and States. <br/><br />We of course know you don't want any sales calls!<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    //Changed by Yogalakshmi on 13th May 2014
        $("#popStateorprovince").popover({ title: '', content: "<h5>Why do we need to know the Foreign State or Province?</h5>Your Foreign State or Province is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your Foreign State or Province appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCountryName").popover({ title: '', content: "<h5>Why do we need to know the Foreign Country?</h5>Your Foreign Country is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your Foreign Country appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPostalCode").popover({ title: '', content: "<h5>Why do we need to know your Foreign Postal Code?</h5>Your Foreign Zip Code or Postal Code is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS by filling in your Foreign Zip Code appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignPhoneNumber").popover({ title: '', content: "<h5>Why do we need your Phone Number?</h5>We can certainly understand your privacy concern! <br/><br />It is just another information required to fill in your tax return to the IRS and States. <br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popFromDate").popover({ title: '', content: "<h5>What is the 'From Date' that has to be mentioned here?</h5>The exact date from which you started to live in this State during the tax year 2014 must be mentioned. <br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popToDate").popover({ title: '', content: "<h5>What is the 'To Date' that has to be mentioned here?</h5>The exact date until which you lived in this State during the tax year 2014 must be mentioned. <br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    //Added by Yogalakshmi on 13th May 2014
        $("#popStateOfResidence").popover({ title: '', content: "<h5>What is your State of Residence?</h5>You are a resident of a State if: <br/><br />(1) It is where you physically reside <br /><br/>(2) It is where you are permitted to Vote <br /><br/>(3) It is the State that has issued you the Driver's License <br/><br />(4) It is the State where you have your Bank Account maintained <br /><br/>Residency rules vary by State, it's best to cross check this with the Department of Revenue.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMoreThanOneState").popover({ title: '', content: "<h5>What is your Part-year Residential State?</h5>When you relocate from one State to a new State you will often be a Part-year Resident of both the States. <br/><br />This applies if you have moved out of your State of Residence permanently to another State during the tax year.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popEarnedIncomeStateNotLived").popover({ title: '', content: "<h5>What is Non-residential State?</h5>It is the State from which you earned an income but did not live during the tax year.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignStreetAddress").popover({ title: '', content: "<h5>Why do we need to know your Foreign Street Address?</h5>Your Foreign Street Name is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your Foreign Street Name appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignApartmentNumber").popover({ title: '', content: "<h5>Why do we need to know your Foreign Apartment Number?</h5>Your Apartment Number is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your Apartment Number appropriately.<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignCity").popover({ title: '', content: "<h5>Why do we need to know the Foreign City or Town?</h5>Your Foreign City or Town is an essential part of your full mailing address. <br/><br />Make sure to receive all mail correspondence from the IRS and States by filling in your Foreign City or Town Name appropriately .<br/><br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
    //Bala, 23 Jun, 2014, Check Address page is valid for accordion issue
    $('#btnSubmitOne').click(function () {
        if ($("#Address").valid()) {
            PersistAddress();
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#address').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
            $('#state').removeClass('accordion-toggle collapsed').addClass('accordion-toggle');
        }
        return false;
    });



//$("#ddlStateOfResidence").change(function () {
//    validateSameStateName();
//});


//$("#ddlMoreThanOneState").change(function () {
//    if ($("#ddlMoreThanOneState option:selected").text() != "---Select---" && $("#ddlMoreThanOneState option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
//        $("#divMoreThanOneStateError").show();
//        $("#divStateOfResidenceError").show();
//        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same');
//        $("#divStateOfResidenceError").html('Your Resident state name and Part year resident name should not be same');
//    }
//    else {
//        $("#divStateOfResidenceError").hide();
//        $("#divMoreThanOneStateError").hide();
//    }
//});



//$("#ddlEarnedIncomeStateNotLived").change(function () {
//    if ($("#ddlEarnedIncomeStateNotLived option:selected").text() != "---Select---" && $("#ddlEarnedIncomeStateNotLived option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
//        $("#divddlEarnedIncomeStateNotLived").show();
//        $("#divStateOfResidenceError").show();
//        $("#divStateOfResidenceError").html('Your Resident State name and Non resident state name should not be same.');
//        $('#divddlEarnedIncomeStateNotLived').html('Your Resident State name and Non resident state name should not be same.');
//    }
//    else if ($("#ddlMoreThanOneState option:selected").text() != "---Select---" && $("#ddlMoreThanOneState option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
//        $("#divMoreThanOneStateError").show();
//        $("#divStateOfResidenceError").show();
//        $("#divddlEarnedIncomeStateNotLived").hide();
//        $("#divStateOfResidenceError").html('Your Resident state name and Part year resident name should not be same');
//        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same');
//    }
//    else {
//        $("#divStateOfResidenceError").hide();
//        $("#divMoreThanOneStateError").hide();
//    }goo
//});
});


function PreventKeypressevent(event) {
    event.preventDefault();
}

//function validateSameStateName() {
//    if ($("#ddlEarnedIncomeStateNotLived option:selected").text() != "---Select---" && $("#ddlEarnedIncomeStateNotLived option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
//        $("#divStateOfResidenceError").show();
//        $("#divddlEarnedIncomeStateNotLived").show();
//        $('#divStateOfResidenceError').html('Your Resident State name and Non resident state name should not be same.');
//        $("#divddlEarnedIncomeStateNotLived").html('Your Resident State name and Non resident state name should not be same.');
//        return false;
//    }
//    else if ($("#ddlStateOfResidence option:selected").text() != "---Select---" && $("#ddlStateOfResidence option:selected").text() == $("#ddlMoreThanOneState option:selected").text()) {
//        $("#divStateOfResidenceError").show();
//        $("#divMoreThanOneStateError").show();
//        $("#divddlEarnedIncomeStateNotLived").hide();
//        $('#divStateOfResidenceError').html('Your Resident state name and Part year resident name should not be same.');
//        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same.');
//        return false;
//    }
//        //TAX1040-14053 - vivek Added for the defect
//    else if ($("#ddlEarnedIncomeStateNotLived option:selected").text() != "---Select---" && $("#ddlEarnedIncomeStateNotLived option:selected").text() == $("#ddlMoreThanOneState option:selected").text()) {
//        $("#divStateOfResidenceError").hide();
//        $("#divddlEarnedIncomeStateNotLived").show();
//        $("#divMoreThanOneStateError").show();
//        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same');
//        $('#divddlEarnedIncomeStateNotLived').html('Your Resident state name and Part year resident name should not be same');
//    }
//    else {
//        $("#divStateOfResidenceError").hide();
//        $("#divMoreThanOneStateError").hide();
//        $("#divddlEarnedIncomeStateNotLived").hide();
//        return true;
//    }
//}



function validateDate(value) {
    if (value != '') {
        var reg = /^\d{1,2}\/\d{1,2}\/\d{4}$/;
        if (reg.test(value)) {
            var splittedDate = value.split('/');
            var mm = parseInt(splittedDate[0], 10);
            var dd = parseInt(splittedDate[1], 10);
            var yyyy = parseInt(splittedDate[2], 10);
            var newDate = new Date(yyyy, mm - 1, dd);
            var currentYear = (new Date).getFullYear();

            if (newDate.getFullYear() != currentYear) {
                return false;
            }
            else {
                return true;
            }
        }
        else
            return false;
    }
    else {
        return true;
    }

}

function PersistAddress() {
  


    if ($("#Address").valid()) {

        //livedInAnotherStates
        $.each($('#divMoreThanOneState').children('div'), function (key, value) {
            var index = value.getElementsByTagName('input');
            var rowIndex = index[0].value;
            if ($("#ddlMoreThanOneState" + rowIndex).val() != 0) {
                livedInAnotherState = {
                    StateId: $("#ddlMoreThanOneState" + rowIndex).val(),
                    StateName: $("#ddlMoreThanOneState" + rowIndex + " option:selected").text(),

                }
                livedInAnotherStates.push(livedInAnotherState);
            }
        });

        //Earned Income StateLived
        $.each($('#divEarnedIncomeStateLived').children('div'), function (key, value) {
            var index = value.getElementsByTagName('input');
            var rowIndex = index[0].value;
            if ($("#ddlEarnedIncomeStateNotLived" + rowIndex).val() != 0) {
                EarnedIncomeFromNonLivedState = {
                    StateId: $("#ddlEarnedIncomeStateNotLived" + rowIndex).val(),
                    StateName: $("#ddlEarnedIncomeStateNotLived" + rowIndex + " option:selected").text(),

                }
                EarnedIncomeFromNonLivedStates.push(EarnedIncomeFromNonLivedState);
            }
        });

        var addressType;
        if ($("#radUsAddress").prop("checked") == true) {
            addressType = $("#radUsAddress").val();
            
            $.ajax({
                url: serviceUrl + 'personalinfo/addresscreate',
                async: false,
                dataType: "json",
                type: "POST",
                beforeSend: function (request) {
                    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
                },
                data: JSON.stringify({
                    "UserId": userId,   
                    "UserDataId": userDataId,  
                    "Address": {
                        "ResidenceState": {
                            "StateId": $("#ddlStateOfResidence").val(),
                            "StateName": $("#ddlStateOfResidence option:selected").text(),
                        },
                        "HasLivedInMoreThanOneState": $("#chkLivedMoreThenOneStatCode").prop("checked"),
                        "HasEarnedIncomeFromNonLivedState": $("#chkEarnedIncomeSateYouNotLived").prop("checked"),

                        "LivedInAnotherStates": livedInAnotherStates,

                        //{
                        //    "StateId": $("#ddlMoreThanOneState").val(),
                        //    "StateName": $("#ddlMoreThanOneState  option:selected").text()
                        //},
                        //"LivedInAnotherStateFrom": $("#dtFromDate").val(),
                        //"LivedInAnotherStateTo": $("#dtToDate").val(),


                        "EarnedIncomeFromNonLivedStates": EarnedIncomeFromNonLivedStates,
                        //{
                        //    "StateId": $("#ddlEarnedIncomeStateNotLived").val(),
                        //    "StateName": $("#ddlEarnedIncomeStateNotLived option:selected").text()
                        //},

                        "AddressType": addressType,
                        "AddressId": $("#hdAddressId").val(),
                        "PersonalAddress":
                        {
                            "StreetAddress": $("#txtStreetAddress").val(),
                            "ApartmentNumber": $("#txtApartmentNumber").val(),
                            "City": $("#txtCity").val(),
                            State:
                                {
                            "StateId": $("#ddlState").val(),
                                    "StateName": $("#ddlState option:selected").text(),
                                },
                            "ZipCode": $("#txtZipCode").val(),
                            "PhoneNumber": $("#txtPhoneNumber").val(),
                            "CountryId": 1, // TODO : Country ID hard coded since personal address country id is USA
                        },
                    },
                }),
                contentType: "application/json; charset=utf-8",
                error: function (jqXHR, textStatus, errorThrown) {
                    //alert(jqXHR + "-" + textStatus + "-" + errorThrown);
                    ErrorHandler(jqXHR, errorThrown);
                },
                success: function (data, textStatus) {

                    window.sessionStorage.setItem("UserDataId", data.UserDataId);
                    $("#hdAddressId").val(data.AddressId);
                }
            });

        } else {
            addressType = $("#radForeignAddress").val();
            $.ajax({
                url: serviceUrl + 'personalinfo/addresscreate',
                async: false,
                dataType: "json",
                type: "POST",
                beforeSend: function (request) {
                    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
                },
                data: JSON.stringify({
                    "UserId": userId,  
                    "UserDataId": userDataId,  
                    "Address": {
                        "ResidenceState": {
                            "StateId": $("#ddlStateOfResidence").val(),
                            "StateName": $("#ddlStateOfResidence option:selected").text(),
                        },
                        "HasLivedInMoreThanOneState": $("#chkLivedMoreThenOneStatCode").prop("checked"),
                        "HasEarnedIncomeFromNonLivedState": $("#chkEarnedIncomeSateYouNotLived").prop("checked"),
                        "LivedInAnotherStates": livedInAnotherStates,
                        //{
                        //    "StateId": $("#ddlMoreThanOneState").val(),
                        //    "StateName": $("#ddlMoreThanOneState option:selected").text(),
                        //},
                        //"LivedInAnotherStateFrom": $("#dtFromDate").val(),
                        //"LivedInAnotherStateTo": $("#dtToDate").val(),
                        "EarnedIncomeFromNonLivedStates": EarnedIncomeFromNonLivedStates,
                        //    {
                        //    "StateId": $("#ddlEarnedIncomeStateNotLived").val(),
                        //    "StateName": $("#ddlEarnedIncomeStateNotLived option:selected").text()
                        //},
                        "AddressType": addressType,
                        "AddressId": $("#hdAddressId").val(),
                        "ForeignAddress":
                        {
                            "StreetAddress": $("#txtForeignStreetAddress").val(),
                            "ApartmentNumber": $("#txtApartmentNumberForeign").val(),
                            "City": $("#txtForeignCity").val(),
                            "StateOrProvince": $("#txtStateorprovince").val(),
                            Country:
                                {
                            "CountryId": $("#ddlCountryName").val(),
                                    "CountryName": $("#ddlCountryName option:selected").text()
                                },
                            "PostalCode": $("#txtPostalCode").val(),
                            "PhoneNumber": $("#txtForeignPhoneNumber").val()
                        },
                    },
                }),
                contentType: "application/json; charset=utf-8",
                error: function (jqXHR, textStatus, errorThrown) {
                    ErrorHandling(jqXHR, errorThrown);
                },
                success: function (data, textStatus) {
                    window.sessionStorage.setItem("UserDataId", data.UserDataId);
                    $("#hdAddressId").val(data.AddressId);
                }
            });
        }
        return true;
    }
    else {
        var controlname = validator[0];
        $('[id^=' + controlname + ']:first').focus();
        return false;
    }
}

function Addlivedinstate(rowIndex) {
    if (rowIndex < 3) {
        var newStateInformation = ' <div id="divMoreThanOneState' + rowIndex + '">' + '<div class="pangird itm">' +
            ' <input type="hidden" id="hStateinformation' + rowIndex + '" value="' + rowIndex + '" />' +
            ' <label class="col-md-6" for="lblMoreThanOneState">' + "State Name" +
            '</label>' +

            '<label class="col-md-6">' +
            '   <select name="ddlMoreThanOneState"  ID="ddlMoreThanOneState' + rowIndex + '" tabindex="19"  >' +
            '        </select>' +
            '   </label>' + ' </div>' +
            ' </div>';


        $('#divMoreThanOneState').append(newStateInformation);

        $('#ddlMoreThanOneState' + rowIndex).append($("<option></option>").val(0).html("---Select---"));

        $.each(otherStateinformation, function (key, value) {
            $('#ddlMoreThanOneState' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateName));
        });
    }
}

function AddEarnedIncomeState(rowIndex) {
    if (rowIndex < 3) {
        var newStateInformation = ' <div id="divEarnedIncomeStateLived' + rowIndex + '">' + '<div class="pangird itm">' +
            ' <input type="hidden" id="hEarnedIncomeState' + rowIndex + '" value="' + rowIndex + '" />' +
            ' <label class="col-md-6" for="lblEarnedIncomeStateNotLived">' + " State Name" +
            '</label>' +

            '<label class="col-md-6">' +
            '   <select name="ddlEarnedIncomeStateNotLived"  ID="ddlEarnedIncomeStateNotLived' + rowIndex + '" tabindex="21" >' +
            '        </select>' +
            '   </label>' + ' </div>' +
            ' </div>';


        $('#divEarnedIncomeStateLived').append(newStateInformation);

        $('#ddlEarnedIncomeStateNotLived' + rowIndex).append($("<option></option>").val(0).html("---Select---"));

        $.each(otherStateinformation, function (key, value) {
            $('#ddlEarnedIncomeStateNotLived' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateName));
        });
    }
}



