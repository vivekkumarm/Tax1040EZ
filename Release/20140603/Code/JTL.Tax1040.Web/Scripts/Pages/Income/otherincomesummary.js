
// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncomeSummary.html page.****//
//**** Vincent-22th May,2014 - Modified JS file for getotherincome and Delete method.
//*****Vincent-23th May,2014-Made a changes on review changes

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/

//Variable for Other Income

//Below are Constants.
var SSA_AND_RRB = 1;
var ALASKA_DIVIDEND_FUND = 2;
var ALASKA_FUND = "Alaska Dividend Fund";
var SSA_RRB = "SSA & RRB ";
//Below are Diagnostics
var navigateValue;
//Below are Taxpayer and Spouse names
var taxPayerFirstName="";
var taxPayerLastName="";
var spouseFirstName="";
var spouseLastName = "";
var benefitsRecipientsName = "";
var alaskaRecipentName = "";
//Below are Delete 
var otherIncomeType;
//Below are Other income summary
var dvSummary;
//Below are Alsaka variable
var alsakaIncomeAmount = 0;
var taxPayerAlaskaAmount = 0;
var spouseAlaskaAmount = 0;
//Below are total other income
var otherIncomeAmount = 0;
//Below are RRB & SSB Variable.
var taxPayerSSBNetBenefits = 0;
var spouseSSBNetBenefits = 0;
var taxPayerRRBNetBenefits = 0;
var spouseRRBNetBenefits = 0;
var benefitIncomeAmount = 0;




/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('#spCurrentYearGatway').html(' ' + CURRENT_TAX_YEAR);
    
    $('.Title').html(TITLE);
    //Loading other income summary method
    GetOtherIncomeSummary();

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
//**** Vincent-22th May,2014 - Modified JS file for getotherincome and Delete method.

