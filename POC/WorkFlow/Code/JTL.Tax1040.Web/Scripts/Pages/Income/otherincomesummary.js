
// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncomeSummary.html page.****//

//Below are Constants.
var SSA_AND_RRB = 1;
var ALASKA_DIVIDEND_FUND = 2;
var navigateValue;

$(document).ready(function () {

    //By Default hide the SSB and RRB divs.
    $('#divSSBAndRRB').hide();
    $('#divAlaska').hide();

});

function GetOtherIncomeSummary() {
    $.ajax({
        url: serviceUrl + 'otherIncome/getotherincomesummary',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item1 != null) {

                    var incomeAmount = 0;

                    //SSA and RRB - Name and Income Amount display logics.
                    if (data.m_Item1.HasSsbAndRrb) {
                        //Diaplay div SSB and RRB.
                        $('#divSSBAndRRB').show();
                        $("#actionSSBAndRRB").append('<label class="col-md-2"><a href="../../../Income/otherincome.html" title="Edit" class="fa fa-edit"></a>' +
                            '<a href="#" id="deleteSSBAndRRB" title="Delete" class="fa fa-minus-square-o"></a></label>');

                        //Calculate Income Amount for SSA and RRB section.
                        if (data.m_Item1.SSB != null) {
                            incomeAmount = data.m_Item1.SSB.TaxpayerNetBenefits + data.m_Item1.SSB.SpouseNetBenefits;
                        }
                        if (data.m_Item1.RRB != null) {
                            incomeAmount = incomeAmount + data.m_Item1.RRB.TaxpayerNetBenefits + data.m_Item1.RRB.SpouseNetBenefits;
                        }

                        //Set Income Amount for SSA and RRB section.
                        $('#lblSSBAndRRBIncomeAmount').val(incomeAmount);

                        //Set Name - TODO: It has to be done as per the postback logic. - Saravanan N.
                        $('#lblSSBAndRRBName').val(data);




                        //Alaska Income - Name and Income Amount display logics.
                        if (data.m_Item1.HasAlaskaPermanantFund) {
                            //Diaplay div Alaska.
                            $('#divAlaska').show();
                            $("#actionAlaska").append('<label class="col-md-2"><a href="../../../Income/otherincome.html" title="Edit" class="fa fa-edit"></a>' +
                                '<a href="#" id="deleteAlaska" title="Delete" class="fa fa-minus-square-o"></a></label>');

                            //Calculate Income Amount for Alaska Income section.
                            if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                                incomeAmount = data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend +
                                    data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend;
                            }

                            //Set Income Amount for Alaska Divident Income section.
                            $('#lblAlaskaIncomeAmount').val(incomeAmount);
                        }
                    }
                }
                //Display Diagnostics.
                if (data.m_Item2.length > 0) {
                    $.each(data.m_Item2, function (index, value) {
                        navigateValue = value.MessageTarget + "?" + value.FieldName;
                        $("#dvDiagnostics").append('<a href="' + navigateValue + '">"' + value.ErrorText + '"</a></br>');
                    });
                }
            }
        }
    });
}

function DeleteSSBAndRRB(SSA_AND_RRB) {
    if (confirm("Are you sure you want to Delete ?")) {
        $.ajax({
            url: serviceUrl + 'otherincome/deleteotherincome',
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "userId": userId,
                "userDataId": userDataId,
                "otherIncomeType": SSA_AND_RRB
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.location.reload(true);
            }
        });
    }
}

function DeleteAlaskaRefund(ALASKA_DIVIDEND_FUND) {
    if (confirm("Are you sure you want to Delete ?")) {
        $.ajax({
            url: serviceUrl + 'otherincome/deleteotherincome',
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                "userId": userId,
                "userDataId": userDataId,
                "otherIncomeType": ALASKA_DIVIDEND_FUND
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.location.reload(true);
            }
        });
    }
}