//Left Memu Controls.

document.write("<div id='leftmenu' class='menu' role='navigation'>" +
    "<div class='collapse navbar-collapse' id='lftmenu'>" +
    "<ul id='nav' class='nav side-nav'>" +
    "<li id='lifilingStatus'><a href='../PersonalInfo/filingstatus.html'><i class='fa fa-exchange'></i>Filing Status</a></li>" +
    "<li id='lipersonalfilerinfo'><a href='../PersonalInfo/primaryfilerinfo.html'><i class='fa fa-user'></i>Primary Filer  <sup id='supprimaryFilerErrorCount' class='badge tip' data-toggle='tooltip' data-placement='top'></sup></a></li>" +
    "<li id='liSpouse' style='display:none;'><a href='../PersonalInfo/spouseinfo.html'><i class='fa fa-female'></i>Spouse  <sup id='supspouseErrorCount' class='badge tip' data-toggle='tooltip' data-placement='top'></sup></a></li>" +
    "<li id='liaddress'><a href='../PersonalInfo/address.html'><i class='fa fa-barcode'></i>Address   <sup id='supaddressErrorCount' class='badge tip' data-toggle='tooltip' data-placement='top'></sup></a></li>" +
    "<li id='lipersonalSummary'><a href='../PersonalInfo/personalsummary.html'><i class='fa fa-th-list'></i>Personal Summary</a></li>" +
    // 19Jun2014 Sathish commented the below code to avoid hiding spouse info while clicking diagnostics.
 //   "<li id='liDiagnostics' style='display:none;'><a href='../Diagnostics/finaldiagnostics.html?Tab=PersonalInfo'><i class='fa fa-female'></i>Diagnostics</a></li>" +
    "</ul>" +
    "</div>" +
    "</div>");

$(document).ready(function() {
    
    //$("#nav li").click(
    //    function (e) {
    //        alert(e);
    //       // e.preventDefault();
    //        $(this).addClass("active");
    //        $(this).removeClass("active");
    //    });

    //07Aug2014 Sathish checked current personal section to show error count in left menu
        if (currentPersonalSection >= 2 && primaryFilerErrorCount > 0) {
            $('#supprimaryFilerErrorCount').html(primaryFilerErrorCount);
        }
        if (currentPersonalSection >= 3 && spouseErrorCount > 0) {
            $('#supspouseErrorCount').html(spouseErrorCount);
        }
        if (currentPersonalSection >= 4 && addressErrorCount > 0) {
            $('#supaddressErrorCount').html(addressErrorCount);
        }

    //Yogalakshmi - 11th July 2014 - Defect fix for TAX1040-14150 - Converting the pathname form upper case to lowercase using toLowerCase() method.
    var selectedSection = (window.location.pathname.split('/')[2].split('.')[0]).toLowerCase();
    //Thileep changed this to show elizibilty error messages in final summary(Review) page on 09July 2014 
    if (selectedSection == "finalsummary") {
        var pageURL = window.location.search.substring(1);
        var parameterName = pageURL.split('=');
        if (parameterName.toString().indexOf('Topic') == 0) {
            topic = parameterName[1];
            switch (topic) {
                case 'Wages':
                    $('#lifilingStatus').attr('style', 'display:none');
                    $('#lipersonalfilerinfo').attr('style', 'display:none');
                    $('#liaddress').attr('style', 'display:none');
                    $('#liSpouse').attr('style', 'display:none');
                    $('#lipersonalSummary').attr('style', 'display:none');
                    $('#liWages').addClass('active');

                    break;
                case 'PrimaryFiler':
                    $('#liWages').attr('style', 'display:none');

                    break;
                case 'Spouse':
                    $('#liWages').attr('style', 'display:none');
                    break;
                default:
            }
        }
        else if(parameterName.toString().indexOf('Tab') == 0)
        {
            var tab = parameterName[1];
            tab = tab.split('&');
           var filingStatus = "";
           if (tab[1] =='FilingStatus')
           {
               filingStatus = parameterName[2];
           }
           switch (tab[0]) {
               case 'PersonalInfo':
                   $('#liWages').attr('style', 'display:none');
                   if(filingStatus == "2")
                       $("#liSpouse").css("display", "inline");
                   break;
               default:
           }
        }
    }
    else {
        switch (selectedSection) {
            case 'filingstatus':
                $('#lifilingStatus').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;

            case 'address':
                $('#liaddress').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;

            case 'primaryfilerinfo':
                $('#lipersonalfilerinfo').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;

            case 'spouseinfo':
                $('#liSpouse').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;

            case 'personalsummary':
                $('#lipersonalSummary').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;
            case 'PrimaryFilerInfo':
                $('#lipersonalfilerinfo').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;
            case 'SpouseInfo':
                $('#liSpouse').addClass('active');
                $('#liWages').attr('style', 'display:none');
                break;
            default:
        }
    }
});



