//Saravanan N - 16th April, 2014 - Newly added for IncomeGatewaywithCheck.html file 
// Sathish N - 28Apr2014 save user data id in session after persist
//Ashok Kumar - 23May2014 Navigation URL changes
//vincent- 23 May 2014- Made a change in persist method.
//Ashok Kumar 29 May 2014- Made changes on handling navigation based on Income Gateway selection

var w2WagesCount, form1099INTCount, form1099OIDCount, form1099GCount;
var defaultTaxPayerName = 'Taxpayer';
$(document).ready(
    function () {

        //Added by Praveen T on 29 May 2014
        $('.CurrentYear').html(' ' + CURRENT_TAX_YEAR);
        $('.Title').html(TITLE);
        
        GetIncomeGatewayData();

        //Saravanan N - 26th May, 2014 - Clear already Set Form1099GId from Unemployment Page. Otherwise existing Unemployment record will open while coming from Income Gateway page.
        window.sessionStorage.setItem("Form1099GId", JSON.stringify('0'));

        $('#btnContinue').click(
            function () {
                PersistIncomeGateway();
                return false;
            });
    });

//Saravanan N - 16th April, 2014 - Get IncomeGateway data.
function GetIncomeGatewayData() {
    $.ajax({
        url: serviceUrl + 'incomegateway/getincomegatewaydata',
        async: false,
        dataType: 'json',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "userId": userId,
            "userDataId": userDataId
        }),
        type: 'POST',
        contentType: 'application/json',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                //Store the values into local variables.
                var isW2HasValue, isInterestIncomeHasValue, isUnemploymentHasValue, isOtherIncomeHasValue, nickName;
                
                isW2HasValue = data.HasW2Wages;
                isInterestIncomeHasValue = data.HasInterestIncome;
                isUnemploymentHasValue = data.HasUnemploymentCompensation;
                isOtherIncomeHasValue = data.HasOtherIncome;
                nickName = data.NickName;
                //showInterestIncomeChkListPage = data.ShowInterestIncomeChkListPage;
                w2WagesCount = data.W2WagesCount;
                form1099INTCount = data.Form1099INTCount;
                form1099OIDCount = data.Form1099OIDCount;
                form1099GCount = data.Form1099GCount;
                otherIncomeCount = data.OtherIncomeCount;
                //Nickname display in Welcome message.
                //Yogalakshmi - 2nd June 2014 - Null check for nick name and if it is null it should display TaxPayer.
                if (nickName != null && nickName!="") {
                    $('#spanNickNameNewUser').html(nickName);
                    $('#spanNickNameExistingUser').html(nickName);
                }
                else {
                    $('#spanNickNameNewUser').html(defaultTaxPayerName);
                    $('#spanNickNameExistingUser').html(defaultTaxPayerName);
                }

                //Display welcome message and bottom HyperLink to IncomeSummary page.
                if (isW2HasValue || isInterestIncomeHasValue || isUnemploymentHasValue || isOtherIncomeHasValue) {
                    //Any one of the IncomeGateway exists.
                    $('.ExistingUser').show();
                }
                else {
                    //IncomeGateway not exists.
                    $('.NewUser').show();
                }

                //W2 Wages.
                $('#chkW2Wages').attr('checked', isW2HasValue);
                if (isW2HasValue) {
                    $('.WagesNormal').hide();
                    $('.WagesSelected').show();
                    $('#chkW2Wages').addClass('tick');
                }
                else {
                    $('.WagesNormal').show();
                    $('.WagesSelected').hide();
                }

                //Interest Income.
                $('#chkInterestIncome').attr('checked', isInterestIncomeHasValue);
                if (isInterestIncomeHasValue) {
                    $('.InterestIncomeNormal').hide();
                    $('.InterestIncomeSelected').show();
                    $('#chkInterestIncome').addClass('tick');

                    ////Decide whether Add / Review button has to be displayed here.
                    //if (showInterestIncomeChkListPage) {
                    //    $('#aInterIncomeReview').hide();
                    //}
                    //else {
                    //    $('#lnkInterestIncometAdd').hide();
                    //}
                }
                else {
                    $('.InterestIncomeNormal').show();
                    $('.InterestIncomeSelected').hide();
                }

                //Unemployment Compensation.
                $('#chkUnemploymentCompensation').attr('checked', isUnemploymentHasValue);
                if (isUnemploymentHasValue) {
                    $('.UnemploymentCompensationNormal').hide();
                    $('.UnemploymentCompensationSelected').show();
                    $('#chkUnemploymentCompensation').addClass('tick');
                }
                else {
                    $('.UnemploymentCompensationNormal').show();
                    $('.UnemploymentCompensationSelected').hide();
                }

                //Other Income.
                $('#chkOtherIncome').attr('checked', isOtherIncomeHasValue);
                if (isOtherIncomeHasValue) {
                    $('.OtherIncomeNormal').hide();
                    $('.OtherIncomeSelected').show();
                    $('#chkOtherIncome').addClass('tick');
                }
                else {
                    $('.OtherIncomeNormal').show();
                    $('.OtherIncomeSelected').hide();
                }
            }
        }
    });
}

//Saravanan N - 16th April, 2014 - Persist IncomeGateway data.
function PersistIncomeGateway() {
    var hasW2 = $('#chkW2Wages').prop('checked');
    var hasInterestIncome = $('#chkInterestIncome').prop('checked');
    var hasUnemployment = $('#chkUnemploymentCompensation').prop('checked');
    var hasOtherIncome = $('#chkOtherIncome').prop('checked');

    $.ajax({
        url: serviceUrl + 'incomegateway/persistincomegateway',
        async: false,
        dataType: 'json',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            'userId': userId,
            'userDataId': userDataId,
            'hasW2': hasW2,
            'hasInterestIncome': hasInterestIncome,
            'hasUnemployment': hasUnemployment,
            'hasOtherIncome': hasOtherIncome
        }),
        type: 'POST',
        contentType: 'application/json',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            window.sessionStorage.setItem("UserDataId", data);
            var pageToNavigate;
            if (hasW2)
            {
                if (w2WagesCount > 0) {
                    pageToNavigate = 'w2summary.html';
                }
                else {
                    pageToNavigate = 'w2employmentandownertype.html';
                }
            }
            else if (hasInterestIncome)
            {
                if (form1099INTCount > 0 || form1099OIDCount > 0) {
                    pageToNavigate = 'interestincomesummary.html';
                }
                else {
                    pageToNavigate = 'interestincomechecklist.html';
                }            
            }
            else if (hasUnemployment)
            {
                if (form1099GCount > 0) {
                    pageToNavigate = 'unemploymentsummary.html';
                }
                else {
                    pageToNavigate = 'Unemployment.html';
                }              
            }
            else if (hasOtherIncome)
            {
                if (otherIncomeCount > 0) {
                    pageToNavigate = 'otherincomesummary.html';
                }
                else {
                    pageToNavigate = 'otherincomegateway.html';
                }               
            }
            else
                pageToNavigate = '../Deduction/deductiongateway.html';

            //On Continue button click navigate to the page.
            window.location.href = pageToNavigate;
        }
    });
}