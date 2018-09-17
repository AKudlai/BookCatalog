var Modal = function () {

    var Modal = function (options) {
        var defaults = {
            title: '',
            id: '',
            className: '',
            content: '',
            onOpen: function () { },
            onClose: function () { },
            template: ''
        };

        this.options = options || $.extend(defaults, options || {});
    };

    Modal.prototype = {
        open: function () {

        },
        setContent: function () {

        },
        close: function () {

        }
    };

    return Modal;
};

