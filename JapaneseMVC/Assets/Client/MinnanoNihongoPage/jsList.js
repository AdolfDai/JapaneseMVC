$(document).ready(function () {
    $("[data-id-a]").click(function () {
        var renshuuAId = $(this).attr("data-id-a");
        $.ajax({
            url: '/JpIndex/GetRenshuuA/',
            type: "Get",
            dataType: "html",
            data: { renshuuAId: renshuuAId },
            success: function (model) {
                $('#myModalContentA').html(model);
            }
        });
    });
    $("[data-id-b]").click(function () {
        var renshuuBId = $(this).attr("data-id-b");
        $.ajax({
            url: '/JpIndex/GetRenshuuB/',
            type: "Get",
            dataType: "html",
            data: { renshuuBId: renshuuBId },
            success: function (model) {
                $('#myModalContentB').html(model);
            }
        });
    });
    $("[data-id-c]").click(function () {
        var renshuuCId = $(this).attr("data-id-c");
        $.ajax({
            url: '/JpIndex/GetRenshuuC/',
            type: "Get",
            dataType: "html",
            data: { renshuuCId: renshuuCId },
            success: function (model) {
                $('#myModalContentC').html(model);
            }
        });
    });
    $("[data-id-md1]").click(function () {
        var MondaiId = $(this).attr("data-id-md1");
        $.ajax({
            url: '/JpIndex/GetMondaiAudio/',
            type: "Get",
            dataType: "html",
            data: { MondaiId: MondaiId },
            success: function (model) {
                $('#myModalContentMD1').html(model);
            }
        });
    });
    $("[data-id-md2]").click(function () {
        var MondaiId = $(this).attr("data-id-md2");
        $.ajax({
            url: '/JpIndex/GetMondaiNoAudio/',
            type: "Get",
            dataType: "html",
            data: { MondaiId: MondaiId },
            success: function (model) {
                $('#myModalContentMD2').html(model);
            }
        });
    });

});