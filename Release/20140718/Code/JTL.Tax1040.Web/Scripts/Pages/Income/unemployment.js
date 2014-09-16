
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


/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    NumbersOnly('txtPayerIdentificationNumber');

    // Swapnesh Added on 3-6-2014
    $("#frmUnemployment").validate({

        rules: {

            txtPayerIdentificationNumber:
                {
                    minlength: 10,
                    validateEINFor0000: true
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
            txtF1099GPayerZip:
               {
                   minlength: "Invalid Zip Code",
                   maxlength: "Invalid Zip Code",
                   validateZipCode: 'Invalid Zip Code'
               },
        }

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

    //Error message- focus method for user control
    isErrorMessageClickedInSummary = false;
    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    var parameters = pageURL.split('&');
    //Vincent-23Jun2014-Added a or condition for parameter length while click the error message form Review section
    if (parameters.length == 2 || parameters.length == 3) {
        isErrorMessageClickedInSummary = true;
        var controlParmeters = parameters[0];
        currentForm1099GId = parameters[1];
        var controls = controlParmeters.split('-');
        if (controls.length == 2) {

            var divToExpand = controls[0];
            var controlToFocus = controls[1];
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
            $('#' + divToExpand).addClass('panel-collapse collapse in');
            $('#' + controlToFocus).focus();
        }
    }

    //Saravanan N - 7th May, 2014 - Moved this call from Page Onload.
    GetUnemploymentById();

    SetTooltip();
    ExpandAccordian();

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

//Saravanan N - 26th May, 2014 - Method refactored.
//Yogalakshmi - 17th July 2014 - Updated Quick help content.
function SetTooltip() {
    $("#popPayerName").popover({ title: '', content: "<h5>What is Payer Name?</h5>This is the Federal or State Government organization that pays you the unemployment compensation.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerAddress").popover({ title: '', content: "<h5>What is Payer's Address?</h5>This is the address of the Federal or State Government organization that pays you the unemployment compensation. <br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerCity").popover({ title: '', content: "<h5>What is Payer's City?</h5>This is the City of  the Federal or State Government organization that pays you the unemployment compensation. <br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerState").popover({ title: '', content: "<h5>What is Payer's State?</h5>This is the State Code of Federal or State Government organization that pays you the unemployment compensation. <br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerZipCode").popover({ title: '', content: "<h5>What is Payer's Zip Code?</h5>This is the Zip Code of Federal or State Government organization that pays you the unemployment compensation. <br/>Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerFederalIdentificationNumber").popover({ title: '', content: "<h5>What is Payer's ID No?</h5>It's nothing but your Payer's Federal Identification Number (FIN).<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });


    $("#popUnemploymentCompensationReceived").popover({ title: '', content: "<h5>What is Unemployment Compensation?</h5>This is a social welfare payment allotted for unemployed citizens. <br/>If you received this compensation, you can find this info in Box 1 of Form 1099-G.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    //Yogalakshmi - 22nd May 2014 - Added content for Quick help
    $("#popRepaidAmountCurrentYear").popover({ title: '', content: "<h5>What is Repaid Amount?</h5>This is nothing but the amount you repaid for the Unemployment Compensation received during the year 2014.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popRepaidAmountPriorYear").popover({ title: '', content: "<h5>How does '2014 repayment of Unemployment Compensation for prior year benefits' affect your 1040EZ Filing?</h5>In 2014, you repaid unemployment compensation that you included in gross income in an earlier year, you can deduct the amount repaid; but you must use Form 1040 to do so.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popFederalTaxWithheld").popover({ title: '', content: "<h5>What is Federal Tax Withheld?</h5>This is the total amount of Federal Tax withheld from your wages.<br/> Box 4 of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popPayerStateID").popover({ title: '', content: "<h5>What is Payer's State ID ?</h5>It is the State Identification Number of the Government Organization that pays your unemployment compensation. <br/>Box 10b of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popStateTaxWithheld").popover({ title: '', content: "<h5>What is  State Tax withheld?</h5>This is the amount of income tax withheld from your income for State Tax purpose.<br/> Box 11 of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

    $("#popStateInformation").popover({ title: 'wwwwww', content: "<h5>What is  State Tax withheld?</h5><b>What is Payer's State ID ?</b><br/>It is the State Identification Number of the Government Organization that pays your unemployment compensation. Box 10b of Form 1099-G is where you can pick this from.<br/><b>What is  State Tax withheld?</b><br />This is the amount of income tax withheld from your income for State Tax purpose. Box 11 of Form 1099-G is where you can pick this from.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
}

//Added by Praveen on 29 May 2014 Expand Accordian on Next Click
function ExpandAccordian() {
    $('#btnNext').click(function () {
        if ($('#frmUnemployment').valid()) {
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            return false;
        }
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
        if (PersistUnemployment()) {
            window.sessionStorage.setItem("Form1099GId", JSON.stringify(''));
            //Saravanan N - 7th May, 2014 - Eligibility check occurred.
            //Yogalakshmi - 17th June 2014 - Changed UnemploymentCompensation to Unemployment Compensation.
            PageNavigation(isEligibilityCheckFailed, '../Income/unemploymentsummary.html', Topic.UnemploymentCompensation);  // 20Jun2014 Sathish replaced hard coded value with the constant
            return false;
        }
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
    if ($("#frmUnemployment").valid()) {
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
        return true;
    }
    else {
        return false;
    }
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

            if (data != null) {
                if (data.m_Item1 != null) {
                    $('#hdnForm1099gId').val(currentForm1099GId);
                    $('#txtF1099GUnempCompReceived').val(data.m_Item1.UnEmploymentCompensation);
                    $('#txtF1099GFederaltaxWithheld').val(data.m_Item1.FederalTaxWithHoldingAmount);
                    $('#chkUnemploymentRepaidForCurrentYear').prop('checked', data.m_Item1.IsCurrentYearUnemploymentRepaid);
                    $('#txtRepaidAmountCurrentYear').val(data.m_Item1.CurrentYearUnemploymentRepaid);
                    $('#chkUnemploymentRepaidForPriorYear').prop('checked', data.m_Item1.IsPriorYearUnEmploymentRepaid);
                    $('#txtRepaidAmountPriorYear').val(data.m_Item1.PriorYearUnEmploymentRepaid);


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
                        $('#txtValidationStatetaxWithheld1').val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount);
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
            }
        }
    });
   
    
}

