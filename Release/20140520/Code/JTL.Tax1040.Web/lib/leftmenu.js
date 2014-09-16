//Left Memu Controls.

document.write("<div id='leftmenu' class='menu' role='navigation'>" +
    "<div class='collapse navbar-collapse' id='lftmenu'>" +
    "<ul id='nav' class='nav side-nav'>" +
    "<li id='lifilingStatus'><a href='filingstatus.html'><i class='fa fa-exchange'></i>Filing Status</a></li>" +
    "<li id='lipersonalfilerinfo'><a href='../PersonalInfo/primaryfilerinfo.html'><i class='fa fa-user'></i>Primary Filer</a></li>" +
    "<li id='liaddress'><a href='../PersonalInfo/address.html'><i class='fa fa-barcode'></i>Address  </a></li>" +
    "<li id='liSpouse' style='display:none;'><a href='../PersonalInfo/spouseinfo.html'><i class='fa fa-female'></i>Spouse </a></li>" +
    "<li id='lipersonalSummary'><a href='../PersonalInfo/personalsummary.html'><i class='fa fa-th-list'></i>Personal Summary</a></li>" +
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

    var selectedSection = window.location.pathname.split('/')[2].split('.')[0];
    switch (selectedSection)
    {
        case 'filingstatus':
            $('#lifilingStatus').addClass('active');
            break;

        case 'address':
            $('#liaddress').addClass('active');
            break;
            
        case 'primaryfilerinfo':
            $('#lipersonalfilerinfo').addClass('active');
            break;
            
        case 'spouseinfo':
            $('#liSpouse').addClass('active');
            break;

        case 'personalsummary': 
            $('#lipersonalSummary').addClass('active');
            break;

        default:
    }
});



