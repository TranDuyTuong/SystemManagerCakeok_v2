
//load data
$(document).ready(function () {
    GetTenNewCity();
});

//create city
$("#Btn_Create").click(function () {
    $("#ErrorCity").empty();

    var NameCity = $("#TxtCitys").val();
    if (NameCity.length == 0) {
        $("#ErrorCity").append("Không bỏ trống !");
    } else {
        $.ajax({
            url: "/Citys/CreateCity",
            type: "post",
            data: {
                NameCity: NameCity
            },
            success: function (result) {
                if (result == true) {
                    toastr.success("Thông Báo Thành Công !", "Tạo mới một Tỉnh/Tp thành công.");
                    $("#TxtCitys").val('');
                } else {
                    toastr.error("Thông Báo Lỗi !", "Tạo mới Tỉnh/Tp thất bại");
                }
            }
        })
        GetTenNewCity();
    }
    return;
});

//Create multiple City with file excel
$("#Btn_Modal").click(function () {
    $("#Modal_AddMuplti").show();
});

$("#Btn_Close").click(function () {
    window.location.reload();
});

$("#Btn_FuilterData").click(function () {
    $("#ErrorFile").empty();

    var Vali_File = CheckFileImport();
    if (Vali_File == false) {
        $("#ErrorFile").append("Không được bỏ trống file !");
    } else {
        var files = $("#formFile").prop("files")
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append("FileExcel", files[i]);
        }
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Citys/CreateMupliteCity",
            type: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.error("Thông Báo Lỗi!", "File Truyền Vào Không Phải Là Excel .xlsx");
                        break;
                    case 2:
                        toastr.error("Thông Báo Lỗi!", "Không Có Dữ Liệu Nào Trong File Excel");
                        break;
                    case 3:
                        toastr.success("Thông Báo Thành Công", "Thêm Danh Sách Tỉnh/Tp Thành Công");
                        $("#formFile").val('');
                        break;
                }
                GetTenNewCity()
            }
        })
    }
    return;
});

function CheckFileImport() {
    var CheckData = $("#formFile").val();
    if (CheckData.length == 0) {
        return false;
    } else {
        return true;
    }
}

//funtion get ten new city
function GetTenNewCity() {
    $("#BodyData").empty();
    var count = 0;
    $.ajax({
        url: "/Citys/GetTenCityNew",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                count++;
                var html = "";
                html += '<tr>';
                html += '<th scope="row">' + count + '</th>';
                html += '<td>' + item.nameCity + '</td>'
                if (item.status == true) {
                    html += '<td style="color:green;">Đang Hoạt Động</td>'
                } else {
                    html += '<td style="color:red;">Ngưng Hoạt Động</td>'
                }
                html += '</tr>';
                $("#BodyData").append(html);
            })
        }
    })
}
