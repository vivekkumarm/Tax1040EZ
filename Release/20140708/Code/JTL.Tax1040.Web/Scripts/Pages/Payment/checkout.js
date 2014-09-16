﻿// 13May2014 Sathish Get Payment Details
var addressType;
var shopingCartId;
var orderAmount;
var stateIds;

$(document).ready(function () {

    $.ajax({
        url: serviceUrl + 'stategateway/getaddress',
        async: false,
        dataType: "json",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            UserId: userId,
            userDataId: userDataId
        }),
        contentType: "application/json; charset=utf-8",
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data.Taxablestate != null) {
                stateIds = data.ResidenceState.StateId;
                for (var i = 0; i < data.Taxablestate.length; i++) {
                    stateIds = stateIds + ',' + data.Taxablestate[i].StateId
                }
            }
        }
    });

    if (sessionStorage.getItem("ShopingCartId") != null)
        shopingCartId = sessionStorage.getItem("ShopingCartId");

    $("#txtZipCode").bind("keyup paste", function () {
        setTimeout(jQuery.proxy(function () {
            this.val(this.val().replace(/[^0-9]/g, ''));
        }, $(this)), 0);
    });

    $('#chkForeignAddress').change(function () {
        if ($('#chkForeignAddress').prop('checked')) {
            $('#divCountryCode').show();
            $('#divForeignAddress').show();
            $('#divUSAddress').hide();
        }
        else {
            $('#divForeignAddress').hide();
            $('#divCountryCode').hide();
            $('#divUSAddress').show();
        }
    });

    $.ajax({
        url: serviceUrl + 'personalinfo/getcountry',
        async: false,
        dataType: 'json',
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $('#ddlCountryCode').append($('<option></option>').val('').html('---Select---'));
            $.each(data, function (key, value) {
                $('#ddlCountryCode').append($('<option></option>').val(value.CountryId).html(value.CountryName));
            });
        }
    });

    $.ajax({
        url: serviceUrl + 'personalinfo/getstate',
        async: false,
        dataType: 'json',
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $('#ddlState').append($('<option></option>').val('').html('---Select---'));
            $.each(data, function (key, value) {
                $('#ddlState').append($('<option></option>').val(value.StateId).html(value.StateName));
            });
        }
    });

    $.ajax({
        url: serviceUrl + 'payment/getallcreditcardtype',
        async: false,
        dataType: 'json',
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            $('#ddlCardType').append($('<option></option>').val('').html('---Select---'));
            $.each(data, function (key, value) {
                $('#ddlCardType').append($('<option></option>').val(value.CardType).html(value.CreditCardTypeName));
            });
        }

    });
    $.ajax({
        url: serviceUrl + 'payment/getorderamount',
        async: false,
        dataType: 'json',
        type: 'POST',
        data: JSON.stringify({
            ShoppingCartId: shopingCartId
        }),
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            orderAmount = data;
            $('#labelTotalTaxcost').html(data);
        }
    });


    $.ajax({
        url: serviceUrl + 'payment/getpaymentdetails',
        async: false,
        dataType: 'json',
        data: JSON.stringify({
            UserId: userId,
            UserDataId: userDataId
        }),
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            if (data != null) {
                if (data.m_Item2 != null) {
                    $('#txtFirstName').val(data.m_Item2.FirstName);
                    $('#txtLastName').val(data.m_Item2.LastName);
                    if (data.m_Item2.Address != null) {
                        if (data.m_Item2.Address.AddressType != null) {
                            addressType = data.m_Item2.Address.AddressType;
                            if (addressType == 2) {
                                $('#chkForeignAddress').prop('checked', true);
                                if (data.m_Item2.Address.ForeignAddress != null) {
                                    $('#txtStreetAddress').val(data.m_Item2.Address.ForeignAddress.StreetAddress);
                                    $('#txtApartmentNumber').val(data.m_Item2.Address.ForeignAddress.ApartmentNumber);
                                    $('#txtCity').val(data.m_Item2.Address.ForeignAddress.City);
                                    $('#txtStateProvince').val(data.m_Item2.Address.ForeignAddress.StateOrProvince);
                                    $('#txtZipCode').val(data.m_Item2.Address.ForeignAddress.PostalCode);
                                    $('#txtPhoneNumber').val(data.m_Item2.Address.ForeignAddress.PhoneNumber);
                                    $('#ddlCountryCode').val(data.m_Item2.Address.ForeignAddress.CountryId);
                                }
                            }
                            else {
                                $('#chkForeignAddress').prop('checked', false);
                                if (data.m_Item2.Address.PersonalAddress != null) {
                                    $('#txtStreetAddress').val(data.m_Item2.Address.PersonalAddress.StreetAddress);
                                    $('#txtApartmentNumber').val(data.m_Item2.Address.PersonalAddress.ApartmentNumber);
                                    $('#txtCity').val(data.m_Item2.Address.PersonalAddress.City);
                                    $('#ddlState').val(data.m_Item2.Address.PersonalAddress.StateId);
                                    $('#txtZipCode').val(data.m_Item2.Address.PersonalAddress.ZipCode);
                                    $('#txtPhoneNumber').val(data.m_Item2.Address.PersonalAddress.PhoneNumber);
                                }
                            }
                            $('#chkForeignAddress').trigger('change');
                        }
                    }

                }
                if (data.m_Item3 != null) {
                    $('#txtEmail').val(data.m_Item3);
                }
            }
        }
    });

    $('#checkout').validate({
        rules: {
            txtFirstName: {
                required: true,
                lettersonly: true
            }
            ,
            txtLastName: {
                required: true,
                lettersonly: true
            },
            txtStreetAddress: {
                required: true,
                lettersonly: true
            },
            txtCity: {
                required: true,
                lettersonly: true
            },
            txtZipCode: {
                required: true
            },
            txtPhoneNumber: {
                required: true,
                minlength: 10,
                maxlength: 10
            },
            ddlCardType: {
                required: true
            },
            txtCardNumber: {
                required: true
            },
            txtCVC: {
                required: true,
                minlength: 3,
                maxlength: 3
            },
            ddlMonth: {
                required: true
            },
            ddlYear: {
                required: true
            },
            ddlState: {
                required: function () {
                    if ($('#chkForeignAddress').prop('checked') == false) {
                        true;
                    } else {
                        false;
                    }
                }
            },
            txtStateProvince: {
                required: function () { $('#chkForeignAddress').prop('checked'); }
            },
            ddlCountryCode: {
                required: function () { $('#chkForeignAddress').prop('checked'); }
            }
        },
        messages: {
            txtFirstName: {
                required: 'Missing First Name',
                lettersonly: 'Special Character on First Name'
            }
            ,
            txtLastName: {
                required: 'Missing Last Name',
                lettersonly: 'Special Character on Last Name'
            },
            txtStreetAddress: {
                required: 'Missing Street Address',
                lettersonly: 'Special characters on Street Address'
            },
            txtCity: {
                required: 'Missing City Name',
                lettersonly: 'Special characters on City Name'
            },
            txtZipCode: {
                required: 'Missing Zip Code'
            },
            txtPhoneNumber: {
                required: 'Missing Phone Number',
                minlength: 'Invalid Phone Number',
                maxlength: 'Invalid Phone Number'
            },
            ddlCardType: {
                required: 'Missing Card Type'
            },
            txtCardNumber: {
                required: 'Missing Card Number'
            },
            txtCVC: {
                required: 'Missing CVC Code value',
                minlength: 'Invalid Card Number',
                maxlength: 'Invalid Card Number'
            },
            ddlMonth: {
                required: 'Missing  Card Expiration Date'
            },
            ddlYear: {
                required: 'Missing  Card Expiration Date'
            },
            ddlState: {
                required: 'Missing State Code'
            },
            txtStateProvince: {
                required: 'Missing State Province'
            },
            ddlCountryCode: {
                required: 'Missing Foreign Country Name'
            }
        }
    });

    $(function () {
        $("#popFirstName").popover({ title: '', content: "<h5>First Name</h5>Enter your first name. Should hold atleast 6 characters.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popLastName").popover({ title: '', content: "<h5>Last Name</h5>Last Name is your surname or your family name.Should hold atleast 6 characters.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popStreetAddress").popover({ title: '', content: "<h5>Street Address</h5>Enter the address of your residing place.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popApartmentNumber").popover({ title: '', content: "<h5>Apartment Number</h5>Door number of your residing house.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCity").popover({ title: '', content: "<h5>City</h5>Name of the City you reside.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popState").popover({ title: '', content: "<h5>State</h5>Select your residing state from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popForeignState").popover({ title: '', content: "<h5>State</h5>Select your residing state from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popZipCode").popover({ title: '', content: "<h5>Zipcode</h5>Zipcode is a 5-digit code used for mailing purpose.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popPhoneNumber").popover({ title: '', content: "<h5>Phone Number</h5>Provide your phone number in the format as 956-222-1234.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popEmail").popover({ title: '', content: "<h5>Email Address</h5>Email Address should be in the format(test@gmail.com).Email Address is used to communicate you <br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCountryName").popover({ title: '', content: "<h5>Country Name</h5>Select the name of the country from the drop down.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //Credit Card Information
        $("#popCountryName").popover({ title: '', content: "<h5>Country Code</h5></a>" });
        $("#popCardType").popover({ title: '', content: "<h5>Card Type</h5></a>" });
        $("#popCardNumber").popover({ title: '', content: "<h5>Card Number</h5></a>" });
        $("#popCVC").popover({ title: '', content: "<h5>CVC</h5></a>" });
        $("#popExpirationDate").popover({ title: '', content: "<h5>Expiration Date</h5></a>" });
    });

});




function orderPersist() {
    $("#divCheckOutError").empty();
    if ($('#checkout').valid()) {
        var state;
        var stateOrProvince;
        var country;

        if ($('#chkForeignAddress').prop('checked') == false) {
            state = {
                StateId: $('#ddlState').val(),
                StateName: $('#ddlState').text()
            }
        }

        if ($('#chkForeignAddress').prop('checked')) {
            country = {
                CountryId: $('#ddlCountryCode').val(),
                CountryName: $('#ddlCountryCode').text()
            };
        }

        var order = {
            TotalAmount: orderAmount,
            ShoppingCartId: shopingCartId,
            BillingDetails: {
                FirstName: $('#txtFirstName').val(),
                LastName: $('#txtLastName').val(),
                Email: $('#txtEmail').val(),
                BillingAddress:
                        {
                            StreetAddress: $('#txtStreetAddress').val(),
                            ApartmentNumber: $('#txtApartmentNumber').val(),
                            City: $('#txtCity').val(),
                            State: state,
                            ZipCode: ($.isNumeric($('#txtZipCode').val()) ? $('#txtZipCode').val() : 0),
                            PhoneNumber: $('#txtPhoneNumber').val(),
                            IsForeignAddress: $('#chkForeignAddress').prop('checked'),
                            Country: country,
                            StateOrProvince: ($('#chkForeignAddress').prop('checked') ? $('#txtStateProvince').val() : null)
                        },
                CreditCard: {
                    CreditCardNo: $('#txtCardNumber').val(),
                    CreditCardType: {
                        CardType: $('#ddlCardType').val(),
                        CreditCardTypeName: $('#ddlCardType').text()
                    },
                    CreditCardHolderName: $('#txtCity').val(),
                    SecurityCodeNo: $('#txtCVC').val(),
                    ExpiryMonth: $('#ddlMonth').val(),
                    ExpiryYear: $('#ddlYear').val()
                }
            }
        }


        $.ajax({
            url: serviceUrl + 'payment/orderpersist',
            async: false,
            dataType: 'json',
            type: 'POST',
            data: JSON.stringify({
                UserId: userId,
                UserDataId: userDataId,
                Order: order,
            }),
            contentType: 'application/json; charset=utf-8',
            error: function (jqXHR, textStatus, errorThrown) {
                ErrorHandling(jqXHR, errorThrown);
            },
            success: function (data, textStatus) {
                if (data.m_Item1 != null && data.m_Item1 != 0) {
                    sessionStorage.setItem("OrderId", data.m_Item1);
                }
                if (data.m_Item2 != null) {
                    if (data.m_Item2.length > 0) {
                        $.each(data.m_Item2, function (index, value) {
                            $("#divCheckOutError").show();
                            $("#divCheckOutError").append(value.ErrorText + '<br />');
                        });
                    }
                    else {
                        setTimeout(function () {
                            window.location.href = '../Payment/invoice.html';
                        });
                    }


                }
            }
        });
    }
}