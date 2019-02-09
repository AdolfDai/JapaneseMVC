$(function () {
    //show hint
    $('.hintKw').hide();
    $('.hintRb').hide();
    $('.hintBk').hide();
    $('ul#Kw #showHint').click(function () {
        $('.hintKw').toggle();
    })
    $('ul#Rb #showHint').click(function () {
        $('.hintRb').toggle();
    })
    $('ul#Bk #showHint').click(function () {
        $('.hintBk').toggle();
    })
});

//Change pixel
$(function () {
    //1
    function divChange12px(divChange) {
        divChange.removeClass("formatFont14px");
        divChange.removeClass("formatFont16px");
        divChange.addClass("formatFont12px");
    }
    //2
    function divChange14px(divChange) {
        divChange.removeClass("formatFont12px");
        divChange.removeClass("formatFont16px");
        divChange.addClass("formatFont14px");
    }
    //3
    function divChange16px(divChange) {
        divChange.removeClass("formatFont12px");
        divChange.removeClass("formatFont14px");
        divChange.addClass("formatFont16px");
    }
    //Change when click button Kaiwa
    $('ul#Kw #btn12px').click(function () {
        var divChange = $('.changeKwPx');
        divChange12px(divChange);
        $(this).prop('disabled', true);
        $('ul#Kw #btn14px').prop('disabled', false);
        $('ul#Kw #btn16px').prop('disabled', false);
    });
    $('ul#Kw #btn14px').click(function () {
        var divChange = $('.changeKwPx');
        divChange14px(divChange);
        $(this).prop('disabled', true);
        $('ul#Kw #btn12px').prop('disabled', false);
        $('ul#Kw #btn16px').prop('disabled', false);
    });
    $('ul#Kw #btn16px').click(function () {
        var divChange = $('.changeKwPx');
        divChange16px(divChange);
        $(this).prop('disabled', true);
        $('ul#Kw #btn12px').prop('disabled', false);
        $('ul#Kw #btn14px').prop('disabled', false);
    });

    //Change when click button Reibun
    $('ul#Rb #btn12px').click(function () {
        var divChange = $('.changeRbPx');
        divChange12px(divChange);
        $(this).prop('disabled', true);
        $('ul#Rb #btn14px').prop('disabled', false);
        $('ul#Rb #btn16px').prop('disabled', false);
    });
    $('ul#Rb #btn14px').click(function () {
        var divChange = $('.changeRbPx');
        divChange14px(divChange);
        $(this).prop('disabled', true);
        $('ul#Rb #btn12px').prop('disabled', false);
        $('ul#Rb #btn16px').prop('disabled', false);
    });
    $('ul#Rb #btn16px').click(function () {
        var divChange = $('.changeRbPx');
        divChange16px(divChange);
        $(this).prop('disabled', true);
        $('ul#Rb #btn12px').prop('disabled', false);
        $('ul#Rb #btn14px').prop('disabled', false);
    });

    //Change when click button Bunkei
    $('ul#Bk #btn12px').click(function () {
        var divChange = $('.changeBkPx');
        divChange12px(divChange);
        $(this).prop('disabled', true);
        $('ul#Bk #btn14px').prop('disabled', false);
        $('ul#Bk #btn16px').prop('disabled', false);
    });
    $('ul#Bk #btn14px').click(function () {
        var divChange = $('.changeBkPx');
        divChange14px(divChange);
        $(this).prop('disabled', true);
        $('ul#Bk #btn12px').prop('disabled', false);
        $('ul#Bk #btn16px').prop('disabled', false);
    });
    $('ul#Bk #btn16px').click(function () {
        var divChange = $('.changeBkPx');
        divChange16px(divChange);
        $(this).prop('disabled', true);
        $('ul#Bk #btn12px').prop('disabled', false);
        $('ul#Bk #btn14px').prop('disabled', false);
    });
});

