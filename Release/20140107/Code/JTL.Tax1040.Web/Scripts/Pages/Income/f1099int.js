////7 Apr 2014 added the script for Form1099INT
//Script for f1099INT

//Vincent - 16th April 2014- added a error message navigation for required user control.
//Vincent - 23 Apr 2014 - Added ToggleTaxExempt() method to toggle the Tax exempt accordion.
//Sathish - 03May2014 Used Tax Return Data BO for persist
//Vincent-26May2014-Refatored the code for Get and Persist method

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var F1099INTPersistData, f1099INT;
var form1099INTId;
var isEligibilityCheckFailed = false;
var controlParmeters;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    //Getting the ID form Session.
    if (!window.sessionStorage.Form1099INTId) {
        form1099INTId = 0;
    } else {
        form1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
    }

    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    var parameters = pageURL.split('&');

    //Click on INT Error Message in InterestIncome Summary Diagnostic page, the below code will be executed.
    if (parameters.length == 3) {
        controlParmeters = parameters[0];
        var FormType = parameters[2];

        //Form Type INT
        if (FormType.toString() == 'FormINT') {
            form1099INTId = parameters[1];

        }
    }

    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('Form1099INTId') == 0) {
        form1099INTId = parameterName[1];
    }

    //Saravanan N - 27th May, 2014 - Moved code to separate functions.
    populateState();
    populateCountry();
    bindEvents();
    F1099INTGetData();
    setPopup();

    //Defect # TAX1040-13968 - Vivek - 10th June, 2014.
    if (controlParmeters != null && controlParmeters.trim().length > 0) {
        var controls = controlParmeters.split('-');
        if (controls.length == 2) {
            var divToExpand = controls[0];
            var controlToFocus = controls[1];
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            $('#' + divToExpand).addClass('panel-collapse collapse in');
            $('#' + controlToFocus).focus();
        }
    }
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
//Saravanan N - 27th May, 2014 - Refactored method.
function populateState() {
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
            $("#ddlPayerStateCode").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlStateExemptCode").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlPayerStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateExemptCode").append($("<option></option>").val(value.StateId).html(value.StateCode));

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function populateCountry() {
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
            $("#ddlForeginCountryID").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlForeginCountryID").append($("<option></option>").val(value.CountryId).html(value.CountryCode));//Thileep Changed to get Country code 27.05.14

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function bindEvents() {
    //TAX1040-13966 - Saravanan N - 9th June, 2014.
    $('#txtForeignWithheld').blur(function (e) {
        if ($("#txtForeignWithheld").val().trim().length == 0) {
            if ($("#ddlForeginCountryID").prop('disabled') == false) {
                $("#ddlForeginCountryID").val(0);
                $("#ddlForeginCountryID").attr('disabled', true);
                $('#txtExemptInterest').focus();
            }
        }
        else {
            if ($("#ddlForeginCountryID").prop('disabled') == true) {
                $("#ddlForeginCountryID").attr('disabled', false);
                $("#ddlForeginCountryID").focus();
            }
        }
        e.preventDefault();
        return false;
    });


    //Commented by Thileep on 19Jun2014 for accordion 'Next' button click should focus 'Box 8 Tax Exempt Interest' accordion's 'State Code'  control should get focus.
    //$('#btnSubmitOne').click(function () {
    //    if ($('#frm1099INT').valid()) {
    //        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
    //        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
    //        $('#collapselinkOne').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
    //        $('#collapselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');

    //        return false;
    //    }
    //});


    //

    //Changed click function by Thileep on 19Jun2014 for accordion 'Next' button click should focus 'Box 8 Tax Exempt Interest' accordion's 'State Code'  control should get focus.
    $('#btnSubmitOne').click(function () {
        if ($('#frm1099INT').valid()) {
            var ExemptInterestVal = $('input#txtExemptInterest').val();
            if (ExemptInterestVal != null && ExemptInterestVal != '') {
                $('#PanelDisplay').show();
                $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
                $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
                $('#collapselinkOne').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
                $('#collapselinkThree').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
            }
            else {
                $("#PanelDisplay").hide();
                $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
                $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
                $('#collapselinkOne').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
                $('#collapselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
            }
            return false;
        }
    });






    $('#btnSubmitTwo').click(function () {
        if ($('#frm1099INT').valid()) {
            $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseTwo').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            return false;
        }
    });

    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

    $('.nextButton').click(function () {
        PersistF1099INT();
        return false;
    });

    $('#btnContinue').click(function () {
        PersistandContinueF1099INT();
        //Saravanan N - 7th May, 2014 - Eligibility check occurred.
        PageNavigation(isEligibilityCheckFailed, '../Income/interestincomesummary.html', 'InterestIncome');
        return false;
    });

    //Thileep Added Filtering funtion 27.05.14
    //$("#txtInterestIncome").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtInterestIncome');

    //$("#txtEarlyWithdrawal").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtEarlyWithdrawal');

    //$("#txtUSSavingBonds").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtUSSavingBonds');

    //$("#txtFederalTaxWitheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtFederalTaxWitheld');

    //$("#txtInvestmentExpenses").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtInvestmentExpenses');

    //$("#txtForeignWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtForeignWithheld');

    //$("#txtExemptInterest").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtExemptInterest');

    //$("#txtSpecifiedPrivate").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtSpecifiedPrivate');

    $("#txtAccountNo").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    //$("#txtStatePayer").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtStatePayer');

    //$("#txtStateWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtStateWithheld');

    //$("#txtPayerStateID").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9-]/g, ''));
    //    }, $(this)), 0);
    //});
    NumbersOnly('txtPayerStateID');

    //$("#txtPayerStateWithheld").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtExempt');

    //$("#txtExempt").bind("keypress paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9.]/g, ''));
    //    }, $(this)), 0);
    //});

    NumbersOnly('txtExempt');
}

//Saravanan N - 27th May, 2014 - Refactored method.
function setPopup() {
    SetPopupForControl('popInterestIncome', 'Box1 Federal Income', 'Interest income earned from any savings account for Federal.');
    SetPopupForControl('popEarlyWithdrawalPenalty', 'Box2 Early Withdrawal Penalty', 'Penalties charged for withdrawing money from any bank account.');
    SetPopupForControl('popUSSavingBonds', 'Box3 Interest on U.S Saving bonds & Treasury Obligation', 'Interest income earned on any U.S Saving bonds & Treasury Obligation.');
    SetPopupForControl('popFederalTaxWitheld', 'Box4 Federal Tax Withheld', 'Total amount of Federal Tax Withheld on your interest income received from your renumerator.');
    SetPopupForControl('popInvestmentExpenses', 'Box5 Investment Expenses', 'Interest you paid for your own investment expenses.');
    SetPopupForControl('popForeignTaxWithheld', 'Box6 Foreign Tax Withheld', 'Foreign tax withheld for investments on any foreign bank or borrowed loans from foreign bank.');
    SetPopupForControl('popForeginCountry', 'Box7 Foreign Country', 'Select the foreign country name to whom you paid the interest.');
    SetPopupForControl('popExemptInterest', 'Box8 Tax Exempt Interest', 'Total amount of Tax exempt interest you received. Tax exempt interest are social security benefits, scholarships, or fellowships, death benefits');
    SetPopupForControl('popSpecifiedPrivateActivity', 'Box9 Specified Private Activity', 'Interest amount on any private activity bonds.');
    SetPopupForControl('popAccountNo', 'Account Number', 'Enter your bank account number.');
    SetPopupForControl('popStateExempt', 'State Code', 'Select your Residential state code for the ‘Tax exempt Interest ‘received from your own state.');
    SetPopupForControl('popExempt', 'State Exempt Amount', 'Enter your ‘Tax exempt interest’ amount received from your Residential state.');
}

//Saravanan N - 4th June, 2014 - Common method created.
function SetPopupForControl(controlToSetPopup, headerText, bodyText) {
    $('#' + controlToSetPopup).popover({ title: '', content: "<h5>" + headerText + "</h5><br />" + bodyText + "<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
}

function ToggleTaxExempt() {
    var ExemptInterestVal = $('input#txtExemptInterest').val();
    if (ExemptInterestVal != null && ExemptInterestVal != '') {
        $('#btnSubmitTwo').show();
        $('#PanelDisplay').show();
    }
    else {
        $("#PanelDisplay").hide();
        $('#btnSubmitTwo').hide();
    }
    return false;
}

//While Continue button click call to this function. 
function PersistandContinueF1099INT() {

    PersistF1099INT();
    setTimeout(function () {
        window.location.href = '../Income/interestincomesummary.html';
    });
    return false;
}

//F1099INT Persist Data

//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
//While Next button click call to this function. 
function PersistF1099INT() {
    var form1099INTId, owner, payerName, payerIdentificationNumber, form;
    payerName = '';
    payerIdentificationNumber = 0;
    owner = 0;
    form = 0;

    //Get values from existing object.
    if (f1099INT != null) {
        form1099INTId = f1099INT.Form1099INTId;
        owner = f1099INT.Owner;
        form = f1099INT.Form;

        if (f1099INT.Payer != null) {
            payerName = f1099INT.Payer.PayerName;
            payerIdentificationNumber = f1099INT.Payer.PayerIdentificationNumber;
        }
    }
    else {
        form1099INTId = form1099INTId;
    }

    var stateExemptInterestValue = '';
    var stateExemptIdValue = 0;

    if ($("#txtExemptInterest").val() > 0) {
        stateExemptIdValue = $("#ddlStateExemptCode").val();
        stateExemptInterestValue = $("#txtExempt").val();
    }

    //Populate data into INT object.
    F1099INTPersistData = {
        Form1099INTId: form1099INTId,
        InterestIncome: ($("#txtInterestIncome").val()),
        FederalTaxWithHoldingAmount: ($("#txtFederalTaxWitheld").val()),
        USBondsTreasury: ($("#txtUSSavingBonds").val()),
        EarlyWithdrawalPenalty: $("#txtEarlyWithdrawal").val(),
        InvestmentExpenses: ($("#txtInvestmentExpenses").val()),
        ForeignTaxPaid: $("#txtForeignWithheld").val(),
        ForeignCountryId: $("#ddlForeginCountryID").val(),
        TaxExemptInterest: $("#txtExemptInterest").val(),
        SpecifiedPrivateActivityBond: $("#txtSpecifiedPrivate").val(),
        AccountNumber: $("#txtAccountNo").val(),
        TaxExemptInterestStateId: stateExemptIdValue,
        StateExemptInterest: stateExemptInterestValue,
        Form1099StateInfo: [
                {
                    StateId: $("#ddlStateCode").val(),
                    StateIdentificationNumber: $("#txtStatePayer").val(),
                    StateTaxWithholdingAmount: ($("#txtStateWithheld").val())
                },
                {
                    StateId: $("#ddlPayerStateCode").val(),
                    StateIdentificationNumber: $("#txtPayerStateID").val(),
                    StateTaxWithholdingAmount: ($("#txtPayerStateWithheld").val())
                }
        ],
        Owner: owner,
        Payer: {
            PayerName: payerName,
            PayerIdentificationNumber: payerIdentificationNumber
        },
        Form: form
    };

    $.ajax({
        url: serviceUrl + 'F1099INT/F1099INTinfocreate',
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
                        TaxData: JSON.stringify(F1099INTPersistData)
                    }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
                window.sessionStorage.setItem("Form1099INTId", data.Form1099INTId);
                //Saravanan N - 7th May, 2014 - Hard Stop eligibility check.
                isEligibilityCheckFailed = data.isEligibilityCheckFailed;
            }
        }
    });
}

//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
function F1099INTGetData() {
    $.ajax({
        url: serviceUrl + 'F1099INT/F1099INTgettaxdata',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId,
            "FormId": form1099INTId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item1 != null) {
                    f1099INT = data.m_Item1;
                    $("#txtInterestIncome").val(data.m_Item1.InterestIncome);
                    $("#txtFederalTaxWitheld").val(data.m_Item1.FederalTaxWithHoldingAmount);
                    $("#txtUSSavingBonds").val(data.m_Item1.USBondsTreasury);
                    $("#txtEarlyWithdrawal").val(data.m_Item1.EarlyWithdrawalPenalty);
                    $("#txtInvestmentExpenses").val(data.m_Item1.InvestmentExpenses);
                    $("#txtForeignWithheld").val(data.m_Item1.ForeignTaxPaid);
                    $("#ddlForeginCountryID").val(data.m_Item1.ForeignCountryId);
                    $("#txtExemptInterest").val(data.m_Item1.TaxExemptInterest);
                    $("#txtSpecifiedPrivate").val(data.m_Item1.SpecifiedPrivateActivityBond);
                    $("#txtAccountNo").val(data.m_Item1.AccountNumber);

                    if (data.m_Item1.TaxExemptInterest > 0) {
                        $('#PanelDisplay').show();
                        $("#ddlStateExemptCode").val(data.m_Item1.TaxExemptInterestStateId);
                        $("#txtExempt").val(data.m_Item1.StateExemptInterest);
                    }

                    if (data.m_Item1.Form1099StateInfo != null) {
                        if (data.m_Item1.Form1099StateInfo[0] != null) {
                            $("#ddlStateCode").val(data.m_Item1.Form1099StateInfo[0].StateId);
                            $("#txtStatePayer").val(data.m_Item1.Form1099StateInfo[0].StateIdentificationNumber);
                            $("#txtStateWithheld").val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount);
                        }

                        if (data.m_Item1.Form1099StateInfo[1] != null) {
                            $("#ddlPayerStateCode").val(data.m_Item1.Form1099StateInfo[1].StateId);
                            $("#txtPayerStateID").val(data.m_Item1.Form1099StateInfo[1].StateIdentificationNumber);
                            $("#txtPayerStateWithheld").val(data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount);
                        }
                    }

                    //TAX1040-13966 - Saravanan N - 9th June, 2014.
                    $("#ddlForeginCountryID").attr('disabled', $("#txtForeignWithheld").val().trim().length == 0);
                }
            }
        }
    });
}