$(document).ready(function () {


    $asp("txtPrice").keydown(function (event) {
        if (event.which >= 48 && event.which <= 57) {
            return true;
        }
        else if (event.which >= 96 && event.which <= 105) {
            return true;
        }
        else if (event.which == 8 || event.which == 9 || event.which == 190) {
            return true;
        }
        else if (event.which >= 35 && event.which <= 46) {
            return true;
        }
        return false;
    });

    $asp("txtStock").keydown(function (event) {
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

    $asp("txtDiscount").keydown(function (event) {
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

    $asp("btnSubmit").click(function () {
        //debugger;
        var Name = $asp("txtName").val();
        var Desc = $asp("txtDesc").val();
        var Price = $asp("txtPrice").val();
        var Stock = $asp("txtStock").val();
        //var Cat1 = $asp("ddlCategory1").val();
        var Discount = $asp("txtDiscount").val();
        var Brand = $asp("txtBrand").val();
        //var Cat2 = $asp("ddlCategory2").val();

        if (Name == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Name";
            return false;
        }
        else if (Desc == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Description";
            return false;
        }
        else if (Price == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Price";
            return false;
        }
        else if (Stock == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Stock";
            return false;
        }
        else if (Discount == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Discount";
            return false;
        }
        else if ($asp("FileUpload1")[0].value == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Select a Pic";
            return false;
        }
        else if (Brand == "") {
            $asp("lblErrorMessage")[0].textContent = "Please Enter Brand";
            return false;
        }
        return true;
    });
});

function $asp(serverID) {
    return $("[id$='" + serverID + "']");
}