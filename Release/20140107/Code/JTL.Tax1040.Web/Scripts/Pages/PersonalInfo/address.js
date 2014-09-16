//Scripts for address   
var validator = [];
var filingStatus;
$(document).ready(function () {
    //Added by prasana on 26.06.2014
    LettersAndSpaceOnly('txtCity');
    LettersAndSpaceOnly('txtForeignCity');
    LettersAndSpaceOnly('txtStateorprovince');

    //Added by prasana on 27.06.2014 for fixing a bug Apartment number accepting special characters
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
        $('#divFromDateErrorMsg').html('');

        if ($("#dtFromDate").val() != '' && $("#dtToDate").val() != '') {

            var fromDate = validateDate($("#dtFromDate").val());
            var toDate = validateDate($("#dtToDate").val());

            if (fromDate && toDate && $("#dtFromDate").val() > $("#dtToDate").val()) {
                $('#divFromDateErrorMsg').html('You have entered an Invalid Date. Check your From date for New state of Residence.');
            }
            else {
                $('#divFromDateErrorMsg').html('');
                $('#divToDateErrorMsg').html('');
            }
        }
      
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
        $('#divToDateErrorMsg').html('');

        if ($("#dtFromDate").val() != '' && $("#dtToDate").val() != '') {

            var fromDate = validateDate($("#dtFromDate").val());
            var toDate = validateDate($("#dtToDate").val());

            if (fromDate && toDate && $("#dtFromDate").val() > $("#dtToDate").val()) {
                $('#divToDateErrorMsg').html('You have entered an Invalid Date. Check your To date for New state of Residence.');
            }
            else {
                $('#divFromDateErrorMsg').html('');
                $('#divToDateErrorMsg').html('');
            }
        }
    });

    //vivek 30-june-14 for the calendar focus
    $('#ddlMoreThanOneState').focusin(function () {
        $('#divDtFromDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#dtToDate').focusin(function () {
        $('#divDtFromDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#dtFromDate').focusin(function () {
        $('#divDtToDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chkEarnedIncomeSateYouNotLived').focusin(function () {
        $('#divDtToDate').datepicker('hide');
    });

    //Added by prasana on 27.06.2014 Since the apartment field is alpha numeric
   // NumbersOnly('txtApartmentNumber');
    NumbersOnly('txtPhoneNumber');
    NumbersOnly('txtZipCode');
    NumbersOnly('txtForeignPhoneNumber'); 
    NumbersOnly('txtPostalCode');
    NumbersLettersAndHyphen('txtStreetAddress');    
    NumbersLettersAndHyphen('txtForeignStreetAddress');//Added by Thileep  on 06 June 2014
    //Bala 23Jun14, code commented to fix the Focus issues
    //$('#divlivedinstate').hide();
    //$('#divEarnedIncomeState').hide();
   
    //Modified by prasana for adding new on page logic <o5> & <o6> on 23.06.2014 
    //Modified by prasana added '---Select---' in all if conditions on 24.06.2014
    //Modified by prasana in order to display non supported state selected in either one dropdown on 26.06.2014(temporary change for now after spec change will change)
    $('#btnAddessContinue').click(function () {
        if (PersistAddress()) {
            var stateOfResidence = $("#ddlStateOfResidence option:selected").text();
            var earnedIncomeStateNotLived = $("#ddlEarnedIncomeStateNotLived option:selected").text();
            var morethanOneState = $("#ddlMoreThanOneState option:selected").text();
            if (stateOfResidence != '---Select---' && stateOfResidence != 'California' && stateOfResidence != 'New York' && stateOfResidence != 'Illinois' && stateOfResidence != 'Michigan' && stateOfResidence != 'Georgia')
            {
                window.location.href = '../PersonalInfo/nonsupportedstatesummary.html';
                window.sessionStorage.setItem("StateOfResidence", $("#ddlStateOfResidence option:selected").text());
                window.sessionStorage.setItem("EarnedIncomeStateNotLived", $("#ddlEarnedIncomeStateNotLived option:selected").text());
                window.sessionStorage.setItem("MorethanOneState", $("#ddlMoreThanOneState option:selected").text());
            }
            else if (earnedIncomeStateNotLived != '---Select---'&& earnedIncomeStateNotLived != 'California' && earnedIncomeStateNotLived != 'New York' && earnedIncomeStateNotLived != 'Illinois' && earnedIncomeStateNotLived != 'Michigan' && earnedIncomeStateNotLived != 'Georgia')
            {
                window.location.href = '../PersonalInfo/nonsupportedstatesummary.html';
                window.sessionStorage.setItem("StateOfResidence", $("#ddlStateOfResidence option:selected").text());
                window.sessionStorage.setItem("EarnedIncomeStateNotLived", $("#ddlEarnedIncomeStateNotLived option:selected").text());
                window.sessionStorage.setItem("MorethanOneState", $("#ddlMoreThanOneState option:selected").text());
            }
            
            else if (morethanOneState != '---Select---' && morethanOneState != 'California' && morethanOneState != 'New York' && morethanOneState != 'Illinois' && morethanOneState != 'Michigan' && morethanOneState != 'Georgia') {
                window.location.href = '../PersonalInfo/nonsupportedstatesummary.html';
                window.sessionStorage.setItem("StateOfResidence", $("#ddlStateOfResidence option:selected").text());
                window.sessionStorage.setItem("EarnedIncomeStateNotLived", $("#ddlEarnedIncomeStateNotLived option:selected").text());
                window.sessionStorage.setItem("MorethanOneState", $("#ddlMoreThanOneState option:selected").text());
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
           var earnedIncome = $("#ddlEarnedIncomeStateNotLived").val();


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
         var earnedIncome = $("#ddlEarnedIncomeStateNotLived").val();


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
            dtFromDate: {
                IsCurrentYear: function () { $('#divFromDateErrorMsg').html(''); true; },
                IsValidFromAndToDate: function () { $('#divFromDateErrorMsg').html(''); true; }
                },
            dtToDate:
                {
                    IsCurrentYear: function () { $('#divToDateErrorMsg').html(''); true; },
                    IsValidFromAndToDate: function () { $('#divToDateErrorMsg').html(''); true; }
                },
            ddlStateOfResidence:
                {
                 dropdownResident: function () { $('#divStateOfResidenceError').html(''); true; }
                },
            ddlMoreThanOneState:
                {
                    dropdownmoreresident: function () { $('#divMoreThanOneStateError').html(''); true; }
                },
            ddlEarnedIncomeStateNotLived:
                {
                    dropdownEarnedIncomeresident: function () { $('#divddlEarnedIncomeStateNotLived').html(''); true; }
                },
            txtZipCode:
               {
                   validateZipCode: true
               },
            txtPostalCode:
                {
                    minlength: 5,
                    maxlength: 10
                },
            txtPhoneNumber:
                {
                    minlength: 12,
                },
            txtForeignPhoneNumber:
                {
                    minlength: 12,
                }

        },
        messages: {
            dtFromDate: {
                IsCurrentYear: function () { $('#divFromDateErrorMsg').html('You have entered an Invalid Date. Check your To date for New state of Residence.'); true; },
                IsValidFromAndToDate: function () { $('#divFromDateErrorMsg').html('You have entered an Invalid Date. Check your From date for New state of Residence.'); true; }
                 },
            dtToDate:
                {
                    IsCurrentYear: function () { $('#divToDateErrorMsg').html('New State of Residence To Date should be within Tax year'); true; },
                    IsValidFromAndToDate: function () { $('#divToDateErrorMsg').html('You have entered an Invalid Date. Check your To date for New state of Residence.'); true; }
                },
            ddlStateOfResidence:
                {
        dropdownResident: function () { $('#divStateOfResidenceError').html('Your Resident State name and Non resident state name should not be same.'); true; }
                },
            ddlMoreThanOneState:
                {
                  dropdownmoreresident: function () { $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same'); true; }
                },
            ddlEarnedIncomeStateNotLived:
                {
                    dropdownEarnedIncomeresident: function () { $('#divddlEarnedIncomeStateNotLived').html('Your Resident State name and Non resident state name should not be same.'); true; }
                },
            txtZipCode:
                {
                    validateZipCode: 'Invalid Zip Code'
                },
            txtPostalCode:
                {
                    minlength: "Invalid Zip Code",
                    maxlength: "Invalid Zip Code",
                },
            txtPhoneNumber:
                {
                    minlength: "Invalid Phone Number"
                },
            txtForeignPhoneNumber:
                {
                    minlength: "Invalid Phone Number"
                }
        }

    });

    //Thileep added datepicker event on 12Jun2014
    $('#divFromDate').datepicker({
        format: "mm/dd/yyyy",
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
        else {
            $('#divFromDateErrorMsg').html('Missing From Date');
        }
    });

    //Thileep added datepicker event on 12Jun2014
    $('#divToDate').datepicker({
        format: "mm/dd/yyyy",
        endDate: '+0d',
        forceParse: false,
        onClose: function () { $(this).valid(); },
    });

    $('#divToDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divToDateErrorMsg').html('');

        if ($('#dtToDate').val() != "") {
            $('#divToDateErrorMsg').html('');
        }
        else {
            $('#divToDateErrorMsg').html('Missing To Date');
        }
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
            $("#ddlMoreThanOneState").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlEarnedIncomeStateNotLived").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlStateOfResidence").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlMoreThanOneState").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlEarnedIncomeStateNotLived").append($("<option></option>").val(value.StateId).html(value.StateName));
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
                    $("#ddlMoreThanOneState").val(data.Address.LivedInAnotherStateId);
                    if (data.Address.LivedInAnotherStateFrom != null)
                    $("#dtFromDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Address.LivedInAnotherStateFrom)));
                    else
                        $("#dtFromDate").val('');
                    if (data.Address.LivedInAnotherStateTo != null)
                    $("#dtToDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Address.LivedInAnotherStateTo)));
                    else
                        $("#dtToDate").val('');
                    $("#ddlEarnedIncomeStateNotLived").val(data.Address.EarnedIncomeFromNonLivedStateId);
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
                        $("#ddlState").val(data.Address.PersonalAddress.StateId);
                        $("#txtZipCode").val(data.Address.PersonalAddress.ZipCode);
                        $("#txtPhoneNumber").val(data.Address.PersonalAddress.PhoneNumber);
                    } else if (data.Address.ForeignAddress != null) {
                        $("#divShowuUSAddress").hide();
                        $("#divShowForeignAddress").show();
                        $("#txtStateorprovince").val(data.Address.ForeignAddress.StateOrProvince);
                        $("#ddlCountryName").val(data.Address.ForeignAddress.CountryId);
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
            $("#ddlMoreThanOneState").val(0);
            $('#dtFromDate').val('');
            $('#dtToDate').val('');
        }

    });


    
    $("#chkEarnedIncomeSateYouNotLived").click(function () {
        $("#divEarnedIncomeState").toggle();
        $("#ddlEarnedIncomeStateNotLived").val(0);
    });
    
    $("[name='radAddress']").click(function () {
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
        
    $("#popStreetAddress").popover({ title: '', content: "<h5>Street Address</h5>Enter the address of your residing place.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popApartmentNumber").popover({ title: '', content: "<h5>Apartment Number</h5>Door number of your residing house.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCity").popover({ title: '', content: "<h5>City</h5>Name of the City you reside.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popState").popover({ title: '', content: "<h5>State</h5>Select your residing state from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popZipCode").popover({ title: '', content: "<h5>Zipcode</h5>Zipcode is a 5-digit code used for mailing purpose.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPhoneNumber").popover({ title: '', content: "<h5>Phone Number</h5>Provide your phone number in the format as 956-222-1234.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    //Changed by Yogalakshmi on 13th May 2014
        $("#popStateorprovince").popover({ title: '', content: "<h5>State or Province</h5>Select your residing state from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCountryName").popover({ title: '', content: "<h5>Country Name</h5>Select the name of the country from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPostalCode").popover({ title: '', content: "<h5>Postal Code</h5>Post code is a 5 digit code for sending mails to your address.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignPhoneNumber").popover({ title: '', content: "<h5>Foriegn Phone Number</h5>Specify the phone number of your foreign residence.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popFromDate").popover({ title: '', content: "<h5>From Date</h5>Enter the date from when you stayed in the new state.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popToDate").popover({ title: '', content: "<h5>To Date</h5>Enter the date when you moved out of the new state.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    //Added by Yogalakshmi on 13th May 2014
        $("#popStateOfResidence").popover({ title: '', content: "<h5>State Of Residence</h5>Select the state where you resides and the place where you permitted to Vote/Maintaining Bank Account /Driving license issued by State Government.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMoreThanOneState").popover({ title: '', content: "<h5>State</h5>Select  the state that you moved from one residential state to another state and lived at the end of the year.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popEarnedIncomeStateNotLived").popover({ title: '', content: "<h5>State</h5>Select the State where you receive income and which it's not your residential state.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignStreetAddress").popover({ title: '', content: "<h5>Street Address</h5>Enter the address of your residing place.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignApartmentNumber").popover({ title: '', content: "<h5>Apartment Number</h5>Door number of your residing house.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignCity").popover({ title: '', content: "<h5>City</h5>Name of the City you reside.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
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



$("#ddlStateOfResidence").change(function () {
    validateSameStateName();
});

$("#ddlMoreThanOneState").change(function () {
    if ($("#ddlMoreThanOneState option:selected").text() != "---Select---" && $("#ddlMoreThanOneState option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
        $("#divMoreThanOneStateError").show();
        $("#divStateOfResidenceError").show();
        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same');
        $("#divStateOfResidenceError").html('Your Resident state name and Part year resident name should not be same');
    }
    else {
        $("#divStateOfResidenceError").hide();
        $("#divMoreThanOneStateError").hide();
    }
});



$("#ddlEarnedIncomeStateNotLived").change(function () {
    if ($("#ddlEarnedIncomeStateNotLived option:selected").text() != "---Select---" && $("#ddlEarnedIncomeStateNotLived option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
        $("#divddlEarnedIncomeStateNotLived").show();
        $("#divStateOfResidenceError").show();
        $("#divStateOfResidenceError").html('Your Resident State name and Non resident state name should not be same.');
        $('#divddlEarnedIncomeStateNotLived').html('Your Resident State name and Non resident state name should not be same.');
    }
    else if ($("#ddlMoreThanOneState option:selected").text() != "---Select---" && $("#ddlMoreThanOneState option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
        $("#divMoreThanOneStateError").show();
        $("#divStateOfResidenceError").show();
        $("#divddlEarnedIncomeStateNotLived").hide();
        $("#divStateOfResidenceError").html('Your Resident state name and Part year resident name should not be same');
        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same');
    }
    else {
        $("#divStateOfResidenceError").hide();
        $("#divMoreThanOneStateError").hide();
    }
});
});


function PreventKeypressevent(event) {
    event.preventDefault();
}

function validateSameStateName() {
    if ($("#ddlEarnedIncomeStateNotLived option:selected").text() != "---Select---" && $("#ddlEarnedIncomeStateNotLived option:selected").text() == $("#ddlStateOfResidence option:selected").text()) {
        $("#divStateOfResidenceError").show();
        $("#divddlEarnedIncomeStateNotLived").show();
        $('#divStateOfResidenceError').html('Your Resident State name and Non resident state name should not be same.');
        $("#divddlEarnedIncomeStateNotLived").html('Your Resident State name and Non resident state name should not be same.');
        return false;
    }
    else if ($("#ddlStateOfResidence option:selected").text() != "---Select---" && $("#ddlStateOfResidence option:selected").text() == $("#ddlMoreThanOneState option:selected").text()) {
        $("#divStateOfResidenceError").show();
        $("#divMoreThanOneStateError").show();
        $("#divddlEarnedIncomeStateNotLived").hide();
        $('#divStateOfResidenceError').html('Your Resident state name and Part year resident name should not be same.');
        $('#divMoreThanOneStateError').html('Your Resident state name and Part year resident name should not be same.');
        return false;
    }
    else {
        $("#divStateOfResidenceError").hide();
        $("#divMoreThanOneStateError").hide();
        $("#divddlEarnedIncomeStateNotLived").hide();
        return true;
    }
}



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
                        "LivedInAnotherStateId": $("#ddlMoreThanOneState").val(),
                        "LivedInAnotherStateFrom": $("#dtFromDate").val(),
                        "LivedInAnotherStateTo": $("#dtToDate").val(),
                        "EarnedIncomeFromNonLivedStateId": $("#ddlEarnedIncomeStateNotLived").val(),
                        "AddressType": addressType,
                        "AddressId": $("#hdAddressId").val(),
                        "PersonalAddress":
                        {
                            "StreetAddress": $("#txtStreetAddress").val(),
                            "ApartmentNumber": $("#txtApartmentNumber").val(),
                            "City": $("#txtCity").val(),
                            "StateId": $("#ddlState").val(),
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
                        "LivedInAnotherStateId": $("#ddlMoreThanOneState").val(),
                        "LivedInAnotherStateFrom": $("#dtFromDate").val(),
                        "LivedInAnotherStateTo": $("#dtToDate").val(),
                        "EarnedIncomeFromNonLivedStateId": $("#ddlEarnedIncomeStateNotLived").val(),
                        "AddressType": addressType,
                        "AddressId": $("#hdAddressId").val(),
                        "ForeignAddress":
                        {
                            "StreetAddress": $("#txtForeignStreetAddress").val(),
                            "ApartmentNumber": $("#txtApartmentNumberForeign").val(),
                            "City": $("#txtForeignCity").val(),
                            "StateOrProvince": $("#txtStateorprovince").val(),
                            "CountryId": $("#ddlCountryName").val(),
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




