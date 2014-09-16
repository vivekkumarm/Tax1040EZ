//Yogalakshmi - 16th June 2014 - Set Id for label.	
document.write("<div id='riht'><div class='refund'><p>Tax Meter</p><h3>$<span id='spnFederalRefund'></span></h3><span id='lblrefundorOweAmount'></span></div>" +
    "<div class='tabbable '><ul class='nav nav-tabs'><li class='active'><a data-toggle='tab'' href='#tab1'>Help</a></li><li class=''><a data-toggle='tab' href='#tab2'>Faq</a></li></ul>" +
    "<div class='tab-content'><div id='tab1' class='tab-pane active'><a href='#' data-toggle='modal' data-target='#h-userid'><i></i>What is User ID? </a><a href='#' data-toggle='modal' data-target='#h-userid'><i></i>Secured Password?</a><button type='button' onclick=''>Get More Help</button>" +
    "</div><div id='tab2' class='tab-pane'><a href='#' data-toggle='modal' data-target='#f-register'>Can I file my return without registering with the site?</a>" +
    "<a href='#' data-toggle='modal' data-target='#f-savetax'>How long does it take to file my return?</a><a href='#' data-toggle='modal' data-target='#f-savetax'>Can I save my tax return and come back after a while to file my return?</a>" +
    "<button type='button' onclick=''>Know more</button></div></div></div><div class='rsearch'><h4>Need assistance?</h4>Search Answers:" +
    "<div class='input-group input-group-sm'><input type='text' class='form-control'><span class='input-group-btn'><button class='btn btn-success ' type='button'>Go!</button></span></div></div></div>");


document.write("<div class='modal fade ' id='h-userid' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'> <div class='modal-dialog modal-xs'> <div class='modal-content'> <div class='modal-header'> <button type='button' class='close' data-dismiss='modal' aria-hidden='true'>&times;</button> <h4 class='modal-title' id='myModalLabel'>User ID</h4> </div> <div class='modal-body'> Enter a user ID with at least <strong>6 characters</strong>. It can accept numbers, alphabets, underscores and one dot. </div> <div class='modal-footer'> <button type='button' class='btn btn-warning' data-dismiss='modal'>Close</button></div> </div> </div> </div>" +
    "<div class='modal fade ' id='f-register' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>" +
    "<div class='modal-dialog modal-sm'><div class='modal-content'><div class='modal-header'><button type='button' class='close' data-dismiss='modal' aria-hidden='true'>&times;</button><h4 class='modal-title' id='H1'>FAQ's</h4></div><div class='modal-body'><h3>Can I file my return without registering with the site?</h3>For filing your return you need to register with us.</div><div class='modal-footer'><button type='button' class='btn btn-primary' data-dismiss='modal'>Close</button><button type='button' class='btn btn-success'>Save changes</button></div></div></div></div>" +
    "<div class='modal fade ' id='f-savetax' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>" +
    "<div class='modal-dialog'><div class='modal-content'><div class='modal-header'><button type='button' class='close' data-dismiss='modal' aria-hidden='true'>&times;</button><h4 class='modal-title' id='H2'>Help or Faq Heading</h4>" +
    "</div><div class='modal-body'><h3>What is meant by E-File?</h3>E-Filing is transmitting Business Tax Returns to the IRS through the internet. Electronic filing is the safest, most secure and private way to send your tax return to the IRS. Once you <a href='#'> E-file your return</a> you receive an electronic acknowledgement that the IRS has accepted your return for processing.<br/><br/>Once the IRS accepts your return, your schedule 1 will be stamped and sent to you.It will have the list of vehicles for which you have filed the return. The stamped copy of Schedule 1 can be used as a proof of payment when registering vehicle(s) with the IRS.If there is any error in the data provided by you then your return may be rejected in which case you will not receive your Schedule 1. </div><div class='modal-footer'><button type='button' class='btn btn-danger' data-dismiss='modal'>Close</button><button type='button' class='btn btn-primary'>Save changes</button></div></div></div></div>");

$(document).ready(function () {
    //RefundAmountCalculation();
});

//Saravanan N - 8th Aug, 2014 - As discussed with Praveen, since rightmenu.js reference removed from Income related HTML pages, moved this method to config.js.
//function RefundAmountCalculation() {

//    $.ajax({
//        url: serviceUrl + 'taxreturn/getfederalsummarydetails',
//        async: true,
//        dataType: 'json',
//        data: JSON.stringify({
//            UserId: userId,
//            UserDataId: userDataId
//        })
//        ,
//        beforeSend: function (request) {
//            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
//        },
//        type: 'POST',
//        contentType: 'application/json; charset=utf-8',
//        error: function (jqXHR, textStatus, errorThrown) {
//            ErrorHandling(jqXHR, errorThrown);
//        },
//        success: function (data, textStatus) {
//            if (data != null) {
//                var totalRefundAmount = currencyformate(Math.round(Math.abs(data)));
//                if (data == 0) {
//                    $('#lblrefundorOweAmount').html("");
//                }
//                else if (data < 0) {
//                    $('#lblrefundorOweAmount').html("Refund");
//                    $('#spnFederalRefund').addClass("text-success");
//                }
//                else {
//                    $('#lblrefundorOweAmount').html("Tax Due");
//                    $('#spnFederalRefund').addClass("text-danger");
//                }
//                $('#spnFederalRefund').html(totalRefundAmount);


//            }
//        }
//    });
//}