function GetOtherIncomeSummary() {
    $.ajax({
        url: serviceUrl + 'otherincome/getotherincomesummary',
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
            $("#divDiagnosticsParent").hide();
        },
        success: function (data, textStatus) {
            if (data != null) {
                taxPayerFirstName = data.m_Item3;
                taxPayerLastName = data.m_Item4;
                spouseFirstName = data.m_Item5;
                spouseLastName = data.m_Item6;
                if (data.m_Item1 != null) {

                    //Display Add New Section on Grid.
                    if (!data.m_Item1.HasSsbAndRrb && !data.m_Item1.HasAlaskaPermanantFund) {

                        $("#hlAddNew").show();

                    } else {

                        $("#hlAddNew").hide();
                    }


                    //SSA and RRB - Name and Income Amount display logics.
                    if (data.m_Item1.HasSsbAndRrb) {

                        //Pre-page logic to get the recipent name for SSB & RRB

                        //SSB
                        if (data.m_Item1.SSB !=null) {
                            taxPayerSSBNetBenefits = data.m_Item1.SSB.TaxpayerNetBenefits;//Field Control 4 as in Spec.
                            spouseSSBNetBenefits = data.m_Item1.SSB.SpouseNetBenefits;//Field Control 8 as in Spec.
                        }
                        //RRB
                        if (data.m_Item1.RRB != null) {
                            taxPayerRRBNetBenefits = data.m_Item1.RRB.TaxpayerNetBenefits;//Field Control 6 as in Spec.
                            spouseRRBNetBenefits = data.m_Item1.RRB.SpouseNetBenefits;//Field Control 10 as in Spec.
                        }

                        //TpSSB or TpRRB Net benefits has value 
                        if (taxPayerSSBNetBenefits > 0 || taxPayerRRBNetBenefits > 0) {

                            benefitsRecipientsName = taxPayerFirstName + " "+taxPayerLastName;
                        }

                        //SpSSB or SpRRB Net benefits has value
                        if (spouseSSBNetBenefits > 0 || spouseRRBNetBenefits > 0) {
                            benefitsRecipientsName = spouseFirstName + " " + spouseLastName;
                        }

                        //TpSSB & SpSSB Net benefits has value
                        if (taxPayerSSBNetBenefits > 0 && spouseSSBNetBenefits > 0) {

                            benefitsRecipientsName = taxPayerFirstName + " " + spouseFirstName;
                        }
                        //TpRRB & SpRRB Net benefits has value
                        if (taxPayerRRBNetBenefits > 0 && spouseRRBNetBenefits > 0) {
                            benefitsRecipientsName = taxPayerFirstName + " " + spouseFirstName;
                        }
                        //TpSSB & SpSSB & TpRRB & SpRRB Net benefits has value
                        if (taxPayerSSBNetBenefits > 0 && spouseSSBNetBenefits > 0 && taxPayerRRBNetBenefits > 0 && spouseRRBNetBenefits > 0)
                        {
                            benefitsRecipientsName = taxPayerFirstName + " " + spouseFirstName;
                        }

                        //Calculate Income Amount for SSA and RRB section.
                        if (data.m_Item1.SSB != null) {
                            benefitIncomeAmount = data.m_Item1.SSB.TaxpayerNetBenefits + data.m_Item1.SSB.SpouseNetBenefits;
                        }
                        if (data.m_Item1.RRB != null) {
                            benefitIncomeAmount = benefitIncomeAmount + data.m_Item1.RRB.TaxpayerNetBenefits + data.m_Item1.RRB.SpouseNetBenefits;
                        }
                        //SSB & RRB Summary
                        dvSummary = '<div class="pangird itm"><label class="col-md-4">'
                                                + SSA_RRB + '</label>' +
                                                               '' +
                                                               '<label class="col-md-3">' + benefitsRecipientsName + '</label>' +
                                                               '<label class="col-md-3">' + benefitIncomeAmount + '</label>' +
                                                                    '<label class="col-md-2">' +
                                                                         '<a href="../../../Income/otherincome.html" title="Edit" class="fa fa-edit"></a>' +
                                                                         '<a href="#" onclick="DeleteOtherIncomeByOtherIncomeType(' + SSA_AND_RRB + ');return false;" title="Delete" class="fa fa-minus-square-o"></a>' +
                                                               '</label></div>';
                    }

                        //Alaska Income - Name and Income Amount display logics.
                    if (data.m_Item1.HasAlaskaPermanantFund) {

                            //getting the alaska's values
                            if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                                taxPayerAlaskaAmount = data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend;//Field Control 12 as in Spec.
                                spouseAlaskaAmount = data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend;//Field Contro 13  in Spec.
                            }

                            //Pre-page logic to get recipent name for Alsaka Permanant fund.

                            //TpAlaskaFund Has value
                            if (data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend > 0)
                            {
                                alaskaRecipentName = taxPayerFirstName + " " + taxPayerLastName;
                            }
                            //SpAlsakaFund has value
                            else if (data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend > 0 )
                            {
                                alaskaRecipentName = spouseFirstName + " " + spouseLastName;
                            }
                            //TpAlaskaFund & SpAlsakaFund has value
                            else if (data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend > 0  && data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend > 0) {

                                alaskaRecipentName = taxPayerFirstName + " " + spouseFirstName;
                            }
                            
                            //Calculate Income Amount for Alaska Income section.
                            if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                                alsakaIncomeAmount = data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend +
                                    data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend;
                            }

                            //Alaska Summary
                            dvSummary = ((typeof dvSummary=="undefined")?"" : dvSummary)  + '<div class="pangird itm"><label class="col-md-4">'
                                                   + ALASKA_FUND + '</label>' +
                                                                  '' +
                                                                  '<label class="col-md-3">' + alaskaRecipentName + '</label>' +
                                                                  '<label class="col-md-3">' + alsakaIncomeAmount + '</label>' +
                                                                       '<label class="col-md-2">' +
                                                                            '<a href="../../../Income/otherincome.html" title="Edit" class="fa fa-edit"></a>' +
                                                                            '<a href="#" onclick="DeleteOtherIncomeByOtherIncomeType(' + ALASKA_DIVIDEND_FUND + ');return false;" title="Delete" class="fa fa-minus-square-o"></a>' +
                                                                  '</label></div>';
                           

                    }
                    //Other income Summary( SSB & RRB and Alsaka dividend fund)
                    $("#dvOtherIncomeSummay").append(dvSummary);
                    
                    //Total Other income amount
                    otherIncomeAmount = benefitIncomeAmount + alsakaIncomeAmount;
                    $('#spnTotalOtherIncome').html('$ ' + otherIncomeAmount);

                    if (data.m_Item1.SSB == null && data.m_Item1.RRB == null && !data.m_Item1.HasAlaskaPermanantFund) {
                        $("#dvOtherIncomeSummay").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                          '</span>');
                    }
                }

                //Display Diagnostics.

                $("#dvDiagnostics").empty();
                $("#dvDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.

                if (data.m_Item2 != null) {
                    var errorKnt = data.m_Item2.length;
                    if (errorKnt > 0) {
                        $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                        $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                        $("#dvDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.

                        $.each(data.m_Item2, function (index, value) {
                            //Error Message navigation url
                            var navigateURL = value.MessageTarget + "?" + value.FieldName;
                            $("#dvDiagnostics").append('<a href="' + navigateURL + '">' + value.ErrorText + '.</a>');
                        });
                    }
                }

            } 
        }
    });
}

//Delete Functionalty

function DeleteOtherIncomeByOtherIncomeType(otherIncomeType) {
    if (confirm("Are you sure you want to delete the selected Form?")) {
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
                "otherIncomeType": otherIncomeType
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

