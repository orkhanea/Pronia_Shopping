$(document).ready(function () {
    $('.js-example-basic-multiple').select2();

    if ($(".owl-carousel-admin").length>0) {
        $(".owl-carousel-admin").owlCarousel({

            items: 1,
            loop: true

        });
    }

    $.getScript('https://unpkg.com/popper.js@1', function () {
        $.getScript('https://unpkg.com/tippy.js@4', function () {
            tippy(".allTabsList", {
                placement: 'right',
                boundary: document.getElementById('page-wrapper'),
                touch: false,
                theme: 'bbf'
            });
        });
    });

});

