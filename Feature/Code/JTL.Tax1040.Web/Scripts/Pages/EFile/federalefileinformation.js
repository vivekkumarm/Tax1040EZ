// 13May2014 Sathish used to bind and person details

//05June2014 Thileep Changed ID for Calendar  fields.

//10jJUly2014-Vincent -Refactor the code
//21 Aug 2014-Vincent- Worked on decimal for the amount fields
//25Aug2014 Thileep changed Error Messages and changes Regarding File spec(V1.6)

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/



/**************************************** PAGE LOAD ACTION ****************************************/

var isElectronicallyFile = false;
var hasValidaiton = false;
var hasIPINValidation = false;
var isEfile;
$(document).ready(function () {

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

    $('#divFilingTodaydate').hide(); //19Aug2014 Sathish hides the filing date and shown only after selecting prior year AGI information

    //21July-2014  Added By Thileep
    //12Jul2014 Sathish changed validation not to accept Dot for PIN #TAX1040-14451
    NumbersOnlyNotAcceptingDot('txtTaxpayerPIN');
    NumbersOnlyNotAcceptingDot('txtSpousePIN');
    NumbersOnlyNotAcceptingDot('txtAGISTaxpayerPIN');
    NumbersOnlyNotAcceptingDot('txtAGISpousePIN');
    NumbersOnlyNotAcceptingDot('txtTaxpayerEFINIssuedbyIRS');
    NumbersOnlyNotAcceptingDot('txtSpouseEFINIssuedbyIRS');
    NumbersOnlyNotAcceptingDot('txtTaxPayerRecivedPINFromIRS');
    NumbersOnlyNotAcceptingDot('txtSpouseRecivedPINFromIRS');
    NumbersOnlyNotAcceptingDot('txtFirstTimeFillerSpouseEFINIssuedbyIRS');
    NumbersOnlyNotAcceptingDot('txtFirstTimeFillerTaxpayerEFINIssuedbyIRS');
    //21July-2014  Added By Thileep
    NumbersOnly('txtAGITaxpayer');
    NumbersOnly('txtAGISpouse');


    //22July-2014 Thileep Added and changed validation for IsFileElectronically form
    $('#frmFiledTaxElectronically').validate({
        rules: {
            radEfileOption:
                {
                    required: function () { if (hasValidaiton) { $('#divradError').html(''); return true; } else { $('#divradError').html(''); return false; } }
                },
            dtFillingDate:
                {
                    required: function () {
                        if (hasValidaiton && isElectronicallyFile && ($('#radHavePriorYearPIN').prop('checked') || $('#radHavePriorYearAGI').prop('checked') || $('#radHavePriorYearAGIAndPIN').prop('checked'))) {
                            $('#divFilingTDErrorMsg').html('');
                            return true;
                        }
                        else { $('#divFilingTDErrorMsg').html(''); return false };
                    }

                },

            radIdentityProtectionPINFromIRS:
               {
                   required: function () { if (hasIPINValidation) { $('#divIdentityProtectionPINFromIRSError').html(''); return true; } else { $('#divIdentityProtectionPINFromIRSError').html(''); return false; } }

               },

            txtTaxpayerPIN: {
                minlength: 5,
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearPIN').prop('checked')) return true; else return false; }
            },
            txtSpousePIN: {
                minlength: 5,
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearPIN').prop('checked')) return true; else return false; }
            },
            txtAGITaxpayer: {
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtAGISTaxpayerPIN: {
                minlength: 5,
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtAGISpousePIN: {
                minlength: 5,
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtAGISpouse: {
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearAGI').prop('checked')) return true; else return false; }
            },
            txtTaxpayerEFINIssuedbyIRS: {
                minlength: 5,
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearAGIAndPIN').prop('checked')) return true; else return false; }
            },
            txtSpouseEFINIssuedbyIRS: {
                minlength: 5,
                required: function () { if (hasValidaiton && isElectronicallyFile && $('#radHavePriorYearAGIAndPIN').prop('checked')) return true; else return false; }
            },
            txtSpouseRecivedPINFromIRS: {
                required: function () { if (hasValidaiton) return true; else return false; },
                minlength: 6

            },
            txtTaxPayerRecivedPINFromIRS: {
                required: function () { if (hasValidaiton) return true; else return false; },
                minlength: 6

            },
        },
        messages: {

            radEfileOption:
               {
                   required: function () { $('#divradError').html('Prior year PIN Information is missing'); }
               },

            dtFillingDate:
                {
                    required: function () { $('#divFilingTDErrorMsg').html('Filing Date is missing'); true; }
                },

            txtTaxpayerPIN: {
                minlength: 'Efile PIN is invalid',
                required: 'Prior year E-filing PIN is missing'
            },
            txtSpousePIN: {
                minlength: 'Efile PIN is invalid',
                required: 'Prior year E-filing PIN is missing'
            },
            txtAGITaxpayer: {

                required: 'Prior Year AGI is missing'
            },
            txtAGISpouse: {

                required: 'Prior Year AGI is missing'
            },
            txtAGISTaxpayerPIN: {
                minlength: 'Efile PIN is invalid',
                required: '5 Digit E-file PIN is missing'
            },
            txtAGISpousePIN: {
                minlength: 'Efile PIN is invalid',
                required: '5 Digit E-file PIN is missing'
            },
            txtTaxpayerEFINIssuedbyIRS: {
                minlength: 'Efile PIN is invalid',
                required: '5 Digit E-file PIN is missing'
            },
            txtSpouseEFINIssuedbyIRS: {
                minlength: 'Efile PIN is invalid',
                required: '5 Digit E-file PIN is missing'
            },


            radIdentityProtectionPINFromIRS: {
                required: function () { $('#divIdentityProtectionPINFromIRSError').html('Information for Identity Protection PIN received from IRS is missing'); true; }

            },

            txtTaxPayerRecivedPINFromIRS: {
                minlength: 'Identity Protection PIN is invalid',
                required: 'Identity Protection PIN is missing'

            },
            txtSpouseRecivedPINFromIRS: {
                minlength: 'Identity Protection PIN is invalid',
                required: 'Identity Protection PIN is missing'
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
                minlength: 'Efile PIN is invalid',
                required: '5 Digit E-file PIN is missing'
            },
            txtFirstTimeFillerSpouseEFINIssuedbyIRS: {
                minlength: 'Efile PIN is invalid',
                required: '5 Digit E-file PIN is missing'
            },
            dtFirstTimeFillerSpouseTodaysDate: {
                required: function () { $('#divSpouseFillerErrorMssg').html('Missing Filing date'); true; }
            },
            dtFirstTimeFillerTaxpayerTodayDate: {
                required: function () { $('#divFillerTDErrorMssg').html('Missing Filing date'); true; }
            }
        }
    });


    $("[name='radEfileOption']").click(function () {
        hasValidaiton = false;
    });

    $("[name='radEfileOption']").change(function () {

        $('#divFilingTodaydate').show(); // 19Aug2014 Sathish show the filing date after selecting prior year AGI information

        if ($('#radHavePriorYearPIN').prop("checked")) {
            //On Page 4
            $('#divHavePriorYearPIN').show();
            $('#divHavePriorYearAGI').hide();
            $('#txtAGITaxpayer').val('');
            $('#txtAGISTaxpayerPIN').val('');

            $('#divHavePriorYearAGIAndPIN').hide();
            $('#txtTaxpayerEFINIssuedbyIRS').val('');
            $('#txtSpouseEFINIssuedbyIRS').val('');
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


    $("[name='radIdentityProtectionPINFromIRS']").click(function () {
        hasIPINValidation = false;
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
        endDate: '01/01/2050',  //08Aug2014 Sathish As per suggestion with BA set feature date upto 2014
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });




    //Spouse
    $('#divSpouseTodaysDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050', //08Aug2014 Sathish As per suggestion with BA set feature date upto 2014
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });




    //Filing Today's Date

    $('#divFilingDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050', //08Aug2014 Sathish As per suggestion with BA set feature date upto 2014
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
            $('#divFilingTDErrorMsg').html('Filing Date is missing');
        }
    });


    //Efile Information for Taxpayer

    $('#divFirstTimeFillerTaxpayerTodayDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050', //08Aug2014 Sathish As per suggestion with BA set feature date upto 2014
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
        endDate: '01/01/2050', //08Aug2014 Sathish As per suggestion with BA set feature date upto 2014
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });
    //13Aug2014-Thileep Added Quickhelp content as per File Spec(V1.5)
    $(function () {
        $("#popFirstTimeFillerTaxpayerEFINIssuedbyIRS").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is E-file PIN?</h5>This is a 5 digit E-file Self-select personal identification number that allows filer to electronically sign their individual income tax return<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popFirstTimeFillerSpouseEFINIssuedbyIRS").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is E-file PIN?</h5>This is a 5 digit E-file Self-select personal identification number that allows filer to electronically sign their individual income tax return<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxpayerPIN").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is E-file PIN?</h5>This is a 5 digit E-file Self-select personal identification number that allows filer to electronically sign their individual income tax return<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpousePIN").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is E-file PIN?</h5>This is a 5 digit E-file Self-select personal identification number that allows filer to electronically sign their individual income tax return<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAGITaxpayer").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Prior Year adjusted gross income?</h5>This is nothing but your adjusted gross income of the year 2013. You can see the info in 1040 EZ Line 4 or 1040 Line 32 or 1040A Line 21.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAGISpouse").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Prior Year adjusted gross income?</h5>This is nothing but your adjusted gross income of the year 2013. You can see the info in 1040 EZ Line 4 or 1040 Line 32 or 1040A Line 21.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAGISTaxpayerPIN").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Prior Year PIN?</h5>This is a 5 digit  prior year E-file Self-select personal identification number that allowed filer to electronically sign their individual income tax return.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popAGISpousePIN").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Prior Year PIN?</h5>This is a 5 digit  prior year E-file Self-select personal identification number that allowed filer to electronically sign their individual income tax return.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxpayerEFINIssuedbyIRS").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is E-file PIN?</h5>This is a 5 digit E-file Self-select personal identification number that allows filer to electronically sign their individual income tax return<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpouseEFINIssuedbyIRS").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is E-file PIN?</h5>This is a 5 digit E-file Self-select personal identification number that allows filer to electronically sign their individual income tax return<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popTaxPayerRecivedPINFromIRS").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Identity Protection PIN?</h5>This is a single-use 6-digit Identity Protection PIN provided to the filer by the IRS Notice CP01A.<br /><br />The Identity Protection PIN will appear on the printed (or PDF) copy of your return. The PIN is automatically transmitted to the IRS with an electronically filed return.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popSpouseRecivedPINFromIRS").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is Identity Protection PIN?</h5>This is a single-use 6-digit Identity Protection PIN provided to the filer by the IRS Notice CP01A.<br /><br />The Identity Protection PIN will appear on the printed (or PDF) copy of your return. The PIN is automatically transmitted to the IRS with an electronically filed return.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

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
        //18Aug2014 Sathish redirected to user referral if paper file is selected.
        if (isEfile) {
            hasValidaiton = true;
            hasIPINValidation = true;
            if (setValidation()) {
                PersistFilingReturn();
            }
            else {
                $('#divEfileOptionError').hide();
            }
        }
        else {
            window.location.href = '../FinalPage/userreferral.html';
        }
        return false;
    }
    );

    //Vincent-26/06/14- Genernating 1040EZ Output Form
    $('#aPrint1040EZ').click(function () {
          Genernate1040EZForm();
        //20Aug2014 Sathish commented Genernate1040EZForm and called windows.print to print 1040EZ
        //window.print();
        return false;
    });

    //20Aug2014 Sathish set PDF url to print PDF in print dialog
    $('#aPrint1040EZ').attr('href', serviceUrl + 'taxreturn/getworksheet/' + userId + '/' + userDataId + '/F1040EZBinding');


    $('input[type="radio"]').click(function () {
        if ($(this).is(':checked')) {
            hasValidaiton = false;
            $('#frmFiledTaxElectronically').valid();
        }
    });

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
                            //07aug2014 Sathish checked null references for First Name or Last name to avoid showing null in the page
                            var taxPayerFirstNameLastName = ((data.m_Item2.PrimaryTaxPayer.Person.FirstName != null) ?
                                                             data.m_Item2.PrimaryTaxPayer.Person.FirstName : '') + ' ' +
                                                             ((data.m_Item2.PrimaryTaxPayer.Person.LastName != null) ?
                                                             data.m_Item2.PrimaryTaxPayer.Person.LastName : '')
                            $('#lblTaxpayerName').html(taxPayerFirstNameLastName);

                            $('#lblTaxpayerSocialSecurityNumber').html(data.m_Item2.PrimaryTaxPayer.Person.SSN);

                            if (data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth != null &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1900' &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1')
                                $('#lblTaxpayerDateofBirth').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)));

                            $('#lblFirstTimeFillerTaxpayerName').html(taxPayerFirstNameLastName);

                            $('#lblFirstTimeFillerTaxpayerSSN').html(data.m_Item2.PrimaryTaxPayer.Person.SSN);

                            if (data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth != null &&
                                $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1900' &&
                              $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1')
                                $('#lblFirstTimeFillerTaxpayerDOB').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)));
                        }
                    }
                    if (data.m_Item2.Spouse != null) {
                        //07aug2014 Sathish checked null references for First Name or Last name to avoid showing null in the page
                        var spouseFirstNameLastName = ((data.m_Item2.Spouse.Person.FirstName != null) ?
                                                             data.m_Item2.Spouse.Person.FirstName : '') + ' ' +
                                                             ((data.m_Item2.Spouse.Person.LastName != null) ?
                                                             data.m_Item2.Spouse.Person.LastName : '')

                        $('#lblSpouseName').html(spouseFirstNameLastName);
                        $('#lblSpouseSocialSecurityNumber').html(data.m_Item2.Spouse.Person.SSN);

                        if (data.m_Item2.Spouse.Person.DateOfBirth != null &&
                            $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1900' &&
                             $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1')
                            $('#lblSpouseDateofBirth').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)));

                        $('#lblFirstTimeFillerSpouseName').html(spouseFirstNameLastName);
                        $('#lblFirstTimeFillerSpouseSSN').html(data.m_Item2.Spouse.Person.SSN);

                        if (data.m_Item2.Spouse.Person.DateOfBirth != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1900' &&
                            $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1')
                            $('#lblFirstTimeFillerSpouseDOB').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)));
                    }
                    if (data.m_Item3 != null
                        && data.m_Item3.FederalFiling != null
                        && data.m_Item3.FederalFiling.IRS != null
                        && data.m_Item3.FederalFiling.IRS.IRSTransmission != null) {


                        $('#radHavePriorYearPIN').prop('checked', data.m_Item3.FederalFiling.IRS.IRSTransmission.HavePriorYearPIN);
                        $('#radHavePriorYearAGI').prop('checked', data.m_Item3.FederalFiling.IRS.IRSTransmission.HavePriorYearAGI);
                        $('#radHavePriorYearAGIAndPIN').prop('checked', data.m_Item3.FederalFiling.IRS.IRSTransmission.HavePriorYearAGIAndPIN);

                        if (data.m_Item3.FederalFiling.IRS.IRSTransmission.HavePriorYearPIN) {
                            $('#divHavePriorYearPIN').show();
                            $('#divHavePriorYearAGI').hide();
                            $('#divHavePriorYearAGIAndPIN').hide();
                            $('#divFilingTodaydate').show();
                            //PIN
                            $('#txtTaxpayerPIN').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryPIN);
                            $('#txtSpousePIN').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpousePIN);

                        } else if (data.m_Item3.FederalFiling.IRS.IRSTransmission.HavePriorYearAGI) {
                            $('#divHavePriorYearAGI').show();
                            $('#divHavePriorYearAGIAndPIN').hide();
                            $('#divHavePriorYearPIN').hide();
                            $('#divFilingTodaydate').show();

                            //AGI
                            $('#txtAGITaxpayer').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryPriorYearAGI == null ? "" : data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryPriorYearAGI.toFixed(2));
                            $('#txtAGISpouse').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpousePriorYearAGI == null ? "" : data.m_Item3.FederalFiling.IRS.IRSTransmission.SpousePriorYearAGI.toFixed(2));

                            //PIN
                            $('#txtAGISTaxpayerPIN').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryPriorYearPIN);
                            $('#txtAGISpousePIN').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpousePriorYearPIN);


                        } else if (data.m_Item3.FederalFiling.IRS.IRSTransmission.HavePriorYearAGIAndPIN) { //30Jul2014 Sathish checked property inside the object
                            $('#divHavePriorYearAGIAndPIN').show();
                            $('#divHavePriorYearPIN').hide();
                            $('#divHavePriorYearAGI').hide();
                            //Commented by Thileep 22July2014 for O6 Logic
                            $('#divFilingTodaydate').show(); //19Aug2014 Sathish hides the filing date and shown only after selecting prior year AGI information

                            $('#txtTaxpayerEFINIssuedbyIRS').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxpayerEFIN);
                            $('#txtSpouseEFINIssuedbyIRS').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseEFIN);


                        }


                        if (data.m_Item3.FederalFiling.IRS.IRSTransmission.FilingDate != null
                               && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.FilingDate)) != '01/01/1900' &&
                               $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.FilingDate)) != '01/01/1')
                            $('#dtFillingDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.FilingDate)));

                        $('#radIdentityProtectionPINFromIRSYes').prop('checked', data.m_Item3.FederalFiling.IRS.IRSTransmission.HasReceivedIPINFromIRS);
                        $("[name='radIdentityProtectionPINFromIRS']").trigger('change');

                        //22july2014-Thileep changed if else for radio button selection
                        if (data.m_Item3.FederalFiling.IRS.IRSTransmission.HasReceivedIPINFromIRS
                            && data.m_Item3.FederalFiling.IRS.IRSTransmission.HasReceivedIPINFromIRS != null) {
                            $('#divRecivedPINFromIRS').show();
                            $('#radIdentityProtectionPINFromIRSYes').prop('checked', 'checked')
                            $('#txtTaxPayerRecivedPINFromIRS').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerIPIN);
                            $('#txtSpouseRecivedPINFromIRS').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseIPIN);
                        }
                        else if (!data.m_Item3.FederalFiling.IRS.IRSTransmission.HasReceivedIPINFromIRS
                                && data.m_Item3.FederalFiling.IRS.IRSTransmission.HasReceivedIPINFromIRS != null) {
                            $('#divRecivedPINFromIRS').hide();
                            $('#radIdentityProtectionPINFromIRSNo').prop('checked', 'checked')

                        }
                        else if (data.m_Item3.HasReceivedIPINFromIRS == null
                                                    && data.m_Item3.FederalFiling.IRS.IRSTransmission.PrimaryTaxPayerIPIN == ""
                                                    && data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseIPIN == "") {
                            $('#radIdentityProtectionPINFromIRSYes').prop('checked', false);
                            $('#radIdentityProtectionPINFromIRSNo').prop('checked', false);
                            $('#divRecivedPINFromIRS').hide();

                        }

                        $('#txtFirstTimeFillerTaxpayerEFINIssuedbyIRS').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.TaxpayerEFINIssuedByIRS);
                        $('#txtFirstTimeFillerSpouseEFINIssuedbyIRS').val(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseEFINIssuedByIRS);

                        if (data.m_Item3.FederalFiling.IRS.IRSTransmission.TaxpayerDateIssuedByIRS != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.TaxpayerDateIssuedByIRS)) != '01/01/1900' &&
                           $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.TaxpayerDateIssuedByIRS)) != '01/01/1')
                            $('#dtFirstTimeFillerTaxpayerTodayDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.TaxpayerDateIssuedByIRS)));
                        // 28Jul2014 Sathish checked null references for spouseDataIssue
                        if (data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseDateIssuedByIRS != null
                            && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseDateIssuedByIRS)) != '01/01/1900' &&
                           $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseDateIssuedByIRS)) != '01/01/1')
                            $('#dtFirstTimeFillerSpouseTodaysDate').val($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FederalFiling.IRS.IRSTransmission.SpouseDateIssuedByIRS)))



                    }

                    if (data.m_Item3 != null) {
                        //18Aug2014 Sathish implemented pre page logic as per the spec #1.5
                        isEfile = (data.m_Item3.FederalFiling != null) ? data.m_Item3.FederalFiling.IsEfile : false;
                        //Pre-Page logic Entry #10
                        if (data.m_Item3.FederalFiling != null && !data.m_Item3.FederalFiling.IsEfile) {
                            $('#divPrintTaxReturn').show();
                            $('#divFirstTimeFiledElectronically').hide();
                            $('#divFiledTaxElectronically').hide();
                            $('#divRecivedPINFromIRS').hide();
                            $('#btnFederalReturn').html('Continue');
                            $('#btnStateFilingInfo').hide();
                        } else {
                            $('#divPrintTaxReturn').hide();

                            $('#divEfileInformation').show();
                            if (data.m_Item3.HaveFiledPriorYearReturnElectronically) {
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
        HasReceivedIPINFromIRS: (($('#radIdentityProtectionPINFromIRSYes').prop('checked') && isElectronicallyFile ? true : (($('#radIdentityProtectionPINFromIRSNo').prop('checked') && isElectronicallyFile ? false : null)))),
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
        url: serviceUrl + 'efile/persistirstransmission',
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
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                $('#divradError').empty();
                $('#divFilingTDErrorMsg').empty();
                $('#divIdentityProtectionPINFromIRSError').empty();
                $('#divSpouseFillerErrorMssg').empty();
                $('#divFillerTDErrorMssg').empty();
                $('#divEfileOptionError').empty();
                if (data.m_Item1 != 0 && data.m_Item2.length > 0) {

                    $('#divEfileOptionError').show();
                    $.each(data.m_Item2, function (index, value) {
                        $('#divEfileOptionError').append(value.ErrorText + '<br />');
                    });
                    //11Aug2014 Sathish saved userdata id in session instead of user Id
                    window.sessionStorage.setItem("UserDataId", data.m_Item1);
                    userDataId = data.m_Item1;

                }
                else if (data.m_Item1 != 0 && data.m_Item3 != 0) {
                    window.sessionStorage.setItem("UserDataId", data.m_Item1);
                    window.location.href = '../EFile/efilediagnostics.html';
                    return false;
                }
                else if (data.m_Item1 != 0 && data.m_Item2.length <= 0) {
                    $('#divEfileOptionError').hide();
                    //11Aug2014 Sathish saved userdata id in session instead of user Id
                    window.sessionStorage.setItem("UserDataId", data.m_Item1);
                    userDataId = data.m_Item1;
                    //05Aug2014 Sathish as discussed with BA if paper file selected need to be redirected to final page, BA will decide this after state completion 
                    //18Aug2014 Sathish redirected to efile acknowledgement
                    window.location.href = '../EFile/efileacknowledge.html';
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

