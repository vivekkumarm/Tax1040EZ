// 13May2014 Sathish Get Payment Details
// 13August2014 Ashok Kumar Modified script for Navigation and Error messages display
var addressType;
var shopingCartId;
var orderAmount;
var stateIds;

$(document).ready(function () {

    //Added by Thileep for Cards Validation on 03July2014
    if (jQuery.validator != null) {
        jQuery.validator.addMethod("method",
         function (value, element) {

             if ($('#ddlCardType').val() == 1) {
                 return this.optional(element) ||
                 /^(^4\d{12}$)|(^4[0-8]\d{14}$)|(^(49)[^013]\d{13}$)|(^(49030)[0-1]\d{10}$)|(^(49033)[0-4]\d{10}$)|(^(49110)[^12]\d{10}$)|(^(49117)[0-3]\d{10}$)|(^(49118)[^0-2]\d{10}$)|(^(493)[^6]\d{12}$)/.test(value);
             }
             if ($('#ddlCardType').val() == 2) {
                 return this.optional(element) || /^5[1-5]\d{2}-?\d{4}-?\d{4}-?\d{4}$/.test(value);
             }
             if ($('#ddlCardType').val() == 3) {
                 return this.optional(element) || /^3[4,7]\d{13}$/.test(value);
             }
             if ($('#ddlCardType').val() == 4) {
                 return this.optional(element) || /^6011-?\d{4}-?\d{4}-?\d{4}$/.test(value);
             }
         }, "Invalid Card Number"
         );
    }

    //Some Validations removed by Thileep 02July 2014
    $('#checkout').validate({
        rules: {
            txtFirstName: {
                required: true
            },
            txtLastName: {
                required: true
            },
            txtStreetAddress: {
                required: true
            },
            txtCity: {
                required: true
            },
            txtZipCode: {
                validateZipCode: true

            },
            txtPhoneNumber: {
                required: true,
                minlength: 12
            },
            txtEmail: {
                required: true,
                email: true
            },
            ddlCardType: {
                required: true
            },
            txtCardNumber: {
                required: true,
                method: true
            },
            txtCVC: {
                required: true,
                minlength: 3,
                maxlength: 4
            },
            ddlMonth: {
                required: true
            },
            ddlYear: {
                required: true
            },
            ddlState: {
                required: function () {
                    if (!$('#chkForeignAddress').prop('checked')) {
                        true;
                    } else {
                        false;
                    }
                }
            },
            txtStateProvince: {
                required: function () {

                    $('#divStateProvinceValidaiton').html('');
                    if ($('#chkForeignAddress').prop('checked'))
                        $('#chkForeignAddress').prop('checked');
                    else
                        false;
                }
            },
            ddlCountryCode: {
                required: function () {
                    $('#divCountryCodeValidation').html('');
                    if ($('#chkForeignAddress').prop('checked'))
                        $('#chkForeignAddress').prop('checked');
                    else
                        false;
                }
            }
        },
        messages: {
            txtFirstName: {
                required: 'Missing First Name'
            }
            ,
            txtLastName: {
                required: 'Missing Last Name'

            },
            txtStreetAddress: {
                required: 'Missing Street Address'

            },
            txtCity: {
                required: 'Missing City Name'
            },
            txtZipCode: {
                validateZipCode: 'Invalid Zip Code'

            },
            txtPhoneNumber: {
                required: 'Missing Phone Number',
                minlength: 'Invalid Phone Number'

            },
            txtEmail: {
                required: "Missing Email Address",
                email: "You have entered invalid Email Address. Please enter a valid Email Address."
            },
            ddlCardType: {
                required: 'Missing Card Type'
            },
            txtCardNumber: {
                required: 'Missing Card Number',
                method: 'Invalid Card Number'

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
                required: function () {
                    if ($('#chkForeignAddress').prop('checked')) {
                        $('#divStateProvinceValidaiton').html('Missing State Province');
                    }
                    else
                        $('#divStateProvinceValidaiton').html('');
                }
            },
            ddlCountryCode: {
                required: function () {
                    if ($('#chkForeignAddress').prop('checked')) {
                        $('#divCountryCodeValidation').html('Missing Foreign Country Name');
                    }
                    else
                        $('#divCountryCodeValidation').html('');
                }
            }
        }
    });

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
                    if (data.Taxablestate.State != null)
                        stateIds = stateIds + ',' + data.Taxablestate[i].State.StateId;
                }
            }
        }
    });

    if (sessionStorage.getItem("ShopingCartId") != null)
        shopingCartId = sessionStorage.getItem("ShopingCartId");

    //$("#txtZipCode").bind("keyup paste", function () {
    //    setTimeout(jQuery.proxy(function () {
    //        this.val(this.val().replace(/[^0-9]/g, ''));
    //    }, $(this)), 0);
    //});

      $.ajax({
        url: serviceUrl + 'personalinfo/getcountry',
        async: false,
        dataType: 'json',
        type: 'GET',
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
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
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
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
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
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
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
        data: JSON.stringify({
            ShoppingCartId: shopingCartId,
            UserId: userId,
            userDataId: userDataId
        }),
        contentType: 'application/json; charset=utf-8',
        error: function (jqXHR, textStatus, errorThrown) {
            ErrorHandling(jqXHR, errorThrown);
        },
        success: function (data, textStatus) {
            orderAmount = data;
            $('#labelTotalTaxcost').html('$' + data);
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
        beforeSend: function (request) {
            request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
        },
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
                                    if (data.m_Item2.Address.ForeignAddress.Country != null) // 09Jul2014 Sathsih  checked null reference
                                        $('#ddlCountryCode').val(data.m_Item2.Address.ForeignAddress.Country.CountryId);
                                }
                            }
                            else {
                                $('#chkForeignAddress').prop('checked', false);
                                if (data.m_Item2.Address.PersonalAddress != null) {
                                    $('#txtStreetAddress').val(data.m_Item2.Address.PersonalAddress.StreetAddress);
                                    $('#txtApartmentNumber').val(data.m_Item2.Address.PersonalAddress.ApartmentNumber);
                                    $('#txtCity').val(data.m_Item2.Address.PersonalAddress.City);
                                    if (data.m_Item2.Address.PersonalAddress.State != null) // 09Jul2014 Sathsih  checked null reference
                                        $('#ddlState').val(data.m_Item2.Address.PersonalAddress.State.StateId);
                                    $('#txtZipCode').val(data.m_Item2.Address.PersonalAddress.ZipCode);
                                    $('#txtPhoneNumber').val(data.m_Item2.Address.PersonalAddress.PhoneNumber);
                                }
                            }
                         //   $('#chkForeignAddress').trigger('change');

                            ValidateZipCode();
                        }
                    }

                }
                if (data.m_Item3 != null) {
                    $('#txtEmail').val(data.m_Item3);
                }
            }
        }
    });


    //Validations Added by Thileep 0n 02July2014
    NumbersOnly('txtPhoneNumber');
    LettersAndSpaceOnly('txtFirstName');
    LettersAndSpaceOnly('txtLastName');
    LettersAndSpaceOnly('txtStateProvince');
    NumbersLettersAndHyphen('txtStreetAddress');
    NumbersLetters('txtApartmentNumber');
    LettersAndSpaceOnly('txtCity');
    NumbersOnly('txtZipCode');
    NumbersOnly('txtCardNumber');//Added by Thileep for Card on 03July2014
    NumbersOnly('txtCVC');//Added by Thileep for CVC on 03July2014




    $(function () {
        //Yogalakshmi - 5th August 2014 -  Changes done for Quick Help flickering Problem  and updated Quickhelp with File SPEC 1.5
        $("#popEmployerID").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is EIN (Employer Identification Number) and where to find it?</h5>EIN is a 9 digit number assigned to your Employer. <br /><br/>This can be seen in Line B of your Form W-2 as Employer Identification Number.<br /> <a href='target='_blank' class='more'>Read Common Question</a>" });
        $("#popFirstName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is the 'First Name'?</h5>Enter the personal name or given name of the billing person.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popLastName").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is the 'Last Name'?</h5>Enter the Family name of the billing person.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popStreetAddress").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'Street Address'?</h5>This is nothing but the Street Name that appears in your billing address you have registered with your credit card provider.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popApartmentNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'Apartment Number'?</h5>This is nothing but the Building Number or Appartment Number that appears in your billing address you have registered with your credit card provider.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popCity").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'City'?</h5>This is nothing but the City or Town that appears in your billing address you have registered with your credit card provider.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popState").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need ‘Province Name’?</h5>The Foreign State or Province is an essential part of your billing address. We need it to ensure that we make the billing available to the right recipient. <br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popForeignState").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'State'?</h5>This is nothing but the State that appears in your billing address you have registered with your credit card provider.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popZipCode").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'Zip Code'?</h5>This is nothing but the Zip Code that appears in your billing address you have registered with your credit card provider.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popPhoneNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'Phone number' (Billing)?</h5>This is nothing but the Phone Number that you have registered with your credit card provider.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        $("#popEmail").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why is your E-mail Address required?</h5>Your E-mail Address is required for reliable mail correspondence. Make sure to give a valid E-mail Address that you check oten so that you don’t miss anything regarding your refunds or payments.<br /> <a href='' target='_blank' class='more'>Read Common Question</a>" });

        //Credit Card Information
        $("#popCountryName").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we need the ‘Foreign Country Name'?</h5>The Foreign Country name is  an essential part of your Foreign billing address. We need it to ensure that we make the billing available to the right recipient.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCardType").popover({ title: 'Quick Help', html: 'true', content: "<h5>Why do we ask for 'Card Type'?</h5>This is to know the Card Type that you will be using for the payment. It will also be helpful to verify the type of the card and to quicken the process from our end.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCardNumber").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Card Number'?</h5>This is a unique 16 digit number that appears across the middle of your card. This can be found printed on the front side of the card. <br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popCVC").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'CVC/ CVV'?</h5>This is nothing but the Card Verification Value of the card that you are using for the payment. You can find it printed at the back side of the card.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
        $("#popExpirationDate").popover({ title: 'Quick Help', html: 'true', content: "<h5>What is 'Expiration Date'?</h5>This is nothing but the 'Expiry Date’ that is mentioned at the front side of your card you are using for the payment.<br/><a href='' target='_blank' class='more'>Read Common Question</a>" });
    });

    $('#chkForeignAddress').change(function () {

        // 13Aug2014 Sathish added postal validation if foreign address is selected
         $("#txtZipCode").rules("remove");

         ValidateZipCode();

        $('#checkout').valid();
    });

});




