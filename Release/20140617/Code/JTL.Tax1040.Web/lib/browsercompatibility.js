// 09Jun2014 Sathish refer javascript browser compatibility. Will not work in jQuery 1.9 or later unless the jQuery Migrate plugin is included.
document.write("<script type='text/javascript' src='../Scripts/jquery-migrate-1.2.1.js'></script>");


$(document).ready(function () {
    // 09Jun2014 Sathish Check the browser comptability
    CheckBrowserCompatibility();
});

// 09Jun2014 Sathish Check the browser comptability
function CheckBrowserCompatibility() {

    /* Get browser Chrome */
    $.browser.chrome = /chrome/.test(navigator.userAgent.toLowerCase());

    if ($.browser.msie) { // Check Internet explorer

        if ($.browser.version < 9) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
    else if ($.browser.mozilla) { // Check Mozila fire fox
        if ($.browser.version < 2) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
    else if ($.browser.opera) {// Check Opera 
        if ($.browser.version < 22) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
    else if ($.browser.safari) {// Check safari
        if ($.browser.version < 5) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
    else if ($.browser.chrome) {// Check chrome
        if ($.browser.version < 32) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }

}