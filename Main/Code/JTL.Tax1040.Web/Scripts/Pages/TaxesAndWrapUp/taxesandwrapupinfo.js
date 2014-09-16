/* 27Mya2014 Sathish Added Bind and persist for federal extension and bank information   */
/* 27May2014 Sathish Added Federal extension filed date  */

var BankDetails;
var ThirdPartyDesignee;
var BankAccountTypeCode;
var taxData;
var taxWrapUpData;
var parameterName;

$(document).ready(function () {
    //06Aug2014 vivek used commonly in get and control focus
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    //Added by Praveen T on 29 May 2014
    $('.Title').html(TITLE);
    NumbersOnly('txtFederalExtensionAmount');
    NumbersOnly('txtBankRoutingNumber');
    //11Aug2014 Thileep Changed Account number validation as per spec Taxeswrapup(V1.5)
    NumbersLettersAndHyphenWithoutSpace('txtBankAccountNumber');
    NumbersOnlyNotAcceptingDot('txtPhoneNumber');
    NumbersOnlyNotAcceptingDot('txtPhoneno');


    //Added by Thileep on 03July2014
    NumbersLettersAndHyphen('txtIncareof');
    NumbersLettersAndHyphen('txtBankName');
    NumbersLettersAndHyphen('txtDesignName');
    NumbersOnlyNotAcceptingDot('txtPersonalIdentificationNumber');


    //    jQuery.validator.addMethod("validateRoutingNumber",
    //function (value, element) {
    //    if ((value != null && value != '')) {
    //        //Thileep changed Routingnumber validation on 04July2014
    //        if (value.length == 9) {
    //            var firstDigit = parseInt(value.substring(0, 1));
    //            var secondDigit = parseInt(value.substring(1, 2));
    //            //if (firstDigit == 0) {

    //            //    return true;
    //            //}
    //            if (firstDigit == 0 && secondDigit != 0) {

    //                return true;
    //            }
    //            else {
    //                var firstTwoDigit = parseInt(value.substring(0, 2));
    //                //if ((firstTwoDigit >= 10 && firstTwoDigit <= 12) || (firstTwoDigit >= 20 && firstTwoDigit <= 32)) {

    //                //    return true;
    //                //}
    //                if ((firstTwoDigit >= 1 && firstTwoDigit <= 12) || (firstTwoDigit >= 20 && firstTwoDigit <= 32)) {

    //                    return true;
    //                }
    //                else {
    //                    return false;
    //                }
    //            }
    //        }
    //    }
    //    else
    //        return true;
    //}, ""
    //);

    //    //15July2014 Thileep Added validation for BankAccountNumber to not allow All Zeors.
    //    jQuery.validator.addMethod("validateBankAccountNumber",
    //function (value, element) {
    //    if ((value != null && value != '')) {
    //        if (value.length >= 4 && value.length <= 17) {
    //            if (value == 0) {

    //                return false;
    //            }
    //            else {

    //                return true;

    //            }
    //        }
    //        else
    //            return false;
    //    }
    //    else
    //        return true;
    //}, ""
    //);


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
                },
            txtPhoneNumber:
                {
                    minlength: 12,
                    maxlength: 12,
                    validatePhoneNumber: true
                },
            txtPhoneno:
                {
                    minlength: 12,
                    maxlength: 12,
                    validatePhoneNumber: true
                },
            txtBankRoutingNumber:
                {
                    minlength: 9,
                    maxlength: 9
                    //validateRoutingNumber: true //16Jul2014 Sathish commented this validation since this validation should occur in server side only
                },
            txtBankAccountNumber:
                  {
                      minlength: 4,
                      maxlength: 17
                      //validateBankAccountNumber: true //16Jul2014 Sathish commented this validation since this validation should occur in server side only
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
                },
            txtPhoneNumber:
                {
                    minlength: "Invalid Phone Number",
                    maxlength: "Invalid Phone Number",
                    validatePhoneNumber: "Invalid Phone Number"
                },
            txtPhoneno:
                {
                    minlength: "Invalid Phone Number",
                    maxlength: "Invalid Phone Number",
                    validatePhoneNumber: "Invalid Phone Number"
                },
            txtBankRoutingNumber:
                {
                    minlength: "Invalid Routing Number",
                    maxlength: "Invalid Routing Number"
                    //validateRoutingNumber: "Invalid Routing Number", //16Jul2014 Sathish commented this validation since this validation should occur in server side only
                },
            txtBankAccountNumber:
                  {
                      minlength: "Invalid Account Number",
                      maxlength: "Invalid Account Number"
                      //validateBankAccountNumber: "Invalid Account Number" //16Jul2014 Sathish commented this validation since this validation should occur in server side only
                  }
        }
    });

    //Thileep added datepicker event on 12Jun2014
    //vivek modified by vivek for the future year before 15-Apr-2015 modified on 17-jun-14
    //18-Jun-2014, BalaRemoved hard code filing date
    $('#divExtensionFiledDate').datepicker({
        format: "mm/dd/yyyy",
        // endDate: '+0d',
        //startView: "decade",
        minViewMode: "day",
        startDate: FILING_START_DATE,
        endDate: FILING_END_DATE,
        autoclose: true,
        forceParse: false,
        onClose: function () { $(this).valid(); },
    });

    $('#divExtensionFiledDate').on('changeDate', function (ev) {
        $(this).datepicker('hide');
        $('#divFederalExtensionFiledDate').html('');

        if ($('#txtFederalExtensionFiledDate').val() != "") {
            $('#divFederalExtensionFiledDate').html('');
        }
        else {
            $('#divFederalExtensionFiledDate').html('Missing Extension Filing Date');
        }
    });

    //Thileep added datepicker event on 12Jun2014
    //Modified by prasana for displaying date between 01.01.2015 to 04.15.2015
    //18-Jun-2014, BalaRemoved hard code filing date
    $('#divAmountPaidDate').datepicker({
        format: "mm/dd/yyyy",
        //startView: "decade",
        minViewMode: "day",
        startDate: FILING_START_DATE,
        endDate: FILING_END_DATE,
        autoclose: true,
        // endDate: '+0d',
        forceParse: false,
        onClose: function () { $(this).valid(); },
    });

    $('#divAmountPaidDate').on('changeDate', function (ev) {
        $(this).datepicker('hide');
        $('#divDatePaid').html('');

        if ($('#txtDatePaid').val() != "") {
            $('#divDatePaid').html('');
        }
        else {
            $('#divDatePaid').html('Missing Paid Date');
        }
    });

    //Thileep added datepicker event on 12Jun2014
    //18-Jun-2014, BalaRemoved hard code filing date
    $('#divFilingDate').datepicker({
        format: "mm/dd/yyyy",
        minViewMode: "day",
        startDate: FILING_END_DATE,
        autoclose: true,
        //  endDate: '+0d',
        forceParse: false,
        onClose: function () { $(this).valid(); },
    });

    $('#divFilingDate').on('changeDate', function (ev) {
        $(this).datepicker('hide');
        $('#divDateOfFiling').html('');

        if ($('#txtDateOfFiling').val() != "") {
            $('#divDateOfFiling').html('');
        }
        else {
            $('#divDateOfFiling').html('Missing Filing Date');
        }
    });
    //vivek 30-june-14 for the calendar focus
    $('#chkFiledForm4868').focusin(function () {
        $('#divExtensionFiledDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chkFederalExtensionPaid').focusin(function () {
        $('#divExtensionFiledDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chklateFiling').focusin(function () {
        $('#divAmountPaidDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#txtFederalExtensionAmount').focusin(function () {
        $('#divAmountPaidDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#btnSubmitOne').focusin(function () {
        $('#divFilingDate').datepicker('hide');
    });
    //vivek 30-june-14 for the calendar focus
    $('#chklateFiling').focusin(function () {
        $('#divFilingDate').datepicker('hide');
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
        else {
            $('#divFiledForm4868ForFederalExtension').hide();
            $('#txtFederalExtensionFiledDate').val('');
        }
    });

    $('#chkFederalExtensionPaid').change(function () {
        if ($('#chkFederalExtensionPaid').prop('checked'))
            $('#divFederalExtensionPaidShow').show();
        else {
            $('#divFederalExtensionPaidShow').hide();
            $('#txtFederalExtensionAmount').val('');
            $('#txtDatePaid').val('');
        }
    });
    $('#chklateFiling').change(function () {
        if ($('#chklateFiling').prop('checked')) {
            $('#divLateFilingShow').show();
            //18Jun2014, Bala, Since Datepicker showing date from filing due date, so code commented
            //$('#txtDateOfFiling').val($.datepicker.formatDate('mm/dd/yy', new Date()));
        }
        else {
            $('#divLateFilingShow').hide();
            $('#txtDateOfFiling').val('');
        }
    });

    $("[name='radIsDirectDeposit']").change(function () {
        if ($('#radIsDirectDepositYes').prop('checked')) {
            $("#divDirectDepositofFederalTaxRefund").show();
        }
        else if ($('#radIsDirectDepositNo').prop('checked')) {
            $("#divDirectDepositofFederalTaxRefund").hide();
            $('#txtBankName').val('');
            $('#txtBankRoutingNumber').val('');
            $('#txtBankAccountNumber').val('');
            $("#radChecked").prop("checked", false);
            $("#radSaved").prop("checked", false);
        }
    });

    $("[name='radIsAllowOtherPerson']").change(function () {
        if ($('#radIsAllowOtherPersonYes').prop('checked')) {
            $("#divOtherPerson").show();

        }
        else if ($('#radIsAllowOtherPersonNo').prop('checked')) {
            $("#divOtherPerson").hide();
            $('#txtDesignName').val('');
            $('#txtPhoneno').val('');
            $('#txtPersonalIdentificationNumber').val('');

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
                        //filingDate = data.m_Item1.FilingDate;
                        $("#txtDateOfFiling").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item1.FilingDate)));
                    //12Aug2014-Condition changed by Thileep
                    if (data.m_Item1.HasToDepositTaxRefundsToBankAccount == true)
                    {
                        $('#radIsDirectDepositYes').prop('checked', 'checked');
                    }
                    if (data.m_Item1.HasToDepositTaxRefundsToBankAccount == false)
                    {
                        $('#radIsDirectDepositNo').prop('checked', 'checked');
                    }
                    $("[name='radIsDirectDeposit']").trigger('change');
                    if (data.m_Item1.BankDetails != null) {
                        $("#txtBankRoutingNumber").val(data.m_Item1.BankDetails.RoutingTransitNumber);
                        $("#txtBankAccountNumber").val(data.m_Item1.BankDetails.AccountNumber);
                        $("#txtBankName").val(data.m_Item1.BankDetails.BankName);

                        //04August2014-Thileep Changed if else condition for Binding radio button selection
                        if (data.m_Item1.BankDetails.BankAccountTypeCode == "Checking") {
                            $("#radChecked").prop("checked", true);
                        }
                        else if (data.m_Item1.BankDetails.BankAccountTypeCode == "Saving") {
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
            if (data.m_Item4 != null) {
                if (parameterName != undefined && parameterName.length == 2) {
                    $.each(data.m_Item4, function (index, value) {

                        var rfparameterName = value.FieldName.split('-');
                        if (rfparameterName.length == 2) {
                            var controlToFocus = rfparameterName[1];
                            $('#' + controlToFocus).removeClass("form-control tip").addClass("tip error");
                            //06Aug2014 Sathish add onblur event to the control to remove error class
                            RemoveControlHighlighting(controlToFocus);
                        }
                    });
                }
            }
            //19Jun2014, Bala, Since Datepicker showing date from filing due date, so code commented
            //if (data == null || data.m_Item1 == null || data.m_Item1.FilingDate == null) {
            //    if (data.m_Item1.IsFilingReturnAfterDueDate && data.m_Item3 != null)
            //        $("#txtDateOfFiling").val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3)));
            //}
        }
    });

    $('#btnSubmitOne').click(function () {
        $('#collapselinkOne').removeClass('accordion-toggle').addClass('accordion-toggle collapsed');
        $('#collapselinktwo').removeClass('accordion-toggle collapsed').addClass('accordion-toggle ');
        if ($("#taxesandwrapupinfo").valid()) {
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
            $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        }
        return false;
    });

    //Added by Prasana on 04.06.2014
    //05Aug2014_Thileep Changed Quickhelp content as per Credit spec(V1.6) and with Latest Quickhelp format
    $(function () {
        $("#DateFiledForExtension").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Date Filed for Extension'?</h5>This is the date on which you filed the Form 4868 automatic extension for Federal Individual income tax return.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#FederalExtensionAmount").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Federal Extension Amount?</h5>This is the estimated amount of total tax liability that you paid and reported on line 4 of Form 4868.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#DatePaid").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Date Paid'?</h5>This is the date on which you paid your estimated total tax liability, which is reported on line 4 of Form 4868.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#DateOfFiling").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is your filing Date?</h5>If you are filing your tax return after the due date (04/15/2015), you have to select the expected date on which you will  like to file your tax return. <br/><br/>Interest & penalty amount for unpaid tax due will be calculated with this filing date.     <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#BankName").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your Bank Name?</h5>If you want to deposit your tax refunds directly to your Bank Account, we will need your Bank Name to make it happen.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#BankRoutingNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your Bank Routing Number?</h5>If you want to deposit your tax refunds directly to your Bank Account, we will need your Bank Routing Number to make it happen.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#BankAccountNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need your Bank Account Number?</h5>If you want to deposit your tax refunds directly to your Bank Account, we will need your Bank Account Number to make it happen.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#DesignName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Designee Name'?</h5> This is the name of the person who you have designated to discuss your return with IRS. <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#Phoneno").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why is 'Designee's Phone Number'?</h5>This is the Phone Number of the person who you have designated to discuss your return with IRS.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#PersonalIdentificationNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Designee's Personal Identification Number'?</h5>This is the Personal Identification Number of the person who you have designated to discuss your return with IRS.  <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#Incareof").popover({ title: 'Quick Help', html: 'true', content: "<h5>What does 'In care of' stand here?</h5>This is the name of the person who takes care of all your taxation troubles. This might be your attorney, executor, personal assistant.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#PhoneNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>Which Phone Number do we need?</h5>You can give the daytime phone number of your attorney, executor, personal assistant. <br/><br/>Don't worry! We won't bother them with sales calls!<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });


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
        var federalExtensionAmountPaidDate = null;
        if ($('#chkFederalExtensionPaid').prop('checked')) {
            federalExtensionAmount = $('#txtFederalExtensionAmount').val();
            federalExtensionAmountPaidDate = $('#txtDatePaid').val();
        }


        var filingDate = null;
        if ($('#chklateFiling').prop('checked')) {
            filingDate = $('#txtDateOfFiling').val();
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
                //12Aug2014 - Condition changed by Thileep for Amount Refund Status
                HasToDepositTaxRefundsToBankAccount: ($('#radIsDirectDepositYes').prop('checked') == false
                                             && $('#radIsDirectDepositNo').prop('checked') == false)
                                                ? null : $('#radIsDirectDepositYes').prop('checked'),
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
            //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
            window.location.href = '../Review/finalsummary.html?Topic=TaxesAndWrapUp';
        });
    }
    else {
        setTimeout(function () {
            window.location.href = '../TaxesAndWrapUp/federaltaxsummary.html';
        });
    }
}



