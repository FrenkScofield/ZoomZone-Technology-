//to retrieve categories from the database with ajax

$(document).ready(function () {
    $(document).on("change", ".categorySelect", function (e) {
        $(".brendSelect").html("");

        var optionVal = $(".categorySelect").val();
        console.log(optionVal);
        if (optionVal != 0) {
            $.ajax({
                url: "/admin/ProductAdd/SearchCategory",
                type: "get",
                data: { id: optionVal },
                success: function (res) {
                    if (res.status == 200) {
                        $(".brendSelect").append('<option>Select</option>');
                        for (var brand of res.data) {
                            $(".brendSelect").append(`<option value="${brand.id}">${brand.name}</option>`);
                        }
                        $(".pvId").append(`<input type ='number' name='Product.CatBraPivotId'  value="${res.data2.id}" />`)
                        $(".brendSelect").change(function () {
                            $(".pvId").append(`<input type ='number' name='BrandId'  value="${$(this).val()}" />`)

                            
                        })
                    }
                    else if (res.status == 404) {
                        console.log("tapilmadi");
                    }
                }
            })
        }
    });
});
