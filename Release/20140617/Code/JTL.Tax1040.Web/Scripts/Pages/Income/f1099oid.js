//10 Apr 14 Vincent Added a new Script file for 1099OID
//Vincent - 16th April 2014- added a error message navigation for required user control.
// Sathish 03May2014 User Tax Return Data bo for presist
//Vincent-26May2014-Refatored the code for Get and Persist method
//Vincent-29May2014-Made a cahnges in get data method

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var F1099OIDPersistData, f1099OID;
var form1099OIDId;
var isEligibilityCheckFailed = false;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    //Saravanan N - 16th June, 2014 - Amount should allow 9+2 degits.
    $('.amountField').attr('maxlength', '12');

    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    //Getting Session Data.
    if (!window.sessionStorage.Form1099OIDId) {
        form1099OIDId = 0;
    } else {
        form1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
    }

    var pageURL = window.location.search.substring(1);
    userId = JSON.parse(window.sessionStorage.getItem("UserId"));
    var parameters = pageURL.split('&');

    //Click on OID Error Message in InterestIncome Summary Diagnostic page, the below code will be executed.
    var controlParmeters;
    if (parameters.length == 3) {
        controlParmeters = parameters[0];
        var FormType = parameters[2];

        //Form Type OID
        if (FormType.toString() == 'FormOID') {
            form1099OIDId = parameters[1];
        }
    }

    //Show Exempt Amount div.
    $("#dvTaxExemptShow").hide();

    $("#chkTaxExempt").click(function () {
        $("#dvTaxExemptShow").toggle();
    });

    //Show Adjusted Amount div.
    $("#dvAdjustedAmount").hide();

    $("#chkadjustment").click(function () {
        $("#dvAdjustedAmount").toggle();
    });

    //Saravanan N - 27th May, 2014 - Moved code to separate functions.
    populateState();
    populateCountry();
    bindEvents();
    F1099OIDGetData();
    setPopup();

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
    //Getiing state details
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
            $("#ddlStateCodeID").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlStateCode2").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlStateCode3").append($("<option></option>").val(0).html("---Select---"));

            $.each(data, function (key, value) {
                $("#ddlStateCodeID").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateCode2").append($("<option></option>").val(value.StateId).html(value.StateCode));
                $("#ddlStateCode3").append($("<option></option>").val(value.StateId).html(value.StateCode));

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function populateCountry() {
    //Getting country details
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
                $("#ddlForeginCountryID").append($("<option></option>").val(value.CountryId).html(value.CountryName));

            });
        }
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function bindEvents() {
    //TAX1040-13966 - Saravanan N - 9th June, 2014.
    $('#txtForeignTaxPaid').blur(function (e) {
        if ($("#txtForeignTaxPaid").val().trim().length == 0) {
            if ($("#ddlForeginCountryID").prop('disabled') == false) {
                $("#ddlForeginCountryID").val(0);
                $("#ddlForeginCountryID").attr('disabled', true);
                $('#txtForeignTaxPaid').focus();
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

    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

    $('#btnContinue').click(function () {
        ContinueAndPersistF1099OID();
        //Saravanan N - 7th May, 2014 - Eligibility check occurred.
        PageNavigation(isEligibilityCheckFailed, '../Income/interestincomesummary.html', 'InterestIncome');
        return false;
    });

    //Thileep Added Filtering funtion 27.05.14
    $("#txtOriginalIssueDiscount").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtOtherPeriodicInterest").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtEarlyWithdrawalPenalty").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtFederalTaxWithHoldingAmount").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtForeignTaxPaid").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtUSTreasuryObligations").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtInvestmentExpenses").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtAccNo").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });
    $("#txtStateTaxWithholdingAmount").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtStateIdentificationNumber").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9-]/g, ''));
        }, $(this)), 0);
    });
    $("#txtPayerStateID").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9-]/g, ''));
        }, $(this)), 0);
    });

    $("#txtPayerStateWithheld").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $("#txtTaxExempt").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtStateExempt").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
    $("#txtajusment").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });
}

