/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/

/**************************************** PAGE LOAD ACTION ****************************************/

$(document).ready(function () {

    $('#divLivedInCA').hide();
    $('#divTaxpayerLastName').hide();
    $('#divSpouseLastName').hide();
    $('#divMilitaryServiceArea').hide();
    

    $('#radPriorYearYes').click(function () {
        //On-page Logic:#1
        $('#divLivedInCA').show();
        $('#divTaxpayerLastName').hide();
        $('#divSpouseLastName').hide();

    });

    $('#radPriorYearNo').click(function () {
        //On-page Logic:#1
        $('#divLivedInCA').hide();
        $('#divTaxpayerLastName').hide();
        $('#divSpouseLastName').hide();

    });

    $('#radFiledYes').click(function () {
        //On-page Logic:#2
        $('#divLivedInCA').show();
        $('#divTaxpayerLastName').show();
        $('#divSpouseLastName').hide();

    });

    $('#radFiledNo').click(function () {
        //On-page Logic:#2
        $('#divLivedInCA').show();
        $('#divTaxpayerLastName').hide();
        $('#divSpouseLastName').hide();

    });

    $('#radFiledSpouseYes').click(function () {
        //On-page Logic:#3
        $('#divLivedInCA').show();
        $('#divTaxpayerLastName').hide();
        $('#divSpouseLastName').show();

    });

    $('#radSpouseFiledNo').click(function () {
        //On-page Logic:#3
        $('#divLivedInCA').show();
        $('#divTaxpayerLastName').hide();
        $('#divSpouseLastName').hide();
    });

    $('#radMilitilaryYes').click(function () {
        //On-page Logic:#4
        $('#divMilitaryServiceArea').show();
    });

    $('#radMilitilaryNo').click(function () {
        //On-page Logic:#4
        $('#divMilitaryServiceArea').hide();
    });
    

    $('#divTpDateOfDeployment').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050', 
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divTpDateOfDeployment').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divDateDeploymentTDErrorMsg').html('');

        if ($('#dtTaxpayerDateDeployment').val() != "") {
            $('#divDateDeploymentTDErrorMsg').html('');
        }
        else {
            $('#divDateDeploymentTDErrorMsg').html('Missing Date of Deployment');
        }
    });

    $('#divSpouseDateDeployment').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divSpouseDateDeployment').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divSpouseDeploymentDateErrorMsg').html('');

        if ($('#dtSpouseDateDeployment').val() != "") {
            $('#divSpouseDeploymentDateErrorMsg').html('');
        }
        else {
            $('#divSpouseDeploymentDateErrorMsg').html('Missing Date of Deployment');
        }
    });


    $('#divTaxpayerDateRetured').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divTaxpayerDateRetured').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divTaxpayerDateReturedErrorMsg').html('');

        if ($('#dtDateRetured').val() != "") {
            $('#divTaxpayerDateReturedErrorMsg').html('');
        }
        else {
            $('#divTaxpayerDateReturedErrorMsg').html('Missing Date Retured');
        }
    });


    $('#divSpouseDateRetured').datepicker({
        format: "mm/dd/yyyy",
        startDate: '01/01/1753',
        endDate: '01/01/2050',
        forceParse: false,
        autoclose: true,
        onClose: function () { $(this).valid(); }
    });

    $('#divSpouseDateRetured').on('changeDate', function (ev) {
        $(this).datepicker();
        $('#divSpouseDateReturedErrorMsg').html('');

        if ($('#dtSpouseDateRetured').val() != "") {
            $('#divSpouseDateReturedErrorMsg').html('');
        }
        else {
            $('#divSpouseDateReturedErrorMsg').html('Missing Date Retured');
        }
    });

});

/*************************************** COMMON FUNCTIONS SECTION *********************************/