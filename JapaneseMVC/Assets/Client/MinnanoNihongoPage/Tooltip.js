
//Change pixel
$(function () {
    $('div.showHint').hide();
    $('button#btn12px').click(function () {
        $('.changePx').removeClass("formatFont14px");
        $('.changePx').removeClass("formatFont16px");
        $('.changePx').addClass("formatFont12px");
        $(this).prop('disabled', true);
        $('button#btn14px').prop('disabled', false);
        $('button#btn16px').prop('disabled', false);
    });
    $('button#btn14px').click(function () {
        $('.changePx').removeClass("formatFont12px");
        $('.changePx').removeClass("formatFont16px");
        $('.changePx').addClass("formatFont14px");
        $(this).prop('disabled', true);
        $('button#btn12px').prop('disabled', false);
        $('button#btn16px').prop('disabled', false);
    });
    $('button#btn16px').click(function () {
        $('.changePx').removeClass("formatFont12px");
        $('.changePx').removeClass("formatFont14px");
        $('.changePx').addClass("formatFont16px");
        $(this).prop('disabled', true);
        $('button#btn12px').prop('disabled', false);
        $('button#btn14px').prop('disabled', false);
    });
    //showHint
    $('button#showHint').click(function () {
        $('div.showHint').toggle();
    });
});