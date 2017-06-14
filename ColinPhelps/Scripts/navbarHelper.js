var navbarHelper = (function (jQuery) {
    "use strict";

    var module = {

        resumeBtnBinding: function () {
            $('#resumeButton').on("click", function () {
                ga('send', 'event', 'button', 'click', 'ResumeBtn');
            });
        }
    }
    return module;
})(jQuery);