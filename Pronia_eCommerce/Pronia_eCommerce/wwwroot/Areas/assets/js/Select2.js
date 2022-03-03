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


    if ($('#myChart').length > 0) {


        let ddts = [];
        let ddt2s = [];

        let a = $(".DatasForCharts");
        for (let i = 0; i < a.length; i++) {

            ddts.push(a[i].attributes["data-date"].textContent);
            ddt2s.push(a[i].attributes["data-data2"].textContent);
        }

        const data = {
            labels: ddts,
            datasets: [{
                label: 'Sale Product Count',
                borderColor: '#14b6ff',
                data: ddt2s,
            }]
        };

        var myChart = new Chart("myChart", {
            type: "line",
            data: data,
            options: {}
        });

    }


});

