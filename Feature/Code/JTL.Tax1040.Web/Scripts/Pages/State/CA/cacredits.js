

/**************************** PAGE LEVEL VARIABLE DECLARATION SECTION. ****************************/
var taxpaidtoanotherstate = 0;
var stateRecordCount = 0;


/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {

    $('.divnonRefundableRenterCredit').hide();
    $('.divotherStateTaxCredits').hide();
    $('.divotherStateTaxCredits1').hide();
    $('#divotherCaliforniaCredits').hide();
    $('#divPoliticalContributionCredit').hide();
    $('#divqualifyforthecredit').hide();
    $('#divhomeownerpropertytax').hide();
    $('#divsingle').hide();
    $('#taxespaidtoanotherState').hide();
    //$('#divqualifiedtoClaim').hide();
    $('#btncollapseOneNext').hide();
    if ($('#chknonRefundableRentersCredit').prop('checked') || $('#chkotherStateTaxCredits').prop('checked') || $('#chkotherCaliforniaCredits').prop('checked') || $('#chkPoliticalContributionCredit').prop('checked')) {
        $('#btncollapseOneNext').show();
    }
    $('#btncollapseOneNext').click(function () {

    });
    //#o1 onpage logic
    $('#chknonRefundableRentersCredit').change(function () {
        if ($('#chknonRefundableRentersCredit').prop('checked')) {
            $('.divnonRefundableRenterCredit').show();
            $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
           
        } else {
            $('.divnonRefundableRenterCredit').hide();
        }
    });
    //#o2 onpage logic
    $('#chkotherStateTaxCredits').change(function () {
        if ($('#chkotherStateTaxCredits').prop('checked')) {
            $('.divotherStateTaxCredits').show();
        } else {
            $('.divotherStateTaxCredits').hide();
        }
    });
    //#o3 onpage logic
    $('#chkotherCaliforniaCredits').change(function () {
        if ($('#chkotherCaliforniaCredits').prop('checked')) {
            $('#divotherCaliforniaCredits').show();
        } else {
            $('#divotherCaliforniaCredits').hide();
        }
    });
    //#o4 onpage logic
    $('#chkPoliticalContributionCredit').change(function () {
        if ($('#chkPoliticalContributionCredit').prop('checked')) {
            $('#divPoliticalContributionCredit').show();
        } else {
            $('#divPoliticalContributionCredit').hide();
        }
    });
    //#o5 onpage logic
    $('#aTaxespaidtoanotherState').click(function () {
        //alert("Add state need to discuss with BA");
        $('#f-savetax').show();
    });
    //#o6 onpage logic
    $('#reviewTaxespaidtoanotherState').click(function () {
        //alert("Add state need to discuss with BA");
        $('.divotherStateTaxCredits1').show();
    });
    //#o7 onpage logic
    $('deleteTaxespaidtoanotherState').click(function () {

        if (confirm("Are you sure, that you want to delete the selected Form W-2?")) {
        }
    });
    //#p7 pre page 
    var taxespaidtoanotherstate = $("#ddlTaxespaidtoanotherstate option:selected").val();
    if (taxespaidtoanotherstate != 0) {
        if ($('#txtDescriptionofIncome1').val() != null && $('#txtIncometaxablebyCalifornia1').val() != null) {
            $('#taxespaidtoanotherState').show();
        }
    }
    $('#divO1').hide();
    $('#btnaddNewState').click(function () {
        $('#divO1').show();
        return false;
    });
    $('#btncancel').click(function () {
        $('#divO1').hide();
        return false;
    });
    $('#btnAddstate').click(function () {
        var isavailable = true;
        var isresidenttypeavailable = false;
        var isstateavailable = false;
        var ispartyearresidentavailable = false;

        $('*[id*=hdnStateId]').each(function () {

            var controlname = $(this).attr("id");
            var getid = controlname.split("hdnStateId");     

            if ($(this).val() == $("#ddlTaxespaidtoanotherstate").val()) {
                $("#divErrorMessage").show();
                $('#divErrorMessage').html('You have already selected the ' + $("#ddlTaxespaidtoanotherstate option:selected").text() + ' state');
                isstateavailable = true;
                isavailable = false;
                return false;
            }
            else if ($('#lblNameOfState').html() != undefined && $("#ddlTaxespaidtoanotherstate option:selected").text() == $('#lblNameOfState').html()) {
                isstateavailable = true;
                isavailable = false;
            }         
          
        });

        if ($("#ddlTaxespaidtoanotherstate").val() != '') {
            if (isavailable) {
                stateRecordCount += 1;
                if (stateRecordCount == 1 || stateRecordCount == 2 || stateRecordCount == 3 || stateRecordCount == 4 || stateRecordCount == 5) {
                
                var newresidenadress = ' <div class="pangird itm" id="divstateInformation' + stateRecordCount + '">' +
                      ' <input type="hidden" id="hdnStateId' + stateRecordCount + '" value="' + $("#ddlTaxespaidtoanotherstate").val() + '" />' +
                       ' <label class="col-md-4">' +
                      '  <label id="lblStateName' + stateRecordCount + '">' + $("#ddlTaxespaidtoanotherstate option:selected").text() + '</label>' +
                       '   </label>' +                   
                        '<label class="col-md-4">' +
                     '<a href="#" title="Review" id="lnkReviewState' + stateRecordCount + '" onclick="ReviewStates(this.id);return false;">Review</a> ' +
                     '<a href="#" title="Delete" id="lnkDeleteState' + stateRecordCount + '" onclick="DeleteStates(this.id);return false;">Delete</a> ' +
                     '   </label>' +
                      ' </div>';               

                $('#divdynamicList').append(newresidenadress);

                if ($('#lblNameOfState').html() == undefined && $('#spnnoInformation') != undefined) {
                    $('#spnnoInformation').remove();
                }

                // Clear Stata and resident type dropdowm
                $("#ddlTaxespaidtoanotherstate").val('');
                

                if (ispartyearresidentavailable && isresidenttypeavailable) {
                    $('#divdynamicList').html($('#divdynamicList').html().replace(">" + residentValue + "<", ">" + partYearResident + "<"));
                }
                }
               
            }
            return false;
        }
    });
    $.ajax({
        url: serviceUrl + 'personalinfo/getstate',
        async: false,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {

            $.each(data, function (key, value) {
                $("#ddlTaxespaidtoanotherstate").append($("<option></option>").val(value.StateId).html(value.StateName));
                
            });
        }
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
            if (data != null) {
                if (data.FilingStatus > 0) {
                    //#p1 pre page 
                    if (data.FilingStatus == 1 || data.FilingStatus == 2) {
                        if (data.other != null) {//have to change declared a dummy variable
                            if (data.other < 36955 || data.other < 73910) {
                                $('#divqualifyforthecredit').show();
                            }
                        }
                    }
                    //#p2 pre page
                    if (data.FilingStatus == 2) {
                        if (data.other != null) {//have to change declared a dummy variable
                            if (data.other < 73910) {
                                $('#divhomeownerpropertytax').show();
                            }
                        }
                    }
                    //#p3 pre page
                    if (data.FilingStatus == 1 || data.FilingStatus == 2) {
                        if (data.other != null) {//have to change declared a dummy variable
                            if (data.other > 36955 || data.other > 73910) {
                                $('#divqualifyforthecredit').show();
                            }
                        }
                    }
                    //#p4 pre page
                    if (data.FilingStatus == 1) {
                        if (data.other != null) {//have to change declared a dummy variable
                            if (data.other < 36955) {
                                $('#divsingle').show();
                            }
                        }
                    }
                    //#p5 pre page
                    if (data.FilingStatus == 2) {
                        if (data.other != null) {//have to change declared a dummy variable
                            if (data.other < 73910) {
                                $('#divMFJ').show();
                            }
                        }
                    }
                }
            }


        }
    });
});


