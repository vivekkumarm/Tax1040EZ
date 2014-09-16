
// **** Vivek - 9th April, 2014 - File contains javascript methods required for OtherIncomeSummary.html page.****//
//**** Vincent-22th May,2014 - Modified JS file for getotherincome and Delete method.
//*****Vincent-23th May,2014-Made a changes on review changes

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/

//Variable for Other Income

//Below are Constants.
var SSA_AND_RRB = 1;
var ALASKA_DIVIDEND_FUND = 2;
var State_Tax_Refund = 3;
var ALASKA_FUND = "Alaska Dividend Fund";
var SSA_RRB = "SSA & RRB ";
var State_Tax = "State Tax Refund";
//Below are Diagnostics
var navigateValue;
//Below are Taxpayer and Spouse names
var taxPayerFirstName = "";
var taxPayerLastName = "";
var spouseFirstName = "";
var spouseLastName = "";
var alaskaRecipentName = "";
var StateTaxRefundRecipentName = "";
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

//Thileep Added new variable to check empty records  on 13jun14
var recordsFound = false;
var hasIncomeEligibilityDiagnostics = false; // 17Jun2014 Sathish used to check eligibility check in continue click





/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('#spCurrentYearGatway').html(' ' + CURRENT_TAX_YEAR);
    
    $('.Title').html(TITLE);
    //Loading other income summary method

    $('#btnContinue').click(function () {
        var pageToNavigate;
        // 17Jun2014 Sathish redirected to finaldiagnostics if it has eligibility rule
        if (hasIncomeEligibilityDiagnostics) {
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            pageToNavigate = '../Review/finalsummary.html?Topic=' + Topic.OtherIncome;  // 20Jun2014 Sathish replaced hard coded value with the constant
        }
        else {
            pageToNavigate = '../Income/incomesummary.html';
        }

        //On Continue button click navigate to the page.
        window.location.href = pageToNavigate;
        return false;
    });

    GetOtherIncomeSummary();
    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#lnkF1040EZ').click(function () {
        Genernate1040EZForm();
        return false;
    });

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
                //Below are RRB & SSB Variable.
                var taxPayerSSBNetBenefits;
                var spouseSSBNetBenefits;
                var taxPayerRRBNetBenefits;
                var spouseRRBNetBenefits;
                var benefitIncomeAmount;
                var benefitsRecipientsName = "";

                //vivek - 17-June-14 declare inside the scope 
                var totalalsakaIncomeAmount = 0;
                var totalbenefitIncomeAmount = 0;

                //Saravanan N - 13th June, 2014  - NULL check handled in Taxpayer / Spouse names.
                taxPayerFirstName = data.m_Item3 != null ? data.m_Item3 : "";
                taxPayerLastName = data.m_Item4 != null ? data.m_Item4 : "";
                spouseFirstName = data.m_Item5 != null ? data.m_Item5 : "";
                spouseLastName = data.m_Item6 != null ? data.m_Item6 : "";

                if (data.m_Item1 != null) {

                    //Display Add New Section on Grid.
                    if (!data.m_Item1.HasSsbAndRrb && !data.m_Item1.HasAlaskaPermanantFund) {

                        $("#hlAddNew").show();

                    } else {

                        $("#hlAddNew").hide();
                    }


                    //SSA and RRB - Name and Income Amount display logics.
                    if (data.m_Item1.HasSsbAndRrb) {

                        recordsFound = true;

                        //Pre-page logic to get the recipent name for SSB & RRB

                        //SSB
                        if (data.m_Item1.SSB != null) {
                            taxPayerSSBNetBenefits = data.m_Item1.SSB.TaxpayerNetBenefits;//Field Control 4 as in Spec.
                            spouseSSBNetBenefits = data.m_Item1.SSB.SpouseNetBenefits;//Field Control 8 as in Spec.
                        }
                        //RRB
                        if (data.m_Item1.RRB != null) {
                            taxPayerRRBNetBenefits = data.m_Item1.RRB.TaxpayerNetBenefits;//Field Control 6 as in Spec.
                            spouseRRBNetBenefits = data.m_Item1.RRB.SpouseNetBenefits;//Field Control 10 as in Spec.
                        }
                        
                        benefitIncomeAmount = taxPayerSSBNetBenefits + spouseSSBNetBenefits + taxPayerRRBNetBenefits + spouseRRBNetBenefits;

                        //Saravanan N - 17th July, 2014 - NULL check handled in taxPayerSSBNetBenefits, taxPayerRRBNetBenefits, spouseSSBNetBenefits and spouseRRBNetBenefits fields.
                        //TpSSB or TpRRB Net benefits has value 
                        if ((taxPayerSSBNetBenefits != null && taxPayerSSBNetBenefits >= 0) ||
                            (taxPayerRRBNetBenefits != null && taxPayerRRBNetBenefits >= 0)) {

                            benefitsRecipientsName = taxPayerFirstName + " " + taxPayerLastName;
                        }

                        //SpSSB or SpRRB Net benefits has value
                        if ((spouseSSBNetBenefits != null && spouseSSBNetBenefits >= 0) ||
                            (spouseRRBNetBenefits != null && spouseRRBNetBenefits >= 0)) {
                            benefitsRecipientsName = spouseFirstName + " " + spouseLastName;
                        }

                        //TpSSB & SpSSB Net benefits has value
                        if ((taxPayerSSBNetBenefits != null && taxPayerSSBNetBenefits >= 0) &&
                            (spouseSSBNetBenefits != null && spouseSSBNetBenefits >= 0)) {
                            benefitsRecipientsName = taxPayerFirstName + " " + spouseFirstName;
                        }

                        //TpRRB & SpRRB Net benefits has value
                        if ((taxPayerRRBNetBenefits != null && taxPayerRRBNetBenefits >= 0) &&
                            (spouseRRBNetBenefits != null && spouseRRBNetBenefits >= 0)) {
                            benefitsRecipientsName = taxPayerFirstName + " " + spouseFirstName;
                        }

                        //TpSSB & SpSSB & TpRRB & SpRRB Net benefits has value
                        if ((taxPayerSSBNetBenefits != null && taxPayerSSBNetBenefits >= 0) &&
                            (spouseSSBNetBenefits != null && spouseSSBNetBenefits >= 0) &&
                            (taxPayerRRBNetBenefits != null && taxPayerRRBNetBenefits >= 0) &&
                            (spouseRRBNetBenefits != null && spouseRRBNetBenefits >= 0)) {
                            benefitsRecipientsName = taxPayerFirstName + " " + spouseFirstName;
                        }

                        //Calculate Income Amount for SSA and RRB section.
                        if (data.m_Item1.SSB != null) {
                            benefitIncomeAmount = data.m_Item1.SSB.TaxpayerNetBenefits + data.m_Item1.SSB.SpouseNetBenefits;
                        }
                        if (data.m_Item1.RRB != null) {
                            benefitIncomeAmount = benefitIncomeAmount + data.m_Item1.RRB.TaxpayerNetBenefits + data.m_Item1.RRB.SpouseNetBenefits;
                           
                         
                        }

                        //Yogalakshmi - 16th June 2014 - Check for negative value.
                        
                        if (benefitIncomeAmount != "undefined") {
                            if (benefitIncomeAmount >= 0) {
                                totalbenefitIncomeAmount = benefitIncomeAmount;
                            }
                        }

                        //SSB & RRB Summary
                        //Defect TAX1040-13977 - Vivek - toFixed(2) added to round off to 2 digits in summary.
                        //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                        dvSummary = '<div class="pangird itm"><label class="col-md-4">'
                                                + SSA_RRB + '</label>' +
                                                               '' +
                                                               '<label class="col-md-3">' + benefitsRecipientsName + '</label>' +
                                                               '<label class="col-md-3">' + currencyformate(totalbenefitIncomeAmount.toFixed(2)) + '</label>' +
                                                                    '<label class="col-md-2">' +
                                                                         '<a href="../../../Income/otherincome.html" title="Edit" class="fa fa-edit"></a>' +
                                                                         '<a href="#" onclick="DeleteOtherIncomeByOtherIncomeType(' + SSA_AND_RRB + ');return false;" title="Delete" class="fa fa-minus-square-o"></a>' +
                                                               '</label></div>';
                    }

                        //Alaska Income - Name and Income Amount display logics.
                    if (data.m_Item1.HasAlaskaPermanantFund) {

                        recordsFound = true;


                            //getting the alaska's values
                            if (data.m_Item1.AlaskaPermanentFundDividend != null) {
                                taxPayerAlaskaAmount = data.m_Item1.AlaskaPermanentFundDividend.PrimaryTaxpayerAlaskaFundDividend;//Field Control 12 as in Spec.
                                spouseAlaskaAmount = data.m_Item1.AlaskaPermanentFundDividend.SpouseAlaskaFundDividend;//Field Contro 13  in Spec.
                            }

                            
                            //Defect TAX1040-13988 - Saravanan N - 9th June, 2014 - If condition execution order alone inter-changed.
                        //Pre-page logic to get recipent name for Alsaka Permanant fund.
                            //Defect 14189 - 15th July, 2014 - NULL check added.
                            if ((taxPayerAlaskaAmount != null && taxPayerAlaskaAmount >= 0) &&
                                (spouseAlaskaAmount != null &&  spouseAlaskaAmount >= 0)) {
                                //TpAlaskaFund & SpAlsakaFund has value
                                alaskaRecipentName = taxPayerFirstName + " " + spouseFirstName;
                            }
                            else if (taxPayerAlaskaAmount != null && taxPayerAlaskaAmount >= 0) {
                                //TpAlaskaFund Has value
                                alaskaRecipentName = taxPayerFirstName + " " + taxPayerLastName;
                            }
                            else if (spouseAlaskaAmount != null && spouseAlaskaAmount >= 0) {
                                //SpAlsakaFund has value
                                alaskaRecipentName = spouseFirstName + " " + spouseLastName;
                            }
                            
                            //Calculate Income Amount for Alaska Income section.
                            alsakaIncomeAmount = taxPayerAlaskaAmount + spouseAlaskaAmount;

                        //Yogalakshmi - 16th June 2014 - Check for negative value.                         
                            if (alsakaIncomeAmount != "undefined") {
                                if (alsakaIncomeAmount >= 0) {
                                    totalalsakaIncomeAmount = alsakaIncomeAmount;
                                }
                            }

                        //Alaska Summary
                        //Defect TAX1040-13977 - Vivek - toFixed(2) added to round off to 2 digits in summary.
                        //Thileep Added on 13June2014 for focus on edit "?collapseTwo" 
                        //Yogalakshmi - 9th July 2014 - Added Currency Format to display it with comma's(,).
                        dvSummary = ((typeof dvSummary == "undefined") ? "" : dvSummary) + '<div class="pangird itm"><label class="col-md-4">'
                                                   + ALASKA_FUND + '</label>' +
                                                                  '' +
                                                                  '<label class="col-md-3">' + alaskaRecipentName + '</label>' +
                                                                  '<label class="col-md-3">' + currencyformate(totalalsakaIncomeAmount.toFixed(2)) + '</label>' +
                                                                       '<label class="col-md-2">' +
                                                                            '<a href="../../../Income/otherincome.html' + "?collapseTwo" + '" title="Edit" class="fa fa-edit"></a>' +
                                                                            '<a href="#" onclick="DeleteOtherIncomeByOtherIncomeType(' + ALASKA_DIVIDEND_FUND + ');return false;" title="Delete" class="fa fa-minus-square-o"></a>' +
                                                                  '</label></div>';
                           

                    }


                  
                    //TpAlaskaFund & SpAlsakaFund has value


                    //Added by prasana on 15.07.2014 after Income spec update 2.3 
                    if (data.m_Item1.HasStateTaxRefund) {

                        recordsFound = true;

                        StateTaxRefundRecipentName = taxPayerFirstName + " " + taxPayerLastName;


                        dvSummary = ((typeof dvSummary == "undefined") ? "" : dvSummary) + '<div class="pangird itm"><label class="col-md-4">'
                                                 + State_Tax + '</label>' +
                                                                '' +
                                                                '<label class="col-md-3">' + StateTaxRefundRecipentName + '</label>' +
                                                                '<label class="col-md-3">' + "" + '</label>' +
                                                                     '<label class="col-md-2">' +
                                                                          '<a href="../../../Income/otherincome.html' + "?collapseThree" + '" title="Edit" class="fa fa-edit"></a>' +
                                                                          '<a href="#" onclick="DeleteOtherIncomeByOtherIncomeType(' + State_Tax_Refund + ');return false;" title="Delete" class="fa fa-minus-square-o"></a>' +
                                                                '</label></div>';
                    }
               
                    //Other income Summary( SSB & RRB and Alsaka dividend fund)
                    $("#dvOtherIncomeSummay").append(dvSummary);
                    
                    //Total Other income amount
                    otherIncomeAmount = totalbenefitIncomeAmount + totalalsakaIncomeAmount;
                    //Defect TAX1040-13977 - Vivek - Amount rounded.
                    //Yogalakshmi - 16th June 2014 - To round off the other Income Amount and not to allow negative value.
                    var finalotherIncomeAmount = 0;
                    if (otherIncomeAmount > 0) {
                        finalotherIncomeAmount = otherIncomeAmount;
                    }                  
                    var value = Math.round(finalotherIncomeAmount);
                    //vivek 18-June-14 Added the Currency formate
                    $('#spnTotalOtherIncome').html('$ ' + currencyformate(value));
                        //Defect TAX1040-14016 - Saravanan N - 11th June, 2014 - AlaskaPermanentFundDividend checked in below if condition.
                }

                //Display Diagnostics.

                $("#dvDiagnostics").empty();
                $("#dvDiagnosticsParent").hide();//Saravanan N - 13th May, 2014 - Default hide the diagnostics.

                if (data.m_Item2 != null) {
                    // * 17Jun2014 Sathish Changed code for eligible navigation
                    var errorKnt = 0;
                    if (data.m_Item2.length > 0) {
                        //Modified by prasana made changes for displaying error based on the type on 14.07.2014
                        //Modified by prasana added null check for value and changed to Switch case on 15.07.2014
                        $.each(data.m_Item2, function (index, value) {
                            if (value != null) {
                                if ((value.Topic == Topic.OtherIncome) && (value.MessageType == MessageType.ER)) {
                                    hasIncomeEligibilityDiagnostics = true;
                                }
                                else {
                                    //Error Message navigation url
                                    errorKnt += 1;
                                    var navigateURL = value.MessageTarget + "?" + value.FieldName;

                                    var errorType = value.ErrorType.trim();
                                    var className = '';

                                    switch (errorType) {
                                        case ErrorType.Error:
                                            className = "dierror";
                                            break;

                                        case ErrorType.Warning:
                                            className = "diwarn";
                                            break;

                                        case ErrorType.Information:
                                            className = "diinfo";
                                            break;
                                    }

                                    //Assign class dynamically based on ErrorType.
                                    $("#dvDiagnostics").append('<a class=' + className + ' href="' + navigateURL + '">' + value.ErrorText + '.</a>');
                                }
                            }
                        });
                        if (errorKnt > 0) {
                            $('#supErrorCount').html(errorKnt); //Saravanan N - 8th May, 2014 
                            $('#supErrorCount').attr('title', 'You have ' + errorKnt + ' Errors');
                            $("#dvDiagnosticsParent").show(); //Saravanan N - 13th May, 2014 - Show the diagnostics.
                        }
                    }
                }
            }

            //Thileep changed Empty records check on 13jun14
            if (!recordsFound) {
                $("#dvOtherIncomeSummay").append('<span  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
                  '</span>');
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

