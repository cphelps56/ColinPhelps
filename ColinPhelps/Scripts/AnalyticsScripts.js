var analyticsHelper = (function (jQuery) {
    "use strict";

    var module = {
        onready: function () {

                $('#resumeButton').click(function () {
                    ga('send', 'event', 'button', 'click', 'ResumeBtn');
                    alert("Resume button clicked");
                });
        }
    }
    return module;
    // Any private functions should go below this line
})(jQuery);