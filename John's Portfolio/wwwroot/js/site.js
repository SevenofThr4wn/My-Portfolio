//Photo Gallery Javascript

$(function () {

    $(`[unique-script-id="w-w-dm-id"] .btn-box`).on('click', function () {
        $(this).parent().children(".overlay").show();
    });

    $(`[unique-script-id="w-w-dm-id"] .close`).on('click', function () {
        $(`[unique-script-id="w-w-dm-id"] .overlay`).hide();
    });
});