//Saravanan N - 27th May, 2014 - Refactored method.
function setPopup() {
    $("#popOriginalIssueDiscount").popover({ title: '', content: "<h5>Original Issue Discount</h5><br />Enter the amount of discount issued by any bond.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popOtherPeriodicalInterest").popover({ title: '', content: "<h5>Other Periodical Interest</h5><br /> Interest earned or paid on for other periodical actvities. <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popEarlyWithdrawalPenalty").popover({ title: '', content: "<h5>Box3 Early Withdrawal Penalty</h5><br />Enter the  penalty amount charged by bank for  early  withdrawal of money deposit for your own purpose.For example early withdrawal of  money from your retirement account, bank will charge you with penalty.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popFederalTaxWithheld ").popover({ title: '', content: "<h5>Box4 Federal Tax Withheld</h5><br />Enter the amount of Federal income tax withheld.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popForeignTaxWithheld").popover({ title: '', content: "<h5>Box5 Foreign Tax Withheld</h5><br />Enter the amount of foriegn tax withheld discount. <br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popForiegnCountryorUS").popover({ title: '', content: "<h5>Box6 Foriegn Tax Withheld</h5><br />Select the foreign country name  or  U.S Possession to which the witheld tax applies to.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popDescription").popover({ title: '', content: "<h5>Box7 Description</h5><br />Enter the Description.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popOIDonUSTreasuryObligation").popover({ title: '', content: "<h5>Box8 OID on U.S Treasury Obligation</h5><br />Enter the interest amount for OID on U.S Treasury Obligation.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popInvestmentExpenses").popover({ title: '', content: "<h5>Box9 Investment Expenses</h5><br />Interest you paid for your own interest expenses.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popAccountNumber").popover({ title: '', content: "<h5>Account Number</h5><br />Enter your bank account number.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popTaxExempt").popover({ title: '', content: "<h5>Tax Exempt Interest</h5><br />Total amount of Tax exempt interest you received. Tax exempt interest are social security benefits, scholarships, or fellowships, death benefits<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popStateCode3").popover({ title: '', content: "<h5> State Code</h5><br />Enter Your In State Code on Your OID TaxExempt Interest.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popStateExempt").popover({ title: '', content: "<h5>State Exempt Amount</h5><br />Enter Your In State Exempt amount on Your OID TaxExempt Interest.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    $("#popOldAdjustment").popover({ title: '', content: "<h5>Please enter Your OID Adjustment amount</h5><br />Enter Your OID Adjustment amount for your OID Interest Income.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
}

//F1099OID Persist
function ContinueAndPersistF1099OID() {
    PersistF1099OID();
    setTimeout(function () {
        window.location.href = '../Income/interestincomesummary.html';
    });
    return false;
}

//Saravanan N - 9th May, 2014 - FormId name altered in data param.
//Persist for Form 1099OID
function PersistF1099OID() {
    var form1099OIDId, owner, payerName, payerIdentificationNumber, form;

    //Get values from existing object.
    form1099OIDId = f1099OID != null ? f1099OID.Form1099OIDId : form1099OIDId;
    owner = f1099OID != null ? f1099OID.Owner : 0;
    payerName = f1099OID.Payer != null ? f1099OID.Payer.PayerName : '';
    payerIdentificationNumber = f1099OID.Payer != null ? f1099OID.Payer.PayerIdentificationNumber : '0';
    form = f1099OID != null ? f1099OID.Form : '0';

    F1099OIDPersistData = {
    Form1099OIDId: form1099OIDId,
    OriginalIssueDiscount: $("#txtOriginalIssueDiscount").val(),
    OtherPeriodicInterest: $("#txtOtherPeriodicInterest").val(),
    EarlyWithdrawalPenalty: $("#txtEarlyWithdrawalPenalty").val(),
    FederalTaxWithHoldingAmount: $("#txtFederalTaxWithHoldingAmount").val(),
    Description: $("#txtDescription").val(),
    USTreasuryObligations: $("#txtUSTreasuryObligations").val(),
    InvestmentExpenses: $("#txtInvestmentExpenses").val(),
    AccountNumber: $("#txtAccNo").val(),
    HasToReportTaxExempt: $("#chkTaxExempt").prop('checked'),
    HasToReportAdjustment: $("#chkadjustment").prop('checked'),
    TaxExemptInterest: $("#txtTaxExempt").val(),
    AdjustmentAmount: $("#txtajusment").val(),
    ForeignTaxPaid: $("#txtForeignTaxPaid").val(),
    ForeignCountryId: $("#ddlForeginCountryID").val(),
    TaxExemptInterestStateId: $("#ddlStateCode3").val(),
    StateExemptInterest: $("#txtStateExempt").val(),
    Form1099StateInfo: [
            {
                StateId: $("#ddlStateCodeID").val(),
                StateIdentificationNumber: $("#txtStateIdentificationNumber").val(),
                StateTaxWithholdingAmount: $("#txtStateTaxWithholdingAmount").val()
            },

            {
                StateId: $("#ddlStateCode2").val(),
                StateIdentificationNumber: $("#txtPayerStateID").val(),
                StateTaxWithholdingAmount: $("#txtPayerStateWithheld").val()
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
        url: serviceUrl + 'InterestIncome/F1099OIDinfocreate',
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
                    TaxData: JSON.stringify(F1099OIDPersistData)
                }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
                window.sessionStorage.setItem("Form1099OIDId", data.Form1099OIDId);
                //Saravanan N - 7th May, 2014 - Hard Stop eligibility check.
                isEligibilityCheckFailed = data.isEligibilityCheckFailed;
            }
        }
    });
}

//F1099OID Get Data
//Saravanan N - 9th May, 2014 - FormId name altered in data param.
function F1099OIDGetData() {
    $.ajax({
        url: serviceUrl + 'InterestIncome/F1099OIDgettaxdata',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId,
            "FormId": form1099OIDId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item1 != null) {
                    f1099OID = data.m_Item1;
                    $("#txtOriginalIssueDiscount").val(data.m_Item1.OriginalIssueDiscount);
                    $("#txtOtherPeriodicInterest").val(data.m_Item1.OtherPeriodicInterest);
                    $("#txtEarlyWithdrawalPenalty").val(data.m_Item1.EarlyWithdrawalPenalty);
                    $("#txtFederalTaxWithHoldingAmount").val(data.m_Item1.FederalTaxWithHoldingAmount);
                    $("#txtDescription").val(data.m_Item1.Description);
                    $("#txtUSTreasuryObligations").val(data.m_Item1.USTreasuryObligations);
                    $("#txtInvestmentExpenses").val(data.m_Item1.InvestmentExpenses);
                    $("#txtForeignTaxPaid").val(data.m_Item1.ForeignTaxPaid);
                    $("#ddlForeginCountryID").val(data.m_Item1.ForeignCountryId);
                    $("#txtAccNo").val(data.m_Item1.AccountNumber);
                    
                    if (data.m_Item1.HasToReportTaxExempt == true)
                    { 
                        $("#chkTaxExempt").prop('checked', data.m_Item1.HasToReportTaxExempt);
                        $("#txtTaxExempt").val(data.m_Item1.TaxExemptInterest);
                        $("#ddlStateCode3").val(data.m_Item1.TaxExemptInterestStateId);
                        $("#txtStateExempt").val(data.m_Item1.StateExemptInterest);
                        $("#dvTaxExemptShow").show();
                    }

                    if (data.m_Item1.HasToReportAdjustment == true)
                    {  
                        $("#chkadjustment").prop('checked', data.m_Item1.HasToReportAdjustment);
                        $("#txtajusment").val(data.m_Item1.AdjustmentAmount);
                        $("#dvAdjustedAmount").show();
                    }
                    

                    if (data.m_Item1.Form1099StateInfo != null) {
                        if (data.m_Item1.Form1099StateInfo[0] != null) {
                            $("#ddlStateCodeID").val(data.m_Item1.Form1099StateInfo[0].StateId);
                            $("#txtStateIdentificationNumber").val(data.m_Item1.Form1099StateInfo[0].StateIdentificationNumber);
                            $("#txtStateTaxWithholdingAmount").val(data.m_Item1.Form1099StateInfo[0].StateTaxWithholdingAmount);
                        }

                        if (data.m_Item1.Form1099StateInfo[1] != null) {
                            $("#ddlStateCode2").val(data.m_Item1.Form1099StateInfo[1].StateId);
                            $("#txtPayerStateID").val(data.m_Item1.Form1099StateInfo[1].StateIdentificationNumber);
                            $("#txtPayerStateWithheld").val(data.m_Item1.Form1099StateInfo[1].StateTaxWithholdingAmount);
                        }
                    }
                }

                //TAX1040-13966 - Saravanan N - 9th June, 2014.
                $("#ddlForeginCountryID").attr('disabled', $("#txtForeignTaxPaid").val().trim().length == 0);
            }
        }
    });
}
