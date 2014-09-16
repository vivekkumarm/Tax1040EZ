// 13May2014 Sathish used to bind and person details

//05June2014 Thileep Changed ID for Calendar  fields.

//10jJUly2014-Vincent -Refactor the code
/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/



/**************************************** PAGE LOAD ACTION ****************************************/

var isElectronicallyFile = false;
var efileStateId;
$(document).ready(function () {

    var pageURL = window.location.search.substring(1);

    var parameterName = pageURL.split('=');
    if (parameterName.toString().indexOf('EfileStateId') == 0) {
        efileStateId = parameterName[1];
    }

    ////Have to work on client side validation.
    //$.validator.addMethod("prodectPIN", function (value, element) {
    //    if ($('#radIdentityProtectionPINFromIRSYes').prop('checked') || $('#radIdentityProtectionPINFromIRSNo').prop('checked')) {
    //        return this.optional(element) || false;        }
    //    else {
    //        return this.optional(element) || true;        }

    //}, '');


    //Added by Thileep 22July 2014
    $("#txtTaxpayerPIN").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtSpousePIN").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtAGISTaxpayerPIN").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtAGISpousePIN").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtTaxpayerEFINIssuedbyIRS").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtSpouseEFINIssuedbyIRS").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtTaxPayerRecivedPINFromIRS").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtSpouseRecivedPINFromIRS").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtFirstTimeFillerSpouseEFINIssuedbyIRS").keyup(function () {
        $("#divEfileOptionError").hide();
    });
    $("#txtFirstTimeFillerTaxpayerEFINIssuedbyIRS").keyup(function () {
        $("#divEfileOptionError").hide();
    });

    //21July-2014  Added By Thileep
    NumbersOnly('txtTaxpayerPIN');
    NumbersOnly('txtSpousePIN');
    NumbersOnly('txtAGISTaxpayerPIN');
    NumbersOnly('txtAGISpousePIN');
    NumbersOnly('txtTaxpayerEFINIssuedbyIRS');
    NumbersOnly('txtSpouseEFINIssuedbyIRS');
    NumbersOnly('txtTaxPayerRecivedPINFromIRS');
    NumbersOnly('txtSpouseRecivedPINFromIRS');
    NumbersOnly('txtFirstTimeFillerSpouseEFINIssuedbyIRS');
    NumbersOnly('txtFirstTimeFillerTaxpayerEFINIssuedbyIRS');
    //21July-2014  Added By Thileep
    NumbersOnly('txtAGITaxpayer');
    NumbersOnly('txtAGISpouse');


    //22July-2014 Thileep Added and changed validation for IsFileElectronically form
    $('#frmFiledTaxElectronically').validate({
        rules: {
            radEfileOption:
                {
                    required: function () { $('#divradError').html(''); true; }
                },
            dtFillingDate:
                {
                    required: function () {
                        if (isElectronicallyFile && ($('#radHavePriorYearPIN').prop('checked') || $('#radHavePriorYearAGI').prop('checked') || $('#radHavePriorYearAGIAndPIN').prop('checked'))) {
                            $('#divFilingTDErrorMsg').html('');
                            return true;
                        }
                        else { $('#divFilingTDErrorMsg').html(''); return false };
                    }

                },

            radIdentityProtectionPINFromIRS:
               {
                   required: function () { $('#divIdentityProtectionPINFromIRSError').html(''); true; }

               },

            txtTaxpayerPIN: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearPIN').prop('checked')) return true; else return false; }
            },
            txtSpousePIN: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearPIN').prop('checked')) return true; else return false; }
            },
            txtAGITaxpayer: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtAGISTaxpayerPIN: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtAGISpousePIN: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtAGISpouse: {
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtTaxpayerEFINIssuedbyIRS: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearAGIAndPIN').prop('checked')) return true; else return false; }
            },
            txtSpouseEFINIssuedbyIRS: {
                minlength: 5,
                required: function () { if (isElectronicallyFile && $('#radHavePriorYearAGIAndPIN').prop('checked')) return true; else return false; }
            },
            txtSpouseRecivedPINFromIRS: {
                required: true,
                minlength: 6

            },
            txtTaxPayerRecivedPINFromIRS: {
                required: true,
                minlength: 6

            },
        },
        messages: {

            radEfileOption:
               {
                   required: function () { $('#divradError').html('Missing Prior year PIN Information'); true; }
               },

            dtFillingDate:
                {
                    required: function () { $('#divFilingTDErrorMsg').html('Missing Filing date'); true; }
                },

            txtTaxpayerPIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing Prior year E-filing PIN'
            },
            txtSpousePIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing Prior year E-filing PIN'
            },
            txtAGITaxpayer: {

                required: 'Missing Prior Year AGI'
            },
            txtAGISpouse: {

                required: 'Missing Prior Year AGI'
            },
            txtAGISTaxpayerPIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing 5 digits E-file PIN'
            },
            txtAGISpousePIN: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing 5 digits E-file PIN'
            },
            txtTaxpayerEFINIssuedbyIRS: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing EFIN Issued by IRS '
            },
            txtSpouseEFINIssuedbyIRS: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing EFIN Issued by IRS '
            },


            radIdentityProtectionPINFromIRS: {
                required: function () { $('#divIdentityProtectionPINFromIRSError').html('Missing the Information for Identity Protection PIN received from IRS'); true; }

            },

            txtTaxPayerRecivedPINFromIRS: {
                minlength: 'Invalid Identity Protection PIN',
                required: 'Missing Identity Protection PIN'

            },
            txtSpouseRecivedPINFromIRS: {
                minlength: 'Invalid Identity Protection PIN',
                required: 'Missing Identity Protection PIN'
            }
        }
    });

    //22July-2014 Thileep Added and changed validation for FirstFileElectronically form
    $('#frmFirstTimeFiledElectronically').validate({
        rules: {
            txtFirstTimeFillerTaxpayerEFINIssuedbyIRS: {
                minlength: 5,
                required: true
            },
            txtFirstTimeFillerSpouseEFINIssuedbyIRS: {
                minlength: 5,
                required: true
            },
            dtFirstTimeFillerSpouseTodaysDate: {
                required: function () { $('#divSpouseFillerErrorMssg').html(''); true; }

            },
            dtFirstTimeFillerTaxpayerTodayDate: {
                required: function () { $('#divFillerTDErrorMssg').html(''); true; }

            }
        },
        messages:
        {
            txtFirstTimeFillerTaxpayerEFINIssuedbyIRS: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing 5 digits E-file PIN'
            },
            txtFirstTimeFillerSpouseEFINIssuedbyIRS: {
                minlength: 'Invalid Efile PIN',
                required: 'Missing 5 digits E-file PIN'
            },
            dtFirstTimeFillerSpouseTodaysDate: {
                required: function () { $('#divSpouseFillerErrorMssg').html('Missing Filing date'); true; }

            },
            dtFirstTimeFillerTaxpayerTodayDate: {
                required: function () { $('#divFillerTDErrorMssg').html('Missing Filing date'); true; }
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
            $('#txtSpouseEFINIssuedbyIRS').val('');

            $('#divFilingTodaydate').show();
        }
        else if ($('#radHavePriorYearAGI').prop("checked")) {
            //On Page 5
            $('#divHavePriorYearAGI').show();
            $('#divHavePriorYearAGIAndPIN').hide();
            $('#txtTaxpayerEFINIssuedbyIRS').val('');
            $('#txtSpouseEFINIssuedbyIRS').val('');

            //23July2014-Thileep changed to Empty the textboxes on Radiobutton selection
            $('#divHavePriorYearPIN').hide();
            $('#txtTaxpayerPIN').val('');
            $('#txtSpousePIN').val('');

            $('#txtAGISTaxpayerPIN').val('')
            $('#txtAGITaxpayer').val('')
            $('#txtAGISpousePIN').val('')
            $('#txtAGISpouse').val('')

            $('#divFilingTodaydate').show();
        }
        else if ($('#radHavePriorYearAGIAndPIN').prop("checked")) {
            //On Page 6
            $('#divHavePriorYearAGIAndPIN').show();
            $('#divHavePriorYearPIN').hide();
            $('#divHavePriorYearAGI').hide();
            //Commented by Thileep 22July2014 for O6 Logic
            //$('#divFilingTodaydate').hide();

        }
    });


    $("[name='radIdentityProtectionPINFromIRS']").change(function () {
        if ($('#radIdentityProtectionPINFromIRSYes').prop('checked')) {
            //On Page 7
            $('#divRecivedPINFromIRS').show();
            $('#txtTaxPayerRecivedPINFromIRS').val('');
            $('#txtSpouseRecivedPINFromIRS').val('');
        }
        else if ($('#radIdentityProtectionPINFromIRSYes').prop('checked') == false) {
            $('#divRecivedPINFromIRS').hide();
            $('#txtTaxPayerRecivedPINFromIRS').val('');
            $('#txtSpouseRecivedPINFromIRS').val('');
        }
    });

    //Tax Payer
    $('#divTaxpayerTodaysDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2100',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });




    //Spouse
    $('#divSpouseTodaysDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2100',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });




    //Filing Today's Date

    $('#divFilingDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2100',
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
            $('#divFilingTDErrorMsg').html('Missing Filing date');
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

        window.location.href = '../EFile/filingoption.html';
        return false;
    });

    $('#btnStateFilingInfo').click(function () {
        PersistFilingReturn();
        //It navigate to page 6 its in hold as per spec
        //window.location.href = '../EFile/efileinformation.html';
        //return false;
    });



    $('#spanTaxYear').html(CURRENT_TAX_YEAR);

    getIRSTransmission();


    $('#btnFederalReturn').click(function () {
        //$('#irsEfileOption').valid()
        //{
        if (setValidation()) {


            PersistFilingReturn();
        }
        //}
        //  window.location.href = '../EFile/efileacknowledge.html';
        return false;
    }
    );

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/

