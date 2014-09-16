// 13May2014 Sathish used to bind and person details

//05June2014 Thileep Changed ID for Calendar  fields.

//10jJUly2014-Vincent -Refactor the code
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/



/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    ////Have to work on client side validation.
    //$.validator.addMethod("prodectPIN", function (value, element) {
    //    if ($('#radIdentityProtectionPINFromIRSYes').prop('checked') || $('#radIdentityProtectionPINFromIRSNo').prop('checked')) {
    //        return this.optional(element) || false;        }
    //    else {
    //        return this.optional(element) || true;        }

    //}, '');

    $('#irsEfileOption').validate({
        rules: {

            txtTaxpayerPIN: {
                minlength: 5,
                required: function () { $('#radHavePriorYearPIN').prop('checked');  }
            },
            txtSpousePIN: {
                minlength: 5,
                required: function () { $('#radHavePriorYearPIN').prop('checked');  }
            },
            txtAGITaxpayer: {
                minlength: 5,
                required: function () { $('#radHavePriorYearAGI').prop('checked');  }
            },
            txtAGISTaxpayerPIN: {
                minlength: 5,
                required: function () { $('#radHavePriorYearAGI').prop('checked');  }
            },
            txtAGISpousePIN: {
                minlength: 5,
                required: function () { $('#radHavePriorYearAGI').prop('checked');  }
            },
            txtAGISpouse: {

                required: function () { $('#radHavePriorYearAGI').prop('checked');  }
            },
            txtTaxpayerEFINIssuedbyIRS: {
                required: function () { $('#radHavePriorYearAGIAndPIN').prop('checked');  }
            },
            txtSpouseEFINIssuedbyIRS: {
                required: function () { $('#radHavePriorYearAGIAndPIN').prop('checked');  }
            },
            dtTaxpayerTodaysDate: {
                required: function () { $('#radHavePriorYearAGIAndPIN').prop('checked');  }
            },
            dtSpouseTodaysDate: {
                required: function () { $('#radHavePriorYearAGIAndPIN').prop('checked'); }
            },

            txtSpouseRecivedPINFromIRS: {
                required: true
            },
            txtTaxPayerRecivedPINFromIRS: {
                required: true
            },
        },
        messages: {
            txtTaxpayerPIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing Personal Identification Number.'
            },
            txtSpousePIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing Personal Identification Number.'
            },
            txtAGITaxpayer: {

                required: 'Missing Adjusted Gross Income'
            },
            txtAGISpouse: {

                required: 'Missing Adjusted Gross Income'
            },
            txtAGISTaxpayerPIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing 5 digit Self select PIN Number'
            },
            txtAGISpousePIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing 5 digit Self select PIN Number'
            },
            txtTaxpayerEFINIssuedbyIRS: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing EFIN Issued by IRS '
            },
            txtSpouseEFINIssuedbyIRS: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing EFIN Issued by IRS '
            },
            dtTaxpayerTodaysDate: {
                //required: $('#divTaxpayerTDErrorMsg').html('Missing EFIN Date')
                required: function () {
                    $('#divTaxpayerTDErrorMsg').html('Missing EFIN Date');
                }
            },

            dtSpouseTodaysDate: {
                required: function () {
                    $('#divSpouseTodayDateErrorMessg').html('Missing EFIN Date'); 
                }
            },


            //radIdentityProtectionPINFromIRS: {
            //    prodectPIN: $('#divIdentityProtectionPINFromIRSError').html('Missing Protection PIN number Type '),

            //},

            txtTaxPayerRecivedPINFromIRS: {
                required: 'Missing Protection PIN number',

            },
            txtSpouseRecivedPINFromIRS: {
                required: 'Missing Protection PIN number',
            }
        }
    });


    $("[name='radEfileOption']").change(function () {
        if ($('#radHavePriorYearPIN').prop("checked")) {
            //On Page 4
            $('#divHavePriorYearPIN').show();
            $('#divHavePriorYearAGI').hide();
            $('#txtAGITaxpayer').val('');
            $('#txtAGISTaxpayerPIN').val('');

            $('#divHavePriorYearAGIAndPIN').hide();
            $('#txtTaxpayerEFINIssuedbyIRS').val('');
            $('#dtTaxpayerTodaysDate').val('');

            $('#divFilingTodaydate').show();
        }
        else if ($('#radHavePriorYearAGI').prop("checked")) {
            //On Page 5
            $('#divHavePriorYearAGI').show();
            $('#divHavePriorYearAGIAndPIN').hide();
            $('#txtTaxpayerEFINIssuedbyIRS').val('');
            $('#dtTaxpayerTodaysDate').val('');


            $('#divHavePriorYearPIN').hide();
            $('#txtTaxpayerPIN').val('');
            $('#txtSpousePIN').val('');

            $('#divFilingTodaydate').show();
        }
        else if ($('#radHavePriorYearAGIAndPIN').prop("checked")) {
            //On Page 6
            $('#divHavePriorYearAGIAndPIN').show();
            $('#divHavePriorYearPIN').hide();
            $('#divHavePriorYearAGI').hide();
            $('#divFilingTodaydate').hide();

        }
    });



    $("[name='radIdentityProtectionPINFromIRS']").change(function () {
        if ($('#radIdentityProtectionPINFromIRSYes').prop('checked')) {
            //On Page 7
            $('#divRecivedPINFromIRS').show();
        }
        else if ($('#radIdentityProtectionPINFromIRSYes').prop('checked') == false) {
            $('#divRecivedPINFromIRS').hide();
        }
    });

    //Tax Payer
    $('#divTaxpayerTodaysDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });



    $('#divTaxpayerTodaysDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divTaxpayerTDErrorMsg').html('');

        if ($('#dtTaxpayerTodaysDate').val() != "") {
            $('#divTaxpayerTDErrorMsg').html('');
        }
        else {
            $('#divTaxpayerTDErrorMsg').html('Missing Todays Date');
        }
    });

    //Spouse
    $('#divSpouseTodaysDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });



    $('#divSpouseTodaysDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#dvSpouseTodayDateErrorMessg').html('');

        if ($('#dtSpouseTodaysDate').val() != "") {
            $('#dvSpouseTodayDateErrorMessg').html('');
        }
        else {
            $('#dvSpouseTodayDateErrorMessg').html('Missing Todays Date');
        }
    });


    //Filing Today's Date

    $('#divFilingDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });



    $('#divFilingDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divFilingTDErrorMsg').html('');

        if ($('#dtFillingDate').val() != "") {
            $('#divFilingTDErrorMsg').html('');
        }
        else {
            $('#divFilingTDErrorMsg').html('Missing Todays Date ');
        }
    });


    //Efile Information for Taxpayer

    $('#divFirstTimeFillerTaxpayerTodayDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });



    $('#divFirstTimeFillerTaxpayerTodayDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divFillerTDErrorMssg').html('');

        if ($('#dtFirstTimeFillerTaxpayerTodayDate').val() != "") {
            $('#divFillerTDErrorMssg').html('');
        }
        else {
            $('#divFillerTDErrorMssg').html('Missing Todays Date ');
        }
    });

    //Efile Information for Spouse


    $('#divFirstTimeFillerSpouseTodaysDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '+0d',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });



    $('#divFirstTimeFillerSpouseTodaysDate').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divSpouseFillerErrorMssg').html('');

        if ($('#dtFirstTimeFillerSpouseTodaysDate').val() != "") {
            $('#divSpouseFillerErrorMssg').html('');
        }
        else {
            $('#divSpouseFillerErrorMssg').html('Missing Todays Date ');
        }
    });

    //Nagivation section
    $('#btnReplan').click(function () {

        window.location.href = '../EFile/efileinformation.html';
        return false;
    });

    $('#btnStateFilingInfo').click(function () {
        PersistFilingReturn();
        //It navigate to page 6 its in hold as per spec
        //window.location.href = '../EFile/efileinformation.html';
        //return false;
    });

    $('#btnFederalReturn').click(function () {
        if ($('#irsEfileOption').valid()) {
            PersistFilingReturn();
            window.location.href = '../EFile/efileacknowledge.html';
            return false;
        }
    });


    $('#spanTaxYear').html(CURRENT_TAX_YEAR);

    getIRSTransmission();

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

