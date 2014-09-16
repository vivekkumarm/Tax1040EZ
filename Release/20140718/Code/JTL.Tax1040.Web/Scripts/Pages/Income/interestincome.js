//7 Apr 2014 added the script for Interest Income
//Script for Interest Income
//Vincent - 16th April 2014- added a error message navigation for required user control.
//Sathish - 2May2014  Added TaxReturnData for PersistTaxReturnForm1099INTData
//Vincent-28MAy,2014 refator the code changes as required for error message.
//Vincent-29May,2014-Made a changes in Persist OID method.
// * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/



var f1099INT;
var f1099OID;  //This variables contains F1099INT and F1099OID objects.
var currentForm1099INTId = 0;
var currentForm1099OIDId = 0; //This variables contains F1099INT and F1099OID ids.
var FORM1099INT_TEXT = 'Form1099INT';
var FORM1099OID_TEXT = 'Form1099OID';
//Saravanan N - 27th May, 2014 - Variables added.
var owner;
var payerName;
var payerIdentificationNumber;

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    // Swapnesh 3-6-2014
    NumbersOnly('txtpayerEIN');

    // Swapnesh Added on 3-6-2014
    $("#frmInterestIncome").validate({

        rules: {

            txtpayerEIN:
                {
                    minlength: 10,
                    validateEINFor0000: true
                }
        },
        messages: {

            txtpayerEIN:
                {
                    minlength: "Invalid Payer Federal Identification Number",
                    validateEINFor0000: "Invalid Payer Federal Identification Number"
                }
        }

    });


    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    //Error message- focus method for user control
    var pageURL = window.location.search.substring(1);
    var parameters = pageURL.split('&');

    //Below code will execute while user click on the Error Messages in INTEREST INCOME SUMMARY page.
    if (parameters.length == 3) {
        var controlParmeters = parameters[0];
        var FormType = parameters[2];

        if (FormType.toString() == 'FormINT') {
            currentForm1099INTId = parameters[1];
            var controls = controlParmeters.split('-');
            if (controls.length == 2) {

                var divToExpand = controls[0];
                var controlToFocus = controls[1];
                $('#' + controlToFocus).focus();
                F1099INTGetData();
            }
        }
            //Form Type OID
        else if (FormType.toString() == 'FormOID') {
            currentForm1099OIDId = parameters[1];
            var controls = controlParmeters.split('-');
            if (controls.length == 2) {
                var divToExpand = controls[0];
                var controlToFocus = controls[1];
                $('#' + controlToFocus).focus();
                F1099OIDGetData();
            }
        }
    }
        //Below code will execute while user click on EDIT button in INTEREST INCOME SUMMARY page.
        //Yogalakshmi - 27th June 2014 - Defect fix TAX1040-14037 - Null check for parameters[0]
    else if (parameters.length == 1 && parameters[0] != "") {
        //Get query method
        GetQueryStringData();
    }
    else {
        //Yogalakshmi - 27th June 2014 - TAX1040-14037 - the user clicks the back button or the browser back then the datas are binded specific to the previous page using session. 
        //Getting Session Data
        SessionStorageData();
    }

    //Saravanan N - 28th May, 2014 - Method refactored.
    bindEvents();

    //Saravanan N - 28th May, 2014 - Method refactored.
    setPopup();
});


/************************************* FORM 1099 INT FUNCTIONS *************************************/

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
            "FormId": currentForm1099INTId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item1 != null) {
                    f1099INT = data.m_Item1;

                    if (data.m_Item1.Payer != null) {
                        disableRadioButtonInEditMode(); //Saravanan N - 28th May, 2014 - Disable radio buttons in case of Edit mode.
                        $("#txtpayername").val(data.m_Item1.Payer.PayerName);
                        $("#txtpayerEIN").val(data.m_Item1.Payer.PayerIdentificationNumber);
                    }

                    if (data.m_Item1.Form != null) {
                        $("input[name=radioIncome][value=" + data.m_Item1.Form + "]").prop('checked', true);
                    }

                    if (data.m_Item1.Owner != null) {
                        $("input[name=rdInterestIncomeSelect][value=" + data.m_Item1.Owner + "]").prop('checked', true);
                    }
                }

                //Pre-PageLogic
                if (data.m_Item2 != null) {

                    //Filing Status
                    if (data.m_Item2 != 2) {
                        $('#divWhoseInterest').hide();
                    }
                }

               
                //Yogalakshmi - 12th June 2014 - Common Issue Added to display the Taxpaer name and Spouse name if given
                if (data.m_Item3 != null) {
                    if (data.m_Item3.PrimaryTaxPayerFirstName != null && data.m_Item3.PrimaryTaxPayerFirstName != "") {
                        $('#lblPrimaryFilerFirstName').html(data.m_Item3.PrimaryTaxPayerFirstName);
                    }
                    else {
                        $('#lblPrimaryFilerFirstName').html("Taxpayer");
                    }

                    if (data.m_Item3.SpouseFirstName != null && data.m_Item3.SpouseFirstName != "") {
                        $('#lblSpouseFirstName').html(data.m_Item3.SpouseFirstName);
                    }
                    else {
                        $('#lblSpouseFirstName').html("Spouse");
                    }
                }
            }
        }
    });
}

