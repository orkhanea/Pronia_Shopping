$(document).ready(function () {
    $('.js-example-basic-multiple').select2();

    if ($(".owl-carousel-admin").length>0) {
        $(".owl-carousel-admin").owlCarousel({

            items: 1,
            loop: true

        });
    }



});