function getIRSTransmission() {
    $.ajax({
        url: serviceUrl + 'efile/getpersonandirstransmission',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data != null) {
                if (data.m_Item1 != null)
                    $('.spanTaxPayer').html(data.m_Item1);
                if (data.m_Item2 != null) {
                    if (data.m_Item2.PrimaryTaxPayer != null) {
                        if (data.m_Item2.PrimaryTaxPayer.FilingStatus == 2) {
                            $('#divEfileOptionSpouse').show();
                            $('#divFirstTimeFillerSpouse').show();
                            $('#divSpousePriorYearPIN').show();
                            $('#divSpouseDontHavePriorYearPIN').show();
                            $('#divSpouseRecivedPINFromIRS').show();
                        }
                        if (data.m_Item2.PrimaryTaxPayer.Person != null) {
                            $('#lblTaxpayerName').html(data.m_Item2.PrimaryTaxPayer.Person.FirstName);
                            $('#lblTaxpayerSocialSecurityNumber').html(data.m_Item2.PrimaryTaxPayer.Person.SSN);

                            if (data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth != null &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1900' &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1')
                                $('#lblTaxpayerDateofBirth').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)));

                            $('#lblFirstTimeFillerTaxpayerName').html(data.m_Item2.PrimaryTaxPayer.Person.FirstName);
                            $('#lblFirstTimeFillerTaxpayerSSN').html(data.m_Item2.PrimaryTaxPayer.Person.SSN);

                            if (data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth != null &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1900' &&
                              $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1')
                                $('#lblFirstTimeFillerTaxpayerDOB').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)));
                        }
                    }
                    if (data.m_Item2.Spouse != null) {
                        $('#lblSpouseName').html(data.m_Item2.Spouse.Person.FirstName);
                        $('#lblSpouseSocialSecurityNumber').html(data.m_Item2.Spouse.Person.SSN);

                        if (data.m_Item2.Spouse.Person.DateOfBirth != null &&
                            $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1900' &&
                             $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1')
                            $('#lblSpouseDateofBirth').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)));

                        $('#lblFirstTimeFillerSpouseName').html(data.m_Item2.Spouse.Person.FirstName);
                        $('#lblFirstTimeFillerSpouseSSN').html(data.m_Item2.Spouse.Person.SSN);

                        if (data.m_Item2.Spouse.Person.DateOfBirth != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1900' &&
                            $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1')
                            $('#lblFirstTimeFillerSpouseDOB').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)));
                    }
                    if (data.m_Item3 != null) {


                        $('#radHavePriorYearPIN').prop('checked', data.m_Item3.HavePriorYearPIN);
                        $('#radHavePriorYearAGI').prop('checked', data.m_Item3.HavePriorYearAGI);
                        $('#radHavePriorYearAGIAndPIN').prop('checked', data.m_Item3.HavePriorYearAGIAndPIN);

                        if (data.m_Item3.HavePriorYearPIN) {
                            $('#divHavePriorYearPIN').show();
                            $('#divHavePriorYearAGI').hide();
                            $('#divHavePriorYearAGIAndPIN').hide();
                            $('#divFilingTodaydate').show();
                            //PIN
                            $('#txtTaxpayerPIN').val(data.m_Item3.PrimaryPIN);
                            $('#txtSpousePIN').val(data.m_Item3.SpousePIN);

                        } else if (data.m_Item3.HavePriorYearAGI) {
                            $('#divHavePriorYearAGI').show();
                            $('#divHavePriorYearAGIAndPIN').hide();
                            $('#divHavePriorYearPIN').hide();
                            $('#divFilingTodaydate').show();

                            //AGI
                            $('#txtAGITaxpayer').val(data.m_Item3.PrimaryPriorYearAGI);
                            $('#txtAGISpouse').val(data.m_Item3.SpousePriorYearAGI);

                            //PIN
                            $('#txtAGISTaxpayerPIN').val(data.m_Item3.PrimaryPriorYearPIN);
                            $('#txtAGISpousePIN').val(data.m_Item3.SpousePriorYearPIN);


                        } else if (data.m_Item3.HavePriorYearAGIAndPIN) {
                            $('#divHavePriorYearAGIAndPIN').show();
                            $('#divHavePriorYearPIN').hide();
                            $('#divHavePriorYearAGI').hide();
                            $('#divFilingTodaydate').hide();

                            $('#txtTaxpayerEFINIssuedbyIRS').val(data.m_Item3.PrimaryTaxpayerEFIN);
                            $('#txtSpouseEFINIssuedbyIRS').val(data.m_Item3.SpouseEFIN);

                            if (data.m_Item3.PrimaryTaxPayerFilingDate != null
                                && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.PrimaryTaxPayerFilingDate)) != '01/01/1900' &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.PrimaryTaxPayerFilingDate)) != '01/01/1')
                                $('#dtTaxpayerTodaysDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.PrimaryTaxPayerFilingDate)));

                            if (data.m_Item3.SpouseFilingDate != null
                                && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.SpouseFilingDate)) != '01/01/1900' &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.SpouseFilingDate)) != '01/01/1')
                                $('#dtSpouseTodaysDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.SpouseFilingDate)));
                        }


                        if (data.m_Item3.FilingDate != null
                               && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FilingDate)) != '01/01/1900' &&
                               $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FilingDate)) != '01/01/1')
                            $('#dtFillingDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FilingDate)));

                        $('#radIdentityProtectionPINFromIRSYes').prop('checked', data.m_Item3.HasReceivedIPINFromIRS);
                        $("[name='radIdentityProtectionPINFromIRS']").trigger('change');

                        if (data.m_Item3.HasReceivedIPINFromIRS) {
                            $('#txtTaxPayerRecivedPINFromIRS').val(data.m_Item3.PrimaryTaxPayerIPIN);
                            $('#txtSpouseRecivedPINFromIRS').val(data.m_Item3.SpouseIPIN);
                        }
                        else {
                            $('#divRecivedPINFromIRS').hide();

                        }

                        $('#txtFirstTimeFillerTaxpayerEFINIssuedbyIRS').val(data.m_Item3.TaxpayerEFINIssuedByIRS);
                        $('#txtFirstTimeFillerSpouseEFINIssuedbyIRS').val(data.m_Item3.SpouseEFINIssuedByIRS);

                        if (data.m_Item3.TaxpayerDateIssuedByIRS != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.TaxpayerDateIssuedByIRS)) != '01/01/1900' &&
                           $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.TaxpayerDateIssuedByIRS)) != '01/01/1')
                            $('#dtFirstTimeFillerTaxpayerTodayDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.TaxpayerDateIssuedByIRS)));

                        if (data.m_Item3.SpouseDateIssuedByIRS != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.SpouseDateIssuedByIRS)) != '01/01/1900' &&
                           $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.SpouseDateIssuedByIRS)) != '01/01/1')
                            $('#dtFirstTimeFillerSpouseTodaysDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.SpouseDateIssuedByIRS)))



                    }

                    if (data.m_Item4 != null) {
                        if (data.m_Item4.HaveFiledPriorYearReturnElectronically) {
                            //Pre-Page logic Entry #8
                            $('#divFiledTaxElectronically').show();
                            $('#divFirstTimeFiledElectronically').hide();
                        }
                        else {
                            //Pre-Page logic Entry #9
                            $('#divFirstTimeFiledElectronically').show();
                            $('#divFiledTaxElectronically').hide();

                        }

                        //Pre-Page logic Entry #10
                        if (!data.m_Item4.FederalFiling.IsEfile) {
                            $('#divPrintTaxReturn').show();

                        } else {
                            $('#divPrintTaxReturn').hide();

                        }
                    }
                }
            }
        }
    });
}

