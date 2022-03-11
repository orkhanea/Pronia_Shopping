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
        let ddt3s = [];

        let a = $(".DatasForCharts");
        for (let i = 0; i < a.length; i++) {

            ddts.push(a[i].attributes["data-date"].textContent);
            ddt2s.push(a[i].attributes["data-data2"].textContent);
            ddt3s.push(a[i].attributes["data-total"].textContent);
        }

        const data = {
            labels: ddts,
            datasets: [
                {
                    label: 'Total Product Count',
                    borderColor: '#bbd07ae8',
                    data: ddt2s,
                },
                {
                    label: 'Total Sales Amount',
                    borderColor: '#14b6ff',
                    data: ddt3s,
                }
            ]
        };

        var myChart = new Chart("myChart", {
            type: "line",
            data: data,
            options: {}
        });

    }



    $("#1234a").change(function (e) {

        $("#asdddsa img").remove();

        for (let i = 0; i < e.originalEvent.srcElement.files.length; i++) {


            let file = e.originalEvent.srcElement.files[i];

            let img = document.createElement("img");
            img.style.width = "150px";
            img.style.height = "auto";
            img.style.margin = "20px";
            let reader = new FileReader();
            reader.onloadend = function () {
                img.src = reader.result;
            }
            reader.readAsDataURL(file);
            $("#asdddsa").append(img);
        }
    });

});