function orderPersist() {
    $("#divCheckOutError").empty();
    if ($('#checkout').valid()) {
        var state;
        var stateOrProvince;
        var country;

        if (!$('#chkForeignAddress').prop('checked')) {
            state = {
                StateId: $('#ddlState').val(),
                StateName: $('#ddlState option:selected').text()//Changed by Thileep on 02July2014               
            };
        }

        if ($('#chkForeignAddress').prop('checked')) {
            country = {
                CountryId: $('#ddlCountryCode').val(),
                CountryName: $('#ddlCountryCode option:selected').text()//Changed by Thileep on 02July2014
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
                    ZipCode: ($('#txtZipCode').val()),
                    PhoneNumber: $('#txtPhoneNumber').val(),
                    IsForeignAddress: $('#chkForeignAddress').prop('checked'),
                    Country: country,
                    StateOrProvince: ($('#chkForeignAddress').prop('checked') ? $('#txtStateProvince').val() : null)
                },
                CreditCard: {
                    CreditCardNo: $('#txtCardNumber').val(),
                    CreditCardType: {
                        CardType: $('#ddlCardType').val(),
                        CreditCardTypeName: $('#ddlCardType option:selected').text()//02July2014 Thileep get selected state id
                    },
                    CreditCardHolderName: $('#txtCity').val(),
                    SecurityCodeNo: $('#txtCVC').val(),
                    ExpiryMonth: $('#ddlMonth').val(),
                    ExpiryYear: $('#ddlYear').val()
                }
            }
        };


        $.ajax({
            url: serviceUrl + 'payment/orderpersist',
            async: false,
            dataType: 'json',
            type: 'POST',
            beforeSend: function (request) {
                request.setRequestHeader("X-Token", window.sessionStorage.getItem("EncryptedTocken"));
            },
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
                    window.sessionStorage.setItem("OrderId", data.m_Item1);
                }
                if (data.m_Item2 != null && data.m_Item2.length > 0) {

                    $.each(data.m_Item2, function (index, value) {
                        $("#divCheckOutError").show();
                        $("#divCheckOutError").append(value.ErrorText + '<br />');
                    });
                }

                else if (data.m_Item3 != null && data.m_Item3.length > 0) {                    
                    
                    $("#divCheckOutError").show();
                    $("#divCheckOutError").append(data.m_Item3 + '<br />');
                    
                }

                else {
                    //setTimeout(function () {
                    window.location.href = '../Payment/invoice.html';
                    //});
                }
            }
        });
    }
    else {
        $("#divCheckOutError").hide(); // 31Aug2014 Sathish hide the error message on client side validaion #TAX1040-14266
    }
    return false;
}


function ValidateZipCode() {

    // 13Aug2014 Sathish added postal validation if foreign address is selected
    $("#txtZipCode").rules("remove");

    if ($('#chkForeignAddress').prop('checked')) {
        $('#divCountryCode').show();
        $('#divForeignAddress').show();
        $('#divUSAddress').hide();
        // 13Aug2014 Sathish added postal validation if foreign address is selected
        $("#txtZipCode").rules("add", {
            minlength: 3,
            maxlength: 10,
            messages: {
                minlength: "Invalid Zip Code",
                maxlength: "Invalid Zip Code",
            }
        });

    }
    else {
        $('#divForeignAddress').hide();
        $('#divCountryCode').hide();
        $('#divUSAddress').show();

        $('#divStateProvinceValidaiton').html('');
        $('#divCountryCodeValidation').html('');
        // 13Aug2014 Sathish added postal validation if foreign address is selected
        $("#txtZipCode").rules("add", {
            validateZipCode: true,
            messages: {
                validateZipCode: "Invalid Zip Code"
            }
        });

    }
}