//Saravanan N - 9th May, 2014  - FormId param altered in 'data'.
function PersistF1099INT() {
    if ($("#frmInterestIncome").valid()) {

        var F1099INTPersistData;

        if (f1099INT != null) {
            F1099INTPersistData = {
                Form1099INTId: f1099INT.Form1099INTId,
                InterestIncome: f1099INT.InterestIncome,
                FederalTaxWithHoldingAmount: f1099INT.FederalTaxWithHoldingAmount,
                USBondsTreasury: f1099INT.USBondsTreasury,
                EarlyWithdrawalPenalty: f1099INT.EarlyWithdrawalPenalty,
                InvestmentExpenses: f1099INT.InvestmentExpenses,
                ForeignTaxPaid: f1099INT.ForeignTaxPaid,
                ForeignCountryId: f1099INT.ForeignCountryId,
                TaxExemptInterest: f1099INT.TaxExemptInterest,
                SpecifiedPrivateActivityBond: f1099INT.SpecifiedPrivateActivityBond,
                AccountNumber: f1099INT.AccountNumber,
                TaxExemptInterestStateId: f1099INT.TaxExemptInterestState,
                StateExemptInterest: f1099INT.StateExemptInterest,
                Form1099StateInfo: f1099INT.Form1099StateInfo,
                Owner: owner,
                Payer: {
                    PayerName: payerName,
                    PayerIdentificationNumber: payerIdentificationNumber
                },
                Form: FORM1099INT_TEXT
            };
        }
        else {
            F1099INTPersistData = {
                Form1099INTId: currentForm1099INTId,
                Owner: owner,
                Payer: {
                    PayerName: payerName,
                    PayerIdentificationNumber: payerIdentificationNumber
                },
                Form: FORM1099INT_TEXT
            };
        }
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
                                TaxData: JSON.stringify(F1099INTPersistData),
                            }
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
                window.sessionStorage.setItem("Form1099INTId", data.Form1099INTId);
            }
        });
        return true;
    }
    else {
        return false;
    }
}
/***************************************************************************************************/



/************************************* FORM 1099 OID FUNCTIONS *************************************/
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
            "FormId": currentForm1099OIDId

        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {

                if (data.m_Item1 != null) {
                    f1099OID = data.m_Item1;
                    //Payer
                    if (data.m_Item1.Payer != null) {
                        disableRadioButtonInEditMode(); //Saravanan N - 28th May, 2014 - Disable radio buttons in case of Edit mode.
                        $("#txtpayername").val(data.m_Item1.Payer.PayerName),
                        $("#txtpayerEIN").val(data.m_Item1.Payer.PayerIdentificationNumber);
                    }
                    //Form
                    if (data.m_Item1.Form != null) {
                        $("input[name=radioIncome][value=" + data.m_Item1.Form + "]").prop('checked', true);
                    }
                    //Owner

                    if (data.m_Item1.Owner != null) {
                        $("input[name=rdInterestIncomeSelect][value=" + data.m_Item1.Owner + "]").prop('checked', true);
                    }
                }
                //Filing Status
                if (data.m_Item2 != null) {

                    //Filing Status
                    if (data.m_Item2 != 2) {
                        $('#divWhoseInterest').hide();
                    }
                }

                //Yogalakshmi - 12th June 2014 - Common Issue Added to display the Taxpaer name and Spouse name if given
                if (data.m_Item3 != null) {
                    if (data.m_Item3.PrimaryTaxPayerFirstName != null && data.m_Item3.PrimaryTaxPayerFirstName != "") {
                        $('#lblPrimaryFilerFirstName').html(data.m_Item3.PrimaryTaxPayerFirstName);
                    }
                    else {
                        $('#lblPrimaryFilerFirstName').html("Taxpayer");
                    }

                    if (data.m_Item3.SpouseFirstName != null && data.m_Item3.SpouseFirstName != "") {
                        $('#lblSpouseFirstName').html(data.m_Item3.SpouseFirstName);
                    }
                    else {
                        $('#lblSpouseFirstName').html("Spouse");
                    }
                }
            }
        }
    });
}

