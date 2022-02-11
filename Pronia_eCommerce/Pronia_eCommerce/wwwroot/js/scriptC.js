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

        
        cartBtnClose.on("click", function(){
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

        if (document.querySelector(".product-detail-modal-ajax") != undefined) {


        let inputQty = document.querySelectorAll(".cart-action-box");
        let plusBtn = document.querySelectorAll(".cart-action .plus");
        let minusBtn = document.querySelectorAll(".cart-action .minus");
        let qty = 1;
        for (let i = 0; i < plusBtn.length; i++) {

            plusBtn[i].addEventListener("click", function () {
            if (qty>=1&&qty<5) {
                inputQty[i].value = qty+1;
                qty+=1; 
            }
            });
            minusBtn[i].addEventListener("click", function(){
                if (qty>1&&qty<=5) {
                    inputQty[i].value=qty-1;
                    qty-=1; 
                }
            });

        };


    }

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

            prSize.innerText = priceSizeOpt[k].value
        })

    }
    if (document.querySelector(".cart-full-checker") != undefined) {
        let cartSizeOpt = document.querySelectorAll("#cart-size .cart-nice-select ul li");
        let cartPrice = document.querySelectorAll(".cart-price");
        let cartProductId = document.querySelectorAll(".cart-price-product-id");
        let cartProductCount = document.getElementById("cartProductCount").value;
        let cartSubtotalPrId = document.querySelectorAll(".cart-product-sub-total input");
        

        for (let s = 0; s < cartSizeOpt.length; s++) {

            cartSizeOpt[s].addEventListener("click", function () {
                let productPrice = document.querySelector(`.cart-product-price${cartProductId[s].value}`);
                productPrice.innerText = cartPrice[s].value
                total();
            })

        }


        let total = function endtotal() {
            for (let q = 0; q < cartProductCount; q++) {

                let price2 = document.querySelector(`.cart-product-price${cartSubtotalPrId[q].value}`);
                let cartActionBox = document.querySelector(`.cart-action-box${cartSubtotalPrId[q].value}`).value
                let cps = document.querySelector(`.cart-product-subtotal${cartSubtotalPrId[q].value}`)
                let endTotal = (+cartActionBox) * (+price2.innerText)
                cps.innerText = endTotal.toFixed(2);       
            }

        }

        total();
        for (let m2 = 0; m2 < cartProductCount; m2++) {
            let qty2 = 1;
            document.querySelector(`.minus${cartSubtotalPrId[m2].value}`).addEventListener("click", function (e) {
                e.preventDefault()
                if (qty2 > 1 && qty2 <= 5) {
                    document.querySelector(`.cart-action-box${cartSubtotalPrId[m2].value}`).value = qty2 - 1;
                    qty2 -= 1;
                }
                total();

            })
            document.querySelector(`.plus${cartSubtotalPrId[m2].value}`).addEventListener("click", function (e) {
                e.preventDefault()

                if (qty2 >= 1 && qty2 < 5) {
                    document.querySelector(`.cart-action-box${cartSubtotalPrId[m2].value}`).value = qty2 + 1;
                    qty2 += 1;
                }

                total();
            })
        }

    }
    
    let cartMenuFull2 = document.getElementById("cart-menu-full");
    let cartMenuContent2 = document.getElementById("cart-menu-content");
    let cartMenuList2 = document.getElementById("cart-menu-list");
    let cartTotalAmount2 = document.getElementById("cart-total-amount");



    //document.querySelector(".btn-close-custom").addEventListener("click", function () {

        

    //})


    let cartClear = function () {


        if (document.querySelectorAll(".cart-menu-products").length!=0) {
            let cmp = document.querySelectorAll(".cart-menu-products");
            for (var cmpr = 0; cmpr < cmp.length; cmpr++) {
                cmp[cmpr].remove()
            }
        }
        

    }

    //cart - menu - overlay

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
                                cartA2.setAttribute("href", "#");

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
                                cartA3.setAttribute("href", "#");
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
                            let img2 = document.createElement("img");
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

    


});