/*************************************** COMMON FUNCTIONS SECTION *********************************/

function ReviewStates(controlid) {
    $('.divotherStateTaxCredits1').show();
    var isResidentAvailable = false;
    var residentCount = 0;
    var lstDynamicResident = [];
    //$('*[id*=lblStateName]').each(function () {
    //    var controlname = $(this).attr("id");
    //    var getid = controlname.split("lblStateName");
       
    //    var stateidcontrol = 'hdnStateId' + getid[1];

    //    if ($('[id^=' + residentcontrol + ']:first').text() == residentValue) {
    //        residentCount = 1;
    //        $('#lblStateCancelFiling').html($(this).text());
    //        $('#lblStateCancelFilingName').html($(this).text());
    //        if ($('#lblresident_type').html() == residentValue) {
    //            isResidentAvailable = true;
    //            residentCount = 1;
    //            if ($('#lblNameOfState').html() != undefined) {
    //                $('#lblStateCancelFiling').html($('#lblNameOfState').html());
    //                $('#lblStateCancelFilingName').html($('#lblNameOfState').html());
    //            }
    //        }
    //        else {
    //            isResidentAvailable = false;
    //        }
    //    }
    //    lstDynamicResident.push({
    //        State: {
    //            StateId: $('[id^=' + stateidcontrol + ']:first').val(),
    //            StateName: $(this).text()
    //        }
           
    //    });
    //});
}

function DeleteStates(controlid) {
    
    if (confirm("Are you sure, you want to delete the selected State ?")) {
        var getid = controlid.split("lnkDeleteState");
        var residentcontrol = 'divstateInformation' + getid[1];
        $('[id^=' + residentcontrol + ']:first').remove();
        if ($('[id^=divstateInformation]').length == 0) {
  //          $("#divAddingEmptyRecord").append('<span id="spnnoInformation"  class="alert-danger col-md-12 text-center">' + EMPTY_RECORD +
  //'</span>');
        }
        
    }
}