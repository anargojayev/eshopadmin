    $(function () {
        $('#table .fa-edit').click(function () {
            $(this).parents('tr').find('td').each(function (index) {
                $(`[name="${$('thead tr th').eq(index).attr('forinput')}"]`).val($(this).text())
            })
        })
    })
$(function () {

    $('#AddCategory').click(function () {
        $('#customFile').attr('required', 'required')
        $('#categoryname').val(null)
        $('#categoryid').val(0)
    })
    $('#AddProduct').click(function () {
        $('#customFile').attr('required', 'required')
        $('#productname').val(null)
        $('#productid').val(0)
    })
    //$('#table .fa-edit').click(function () {
    //    $('#categoryname').val($(this).parents('tr').find('td').eq(2).text())
    //    $('#categoryid').val($(this).parents('tr').find('td').eq(0).text())
    //})
    //$('#table .fa-edit').click(function () {
    //    $('#productname').val($(this).parents('tr').find('td').eq(2).text())
    //    $('#productid').val($(this).parents('tr').find('td').eq(0).text())
    //    $('#productprice').val($(this).parents('tr').find('td').eq(3).text())
    //    $('#productdiscount').val($(this).parents('tr').find('td').eq(4).text())
    //    $('#productinfo').val($(this).parents('tr').find('td').eq(5).text())
    //})
})
