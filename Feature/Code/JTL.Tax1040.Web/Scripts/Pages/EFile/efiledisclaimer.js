$(document).ready(function () {
    $("#efileDisclaimer").validate({
        rules: {
            chkTermsofServices:
              {
                  required: function () { $('#divFileDisclaimerError').html(''); true }
              }
        },
        messages: {
            chkTermsofServices:
               {
                   required: function () { $('#divFileDisclaimerError').html('Please accept the terms of service for continuing E-filing with errors'); true; }
               }
        }
    });

    //4-july-14 vivek for the persist after continue
    $('#btnFileDisclaimerContinue').click(function () {
        if ($('#efileDisclaimer').valid()) {
            window.location.href = '../EFile/efileacknowledge.html';
            return false;
        }
        else {
            $('#divFileDisclaimerError').show();
        }
    });
});