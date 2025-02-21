// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Photo Gallery

$(function () {

    $(`[unique-script-id="w-w-dm-id"] .btn-box`).on('click', function () {
        $(this).parent().children(".overlay").show();
    });

    $(`[unique-script-id="w-w-dm-id"] .close`).on('click', function () {
        $(`[unique-script-id="w-w-dm-id"] .overlay`).hide();
    });
});