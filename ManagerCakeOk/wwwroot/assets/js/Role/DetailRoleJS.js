$(document).ready(function () {
    LoadDataRole();
});

//load data
function LoadDataRole() {
    $("#BodyData").empty();
    var count = 0;
    $.ajax({
        url: "/Roles/DetailRole/",
        type: "get",
        data: {
            Id: $("#IdRole").val()
        },
        success: function (result) {
            //List user role
            $.each(result.l_UserRole, function (key, item) {
                count++;
                var Html = '';
                Html += '<tr id="' + item.idUserRole + '">';
                Html += '<th scope="row">' + count + '</th>';
                Html += '<td>' + item.nameStaff + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                if (item.fileName != null) {
                    switch (item.typeImage) {
                        case "JPG":
                            html += '<td>' + '<img src="data:image/JPG;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "jpg":
                            html += '<td>' + '<img src="data:image/jpg;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "JPEG":
                            html += '<td>' + '<img src="data:image/JPEG;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "jpeg":
                            html += '<td>' + '<img src="data:image/jpeg;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "PNG":
                            html += '<td>' + '<img src="data:image/PNG;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "png":
                            html += '<td>' + '<img src="data:image/png;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "GIF":
                            html += '<td>' + '<img src="data:image/GIF;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                        case "gif":
                            html += '<td>' + '<img src="data:image/gif;base64,' + item.contentFile + '" style="width: 100px;"/>' + '</td>';
                            break;
                    }
                } else {
                    Html += '<td>' + 'Chưa Có Hình' + '</td>';
                }
                Html += '<td>' + item.createDate + '</td>';
                Html += '<td><button style="border: none; background: none; color: blue;" name="BtnEditCity" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
                    + '<i class="fas fa-edit"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
            $("#TxtNameRole").val(result.nameRole);
            $("#TxtSymbolRole").val(result.symbol);
        }
    })
}