//Saravanan N - 9th May, 2014 - FormId name altered in data param.
//Persist for Form 1099OID
function PersistF1099OID() {
    if ($("#frmInterestIncome").valid()) {
        /**Variable **/
        var F1099OIDPersistData;

        /** Input Values**/
        if ((f1099OID != null) && (f1099OID.Payer != null || f1099OID.Owner != null || f1099OID.Form != null)) {
            F1099OIDPersistData = {
                Form1099OIDId: f1099OID.Form1099OIDId,
                OriginalIssueDiscount: f1099OID.OriginalIssueDiscount,
                OtherPeriodicInterest: f1099OID.OtherPeriodicInterest,
                EarlyWithdrawalPenalty: f1099OID.EarlyWithdrawalPenalty,
                FederalTaxWithHoldingAmount: f1099OID.FederalTaxWithHoldingAmount,
                Description: f1099OID.Description,
                USTreasuryObligations: f1099OID.USTreasuryObligations,
                InvestmentExpenses: f1099OID.InvestmentExpenses,
                AccountNumber: f1099OID.AccountNumber,
                HasToReportTaxExempt: f1099OID.HasToReportTaxExempt,
                HasToReportAdjustment: f1099OID.HasToReportAdjustment,
                TaxExemptInterest: f1099OID.TaxExemptInterest,
                AdjustmentAmount: f1099OID.AdjustmentAmount,
                ForeignTaxPaid: f1099OID.ForeignTaxPaid,
                ForeignCountryId: f1099OID.ForeignCountryId,
                TaxExemptInterestStateId: f1099OID.TaxExemptInterestState,
                StateExemptInterest: f1099OID.StateExemptInterest,
                Form1099StateInfo: f1099OID.Form1099StateInfo,
                Owner: owner,
                Payer: {
                    PayerName: payerName,
                    PayerIdentificationNumber: payerIdentificationNumber
                },
                Form: FORM1099OID_TEXT
            };
        }
        else {
            F1099OIDPersistData = {
                Form1099OIDId: currentForm1099OIDId,
                Form: FORM1099OID_TEXT,
                Owner: owner,
                Payer: {
                    PayerName: payerName,
                    PayerIdentificationNumber: payerIdentificationNumber
                }
            };
        }

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
                        TaxData: JSON.stringify(F1099OIDPersistData),
                    }
            }),
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("UserDataId", data.UserDataId);
                window.sessionStorage.setItem("Form1099OIDId", data.Form1099OIDId);
            }
        });
        return true;
    }
    else {
        return false;
    }
}
/***************************************************************************************************/

/************************************* COMMON FUNCTIONS ********************************************/
//Saravanan N - 28th May, 2014 - Method refactored.
//Yogalakshmi - 16th July 2014 - Updated Quick Help Content
function setPopup() {
    $(function () {
        $("#popPayerName").popover({ title: '', content: "<h5>What is 'Payer Name'?</h5>It is the name of the Financial Institution or Bank who pays you the Interest Income. Fill it in exactly as it appears on your Form 1099-INT.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPayerEIN").popover({ title: '', content: "<h5>What is 'Payer FIN'?</h5>It is the Federal Identification Number (FIN) allotted to the Payer who provides you your interest income. Fill it in exactly as it appears on your Form 1099-INT.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    });
}

//Saravanan N - 28th May, 2014 - Method refactored.
function bindEvents() {
    //Nagivation Pages Method
    $('#btnSubmit').click(function () {
        PersistAndNavigate(CONTINUE_BUTTON_CAPTION);
        return false;
    });

    //Nagivation Pages Method for Back.
    $('#btnBack').click(function () {
        //Vincent - 14th Mar, 2014 - As per Interest Income selected, next page(back button) will be decided.
        //Vincent - 1st July, 2014 - Defect 14040 - Adding new INT / OID, then Presses BACK button should not Persist.
        if (currentForm1099INTId != 0 || currentForm1099OIDId != 0) {
            PersistAndNavigate(BACK_BUTTON_CAPTION);
        }
        else {
            window.location.href = '../Income/interestincomesummary.html';
        }

        return false;
    });

    $("#txtpayername").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^a-zA-Z-0-9\s ]/g, ''));
        }, $(this)), 0);
    });

    $("#txtpayerEIN").bind("keypress paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });
}

//Saravanan N - 28th May, 2014 - Disable radio buttons in InterestIncomeGateway page, if user comes here in Edit mode.
function disableRadioButtonInEditMode() {
    $('input[name=radioIncome]').attr('disabled', true);
}

