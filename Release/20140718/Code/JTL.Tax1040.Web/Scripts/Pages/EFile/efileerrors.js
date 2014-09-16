var hasIncomeEligibilityDiagnostics = false;
$(document).ready(function () {
    $.ajax({
        url: serviceUrl + 'efile/geterrormessage',
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
            $("#divError").empty();
            $.each(data, function (index, value) {
                if (value != null) {
                  
                    if ((value.Topic == Topic.Address) && (value.MessageType == MessageType.ER)) {
                        hasIncomeEligibilityDiagnostics = true;
                    }
                    else {
                        //Error Message navigation url
                        // errorKnt += 1;
                        var navigateURL = value.MessageTarget + "?" + value.FieldName + "&" + value.FormId;

                        var errorType = value.ErrorType.trim();
                        var className = '';

                        switch (errorType) {
                            case ErrorType.Error:
                                className = "dierror";
                                break;

                            case ErrorType.Warning:
                                className = "diwarn";
                                break;

                            case ErrorType.Information:
                                className = "diinfo";
                                break;
                        }

                        //Assign class dynamically based on ErrorType.
                        $("#divError").append('<a  class=' + className + ' href="' + navigateURL + '">' + value.ErrorText + '.</a>');
                    }
                }
            });
        }
    });
});