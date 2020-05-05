$(document).ready(function () {
    var bankNotUpdated = $('#bank-not-updated')[0];
    
    $('#placed-transfer').click(function () {
        if ($(this).is(':checked')) {
            bankNotUpdated.classList.remove('d-none');
        }
    });

    $('#not-transfered').click(function () {
        bankNotUpdated.classList.add('d-none');
    });
})