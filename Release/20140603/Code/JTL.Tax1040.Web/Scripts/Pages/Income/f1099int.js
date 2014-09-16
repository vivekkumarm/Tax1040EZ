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
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
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
        var controlParmeters = parameters[0];
        var FormType = parameters[2];

        //Form Type INT
        if (FormType.toString() == 'FormINT') {
            form1099INTId = parameters[1];
            var controls = controlParmeters.split('-');

            if (controls.length == 2) {
                var divToExpand = controls[0];
                var controlToFocus = controls[1];
                $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
                $('#' + divToExpand).addClass('panel-collapse collapse in');
                $('#' + controlToFocus).focus();
            }
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
    
    $('#btnSubmitOne').click(function () {
        if ($('#frm1099INT').valid()) {
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
            return false;
        }
    });
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
            $("#ddlStateExempt").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlPayerStateCode").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateExempt").append($("<option></option>").val(value.StateId).html(value.StateCode));

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

    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

    $('#btnContinue').click(function () {
        PersistandContinueF1099INT();
        //Saravanan N - 7th May, 2014 - Eligibility check occurred.
        PageNavigation(isEligibilityCheckFailed, '../Income/interestincomesummary.html', 'InterestIncome');
        return false;
    });

    //Thileep Added Filtering funtion 27.05.14
    $("#txtInterestIncome").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtEarlyWithdrawal").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtUSSavingBonds").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtFederalTaxWitheld").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtInvestmentExpenses").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtForeignWithheld").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtExemptInterest").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtSpecifiedPrivate").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtAccountNo").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtStatePayer").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9-]/g, ''));
        }, $(this)), 0);
    });

    $("#txtStateWithheld").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtPayerStateID").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9-]/g, ''));
        }, $(this)), 0);
    });

    $("#txtPayerStateWithheld").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $("#txtExempt").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function setPopup() {
    $("#popInterestIncome").popover({ title: '', content: "<h5>Box1 Federal Income</h5><br />Interest income earned from any savings account for Federal.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEarlyWithdrawalPenalty").popover({ title: '', content: "<h5>Box2 Early Withdrawal Penalty</h5><br />Penalties charged for withdrawing money from any bank account.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popUSSavingBonds").popover({ title: '', content: "<h5>Box3 Interest on U.S Saving bonds & Treasury Obligation</h5><br />Interest income earned on any U.S Saving bonds & Treasury Obligation.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popFederalTaxWitheld").popover({ title: '', content: "<h5>Box4 Federal Tax Withheld</h5><br />Total amount of Federal Tax Withheld on your interest income received from your renumerator.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInvestmentExpenses").popover({ title: '', content: "<h5>Box5 Investment Expenses</h5><br />Interest you paid for your own investment expenses.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popForeignTaxWithheld").popover({ title: '', content: "<h5>Box6 Foreign Tax Withheld</h5><br />Foreign tax withheld for investments on any foreign bank or borrowed loans from foreign bank.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popForeginCountry").popover({ title: '', content: "<h5>Box7 Foreign Country</h5><br />Select the foreign country name to whom you paid the interest.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popExemptInterest").popover({ title: '', content: "<h5>Box8 Tax Exempt Interest</h5><br />Total amount of Tax exempt interest you received. Tax exempt interest are social security benefits, scholarships, or fellowships, death benefits <br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popSpecifiedPrivateActivity").popover({ title: '', content: "<h5>Specified Private Activity</h5><br />Interest amount on any private activity bonds. <br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAccountNo").popover({ title: '', content: "<h5>Account Number</h5><br />Enter your bank account number. <a href='' target='_blank' class='more'>Read Common Question</a>" });
}

function ToggleTaxExempt() {
    var ExemptInterestVal = $('input#txtExemptInterest').val();
    if (ExemptInterestVal != null && ExemptInterestVal != '') {
        $('#PanelDisplay').show();
        $('#collapseThree').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
    }
    else {
        $("#PanelDisplay").hide();

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
        TaxExemptInterestStateId: $("#ddlStateExempt").val(),
        StateExemptInterest: $("#txtStateExempt").val(),
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
                    $("#txtAccountNo").val(data.AccountNumber);

                    if (data.m_Item1.TaxExemptInterest > 0) {
                        $('#PanelDisplay').show();
                        $("#ddlStateExempt").val(data.m_Item1.TaxExemptInterestStateId);
                        $("#txtStateExempt").val(data.m_Item1.StateExemptInterest);
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
                }
            }
        }
    });
}