//W2 Scripts

//22 Apr 2014- vincent Moved-w2LocalTaxInfo List to W2StateLocalTaxInfo
//13 May 14- Vincent-CheckBox Id name change.
//14 May 14-Vincent- Added th DDL fuction in Document ready 
//14 May 14-Vincent-Eligibility check occurred 
//19 May 14-Vincent-Made a numeric check for 'Dot'.

var w2Id;
var employmentType;
var ownerType;
var otherDeductionBenefitsRecordCount = 0;
var stateWagesRecordCount = 0;
var localTaxInfoRecordCount = 0;
var box14OtherCode;
var state;
var isEligibilityCheckFailed = false;




$(document).ready(function () {

    $("#txtW2FederalWages").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2FederalWithheld").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2SSWages").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2SSwithheld").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2MedicalWages").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2MedicalWithheld").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2SSTips").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2AllocatedTips").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2DependentCare").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtQualifiedPlan").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });


    $("#txt12AAmount").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txt12BAmount").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txt12CAmount").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txt12DAmount").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2Amount0").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2StateWages0").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2LocalWages0").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2LocalWithHeld0").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });


    $("#txtHouseholdEmployerZip").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2EmployerZip").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    

    $("#txtW2EmployeeZip").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtHouseholdEmployerZip").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtInstitutionZip").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    

    $("#txtW2StateWithheld0").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    
    

    jQuery.validator.addMethod("numbersonly", function (value, element) {
        return this.optional(element) || /^[0-9]+$/i.test(value);
    }, "numbers only please");


    $("#W2").validate({

        rules: {
            txtW2FederalWages: {
                required: true,
                numbersonly: true
            },
        },
        messages: {
            txtW2FederalWages: {
                required: "Federal Wages should not be Empty",
                numbersonly: "Enter Number only"
            },
        }

    });



    //Error message- focus method for user control
    fromSummary = false;
    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    var parameters = pageURL.split('&');
    if (parameters.length == 2) {
        fromSummary = true;
        var controlParmeters = parameters[0];
        w2Id = parameters[1];
        var controls = controlParmeters.split('-');
        if (controls.length == 2) {

            var divToExpand = controls[0];
            var controlToFocus = controls[1];
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#' + divToExpand).addClass('panel-collapse collapse in');
            $('#' + controlToFocus).focus();
        }
    }

    if (fromSummary = false) {
        var pageURL = window.location.search.substring(1);
    }

    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('W2Id') == 0) {
        w2Id = parameterName[1];
    }

    //DDL Method.
    GetState();
    GetEmployeeCode();
    GetW2OtherCode();

    //Saravanan N - 14th May, 2014 - Method code refactored from HTML.
    $('#btnBack').click(function () {
        PersistW2();
        GoToPreviousPage();
        return false;
    });

    //On-Page Logic EmployerAddess name change.
    $("#divEmployee").hide();
    $("#chkW2EmployerAddress").click(function () {
        $("#divEmployee").toggle();
    });

    $('#btnContinue').click(function () {
        if (PersistW2()) {
            //Vincent- Hard Stopper
            PageNavigation(isEligibilityCheckFailed, '../Income/w2summary.html', 'Wages');
        }
        return false;
    });

    $('#aBox14OtherInformation').click(function () {
        otherDeductionBenefitsRecordCount += 1;
        AddOtherDeductionBenefits(otherDeductionBenefitsRecordCount);
        return false;
    });

    $('#aStateWages').click(function () {
        stateWagesRecordCount += 1;
        AddStateWages(stateWagesRecordCount);
        return false;
    });

    $('#aLocalTaxInfo').click(function () {
        localTaxInfoRecordCount += 1;
        AddLocalTaxInfo(localTaxInfoRecordCount);
        return false;
    });

    $('.btnNextClass').click(function () {
        NextClick();
        return false;
    });


    GetW2Data();

    $('#btnSubmitOne').click(function () {
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        return false;
    });

    $('#btnSubmitTwo').click(function () {
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        return false;
    });

    $('#btnSubmitThree').click(function () {
        $('#collapseFour').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseThree').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        return false;
    });

    $('#btnSubmitFour').click(function () {
        $('#collapseFive').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseFour').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        return false;
    });

});


