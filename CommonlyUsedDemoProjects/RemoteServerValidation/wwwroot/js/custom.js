//For Phone Number validation with server side
$(function () {
    jQuery.fn.ForceNumericOnly =
        function () {
            return this.each(function () {
                $(this).keydown(function (e) {
                    var IsCtrlKey = false;
                    var key = e.charCode || e.keyCode || 0;
                    console.log(key);
                    if (e.ctrlKey === true || e.metaKey === true) {
                        IsCtrlKey = true;
                    }
                    return (
                        key == 46 ||                //deleteKey
                        (key >= 35 && key <= 36) || //arrow keys
                        key == 14 ||                //ctrlKey
                        (key >= 37 && key <= 40) || //arrow keys
                        (key == 86 && IsCtrlKey) ||                //paste Key
                        (key == 67 && IsCtrlKey) ||               //copy Key
                        key == 8 ||
                        (key >= 48 && key <= 57) ||
                        (key >= 96 && key <= 105)
                    );
                });
            });
        };

    $(".numberOnly").ForceNumericOnly();

});