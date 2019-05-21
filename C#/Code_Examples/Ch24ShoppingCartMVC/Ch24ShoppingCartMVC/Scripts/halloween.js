$(document).ready(function () {
    $('.autoPostBack').change(function () {
        $(this).closest('form').submit();
    });
});