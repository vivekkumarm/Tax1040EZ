// 13May2014 Sathish Get Payment Details
// 13August2014 Ashok Kumar Modified script for Navigation and Error messages display
//25Aug2014 Thileep changed Error Messages and Changes  Regarding File spec(V1.6)
var addressType;
var shopingCartId;
var orderAmount;
var stateIds;

$(document).ready(function () {

    NumbersOnlyNotAcceptingDot('txtForeignPhoneNumber');

    //Added by Thileep for Cards Validation on 03July2014
    if (jQuery.validator != null) {
        jQuery.validator.addMethod("method",
         function (value, element) {
             if ($('#ddlCardType').val() == 0) {
                 return true;
             }
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
                minlength: 3,
                required: true
            },
            txtZipCode: {
                required: true,
                validateZipCode: true
            },
            txtPostalCode: {
                minlength: 3,
                maxlength: 10,
                required: true
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
            txtForeignPhoneNumber:
               {
                   required: true,
                   minlength: 1,
                   maxlength: 20,
                   //validatePhoneNumber: true
               }
        },
        messages: {
            txtFirstName: {
                required: 'First Name is missing'
            }
            ,
            txtLastName: {
                required: 'Last Name is missing'

            },
            txtStreetAddress: {
                required: 'Street Address is missing'

            },
            txtCity: {
                minlength: 'Invalid City name',
                required: 'City Name is missing'
            },
            ddlState: {
                required: 'State Code is missing'
            },
            txtZipCode: {
                required: 'Zip Code is missing',
                validateZipCode: 'Zip Code is invalid'

            },
            txtPostalCode: {
                minlength: "Postal code is Invalid",
                maxlength: "Postal code is Invalid",
                required: 'Postal Code is missing'
            },
            txtPhoneNumber: {
                required: 'Phone Number is missing',
                minlength: 'Phone Number is invalid'

            },
            txtEmail: {
                required: "Email Address is missing",
                email: "Invalid Email address"
            },
            ddlCardType: {
                required: 'Card Type is missing'
            },
            txtCardNumber: {
                required: 'Card Number is missing',
                method: 'Card Number is invalid'

            },
            txtCVC: {
                required: 'CVC Code value is missing',
                minlength: 'Invalid CVC Code',
                maxlength: 'Invalid CVC Code'
            },
            ddlMonth: {
                required: 'Card Expiration Month is missing'
            },
            ddlYear: {
                required: 'Card Expiration year is missing'
            },
            txtForeignPhoneNumber:
            {
                required: "Phone Number is missing",
                minlength: "Foreign Phone Number is invalid.",
                maxlength: "Foreign Phone Number is invalid."
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
                                    $('#txtPostalCode').val(data.m_Item2.Address.ForeignAddress.PostalCode);
                                    $('#txtForeignPhoneNumber').val(data.m_Item2.Address.ForeignAddress.PhoneNumber);
                                    if (data.m_Item2.Address.ForeignAddress.Country != null &&
                                        data.m_Item2.Address.ForeignAddress.Country.CountryId != 0) // 09Jul2014 Sathsih  checked null reference
                                        $('#ddlCountryCode').val(data.m_Item2.Address.ForeignAddress.Country.CountryId);
                                }
                            }
                            else {
                                $('#chkForeignAddress').prop('checked', false);
                                if (data.m_Item2.Address.PersonalAddress != null) {
                                    $('#txtStreetAddress').val(data.m_Item2.Address.PersonalAddress.StreetAddress);
                                    $('#txtApartmentNumber').val(data.m_Item2.Address.PersonalAddress.ApartmentNumber);
                                    $('#txtCity').val(data.m_Item2.Address.PersonalAddress.City);
                                    if (data.m_Item2.Address.PersonalAddress.State != null && data.m_Item2.Address.PersonalAddress.State.StateId != 0) // 09Jul2014 Sathsih  checked null reference
                                        $('#ddlState').val(data.m_Item2.Address.PersonalAddress.State.StateId);
                                    $('#txtZipCode').val(data.m_Item2.Address.PersonalAddress.ZipCode);
                                    $('#txtPhoneNumber').val(data.m_Item2.Address.PersonalAddress.PhoneNumber);
                                }
                            }
                            //   $('#chkForeignAddress').trigger('change');


                        }
                    }

                }
                if (data.m_Item3 != null) {
                    $('#txtEmail').val(data.m_Item3);
                }
            }
            SetAddressType();
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
    NumbersOnlyNotAcceptingDot('txtZipCode');
    NumbersLettersAndHyphen('txtPostalCode');
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
        $("#popPostalCode").popover({ title: 'Quick Help', html: 'true', content: "<h5>What needs to be filled in 'Zip Code/Postal Code'?</h5>This is nothing but the Zip Code/Postal Code that appears in your billing address you have registered with your credit card provider.<br/> <a href='' target='_blank' class='more'>Read Common Question</a>" });

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
        // $("#txtZipCode").rules("remove");

        SetAddressType();

        //22Aug2014 Sathish removed validation error while changing to foreign address
        //if ($('#chkForeignAddress').prop('checked')) {
        //    $("#txtStateProvince.error").hide();
        //    $("#ddlCountryCode.error").hide();
        //    $("#txtStateProvince.error").removeClass("error");
        //    $("#ddlCountryCode.error").removeClass("error");
        //}

        //  $(".error").removeClass("error");

        //  $('#checkout').valid();
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
                    ZipCode: ($('#chkForeignAddress').prop('checked') ? $('#txtPostalCode').val() : $('#txtZipCode').val()), 
                    PhoneNumber: ($('#chkForeignAddress').prop('checked') ? $('#txtForeignPhoneNumber').val() : $('#txtPhoneNumber').val()),
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


//01Sep2014 Sathish removed validation and set address type and changed fucntion name
function SetAddressType() {


    $("#ddlState").removeClass("error");
    $("[for=ddlState]").remove();

    $("#txtZipCode").removeClass("error");
    $("[for=txtZipCode]").remove();

    $("#txtStateProvince").removeClass("error");
    $("[for=txtStateProvince]").remove();

    $("#ddlCountryCode").removeClass("error");
    $("[for=ddlCountryCode]").remove();

    $("#txtPostalCode").removeClass("error");
    $("[for=txtPostalCode]").remove();

    $("#txtForeignPhoneNumber").removeClass("error");
    $("[for=txtForeignPhoneNumber]").remove();

    $("#txtPhoneNumber").removeClass("error");
    $("[for=txtPhoneNumber]").remove();


    if ($('#chkForeignAddress').prop('checked')) {
        $('#divUsPhoneNumber').hide();
        $('#divForeignPhoneNumber').show();
        $('#divZipCode').hide();
        $('#divPostalCode').show();

        $('#divCountryCode').show();
        $('#divForeignAddress').show();
        $('#divUSAddress').hide();

        $("#txtStateProvince").rules("add", {
            required: true,
            messages: {
                required: 'Missing State Province'
            }
        });

        $("#ddlCountryCode").rules("add", {
            required: true,
            messages: {
                required: 'Foreign Country Name is missing'
            }
        });

    }
    else {

        $('#divUsPhoneNumber').show();
        $('#divForeignPhoneNumber').hide();
        $('#divZipCode').show();
        $('#divPostalCode').hide();

        $("#txtStateProvince").rules("remove");
        $("#ddlCountryCode").rules("remove");

        $('#divForeignAddress').hide();
        $('#divCountryCode').hide();
        $('#divUSAddress').show();

     }
}