function getIRSTransmission() {
    $.ajax({
        url: serviceUrl + 'efile/getpersonandstatetransmission',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId,
            StateId: efileStateId
        }),
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            if (data != null) {
                if (data.m_Item1 != null)
                    $('.spanTaxPayer').html(data.m_Item1 + ' ');
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
                    if (data.m_Item3 != null && data.m_Item3.StateTransmission != null) {


                        $('#radHavePriorYearPIN').prop('checked', data.m_Item3.StateTransmission.HavePriorYearPIN);
                        $('#radHavePriorYearAGI').prop('checked', data.m_Item3.StateTransmission.HavePriorYearAGI);
                        $('#radHavePriorYearAGIAndPIN').prop('checked', data.m_Item3.StateTransmission.HavePriorYearAGIAndPIN);

                        if (data.m_Item3.StateTransmission.HavePriorYearPIN) {
                            $('#divHavePriorYearPIN').show();
                            $('#divHavePriorYearAGI').hide();
                            $('#divHavePriorYearAGIAndPIN').hide();
                            $('#divFilingTodaydate').show();
                            //PIN
                            $('#txtTaxpayerPIN').val(data.m_Item3.StateTransmission.PrimaryPIN);
                            $('#txtSpousePIN').val(data.m_Item3.StateTransmission.SpousePIN);

                        } else if (data.m_Item3.StateTransmission.HavePriorYearAGI) {
                            $('#divHavePriorYearAGI').show();
                            $('#divHavePriorYearAGIAndPIN').hide();
                            $('#divHavePriorYearPIN').hide();
                            $('#divFilingTodaydate').show();

                            //AGI
                            $('#txtAGITaxpayer').val(data.m_Item3.StateTransmission.PrimaryPriorYearAGI);
                            $('#txtAGISpouse').val(data.m_Item3.StateTransmission.SpousePriorYearAGI);

                            //PIN
                            $('#txtAGISTaxpayerPIN').val(data.m_Item3.StateTransmission.PrimaryPriorYearPIN);
                            $('#txtAGISpousePIN').val(data.m_Item3.StateTransmission.SpousePriorYearPIN);


                        } else if (data.m_Item3.StateTransmission.HavePriorYearAGIAndPIN) { //30Jul2014 Sathish checked property inside the object
                            $('#divHavePriorYearAGIAndPIN').show();
                            $('#divHavePriorYearPIN').hide();
                            $('#divHavePriorYearAGI').hide();
                            //Commented by Thileep 22July2014 for O6 Logic
                            //$('#divFilingTodaydate').hide();

                            $('#txtTaxpayerEFINIssuedbyIRS').val(data.m_Item3.StateTransmission.PrimaryTaxpayerEFIN);
                            $('#txtSpouseEFINIssuedbyIRS').val(data.m_Item3.StateTransmission.SpouseEFIN);


                        }


                        if (data.m_Item3.StateTransmission.FilingDate != null
                               && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.FilingDate)) != '01/01/1900' &&
                               $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.FilingDate)) != '01/01/1')
                            $('#dtFillingDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.FilingDate)));

                        $('#radIdentityProtectionPINFromIRSYes').prop('checked', data.m_Item3.StateTransmission.HasReceivedIPINFromIRS);
                        $("[name='radIdentityProtectionPINFromIRS']").trigger('change');

                        //22july2014-Thileep changed if else for radio button selection
                        if (data.m_Item3.StateTransmission.HasReceivedIPINFromIRS
                            && data.m_Item3.StateTransmission.HasReceivedIPINFromIRS != null) {
                            $('#divRecivedPINFromIRS').show();
                            $('#radIdentityProtectionPINFromIRSYes').prop('checked', 'checked')
                            $('#txtTaxPayerRecivedPINFromIRS').val(data.m_Item3.StateTransmission.PrimaryTaxPayerIPIN);
                            $('#txtSpouseRecivedPINFromIRS').val(data.m_Item3.StateTransmission.SpouseIPIN);
                        }
                        else if (!data.m_Item3.StateTransmission.HasReceivedIPINFromIRS
                                && data.m_Item3.StateTransmission.HasReceivedIPINFromIRS != null) {
                            $('#divRecivedPINFromIRS').hide();
                            $('#radIdentityProtectionPINFromIRSNo').prop('checked', 'checked')

                        }
                        else if (data.m_Item3.StateTransmission.HasReceivedIPINFromIRS == null
                                                    && data.m_Item3.StateTransmission.PrimaryTaxPayerIPIN == ""
                                                    && data.m_Item3.StateTransmission.SpouseIPIN == "") {
                            $('#radIdentityProtectionPINFromIRSYes').prop('checked', false);
                            $('#radIdentityProtectionPINFromIRSNo').prop('checked', false);
                            $('#divRecivedPINFromIRS').hide();

                        }

                        $('#txtFirstTimeFillerTaxpayerEFINIssuedbyIRS').val(data.m_Item3.StateTransmission.TaxpayerEFINIssuedByIRS);
                        $('#txtFirstTimeFillerSpouseEFINIssuedbyIRS').val(data.m_Item3.StateTransmission.SpouseEFINIssuedByIRS);

                        if (data.m_Item3.StateTransmission.TaxpayerDateIssuedByIRS != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.TaxpayerDateIssuedByIRS)) != '01/01/1900' &&
                           $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.TaxpayerDateIssuedByIRS)) != '01/01/1')
                            $('#dtFirstTimeFillerTaxpayerTodayDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.TaxpayerDateIssuedByIRS)));
                        // 28Jul2014 Sathish checked null references for spouseDataIssue
                        if (data.m_Item3.StateTransmission.SpouseDateIssuedByIRS != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.SpouseDateIssuedByIRS)) != '01/01/1900' &&
                           $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.SpouseDateIssuedByIRS)) != '01/01/1')
                            $('#dtFirstTimeFillerSpouseTodaysDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.StateTransmission.SpouseDateIssuedByIRS)))



                    }

                    if (data.m_Item4 != null) {
                        if (data.m_Item4) {
                            //Pre-Page logic Entry #8
                            $('#divFiledTaxElectronically').show();
                            $('#divFirstTimeFiledElectronically').hide();
                            isElectronicallyFile = true;
                        }
                        else {
                            //Pre-Page logic Entry #9
                            $('#divFirstTimeFiledElectronically').show();
                            $('#divFiledTaxElectronically').hide();
                            $('#divRecivedPINFromIRS').hide();
                            isElectronicallyFile = false;
                        }

                        //Pre-Page logic Entry #10
                        if (!data.m_Item3.IsEfile) {
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

//22July2014-Thileep Changed Persist method
function PersistFilingReturn() {
    var taxdata = {
        //Form1 Elcetronically
        HavePriorYearPIN: (($('#radHavePriorYearPIN').prop('checked') && isElectronicallyFile) ? true : null),
        HavePriorYearAGI: (($('#radHavePriorYearAGI').prop('checked') && isElectronicallyFile) ? true : null),
        HavePriorYearAGIAndPIN: (($('#radHavePriorYearAGIAndPIN').prop('checked') && isElectronicallyFile) ? true : null),
        //Form1 Radio button1
        PrimaryPIN: (($('#radHavePriorYearPIN').prop('checked') && isElectronicallyFile) ? $('#txtTaxpayerPIN').val() : ''),
        SpousePIN: (($('#radHavePriorYearPIN').prop('checked') && isElectronicallyFile) ? $('#txtSpousePIN').val() : ''),
        //Form1 Radio button2
        PrimaryPriorYearPIN: (($('#radHavePriorYearAGI').prop('checked') && isElectronicallyFile) ? $('#txtAGISTaxpayerPIN').val() : ''),
        PrimaryPriorYearAGI: (($('#radHavePriorYearAGI').prop('checked') && isElectronicallyFile) ? $('#txtAGITaxpayer').val() : ''),
        SpousePriorYearPIN: (($('#radHavePriorYearAGI').prop('checked') && isElectronicallyFile) ? $('#txtAGISpousePIN').val() : ''),
        SpousePriorYearAGI: (($('#radHavePriorYearAGI').prop('checked') && isElectronicallyFile) ? $('#txtAGISpouse').val() : ''),
        //Form1 Radio button3
        PrimaryTaxpayerEFIN: (($('#radHavePriorYearAGIAndPIN').prop('checked') && isElectronicallyFile) ? $('#txtTaxpayerEFINIssuedbyIRS').val() : ''),
        SpouseEFIN: (($('#radHavePriorYearAGIAndPIN').prop('checked') && isElectronicallyFile) ? $('#txtSpouseEFINIssuedbyIRS').val() : ''),
        //PrimaryTaxPayerFilingDate: (($('#radHavePriorYearAGIAndPIN').prop('checked') && isElectronicallyFile) ? $('#dtTaxpayerTodaysDate').val() : ''),
        // SpouseFilingDate: (($('#radHavePriorYearAGIAndPIN').prop('checked') && isElectronicallyFile) ? $('#dtSpouseTodaysDate').val() : ''),
        //Form1 IPIN Radio button
        HasReceivedIPINFromIRS: (($('#radIdentityProtectionPINFromIRSYes').prop('checked') && isElectronicallyFile ? true : (($('#radIdentityProtectionPINFromIRSNo').prop('checked') && isElectronicallyFile ? false : '')))),
        PrimaryTaxPayerIPIN: (($('#radIdentityProtectionPINFromIRSYes').prop('checked') && isElectronicallyFile) ? $('#txtTaxPayerRecivedPINFromIRS').val() : ''),
        SpouseIPIN: (($('#radIdentityProtectionPINFromIRSYes').prop('checked') && isElectronicallyFile) ? $('#txtSpouseRecivedPINFromIRS').val() : ''),
        //Form1 date field
        FilingDate: ((($('#radHavePriorYearAGIAndPIN').prop('checked') ||
                        $('#radHavePriorYearAGI').prop('checked') ||
                        $('#radHavePriorYearPIN').prop('checked')) && isElectronicallyFile) ? $('#dtFillingDate').val() : ''),
        //Form2 not Elcetronically
        TaxpayerEFINIssuedByIRS: (!isElectronicallyFile ? $('#txtFirstTimeFillerTaxpayerEFINIssuedbyIRS').val() : ''),
        SpouseEFINIssuedByIRS: (!isElectronicallyFile ? $('#txtFirstTimeFillerSpouseEFINIssuedbyIRS').val() : ''),
        TaxpayerDateIssuedByIRS: (!isElectronicallyFile ? $('#dtFirstTimeFillerTaxpayerTodayDate').val() : ''),
        SpouseDateIssuedByIRS: (!isElectronicallyFile ? $('#dtFirstTimeFillerSpouseTodaysDate').val() : '')
    }
    $.ajax({
        url: serviceUrl + 'efile/persiststatetranmission',
        async: false,
        dataType: "json",
        data: JSON.stringify({
            UserDataId: userDataId,
            UserId: userId,
            StateId: efileStateId,
            TaxData: JSON.stringify(taxdata),
        }),
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                $('#divEfileOptionError').html('');
                if (data.m_Item1 != 0 && data.m_Item2.length > 0) {

                    $('#divEfileOptionError').show();
                    $.each(data.m_Item2, function (index, value) {
                        $('#divEfileOptionError').append(value.ErrorText + '<br />');
                    });
                    window.sessionStorage.setItem("UserId", data.m_Item1);

                }
                else if (data.m_Item1 != 0 && data.m_Item2.length <= 0) {
                    window.location.href = '../EFile/efileacknowledge.html';
                    $('#divEfileOptionError').hide();
                    window.sessionStorage.setItem("UserId", data.m_Item1);

                }
            }
        }
    });
}

function setValidation() {
    if (isElectronicallyFile) {
        return $('#frmFiledTaxElectronically').valid();
    }
    else {
        return $('#frmFirstTimeFiledElectronically').valid();
    }
}

