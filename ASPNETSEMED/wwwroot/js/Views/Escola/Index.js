$(document).ready(function() {
    $('#searchInput').on('keyup', function() {
        var value = $(this).val().toLowerCase();
        $('.card-item').filter(function() {
            $(this).toggle($(this).attr('data-escola').toLowerCase().indexOf(value) > -1);
        });
    });

    $('.form-control').on('input', function() {
        if ($(this).val() === "") {
            resetFilter();
        }
    });

    function resetFilter() {
        $('.card-item').show(); // Mostra todos os itens
    }
});
