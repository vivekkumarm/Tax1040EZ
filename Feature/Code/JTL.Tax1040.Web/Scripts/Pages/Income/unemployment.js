
// **** Saravanan N - 8th April, 2014 - File contains javascript methods required for Unemployment.html page.****//

/********************************* MODIFICATION HISTORY SECTION **********************************/
// Saravanan N. - 9th April, 2014 - Global Variable declaration. It can be used in all the below functions.
// Vincent - 15th April 2014- added a error message navigation for required user control.
// Bala - 23rd April 2014- PayerAddress name changed as Address in Payer object.
// Sathish 28th Apr 2014 - Changed PersistForm1099G method to return user data id and form1099g ID
// Sathish 02Mat2014 - change perist to pass tax return data bo
// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var isErrorMessageClickedInSummary;
var currentForm1099GId;
var isEligibilityCheckFailed = false;
var parameters;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    NumbersOnlyNotAcceptingDot('txtPayerIdentificationNumber');

    // Swapnesh Added on 3-6-2014
    $("#frmUnemployment").validate({

        rules: {

            txtPayerIdentificationNumber:
                {
                    minlength: 10,
                    validateEINFor0000: true
                },
            //Yogalakshmi - 13th Aug 2014 - Added client side validation for City which should atleast have 3 characters
            txtF1099GPayerCity:
                {
                    minlength: 3
                },
            txtF1099GPayerZip:
                 {
                     minlength: 5,
                     maxlength: 10,
                     validateZipCode: true
                 },
        },
        messages: {

            txtPayerIdentificationNumber:
                {
                    minlength: "Invalid Payer Federal Identification Number",
                    validateEINFor0000: "Invalid Payer Federal Identification Number"
                },
            //Yogalakshmi - 13th Aug 2014 - Added client side validation for City which should atleast have 3 characters
            txtF1099GPayerCity:
                {
                    minlength: "Invalid Employer City"
                },
            txtF1099GPayerZip:
               {
                   minlength: "Invalid Zip Code",
                   maxlength: "Invalid Zip Code",
                   validateZipCode: 'Invalid Zip Code'
               },
        }

    });

    //Yogalakshmi - 18th August 2014 - Persist when accordion is closed and validates when accordion is opened.
    $('#collapseOne').on('shown.bs.collapse', function () {
        ValidateUnemploymentFirstAccordion();
    });

    $('#collapseOne').on('hidden.bs.collapse', function () {
        //validateUnemploymentFirstAccordion();
        PersistUnemployment();
        return false;
    });

    //Yogalakshmi - 20th August 2014 - Added getErrorCountAndDisableBreadcrum() to disable the breadcrum when there is an eligibility error.
    $('#collapseTwo').on('hidden.bs.collapse', function () {
        PersistUnemployment();
        getErrorCountAndDisableBreadcrum();
        return false;
    });

    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);

    //Bind keypress events to Textbox.
    BindEventsToControls();

    //Bind State to DDL.
    BindState();

    //Added By Pushparaj 05/05/2014
    $('#radPrimaryTaxPayer').prop('checked', true);

    //Yogalakshmi - 12th August 2014 - Common issue fixed - While Uncheck the Repaid amount check box, Repaid amount text box value should be removed.
    $("#chkUnemploymentRepaidForCurrentYear").click(function () {
        if ($('#chkUnemploymentRepaidForCurrentYear').prop('checked') == false) {
            $('#txtRepaidAmountCurrentYear').val('');
        }
    });
    $("#chkUnemploymentRepaidForPriorYear").click(function () {
        if ($('#chkUnemploymentRepaidForPriorYear').prop('checked') == false) {
            $('#txtRepaidAmountPriorYear').val('');
        }
    });

    //Error message- focus method for user control
    isErrorMessageClickedInSummary = false;
    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    parameters = pageURL.split('&');

    var divToExpand;
    var controlToFocus;
    //Vincent-23Jun2014-Added a or condition for parameter length while click the error message form Review section
    if (parameters.length == 2 || parameters.length == 3) {
        isErrorMessageClickedInSummary = true;
        var controlParmeters = parameters[0];
        currentForm1099GId = parameters[1];
        var controls = controlParmeters.split('-');
        if (controls.length == 2) {

            var divToExpand = controls[0];
            var controlToFocus = controls[1];
        }
    }


    SetTooltip();

    //Saravanan N - 7th May, 2014 - Moved this call from Page Onload.
    GetUnemploymentById();

    ExpandAccordian();

    $('#collapseOne input').each(function () {
        $(this).addClass('validateControl1');
    })

    $('#collapseTwo input').each(function () {
        $(this).addClass('validateControl2');
    })

    $('.validateControl1').blur(function () {
        ValidateUnemploymentFirstAccordion();
    });

    $('.validateControl2').blur(function () {
        ValidateUnemploymentSecondAccordion();
    });

    //Yogalakshmi - 26th August 2014 - Added to validate the accfirst accordion
    ValidateUnemploymentFirstAccordion();
    ValidateUnemploymentSecondAccordion();

    if (divToExpand != null && controlToFocus != null) {
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
});

