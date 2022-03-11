
$(document).ready(function()
{

    // #region Sticky Nav \\
            if (window.pageYOffset>170) {
                
                stickyFirst = document.querySelector(".header-sticky");
                stickyFirst.classList.remove("d-none");
                stickyFirst.classList.add("stickyC");
            }

            window.onscroll = function() {stickyOrNot()};

            var navbar = $(".full-header")[0],
            stickyNav= $(".header-sticky")[0];

            var sticky = navbar.getBoundingClientRect();

            function stickyOrNot() {
                if (window.pageYOffset >= sticky.height) {
                    
                    stickyNav.classList.remove("d-none");
                    stickyNav.classList.add("stickyC");
                } 
                else if(window.pageYOffset < sticky.height-20) {
                
                    stickyNav.classList.remove("stickyC");
                    stickyNav.classList.add("d-none");

                }

            
            };

        // #endregion Sticky Nav End \\

    // #region Sliders 

        // #region Main Slider \\
            var swiper1 = new Swiper('.main-slider', 
                {
                    rewind: true,
                    slidesPerView: 1,
                    speed: 750,
                    autoplay: {
                        delay: 7e3
                    },
                    effect: "fade",
                    fadeEffect: {
                        crossFade: true
                    },
                    navigation: {
                        nextEl: '.swiper-button-next',
                        prevEl: '.swiper-button-prev'
                    },
                    pagination: {
                        el: ".swiper-pagination",
                        clickable: true,
                        type: "bullets"
                    }

            });
            $(".main-slider").hover(function() {
                    (this).swiper.autoplay.stop();
                }, function() {
                    (this).swiper.autoplay.start();
            });
        // #endregion Main End \\

        // #region New Product Slider \\
            var swiper2 = new Swiper(".new-product-slider",{
                    slidesPerView: 4,
                    spaceBetween: 30,
                    loop: true,
                    navigation: {
                        nextEl: ".product-button-next",
                        prevEl: ".product-button-prev"
                    },
                    breakpoints: {
                        320: {
                            slidesPerView: 1
                        },
                        480: {
                            slidesPerView: 2
                        },
                        768: {
                            slidesPerView: 3
                        },
                        992: {
                            slidesPerView: 4
                        }
                    }
            });
        // #endregion New Product End \\

        // #region Testimonial Slider \\
            var swiper3 = new Swiper(".testimonial-slider",{
                    preventInteractionOnTransition: true,
                    slidesPerView: 3,
                    spaceBetween: 30,
                    loop: true,
                    navigation: {
                        nextEl: ".testimonial-button-next",
                        prevEl: ".testimonial-button-prev"
                    },
                    pagination: {
                        el: ".swiper-pagination",
                        clickable: true,
                        type: "bullets"
                    },
                    breakpoints: {
                        320: {
                            slidesPerView: 1
                        },
                        768: {
                            slidesPerView: 2
                        },
                        1200: {
                            slidesPerView: 3
                        }
                    }
            });
        // #endregion Testimonial Slider End \\

        // #region Our Brand Slider \\
            var swiper4 = new Swiper(".our-brand-slider",{
                    slidesPerView: 5,
                    spaceBetween: 120,
                    loop: !0,
                    speed: 750,
                    autoplay: {
                        delay: 1e3
                    },
                    navigation: {
                        nextEl: ".swiper-button-next",
                        prevEl: ".swiper-button-prev"
                    },
                    breakpoints: {
                        320: {
                            slidesPerView: 2,
                            spaceBetween: 30
                        },
                        480: {
                            slidesPerView: 3,
                            spaceBetween: 30
                        },
                        992: {
                            slidesPerView: 4
                        },
                        1200: {
                            slidesPerView: 5
                        }
                    }
            });
            $(".our-brand-slider").hover(function() {
                    this.swiper.autoplay.stop()
                }, function() {
                    this.swiper.autoplay.start()
            });
        // #endregion Our Brand Slider End \\

        // #region Latest Blog Slider \\
            var swiper5 = new Swiper(".latest-blog-slider",{
                    slidesPerView: 3,
                    spaceBetween: 30,
                    speed: 750,
                    autoplay: {
                        delay: 5e3
                    },
                    loop: !0,
                    breakpoints: {
                        320: {
                            slidesPerView: 1
                        },
                        768: {
                            slidesPerView: 2
                        },
                        992: {
                            slidesPerView: 3
                        }
                    }
            });
            $(".latest-blog-slider").hover(function() {
                this.swiper.autoplay.stop()
            }, function() {
                this.swiper.autoplay.start()
            });
        // #endregion Latest Blog Slider End \\

        // #region Single Product Slider \\
            let singleProduct = document.querySelectorAll(".single-product-slider");
            let singleProductBottom = document.querySelectorAll(".single-product-bottom-slider");
            let singleProductArr = [];
            let singleProductBottomArr = [];
                
            let singleProductSlider = function ()
            {

                singleProduct.forEach(function(singleProduct, t)
                {
                    singleProductArr.push(new Swiper(singleProduct,{
                        loopedSlides: 3,
                        loop: true
                    }))
                });

                singleProductBottom.forEach(function(singleProduct, t)
                {

                    var singleProductArr = singleProductBottom;
                        
                    singleProductBottomArr.push(new Swiper(singleProduct,{
                        spaceBetween: 20,
                        slideToClickedSlide: true,
                        loop: true,
                        loopedSlides: 3,
                        slidesPerView: 2,
                        navigation: {
                            nextEl: singleProductArr[t].querySelector(".single-product-img-button-next"),
                            prevEl: singleProductArr[t].querySelector(".single-product-img-button-prev")
                        }
                    }))
                        
                    });

                    let sync = function() 
                    {
                        if (0 < singleProduct.length && 0 < singleProductBottom.length) {

                            var t = singleProductArr.length || singleProductBottomArr.length || 0;

                            for (let singleProduct = 0; singleProduct < t; singleProduct++){
                                singleProductArr[singleProduct].controller.control = singleProductBottomArr[singleProduct];
                                singleProductBottomArr[singleProduct].controller.control = singleProductArr[singleProduct];
                            }
                    }
                }();

            }();

        // #endregion Single Product Slider End \\

        // #region Modal-slider \\
            new Swiper(".modal-slider",{
                autoplay: false,
                delay: 5e3,
                slidesPerView: 1,
                slidesPerGroup: 1,
                observer: true,
                observeParents: true,
                loop: false,
                navigation: {
                    nextEl: ".thumbs-button-next",
                    prevEl: ".thumbs-button-prev"
                }
            });
        // #endregion Modal-slider end \\

        if ($(".owl-carousel-admin").length > 0) {
            $(".owl-carousel-admin").owlCarousel({

                items: 1,
                loop: true

            });
        }

        // #endregion Sliders End\\

    // #region To Top \\

            var toTop = $(".to-top");
            var windowScroll = $(window);
            windowScroll.on("scroll", function(){
                200 < windowScroll.scrollTop() ? toTop.addClass("show") : toTop.removeClass("show")
            });

            if (200 < windowScroll.scrollTop()) {
                toTop.addClass("show")
            }else{
                toTop.removeClass("show")
            }

            toTop.on("click", function(e){
                e.preventDefault(),
                $("html, body").animate({
                    scrollTop: 0
                })
            })

        // #endregion To Top End \\
  
    // #region Cart Menu & Small Menu\\

        var cartMenu = $(".cart-menu-full");
        var cart = $(".minicart-wrap");
        var cartMenuOverlay = $(".cart-menu-overlay");
        var body = $("body");
        var cartBtnClose = $(".btn-close-custom");
        var smallMenu = $(".menu-sm-full");
        var smallMenuCloseBtn = $(".menu-sm-full .button-close")
        var smallMenuOpenBtn = $(".small-menu-open-btn");
        

        cart.on("click", function(){

            cartMenu.addClass("open");
            cartMenuOverlay.addClass("open");
            body.addClass("body-overflow-hidden");
        });

        
    cartBtnClose.on("click", function (e) {
            e.preventDefault();
            cartMenu.removeClass("open");
            cartMenuOverlay.removeClass("open");
            body.removeClass("body-overflow-hidden");
        });

        cartMenuOverlay.on("click", function(){
            cartMenu.removeClass("open");
            smallMenu.removeClass("open-menu");
            cartMenuOverlay.removeClass("open");
            body.removeClass("body-overflow-hidden");
        });

        smallMenuOpenBtn.on("click", function(){

            smallMenu.addClass("open-menu");
            cartMenuOverlay.addClass("open");
            body.addClass("body-overflow-hidden");
        });

       
        smallMenuCloseBtn.on("click", function(){
            smallMenu.removeClass("open-menu");
            cartMenuOverlay.removeClass("open");
            body.removeClass("body-overflow-hidden");
        });

    // #endregion Cart Menu & Small Menu End \\

    // #region Range Slider \\
            $(".js-range-slider").ionRangeSlider({
                type: "double",
                min: 0,
                max: 1000,
                from: 0,
                to: 10000,
                grid: 0
            });
        
            $(".nice-select").niceSelect();
    // #endregion Range Slider End \\
    
    // #region Magnific-Popup \\
        $('.gallery-popup').magnificPopup({
            type: "image",
            gallery: {
                enabled: true
            }
        });

        $('.youtube-link').magnificPopup({
            type: "image",
            gallery: {
                enabled: true
            }
        });

        $('.youtube-link').magnificPopup({
            type: "iframe",
            disableOn: function() {
                return !($(window).width() < 600)
            }
        });
    // #endregion Magnific-Popup End \\
    
    // #region Product Count Select \\

        //if (document.querySelector(".product-detail-modal-ajax") != undefined) {


        //    let inputQty = document.querySelectorAll(".cart-action-box");
        //    let plusBtn = document.querySelectorAll(".cart-action .plus");
        //    let minusBtn = document.querySelectorAll(".cart-action .minus");
        //    let qty = 1;
        //    for (let i = 0; i < plusBtn.length; i++) {

        //        plusBtn[i].addEventListener("click", function () {
        //        if (qty>=1&&qty<5) {
        //            inputQty[i].value = qty+1;
        //            qty+=1; 
        //        }
        //        });

        //        minusBtn[i].addEventListener("click", function () {
        //            if (qty>1&&qty<=5) {
        //                inputQty[i].value=qty-1;
        //                qty-=1; 
        //            }
        //        });

        //    };


        //}

    // #endregion Product Count Select End \\

    // #region Counter-Up Plugin \\

        if ($('.counter').length!=0) {
            const counterUp = window.counterUp.default;

            const callback = entries => {
                entries.forEach( entry => {
                    const el = entry.target
                    if ( entry.isIntersecting && ! el.classList.contains( 'is-visible' ) ) {
                        counterUp( el, {
                            duration: 2000,
                            delay: 16,
                        } );
                        el.classList.add( 'is-visible' );
                    }
                } );
            };

            const IO = new IntersectionObserver( callback, { threshold: 1 } );

            const el = document.querySelectorAll( '.counter' );
            for (let index = 0; index < el.length; index++) {
                IO.observe( el[index] );
            }
        }
   
    // #endregion Counter-Up Plugin End \\

    // #region FAQ \\
        var faqOpenBtn = document.querySelectorAll(".faq-open-btn");
        var faqBody = document.querySelectorAll(".frequently-body");
        for (let i = 0; i < faqOpenBtn.length; i++) {
            faqOpenBtn[i].addEventListener("click", function (e) {
                e.preventDefault();
                for (let j = 0; j < faqBody.length; j++) {
                    if (j!=i) {
                        faqBody[j].classList.remove("active");
                    }
                    
                }
                faqBody[i].classList.toggle("active");
                
            });
        }
    // #endregion FAQ End \\


    let priceOpt = $("#singleProductSelector .nice-select ul li")
    let priceSizeOpt = document.querySelectorAll(".opt-price-size");
    let prSize = document.getElementById("SingleProductPrice");

    for (let k = 0; k < priceOpt.length; k++) {

        priceOpt[k].addEventListener("click", function () {

            if (!priceOpt[k].classList.contains("disabled")) {

                prSize.innerText = "$" + priceSizeOpt[k].value
            }
        })

    }
    if (document.querySelector(".cart-full-checker") != undefined) {
        let cartSizeOpt = $(".cart-nice-select");
        let cartPrice = document.querySelectorAll(".cart-price");
        let cartProductId = document.querySelectorAll(".cart-price-product-id");
        let cartProductCount = document.getElementById("cartProductCount").value;
        let cartSubtotalPrId = document.querySelectorAll(".cart-product-sub-total input");

        

        cartSizeOpt.change(function () {

            let mn = $(this);

            for (let t = 0; t < mn.children().length; t++) {

                if (+$(this).val() == mn.children()[t].value) {
                    $(this).parents("tr").children(".product-price").children(".cart-product-price")[0].textContent = "$" + mn.children()[t].attributes[1].value;
                    $(this).parent().siblings()[5].children[0].textContent ="$"+(+$(this).parent().next()[0].children[0].children[0].value * +($(this).parents("tr").children(".product-price").children(".cart-product-price")[0].textContent.substring(1))).toFixed(2);
                }

            }

            sbttl();
        })

        for (let l = 0; l < $(".cart-nice-select").length; l++) {

            $(".cart-nice-select")[l].removeAttribute("multiple");

        }

        $(".cart-minus2").click(function (e) {

            e.preventDefault()
            if ($(this).prev("input").val() > 1 && $(this).prev("input").val() <= 5) {
                $(this).prev("input").val($(this).prev("input").val() - 1);
            }

            $(this).parents()[2].children[6].children[0].textContent ="$"+ (+$(this).prev("input").val() * +($(this).parents()[2].children[3].children[0].textContent).substring(1)).toFixed(2);
            sbttl();

        })

        $(".cart-plus2").click(function (e) {

            e.preventDefault()
            let input = $(this).prevAll()[1];
            if (input.value >= 1 && input.value < 5) {
                input.value = +input.value + 1;
            }

            $(this).parents()[2].children[6].children[0].textContent = "$" + (+$(this).parent()[0].children[0].value * +($(this).parents()[2].children[3].children[0].textContent).substring(1)).toFixed(2);
            sbttl();

        })

    }
    let cartMenuFull2 = document.getElementById("cart-menu-full");
    let cartMenuContent2 = document.getElementById("cart-menu-content");
    let cartMenuList2 = document.getElementById("cart-menu-list");
    let cartTotalAmount2 = document.getElementById("cart-total-amount");

    let cartClear = function () {


        if (document.querySelectorAll(".cart-menu-products").length!=0) {
            let cmp = document.querySelectorAll(".cart-menu-products");
            for (var cmpr = 0; cmpr < cmp.length; cmpr++) {
                cmp[cmpr].remove()
            }
        }
        

    }

    let cartImgClear = function () {


        if (document.querySelectorAll(".empty-cart-img").length != 0) {
            let cmpe = document.querySelectorAll(".empty-cart-img");
            for (var cic = 0; cic < cmpe.length; cic++) {
                cmpe[cic].remove()
            }
        }


    }

    for (var mbtn = 0; mbtn < document.querySelectorAll(".minicart-btn").length; mbtn++) {
        document.querySelectorAll(".minicart-btn")[mbtn].addEventListener("click", function () {

            $.ajax({
                url: location.origin + "/Cart/GetCartMenu",
                type: "get",
                dataType: "json",
                data: {
                },
                success: function (model) {
                    if (model != null) {
                        var cartProducts = model["$values"];
                        let totalCartAmount = 0;
                        cartClear();
                        if (cartProducts != null || cartProducts != undefined) {
                            for (var p = 0; p < cartProducts.length; p++) {

                                let cartLi = document.createElement("li");
                                cartLi.classList.add("cart-menu-products");

                                let cartA = document.createElement("a");
                                cartA.classList.add("product-item-delete");
                                cartA.setAttribute("href", `/Cart/RemoveFromCart/${+cartProducts[p].id}`);
                                let cartI = document.createElement("i");
                                cartI.classList.add("fal");
                                cartI.classList.add("fa-times");
                                cartI.setAttribute("data-tippy", "Remove");
                                cartI.setAttribute("data-tippy-inertia", "true");
                                cartI.setAttribute("data-tippy-animation", "shift-away");
                                cartI.setAttribute("data-tippy-arrow", "true");
                                cartI.setAttribute("data-tippy-theme", "sharpborder");

                                cartA.appendChild(cartI);
                                cartLi.appendChild(cartA)
                                //---------
                                let cartDiv = document.createElement("div");
                                cartDiv.classList.add("product-item-img-wrapper");

                                let cartA2 = document.createElement("a");
                                cartA2.classList.add("product-item-img");
                                cartA2.setAttribute("href", "/Cart/Index/");

                                let cartImg = document.createElement("img");
                                for (var pi = 0; pi < cartProducts[p].productImages["$values"].length; pi++) {

                                    if (cartProducts[p].productImages["$values"][pi] != null) {
                                        cartImg.src = "/img/products/" + cartProducts[p].productImages["$values"][pi].image;
                                        break;
                                    }

                                }


                                cartA2.appendChild(cartImg);
                                cartDiv.appendChild(cartA2);
                                cartLi.appendChild(cartDiv);
                                //-----------

                                let cartDiv2 = document.createElement("div");
                                cartDiv2.classList.add("product-item-content");
                                let cartA3 = document.createElement("a");
                                cartA3.classList.add("product-item-title");
                                cartA3.setAttribute("href", "/Cart/Index/");
                                cartA3.innerText = cartProducts[p].name;

                                let cartSpan = document.createElement("span");
                                cartSpan.classList.add("product-item-qty");
                                for (var pp = 0; pp < cartProducts[p].productSizeToProducts["$values"].length; pp++) {
                                    if (cartProducts[p].productSizeToProducts["$values"][pp].price > 0) {
                                        cartSpan.innerText = `Starting price:` + Array(5).fill('\xa0').join('') + "$" + (+cartProducts[p].productSizeToProducts["$values"][pp].price).toFixed(2);
                                        totalCartAmount += +(cartProducts[p].productSizeToProducts["$values"][pp].price);
                                        break;
                                    }
                                    else {
                                        cartSpan.innerText = "Price will update soon."
                                    }
                                }
                                cartDiv2.appendChild(cartA3);
                                cartDiv2.appendChild(cartSpan);
                                cartLi.appendChild(cartDiv2);
                                cartMenuList2.appendChild(cartLi);
                                cartMenuContent2.appendChild(cartMenuList2);
                                cartMenuFull2.prepend(cartMenuContent2);
                                //--------------

                            }
                            if (totalCartAmount > 0) {
                                cartTotalAmount2.innerText = totalCartAmount.toFixed(2);
                            }
                        }
                        else {
                            cartImgClear();
                            let img2 = document.createElement("img");
                            img2.classList.add("empty-cart-img");
                            img2.src = "/img/uncategorized/empty-cart..png";
                            img2.classList.add("w-100");
                            cartMenuList2.appendChild(img2);
                        }
                        

                    }
                },
                error: function (error) {
                    console.log(error);
                },
                complete: function () {

                }
            });
        })
    }

    let StarFunc = function (AllTheStars) {

        let allStr = AllTheStars;
        if (allStr != null) {
            for (let astr = 0; astr < allStr.length; astr++) {

                allStr[astr].addEventListener("mouseover", function () {

                    if (astr == 0) {
                        for (let astr2 = 0; astr2 <= astr; astr2++) {
                            allStr[astr2].children[0].style.fontWeight = "900";

                        }
                    }
                    else if (astr == 1) {
                        for (let astr2 = 0; astr2 <= astr; astr2++) {
                            allStr[astr2].children[0].style.fontWeight = "900";

                        }
                    }
                    else if (astr == 2) {
                        for (let astr2 = 0; astr2 <= astr; astr2++) {
                            allStr[astr2].children[0].style.fontWeight = "900";

                        }
                    }
                    else if (astr == 3) {
                        for (let astr2 = 0; astr2 <= astr; astr2++) {
                            allStr[astr2].children[0].style.fontWeight = "900";

                        }
                    }
                    else if (astr == 4) {
                        for (let astr2 = 0; astr2 <= astr; astr2++) {
                            allStr[astr2].children[0].style.fontWeight = "900";

                        }
                    }

                })

            }

            for (let astre = allStr.length - 1; astre >= 0; astre--) {

                allStr[astre].addEventListener("mouseleave", function () {

                    if (astre == 0) {
                        for (let astr2 = astre; astr2 >= 0; astr2--) {
                            allStr[astr2].children[0].style.fontWeight = "100";

                        }
                    }
                    else if (astre == 1) {
                        for (let astr2 = astre; astr2 >= 0; astr2--) {
                            allStr[astr2].children[0].style.fontWeight = "100";

                        }
                    }
                    else if (astre == 2) {
                        for (let astr2 = astre; astr2 >= 0; astr2--) {
                            allStr[astr2].children[0].style.fontWeight = "100";

                        }
                    }
                    else if (astre == 3) {
                        for (let astr2 = astre; astr2 >= 0; astr2--) {
                            allStr[astr2].children[0].style.fontWeight = "100";

                        }
                    }
                    else if (astre == 4) {
                        for (let astr2 = astre; astr2 >= 0; astr2--) {
                            allStr[astr2].children[0].style.fontWeight = "100";

                        }

                    }





                })

            }
        }

    }

    let starReviews = function (userEmail, userSurname, userName, singleProductId, ratingValue) {

        $.ajax({
            url: location.origin + "/Shop/ReviewPost",
            type: "get",
            dataType: "json",
            data: {
                userName: userName,
                userSurname: userSurname,
                userEmail: userEmail,
                productId: String(singleProductId),
                ratingValue: ratingValue
            },
            success: function (response) {
                if (response.success != null) {

                    swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");

                    strttlfunc(+singleProductId)

                }
                else if (response.changed != null) {

                    swal("Changed!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");

                    strttlfunc(+singleProductId)

                }
                else if (response.error != null) {

                    swal("Oops", "Something went wrong", "error");
                    strttlfunc(+singleProductId)
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {

            }
        });

    }

    var shopSI = $(`.product-full .product-item .product-content .rating-box ul li .fastar`);

    if ($(".single-product-full").length > 0) {

        shopSI = $(".single-product-full .product-info .rating-box1 .fastar");
    }

    let isEmailTrue = function isEmail(email) {
        return /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$/i.test(email);
    }

    var b;
    var a;

    shopSI.click(function () {

        let ratingValuePD = $(this).data().rv;
        let singleProductIdPD = $(this).data().pd;

        b = ratingValuePD;
        a = singleProductIdPD;
       

    })

    shopSI.mouseover(function () {

        StarFunc($(this).parentsUntil(".rating-box")[1].children);
        
    })

    $("#mdoalrat1").click(function (e) {

        e.preventDefault();

        var userName = $("#recipient-name").val();
        var userSurname = $("#recipient-surname").val();
        var userEmail = $("#message-email").val();

        if (isEmailTrue(userEmail)) {

            starReviews(userEmail, userSurname, userName, a, b);

            

        }
        else {

            swal("Oops", "Please enter valid Email adress", "error");
        }

        $("#exampleModal2 .btn-close").click()

    })

    if ($(".user-enable").length>0) {

        $(".user-enable").click(function () {

            starReviews("user", "user", "user", a, b);

        })

    }

    if ($("#profileIsCreated").length>0) {

        swal("Perfect!", `Thank you for Signing Up!`, "success");

    }

    if ($("#UpdateUserSuccess").length > 0) {

        swal("Updated!", `Your profile was updated successfully!`, "success");

    }

    if ($("#PaymentSuccessAlert").length > 0) {

        swal("Perfect!!", `Thank you for choosing us! Please check your Email`, "success");

    }
    
    if ($("#ResetSuccess").length > 0) {

        swal("Success!", `Your password has been changed successfully!`, "success");

    }

    if ($("#ResetError2").length > 0) {

        swal("Oops!", `Something went wrong. Try it again!`, "error");

    }

    if ($("#LoginRoleError").length > 0) {

        swal("Oops!", `You dont have permission to use this account like End User!`, "error");

    }

    let sbttl = function () {

        var tl = 0;
        let a = $(".amount-cart2");
        for (let t = 0; t < a.length; t++) {

            tl += +(a[t].textContent.substring(1))
            a[t].textContent

        }

        $(".subTotalEnd2")[0].textContent = "$" + tl.toFixed(2);
        $(".totalEnd2")[0].textContent = "$" + tl.toFixed(2);

    }
    
    if ($(".amount-cart2").length > 0) {

        sbttl();
    }

    $(".btn-newsletter2").click(function (e) {

        e.preventDefault();

        let usrMail = $("#hgjhg").val();

        if (isEmailTrue(usrMail)) {
            console.log(usrMail)
            $.ajax({
                url: location.origin + "/About/Subscribe",
                type: "get",
                dataType: "json",
                data: {
                    email: usrMail
                },
                success: function (response) {

                    console.log(response)

                    if (response.success != null) {

                        swal("Good Job!", `${response.success}`, "success");
                        $("#hgjhg")[0].value = "";
                        $("#hgjhg").attr("placeholder", "Enter Your Email")
                    }
                    else if (response.changed != null) {

                        swal("Hmm!", `${response.changed}`, "info");
                        $("#hgjhg")[0].value = "";
                        $("#hgjhg").attr("placeholder", "Enter Your Email")


                    }

                    
                },
                error: function (error) {
                    console.log(error);
                },
                complete: function () {

                }
            });

        } else {

            $("#hgjhg")[0].value = "";
            $("#hgjhg").attr("placeholder", "Enter Your Email")

        }

        



    })

    if ($("#emlscssend").length>0) {

        swal({
            title: "Success!",
            text: `We sent reset link to you. Check your email!`,
            icon: "success",
            button: "Close"
        });

    }

    let strttlfunc = function (Id) {

        let dtd = $(".ratingdataid2");

        if (Number.isInteger(Id)) {
            $.ajax({
                url: location.origin + "/Shop/GetRatingValue",
                type: "get",
                dataType: "json",
                data: {
                    id: Id
                },
                success: function (r) {
                    if (r["$values"].length>0) {

                        let fiveS = 0;
                        let fourS = 0;
                        let threeS = 0;
                        let twoS = 0;
                        let oneS = 0;
                        let rval2 = r["$values"];

                        for (var i = 0; i < rval2.length; i++) {

                            for (let str = 0; str < rval2.length; str++) {
                                if (rval2[str].star == 5) {
                                    fiveS++;
                                }
                                else if (rval2[str].star == 4) {
                                    fourS++;
                                }
                                else if (rval2[str].star == 3) {
                                    threeS++;
                                }
                                else if (rval2[str].star == 2) {
                                    twoS++;
                                }
                                else if (rval2[str].star == 1) {
                                    oneS++;
                                }
                            }

                        }

                            let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
                            let rSum = fiveS + fourS + threeS + twoS + oneS;
                            let sumRsum = sum / rSum;

                            if (sumRsum != 0) {

                                for (var i = 0; i < dtd.length; i++) {

                                    if (dtd[i].attributes[0].value == Id) {
                                        dtd[i].textContent = `(${sumRsum.toFixed(1)})`;
                                    }

                                }
                            }

                    }
                    else if (r.length == 0) {

                        swal("Oops", "Something went wrong", "error");
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            });
        }

    }

    if ($("#UserAccessDenied").length>0) {

        swal("Info", `To access, you must first log out of your current account!`, "info");

    }

    // #region Remove Archived Product

    $.ajax({
        url: location.origin + "/Cart/RemoveArchivedFromCart",
        type: "get",
        dataType: "json",
        data: {},
        success: function () {
            console.log("Hello")
        },
        error: function (error) {
        }
    });

    $.ajax({
        url: location.origin + "/Cart/RemoveUserArchivedFromCart",
        type: "get",
        dataType: "json",
        data: {},
        success: function () {
            console.log("Hello")
        },
        error: function (error) {
        }
    });

    // #endregion Remove Archived Product

    $(document).ready(function () {

        setTimeout(function () {
            $('#ctn-preloader').addClass('loaded');
            // Una vez haya terminado el preloader aparezca el scroll
            $('body').removeClass('no-scroll-y');

            if ($('#ctn-preloader').hasClass('loaded')) {
                // Es para que una vez que se haya ido el preloader se elimine toda la seccion preloader
                $('#preloader').delay(1000).queue(function () {
                    $(this).remove();
                });
            }
        }, 3000);

    });

});