//28 Apr 2014 - Vincent-Added a income summary Section.
//30 Apr 2014 - Vincent-Changes to the income summary Section.

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('#spCurrentYear').html(' ' + CURRENT_TAX_YEAR);
    $('.Title').html(TITLE);
    GetIncomeSummary();



});


function GetIncomeSummary() {

    $.ajax({
        url: serviceUrl + 'taxreturn/getincomesummary',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId,
            "UserDataId": userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            //Wages
            //Yogalakshmi - 16th June 2014 - To round off the Wages Amount and not to allow negative value.
            var finalWages = 0;
            var finalInterestIncome = 0;
            var finalUnemployment = 0;
            var finalOtherIncome = 0;
            var nickName = '';

            if (data != null) {
                if(data.m_Item5 != "") {
                    nickName = data.m_Item5;
                }

                if (data.m_Item1 != "undefined") {
                    if (data.m_Item1 > 0) {
                        finalWages = data.m_Item1;
                    }
                }

                //Interest Income
                //Yogalakshmi - 16th June 2014 - To round off the Interest Income Amount and not to allow negative value.

                if (data.m_Item2 != "undefined") {
                    if (data.m_Item2 > 0) {
                        finalInterestIncome = data.m_Item2;
                    }
                }

                //Unemployment Compensation
                //Yogalakshmi - 16th June 2014 - To round off the Unemployment Amount and not to allow negative value.

                if (data.m_Item3 != "undefined") {
                    if (data.m_Item3 > 0) {
                        finalUnemployment = data.m_Item3;
                    }
                }

                //Other Income
                //Yogalakshmi - 16th June 2014 - To round off the Other Income Amount and not to allow negative value.

                if (data.m_Item4 != "undefined") {
                    if (data.m_Item4 > 0) {
                        finalOtherIncome = data.m_Item4;
                    }
                }
                // 18Jun2014 Sathish hides the income base on the selected income
                if (data.m_Item6 != null) {
                    if (data.m_Item6.m_Item1 != null) {
                        if (data.m_Item6.m_Item1 == false) {
                            $('#divWages').hide();
                        }
                    }
                    if (data.m_Item6.m_Item2 != null) {
                        if (data.m_Item6.m_Item2 == false) {
                            $('#divIntrestIncome').hide();
                        }
                    }
                    if (data.m_Item6.m_Item3 != null) {
                        if (data.m_Item6.m_Item3 == false) {
                            $('#divUnemploymentCompensaiton').hide();
                        }
                    }
                    if (data.m_Item6.m_Item4 != null) {
                        if (data.m_Item6.m_Item4 == false) {
                            $('#divOtherIncome').hide();
                        }
                    }
                }
            }

            //Saravanan N - 16th June, 2014 - Code refactored.
            $('#lblWagesAmount').html(Math.round(finalWages));
            $('#lblInterestIncome').html(Math.round(finalInterestIncome));
            $('#lblF1099G').html(Math.round(finalUnemployment));
            $('#lblOtherIncome').html(Math.round(finalOtherIncome));
            $('.spanNickName').html(nickName);

            return false;


        }
    });
}






