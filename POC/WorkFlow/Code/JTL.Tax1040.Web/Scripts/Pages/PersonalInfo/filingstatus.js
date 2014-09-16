//Filing Status Script
            
$(document).ready(function () {
    $('#btnFilingStatus').click(function () {
        PrimaryTaxPayerPersist();
    });
    
    $.ajax({
        url: serviceUrl + 'personalinfo/getprimarytaxpayer',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId, 
            UserDataId: userDataId, 
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            
            if (data.FilingStatus > 0) {
            $('input:radio[name=optionsRadios]')[data.FilingStatus - 1].checked = true;
            if (data.FilingStatus == 2) {
                $("#liSpouse").css("display", "inline");
            }
            }
            if (data.Person != null) {
                $("#lblPrimaryFilerNickName").html(data.Person.NickName);
            } else {
                $("#lblPrimaryFilerNickName").html("Primary Tax Payer");
            }
        }
});

});


function PrimaryTaxPayerPersist() {
    
    $.ajax({
        url: serviceUrl + 'personalinfo/primarytaxpayercreate',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId,
            Topic:'FilingStatus',
            PrimaryTaxPayer: {
                FilingStatus: $("input:radio:checked").val()
            }
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            window.sessionStorage.setItem("UserDataId", data.m_Item1);
            PageNavigate(data.m_Item2);
            return false;
        }
    });
    
}

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        setTimeout(function () {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=FilingStatus';
        });
    }
    else {
        setTimeout(function () {
            window.location.href = '../PersonalInfo/primaryfilerinfo.html';
        });
    }
}


