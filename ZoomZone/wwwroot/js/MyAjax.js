
//to retrieve categories from the database with ajax
$(document).ready(function () {
    $(document).on("change", ".categorySelect", function (e) {
        $(".brendSelect").html("");

        var optionVal = $(".categorySelect").val();
        if (optionVal != 0) {
            $.ajax({
                url: "/Home/SearchCategory/",
                type: "get",
                data: { id: optionVal },
                success: function (res) {
                    if (res.status == 200) {
                        $(".brendSelect").append('<option>Select</option>');
                        for (var brand of res.data) {
                            $(".brendSelect").append(`<option value="${brand.id}">${brand.name}</option>`);
                        }
                    }
                    else if (res.status == 404) {
                        console.log("tapilmadi");
                    }
                }
            })
        }
    });
});

// process of importing products from database with ajax
$(document).ready(function () {
    $(".search").click(function (e) {
        $(".firstProducCarusel").children().remove();
        e.preventDefault();
        let category = $("#exampleFormControlSelect1").val();
        let brend = $("#exampleFormControlSelect2").val();

        console.log(category, brend);
        $.ajax({
            url: "/Home/ProductAjax",
            type: "POST",
            data: {
                categoryId: category,
                brendId: brend
            },
            success: function (re) {

                $(".firstProducCarusel").children().remove();
                $(".firstProducCarusel").html(re)
            }
        })
    });

});

// Product Click time Open Pophup Add Detalist Section
$(document).ready(function () {
    $(document).on("click", ".eyesButton", function (e) {
        console.log($(e.target));
        if ($(e.target).hasClass("eyesButton")) {
            //  $("#modal_box").children().remove();
            var ID = $(this).data("id");
            console.log(ID);
            $.ajax({
                url: "/home/popup",
                data: { id: ID },
                type: "Post",
                success: function (re) {
                    $("#modal_box").children().remove();
                    $("#modal_box").append(re);
                    $(".baseModal #modal_box").show();
                    $(".baseModal #modal_box .modal-backdrop").show();
                    console.log("aa");
                }
            })

        }


    });
});

// Popup close function
$(document).ready(function () {
    $(document).on("click", ".close", function (e) {
        if ($(e.target).hasClass("close")) {

            $("#modal_box").hide();
            $(".modal-backdrop").hide();
            $("body").removeClass();
            $("body").attr("style", "padding:0px;");
        }
    });
});

//Search by name and price. Function part
$(document).ready(function () {
    let search = document.querySelector('.SearcProductInput');
    let mainpage = document.querySelector('.mainProductList');

    console.log(search)
    search.addEventListener("keyup", (e) => {
        let names = e.target.value;
        console.log(names);
        mainpage.innerHTML = "";
        fetch(`Home/SearchProduct?name=${names}`)
            .then(res => res.json())
            .then(products => products.forEach(product => {
               
                mainpage.innerHTML += `<div class="col-md-3 13">
    <div class="single_product">
        <div class="product_thumb">
           <img src="/img/MyProduct/${product[0].image}" alt="">
            <div class="label_product">
                <span class="label_sale">sale</span>
            </div>
            <div class="quick_button" id="quick_button">
               
                <a data-id="15" data-toggle="modal" data-target="#modal_box" title="" href="/?Id=15" data-original-title="quick view"> <i class="zmdi zmdi-eye eyesButton" data-id="15" 15=""></i></a>
            </div>
        </div>
        <div class="product_content">
            <div class="product_name">
                <h3><a href="product-details.html">${product[0].name}</a></h3>
            </div>
            <div class="product_rating">
                <ul>
                    <li><a href="#"><i class="zmdi zmdi-star-outline"></i></a></li>
                    <li><a href="#"><i class="zmdi zmdi-star-outline"></i></a></li>
                    <li><a href="#"><i class="zmdi zmdi-star-outline"></i></a></li>
                    <li><a href="#"><i class="zmdi zmdi-star-outline"></i></a></li>
                    <li><a href="#"><i class="zmdi zmdi-star-outline"></i></a></li>
                </ul>
            </div>
            <div class="price_box">
                <span class="current_price">${product[0].price}</span>
                <span class="old_price">$70.00</span>
            </div>
            <div class="action_links">
                <ul>
                    <li class="wishlist"><a href="wishlist.html" title="" data-original-title="Add to Wishlist"><i class="fa fa-heart-o" aria-hidden="true"></i></a></li>
                    <li class="add_to_cart"><a href="cart.html" title="" data-original-title="add to cart"><i class="zmdi zmdi-shopping-cart-plus"></i> add to cart</a></li>
                    <li class="compare"><a href="#" title="" data-original-title="compare"><i class="zmdi zmdi-swap"></i></a></li>
                </ul>
            </div>
        </div>
    </div>
</div>`
            }))
            .catch(er => console.log(er))

    });
});

// details page product image carousel section 
$(document).ready(function () {
    let mainImg = document.querySelector('#zoom1')
    let childImgs = document.querySelectorAll('#owl-carousel img')

    childImgs.forEach(img => {
        img.addEventListener('click', () => {
            mainImg.src = img.src
        })
    })
});

//Ad to cart funcition part.
$(document).on("click", ".add_to_cart", function (e) {
    var proId = $(this).attr("data-id");

    $.ajax({
        url: "/Cart/Add/" + proId,
        success: function (res) {
            if (res != null) {
                $(".mini_cart .cart_item").remove();
                $(".mini_cart").prepend(res);
                $("#cart_count").html($(".mini_cart .cart_item").length - 2);
                $(res).remove("text");
                var a = $(res)[1];
                console.log(a);
                $(a).removeAttr("#text");
                console.log($(a));
                //id.value = sum(cart);
                console.log($(res));

                toastr.options = {
                    "closeButton": true,
                    "progressBar": false,
                    "positionClass": "toast-bottom-right",
                    "showDuration": "1000",
                    "timeOut": "3000"
                };
                toastr.success(res.message);
            }
        }
    })
});

//Load More button clicked, the arrival of other products
$(document).on("click", "#load_more_btn", async function () {

    var count = +$(this).attr("data-skip")
    var totalCount = +$(this).attr("data-totalCount")

    fetch("/Home/LodMoreProducts?count=" + count, { method: "POST" })
        .then(res => res.text())
        .then(function (res) {
            $("#load_more").append(res);

            var newCount = count + 8;

            $("#load_more_btn").attr("data-skip", newCount)

            if (newCount >= totalCount) {

                $("#load_more_btn").remove();

            }
        })
});

// Like Click  Add Database new data Section
$(document).ready(function () {
    $(document).on("click", ".Like", function (e) {
        console.log($(e.target));
        if ($(e.target).hasClass("Like")) {
            var a = $(e.target);

            var ID = $(this).data("id");
            console.log(ID);
            $.ajax({
                url: "/home/LikePost",
                data: { proId: ID },
                type: "Post",
                success: function (re) {

                    if (re.success == 200) {
                        console.log($(a));
                        $(a).attr("style", "background-color:red");
                    } else if (re.success == 300) {
                        $(a).attr("style", "background-color:transparent");

                    }
                }
            })

        }

    })


});

// AddToCart  page products total price show part
$(document).ready(function () {
    var pTxt = document.querySelectorAll(".new_price");

    var sum = 0;
    for (var i = 0; i < pTxt.length; i++) {
        sum += parseInt(pTxt[i].innerHTML);
    }
    var amount = document.querySelector(".cart_amount");
    amount.innerHTML = sum + " Azn";
});