/* 27Mya2014 Sathish Added Bind and persist for federal extension and bank information   */
/* 27May2014 Sathish Added Federal extension filed date  */

var BankDetails;
var ThirdPartyDesignee;
var BankAccountTypeCode;
var taxData;
var taxWrapUpData;

$(document).ready(function () {
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);

    $("#taxesandwrapupinfo").validate({
        rules: {
            txtFederalExtensionFiledDate:
                {
                    validateDate: function () { $('#divFederalExtensionFiledDate').html(''); true; },
                },
            txtDatePaid:
                {
                    validateDate: function () { $('#divDatePaid').html(''); true; }
                },
            txtDateOfFiling:
                {
                    validateDate: function () { $('#divDateOfFiling').html(''); true; }
                }
        },
        messages: {
            txtFederalExtensionFiledDate:
                {
                    validateDate: function () { $('#divFederalExtensionFiledDate').html('Enter a valid date'); }
                },
            txtDatePaid:
                {
                    validateDate: function () { $('#divDatePaid').html('Enter a valid date'); }
                },
            txtDateOfFiling:
                {
                    validateDate: function () { $('#divDateOfFiling').html('Enter a valid date'); }
                }
        }
    });

    $("#txtFederalExtensionAmount").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9.]/g, ''));
        }, $(this)), 0);
    });

    $('.spanFillingYear').html(FILLING_YEAR);


    $('#chkFiledForm4868').change(function () {
        if ($('#chkFiledForm4868').prop('checked'))
            $('#divFiledForm4868ForFederalExtension').show();
        else
            $('#divFiledForm4868ForFederalExtension').hide();
    });

    $('#chkFederalExtensionPaid').change(function () {
        if ($('#chkFederalExtensionPaid').prop('checked'))
            $('#divFederalExtensionPaidShow').show();
        else
            $('#divFederalExtensionPaidShow').hide();
    });
    $('#chklateFiling').change(function () {
        if ($('#chklateFiling').prop('checked'))
            $('#divLateFilingShow').show();
        else
            $('#divLateFilingShow').hide();
    });

    $("[name='radIsDirectDeposit']").change(function () {
        if ($('#radIsDirectDepositYes').prop('checked')) {
            $("#divDirectDepositofFederalTaxRefund").show();
        }
        else if ($('#radIsDirectDepositNo').prop('checked')) {
            $("#divDirectDepositofFederalTaxRefund").hide();

        }
    });

    $("[name='radIsAllowOtherPerson']").change(function () {
        if ($('#radIsAllowOtherPersonYes').prop('checked')) {
            $("#divOtherPerson").show();

        }
        else if ($('#radIsAllowOtherPersonNo').prop('checked')) {
            $("#divOtherPerson").hide();

        }
    });

    //Get Tax and Wrap up data
    $.ajax({
        url: serviceUrl + 'taxesandwrapup/gettaxandwrapup',
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
                if (data.m_Item1 != null) {
                    taxWrapUpData = data.m_Item1;
                    $('#chkFiledForm4868').prop('checked', data.m_Item1.HasFiledForm4868);
                    $('#chkFiledForm4868').trigger('change');
                    if (data.m_Item1.FederalExtensionFiledDate != null)
                        $("#txtFederalExtensionFiledDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.FederalExtensionFiledDate)));
                    $('#chkFederalExtensionPaid').prop('checked', data.m_Item1.HasPaidFederalExtensionWithForm4868);
                    $('#chkFederalExtensionPaid').trigger('change');
                    $("#txtFederalExtensionAmount").val(data.m_Item1.FederalExtensionAmount);
                    if (data.m_Item1.FederalExtensionAmountPaidDate != null)
                        $("#txtDatePaid").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.FederalExtensionAmountPaidDate)));

                    $('#chklateFiling').prop('checked', data.m_Item1.IsFilingReturnAfterDueDate);
                    $('#chklateFiling').trigger('change');
                    if (data.m_Item1.FilingDate != null)
                        $("#txtDateOfFiling").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.FilingDate)));

                    $('#radIsDirectDepositYes').prop('checked', data.m_Item1.HasToDepositTaxRefundsToBankAccount);
                    $("[name='radIsDirectDeposit']").trigger('change');
                    if (data.m_Item1.BankDetails != null) {
                        $("#txtBankRoutingNumber").val(data.m_Item1.BankDetails.RoutingTransitNumber);
                        $("#txtBankAccountNumber").val(data.m_Item1.BankDetails.AccountNumber);
                        $("#txtBankName").val(data.m_Item1.BankDetails.BankName);
                        if (data.m_Item1.BankDetails.BankAccountTypeCode == 1) {
                            $("#radChecked").prop("checked", true);
                        }
                        else if (data.m_Item1.BankDetails.BankAccountTypeCode == 2) {
                            $('#radSaved').prop('checked', true);
                        }
                    }
                
                    $('#radIsAllowOtherPersonYes').prop('checked', data.m_Item1.HasThirdPartyDesignee),
                    $("[name='radIsAllowOtherPerson']").trigger('change');
                    if (data.m_Item1.ThirdPartyDesignee != null) {
                        $("#txtDesignName").val(data.m_Item1.ThirdPartyDesignee.DesigneeName),
                        $("#txtPhoneno").val(data.m_Item1.ThirdPartyDesignee.PhoneNumber),
                        $("#txtPersonalIdentificationNumber").val(data.m_Item1.ThirdPartyDesignee.PIN)
                    }
                     $("#txtIncareof").val(data.m_Item1.InCareOf),
                    $("#txtPhoneNumber").val(data.m_Item1.InCareOfPhoneNumber)

                }
            }
            if (data == null || data.m_Item1 == null || data.m_Item1.FederalExtensionAmountPaidDate == null) {
                if(data.m_Item3 != null)
                    $("#txtDateOfFiling").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3)));
            }
        }
    });

    $('#btnSubmitOne').click(function () {
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        return false;
    });

    $(function () {
        $("#DateFiledForExtension").popover({ title: 'Date Filed for extension', content: "<h5>Date Filed for extension<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#FederalExtensionAmount").popover({ title: 'Federal Extension Amount', content: "<h5>Federal Extension Amount<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#DatePaid").popover({ title: 'Date Paid', content: "<h5>Date Paid<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#DateOfFiling").popover({ title: 'Date of Filing Your Tax return', content: "<h5>Date of Filing Your Tax return<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#BankName").popover({ title: 'Bank Name', content: "<h5>Bank Name<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#BankRoutingNumber").popover({ title: 'Bank Routing Number', content: "<h5>Bank Routing Number<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#BankAccountNumber").popover({ title: 'Bank Account Number', content: "<h5>Bank Account Number<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#DesignName").popover({ title: 'Designee Name', content: "<h5>Designee Name<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#Phoneno").popover({ title: 'Phone No', content: "<h5>Phone No<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#PersonalIdentificationNumber").popover({ title: 'Personal Identification No', content: "<h5>Personal Identification No<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#Incareof").popover({ title: 'In Care of', content: "<h5>In Care of<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#PhoneNumber").popover({ title: 'Phone Number', content: "<h5>Phone Number<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });


    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }


});



// 28May2014 Sathish Persist Tax and wrap up data
function PersistTaxAndwrapup(isContinue) {

    if ($("#taxesandwrapupinfo").valid()) {


        if ($('#radChecked').prop('checked')) {
            BankAccountTypeCode = 1;
        }
        else if ($('#radSaved').prop('checked')) {
            BankAccountTypeCode = 2;
        }
        if ($('#radIsDirectDepositYes').prop('checked')) {
            BankDetails = {
                RoutingTransitNumber: $('#txtBankRoutingNumber').val(),
                AccountNumber: $('#txtBankAccountNumber').val(),
                BankName: $('#txtBankName').val(),
                BankAccountTypeCode: BankAccountTypeCode
            }
        }
        else {
            BankDetails = null;
        }
        if ($('#radIsAllowOtherPersonYes').prop('checked')) {
            ThirdPartyDesignee =
            {
                DesigneeName: $('#txtDesignName').val(),
                PhoneNumber: $('#txtPhoneno').val(),
                PIN: $('#txtPersonalIdentificationNumber').val(),
            }
        }
        else {
            ThirdPartyDesignee = null;
        }

        var federalExtensionFiledDate = null;
        if ($('#chkFiledForm4868').prop('checked'))
            federalExtensionFiledDate = $('#txtFederalExtensionFiledDate').val();

        var federalExtensionAmount = null;
        var filingDate = null;
        if ($('#chkFederalExtensionPaid').prop('checked')) {
            federalExtensionAmount = $('#txtFederalExtensionAmount').val();
            filingDate = $('#txtDateOfFiling').val();
        }

        var federalExtensionAmountPaidDate = null;
        if ($('#chklateFiling').prop('checked')) {
            federalExtensionAmountPaidDate = $('#txtDatePaid').val();
        }


        if (taxWrapUpData != null) {
            taxData = {
                HasOwedHouseholdEmploymentTax: taxWrapUpData.HasOwedHouseholdEmploymentTax,
                HasAlternativeMinimumTax: taxWrapUpData.HasAlternativeMinimumTax,
                HasAdditionalSocialSecurityOrMedicareTax: taxWrapUpData.HasAdditionalSocialSecurityOrMedicareTax,
                HasFederalQuarterlyEstimatesPaid: taxWrapUpData.HasFederalQuarterlyEstimatesPaid,
                HasFiledForm4868: $('#chkFiledForm4868').prop('checked'),
                FederalExtensionFiledDate: federalExtensionFiledDate,
                HasPaidFederalExtensionWithForm4868: $('#chkFederalExtensionPaid').prop('checked'),
                FederalExtensionAmount: federalExtensionAmount,
                FederalExtensionAmountPaidDate: federalExtensionAmountPaidDate,
                IsFilingReturnAfterDueDate: $('#chklateFiling').prop('checked'),
                FilingDate: filingDate,
                HasToDepositTaxRefundsToBankAccount: $('#radIsDirectDepositYes').prop('checked'),
                HasThirdPartyDesignee: $('#radIsAllowOtherPersonYes').prop('checked'),
                InCareOf: $('#txtIncareof').val(),
                InCareOfPhoneNumber: $('#txtPhoneNumber').val(),
                BankDetails: BankDetails,
                ThirdPartyDesignee: ThirdPartyDesignee
            }
        }
        else {
            taxData = {
                HasFiledForm4868: $('#chkFiledForm4868').prop('checked'),
                FederalExtensionFiledDate: federalExtensionFiledDate,
                HasPaidFederalExtensionWithForm4868: $('#chkFederalExtensionPaid').prop('checked'),
                FederalExtensionAmount: federalExtensionAmount,
                FederalExtensionAmountPaidDate: federalExtensionAmountPaidDate,
                IsFilingReturnAfterDueDate: $('#chklateFiling').prop('checked'),
                FilingDate: filingDate,
                HasToDepositTaxRefundsToBankAccount: $('#radIsDirectDepositYes').prop('checked'),
                HasThirdPartyDesignee: $('#radIsAllowOtherPersonYes').prop('checked'),
                InCareOf: $('#txtIncareof').val(),
                InCareOfPhoneNumber: $('#txtPhoneNumber').val(),
                BankDetails: BankDetails,
                ThirdPartyDesignee: ThirdPartyDesignee
            }
        }

        $.ajax({
            url: serviceUrl + 'taxesandwrapup/persisttaxesandwrapupdata',
            async: false,
            dataType: "json",
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
            data: JSON.stringify({
                userId: userId,
                TaxReturnData:
                     {
                         userDataId: userDataId,
                         TaxData: JSON.stringify(taxData),
                     }
            }),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                window.sessionStorage.setItem("UserDataId", data.m_Item1);
                if (isContinue) {
                    PageNavigate(data.m_Item2);
                    return false;
                }
            }
        });
    }
}

function PageNavigate(isdiagonstics) {

    if (isdiagonstics) {
        setTimeout(function () {
            window.location.href = '../Diagnostics/finaldiagnostics.html?Topic=TaxesAndWrapUp';
        });
    }
    else {
        setTimeout(function () {
            window.location.href = '../TaxesAndWrapUp/federaltaxsummary.html';
        });
    }
}