//Saravanan N - 27th Aug, 2014 - First accordion's client side validated controls' status verified here.
function GetFirstAccordionClientSideValidationStatus() {
    var isValidationFailed = false;
    var isPayerCityValid = $('#txtF1099GPayerCity').valid();
    var isPayerZipValid = $('#txtF1099GPayerZip').valid();
    var isPayerIdNumberValid = $('#txtPayerIdentificationNumber').valid();

    if (!isPayerCityValid || !isPayerZipValid || !isPayerIdNumberValid) {
        isValidationFailed = true;
    }
    return isValidationFailed;
}

function GetFirstAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseOne input:text, select').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

function GetSecondAccordionServerSideValidationStatus() {
    var isValidationFailed = false;
    $('#collapseTwo input:text, select').each(function () {
        if ($(this).hasClass('error')) {
            isValidationFailed = true;
        }
    });

    return isValidationFailed;
}

//Yogalakshmi- 26th Aug, 2014 - Added method to validate Employer Information (first) accordion.
function ValidateUnemploymentFirstAccordion() {
    var isClientSideValidationFailed = GetFirstAccordionClientSideValidationStatus();
    var isServerSideValidationFailed = GetFirstAccordionServerSideValidationStatus();

    //If all the first accordion control client side validation pass then remove the error class orElse Add. - Saravanan N - 27th Aug, 2014.
    if (isClientSideValidationFailed || isServerSideValidationFailed) {
        $('#collpselinkone').addClass('error');
    }
    else {
        $('#collpselinkone').removeClass('error');
    }
}

function ValidateUnemploymentSecondAccordion() {
    if (GetSecondAccordionServerSideValidationStatus()) {
        $('#collpselinktwo').addClass('error');
    }
    else {
        $('#collpselinktwo').removeClass('error');
    }
}

/*************************************** COMMON FUNCTIONS SECTION *********************************/

