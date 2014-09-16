//Saravanan N - 16th April, 2014 - Newly added for IncomeGatewaywithCheck.html file 
// Sathish N - 28Apr2014 save user data id in session after persist

$(document).ready(
    function () {
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
                isW2HasValue = data.m_Item1;
                isInterestIncomeHasValue = data.m_Item2;
                isUnemploymentHasValue = data.m_Item3;
                isOtherIncomeHasValue = data.m_Item4;
                nickName = data.m_Item5;

                //Nickname display in Welcome message.
                $('#spanNickNameNewUser').html(nickName);
                $('#spanNickNameExistingUser').html(nickName);

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
            { pageToNavigate = "w2employmentandownertype.html" }
            else if (hasInterestIncome)
            { pageToNavigate = 'InterestIncome.html'; }
            else if (hasUnemployment)
            { pageToNavigate = 'Unemployment.html'; }
            else if (hasOtherIncome)
            { pageToNavigate = 'OtherIncome.html'; }
            else
                pageToNavigate = '../Deduction/deductiongateway.html';

            //On Continue button click navigate to the page.
            window.location.href = pageToNavigate;
        }
    });
}