function PersistAndNavigate(buttonClicked) {
    
    var isINTSelected = $("#rad1099INT").prop('checked');
    var isOIDSelected = $("#rad1099OID").prop('checked');
    var nextPageToNavigate;

    //SessionStorageData();

    //Saravanan N - 27th May, 2014 
    owner = $('input:radio[name=rdInterestIncomeSelect]:checked').val();
    payerName = $("#txtpayername").val();
    payerIdentificationNumber = $("#txtpayerEIN").val();

    var Isvalidform = false;
    //Irrespective of button click, Persist should happen.
    if (isINTSelected == true) {
        Isvalidform = PersistF1099INT();
            nextPageToNavigate = '../Income/f1099int.html';
    }
    else if (isOIDSelected == true) {
        Isvalidform = PersistF1099OID();
        nextPageToNavigate = '../Income/f1099oid.html';
    }

    if (Isvalidform) {
        if (buttonClicked == CONTINUE_BUTTON_CAPTION) {
            window.location.href = nextPageToNavigate;
        }
        else if (buttonClicked == BACK_BUTTON_CAPTION) {
            GoToPreviousPage();
            return false;
        }
    }
}

function GetQueryStringData() {
    var sPageURL = window.location.search.substring(1);
    var sParameterName = sPageURL.split('=');

    if (sParameterName[0].toString() == 'Form1099INTId') {
        currentForm1099INTId = sParameterName[1];
        F1099INTGetData();
    }
    //Yogalakshmi - 26th June 2014 - Defect fix TAX1040-14037 - Commmented as it is implemented in the SessionStorageData()
    //else {
    //    currentForm1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
    //}

    if (sParameterName[0].toString() == 'Form1099OIDId') {
        currentForm1099OIDId = sParameterName[1];
        F1099OIDGetData();
    }
    //Yogalakshmi - 26th June 2014 - Defect fix TAX1040-14037 - Commmented as it is implemented in the SessionStorageData()
    //else {
    //    currentForm1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
    //}

    if (sParameterName[0].toString() == '') {
        //To get filling status
        InterestIncomeEmptyData();
    }
}

//New Method To Get Only Filling status
function InterestIncomeEmptyData() {
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
            "FormId": currentForm1099INTId,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                //Pre-PageLogic
                if (data.m_Item2 != null) {
                    if (data.m_Item2 == null || data.m_Item2 != FILING_STATUS_MFJ) {
                        $('#divWhoseInterest').hide();
                    }
                }

                //Yogalakshmi - 12th June 2014 - Common Issue Added to display the Taxpaer name and Spouse name if given
                if (data.m_Item3 != null) {
                    if (data.m_Item3.PrimaryTaxPayerFirstName != null && data.m_Item3.PrimaryTaxPayerFirstName != "") {
                        $('#lblPrimaryFilerFirstName').html(data.m_Item3.PrimaryTaxPayerFirstName);
                    }
                    else {
                        $('#lblPrimaryFilerFirstName').html("Taxpayer");
                    }

                    if (data.m_Item3.SpouseFirstName != null && data.m_Item3.SpouseFirstName != "") {
                        $('#lblSpouseFirstName').html(data.m_Item3.SpouseFirstName);
                    }
                    else {
                        $('#lblSpouseFirstName').html("Spouse");
                    }
                }
            }
        }
    });
}

//New Method whiling creating Interest income
function SessionStorageData() {
    //Checking the Session Storage data for Form1099INT and Form1099OID ID.

    //F1099INT
    if (!window.sessionStorage.Form1099INTId) {
        currentForm1099INTId = 0;
        //Yogalakshmi - 27th June 2014 - Defect fix TAX1040-14037 - Added this method when Add new is clicked in the summary page so that all the feids are binded accordingly with the filing status.
        InterestIncomeEmptyData();
    } else {
        currentForm1099INTId = JSON.parse(window.sessionStorage.getItem("Form1099INTId"));
        //Yogalakshmi - 27th June 2014 - Defect fix TAX1040-14037 - Added this method when the user clicks the back button or the browser back to bind the data.
        F1099INTGetData();
    }

    //F1099OID
    if (!window.sessionStorage.Form1099OIDId) {
        currentForm1099OIDId = 0;
        //Yogalakshmi - 27th June 2014 - Defect fix TAX1040-14037 - Added this method when Add new is clicked in the summary page so that all the feids are binded accordingly with the filing status.
        InterestIncomeEmptyData();
    } else {
        currentForm1099OIDId = JSON.parse(window.sessionStorage.getItem("Form1099OIDId"));
        //Yogalakshmi - 27th June 2014 - Defect fix TAX1040-14037 - Added this method when the user clicks the back button or the browser back to bind the data.
        F1099OIDGetData();
    }


}

/***************************************************************************************************/