//Saravanan N - 26th May, 2014 - Method refactored.
//Yogalakshmi - 17th July 2014 - Updated Quick help content.
//Yogalakshmi - 5th August 2014 -  Changes done for Quick Help flickering Problem 
function SetTooltip() {
    $("#popPayerName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Payer Name?</h5>This is the Federal or State Government organization that pays you the unemployment compensation.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerAddress").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Payer's Address?</h5>This is the address of the Federal or State Government organization that pays you the unemployment compensation. <br/><br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerCity").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Payer's City?</h5>This is the City of  the Federal or State Government organization that pays you the unemployment compensation. <br/><br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerState").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Payer's State?</h5>This is the State Code of Federal or State Government organization that pays you the unemployment compensation. <br/><br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerZipCode").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Payer's Zip Code?</h5>This is the Zip Code of Federal or State Government organization that pays you the unemployment compensation. <br/><br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerFederalIdentificationNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Payer FIN'?</h5>It is the Federal Identification Number (FIN) allotted to the Payer who provides you unemployment compensation.<br/><br/> Fill it in exactly as it appears on your Form 1099-G.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });


    $("#popUnemploymentCompensationReceived").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Unemployment Compensation?</h5>This is a social welfare payment allotted for unemployed citizens. <br/><br/>If you received this compensation, you can find this info in Box 1 of Form 1099-G.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    //Yogalakshmi - 22nd May 2014 - Added content for Quick help
    $("#popRepaidAmountCurrentYear").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Repaid Amount?</h5>This is nothing but the amount you repaid for the Unemployment Compensation received during the year 2014.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popRepaidAmountPriorYear").popover({ title: 'Quick Help', html: 'true', content: "<h5>How does '2014 repayment of Unemployment Compensation for prior year benefits' affect your 1040EZ Filing?</h5>In 2014, you repaid unemployment compensation that you included in gross income in an earlier year, you can deduct the amount repaid; but you must use Form 1040 to do so.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popFederalTaxWithheld").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Federal Tax Withheld?</h5>This is the total amount of Federal Tax Withheld from your wages.<br/><br/> Box 4 of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerStateID").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Payer's State ID ?</h5>It is the State Identification Number of the Government Organization that pays your unemployment compensation. <br/><br/>Box 10b of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popStateTaxWithheld").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is  State Tax Withheld?</h5>This is the amount of Income Tax Withheld from your income for State Tax purpose.<br/><br/> Box 11 of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popStateInformation").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is the State Code asked here?</h5>This is the two digit Code of the State in which you are eligible for any Unemployment Benefits.<br/><br/>Box 10a of Form 1099-G is where you can pick this from.<br/><br/><h5>What is Payer's State ID ?</h5>It is the State Identification Number of the Government Organization that pays your unemployment compensation.<br/><br/> Box 10b of Form 1099-G is where you can pick this from.<br/><br/><h5>What is  State Tax Withheld?</h5>This is the amount of Income Tax Withheld from your income for State Tax purpose.<br/><br/> Box 11 of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
}

//Added by Praveen on 29 May 2014 Expand Accordian on Next Click
function ExpandAccordian() {
    $('#btnNext').click(function () {
        //if ($('#frmUnemployment').valid()) {
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            return false;
        //}
    });
}

//Saravanan N - 26th May, 2014 - Method refactored.
function BindEventsToControls() {
    $("#txtF1099GPayerAddress").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^a-zA-Z0-9- ]/g, ''));
        }, $(this)), 0);
    });

    //Yogalakshmi - 23rd May 2014 - Changed Keyup to keypress
    $("#txtF1099GPayerName").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^a-zA-Z0-9- ]/g, ''));
        }, $(this)), 0);
    });

    //Yogalakshmi - 23rd May 2014 - To allow space 
    $("#txtF1099GPayerCity").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^a-zA-Z ]/g, ''));
        }, $(this)), 0);
    });

    //Yogalalkshmi - 4th July 2014 - Added for back arrow and cursor jumb  problems
    NumbersOnlyNotAcceptingDot('txtF1099GPayerZip');
    ////Yogalakshmi - 29th May 2014 - Removed (-) so that it allows only numbers.
    //$("#txtF1099GPayerZip").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9]/g, ''));
    //    }, $(this)), 0);
    //});

    //Yogalalkshmi - 4th July 2014 - Added for back arrow and cursor jumb  problems
    NumbersOnly('txtPayerIdentificationNumber');
    ////Yogalakshmi - 29th May 2014 - Removed (-) so that it allows only numbers.
    //$("#txtPayerIdentificationNumber").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});

    //$("#txtF1099GUnempCompReceived").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtF1099GUnempCompReceived');

    //$("#txtF1099GFederaltaxWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtF1099GFederaltaxWithheld');

    //$("#txtValidationStatetaxWithheld1").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtValidationStatetaxWithheld1');

    NumbersOnly('txtRepaidAmountCurrentYear');

    //$("#txtRepaidAmountCurrentYear").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    //$("#txtRepaidAmountPriorYear").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtRepaidAmountPriorYear');

    //Saravanan N - 8th April, 2014 
    $('#chkUnemploymentRepaidForCurrentYear').click(function () {
        UnemploymentRepaidForCurrentYearDivVisibility();
    });

    //Saravanan N - 8th April, 2014
    $('#chkUnemploymentRepaidForPriorYear').click(function () {
        UnemployementRepaidForPriorYearDivVisibility();
    });

    ////Saravanan N - 7th May, 2014 - Moved from HTML page.
    //$('#btnBack').click(function() {
    //    return false;
    //});

    //Saravanan N - 7th May, 2014 - Moved from HTML page.
    $('#btnContinue').click(function () {
        //if (PersistUnemployment()) {
            PersistUnemployment();
            window.sessionStorage.setItem("Form1099GId", JSON.stringify(''));
            //Saravanan N - 7th May, 2014 - Eligibility check occurred.
            //Yogalakshmi - 17th June 2014 - Changed UnemploymentCompensation to Unemployment Compensation.
            PageNavigation(isEligibilityCheckFailed, '../Income/unemploymentsummary.html', Topic.UnemploymentCompensation);  // 20Jun2014 Sathish replaced hard coded value with the constant
            return false;
        //}
    });

    $('#btnNext').click(function () {
        PersistUnemployment();
        $('#collpselinkone').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#collpselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
        return false;
    });
   

    $('#btnBack').click(function () {
        //Added by Ashok Kumar Back Button Persist - DefectID - TAX1040-14039
        if (currentForm1099GId > 0) {
            PersistUnemployment();
        }
        GoToPreviousPage();
        return false;
    });
}

