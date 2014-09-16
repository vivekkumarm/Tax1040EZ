//Saravanan N - 25th July, 2014 - File newly added.

$(document).ready(
    function () {
        $('#btnSignout').click(function () {
            window.sessionStorage.clear();
            window.location.href = '../Login.html';
        });
    });
