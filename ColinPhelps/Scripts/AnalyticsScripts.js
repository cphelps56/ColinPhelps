$(document).ready(function () {


    $('#resumeButton').click(function () {
        ga('create', 'UA-100321309-1', 'auto');
        ga('send', 'event', 'button', 'click', 'Resume');
        alert("Resume button clicked");
    });

});