    //$(function () {
    //    $('#table .fa-edit').click(function () {
    //        $(this).parents('tr').find('td').each(function (index) {
    //            $(`[name="${$('thead tr th').eq(index).attr('forinput')}"]`).val($(this).text())
    //        })
    //    })
    //})
$(function () {

    $('#AddCategory').click(function () {
        $('#customFile').attr('required', 'required')
        $('#categoryid').val(0)
        $('#categoryname').val(null)
    })
    $('#AddProduct').click(function () {
        $('#customFile').attr('required', 'required')
        $('#productid').val(0)
        $('#productname').val(null)
    })
    $('#AddAbout').click(function () {
        $('#customFile').attr('required', 'required')
        $('#aboutid').val(0)
        $('#aboutphonenumber').val(null)
        $('#aboutemail').val(null)
        $('#aboutfacebook').val(null)
        $('#aboutinstagram').val(null)
        $('#aboutwhatsapp').val(null)
        $('#aboutinfo').val(null)
    })
    $('#table .fa-edit').click(function () {
        $('#categoryid').val($(this).parents('tr').find('td').eq(0).text())
        $('#categoryname').val($(this).parents('tr').find('td').eq(2).text())
    })
    $('#table .fa-edit').click(function () {
        $('#productid').val($(this).parents('tr').find('td').eq(2).text())
        $('#productname').val($(this).parents('tr').find('td').eq(3).text())
        $('#productprice').val($(this).parents('tr').find('td').eq(4).text())
        $('#productdiscount').val($(this).parents('tr').find('td').eq(5).text())
        $('#productinfo').val($(this).parents('tr').find('td').eq(6).text())
    })
    $('#table .fa-edit').click(function () {
        $('#aboutid').val($(this).parents('tr').find('td').eq(0).text())
        $('#aboutphonenumber').val($(this).parents('tr').find('td').eq(1).text())
        $('#aboutemail').val($(this).parents('tr').find('td').eq(2).text())
        $('#aboutfacebook').val($(this).parents('tr').find('td').eq(3).text())
        $('#aboutinstagram').val($(this).parents('tr').find('td').eq(4).text())
        $('#aboutwhatsapp').val($(this).parents('tr').find('td').eq(5).text())
        $('#aboutinfo').val($(this).parents('tr').find('td').eq(6).text())
    })
})