//Saravanan N - 26th May, 2014 - Method refactored.
function BindState() {
    //Display state in Dropdownlist.
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
            //Yogalakshmi - 20th MAy 2014 - Added to bind the initial value in the dropdown.
            $("#ddlF1099GEmployerState1").append($("<option></option>").val(0).html('---Select---'));
            //Yogalakshmi - 22nd MAy 2014 - Added to bind the initial value in the dropdown.
            $("#ddlF1099GState").append($("<option></option>").val(0).html('---Select---'));
            $.each(data, function (key, value) {
                //Yogalakshmi - 20th MAy 2014 - Changed the value to state code.
                $("#ddlF1099GEmployerState1").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlF1099GState").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });
}

//Saravanan N - 8th April, 2014
function UnemploymentRepaidForCurrentYearDivVisibility() {
    if ($('#chkUnemploymentRepaidForCurrentYear').is(':checked')) {
        $('#divRepaidAmountCurrentYear').css('display', 'block');
    }
    else {
        $('#divRepaidAmountCurrentYear').css('display', 'none');
    }
}

//Saravanan N - 8th April, 2014
function UnemployementRepaidForPriorYearDivVisibility() {
    if ($('#chkUnemploymentRepaidForPriorYear').is(':checked')) {
        $('#divRepaidAmountPriorYear').css('display', 'block');
    }
    else {
        $('#divRepaidAmountPriorYear').css('display', 'none');
    }
}

//Persist Form1099G
function PersistUnemployment() {
    //if ($("#frmUnemployment").valid())
    //{
        //TODO: If Div is hidden then update 0 in ownerType. - Saravanan 
        var ownerType = $("input:radio:checked").val() > 0 ? $("input:radio:checked").val() : 0;
        var unEmploymentCompensationReceived;
        var federalTaxWithheld;
        var repaidForCurrentYear;
        var repaidForPriorYear;
        var stateTaxWithheld1;
        var form1099gId;
        //Yogalakshmi - 20th May 2014 - 0 is removed as it has nullable check in BO.
        if (!$('#chkUnemploymentRepaidForPriorYear').is(':checked')) {
            $('#txtRepaidAmountPriorYear').val('');
        }
        if (!$('#chkUnemploymentRepaidForCurrentYear').is(':checked')) {
            $('#txtRepaidAmountCurrentYear').val('');
        }

        unEmploymentCompensationReceived = $('#txtF1099GUnempCompReceived').val();
        federalTaxWithheld = $('#txtF1099GFederaltaxWithheld').val();
        repaidForCurrentYear = $('#txtRepaidAmountCurrentYear').val();
        repaidForPriorYear = $('#txtRepaidAmountPriorYear').val();
        stateTaxWithheld1 = $('#txtValidationStatetaxWithheld1').val();
        if ($('#hdnForm1099gId').val().trim().length == 0) {
            form1099gId = '0';
        }
        else {
            form1099gId = $('#hdnForm1099gId').val();
        }

        var form1099G = {
            Form1099GId: form1099gId,
            OwnerType: ownerType,
            UnEmploymentCompensation: unEmploymentCompensationReceived,
            FederalTaxWithHoldingAmount: federalTaxWithheld,
            IsCurrentYearUnemploymentRepaid: $('#chkUnemploymentRepaidForCurrentYear').prop('checked'),
            CurrentYearUnemploymentRepaid: repaidForCurrentYear,
            IsPriorYearUnEmploymentRepaid: $('#chkUnemploymentRepaidForPriorYear').prop('checked'),
            PriorYearUnEmploymentRepaid: repaidForPriorYear,
            Payer: {
                PayerName: $('#txtF1099GPayerName').val(),
                PayerIdentificationNumber: $('#txtPayerIdentificationNumber').val(),
                Address:
                {
                    PayerAddress:
                        {
                            State: {
                                StateId: $('#ddlF1099GState').val()
                            },
                            StreetAddress: $('#txtF1099GPayerAddress').val(),
                            City: $('#txtF1099GPayerCity').val(),
                            ZipCode: $('#txtF1099GPayerZip').val()
                            
                        }
                },
            },
            Form1099StateInfo:
                [
                    {
                        State: {
                            StateId: $('#ddlF1099GEmployerState1').val(),
                            StateCode: $('#ddlF1099GEmployerState1 option:selected').text(),
                        },
                        StateIdentificationNumber: $('#txtF1099GPayerState1').val(),
                        StateTaxWithholdingAmount: stateTaxWithheld1
                    }
                ]
        };

        $.ajax({
            url: serviceUrl + 'unemployment/persistunemployment',
            async: false,
            dataType: 'json',
            type: 'POST',
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                userId: userId,
                TaxReturnData:
                    {
                        UserDataId: userDataId,
                        TaxData: JSON.stringify(form1099G),
                    }
            }),
            contentType: 'application/json; charset=utf-8',
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("Form1099GId", JSON.stringify(data.Form1099GId));
                window.sessionStorage.setItem("UserDataId", JSON.stringify(data.UserDataId));
                $('#hdnForm1099gId').val(data.Form1099GId);
                //Saravanan N - 7th May, 2014 - Hard Stop eligibility check.
                isEligibilityCheckFailed = data.isEligibilityCheckFailed;
            }
        });
        //return true;
    //}
    //else {
    //    return false;
    //}
}

