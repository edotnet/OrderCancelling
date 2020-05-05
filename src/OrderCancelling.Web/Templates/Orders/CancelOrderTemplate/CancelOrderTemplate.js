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

    var otherText = $('#other-description')[0];

    $('#select-reason-radios .radio-wrapper input').click(function() {
        debugger
        if($('#other').is(':checked')) {
            otherText.classList.remove('d-none');
        } else {
            otherText.classList.add('d-none');
        }
    });
})