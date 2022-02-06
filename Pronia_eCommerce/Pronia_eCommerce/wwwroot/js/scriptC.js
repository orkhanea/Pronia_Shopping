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
                        slidesPerView: 3,
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
                max: 10000,
                from: 100,
                to: 10000,
                grid: 0
            });
        
            $("select").niceSelect();
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
        
        // let inputQty = $(".cart-action-box");
        // let plusBtn = $(".cart-action .plus");
        // let minusBtn = $(".cart-action .minus");
        // let qty = 1;
        // plusBtn.on("click", function(){
        //     if (qty>=1&&qty<5) {
        //         inputQty.val(qty+1);
        //         qty+=1; 
        //     }
        // })
        // minusBtn.on("click", function(){
        //     if (qty>1&&qty<=5) {
        //         inputQty.val(qty-1);
        //         qty-=1; 
        //     }
        // })

        let inputQty = document.querySelectorAll(".cart-action-box");
        let plusBtn = document.querySelectorAll(".cart-action .plus");
        let minusBtn = document.querySelectorAll(".cart-action .minus");
        let qty = 1;
        for (let i = 0; i < plusBtn.length; i++) {
            
            plusBtn[i].addEventListener("click", function(){
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

});