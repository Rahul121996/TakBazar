

//function _fnCreateProduct() {

//    var SearchVal = $('[name=Search]').val();
//    var request = $.ajax({
//        type: "POST",
//        url: "/Product/Create",
//        data: $('[id$=CreateProduct]').serialize(),
//    });

//    request.done(function (response) {
//        $('[id$=divTable]').html(response);
//        $('[id$=actionMethod]').html('');
//    });

//    request.fail(function (jqXHR, textStatus) {
//        alert("Failed");
//    });
//}


//function _fnEditProduct() {
//    var request = $.ajax({
//        url: "/Product/Edit",
//        data: {
//            ID: $(this).attr('data-id')
//        }

//    });

//    request.done(function (response) {
//        $('[id$=actionMethod]').empty();
//        $('[id$=actionMethod]').html(response);
//    });

//    request.fail(function (jqXHR, textStatus) {
//        alert("Failed");
//    });
//}

//function _fnUpDateProduct() {
//    var request = $.ajax({
//        type: "POST",
//        url: "/Product/Edit",
//        data: $('[id$=EditProduct]').serialize(),
//    });

//    request.done(function (response) {
//        $('[id$=divTable]').html(response);
//        $('[id$=actionMethod]').html('');
//    });

//    request.fail(function (jqXHR, textStatus) {
//        alert("Failed");
//    });
//}


//$('[id$=btnSearch]').click(function () {

//    var SearchVal = $('[name=Search]').val();
//    var request = $.ajax({
//        url: "/Product/ProductTable",
//        //type: "Get",
//        data: { Search: SearchVal },
//        //dataType: "html"
//    });

//    request.done(function (response) {
//        $('[id$=divTable]').html(response);
//    });

//    request.fail(function (jqXHR, textStatus) {
//        alert("Failed");
//    });
//})
//$('[id$=btnNew]').click(function () {
//    var request = $.ajax({
//        url: "/Product/Create",

//    });

//    request.done(function (response) {
//        $('[id$=actionMethod]').html(response);
//    });

//    request.fail(function (jqXHR, textStatus) {
//        alert("Failed");
//    });
//})

