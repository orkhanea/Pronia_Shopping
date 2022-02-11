$(document).ready(function () {

    let eye = document.querySelectorAll(".productFullDetail");

    for (let i = 0; i < eye.length; i++) {

        eye[i].addEventListener("click", function () {

            $("#quantity-left").addClass("d-none");
            let productSwiperWrapper = $("#productmodalbody .swiper-wrapper .swiper-slide");
            for (var q = 0; q < productSwiperWrapper.length; q++) {
                productSwiperWrapper[q].remove()
            }

            let niceSelect = $("#modalSize").siblings();
            for (var o = 0; o < niceSelect.length; o++) {
                if (niceSelect[o].className != "selector-title") {
                    niceSelect[o].remove()
                }

            }

            let sizeOptions = $("#modalSize").children();
            for (var op = 0; op < sizeOptions.length; op++) {
                sizeOptions[op].remove()
            }
            

            let id = eye[i].firstChild.nextSibling.value;

            $.ajax({
                url: "Shop/GetProductInfo",
                type: "get",
                dataType: "json",
                data: {
                    id: id
                },
                success: function (data) {
                    if (data.data != null) {

                        let noResult = $("#noResult");
                        noResult.addClass("d-none")

                        var Product = data.data
                        var productImges = Product.productImages
                        var productSizeToProduct = Product.productSizeToProducts
                        var imagesArr = [];



                        for (var i in productImges) {
                            for (var t = 0; t < productImges[i].length; t++) {
                                if (productImges[i][t].image !== undefined) {
                                    imagesArr[t] = productImges[i][t].image;
                                }
                            }

                        }

                        var pricesArr = [];
                        var pricesIdArr = [];
                        var sizesArr = [];
                        var quantityArr = [];
                        var productSizeToProductHelper = [];

                        for (var a in productSizeToProduct) {
                            for (var b = 0; b < productSizeToProduct[a].length; b++) {
                                if (productSizeToProduct[a][b].price !== undefined) {

                                    pricesArr[b] = productSizeToProduct[a][b].price
                                    sizesArr[b] = productSizeToProduct[a][b].productSize.size
                                    pricesIdArr[b] = productSizeToProduct[a][b].productSize.id
                                    quantityArr[b] = productSizeToProduct[a][b].quantity
                                    productSizeToProductHelper[b] = productSizeToProduct[a][b];

                                }
                                else if (true) {

                                }
                            }
                        }

                        for (var img = 0; img < imagesArr.length; img++) {

                            let productModalWrapper = $("#productmodalbody .swiper-wrapper");
                            let swiperSlide = document.createElement("div");
                            let newA = document.createElement("a");
                            newA.classList.add("single-img");
                            let newImg = document.createElement("img");
                            newImg.src = "/img/products/" + imagesArr[img];
                            swiperSlide.classList.add("swiper-slide");

                            newA.appendChild(newImg);
                            swiperSlide.appendChild(newA);
                            productModalWrapper.append(swiperSlide);


                        }
                        let modalSize = document.getElementById("modalSize");
                        let modalPrice = document.getElementById("modalPrice");
                        let modalDesc = document.getElementById("modal-product-desc");
                        let productName = document.getElementById("product-name");
                        modalPrice.innerText = pricesArr[0].toFixed(2);
                        productName.innerText = Product.name
                        modalDesc.innerText = Product.shortDesc

                        for (var s = 0; s < sizesArr.length; s++) {
                            let size = document.createElement("option");
                            size.innerText = sizesArr[s];
                            size.value = pricesIdArr[s];
                            modalSize.appendChild(size)
                        }
                        $(".nice-select2").niceSelect();



                        let selector = document.querySelectorAll("#selector-size .nice-select ul li")

                        for (let s = 0; s < selector.length; s++) {

                            selector[s].addEventListener("click", function () {

                                let sizeId = selector[s].getAttribute('data-value');

                                for (let i = 0; i < productSizeToProductHelper.length; i++) {

                                    if (productSizeToProductHelper[i].productSizeId == sizeId) {

                                        modalPrice.innerText = productSizeToProductHelper[i].price.toFixed(2)

                                    }

                                }

                            })

                        }

                        let addCart = document.getElementById("add-to-cart-btn");

                        addCart.addEventListener("click", function () {

                            let sizeId = $("#modalSize").val();
                            let quantity = $("#cart-action-box-value").val();
                            let alert = $("#quantity-left");

                            for (let i = 0; i < productSizeToProductHelper.length; i++) {

                                if (productSizeToProductHelper[i].productSizeId == sizeId) {

                                    if (productSizeToProductHelper[i].quantity >= quantity) {

                                        console.log(sizeId, quantity)
                                        console.log(productSizeToProductHelper[i].quantity, productSizeToProductHelper[i].productSizeId)

                                        alert.addClass("d-none");


                                    }
                                    else {
                                        alert.html(`Only ${productSizeToProductHelper[i].quantity} Lefts`);
                                        alert.removeClass("d-none");
                                    }

                                }

                            }

                        })
                    }
                    else {
                        let noResult = $("#noResult");
                        noResult.removeClass("d-none")
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

    if (document.getElementById("min-value") != undefined && document.getElementById("max-value") != undefined) {
        let max = document.getElementById("min-value");
        let min = document.getElementById("max-value");



        document.getElementById("tester3").addEventListener("click", function (e) {

            let a = 0;
            let b = 0;
            let value = $("#Tester2").val();
            let valueArr = value.split(";");
            for (let i = 0; i < valueArr.length; i++) {


                if (i == 0) {
                    a = +valueArr[i];
                } else {
                    b = +valueArr[i];
                }
            }

            max.value = b;
            min.value = a;
        })
    }
    
    if (document.getElementById("totalRating")!=null) {
        let totalRating = document.getElementById("totalRating").value;
    }
    
    let ratingStars = document.querySelectorAll(".ratingStrars");
    let ratingStarIcon = document.querySelectorAll(".ratingStrars .fa-star");

    let singleProductId;
    if (document.getElementById("singleProductId") != null) {
        singleProductId = document.getElementById("singleProductId").value;
    }
    
    let ratingStarsValue = $(".ratingStarsValue");
    for (let s = 0; s < ratingStars.length; s++) {

        ratingStars[s].addEventListener("click", function (e) {
            e.preventDefault()
            $.getJSON("https://api.ipify.org?format=json", function (data) {


                let userIp = data.ip
                let ratingValue = String(ratingStarsValue[s].value)




                
                $.ajax({
                    url: "../ReviewPost",
                    type: "get",
                    dataType: "json",
                    data: {
                        userIp: userIp,
                        productId: String(singleProductId),
                        ratingValue: ratingValue
                    },
                    success: function (response) {
                        if (response.success != null) {

                            swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
                        }
                        else if (response.changed != null) {

                            swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
                        }
                        else if (response.error != null) {

                            swal("Oops", "Something went wrong", "error");
                        }
                    },
                    error: function (error) {
                        console.log(error);
                    },
                    complete: function () {

                    }
                });





                
            })

           


        })

    }

    if (document.getElementById("totalRating") != null) {
        for (let r = 0; r < totalRating; r++) {

            ratingStarIcon[r].style.fontWeight = "900";
            console.log(ratingStarIcon[r])

        }
    }
    
    let wishlistBtn = document.querySelectorAll(".product-add-action ul li [data-tippy='Add to wishlist']");
    let wishlistPrId = document.querySelectorAll(".product-add-action ul li [data-tippy='Add to wishlist'] .add-to-wishlist-product-id");
    let wishlistIcon = document.querySelectorAll(".product-add-action ul li [data-tippy='Add to wishlist'] i");
    for (let w = 0; w < wishlistBtn.length; w++) {
        wishlistBtn[w].addEventListener("click", function (e) {
            e.preventDefault()
            $.ajax({
                url: location.origin + "/Shop/AddToWishlist",
                type: "get",
                dataType: "json",
                data: {
                    productId: wishlistPrId[w].value,
                },
                success: function (response) {
                    if (response.success == "Added") {

                        swal("Good job!", `You added this product to your wishlist`, "success");
                        wishlistIcon[w].classList.add("added-to-wishlist");
                    }
                    else if (response.changed == "Removed") {
                        swal("Good job!", `You removed this product from your wishlist`, "success");
                        wishlistIcon[w].classList.remove("added-to-wishlist");
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

    if (document.querySelectorAll(".add-to-cart-btn-from-wishlist").length!=0) {
        let addToCartBtn = document.querySelectorAll(".add-to-cart-btn-from-wishlist");
        let addtoCartProductId = document.querySelectorAll(".add-to-cart-product-id");

        for (let c = 0; c < addToCartBtn.length; c++) {
            
            addToCartBtn[c].addEventListener("click", function (e) {
                e.preventDefault()

                $.ajax({
                    url: location.origin + "/Cart/AddToCart",
                    type: "get",
                    dataType: "json",
                    data: {
                        productId: String(addtoCartProductId[c].value)
                    },
                    success: function (response) {
                        if (response.success != null) {

                            swal("Good job!", `The product added successfully to your cart`, "success");
                        }
                        else if (response.changed != null) {

                            swal("Hmm!", `You already added this product to your cart`, "info");
                        }
                        else if (response.error != null) {

                            swal("Oops", "Something went wrong", "error");
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



    }

    
    
});