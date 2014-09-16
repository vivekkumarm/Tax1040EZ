// 14May2014 Sathish used to bind and person details
//14JULY2014-Vincent implemented pre page logic.

/**************************************** PAGE LOAD ACTION ****************************************/
$(document).ready(function () {
    $('#btnContinue').click(function () {
        location.href = '';
        return false;
    });
    $('#btnCancelEfile').click(function () {

        window.location.href = '../EFile/efileinformation.html';
        return false;
    });
    $('.spantaxendyear').html(TAX_END_YEAR);
    $.ajax({
        url: serviceUrl + 'efile/getpersonandirstransmission',
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

            $('#divSpouse').hide();
            $('#divSpouseFilingInfoFederal').hide();
            $('#divSpouseFilingInfoFederalState').hide();
            if (data != null) {
                if (data.m_Item1 != null)
                    $('.spanTaxPayer').html(data.m_Item1);
                if (data.m_Item2 != null) {
                    if (data.m_Item2.PrimaryTaxPayer != null) {
                        if (data.m_Item2.PrimaryTaxPayer.FilingStatus == 2) {
                            $('#divSpouse').show();
                            $('#divSpouseFilingInfoFederal').show();
                            $('#divSpouseFilingInfoFederalState').show();
                        }

                        //PRE-Page entry #9
                        if (data.m_Item2.PrimaryTaxPayer.Person != null && data.m_Item2.PrimaryTaxPayer.Person.Address != null) {
                            if (data.m_Item2.PrimaryTaxPayer.Person.Address.AddressType == 1) {
                                if (data.m_Item2.PrimaryTaxPayer.Person.Address.PersonalAddress != null)
                                    $('#lblPhoneNumber').html(data.m_Item2.PrimaryTaxPayer.Person.Address.PersonalAddress.PhoneNumber);
                            }
                            else if (data.m_Item2.PrimaryTaxPayer.Person.Address.AddressType == 2) {
                                if ($('#lblPhoneNumber').html(data.m_Item2.PrimaryTaxPayer.Person.Address.ForeignAddress != null))
                                    $('#lblPhoneNumber').html(data.m_Item2.PrimaryTaxPayer.Person.Address.ForeignAddress.PhoneNumber);
                            }
                        }



                        if (data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth != null) {
                            if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1900'
                   && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)) != '01/01/1')
                                $('#lblTaxpayerDOB').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.PrimaryTaxPayer.Person.DateOfBirth)));
                        }
                    }

                    if (data.m_Item2.Spouse != null && data.m_Item2.Spouse.Person!=null && data.m_Item2.Spouse.Person.DateOfBirth != null) {
                        if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1900'
                 && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)) != '01/01/1')
                            $('#lblSpouseDOB').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item2.Spouse.Person.DateOfBirth)));
                    }


                    if (data.m_Item4 != null) {
                        //PRE-Page entry #11

                        $('#lblEmailId').html(data.m_Item4.Email);
                    }

                    if (data.m_Item3 != null) {

                      

                        if (data.m_Item4.HaveFiledPriorYearReturnElectronically) {
                            //PRE-Page entry #12
                            if (data.m_Item3.FilingDate != null) {
                                $('#lblTodayDate').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.FilingDate)));
                            } else if (data.m_Item3.TaxpayerDateIssuedByIRS !=null) {
                                $('#lblTodayDate').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.TaxpayerDateIssuedByIRS)));
                            
                            }
                            if (data.m_Item3.HavePriorYearPIN) {
                                $('#lblTaxpayerPINFederal').html(data.m_Item3.PrimaryPIN);
                                $('#lblSpousePINFederal').html(data.m_Item3.SpousePriorYearPIN);
                            }
                            else if (data.m_Item3.HavePriorYearAGI) {
                                $('#lblTaxpayerPINFederal').html(data.m_Item3.PrimaryPriorYearPIN);
                                $('#lblSpousePINFederal').html(data.m_Item3.SpousePIN);
                            }
                            else if (data.m_Item3.HavePriorYearAGIAndPIN) {
                                $('#lblTaxpayerPINFederal').html(data.m_Item3.PrimaryTaxpayerEFIN);
                                $('#lblSpousePINFederal').html(data.m_Item3.SpouseEFIN);
                            }
                        }
                        else {
                            if ($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.PrimaryTaxPayerFilingDate)) != '01/01/1900'
               && $.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.PrimaryTaxPayerFilingDate)) != '01/01/1') {
                                $('#lblTodayDate').html($.datepicker.formatDate('mm/dd/yy', new Date(data.m_Item3.TaxpayerDateIssuedByIRS)));
                                $('#lblTaxpayerPINFederal').html(data.m_Item3.TaxpayerEFINIssuedByIRS);
                                $('#lblSpousePINFederal').html(data.m_Item3.SpouseEFINIssuedByIRS);
                            }
                        }

                    }

                    

                    if (data.m_Item5) {
                        
                        //window.location.href = '';
                        //return false;
                    } else {
                        //TODO
                        //Commented by vivek for the redirection based on the error
                        ////window.location.href = '../Efile/efileinformation.html';
                        ////return false;
                    }
                }

            }
        }
    });
    $('#btnContinue').click(function () {
        window.location.href = '../Efile/reviewtaxreturn.html';
        return false;
    });
    $('#btnCancelEfile').click(function () {
        if (confirm("Are you sure, you want to Cancel E-filing for your Federal tax return?")) {
            $.ajax({
                url: serviceUrl + 'efile/deleteefileinformation',
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
                }
            });
        }
        else {
            window.location.href = '../Efile/efileacknowledge.html';
            return false;
        }
    });
});