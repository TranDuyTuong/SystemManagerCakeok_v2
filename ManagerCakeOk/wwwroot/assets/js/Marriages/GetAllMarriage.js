$(document).ready(function () {
    LoadMarriage();
});

//load marriages
function LoadMarriage() {
    $("#BodyData").empty();
    $.ajax({
        url: "/Marriages/GetAllMarriage",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                var Html = '';
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.name + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                Html += '<td> <button style="border: none; background: none; color: blue;" name="BtnEditDistrict" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
                    + '<i class="fas fa-edit"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditStatus" data-bs-toggle="tooltip" data-bs-placement="top" title="Đổi Trạng Thái" />'
                    + '<i class="fas fa-cog"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
        }
    })
}