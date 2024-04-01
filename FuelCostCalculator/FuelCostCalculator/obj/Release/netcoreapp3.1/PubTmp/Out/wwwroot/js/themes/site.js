// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function FormatDate(e, obj) {
    debugger;
    var flag = false;
    var key = e.keyCode ? e.keyCode : e.which ? e.which : e.charCode;
    var inputLength = obj.value.length;
    var selectionLength = obj.selectionEnd - obj.selectionStart;
    if (key != 13) {
        if (key == 8 || key == 9 || key == 127 || key == 48 || key == 49 || key == 50 || key == 51 || key == 52 || key == 53 || key == 54 || key == 55 || key == 56 || key == 57 || selectionLength == inputLength) {
            flag = true;
        }
        else {
            flag = false;
        }
    }
    else if (obj.selectionStart === 0 && obj.selectionEnd === obj.value.length) {
        // user has selected the whole text of the input, allow input
        flag = true;
    }
    else {
        flag = false;
    }
    if (flag) {
        var res = obj.value;
        if (obj.value.length == 2) {
            if (parseInt(obj.value) <= 12) {
                obj.value = obj.value + "/";
            }
            else if (selectionLength == inputLength) {
                obj.value = "";
            }
            else {
                e.preventDefault();
                return false;
            }
        }
        if (obj.value.length == 5) {
            var res = obj.value.split("/");
            if (parseInt(res[1]) <= 31) {
                obj.value = obj.value + "/";
            } else if (selectionLength == inputLength) {
                obj.value = "";
            }
            else {
                e.preventDefault();
                return false;
            }
        }
    }
}

function InitDateKeyEvent() {
    $('.date-picker').on('keypress', function (e) {
        var Id = "#" + $(this).attr("Id");
        var key = e.keyCode ? e.keyCode : e.which ? e.which : e.charCode;

        if (
            ($(Id).val().length < 10 || (
                $(Id).val().length == 10
                && $(Id)[0].selectionStart == 0
                && $(Id)[0].selectionEnd == 10
            )
            ) && key != 47 && key != 45) {
            FormatDate(e, this);
        }
        else {
            e.preventDefault();
            return false;
        }
    });
}