$(function () {
    
    //Quick Help for W2 Basic Details
    $("#popEmployerID").popover({ title: '', content: "<h5>Employer Identification Number</h5>Unique 9 digit number assigned by IRS to an individual for the purpose of identification. Used by the employers for reporting the taxes. You can find the digits of EIN in the format as XX-XXXXXXX.<br /> <a href='target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployerName").popover({ title: '', content: "<h5>Employer's Name</h5>Specify your full name along with your initial and last name.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployerAddress").popover({ title: '', content: "<h5>Employer's Address</h5>Specify the address of main office or headquarters you were employed during this tax season.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployerCity").popover({ title: '', content: "<h5>Employer's City</h5>Name of the City you were working with.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployerState").popover({ title: '', content: "<h5>Employer's State</h5>Select the Name of the State you were employed with.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployerZipCode").popover({ title: '', content: "<h5>Employer's Zip Code</h5>Zipcode of the state. For example, you have entered your employer state as 'California', you need to enter your zip code as 90001.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popFederalWages").popover({ title: '', content: "<h5>Box1 Federal Wages</h5>Enter the Wages, tips, bonuses and other compensation paid by your employer.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popFederalTaxWithheld").popover({ title: '', content: "<h5>Box2 Federal Tax Withheld</h5>Enter the amount of Federal income tax your employer has withheld from your wages.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popSocialSecurityWages").popover({ title: '', content: "<h5>Box3 Social Security Wages</h5>Enter the amount your employer paid you for the social security tax .<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popSocialSecurityTaxWithheld").popover({ title: '', content: "<h5>Box4 Social Security Tax Witheld</h5>Amount of Social Security Tax withheld on your wages .<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popMedicalWages").popover({ title: '', content: "<h5>Box5 Medicare Wages</h5> Total amount paid by your employer for Medicare Taxof Social Security Tax withheld on your wages.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popMedicalTaxWithheld").popover({ title: '', content: "<h5>Box6 Medicare Tax Withheld</h5>Enter the amount of Medicare tax withheld on your wages. The value of Box6 should be equal to 1.45% value of Box7. \.<hr /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popSocialSecurityTips").popover({ title: '', content: "<h5>Box7 Social Security Tips</h5>Amount of tips you have reported to your employer.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popAllocatedTips").popover({ title: '', content: "<h5>Box8 Allocated Tips</h5>Amount of tips received by your employer <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popDependentCareBenefits").popover({ title: '', content: "<h5>Box10 Dependent Care Benefits</h5>Total amount of benefits received from your employer for caring your Dependents.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popNonQualifiedPlan").popover({ title: '', content: "<h5>Non Qualified Plan</h5>Amount received for any nonqualified deferred compensation plans.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    //Added By Yogalakshmi on 13th May 2014
    
    //Quick Help for W2 benefits and other information 
    $("#popW212A").popover({ title: '', content: "<h5>Box 12A</h5>Select your other benefit information reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#pop12AAmount").popover({ title: '', content: "<h5>Box 12A</h5>Enter your other benefit amount reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popW212B").popover({ title: '', content: "<h5>Box 12B</h5>Select your other benefit information reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popW212BAmount").popover({ title: '', content: "<h5>Box 12B</h5>Enter your other benefit amount reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popW212C").popover({ title: '', content: "<h5>Box 12C</h5>Select your other benefit information reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#pop12CAmount").popover({ title: '', content: "<h5>Box 12C</h5>Enter your other benefit amount reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popW212D").popover({ title: '', content: "<h5>Box 12D</h5>Select your other benefit information reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#pop12DAmount").popover({ title: '', content: "<h5>Box 12D</h5>Enter your other benefit amount reported on your Form W-2.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    
    //Quick help for Household Employee Wages 
    $("#popHouseholdEmployerName").popover({ title: '', content: "<h5>Employer's Name</h5>Specify your full name along with your initial and last name.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerAddress").popover({ title: '', content: "<h5>Employer's Address</h5>Specify the address of main office or headquarters you were employed during this tax season.<hr /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerCity").popover({ title: '', content: "<h5>Employer's City</h5>Name of the City you were working with.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerState").popover({ title: '', content: "<h5>Employer's State</h5>Select the Name of the State you were employed with.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployerZip").popover({ title: '', content: "<h5>Employer's Zip Code</h5>Zipcode of the state. For example, you have entered your employer state as 'California', you need to enter your zip code as 90001.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popHouseholdEmployeeWages").popover({ title: '', content: "<h5>Household Employee Wages</h5>Enter your Household Employee Wages income received from your employer, which is not reported on your Form W-2 and it must be less than $1,800.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    
    //Quick help for Taxable Scholarship Income
    $("#popInstitutionName").popover({ title: '', content: "<h5>Institution Name</h5>Specify your full name along with your initial and last name.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionAddress").popover({ title: '', content: "<h5>Address</h5>Specify the address of main office or headquarters of your institution.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionCity").popover({ title: '', content: "<h5>City</h5>Name of the City of your Institution.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionState").popover({ title: '', content: "<h5>State</h5>Select the Name of the State of your Institution.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInstitutionZip").popover({ title: '', content: "<h5>Employer's Zip Code</h5>Zipcode of the state. For example, you have entered your Institution state as 'California', you need to enter your zip code as 90001.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popTaxableScholarshipAmount").popover({ title: '', content: "<h5>Taxable Scholarship Amount</h5>Enter your Taxable Scholarship Income received from your educational Institution.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

    //Quick Help for Employee 
    $("#popEmployeeAddress").popover({ title: '', content: "<h5>Employee Address</h5>Enter the Employee street address on your Form W-2.<a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployeeCity").popover({ title: '', content: "<h5>Employee City</h5>Enter the Employee City on your Form W-2.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployeeState").popover({ title: '', content: "<h5>Employee State</h5>Select the Employee State on your Form W-2.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEmployeeZipCode").popover({ title: '', content: "<h5>Employee Zip Code</h5>Enter the Employee Zip Code on your Form W-2. For example, you have entered your employer state as 'California', you need to enter your zip code as 90001.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
});

//Saravanan N - 14th May, 2014 - Code refactored.
function GetState() {
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
            state = data;
            $("#ddlW2State").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlW2EmployeeState").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlW2Box15State0").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlW2AssociatedState0").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlHouseholdEmployerState").append($("<option></option>").val(0).html('---Select---'));
            $("#ddlInstitutionState").append($("<option></option>").val(0).html('---Select---'));
            $.each(data, function (key, value) {
                $("#ddlW2State").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlW2EmployeeState").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlW2Box15State0").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlW2AssociatedState0").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlHouseholdEmployerState").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlInstitutionState").append($("<option></option>").val(value.StateId).html(value.StateCode));
            });
        }
    });
}

//Saravanan N - 14th May, 2014 - Code refactored.
function GetEmployeeCode() {
    $.ajax({
        url: serviceUrl + 'w2/getemployeecode',
        async: false,
        dataType: "json",
        type: "GET",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $.each(data, function (key, value) {
                $("#ddlW212A").append($("<option></option>").val(value.Value).html(value.Text));
                $("#ddlW212B").append($("<option></option>").val(value.Value).html(value.Text));
                $("#ddlW212C").append($("<option></option>").val(value.Value).html(value.Text));
                $("#ddlW212D").append($("<option></option>").val(value.Value).html(value.Text));
            });
        }
    });
}

//Saravanan N - 14th May, 2014 - Code refactored.
function GetW2OtherCode() {
    $.ajax({
        url: serviceUrl + 'w2/getw2othercode',
        async: false,
        dataType: "json",
        type: "GET",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            box14OtherCode = data;
            $.each(box14OtherCode, function (key, value) {
                $("#ddlW2OtherCode0").append($("<option></option>").val(value.Value).html(value.Text));
            });
        }
    });
}

//TODO: Has to see the possibility to move this method to common place, since it is used from W2employmentandownertype.js also. - Saravanan N - 14th May, 2014
function PersistW2() {
    var householdEmployeeWages;
    var taxableScholarshipAmount;
    var name;
    var ein;
    var streetAddress;
    var city;
    var zip;
    var stateId;
    var otherDeductionBenefit;
    var otherDeductionBenefits = [];
    var stateLocalWage;
    var StateLocalWagesInfo = [];
    var localTax;
    var localTaxInfo = [];

    $.each($('#divBox14OtherInformation').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;
        otherDeductionBenefit = {
            W2OtherId: $("#ddlW2OtherCode" + rowIndex).val(),
            Description: $("#txtW2Description" + rowIndex).val(),
            Amount:($.isNumeric($("#txtW2Amount" + rowIndex).val().trim()) ? $("#txtW2Amount" + rowIndex).val().trim():null),
        }
        otherDeductionBenefits.push(otherDeductionBenefit);
    });

    $.each($('#divLocalTaxInfo').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;
        localTax = {
            StateCode: $("#ddlW2AssociatedState" + rowIndex).val(),
            LocalWagesAmount: $("#txtW2LocalWages" + rowIndex).val().trim(),
            LocalTaxWithholdingAmount:($.isNumeric($("#txtW2LocalWithHeld" + rowIndex).val().trim()) ? $("#txtW2LocalWithHeld" + rowIndex).val().trim():null),
            LocalityName: $("#txtW2LocalityName" + rowIndex).val()
        }
        localTaxInfo.push(localTax);
    });

    $.each($('#divLocalStateWagesInfo').children('div'), function (key, value) {
        var index = value.getElementsByTagName('input');
        var rowIndex = index[0].value;

        var stateLocalTax = [];
        if (localTaxInfo[rowIndex] != null)
            stateLocalTax.push(localTaxInfo[rowIndex]);

        stateLocalWage = {
            StateCode: $("#txtW2StateID" + rowIndex).val(),
            StateId: $("#ddlW2Box15State" + rowIndex).val(),
            StateWagesAmount: $("#txtW2StateWages" + rowIndex).val().trim(),
            StateTaxWithholdingAmount: ($.isNumeric($("#txtW2StateWithheld" + rowIndex).val().trim())? $("#txtW2StateWithheld" + rowIndex).val().trim():null),
            W2LocalTaxInfo: stateLocalTax,
        }
        StateLocalWagesInfo.push(stateLocalWage);
    });

    if (employmentType > 0 && employmentType != 6 && employmentType != 7) {
        name = $("#txtW2EmployerName").val();
        ein = $("#txtW2EmployerID").val();
        streetAddress = $("#txtW2EmployerAddress").val();
        city = $("#txtW2EmployerCity").val();
        zip = $("#txtW2EmployerZip").val();
        stateId = $("#ddlW2State").val();
    } else if (employmentType == 6) {

        householdEmployeeWages =($.isNumeric($("#txtHouseholdEmployeeWages").val().trim()) ? $("#txtHouseholdEmployeeWages").val().trim() : null),
        name = $("#txtHouseholdEmployerName").val(),
        streetAddress = $("#txtHouseholdEmployerAddress").val(),
        city = $("#txtHouseholdEmployerCity").val(),
        zip = $("#txtHouseholdEmployerZip").val(),
        stateId =
            $("#ddlHouseholdEmployerState").val();
    } else if (employmentType == 7) {

        taxableScholarshipAmount = ($.isNumeric($("#txtTaxableScholarshipAmount").val().trim()) ? $("#txtTaxableScholarshipAmount").val().trim() : null),
        name = $("#txtInstitutionName").val(),
        streetAddress = $("#txtInstitutionAddress").val(),
        city = $("#txtInstitutionCity").val(),
        zip = $("#txtInstitutionZip").val(),
        stateId = $("#ddlInstitutionState").val();
    }

    var w2Data = {
        W2Id: w2Id,
        EmploymentType: employmentType,
        OwnerType: ownerType,
        WagesAmount: ($.isNumeric($("#txtW2FederalWages").val().trim()) ? $("#txtW2FederalWages").val().trim():null),
        FederalTaxWithholdingAmount:($.isNumeric($("#txtW2FederalWithheld").val().trim()) ? $("#txtW2FederalWithheld").val().trim():null),
        SocialSecurityWagesAmount:($.isNumeric($("#txtW2SSWages").val().trim()) ? $("#txtW2SSWages").val().trim():null),
        SocialSecurityTaxWithholdingAmount: ($.isNumeric($("#txtW2SSwithheld").val().trim()) ? $("#txtW2SSwithheld").val().trim() : null),
        MedicareWagesAmount: ($.isNumeric($("#txtW2MedicalWages").val().trim()) ? $("#txtW2MedicalWages").val().trim():null),
        MedicareTaxWithholdingAmount:($.isNumeric($("#txtW2MedicalWithheld").val().trim()) ? $("#txtW2MedicalWithheld").val().trim():null),
        SocialSecurityTipsAmount: ($.isNumeric($("#txtW2SSTips").val().trim()) ? $("#txtW2SSTips").val().trim():null),
        AllocatedTipsAmount:($.isNumeric($("#txtW2AllocatedTips").val().trim()) ? $("#txtW2AllocatedTips").val().trim():null),
        DependentCareBenefitsAmount:($.isNumeric($("#txtW2DependentCare").val().trim()) ? $("#txtW2DependentCare").val().trim():null),
        //NotInUseAmount: $("#txtW2NotInUse").val(),
        IsStatutoryEmployee: $('#rdW2Statutory').prop('checked'),
        HasRetirementPlan: $('#rdW2RetirementPlan').prop('checked'),
        HasThirdPartySickPay: $('#rdW2ThridPartySick').prop('checked'),
        NonQualifiedPlansAmount: GetZeroOnIsNullOrEmpty($.isNumeric($("#txtQualifiedPlan").val().trim()) ? $("#txtQualifiedPlan").val().trim():null),
        HasEmployeeAddress: $("#chkW2EmployerAddress").prop("checked"),
        EmployeeAddress: {
            StreetAddress: $("#txtW2EmployeeAddress").val(),
            City: $("#txtW2EmployeeCity").val(),
            StateId: $("#ddlW2EmployeeState").val(),
            ZipCode: $("#txtW2EmployeeZip").val()
        },
        IsCorrectedW2: $("#chkW2correct").prop("checked"),
        IsNonStandardW2: $("#chkW2NonStandard").prop("checked"),
        W2EmployerCodes: [
            {
                EmployerCode: $("#ddlW212A").val(),
                Amount: GetZeroOnIsNullOrEmpty($.isNumeric($("#txt12AAmount").val().trim()) ? $("#txt12AAmount").val().trim():null)
            },
            {
                EmployerCode: $("#ddlW212B").val(),
                Amount: GetZeroOnIsNullOrEmpty($.isNumeric($("#txt12BAmount").val().trim()) ? $("#txt12BAmount").val().trim():null)
            },
            {
                EmployerCode: $("#ddlW212C").val(),
                Amount: GetZeroOnIsNullOrEmpty($.isNumeric($("#txt12CAmount").val().trim()) ? $("#txt12CAmount").val().trim():null)
            },
            {
                EmployerCode: $("#ddlW212D").val(),
                Amount: GetZeroOnIsNullOrEmpty($.isNumeric($("#txt12DAmount").val().trim()) ? $("#txt12DAmount").val().trim():null)
            }
        ],

        OtherDeductsBenefits: otherDeductionBenefits,

        W2StateLocalTaxInfo: StateLocalWagesInfo,



        Employer: {
            TaxableScholarshipAmount: taxableScholarshipAmount,
            HouseholdEmployeeWages: householdEmployeeWages,
            Organization: {
                Name: name,
                EIN: ein,
                Address: {
                    CompanyAddress: {
                        StreetAddress: streetAddress,
                        City: city,
                        Zip: zip,
                        StateId: stateId,
                    }
                }
            }
        }
    };

    var isW2Persist = false;
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
            isW2Persist = true;
            //Hard Stopper
            isEligibilityCheckFailed = data.isEligibilityCheckFailed;
        }
    });
    return isW2Persist;

}

function GetZeroOnIsNullOrEmpty(value) {
    if (value == "" || value == null)
        return 0;
    else {
        return value;
    }
}

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
            "FormId": w2Id,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data != null) {

                if (data.m_Item1.W2Id != 0) {
                    w2Id = data.m_Item1.W2Id;
                }
                if (data.m_Item1.EmploymentType != 0) {

                    employmentType = data.m_Item1.EmploymentType;
                }
                if (data.m_Item1.OwnerType != 0) {

                    ownerType = data.m_Item1.OwnerType;
                }

                if (data.m_Item1.EmploymentType > 0 && data.m_Item1.EmploymentType != 6 && data.m_Item1.EmploymentType != 7) {

                    if (data.m_Item1.Employer != null && data.m_Item1.Employer.Organization != null) {
                        $("#txtW2EmployerID").val(data.m_Item1.Employer.Organization.EIN),
                        $("#txtW2EmployerName").val(data.m_Item1.Employer.Organization.Name),
                        $("#txtW2EmployerAddress").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StreetAddress),
                        $("#txtW2EmployerCity").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.City),
                        $("#txtW2EmployerZip").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.Zip),
                        $("#ddlW2State").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StateId);
                    }

                    if (data.m_Item1.W2EmployerCodes != null) {
                        $.each(data.m_Item1.W2EmployerCodes, function (index, value) {
                            if (index == 0) {
                                $("#ddlW212A").val(value.EmployerCode);
                                //TODO:Vincent-NUll check should be done.
                                $("#txt12AAmount").val(value.Amount== 0 ? "": value.Amount==0 );
                            }
                            if (index == 1) {
                                $("#ddlW212B").val(value.EmployerCode);
                                //TODO:Vincent-NUll check should be done.
                                $("#txt12BAmount").val(value.Amount == 0 ? "" : value.Amount);
                            }
                            if (index == 2) {
                                $("#ddlW212C").val(value.EmployerCode);
                                //TODO:Vincent-NUll check should be done.
                                $("#txt12CAmount").val(value.Amount== 0 ? "" : value.Amount);
                            }
                            if (index == 3) {
                                $("#ddlW212D").val(value.EmployerCode);
                                //TODO:Vincent-NUll check should be done.
                                $("#txt12DAmount").val(value.Amount== 0 ? "" :value.Amount);
                            }

                        });
                    }

                    if (data.m_Item1.OtherDeductsBenefits != null) {
                        $.each(data.m_Item1.OtherDeductsBenefits, function (index, value) {
                            otherDeductionBenefitsRecordCount = index;
                            if (index != 0) {
                                AddOtherDeductionBenefits(otherDeductionBenefitsRecordCount);
                            }
                            $("#hW2OtherInfoIndex" + otherDeductionBenefitsRecordCount).val(otherDeductionBenefitsRecordCount);
                            $("#ddlW2OtherCode" + otherDeductionBenefitsRecordCount).val(value.W2OtherId);
                            $("#txtW2Description" + otherDeductionBenefitsRecordCount).val(value.Description);
                            $("#txtW2Amount" + otherDeductionBenefitsRecordCount).val(value.Amount);
                        });
                    }


                    if (data.m_Item1.W2StateLocalTaxInfo != null) {
                        $.each(data.m_Item1.W2StateLocalTaxInfo, function (index, value) {
                            stateWagesRecordCount = index;
                            if (index != 0) {
                                AddStateWages(stateWagesRecordCount);
                            }

                            if (data.m_Item1.W2StateLocalTaxInfo[stateWagesRecordCount].W2LocalTaxInfo != null) {
                                $.each(data.m_Item1.W2StateLocalTaxInfo[stateWagesRecordCount].W2LocalTaxInfo, function (index, value) {
                                    localTaxInfoRecordCount = stateWagesRecordCount;
                                    $("#hLocalTaxInfoIndex" + localTaxInfoRecordCount).val(localTaxInfoRecordCount);
                                    $("#ddlW2AssociatedState" + localTaxInfoRecordCount).val(value.StateCode);
                                    $("#txtW2LocalWages" + localTaxInfoRecordCount).val(value.LocalWagesAmount);
                                    $("#txtW2LocalWithHeld" + localTaxInfoRecordCount).val(value.LocalTaxWithholdingAmount);
                                    $("#txtW2LocalityName" + localTaxInfoRecordCount).val(value.LocalityName);
                                });
                            }

                            $("#hLocalStateWagesIndex" + stateWagesRecordCount).val(stateWagesRecordCount);
                            $("#ddlW2Box15State" + stateWagesRecordCount).val(value.StateId);
                            $("#txtW2StateID" + stateWagesRecordCount).val(value.StateCode);
                            $("#txtW2StateWages" + stateWagesRecordCount).val(value.StateWagesAmount);
                            $("#txtW2StateWithheld" + stateWagesRecordCount).val(value.StateTaxWithholdingAmount);
                        });
                    }

                    $("#txtW2FederalWages").val(data.m_Item1.WagesAmount),
                    $("#txtW2FederalWithheld").val(data.m_Item1.FederalTaxWithholdingAmount),
                    $("#txtW2SSWages").val(data.m_Item1.SocialSecurityWagesAmount),
                    $("#txtW2SSwithheld").val(data.m_Item1.SocialSecurityTaxWithholdingAmount);
                    $("#txtW2MedicalWages").val(data.m_Item1.MedicareWagesAmount);
                    $("#txtW2MedicalWithheld").val(data.m_Item1.MedicareTaxWithholdingAmount),
                    $("#txtW2SSTips").val(data.m_Item1.SocialSecurityTipsAmount),
                    $("#txtW2AllocatedTips").val(data.m_Item1.AllocatedTipsAmount),
                    $("#txtW2DependentCare").val(data.m_Item1.DependentCareBenefitsAmount),
                    //$("#txtW2NotInUse").val(data.m_Item1.NotInUseAmount),
                    $("#rdW2Statutory").attr('checked', (data.m_Item1.IsStatutoryEmployee)),
                    $("#rdW2RetirementPlan").attr('checked', data.m_Item1.HasRetirementPlan),
                    $("#rdW2ThridPartySick").attr('checked', data.m_Item1.HasThirdPartySickPay),
                    //TODO:Vincent-After getting the value it return Zero value ,nullable should be done for NON Qualifield Plans amount. 
                    $("#txtQualifiedPlan").val(data.m_Item1.NonQualifiedPlansAmount ==0 ?"": data.m_Item1.NonQualifiedPlansAmount),
                    $("#chkW2EmployerAddress").prop("checked", data.m_Item1.HasEmployeeAddress);

                    if ($("#chkW2EmployerAddress").prop("checked") == true) {
                        $("#divEmployee").show();
                    } else {

                        $("#divEmployee").hide();
                    }

                    if (data.m_Item1.HasEmployeeAddress != null) {
                        $("#txtW2EmployeeAddress").val(data.m_Item1.EmployeeAddress.StreetAddress),
                        $("#txtW2EmployeeCity").val(data.m_Item1.EmployeeAddress.City),
                        $("#ddlW2EmployeeState").val(data.m_Item1.EmployeeAddress.StateId),
                        $("#txtW2EmployeeZip").val(data.m_Item1.EmployeeAddress.ZipCode);
                    }
                    $("#chkW2correct").prop("checked", data.m_Item1.IsCorrectedW2),
                    $("#chkW2NonStandard").prop("checked", data.m_Item1.IsNonStandardW2);
                } else if (data.m_Item1.EmploymentType == 6) {
                    if (data.m_Item1.Employer != null && data.m_Item1.Employer.Organization != null) {
                        $("#txtHouseholdEmployerName").val(data.m_Item1.Employer.Organization.Name),
                        $("#txtHouseholdEmployerAddress").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StreetAddress),
                        $("#txtHouseholdEmployerCity").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.City),
                        $("#txtHouseholdEmployerZip").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.Zip),
                        $("#txtHouseholdEmployeeWages").val(data.m_Item1.Employer.HouseholdEmployeeWages);
                        $("#ddlHouseholdEmployerState").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StateId);
                    }
                } else if (data.m_Item1.EmploymentType == 7) {
                    if (data.m_Item1.Employer != null && data.m_Item1.Employer.Organization != null) {
                        $("#txtInstitutionName").val(data.m_Item1.Employer.Organization.Name),
                        $("#txtInstitutionAddress").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StreetAddress),
                        $("#txtInstitutionCity").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.City),
                        $("#txtInstitutionZip").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.Zip),
                        $("#txtTaxableScholarshipAmount").val(data.m_Item1.Employer.TaxableScholarshipAmount);
                        $("#ddlInstitutionState").val(data.m_Item1.Employer.Organization.Address.CompanyAddress.StateId);
                    }
                }
            }
        }
    });

    if (employmentType == 6 || employmentType == 7) {
        $('.W2Employment').hide();
        if (employmentType == 6) {
            $('#divInstution').hide();
        } else if (employmentType == 7) {
            $('#divHouseHold').hide();
        }
    } else {
        $('#divHouseHold').hide();
        $('#divInstution').hide();
    }
}


function AddOtherDeductionBenefits(rowIndex) {
    var newBox14OtherDeductionBenefits = ' <div class="pangird itm" id="divBox14OtherInformation' + rowIndex + '">' +
        ' <input type="hidden" id="hW2OtherInfoIndex' + rowIndex + '" value="' + rowIndex + '" />' +
        '<label class="col-md-4">' +
        '   <input type="text" id="txtW2Description' + rowIndex + '" class="form-control" />' +
        '</label>' +
        '<label class="col-md-4">' +
        '   <input type="text" id="txtW2Amount' + rowIndex + '" class="form-control" />' +
        '</label>' +
        '<label class="col-md-4">' +
        '   <select name="ddlW2OtherCode"  ID="ddlW2OtherCode' + rowIndex + '"  >' +
        '        </select>' +
        '   </label>' +
        ' </div>';


    $('#divBox14OtherInformation').append(newBox14OtherDeductionBenefits);

    $("#txtW2Amount" + rowIndex ).bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });


    $.each(box14OtherCode, function (key, value) {
        $('#ddlW2OtherCode' + rowIndex).append($("<option></option>").val(value.Value).html(value.Text));
    });
}


function AddStateWages(rowIndex) {
    //StateWages
    var newStateWages = '  <div id="divLocalStateWagesInfo"> ' +
           ' <div id="divLocalStateWagesInfo' + rowIndex + '"> ' +
           '     <input type="hidden" id="hLocalStateWagesIndex' + rowIndex + '" value="' + rowIndex + '" /> ' +
           '   <label class="col-md-3" id="lblEmployerName"> ' +
           '     <select id="ddlW2Box15State' + rowIndex + '" name="ddlBox15State"> ' +
           '   </select> ' +
           ' </label> ' +
           ' <label class="col-md-3"> ' +
           '   <input type="text" id="txtW2StateID' + rowIndex + '" class="form-control" /> ' +
           ' </label> ' +
           ' <label class="col-md-3"> ' +
           ' <input type="text" id="txtW2StateWages' + rowIndex + '" class="form-control" /> ' +
           ' </label> ' +
           ' <label class="col-md-3"> ' +
           '             <input type="text" id="txtW2StateWithheld' + rowIndex + '" class="form-control" /> ' +
           '       </label> ' +
           ' </div> ' +
           ' </div> ';

    $('#divLocalStateWagesInfo').append(newStateWages);
    $('#ddlW2Box15State' + rowIndex).append($("<option></option>").val(0).html('---Select---'));
    $.each(state, function (key, value) {
        $('#ddlW2Box15State' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateCode));
    });

    $("#txtW2StateWages" + rowIndex).bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2StateWithheld" + rowIndex).bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    //LocalTaxInfo
    var newLocalTaxInfo = ' <div id="divLocalTaxInfo' + rowIndex + '"> ' +
      ' <label class="col-md-3"> ' +
      '   <input type="hidden" id="hLocalTaxInfoIndex' + rowIndex + '" value="' + rowIndex + '" /> ' +
      ' <input type="text" id="txtW2LocalWages' + rowIndex + '" class="form-control" /> ' +
      ' </label> ' +
      ' <label class="col-md-3"> ' +
      '   <input type="text" id="txtW2LocalWithHeld' + rowIndex + '" class="form-control" /> ' +
      ' </label> ' +
      ' <label class="col-md-3"> ' +
      '  <input type="text" id="txtW2LocalityName' + rowIndex + '" class="form-control" /> ' +
      ' </label> ' +
      ' <label class="col-md-3"> ' +
      ' <select name="ddlW2AssociatedState" id="ddlW2AssociatedState' + rowIndex + '"> ' +
      ' </select> ' +
      ' </label> ' +
      ' </div> ';

    $('#divLocalTaxInfo').append(newLocalTaxInfo);
    $('#ddlW2AssociatedState' + rowIndex).append($("<option></option>").val(0).html('---Select---'));
    $.each(state, function (key, value) {
        $('#ddlW2AssociatedState' + rowIndex).append($("<option></option>").val(value.StateId).html(value.StateCode));
    });

    $("#txtW2LocalWages" + rowIndex).bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtW2LocalWithHeld" + rowIndex).bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
}


function RemoveDiv(divId) {
    $('#' + divId.id).remove();
    return false;
}

function NextClick() {
    PersistW2();
    return false;
}