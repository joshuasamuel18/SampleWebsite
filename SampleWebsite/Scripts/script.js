﻿$(document).ready(function () {

    $('[id$=btnregister]').click(function () {
        checkvalidation();
        if ($(":input").hasClass('errortxt')) { return false; }
        var UserInfo =
            {
                UserId: 0,
                Name: $('[id$=txtname]').val(),
                EmailId: $('[id$=txtEmailId]').val(),
                PhoneNo: $('[id$=txtPhoneNo]').val().toString(),
                UserName: $('[id$=txtUserName]').val(),
                Password: $('[id$=txtPassword]').val(),
                Status: 0
            };
        $.ajax({
            cache: false,
            type: 'POST',
            url: "/UserInfo/Registeration",
            datatype: 'json',
            data: UserInfo,
            success: function (data)
            { alert('Success'); return false; }
        });
    });

    function checkvalidation() {
        var inp = $(":input");
        $(":input").each(function () {
            $(":input").removeClass('errortxt').filter(function () {
                return !$.trim(this.value);
            }).addClass('errortxt');
        });
        var name = $('[id$=txtname]').val();
        if (name.length < 3) {
            $('[id$=txtname]').addClass('errortxt');
            return false;
        }

        //validate email
        var email = $('[id$=txtEmailId]').val();
        var emailReg = new RegExp(/^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/i);
        if (!(emailReg.test(email)) || email == '') {
            $('[id$=txtEmailId]').addClass('errortxt');
            return false;
        }

        //validate phone
        var phone = $('[id$=txtPhoneNo]').val();
        var intRegex = new RegExp("/^\d{10}$/");
        if ((intRegex.test(phone)) || (phone.length < 10)) {
            $('[id$=txtPhoneNo]').addClass('errortxt');
            return false;
        }
        if (inp.hasClass('errortxt')) { return false; }
    }

    $(":input").blur(function () {
        $(":input").removeClass('errortxt').filter(function () {
            return !$.trim(this.value);
        }).addClass('errortxt');
    });
//    $('[id$=txtEmailId]').blur(function () {
//        validateEmail(this.value);
//    });
});