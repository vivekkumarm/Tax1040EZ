// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncomeGateway.html page.****//
// Global Variable declaration. It can be used in all the below functions.
//Saravanan N - 11th April, 2014 - Obtaining from Session Storage.

//Saravanan N - 11th April, 2014 - Added by Saravanan to get UserID and UserDataId from Session.
// 03may2014 Sathish user Tax return bo for persist
//22 May 2014- Vincent-Made a alignment to the code and remove un use code.

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var otherIncome;
var otherIncomeGetData;


/**************************************** PAGE LOAD ACTION ****************************************/

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    GetOtherIncome();

    //Saravanan N - 20th May, 2014 - Code moved from HTML.
    $('#btnBack').click(function () {
        GoToPreviousPage();
        return false;
    });

    //Saravanan N - 20th May, 2014 - Code moved from HTML.
    $('#btnContinue').click(function () {
        PersistOtherIncome();
        //window.location.href = '../Income/otherincome.html';
        return false;
    });
});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
function PersistOtherIncome() {
    
    var HasSsbAndRrb= $('#chkSSB').prop('checked');
    var HasAlaskaPermanantFund = $('#chkAlaska').prop('checked');
    var HasStateTaxRefund = $('#chkStateLocalTax').prop('checked');
    var SSB, RRB, alaskaPermanentFundDividend, stateOrLocalIncomeTaxRefunds;

    if (otherIncomeGetData != null) {
        if (otherIncomeGetData.SSB != null) {
            SSB = otherIncomeGetData.SSB;
        }
        if (otherIncomeGetData.RRB != null)
        {
            RRB = otherIncomeGetData.RRB;
        }
        if (otherIncomeGetData.AlaskaPermanentFundDividend != null)
        {
            alaskaPermanentFundDividend = otherIncomeGetData.AlaskaPermanentFundDividend;
        }
        if (otherIncomeGetData.StateOrLocalIncomeTaxRefunds != null) {
            stateOrLocalIncomeTaxRefunds = otherIncomeGetData.StateOrLocalIncomeTaxRefunds;
        }
        
        
    }

    otherIncome = {
        HasSsbAndRrb: $('#chkSSB').prop('checked'),
        HasAlaskaPermanantFund: $('#chkAlaska').prop('checked'),
        HasStateTaxRefund: $('#chkStateLocalTax').prop('checked'),
        SSB: SSB,
        RRB: RRB,
        AlaskaPermanentFundDividend: alaskaPermanentFundDividend,
        StateOrLocalIncomeTaxRefunds: stateOrLocalIncomeTaxRefunds
    };
    

    $.ajax({
        url: serviceUrl + 'otherincome/persistotherincome',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
                {
                    UserDataId: userDataId,
                    TaxData: JSON.stringify(otherIncome),
                }

        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            
            window.sessionStorage.setItem("UserDataId", data);
            
            if (HasSsbAndRrb == false && HasAlaskaPermanantFund == false && HasStateTaxRefund == false) {
                window.location.href = '../Income/incomesummary.html';
            }
            else {
                window.location.href = '../Income/otherincome.html';
            }
            return false;
        }
    });
}

function GetOtherIncome() {
    $.ajax({
        url: serviceUrl + 'otherincome/getotherincome',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            userDataId: userDataId
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null && data.m_Item1 != null) {
                
                if (data.m_Item1 != null) {

                    otherIncomeGetData = data.m_Item1;

                    //$('#chkSSB').prop('checked', data.m_Item1.HasSsbAndRrb);
                    //$('#chkAlaska').prop('checked', data.m_Item1.HasAlaskaPermanantFund);
                    //$('#chkStateLocalTax').prop('checked', data.m_Item1.HasStateTaxRefund);

                    $('#chkSSB').attr('checked', data.m_Item1.HasSsbAndRrb);
                    if (data.m_Item1.HasSsbAndRrb) {
                        $('#chkSSB').addClass('tick');
                    }

                    $('#chkAlaska').attr('checked', data.m_Item1.HasAlaskaPermanantFund);
                    if (data.m_Item1.HasAlaskaPermanantFund) {
                        $('#chkAlaska').addClass('tick');
                    }

                    $('#chkStateLocalTax').attr('checked', data.m_Item1.HasStateTaxRefund);
                    if (data.m_Item1.HasStateTaxRefund) {
                        $('#chkStateLocalTax').addClass('tick');
                    }


                    //if (data.m_Item1.HasSsbAndRrb)
                    //{
                    //    $('#chkSSB').attr('disabled', true);
                    //}
                    //if (data.m_Item1.HasAlaskaPermanantFund)
                    //{
                    //    $('#chkAlaska').attr('disabled', true);
                    //}
                    //if (data.m_Item1.HasStateTaxRefund)
                    //{
                    //    $('#chkStateLocalTax').attr('disabled', true);
                    //}

                }
            }
        }
    });
}