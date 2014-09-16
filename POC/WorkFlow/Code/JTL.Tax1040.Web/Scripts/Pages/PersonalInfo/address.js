﻿//Scripts for address   

var filingStatus;
$(document).ready(function () {
    $('#divlivedinstate').hide();
    $('#divEarnedIncomeState').hide();
    pageURL = window.location.search.substring(1);
    parameterName = pageURL.split('-');
    if (parameterName.length == 2) {
        var divToExpand = parameterName[0];
        var controlToFocus = parameterName[1];
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#divShowForeignAddress').show();
        $('#' + divToExpand).addClass('panel-collapse collapse in');
        $('#' + controlToFocus).focus();
    }
    $('#btnAddessContinue').click(function () {
        PersistAddress();
        window.location.href = '../PersonalInfo/personalsummary.html';
        return false;
    });

    $('#btnAddressBack').click(function () {
        PersistAddress();
        filingStatus;
        if (filingStatus == 2) {
            window.location.href = '../PersonalInfo/spouseinfo.html';
        }
        else {
            window.location.href = '../PersonalInfo/primaryfilerinfo.html';
        }
        return false;
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
            $("#ddlStateOfResidence").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlMoreThanOneState").append($("<option></option>").val(0).html("---Select---"));
            $("#ddlEarnedIncomeStateNotLived").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlStateOfResidence").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlMoreThanOneState").append($("<option></option>").val(value.StateId).html(value.StateName));
                $("#ddlEarnedIncomeStateNotLived").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });

    $.ajax({
        url: serviceUrl + 'personalinfo/getalllivingstates',
        async: false,
        dataType: "json",
        type: "GET",
        data: JSON.stringify({
            "IsAdditionalMailingAddress": JSON.stringify(true),
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $("#ddlState").append($("<option></option>").val(0).html("---Select---"));
            $.each(data, function (key, value) {
                $("#ddlState").append($("<option></option>").val(value.StateId).html(value.StateName));
            });
        }
    });

        $.ajax({
            url: serviceUrl + 'personalinfo/getcountry',
            async: false,
            dataType: "json",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                $("#ddlCountryName").append($("<option></option>").val(0).html("---Select---"));
                $.each(data, function (key, value) {
                    $("#ddlCountryName").append($("<option></option>").val(value.CountryId).html(value.CountryName));
                });
            }
        });

    $.ajax({
        url: serviceUrl + 'personalinfo/getaddress',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            "UserId": userId, 
            "UserDataId": userDataId,
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.FilingStatus == 2) {
                    filingStatus = data.FilingStatus;
                    $("#liSpouse").css("display", "inline");
                }
                $("#lblTaxPayerName").html(data.TaxPayerName);
                if (data.Address != null) {
                    $("#hdAddressId").val(data.Address.AddressId);
                    $("#ddlStateOfResidence").val(data.Address.ResidenceState.StateId);
                    $("#chkLivedMoreThenOneStatCode").prop("checked", data.Address.HasLivedInMoreThanOneState);

                   if (data.Address.HasLivedInMoreThanOneState == true) {
                       $('#divlivedinstate').show();
                    }
                    else {
                       $('#divlivedinstate').hide();
                    }
                    //$('#divLivedInMoreThanOneState').show();
                    $("#chkEarnedIncomeSateYouNotLived").prop("checked", data.Address.HasEarnedIncomeFromNonLivedState);
                    if (data.Address.HasEarnedIncomeFromNonLivedState == true) {
                        $('#divEarnedIncomeState').show();
                    }
                    else {
                        $('#divEarnedIncomeState').hide();
                    }
                    $("#ddlMoreThanOneState").val(data.Address.LivedInAnotherStateId);
                    if (data.Address.LivedInAnotherStateFrom != null)
                    $("#dtFromDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Address.LivedInAnotherStateFrom)));
                    else
                        $("#dtFromDate").val('');
                    if (data.Address.LivedInAnotherStateTo != null)
                    $("#dtToDate").val($.datepicker.formatDate('mm/dd/yy', new Date(data.Address.LivedInAnotherStateTo)));
                    else
                        $("#dtToDate").val('');
                    $("#ddlEarnedIncomeStateNotLived").val(data.Address.EarnedIncomeFromNonLivedStateId);
                    if (data.Address.AddressType == 1) {
                        $("#radUsAddress").prop("checked", true);
                        $('#divShowForeignAddress').hide();
                        $('#divShowUSAddress').show();
                    }
                    else {
                        $("#radForeignAddress").prop("checked", true);
                        $('#divShowUSAddress').hide();
                        $('#divShowForeignAddress').show();
                    }
                   
                    if (data.Address.PersonalAddress != null) {
                        $("#divShowuUSAddress").show();
                        $("#divShowForeignAddress").hide();
                        $("#txtStreetAddress").val(data.Address.PersonalAddress.StreetAddress);
                        $("#txtApartmentNumber").val(data.Address.PersonalAddress.ApartmentNumber);
                        $("#txtCity").val(data.Address.PersonalAddress.City);
                        $("#ddlState").val(data.Address.PersonalAddress.StateId);
                        $("#txtZipCode").val(data.Address.PersonalAddress.ZipCode);
                        $("#txtPhoneNumber").val(data.Address.PersonalAddress.PhoneNumber);
                    } else if (data.Address.ForeignAddress != null) {
                        $("#divShowuUSAddress").hide();
                        $("#divShowForeignAddress").show();
                        $("#txtStateorprovince").val(data.Address.ForeignAddress.StateOrProvince);
                        $("#ddlCountryName").val(data.Address.ForeignAddress.CountryId);
                        $("#txtForeignStreetAddress").val(data.Address.ForeignAddress.StreetAddress);
                        $("#txtApartmentNumberForeign").val(data.Address.ForeignAddress.ApartmentNumber);
                        $("#txtPostalCode").val(data.Address.ForeignAddress.PostalCode);
                        $("#txtForeignPhoneNumber").val(data.Address.ForeignAddress.PhoneNumber);
                        $("#txtCityForeign").val(data.Address.ForeignAddress.City);
                    }
                } 
            }
        }
    });


    
    $("#chkLivedMoreThenOneStatCode").change(function () {
        if ($('#chkLivedMoreThenOneStatCode').prop('checked')) {
            $('#divlivedinstate').show();
        }
        else {
            $('#divlivedinstate').hide();
            $("#ddlMoreThanOneState").val(0);
            $('#dtFromDate').val('');
            $('#dtToDate').val('');
        }

    });


    
    $("#chkEarnedIncomeSateYouNotLived").click(function () {
        $("#divEarnedIncomeState").toggle();
        $("#ddlEarnedIncomeStateNotLived").val(0);
    });
    
    $("[name='radAddress']").click(function () {
        if ($('#radUsAddress').prop('checked')) {
            $("#divShowUSAddress").show();
            $("#divShowForeignAddress").hide();
        }
        else if ($('#radForeignAddress').prop('checked'))
        {
            $("#divShowForeignAddress").show();
            $("#divShowUSAddress").hide();
        }
    });


   

    jQuery.validator.addMethod("lettersonly", function (value, element) {
        return this.optional(element) || /^[a-z]+$/i.test(value);
    }, "Letters only please");

    $.validator.addMethod('selectNone',
        function (value, element) {
            return this.optional(element)
            (value.indexOf("--Select--") == -1);
        }, "Please select an option");

    $(function () {
        
    $("#popStreetAddress").popover({ title: '', content: "<h5>Street Address</h5>Enter the address of your residing place.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popApartmentNumber").popover({ title: '', content: "<h5>Apartment Number</h5>Door number of your residing house.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCity").popover({ title: '', content: "<h5>City</h5>Name of the City you reside.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popState").popover({ title: '', content: "<h5>State</h5>Select your residing state from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popZipCode").popover({ title: '', content: "<h5>Zipcode</h5>Zipcode is a 5-digit code used for mailing purpose.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPhoneNumber").popover({ title: '', content: "<h5>Phone Number</h5>Provide your phone number in the format as 956-222-1234.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    //Changed by Yogalakshmi on 13th May 2014
        $("#popStateorprovince").popover({ title: '', content: "<h5>State or Province</h5>Select your residing state from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCountryName").popover({ title: '', content: "<h5>Country Name</h5>Select the name of the country from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPostalCode").popover({ title: '', content: "<h5>Postal Code</h5>Post code is a 5 digit code for sending mails to your address.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignPhoneNumber").popover({ title: '', content: "<h5>Foriegn Phone Number</h5>Specify the phone number of your foreign residence.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popFromDate").popover({ title: '', content: "<h5>From Date</h5>Enter the date from when you stayed in the new state.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popToDate").popover({ title: '', content: "<h5>To Date</h5>Enter the date when you moved out of the new state.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        
    //Added by Yogalakshmi on 13th May 2014
        $("#popStateOfResidence").popover({ title: '', content: "<h5>State Of Residence</h5>Select the state where you resides and the place where you permitted to Vote/Maintaining Bank Account /Driving license issued by State Government.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popMoreThanOneState").popover({ title: '', content: "<h5>State</h5>Select  the state that you moved from one residential state to another state and lived at the end of the year.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popEarnedIncomeStateNotLived").popover({ title: '', content: "<h5>State</h5>Select the State where you receive income and which it's not your residential state.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignStreetAddress").popover({ title: '', content: "<h5>Street Address</h5>Enter the address of your residing place.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignApartmentNumber").popover({ title: '', content: "<h5>Apartment Number</h5>Door number of your residing house.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignCity").popover({ title: '', content: "<h5>City</h5>Name of the City you reside.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

    $('#btnSubmitOne').click(function () {
        $('#collapseOne').removeClass('panel-collapse collapse in').addClass('panel-collapse collapse');
        $('#collapseTwo').removeClass('panel-collapse collapse').addClass('panel-collapse collapse in');
        return false;
    });


});

function PersistAddress() {
  
    if ($("#Address").valid()) {
        var addressType;
        if ($("#radUsAddress").prop("checked") == true) {
            addressType = $("#radUsAddress").val();
            
            
            $.ajax({
                url: serviceUrl + 'personalinfo/addresscreate',
                async: false,
                dataType: "json",
                type: "POST",
                beforeSend: function (request) {
                    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
                },
                data: JSON.stringify({
                    "UserId": userId,   
                    "UserDataId": userDataId,  
                    "Address": {
                        "ResidenceState": {
                            "StateId" : $("#ddlStateOfResidence").val(),
                            "StateName" :  $("#ddlStateOfResidence option:selected").text(),
                        },
                        "HasLivedInMoreThanOneState": $("#chkLivedMoreThenOneStatCode").prop("checked"),
                        "HasEarnedIncomeFromNonLivedState": $("#chkEarnedIncomeSateYouNotLived").prop("checked"),
                        "LivedInAnotherStateId": $("#ddlMoreThanOneState").val(),
                        "LivedInAnotherStateFrom": $("#dtFromDate").val(),
                        "LivedInAnotherStateTo": $("#dtToDate").val(),
                        "EarnedIncomeFromNonLivedStateId": $("#ddlEarnedIncomeStateNotLived").val(),
                        "AddressType": addressType,
                        "AddressId": $("#hdAddressId").val(),
                        "PersonalAddress":
                        {
                            "StreetAddress": $("#txtStreetAddress").val(),
                            "ApartmentNumber": $("#txtApartmentNumber").val(),
                            "City": $("#txtCity").val(),
                            "StateId": $("#ddlState").val(),
                            "ZipCode": $("#txtZipCode").val(),
                            "PhoneNumber": $("#txtPhoneNumber").val(),
                            "CountryId": 1, // TODO : Country ID hard coded since personal address country id is USA
                        },
                    },
                }),
                contentType: "application/json; charset=utf-8",
                error: function (jqXHR, textStatus, errorThrown) {
                    //alert(jqXHR + "-" + textStatus + "-" + errorThrown);
                    ErrorHandler(jqXHR, errorThrown);
                },
                success: function (data, textStatus) {

                    window.sessionStorage.setItem("UserDataId", data.UserDataId);
                    $("#hdAddressId").val(data.AddressId);
                }
            });

        } else {
            addressType = $("#radForeignAddress").val();
            $.ajax({
                url: serviceUrl + 'personalinfo/addresscreate',
                async: false,
                dataType: "json",
                type: "POST",
                beforeSend: function (request) {
                    request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
                },
                data: JSON.stringify({
                    "UserId": userId,  
                    "UserDataId": userDataId,  
                    "Address": {
                        "ResidenceState": {
                            "StateId": $("#ddlStateOfResidence").val(),
                            "StateName": $("#ddlStateOfResidence option:selected").text(),
                        },
                        "HasLivedInMoreThanOneState": $("#chkLivedMoreThenOneStatCode").prop("checked"),
                        "HasEarnedIncomeFromNonLivedState": $("#chkEarnedIncomeSateYouNotLived").prop("checked"),
                        "LivedInAnotherStateId": $("#ddlMoreThanOneState").val(),
                        "LivedInAnotherStateFrom": $("#dtFromDate").val(),
                        "LivedInAnotherStateTo": $("#dtToDate").val(),
                        "EarnedIncomeFromNonLivedStateId": $("#ddlEarnedIncomeStateNotLived").val(),
                        "AddressType": addressType,
                        "AddressId": $("#hdAddressId").val(),
                        "ForeignAddress":
                        {
                            "StreetAddress": $("#txtForeignStreetAddress").val(),
                            "ApartmentNumber": $("#txtApartmentNumberForeign").val(),
                            "City": $("#txtForeignCity").val(),
                            "StateOrProvince": $("#txtStateorprovince").val(),
                            "CountryId": $("#ddlCountryName").val(),
                            "PostalCode": $("#txtPostalCode").val(),
                            "PhoneNumber": $("#txtForeignPhoneNumber").val()
                        },
                    },
                }),
                contentType: "application/json; charset=utf-8",
                error: function (jqXHR, textStatus, errorThrown) {
                    ErrorHandling(jqXHR, errorThrown);
                },
                success: function (data, textStatus) {
                    window.sessionStorage.setItem("UserDataId", data.UserDataId);
                    $("#hdAddressId").val(data.AddressId);
                }
            });
        }

    }
}