function PersistFilingReturn() {
    var taxdata = {
        HavePriorYearPIN: $('#radHavePriorYearPIN').prop('checked'),
        HavePriorYearAGI: $('#radHavePriorYearAGI').prop('checked'),
        HavePriorYearAGIAndPIN: $('#radHavePriorYearAGIAndPIN').prop('checked'),
        PrimaryPIN: $('#txtTaxpayerPIN').val(),
        SpousePIN: $('#txtSpousePIN').val(),
        PrimaryPriorYearPIN: $('#txtAGISTaxpayerPIN').val(),
        PrimaryPriorYearAGI: $('#txtAGITaxpayer').val(),
        SpousePriorYearPIN: $('#txtAGISpousePIN').val(),
        SpousePriorYearAGI: $('#txtAGISpouse').val(),
        PrimaryTaxpayerEFIN: $('#txtTaxpayerEFINIssuedbyIRS').val(),
        SpouseEFIN: $('#txtSpouseEFINIssuedbyIRS').val(),
        PrimaryTaxPayerFilingDate: $('#dtTaxpayerTodaysDate').val(),
        SpouseFilingDate: $('#dtSpouseTodaysDate').val(),
        FilingDate: $('#dtFillingDate').val(),
        HasReceivedIPINFromIRS: $('#radIdentityProtectionPINFromIRSYes').prop('checked'),
        PrimaryTaxPayerIPIN: $('#txtTaxPayerRecivedPINFromIRS').val(),
        SpouseIPIN: $('#txtSpouseRecivedPINFromIRS').val(),
        TaxpayerEFINIssuedByIRS: $('#txtFirstTimeFillerTaxpayerEFINIssuedbyIRS').val(),
        SpouseEFINIssuedByIRS: $('#txtFirstTimeFillerSpouseEFINIssuedbyIRS').val(),
        TaxpayerDateIssuedByIRS: $('#dtFirstTimeFillerTaxpayerTodayDate').val(),
        SpouseDateIssuedByIRS: $('#dtFirstTimeFillerSpouseTodaysDate').val()
    };

    $.ajax({
        url: serviceUrl + 'efile/persistirstranmission',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            userId: userId,
            TaxReturnData:
            {
                UserDataId: userDataId,
                TaxData: JSON.stringify(taxdata),
            }
        }),
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                window.sessionStorage.setItem("UserId", data);

            }
        }
    });




}
