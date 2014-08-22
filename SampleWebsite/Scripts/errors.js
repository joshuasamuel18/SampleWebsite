$(document).ready(function () {
    //Registration Section Starts Here


    var mob = /^[1-9]{1}[0-9]{9}$/;
    var email = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;

    $("#txtEmailId").focusout(function () {
        if (email.test($(this).val()) == false) {
            $(this).addClass('error'); return false;
        }
    });
    $("#txtPhoneNo").focusout(function () {
        if (mob.test($(this).val()) == false) {
            $(this).addClass('error');
            return false;
        }
    });
    $('input[type="text"]').focus(function () {
        $(this).addClass("focus");
    });

    $('input[type="text"]').blur(function () {
        $(this).removeClass("focus");
    });
    //Registration Section Ends Here
});