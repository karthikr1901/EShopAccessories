$(document).ready(function () {
    $asp("txtName").keydown(function (event) {
        return NameCityVal();
    });

  
    $asp("txtCVV").keydown(function (event) {
        if (event.which >= 48 && event.which <= 57) {
            return true;
        }
        else if (event.which >= 96 && event.which <= 105) {
            return true;
        }
        else if (event.which == 8 || event.which == 9) {
            return true;
        }
        else if (event.which >= 35 && event.which <= 46) {
            return true;
        }
        return false;
    });

    function NameCityVal() {
        //debugger;
        if (event.which >= 65 && event.which <= 90) {
            return true;
        }
        else if (event.which == 8 || event.which == 9 || event.which == 16 || event.which == 20 || event.which == 32) {
            return true;
        }
        else if (event.which >= 35 && event.which <= 46) {
            return true;
        }
        return false;
    }
    
});
function $asp(serverID) {
    return $("[id$='" + serverID + "']");
}