//Saravanan N - Get Form1099G value by Form1099GId.
function GetUnemploymentById() {

    //Vincent - added summary method check.
    if (isErrorMessageClickedInSummary == false) {
        var sPageURL = window.location.search.substring(1);
        var sParameterName = sPageURL.split('=');

        //While coming from Summary page (EDIT) this param. will set.
        if (sParameterName.toString().indexOf('Form1099GId') == 0) {
            currentForm1099GId = sParameterName[1];
        } else {
            currentForm1099GId = JSON.parse(window.sessionStorage.getItem("Form1099GId"));
        }

    }
    $.ajax({
        url: serviceUrl + 'unemployment/getunemploymentbyid',
        async: false,
        dataType: 'json',
        type: 'POST',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId,
            FormId: currentForm1099GId

        }),
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            //Yogalakshmi - 19th August 2014 - All the amount field should be fixed to two zeros after the decimal point - fixed.
            if (data != null) {
                if (data.m_Item1 != null) {
                    $('#hdnForm1099gId').val(currentForm1099GId);
                    $('#txtF1099GUnempCompReceived').val(data.m_Item1.UnEmploymentCompensation == null ? "" : data.m_Item1.UnEmploymentCompensation.toFixed(2));
                    $('#txtF1099GFederaltaxWithheld').val(data.m_Item1.FederalTaxWithHoldingAmount == null ? "" : data.m_Item1.FederalTaxWithHoldingAmount.toFixed(2));
                    $('#chkUnemploymentRepaidForCurrentYear').prop('checked', data.m_Item1.IsCurrentYearUnemploymentRepaid);
                    $('#txtRepaidAmountCurrentYear').val(data.m_Item1.CurrentYearUnemploymentRepaid == null ? "" : data.m_Item1.CurrentYearUnemploymentRepaid.toFixed(2));
                    $('#chkUnemploymentRepaidForPriorYear').prop('checked', data.m_Item1.IsPriorYearUnEmploymentRepaid);
                    $('#txtRepaidAmountPriorYear').val(data.m_Item1.PriorYearUnEmploymentRepaid == null ? "" : data.m_Item1.PriorYearUnEmploymentRepaid.toFixed(2));


                    if (data.m_Item1.Payer != null) {
                        $('#txtF1099GPayerName').val(data.m_Item1.Payer.PayerName);
                        $('#txtPayerIdentificationNumber').val(data.m_Item1.Payer.PayerIdentificationNumber);
                    }

                    if (data.m_Item1.Payer.Address != null && data.m_Item1.Payer.Address.PayerAddress != null) {
                        $('#txtF1099GPayerAddress').val(data.m_Item1.Payer.Address.PayerAddress.StreetAddress);
                        $('#txtF1099GPayerCity').val(data.m_Item1.Payer.Address.PayerAddress.City);
                        $('#ddlF1099GState').val(data.m_Item1.Payer.Address.PayerAddress.State.StateId);
                        $('#txtF1099GPayerZip').val(data.m_Item1.Payer.Address.PayerAddress.ZipCode);
                    }

                    if (data.m_Item1.Form1099StateInfo != null) {
                        if (data.m_Item1.Form1099StateInfo[0].State != null)
                            $('#ddlF1099GEmployerState1').val(data.m_Item1.Form1099StateInfo[0].State.StateId);
                        $('#txtF1099GPayerState1').val(data.m_Item1.Form1099StateInfo[0].StateIdentificationNumber);
                        $('#txtValidationStatetaxWithheld1').val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount == null ? "" : data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount.toFixed(2));
                    }
                }

                //Saravanan N - 8th April, 2014 - UnemploymentRepaid corresponding Div visibility.
                UnemploymentRepaidForCurrentYearDivVisibility();
                UnemployementRepaidForPriorYearDivVisibility();

                //Saravanan N - 8th April, 2014 - Tax Payer radio buttons visibility check.
                if (data.m_Item4 != null && data.m_Item4 == FILING_STATUS_MFJ) {
                    $('#divTaxPayerRadioBtn').show();

                    //Defect ID : TAX1040-13959 - Saravanan N - 5th June, 2014 - Assigned value to Span controls based on condition.
                    $('#spTaxpayer').html((data.m_Item2 != null && data.m_Item2.trim().length > 0) ? data.m_Item2 : 'Taxpayer');
                    $('#SpSpouse').html((data.m_Item3 != null && data.m_Item3.trim().length > 0) ? data.m_Item3 : 'Spouse');

                    //Saravanan N - 8th April, 2014 - Decide which radio button has to be selected.
                    if (data.m_Item1 != null && data.m_Item1.OwnerType == '1') {
                        $('#radPrimaryTaxPayer').prop('checked', true);
                    }
                    else if (data.m_Item1.OwnerType == '2') {
                        $('#radSpouseTaxPayer').prop('checked', true);
                    }
                }
                else {
                    $('#divTaxPayerRadioBtn').hide();
                }
                //Yogalakshmi - 25th August 2014 - Added to validate
                //$("#frmUnemployment").valid();

                //vivek - 6-Aug-14 - Added the focus for the error message control focus 
                if (data.m_Item5 != null) {
                    if (parameters != undefined && parameters.length == 2 || parameters.length == 3) {
                        $.each(data.m_Item5, function (index, value) {

                            var rfparameterName = value.FieldName.split('-');
                            if (rfparameterName.length == 2) {
                                var controlToFocus = rfparameterName[1];
                                $('#' + controlToFocus).removeClass("form-control tip").addClass("tip error");
                                //06Aug2014 Sathish add onblur event to the control to remove error class
                                RemoveControlHighlighting(controlToFocus);
                            }
                        });
                    }
                }
            }
        }
    });
   
    
}

