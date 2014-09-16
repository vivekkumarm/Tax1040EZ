//8 Aug 2014-Vincent- Implemented the caadjustment.js

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var caOtherInformation = 0;
var totalUnemployment = 0;
/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    $('#divCAAdjustmentWagesDetails').hide();
    $('#divCAAdjustmentInterestDetails').hide();
    $('#divCAAdjustmentUnemploymentDetails').hide();
    $('#divOtherCAInformationDetails').hide();

    // On-Page #1
    $('#radAdjustmentYes').click(function () {
        $('#divCAAdjustmentWagesDetails').show();
        $('#divCAAdjustmentInterestDetails').show();
        $('#divCAAdjustmentUnemploymentDetails').show();
        $('#divOtherCAInformationDetails').show();

    });


    $('#radAdjustmentNo').click(function () {
        $('#divCAAdjustmentWagesDetails').hide();
        $('#divCAAdjustmentInterestDetails').hide();
        $('#divCAAdjustmentUnemploymentDetails').hide();
        $('#divOtherCAInformationDetails').hide();
    });


    $('#aOtherAdjustment').click(function () {
        caOtherInformation += 1;
        AddOtherInformation(caOtherInformation);
        return false;
    });

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/
function AddOtherInformation(rowIndex) {
    // On-Page #2
    if (rowIndex < 5) {
        var newStateInformation = ' <div id="divOtherInformationInfo' + rowIndex + '">' + '<div class="pangird itm">' +
            ' <input class="col-md-3" type="text" id="txtOtherDescription' + rowIndex + '" />' +
            //pre-page Logic: #4
            ' <label class="col-md-3" id="lblOtherFederalAmount">' + " 0" +
            '</label>' +

            ' <input class="col-md-3" type="text" id="txtOtherAddition' + rowIndex +  '" />' +
            ' <input class="col-md-3" type="text" id="txtOtherSubtraction' + rowIndex + '" />'
             + ' </div>' +
            ' </div>';


        $('#divOtherInformationInfo').append(newStateInformation);

    }
}

function GetFederalDetails()
{
    $.ajax({
        url: serviceUrl + 'taxesandwrapup/getfederaltaxsummary',
        async: false,
        dataType: "json",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            userId: userId,
            userDataId: userDataId,
        }
        ),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item5 != null) {
                    window.sessionStorage.setItem("UserDataId", data.m_Item5);
                }

                if (data.m_Item1 != null) {
                    //Wages

                    //pre-page Logic #1
                    if (data.m_Item1.TotalWages != null) {
                        $('#lblFederalWagesAmount').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TotalWages))));
                    } else {

                        $('#lblFederalWagesAmount').html(0);
                    }

                    //Interest Income
                    //pre-page Logic #2
                    //TODO: Yet to implement pre-page logic for hidden field 7 and 8
                    if (data.m_Item1.TaxableInterest != null) {
                        $('#lblFederalInterestAmount').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.TaxableInterest))));
                    } else {
                        $('#lblFederalInterestAmount').html(0);
                    }

                    //Unemployment Compensation
                    //pre-page Logic #3
                    if (data.m_Item1.UnemploymentCompensation != null) {
                        totalUnemployment = $('#lblFederalUnemployment').html(currencyformate(Math.round(NotToAllowNegativeValue(data.m_Item1.UnemploymentCompensation))));
                        //TODO: NEED a clarfication regarding the binding.
                        $('#txtUnemploymentSubtraction').html(currencyformate(Math.round(NotToAllowNegativeValue(totalUnemployment))))
                    }
                    else {
                        $('#lblFederalUnemployment').html(0);
                        $('#txtUnemploymentSubtraction').html(0);
                        $('#txtUnemploymentAddition').html(0);
                    }

                }
                else {
                    $('#lblFederalWagesAmount').html(0);
                    $('#lblFederalInterestAmount').html(0);
                    $('#lblFederalUnemployment').html(0);
                   
                }
                
            }
        }
    });

}
