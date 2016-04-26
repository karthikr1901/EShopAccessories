
$(document).ready(function () {
    $asp("TextBox11").keydown(function (event) {
        //8  - back space
        //46 - delete
        //37 - <- arrow
        //39 - -> arrow
        //36 - Home
        //35 - End
        if ((event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105) && !(event.which == 8) && !(event.which == 35) && !(event.which == 36) && !(event.which == 37) && !(event.which == 39) && !(event.which == 46))
            return false;
    });

    $asp("TextBox11").keyup(function () {
        if ($(this)[0].value.length > 3)
            $asp("TextBox12").focus();
    });

    $asp("TextBox12").keydown(function (event) {

        if ((event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105) && !(event.which == 8) && !(event.which == 35) && !(event.which == 36) && !(event.which == 37) && !(event.which == 39) && !(event.which == 46))
            return false;

    });

    $asp("TextBox12").keyup(function () {
        if ($(this)[0].value.length > 3)
            $asp("TextBox13").focus();
    });

    $asp("TextBox13").keydown(function (event) {

        if ((event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105) && !(event.which == 8) && !(event.which == 35) && !(event.which == 36) && !(event.which == 37) && !(event.which == 39) && !(event.which == 46))
            return false;

    });

    $asp("TextBox13").keyup(function () {
        if ($(this)[0].value.length > 3)
            $asp("TextBox14").focus();
    });

    $asp("TextBox14").keydown(function (event) {

        if ((event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105) && !(event.which == 8) && !(event.which == 35) && !(event.which == 36) && !(event.which == 37) && !(event.which == 39) && !(event.which == 46))
            return false;

//        if ($(this)[0].value.length > 2 && (event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105) && !(event.which == 8) && !(event.which == 35) && !(event.which == 36) && !(event.which == 37) && !(event.which == 39) && !(event.which == 46))
//            return false;

    });

    $asp("TextBox14").keyup(function () {
        if ($(this)[0].value.length > 3)
            $asp("TextBox15").focus();
    });

    $asp("TextBox15").keydown(function (event) {

        if ((event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105) && !(event.which == 8) && !(event.which == 35) && !(event.which == 36) && !(event.which == 37) && !(event.which == 39) && !(event.which == 46))
            return false;

    });
});

function $asp(serverID) {
    return $("[id$='" + serverID + "']");
}