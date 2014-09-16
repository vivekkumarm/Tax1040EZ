
// **** Saravanan N - 8th April, 2014 - File contains javascript methods required for Unemployment.html page.****//

/********************************* MODIFICATION HISTORY SECTION **********************************/
// Saravanan N. - 9th April, 2014 - Global Variable declaration. It can be used in all the below functions.
// Vincent - 15th April 2014- added a error message navigation for required user control.
// Bala - 23rd April 2014- PayerAddress name changed as Address in Payer object.
// Sathish 28th Apr 2014 - Changed PersistForm1099G method to return user data id and form1099g ID
// Sathish 02Mat2014 - change perist to pass tax return data bo

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var fromSummary;
var currentForm1099GId;
var isEligibilityCheckFailed = false;


/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added By Pushparaj 05/05/2014
    $('#radPrimaryTaxPayer').prop('checked', true);

    //Error message- focus method for user control
    fromSummary = false;
    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    var parameters = pageURL.split('&');
    if (parameters.length == 2) {
        fromSummary = true;
        var controlParmeters = parameters[0];
        currentForm1099GId = parameters[1];
        var controls = controlParmeters.split('-')
        if (controls.length == 2) {

            var divToExpand = controls[0];
            var controlToFocus = controls[1];
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse')
            $('#' + divToExpand).addClass('panel-collapse collapse in');
            $('#' + controlToFocus).focus();
        }
    }

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
            $.each(data, function (key, value) {
                $("#ddlF1099GEmployerState1").append($("<option></option>").val(value.StateId).html(value.StateName));
                //Saravanan N - 8th May, 2014 - As discussed with BA and Praveen commented the second row of State Information section for now.
                //$("#ddlF1099GEmployerState2").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlF1099GState").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });

    //Saravanan N - 8th April, 2014 
    $('#chkUnemploymentRepaidForCurrentYear').click(function () {
        UnemploymentRepaidForCurrentYearDivVisibility();
    });

    //Saravanan N - 8th April, 2014
    $('#chkUnemploymentRepaidForPriorYear').click(function () {
        UnemployementRepaidForPriorYearDivVisibility();
    });

    //Saravanan N - 7th May, 2014 - Moved from HTML page.
    $('#btnBack').click(function () {
        return false;
    })

    //Saravanan N - 7th May, 2014 - Moved from HTML page.
    $('#btnContinue').click(function () {
        PersistUnemployment();
        //Saravanan N - 7th May, 2014 - Eligibility check occurred.
        PageNavigation(isEligibilityCheckFailed, '../Income/unemploymentsummary.html', 'UnemploymentCompensation');
        return false;
    });

    $('#btnNext').click(function () {
        PersistUnemployment();
        return false;
    })

    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    })

    //TODO: Saravanan N - 8th May, 2014 - Validate
    $("#frmUnemployment").validate({
        rules: {
            txtF1099GUnempCompReceived:
                {
                    numericOnly: true
                }
        }
    });

    $.validator.addMethod('numericOnly', function (value) {
        return /^[0-9]+$/.test(value);
    }, 'Please only enter numeric values (0-9)');

    //Saravanan N - 7th May, 2014 - Moved this call from Page Onload.
    GetUnemploymentById();

    $(function () {
        $("#popPayeName").popover({ title: '', content: "<h5>Payer Name</h5><br />Name of the Taxpayer.  Specify your full name including your last name or your family name./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popPayerAddress").popover({ title: '', content: "<h5>Payer Address</h5><br />Complete address of the location where you reside./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerCity").popover({ title: '', content: "<h5>Payer City</h5><br />Name of the city you reside./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerState").popover({ title: '', content: "<h5>Payer State</h5><br />Select the name of the State you belong to from the drop down./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerZipCode").popover({ title: '', content: "<h5>Payer ZipCode</h5><br />Five digit number for identifying the exact geographical region of your residing area../> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerFederalIdentificationNumber").popover({ title: '', content: "<h5>Payer's Federal Identification Number</h5><br />Payer's Federal Identification Number is your Employer Identification Number.Unique 9 digit number assigned by IRS to an individual for the purpose of identification. You can find the digits of EIN in the format as XX-XXXXXXX./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popUnemploymentCompensationReceived").popover({ title: '', content: "<h5>Box 1 Unemployment Compensation Received</h5><br />Total amount of unemployment compensation received in the form of benefits, insurance plan and any other extra benefits./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popFederalTaxWithheld").popover({ title: '', content: "<h5>Box4 Federal tax withheld</h5><br />Total amount of Federal tax withheld for unemployment benefits./> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerStateID").popover({ title: '', content: "<h5>Box 10b Payer's State ID</h5><br />State Taxpayer Identification number is assigned by the state authority to an individual tax payer for identification purpose./> <a href='' target='_blank' class='more'>Read Common Question</a>" });


        $("#popStateTaxWithheld").popover({ title: '', content: "<h5>Box 11 State Tax Withheld</h5><br />Total amount of State tax withheld for  any unemployment benefits./> <a href='' target='_blank' class='more'>Read Common Question</a>" });





    });
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
//Saravanan N - 8th April, 2014
function UnemploymentRepaidForCurrentYearDivVisibility() {
    if ($('#chkUnemploymentRepaidForCurrentYear').is(':checked')) {
        $('#divRepaidAmountCurrentYear').css('display', 'inline');
    }
    else {
        $('#divRepaidAmountCurrentYear').css('display', 'none');
    }
}

//Saravanan N - 8th April, 2014
function UnemployementRepaidForPriorYearDivVisibility() {
    if ($('#chkUnemploymentRepaidForPriorYear').is(':checked')) {
        $('#divRepaidAmountPriorYear').css('display', 'inline');
    }
    else {
        $('#divRepaidAmountPriorYear').css('display', 'none');
    }
}

//Persist Form1099G
function PersistUnemployment() {
    //TODO: If Div is hidden then update 0 in ownerType. - Saravanan 
    var ownerType = $("input:radio:checked").val() > 0 ? $("input:radio:checked").val() : 0;
    var unEmploymentCompensationReceived;
    var federalTaxWithheld;
    var repaidForCurrentYear;
    var repaidForPriorYear;
    var stateTaxWithheld1;
    var stateTaxWithheld2;
    var form1099gId;

    if (!$('#chkUnemploymentRepaidForPriorYear').is(':checked')) {
        $('#txtRepaidAmountPriorYear').val('0');
    }

    if (!$('#chkUnemploymentRepaidForCurrentYear').is(':checked')) {
        $('#txtRepaidAmountCurrentYear').val('0')
    }

    unEmploymentCompensationReceived = $('#txtF1099GUnempCompReceived').val();
    federalTaxWithheld = $('#txtF1099GFederaltaxWithheld').val();
    repaidForCurrentYear = $('#txtRepaidAmountCurrentYear').val();
    repaidForPriorYear = $('#txtRepaidAmountPriorYear').val();
    stateTaxWithheld1 = $('#txtF1099GStateTaxWithheld1').val();
    stateTaxWithheld2 = $('#txtF1099GStateTaxWithheld2').val();
    if ($('#hdnForm1099gId').val().trim().length == 0) {
        form1099gId = '0';
    }
    else {
        form1099gId = $('#hdnForm1099gId').val();
    }

    //TODO: Saravanan N - 7th May, 2014 - It will be removed after testing.
    //if ($('#txtF1099GUnempCompReceived').val().trim().length == 0) {
    //    unEmploymentCompensationReceived = '0';
    //}
    //else {
    //    unEmploymentCompensationReceived = $('#txtF1099GUnempCompReceived').val();
    //}

    //if ($('#txtF1099GFederaltaxWithheld').val().trim().length == 0) {
    //    federalTaxWithheld = '0';
    //}
    //else {
    //    federalTaxWithheld = $('#txtF1099GFederaltaxWithheld').val();
    //}

    //if ($('#txtRepaidAmountCurrentYear').val().trim().length == 0) {
    //    repaidForCurrentYear = '0';
    //}
    //else {
    //    repaidForCurrentYear = $('#txtRepaidAmountCurrentYear').val();
    //}

    //if ($('#txtRepaidAmountPriorYear').val().trim().length == 0) {
    //    repaidForPriorYear = '0';
    //}
    //else {
    //    repaidForPriorYear = $('#txtRepaidAmountPriorYear').val();
    //}

    //if ($('#txtF1099GStateTaxWithheld1').val().trim().length == 0) {
    //    stateTaxWithheld1 = '0';
    //}
    //else {
    //    stateTaxWithheld1 = $('#txtF1099GStateTaxWithheld1').val();
    //}

    //if ($('#txtF1099GStateTaxWithheld2').val().trim().length == 0) {
    //    stateTaxWithheld2 = '0';
    //}
    //else {
    //    stateTaxWithheld2 = $('#txtF1099GStateTaxWithheld2').val();
    //}


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
                        StreetAddress: $('#txtF1099GPayerAddress').val(),
                        City: $('#txtF1099GPayerCity').val(),
                        StateId: $('#ddlF1099GState').val(),
                        ZipCode: $('#txtF1099GPayerZip').val()
                    }
            },
        },
        Form1099StateInfo:
            [
                {
                    StateId: $('#ddlF1099GEmployerState1').val(),
                    StateIdentificationNumber: $('#txtF1099GPayerState1').val(),
                    StateTaxWithholdingAmount: stateTaxWithheld1
                },
                //Saravanan N - 8th May, 2014 - As discussed with BA and Praveen commented the second row of State Information section for now.
                //{
                //    StateId: $('#ddlF1099GEmployerState2').val(),
                //    StateIdentificationNumber: $('#txtF1099GPayerState2').val(),
                //    StateTaxWithholdingAmount: stateTaxWithheld2
                //}
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
}

//Saravanan N - Get Form1099G value by Form1099GId.
function GetUnemploymentById() {

    //Vincent - added summary method check.
    if (fromSummary == false) {
        var sPageURL = window.location.search.substring(1);
        var sParameterName = sPageURL.split('=');
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
                    $('#txtF1099GUnempCompReceived').val(data.m_Item1.UnEmploymentCompensation),
                    $('#txtF1099GFederaltaxWithheld').val(data.m_Item1.FederalTaxWithHoldingAmount),
                    $('#chkUnemploymentRepaidForCurrentYear').prop('checked', data.m_Item1.IsCurrentYearUnemploymentRepaid),
                    $('#txtRepaidAmountCurrentYear').val(data.m_Item1.CurrentYearUnemploymentRepaid),
                    $('#chkUnemploymentRepaidForPriorYear').prop('checked', data.m_Item1.IsPriorYearUnEmploymentRepaid),
                    $('#txtRepaidAmountPriorYear').val(data.m_Item1.PriorYearUnEmploymentRepaid);


                    if (data.m_Item1.Payer != null) {
                        $('#txtF1099GPayerName').val(data.m_Item1.Payer.PayerName),
                        $('#txtPayerIdentificationNumber').val(data.m_Item1.Payer.PayerIdentificationNumber);
                    }

                    if (data.m_Item1.Payer.Address != null && data.m_Item1.Payer.Address.PayerAddress != null) {
                        $('#txtF1099GPayerAddress').val(data.m_Item1.Payer.Address.PayerAddress.StreetAddress),
                        $('#txtF1099GPayerCity').val(data.m_Item1.Payer.Address.PayerAddress.City),
                        $('#ddlF1099GState').val(data.m_Item1.Payer.Address.PayerAddress.StateId),
                        $('#txtF1099GPayerZip').val(data.m_Item1.Payer.Address.PayerAddress.ZipCode);
                    }

                    if (data.m_Item1.Form1099StateInfo != null) {
                        $('#ddlF1099GEmployerState1').val(data.m_Item1.Form1099StateInfo[0].StateId),
                        $('#txtF1099GPayerState1').val(data.m_Item1.Form1099StateInfo[0].StateIdentificationNumber),
                        $('#txtF1099GStateTaxWithheld1').val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount)
                        //Saravanan N - 8th May, 2014 - As discussed with BA and Praveen commented the second row of State Information section for now.
                        //$('#ddlF1099GEmployerState2').val(data.m_Item1.Form1099StateInfo[1].StateId),
                        //$('#txtF1099GPayerState2').val(data.m_Item1.Form1099StateInfo[1].StateIdentificationNumber),
                        //$('#txtF1099GStateTaxWithheld2').val(data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount);
                    }
                }

                //Saravanan N - 8th April, 2014 - UnemploymentRepaid corresponding Div visibility.
                UnemploymentRepaidForCurrentYearDivVisibility();
                UnemployementRepaidForPriorYearDivVisibility();

                //Saravanan N - 8th April, 2014 - Tax Payer radio buttons visibility check.
                if (data.m_Item4 != null && data.m_Item4 == 2) {
                    $('#divTaxPayerRadioBtn').show();
                    $('#lblPrimaryTaxPayer').html(data.m_Item2);
                    $('#lblSpouseTaxPayer').html(data.m_Item3);

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


