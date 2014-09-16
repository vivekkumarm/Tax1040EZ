
if (get_browser().toUpperCase() == 'MSIE' || get_browser().toUpperCase() == 'TRIDENT') { // Check Internet explorer
        if (get_browser_version() < 9) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
else if (get_browser().toUpperCase() == 'FIREFOX') { // Check Mozila fire fox
        if (get_browser_version() < 2) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
else if (get_browser().toUpperCase() == 'OPERA') {// Check Opera 
        if (get_browser_version() < 22) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
else if (get_browser().toUpperCase() == 'SAFARI') {// Check safari
        if (get_browser_version() < 5) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }
else if (get_browser().toUpperCase() == 'CHROME') {// Check chrome
        if (get_browser_version() < 32) {
            window.location.href = "../Common/browsercompatibility.html";
        }
    }

function get_browser() {
    var ua = navigator.userAgent, tem, M = ua.match(/(opera|chrome|safari|firefox|msie|trident(?=\/))\/?\s*(\d+)/i) || [];
    if (/trident/i.test(M[1])) {
        tem = /\brv[ :]+(\d+)/g.exec(ua) || [];
        return 'IE ' + (tem[1] || '');
    }
    if (M[1] === 'Chrome') {
        tem = ua.match(/\bOPR\/(\d+)/)
        if (tem != null) { return 'Opera ' + tem[1]; }
    }
    M = M[2] ? [M[1], M[2]] : [navigator.appName, navigator.appVersion, '-?'];
    if ((tem = ua.match(/version\/(\d+)/i)) != null) { M.splice(1, 1, tem[1]); }
    return M[0];
}

function get_browser_version() {
    var ua = navigator.userAgent, tem, M = ua.match(/(opera|chrome|safari|firefox|msie|trident(?=\/))\/?\s*(\d+)/i) || [];
    if (/trident/i.test(M[1])) {
        tem = /\brv[ :]+(\d+)/g.exec(ua) || [];
        return 'IE ' + (tem[1] || '');
    }
    if (M[1] === 'Chrome') {
        tem = ua.match(/\bOPR\/(\d+)/)
        if (tem != null) { return 'Opera ' + tem[1]; }
    }
    M = M[2] ? [M[1], M[2]] : [navigator.appName, navigator.appVersion, '-?'];
    if ((tem = ua.match(/version\/(\d+)/i)) != null) { M.splice(1, 1, tem[1]); }
    return M[1];
}