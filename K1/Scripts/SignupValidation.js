$(document).ready(function () {
    $asp("txtName").keydown(function (event) {
        return NameCityVal();
    });

    $asp("txtCity").keydown(function (event) {
        return NameCityVal();
    });

    $asp("txtMobile").keydown(function (event) {
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
    $asp("btnSubmit").click(function () {
        var Name = $asp("txtName").val();
        var Address = $asp("txtAddress").val();
        var City = $asp("txtCity").val();
        var MobileNo = $asp("txtMobile").val();
        var Email = $asp("txtEmail").val();
        var RegExValID = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;

        if (Name == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Name";
            return false;
        }
        else if (Address == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Address";
            return false;
        }
        else if (City == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter City";
            return false;
        }
        else if (MobileNo == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Mobile Number";
            return false;
        }
        else if (Email == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Email";
            return false;
        }
        else if (MobileNo.length < 10) {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Valid Mobile Number";
            return false;
        }
        else if (Email.search(RegExValID) == -1) {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Valid Email";
            return false;
        }
        return true;
    });
});
function $asp(serverID) {
    return $("[id$='" + serverID + "']");
}