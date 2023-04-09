$(document).ready(function () {
    LoadDataCountry();
});


//load country ten
function LoadDataCountry() {
    $("#BodyData").empty();
    var count = 0;
    $.ajax({
        url: "/Countrys/GetTenCountry",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                count++;
                var html = "";
                html += '<tr>';
                html += '<th scope="row">' + count + '</th>';
                html += '<td>' + item.name + '</td>'
                html += '<td>' + item.createDate + '</td>'
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

//validate name country
function ValidateCountry() {
    var Check = $("#TxtCountry").val();
    if (Check.length == 0 || Check == '') {
        return false;
    } else {
        return true
    }
}

//create country
$("#Btn_Create").click(function () {
    $("#ErrorCountry").empty();
    //check value
    var Check = ValidateCountry();
    if (Check == false) {
        $("#ErrorCountry").append("Vui Lòng Nhập Vào Tên Quốc Gia");
    } else {
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Countrys/CreatePost",
            type: "post",
            data: {
                Name: $("#TxtCountry").val()
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.success("Thông Báo Thành Công!", "Tạo Mới Quốc Gia Thành Công");
                        $("#TxtCountry").val('');
                        LoadDataCountry();
                        break;
                    default:
                        toastr.error("Thông Báo Thất Bại!", "Tạo Mới Quốc Gia Thất Bại");
                        break;
                }
            }
        })
    }
    return;
});

//create country with excel file
$("#Btn_Modal").click(function () {
    $("#Modal_AddMuplti").show();
    $("#ErrorFile").empty();
    $("#formFile").val('');
})

$("#Btn_Close").click(function () {
    $("#Modal_AddMuplti").hide();
    window.location.reload();
})

function CheckFileImport() {
    var CheckData = $("#formFile").val();
    if (CheckData.length == 0) {
        return false;
    } else {
        return true;
    }
}

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
            url: "/Countrys/CreateCoutryExcel",
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
                        toastr.success("Thông Báo Thành Công", "Thêm Danh Sách Quốc Gia Thành Công");
                        $("#formFile").val('');
                        $("#Modal_AddMuplti").hide();
                        break;
                }
                LoadDataCountry();
            }
        })
    }
    return;
})